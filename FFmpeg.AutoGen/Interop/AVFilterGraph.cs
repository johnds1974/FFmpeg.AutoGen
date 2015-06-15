using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFilterGraph
    {
        public AVClass* av_class;
        public int filter_count_unused;
        public AVFilterContext** filters;
        public sbyte* scale_sws_opts;
        public sbyte* resample_lavr_opts;
        public int nb_filters;
        public int thread_type;
        public int nb_threads;
        public AVFilterGraphInternal* @internal;
        public void* opaque;
        public IntPtr execute; // avfilter_execute_func* - Func<AVFilterContext*, avfilter_action_func*, void*, int*, int, int>
        public sbyte* aresample_swr_opts;
        public AVFilterLink** sink_links;
        public int sink_links_count;
        public int disable_auto_convert;
    }
}