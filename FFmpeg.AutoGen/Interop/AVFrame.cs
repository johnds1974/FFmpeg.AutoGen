using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFrame
    {
        // fixed byte* data[8] - <Ctype "POINTER(c_uint8) * 8">
        public byte* data_0;
        public byte* data_1;
        public byte* data_2;
        public byte* data_3;
        public byte* data_4;
        public byte* data_5;
        public byte* data_6;
        public byte* data_7;
        public fixed int linesize[8]; // <Ctype "c_int * 8">
        public byte** extended_data;
        public int width;
        public int height;
        public int nb_samples;
        public int format;
        public int key_frame;
        public AVPictureType pict_type;
        // fixed byte* @base[8] - <Ctype "POINTER(c_uint8) * 8">
        public byte* @base_0;
        public byte* @base_1;
        public byte* @base_2;
        public byte* @base_3;
        public byte* @base_4;
        public byte* @base_5;
        public byte* @base_6;
        public byte* @base_7;
        public AVRational sample_aspect_ratio;
        public long pts;
        public long pkt_pts;
        public long pkt_dts;
        public int coded_picture_number;
        public int display_picture_number;
        public int quality;
        public int reference;
        public sbyte* qscale_table;
        public int qstride;
        public int qscale_type;
        public byte* mbskip_table;
        // fixed short** motion_val[2] - <Ctype "POINTER(c_int16 * 2) * 2">
        public short** motion_val_0;
        public short** motion_val_1;
        public uint* mb_type;
        public short* dct_coeff;
        // fixed sbyte* ref_index[2] - <Ctype "POINTER(c_int8) * 2">
        public sbyte* ref_index_0;
        public sbyte* ref_index_1;
        public void* opaque;
        public fixed ulong error[8]; // <Ctype "c_uint64 * 8">
        public int type;
        public int repeat_pict;
        public int interlaced_frame;
        public int top_field_first;
        public int palette_has_changed;
        public int buffer_hints;
        public AVPanScan* pan_scan;
        public long reordered_opaque;
        public void* hwaccel_picture_private;
        public AVCodecContext* owner;
        public void* thread_opaque;
        public byte motion_subsample_log2;
        public int sample_rate;
        public ulong channel_layout;
        // fixed AVBufferRef* buf[8] - <Ctype "POINTER(AVBufferRef) * 8">
        public AVBufferRef* buf_0;
        public AVBufferRef* buf_1;
        public AVBufferRef* buf_2;
        public AVBufferRef* buf_3;
        public AVBufferRef* buf_4;
        public AVBufferRef* buf_5;
        public AVBufferRef* buf_6;
        public AVBufferRef* buf_7;
        public AVBufferRef** extended_buf;
        public int nb_extended_buf;
        public AVFrameSideData** side_data;
        public int nb_side_data;
        public int flags;
        public AVColorRange color_range;
        public AVColorPrimaries color_primaries;
        public AVColorTransferCharacteristic color_trc;
        public AVColorSpace colorspace;
        public AVChromaLocation chroma_location;
        public long best_effort_timestamp;
        public long pkt_pos;
        public long pkt_duration;
        public AVDictionary* metadata;
        public int decode_error_flags;
        public int channels;
        public int pkt_size;
        public AVBufferRef* qp_table_buf;
    }
}