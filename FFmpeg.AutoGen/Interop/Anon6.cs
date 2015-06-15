using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct Anon6
    {
        public long i64;
        public double dbl;
        public sbyte* str;
        public AVRational q;
    }
}