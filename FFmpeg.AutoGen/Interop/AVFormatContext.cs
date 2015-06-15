using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFormatContext
    {
        public AVClass* av_class;
        public AVInputFormat* iformat;
        public AVOutputFormat* oformat;
        public void* priv_data;
        public AVIOContext* pb;
        public int ctx_flags;
        public int nb_streams;
        public AVStream** streams;
        public fixed sbyte filename[1024]; // <Ctype "c_char * 1024">
        public long start_time;
        public long duration;
        public int bit_rate;
        public int packet_size;
        public int max_delay;
        public int flags;
        public int probesize;
        public int max_analyze_duration;
        public byte* key;
        public int keylen;
        public int nb_programs;
        public AVProgram** programs;
        public AVCodecID video_codec_id;
        public AVCodecID audio_codec_id;
        public AVCodecID subtitle_codec_id;
        public int max_index_size;
        public int max_picture_buffer;
        public int nb_chapters;
        public AVChapter** chapters;
        public AVDictionary* metadata;
        public long start_time_realtime;
        public int fps_probe_size;
        public int error_recognition;
        public AVIOInterruptCB interrupt_callback;
        public int debug;
        public long max_interleave_delta;
        public int strict_std_compliance;
        public int event_flags;
        public int max_ts_probe;
        public int avoid_negative_ts;
        public int ts_id;
        public int audio_preload;
        public int max_chunk_duration;
        public int max_chunk_size;
        public int use_wallclock_as_timestamps;
        public int avio_flags;
        public AVDurationEstimationMethod duration_estimation_method;
        public long skip_initial_bytes;
        public int correct_ts_overflow;
        public int seek2any;
        public int flush_packets;
        public int probe_score;
        public int format_probesize;
        public sbyte* codec_whitelist;
        public sbyte* format_whitelist;
        public AVPacketList* packet_buffer;
        public AVPacketList* packet_buffer_end;
        public long data_offset;
        public AVPacketList* raw_packet_buffer;
        public AVPacketList* raw_packet_buffer_end;
        public AVPacketList* parse_queue;
        public AVPacketList* parse_queue_end;
        public int raw_packet_buffer_remaining_size;
        public long offset;
        public AVRational offset_timebase;
        public AVFormatInternal* @internal;
        public int io_repositioned;
        public AVCodec* video_codec;
        public AVCodec* audio_codec;
        public AVCodec* subtitle_codec;
        public int metadata_header_padding;
        public void* opaque;
        public IntPtr control_message_cb; // av_format_control_message
        public long output_ts_offset;
        public long max_analyze_duration2;
        public long probesize2;
        public byte* dump_separator;
    }
}