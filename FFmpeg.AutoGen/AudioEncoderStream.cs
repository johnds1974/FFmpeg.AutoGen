#region LGPL License
//
// AudioEncoderStream.cs
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
using System.IO;
using FFmpeg.Audio;
using FFmpeg.AutoGen;
using FFmpeg.AutoGen.Interop;

namespace FFmpeg
{
    public unsafe class AudioEncoderStream : Stream
    {
        #region Private Instance Variables

        private AVFormatContext* _avFormatCtx;
        private AVCodecContext* _avCodecCtx;
        private AVStream _avStream;
        private bool _disposed;
        private bool _fileOpen;
        private string _filename;
        private FifoMemoryStream _buffer;
        private int _totalWritten;

        #endregion

        #region Properties

        public int FrameSize
        {
            get { return _avCodecCtx->frame_size * _avCodecCtx->channels * 2; } //2 == Sample Size (16-bit)
        }

        public string Filename { get { return _filename; } }

        public override bool CanRead { get { return false; } }
        public override bool CanSeek { get { return false; } }
        public override bool CanWrite { get { return true; } }

        public override long Length { get { return _totalWritten; } }

        public override long Position
        {
            get { return Length; }
            set { throw new NotSupportedException(); }
        }

        #endregion

        public AudioEncoderStream(string Filename, AudioCodec Codec, int Bitrate, int SampleRate, int Channels, bool VBR)
            : this(Filename, new EncoderInformation(Codec, Bitrate, SampleRate, Channels, VBR)) { }

        public AudioEncoderStream(string Filename, EncoderInformation EncoderInfo)
        {
            // Initialize instance variables
            _filename = Filename;
            _disposed = _fileOpen = false;
            _buffer = new FifoMemoryStream();

            // Open FFmpeg
            FFmpegInvoke.av_register_all();

            // Initialize the output format context
            _avFormatCtx = FFmpegInvoke.avformat_alloc_context();

            // Get output format
            _avFormatCtx->oformat = FFmpegInvoke.av_guess_format(EncoderInfo.Codec.ShortName, null, null);
            if (_avFormatCtx->oformat != null)
                throw new EncoderException("Could not find output format.");

//            FFmpegInvoke.av_set_parameters(ref _avFormatCtx, null);

            // Initialize the new output stream
            AVStream* stream = FFmpegInvoke.avformat_new_stream(_avFormatCtx, _avCodecCtx->codec);
            if (stream == null)
                throw new EncoderException("Could not alloc output audio stream");

            _avStream = *stream;

            // Initialize output codec context
            _avCodecCtx = _avStream.codec;

            _avCodecCtx->codec_id = EncoderInfo.Codec.CodecID;
            _avCodecCtx->codec_type = AVMediaType.AVMEDIA_TYPE_AUDIO;
            _avCodecCtx->sample_rate = EncoderInfo.SampleRate;
            _avCodecCtx->channels = EncoderInfo.Channels;
            _avCodecCtx->bits_per_coded_sample = EncoderInfo.SampleSize;
            _avCodecCtx->bit_rate = EncoderInfo.Bitrate;

            if (EncoderInfo.VBR)
            {
                _avCodecCtx->flags |= FFmpegInvoke.CODEC_FLAG_QSCALE;
                _avCodecCtx->global_quality = EncoderInfo.FFmpegQualityScale;
            }

            // Open codec
            AVCodec* outCodec = FFmpegInvoke.avcodec_find_encoder(_avCodecCtx->codec_id);
            if (outCodec == null)
                throw new EncoderException("Could not find encoder");

            if (FFmpegInvoke.avcodec_open2(_avCodecCtx, outCodec, null) < 0)
                throw new EncoderException("Could not open codec.");

            // Open and prep file
            if (FFmpegInvoke.avio_open(
                &_avFormatCtx->pb, 
                _filename, 
                FFmpegInvoke.AVIO_FLAG_READ_WRITE
                ) < 0)
                throw new EncoderException("Could not open output file.");

            _fileOpen = true;

            FFmpegInvoke.avformat_write_header(_avFormatCtx, null);
        }

        public override void Flush()
        {
            while (_buffer.Length > 0)
                EncodeAndWritePacket();
        }

        private void EncodeAndWritePacket()
        {
            byte[] frameBuffer = new byte[FrameSize];
            _buffer.Read(frameBuffer, 0, frameBuffer.Length);

            fixed (byte* pcmSamples = frameBuffer)
            {
                if (_disposed)
                    throw new ObjectDisposedException(this.ToString());

                AVPacket outPacket = new AVPacket();
                FFmpegInvoke.av_init_packet(&outPacket);

                byte[] buffer = new byte[FFmpegInvoke.FF_MIN_BUFFER_SIZE];
                fixed (byte* encodedData = buffer)
                {
                    try
                    {
                        outPacket.size = FFmpegInvoke.avcodec_encode_audio(
                            _avCodecCtx, 
                            encodedData, 
                            FFmpegInvoke.FF_MIN_BUFFER_SIZE, 
                            (short*)pcmSamples
                            );
                        outPacket.pts = _avCodecCtx->coded_frame->pts;
                        outPacket.flags |= FFmpegInvoke.AV_PKT_FLAG_KEY;
                        outPacket.stream_index = _avStream.index;
                        outPacket.data = encodedData;

                        if (outPacket.size > 0)
                        {
                            if (FFmpegInvoke.av_write_frame(_avFormatCtx, &outPacket) != 0)
                                throw new IOException("Error while writing encoded audio frame to file");
                        }
                    }
                    finally
                    {
                        FFmpegInvoke.av_free_packet(&outPacket);
                    }
                }
            }
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (_disposed)
                throw new ObjectDisposedException(this.ToString());

            _buffer.Write(buffer, offset, count);

            while (_buffer.Length >= FrameSize)
                EncodeAndWritePacket();

            _totalWritten += count;
        }

        protected override void Dispose(bool Disposing)
        {
            if (!_disposed)
            {
                if (Disposing)
                {
                    _filename = null;
                }

                if (_avCodecCtx->codec != null)
                    FFmpegInvoke.avcodec_close(_avCodecCtx);

                for (int i = 0; i < _avFormatCtx->nb_streams; i++)
                {
                    var ptr = (IntPtr)_avFormatCtx->streams[i]->codec;
                    FFmpegInvoke.av_freep((void*)ptr);

                    ptr = (IntPtr)_avFormatCtx->streams[i];
                    FFmpegInvoke.av_freep((void*)ptr);
                }

                if (_fileOpen)
                    FFmpegInvoke.avio_close(_avFormatCtx->pb);
            }

            _disposed = true;
        }

        #region Unsupported Stream Methods

        public override int Read(byte[] buffer, int offset, int count) { throw new NotSupportedException(); }
        public override long Seek(long offset, SeekOrigin origin) { throw new NotSupportedException(); }
        public override void SetLength(long value) { throw new NotSupportedException(); }

        #endregion
    }
}
