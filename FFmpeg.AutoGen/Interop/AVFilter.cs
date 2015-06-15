using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFilter
    {
        public sbyte* name;
        public sbyte* description;
        public AVFilterPad* inputs;
        public AVFilterPad* outputs;
        public AVClass* priv_class;
        public int flags;
        public IntPtr init; // Func<AVFilterContext*, int>
        public IntPtr init_dict; // Func<AVFilterContext*, AVDictionary**, int>
        public IntPtr uninit; // Action<AVFilterContext*>
        public IntPtr query_formats; // Func<AVFilterContext*, int>
        public int priv_size;
        public AVFilter* next;
        public IntPtr process_command; // Func<AVFilterContext*, String, String, String, int, int, int>
        public IntPtr init_opaque; // Func<AVFilterContext*, void*, int>
    }
}