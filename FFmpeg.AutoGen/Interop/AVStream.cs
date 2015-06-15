using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVStream
    {
        public int index;
        public int id;
        public AVCodecContext* codec;
        public void* priv_data;
        public AVFrac pts;
        public AVRational time_base;
        public long start_time;
        public long duration;
        public long nb_frames;
        public int disposition;
        public AVDiscard discard;
        public AVRational sample_aspect_ratio;
        public AVDictionary* metadata;
        public AVRational avg_frame_rate;
        public AVPacket attached_pic;
        public AVPacketSideData* side_data;
        public int nb_side_data;
        public int event_flags;
        public Anon8* info;
        public int pts_wrap_bits;
        public long first_dts;
        public long cur_dts;
        public long last_IP_pts;
        public int last_IP_duration;
        public int probe_packets;
        public int codec_info_nb_frames;
        public AVStreamParseType need_parsing;
        public AVCodecParserContext* parser;
        public AVPacketList* last_in_packet_buffer;
        public AVProbeData probe_data;
        public fixed long pts_buffer[17]; // <Ctype "c_int64 * (16 + 1)">
        public AVIndexEntry* index_entries;
        public int nb_index_entries;
        public int index_entries_allocated_size;
        public AVRational r_frame_rate;
        public int stream_identifier;
        public long interleaver_chunk_size;
        public long interleaver_chunk_duration;
        public int request_probe;
        public int skip_to_keyframe;
        public int skip_samples;
        public long first_discard_sample;
        public long last_discard_sample;
        public int nb_decoded_frames;
        public long mux_ts_offset;
        public long pts_wrap_reference;
        public int pts_wrap_behavior;
        public int update_initial_durations_done;
        public fixed long pts_reorder_error[17]; // <Ctype "c_int64 * (16 + 1)">
        public fixed byte pts_reorder_error_count[17]; // <Ctype "c_uint8 * (16 + 1)">
        public long last_dts_for_order_check;
        public byte dts_ordered;
        public byte dts_misordered;
        public int inject_global_side_data;
        public sbyte* recommended_encoder_configuration;
        public AVRational display_aspect_ratio;
    }
}