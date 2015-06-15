using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFifoBuffer
    {
        public byte* buffer;
        public byte* rptr;
        public byte* wptr;
        public byte* end;
        public uint rndx;
        public uint wndx;
    }
}