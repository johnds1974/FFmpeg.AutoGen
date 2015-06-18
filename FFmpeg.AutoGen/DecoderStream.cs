#region LGPL License
//
// DecoderStream.cs
//
// Author:
//   Justin Cherniak (justin.cherniak@gmail.com
//
// Copyright (C) 2008 Justin Cherniak
//
// This library is free software; you can redistribute it and/or modify
// it  under the terms of the GNU Lesser General Public License version
// 2.1 as published by the Free Software Foundation.
//
// This library is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307
// USA
//
#endregion

using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using FFmpeg.AutoGen.Interop;

namespace FFmpeg.AutoGen
{
    public unsafe abstract class DecoderStream : Stream, IMediaStream
    {
        #region Fields

        protected MediaFile _mediaFile;
        protected AVCodecContext* _avCodecCtx;
        protected AVStream _avStream;
        protected uint _streamIdx;
        protected bool _disposed;
        protected byte[] _buffer = null;
        protected int _bufferUsedSize = 0;
        protected long _position;
        private bool _codecOpen = false;
        private TimeSpan _timestamp = TimeSpan.Zero;

        private Queue<AVPacket> m_packetQueue = new Queue<AVPacket>();

        private long m_rawPts;
        private long m_rawDts;

        #endregion

        #region Properties

        internal Queue<AVPacket> PacketQueue
        {
            get { return m_packetQueue; }
        }

        public override long Length
        {
            get { return (long)(Math.Ceiling(Duration.TotalSeconds * UncompressedBytesPerSecond)); }
        }

        public TimeSpan Duration
        {
            get { return _mediaFile.Duration; }
        }

        public TimeSpan Timestamp
        {
            get { return _timestamp; }
        }

        public abstract int UncompressedBytesPerSecond { get; }

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanSeek
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override long Position
        {
            get { return _position; }
            set { this.Seek(value, SeekOrigin.Begin); }
        }

        public long Pts
        {
            get { return m_rawPts; }
        }

        public long Dts
        {
            get { return m_rawDts; }
        }

        #endregion

        #region Constructors / destructor

        protected DecoderStream(MediaFile file, AVStream* stream)
        {
            // Initialize instance variables
            _disposed = false;
            _position = _bufferUsedSize = 0;
            _mediaFile = file;
            _avStream = *stream;

            _avCodecCtx = _avStream.codec;

            // Open the decoding codec
            AVCodec* avCodec = FFmpegInvoke.avcodec_find_decoder(_avCodecCtx->codec_id);
            if (avCodec == null)
                throw new DecoderException("No decoder found");

            if (FFmpegInvoke.avcodec_open2(_avCodecCtx, avCodec, null) < 0)
                throw new DecoderException("Error opening codec");

            _codecOpen = true;
        }

        protected DecoderStream(MediaFile file, ref AVStream stream)
        {
            // Initialize instance variables
            _disposed = false;
            _position = _bufferUsedSize = 0;
            _mediaFile = file;
            _avStream = stream;

            _avCodecCtx = _avStream.codec;

            // Open the decoding codec
            AVCodec* avCodec = FFmpegInvoke.avcodec_find_decoder(_avCodecCtx->codec_id);
            if (avCodec == null)
                throw new DecoderException("No decoder found");

            if (FFmpegInvoke.avcodec_open2(_avCodecCtx, avCodec, null) < 0)
                throw new DecoderException("Error opening codec");

            _codecOpen = true;
        }

        ~DecoderStream()
        {
            Dispose(false);
        }

        #endregion

        #region Methods

        public override int Read(byte[] buffer, int offset, int count)
        {
            int totalRead = 0;

            while (count > 0)
            {
                if (_bufferUsedSize == 0)
                {
                    try
                    {
                        ReadNextPacket();
                    }
                    catch (EndOfStreamException)
                    {
                        break;
                    }
                }

                if (_bufferUsedSize > 0)
                {
                    int len = Math.Min(count, _bufferUsedSize);

                    Buffer.BlockCopy(_buffer, 0, buffer, 0, len);

//                    Utils.CopyArray(_buffer, 0, buffer, offset, len);

                    _bufferUsedSize -= len;
                    offset += len;
                    count -= len;
                    totalRead += len;

                    if (_bufferUsedSize > 0)
                    {
//                        Utils.CopyArray(_buffer, len, _buffer, 0, _bufferUsedSize);
                        Buffer.BlockCopy(_buffer, len, _buffer, 0, _bufferUsedSize);
                    }
                }

                Debug.Assert(_bufferUsedSize >= 0);
            }

            _position += totalRead;
            _timestamp += TimeSpan.FromSeconds(totalRead / UncompressedBytesPerSecond);

            if (totalRead == 0)
                return -1;

            return totalRead;
        }

        private void ReadNextPacket()
        {
            if (_position >= Length)
                throw new System.IO.EndOfStreamException();

            if (_disposed)
                return;

            AVPacket packet;
            bool retry = false;
            do
            {
                while (PacketQueue.Count == 0)
                    _mediaFile.EnqueueNextPacket();

                packet = PacketQueue.Dequeue();

                try
                {
                    retry = !DecodePacket(ref packet);
                }
                finally
                {
                    FFmpegInvoke.av_free_packet(&packet);
                }
            } while (retry);

            m_rawDts = packet.dts;
            m_rawPts = packet.pts;
        }
        
        protected abstract bool DecodePacket(ref AVPacket packet);

        public override long Seek(long offset, SeekOrigin origin)
        {
            TimeSpan position = Seek(TimeSpan.FromSeconds(offset / UncompressedBytesPerSecond), origin);

            return (long)(position.TotalSeconds * UncompressedBytesPerSecond);
        }

        public TimeSpan Seek(TimeSpan offset, SeekOrigin origin)
        {
            TimeSpan newPosition = TimeSpan.Zero;

            switch (origin)
            {
                case SeekOrigin.Begin:
                    newPosition = offset;
                    break;
                case SeekOrigin.Current:
                    newPosition = offset + Timestamp;
                    break;
                case SeekOrigin.End:
                    newPosition = Duration - Timestamp;
                    break;
            }

            if (newPosition < TimeSpan.Zero)
                newPosition = TimeSpan.Zero;
            else if (newPosition > Duration)
                newPosition = Duration;

            bool backward = newPosition > Timestamp;

//            AVSEEK_FLAG flags = AVSEEK_FLAG.Any | (backward ? AVSEEK_FLAG.Backward: 0);
            int flags = FFmpegInvoke.AVSEEK_FLAG_ANY | (backward ? FFmpegInvoke.AVSEEK_FLAG_BACKWARD : 0);

            long position = (long)(newPosition.TotalSeconds * FFmpegInvoke.AV_TIME_BASE);

            if (FFmpegInvoke.av_seek_frame(_mediaFile.FormatContext, -1, position, flags) < 0)
            {
                _position = Length;
                _timestamp = Duration;
                return Duration;
            }

            FFmpegInvoke.avcodec_flush_buffers(_avCodecCtx);

            _timestamp = offset;
            _position = (long)(_timestamp.TotalSeconds * UncompressedBytesPerSecond);

            return _timestamp;
        }

        public override void Flush()
        {
            throw new NotSupportedException();
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;

                // BROKEN: Throwing exception on video codec close with MPEG4
//                if (m_codecOpen)
//                    FFmpegInvoke.avcodec_close(ref m_avCodecCtx);
            }
        }

        #endregion
    }
}
