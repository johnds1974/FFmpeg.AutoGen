using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVBufferRef
    {
        public AVBuffer* buffer;
        public byte* data;
        public int size;
    }
}