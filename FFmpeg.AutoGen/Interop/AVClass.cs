using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVClass
    {
        public sbyte* class_name;
        public IntPtr item_name; // Func<void*, String>
        public AVOption* option;
        public int version;
        public int log_level_offset_offset;
        public int parent_log_context_offset;
        public IntPtr child_next; // Func<void*, void*, void*>
        public IntPtr child_class_next; // Func<AVClass*, AVClass*>
        public Anon5 category;
        public IntPtr get_category; // Func<void*, AVClassCategory>
        public IntPtr query_ranges; // Func<AVOptionRanges**, void*, String, int, int>
    }
}