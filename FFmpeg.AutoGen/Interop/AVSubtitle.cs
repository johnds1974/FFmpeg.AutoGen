using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVSubtitle
    {
        public ushort format;
        public uint start_display_time;
        public uint end_display_time;
        public int num_rects;
        public AVSubtitleRect** rects;
        public long pts;
    }
}