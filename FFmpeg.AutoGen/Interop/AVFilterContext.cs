using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFilterContext
    {
        public AVClass* av_class;
        public AVFilter* filter;
        public sbyte* name;
        public AVFilterPad* input_pads;
        public AVFilterLink** inputs;
        public int input_count;
        public int nb_inputs;
        public AVFilterPad* output_pads;
        public AVFilterLink** outputs;
        public int output_count;
        public int nb_outputs;
        public void* priv;
        public AVFilterGraph* graph;
        public int thread_type;
        public AVFilterInternal* @internal;
        public AVFilterCommand* command_queue;
        public sbyte* enable_str;
        public void* enable;
        public double* var_values;
        public int is_disabled;
    }
}