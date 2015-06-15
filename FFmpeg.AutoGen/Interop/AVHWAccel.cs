using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVHWAccel
    {
        public sbyte* name;
        public AVMediaType type;
        public AVCodecID id;
        public AVPixelFormat pix_fmt;
        public int capabilities;
        public AVHWAccel* next;
        public IntPtr alloc_frame; // Func<AVCodecContext*, AVFrame*, int>
        public IntPtr start_frame; // Func<AVCodecContext*, byte*, uint, int>
        public IntPtr decode_slice; // Func<AVCodecContext*, byte*, uint, int>
        public IntPtr end_frame; // Func<AVCodecContext*, int>
        public int frame_priv_data_size;
        public IntPtr decode_mb; // Action<MpegEncContext*>
        public IntPtr init; // Func<AVCodecContext*, int>
        public IntPtr uninit; // Func<AVCodecContext*, int>
        public int priv_data_size;
    }
}