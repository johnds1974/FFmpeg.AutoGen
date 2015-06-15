using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFilterLink
    {
        public AVFilterContext* src;
        public AVFilterPad* srcpad;
        public AVFilterContext* dst;
        public AVFilterPad* dstpad;
        public AVMediaType type;
        public int w;
        public int h;
        public AVRational sample_aspect_ratio;
        public ulong channel_layout;
        public int sample_rate;
        public int format;
        public AVRational time_base;
        public AVFilterFormats* in_formats;
        public AVFilterFormats* out_formats;
        public AVFilterFormats* in_samplerates;
        public AVFilterFormats* out_samplerates;
        public AVFilterChannelLayouts* in_channel_layouts;
        public AVFilterChannelLayouts* out_channel_layouts;
        public int request_samples;
        public Anon9 init_state;
        public AVFilterPool* pool;
        public AVFilterGraph* graph;
        public long current_pts;
        public int age_index;
        public AVRational frame_rate;
        public AVFrame* partial_buf;
        public int partial_buf_size;
        public int min_samples;
        public int max_samples;
        public AVFilterBufferRef* cur_buf_copy;
        public int closed;
        public int channels;
        public int frame_requested;
        public int flags;
        public long frame_count;
    }
}