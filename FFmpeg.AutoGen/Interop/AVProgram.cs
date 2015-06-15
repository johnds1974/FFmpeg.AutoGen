using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVProgram
    {
        public int id;
        public int flags;
        public AVDiscard discard;
        public int* stream_index;
        public int nb_stream_indexes;
        public AVDictionary* metadata;
        public int program_num;
        public int pmt_pid;
        public int pcr_pid;
        public long start_time;
        public long end_time;
        public long pts_wrap_reference;
        public int pts_wrap_behavior;
    }
}