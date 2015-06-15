using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVOutputFormat
    {
        public sbyte* name;
        public sbyte* long_name;
        public sbyte* mime_type;
        public sbyte* extensions;
        public AVCodecID audio_codec;
        public AVCodecID video_codec;
        public AVCodecID subtitle_codec;
        public int flags;
        public AVCodecTag** codec_tag;
        public AVClass* priv_class;
        public AVOutputFormat* next;
        public int priv_data_size;
        public IntPtr write_header; // Func<AVFormatContext*, int>
        public IntPtr write_packet; // Func<AVFormatContext*, AVPacket*, int>
        public IntPtr write_trailer; // Func<AVFormatContext*, int>
        public IntPtr interleave_packet; // Func<AVFormatContext*, AVPacket*, AVPacket*, int, int>
        public IntPtr query_codec; // Func<AVCodecID, int, int>
        public IntPtr get_output_timestamp; // Action<AVFormatContext*, int, long*, long*>
        public IntPtr control_message; // Func<AVFormatContext*, int, void*, uint, int>
        public IntPtr write_uncoded_frame; // Func<AVFormatContext*, int, AVFrame**, int, int>
        public IntPtr get_device_list; // Func<AVFormatContext*, AVDeviceInfoList*, int>
        public IntPtr create_device_capabilities; // Func<AVFormatContext*, AVDeviceCapabilitiesQuery*, int>
        public IntPtr free_device_capabilities; // Func<AVFormatContext*, AVDeviceCapabilitiesQuery*, int>
    }
}