using System;
using FFmpeg.AutoGen;
using System.IO;
using System.Diagnostics;
using FFmpeg.AutoGen.Interop;

namespace FFmpeg
{
    public unsafe class VideoScalingStream : IVideoStream
    {
        #region Private Instance Members

        IVideoStream _source;
        SwsContext* _scalingContext;
        int _width;
        int _height;
        AVPixelFormat _pixelFormat;
        AVPicture _outPict;
        bool _outPictAllocated;

        #endregion

        public VideoScalingStream(IVideoStream source, int width, int height, AVPixelFormat pixelFormat)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            _source = source;
            _width = width;
            _height = height;
            _pixelFormat = pixelFormat;

            _scalingContext = FFmpegInvoke.sws_getContext(
                source.Width, 
                source.Height, 
                source.PixelFormat,
                width, 
                height, 
                pixelFormat, 
                FFmpegInvoke.SWS_BICUBIC, 
                null, 
                null, 
                null);

            if (_scalingContext == null)
                throw new DecoderException("Error getting scaling context");

            fixed (AVPicture* pPicture = &_outPict)
            {
                if (FFmpegInvoke.avpicture_alloc(pPicture, this.PixelFormat, this.Width, this.Height) != 0)
                    throw new DecoderException("Error allocating AVPicture");
            }

            _outPictAllocated = true;
        }

        #region IVideoStream Members

        public int Stride
        {
            get
            {
                fixed (AVPicture* pOutPict = &_outPict)
                {
                    return pOutPict->linesize != null ? pOutPict->linesize[0] : 0;
                }
            }
        }


        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public double FrameRate
        {
            get { return _source.FrameRate; }
        }

        public long FrameCount
        {
            get { return _source.FrameCount; }
        }

        public int FrameSize
        {
            get { return FFmpegInvoke.avpicture_get_size(PixelFormat, Width, Height); }
        }

        public AVPixelFormat PixelFormat
        {
            get { return _pixelFormat; }
        }

        public bool ReadFrame(out byte[] frame)
        {
            frame = null;
            byte[] sourceFrame;

            if (!_source.ReadFrame(out sourceFrame))
                return false;

            frame = new byte[FrameSize];

            fixed (AVPicture* pOutPict = &_outPict)
            {
                fixed (byte* pOrig = sourceFrame)
                {
                    AVPicture sourcePict;
                    int size = FFmpegInvoke.avpicture_fill(
                        &sourcePict, 
//                        sourceFrame, 
                        pOrig,
                        _source.PixelFormat, 
                        _source.Width,
                        _source.Height
                        );

                    Debug.Assert(size == sourceFrame.Length);

                    if (FFmpegInvoke.sws_scale(
                        _scalingContext, 
                        &sourcePict.data_0, 
                        sourcePict.linesize, 
                        0,
                        _source.Height,
                        &pOutPict->data_0, 
                        pOutPict->linesize
                        ) < 0)
                        throw new DecoderException("Error scaling output");

                    // copy data into our managed buffer
                    if (_outPict.data_0 == null)
                    {
                        frame = null;
                        return true;
                    }

                    fixed (byte* pFrame = frame)
                    {
                        if (FFmpegInvoke.avpicture_layout(
                            pOutPict,
                            PixelFormat,
                            Width,
                            Height,
                            (sbyte*) pFrame,
                            frame.Length
                                ) < 0)
                            throw new DecoderException("Error copying decoded frame into managed memory");
                    }

                }

            }

            return true;
        }

        #endregion

        #region IMediaStream Members

        public TimeSpan Duration
        {
            get { return _source.Duration; }
        }

        public TimeSpan Timestamp
        {
            get { return _source.Timestamp; }
        }

        public long Position
        {
            get { return _source.Position; }
        }

        public long Pts
        {
            get { return _source.Pts; }
        }

        public long Dts
        {
            get { return _source.Dts; }
        }

        public long Length
        {
            get { throw new NotImplementedException(); }
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public TimeSpan Seek(TimeSpan offset, SeekOrigin origin)
        {
            return _source.Seek(offset, origin);
        }

        public long Seek(long offset, SeekOrigin origin)
        {
            return _source.Seek(offset, origin);
        }

        public int UncompressedBytesPerSecond
        {
            get { return (int)Math.Ceiling(FrameRate * FrameSize); }
        }

        #endregion

        public void Dispose()
        {
            Dispose(true);
        }

        protected void Dispose(bool disposing)
        {
            if (_scalingContext != null)
            {
                FFmpegInvoke.sws_freeContext(_scalingContext);
                _scalingContext = null;
            }

            if (_outPictAllocated)
            {
                fixed (AVPicture* pPicture = &_outPict)
                {
                    FFmpegInvoke.avpicture_free(pPicture);
                }
            }
        }
    }
}
