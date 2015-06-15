using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct RcOverride
    {
        public int start_frame;
        public int end_frame;
        public int qscale;
        public float quality_factor;
    }
}