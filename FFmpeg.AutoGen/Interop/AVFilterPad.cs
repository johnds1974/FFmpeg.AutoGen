using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFilterPad
    {
        public sbyte* name;
        public AVMediaType type;
        public int min_perms;
        public int rej_perms;
        public IntPtr start_frame; // Func<AVFilterLink*, AVFilterBufferRef*, int>
        public IntPtr get_video_buffer; // Func<AVFilterLink*, int, int, AVFrame*>
        public IntPtr get_audio_buffer; // Func<AVFilterLink*, int, AVFrame*>
        public IntPtr end_frame; // Func<AVFilterLink*, int>
        public IntPtr draw_slice; // Func<AVFilterLink*, int, int, int, int>
        public IntPtr filter_frame; // Func<AVFilterLink*, AVFrame*, int>
        public IntPtr poll_frame; // Func<AVFilterLink*, int>
        public IntPtr request_frame; // Func<AVFilterLink*, int>
        public IntPtr config_props; // Func<AVFilterLink*, int>
        public int needs_fifo;
        public int needs_writable;
    }
}