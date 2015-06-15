using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVProbeData
    {
        public sbyte* filename;
        public sbyte* buf;
        public int buf_size;
        public sbyte* mime_type;
    }
}