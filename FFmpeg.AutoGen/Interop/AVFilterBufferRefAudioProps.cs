using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFilterBufferRefAudioProps
    {
        public ulong channel_layout;
        public int nb_samples;
        public int sample_rate;
        public int channels;
    }
}