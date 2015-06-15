using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVOptionRanges
    {
        public AVOptionRange** range;
        public int nb_ranges;
        public int nb_components;
    }
}