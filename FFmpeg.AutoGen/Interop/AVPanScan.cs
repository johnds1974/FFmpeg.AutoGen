using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVPanScan
    {
        public int id;
        public int width;
        public int height;
        public fixed short position[6]; // <Ctype "(c_int16 * 2) * 3">
    }
}