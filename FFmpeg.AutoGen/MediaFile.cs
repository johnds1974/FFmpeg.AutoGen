using System;
using System.Collections.Generic;
using FFmpeg.AutoGen;
using System.IO;
using System.Collections.ObjectModel;
using FFmpeg.AutoGen.Interop;

namespace FFmpeg.AutoGen
{
    public unsafe class MediaFile : IDisposable
    {
        private AVFormatContext* _formatContext;
        private bool _disposed = false;
        private SortedList<int, DecoderStream> _streams;
        private string _filename;

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public ReadOnlyCollection<DecoderStream> Streams
        {
            get { return new ReadOnlyCollection<DecoderStream>(_streams.Values); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Filename
        {
            get { return _filename; }
        }

        /// <summary>
        /// 
        /// </summary>
        public AVFormatContext* FormatContext
        {
            get { return _formatContext; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FileFormat
        {
            get
            {
                return new string(_formatContext->iformat->name);
            }
        }

        /// <summary>
        /// Duration of the stream
        /// </summary>
        public TimeSpan Duration
        {
            get { return new TimeSpan((long)(RawDuration * 1e7)); }
        }

        /// <summary>
        /// 
        /// </summary>
        public double RawDuration
        {
            get
            {
                double duration = (double)(_formatContext->duration / (double)FFmpegInvoke.AV_TIME_BASE);
                if (duration < 0)
                    duration = 0;
                return duration;
            }
        }

        #endregion

        static MediaFile()
        {
            // Register all codecs and protocols
            FFmpegInvoke.av_register_all();
#if DEBUG
            FFmpegInvoke.av_log_set_level(1000);
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        public MediaFile(FileInfo file) : this(file.FullName)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="codecType"></param>
        public MediaFile(FileStream file, AVMediaType codecType) : this(file.Name)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public unsafe MediaFile(string filename)
        {
            if (String.IsNullOrEmpty(filename))
                throw new ArgumentNullException("filename");

            _filename = filename;

            // Allocate a FormatContext...
            _formatContext = FFmpegInvoke.avformat_alloc_context();

            // Open the file with FFmpeg
            fixed (AVFormatContext** pFormatContext = &_formatContext)
            {
                if (FFmpegInvoke.avformat_open_input(pFormatContext, filename, null, null) != 0)
                    throw new DecoderException("Couldn't open file");
            }

            if (FFmpegInvoke.avformat_find_stream_info(_formatContext, null) != 0)
                throw new DecoderException("Couldn't find stream info");

            if (_formatContext->nb_streams < 1)
                throw new DecoderException("No streams found");

            _streams = new SortedList<int, DecoderStream>();

            for (int i = 0; i < _formatContext->nb_streams; i++)
            {
                AVStream stream = *_formatContext->streams[i];

                switch (stream.codec->codec_type)
                {
                    case AVMediaType.AVMEDIA_TYPE_VIDEO:
                        _streams.Add(i, new VideoDecoderStream(this, ref stream));
                        break;

                    case AVMediaType.AVMEDIA_TYPE_AUDIO:
                        _streams.Add(i, new AudioDecoderStream(this, ref stream));
                        break;

                    default:
                        _streams.Add(i, null);
                        break;
                }
            }
        }

        internal void EnqueueNextPacket()
        {
            AVPacket packet = new AVPacket();

            FFmpegInvoke.av_init_packet(&packet);

            if (FFmpegInvoke.av_read_frame(_formatContext, &packet) < 0)
                throw new System.IO.EndOfStreamException();

            DecoderStream dest = null;
            if (_streams.TryGetValue(packet.stream_index, out dest))
                dest.PacketQueue.Enqueue(packet);
            else
                FFmpegInvoke.av_free_packet(&packet);
        }

        ~MediaFile()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;

                if (disposing)
                {
                    _streams = null;
                }

                fixed (AVFormatContext** p = &_formatContext)
                {
                    FFmpegInvoke.avformat_close_input(p);
                }

            }
        }
    }
}
