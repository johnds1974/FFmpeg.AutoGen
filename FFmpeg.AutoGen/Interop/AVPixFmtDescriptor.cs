using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVPixFmtDescriptor
    {
        public sbyte* name;
        public byte nb_components;
        public byte log2_chroma_w;
        public byte log2_chroma_h;
        public byte flags;
        public fixed uint comp[4]; // <Ctype "AVComponentDescriptor * 4">
        public sbyte* alias;
    }
}