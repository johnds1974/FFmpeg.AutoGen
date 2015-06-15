using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVDeviceRect
    {
        public int x;
        public int y;
        public int width;
        public int height;
    }
}