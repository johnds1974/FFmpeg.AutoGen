using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFilterInOut
    {
        public sbyte* name;
        public AVFilterContext* filter_ctx;
        public int pad_idx;
        public AVFilterInOut* next;
    }
}