using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFrameSideData
    {
        public AVFrameSideDataType type;
        public byte* data;
        public int size;
        public AVDictionary* metadata;
    }
}