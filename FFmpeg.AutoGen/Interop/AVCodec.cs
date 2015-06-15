using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVCodec
    {
        public sbyte* name;
        public sbyte* long_name;
        public AVMediaType type;
        public AVCodecID id;
        public int capabilities;
        public AVRational* supported_framerates;
        public AVPixelFormat* pix_fmts;
        public int* supported_samplerates;
        public AVSampleFormat* sample_fmts;
        public ulong* channel_layouts;
        public byte max_lowres;
        public AVClass* priv_class;
        public AVProfile* profiles;
        public int priv_data_size;
        public AVCodec* next;
        public IntPtr init_thread_copy; // Func<AVCodecContext*, int>
        public IntPtr update_thread_context; // Func<AVCodecContext*, AVCodecContext*, int>
        public AVCodecDefault* defaults;
        public IntPtr init_static_data; // Action<AVCodec*>
        public IntPtr init; // Func<AVCodecContext*, int>
        public IntPtr encode_sub; // Func<AVCodecContext*, byte*, int, AVSubtitle*, int>
        public IntPtr encode2; // Func<AVCodecContext*, AVPacket*, AVFrame*, int*, int>
        public IntPtr decode; // Func<AVCodecContext*, void*, int*, AVPacket*, int>
        public IntPtr close; // Func<AVCodecContext*, int>
        public IntPtr flush; // Action<AVCodecContext*>
    }
}