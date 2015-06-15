using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVCodecParserContext
    {
        public void* priv_data;
        public AVCodecParser* parser;
        public long frame_offset;
        public long cur_offset;
        public long next_frame_offset;
        public int pict_type;
        public int repeat_pict;
        public long pts;
        public long dts;
        public long last_pts;
        public long last_dts;
        public int fetch_timestamp;
        public int cur_frame_start_index;
        public fixed long cur_frame_offset[4]; // <Ctype "c_int64 * 4">
        public fixed long cur_frame_pts[4]; // <Ctype "c_int64 * 4">
        public fixed long cur_frame_dts[4]; // <Ctype "c_int64 * 4">
        public int flags;
        public long offset;
        public fixed long cur_frame_end[4]; // <Ctype "c_int64 * 4">
        public int key_frame;
        public long convergence_duration;
        public int dts_sync_point;
        public int dts_ref_dts_delta;
        public int pts_dts_delta;
        public fixed long cur_frame_pos[4]; // <Ctype "c_int64 * 4">
        public long pos;
        public long last_pos;
        public int duration;
        public AVFieldOrder field_order;
        public AVPictureStructure picture_structure;
        public int output_picture_number;
    }
}