#region LGPL License
//
// AudioDecoderStream.cs
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
using FFmpeg.AutoGen;
using FFmpeg.AutoGen.Interop;

namespace FFmpeg
{
    public unsafe class AudioDecoderStream : DecoderStream, IAudioStream
    {
        internal AudioDecoderStream(MediaFile file, ref AVStream stream)
            : base(file, ref stream)
        {
            _buffer = new byte[FFmpegInvoke.FF_MIN_BUFFER_SIZE];
        }

        /// <summary>
        /// Number of channels in the audio stream.
        /// </summary>
        public int Channels
        {
            get { return _avCodecCtx->channels; }
        }

        /// <summary>
        /// Sample rate of the stream in bits per second
        /// </summary>
        public int SampleRate
        {
            get { return _avCodecCtx->sample_rate; }
        }

        /// <summary>
        /// Returns the sample size in bits.
        /// </summary>
        public int SampleSize
        {
            get
            {
                int bytesPerSample = FFmpegInvoke.av_get_bytes_per_sample(_avCodecCtx->sample_fmt);

                return bytesPerSample;

                switch (_avCodecCtx->sample_fmt)
                {
                    case AVSampleFormat.AV_SAMPLE_FMT_U8:
                        return 8;
                    case AVSampleFormat.AV_SAMPLE_FMT_S16:
                        return 16;
                    //case AVSampleFormat.SAMPLE_FMT_S24:
                    //    return 24;
                    case AVSampleFormat.AV_SAMPLE_FMT_S32:
                        return 32;
                    default:
                        throw new Exception("Unknown sample size.");
                }
            }
        }

        /// <summary>
        /// Average bytes per second of the stream
        /// </summary>
        public override int UncompressedBytesPerSecond
        {
            get { return (Channels * SampleRate * SampleSize) / 8; }
        }

        protected override bool DecodePacket(ref AVPacket packet)
        {
            int totalOutput = 0;

            // Copy the data pointer to we can muck with it
            int packetSize = packet.size;
            byte* packetData = (byte*)packet.data;

            // May be necessary to loop multiple times if more than one frame is in the compressed packet
            fixed (byte* pBuffer = _buffer)
            do
            {
                if (_disposed)
                {
                    _bufferUsedSize = 0;
                    return false;
                }

                int outputBufferUsedSize = _buffer.Length - totalOutput; //Must be initialized before sending in as per docs

                short* pcmWritePtr = (short*)(pBuffer + totalOutput);

                fixed (AVPacket* pPacket = &packet)
                {
                    int usedInputBytes = FFmpegInvoke.avcodec_decode_audio3(
                        _avCodecCtx,
                        pcmWritePtr,
                        &outputBufferUsedSize,
                        pPacket
                        );

                    if (usedInputBytes < 0) //Error in packet, ignore packet
                        break;


                    if (outputBufferUsedSize > 0)
                        totalOutput += outputBufferUsedSize;

                    packetData += usedInputBytes;
                    packetSize -= usedInputBytes;
                }
            }
            while (packetSize > 0);

            _bufferUsedSize = totalOutput;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sample"></param>
        /// <returns></returns>
        public bool ReadSample(out byte[] sample)
        {
            sample = new byte[SampleSize];

            int count = Read(sample, 0, SampleSize);

            if (count <= 0)
            {
                sample = null;
                return false;
            }

            return true;
        }
    }
}
