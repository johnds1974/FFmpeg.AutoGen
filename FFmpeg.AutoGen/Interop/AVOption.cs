using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVOption
    {
        public sbyte* name;
        public sbyte* help;
        public int offset;
        public AVOptionType type;
        public Anon6 default_val;
        public double min;
        public double max;
        public int flags;
        public sbyte* unit;
    }
}