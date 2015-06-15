using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVDeviceCapabilitiesQuery
    {
        public AVClass* av_class;
        public AVFormatContext* device_context;
        public AVCodecID codec;
        public AVSampleFormat sample_format;
        public AVPixelFormat pixel_format;
        public int sample_rate;
        public int channels;
        public long channel_layout;
        public int window_width;
        public int window_height;
        public int frame_width;
        public int frame_height;
        public AVRational fps;
    }
}