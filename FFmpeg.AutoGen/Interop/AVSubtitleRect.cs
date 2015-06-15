using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVSubtitleRect
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public int nb_colors;
        public AVPicture pict;
        public AVSubtitleType type;
        public sbyte* text;
        public sbyte* ass;
        public int flags;
    }
}