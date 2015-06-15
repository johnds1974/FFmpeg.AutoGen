using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVChapter
    {
        public int id;
        public AVRational time_base;
        public long start;
        public long end;
        public AVDictionary* metadata;
    }
}