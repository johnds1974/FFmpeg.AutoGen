using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFilterBufferRefVideoProps
    {
        public int w;
        public int h;
        public AVRational sample_aspect_ratio;
        public int interlaced;
        public int top_field_first;
        public AVPictureType pict_type;
        public int key_frame;
        public int qp_table_linesize;
        public int qp_table_size;
        public sbyte* qp_table;
    }
}