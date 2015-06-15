using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct Anon12
    {
        public AVSampleFormat* sample_fmts;
        public long* channel_layouts;
        public int* channel_counts;
        public int all_channel_counts;
        public int* sample_rates;
    }
}