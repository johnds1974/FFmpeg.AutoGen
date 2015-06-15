#region LGPL License
//
// VideoDecoderStream.cs
//
// Author:
//   Tim Jones (tim@roastedamoeba.com)
//   Justin Cherniak (justin.cherniak@gmail.com)
//
// Copyright (C) 2008 Tim Jones, Justin Cherniak
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
    public unsafe class VideoDecoderStream : DecoderStream, IVideoStream
    {
        #region Fields

        private AVFrame* _avFrame = null;
        private AVPicture _avPicture;
        private bool _avPicture_allocated = false;
        private byte[] _frameBuffer;

        #endregion

        #region Properties

        public int Stride
        {
            get
            {
                fixed (AVPicture* pOutPict = &_avPicture)
                {
                    return pOutPict->linesize != null ? pOutPict->linesize[0] : 0;
                }
            }
        }

        public int Width
        {
            get { return _avCodecCtx->width; }
        }

        public int Height
        {
            get { return _avCodecCtx->height; }
        }

        /// <summary>
        /// Frame rate of video stream in frames/second
        /// </summary>
        public double FrameRate
        {
            get
            {
                if (_avStream.r_frame_rate.den > 0 && _avStream.r_frame_rate.num > 0)
                    return _avStream.r_frame_rate.num / _avStream.r_frame_rate.den;
                else
                    return 1 / _avCodecCtx->time_base.num;
            }
        }

        public long FrameCount
        {
            get { return (long)(FrameRate * _mediaFile.RawDuration); }
        }

        /// <summary>
        /// Size of one frame in bytes
        /// </summary>
        public int FrameSize
        {
            get { return _buffer.Length; }
        }

        public override int UncompressedBytesPerSecond
        {
            get { return (int)Math.Ceiling(FrameRate * FrameSize); }
        }

        public AVPixelFormat PixelFormat
        {
            get { return _avCodecCtx->pix_fmt; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new VideoDecoderStream over a specific filename.
        /// </summary>
        /// <param name="file">File to decode</param>
        /// <param name="stream"></param>
        internal VideoDecoderStream(MediaFile file, ref AVStream stream)
            : base(file, ref stream)
        {
            // allocate video frame
            _avFrame = FFmpegInvoke.avcodec_alloc_frame();

            fixed (AVPicture* pPicture = &_avPicture)
            {
                if (FFmpegInvoke.avpicture_alloc(
                    pPicture,
                    _avCodecCtx->pix_fmt,
                    _avCodecCtx->width,
                    _avCodecCtx->height
                        ) != 0)
                    throw new DecoderException("Error allocating AVPicture");
            }

            _avPicture_allocated = true;

            int buffersize = FFmpegInvoke.avpicture_get_size(_avCodecCtx->pix_fmt, _avCodecCtx->width, _avCodecCtx->height);
            if (buffersize <= 0)
                throw new DecoderException("Invalid size returned by avpicture_get_size");

            _buffer = new byte[buffersize];
        }

        #endregion

        #region Methods

        protected override bool DecodePacket(ref AVPacket packet)
        {
            // decode video frame
            int frameFinished = 0;

            fixed (AVPacket* pPacket = &packet)
            {
                int byteCount = FFmpegInvoke.avcodec_decode_video2(
                    _avCodecCtx,
                    _avFrame,
                    &frameFinished,
                    pPacket
                    );

                if (byteCount < 0)
                    throw new DecoderException("Couldn't decode frame");
            }

            // copy data into our managed buffer
            if (_avFrame->data_0 == null)
                _bufferUsedSize = 0;
            else
                fixed (byte* buff = _buffer)
                {
                    _bufferUsedSize = FFmpegInvoke.avpicture_layout((AVPicture*) _avFrame, PixelFormat, Width, Height,
                                                                    (sbyte*)buff, _buffer.Length);
                }

            if (_bufferUsedSize < 0)
                throw new DecoderException("Error copying decoded frame into managed memory");

            return frameFinished == 1;
        }

        public bool ReadFrame(out byte[] frame)
        {
            if (_frameBuffer == null)
                _frameBuffer = new byte[FrameSize];

            // read whole frame from the stream
            if (Read(_frameBuffer, 0, FrameSize) <= 0)
            {
                frame = null;
                return false;
            }
            else
            {
                frame = _frameBuffer;
                return true;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (_avFrame != null)
            {
                FFmpegInvoke.av_free(_avFrame);
                _avFrame = null;
            }

            if (_avPicture_allocated)
            {
                fixed (AVPicture* pPicture = &_avPicture)
                {
                    FFmpegInvoke.avpicture_free(pPicture);
                    _avPicture_allocated = false;
                }
            }

            base.Dispose(disposing);
        }

        #endregion
    }
}
