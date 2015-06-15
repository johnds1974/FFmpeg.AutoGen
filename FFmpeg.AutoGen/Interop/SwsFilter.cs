using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct SwsFilter
    {
        public SwsVector* lumH;
        public SwsVector* lumV;
        public SwsVector* chrH;
        public SwsVector* chrV;
    }
}