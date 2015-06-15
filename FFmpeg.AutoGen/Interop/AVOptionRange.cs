using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVOptionRange
    {
        public sbyte* str;
        public double value_min;
        public double value_max;
        public double component_min;
        public double component_max;
        public int is_range;
    }
}