using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVInputFormat
    {
        public sbyte* name;
        public sbyte* long_name;
        public int flags;
        public sbyte* extensions;
        public AVCodecTag** codec_tag;
        public AVClass* priv_class;
        public sbyte* mime_type;
        public AVInputFormat* next;
        public int raw_codec_id;
        public int priv_data_size;
        public IntPtr read_probe; // Func<AVProbeData*, int>
        public IntPtr read_header; // Func<AVFormatContext*, int>
        public IntPtr read_packet; // Func<AVFormatContext*, AVPacket*, int>
        public IntPtr read_close; // Func<AVFormatContext*, int>
        public IntPtr read_seek; // Func<AVFormatContext*, int, long, int, int>
        public IntPtr read_timestamp; // Func<AVFormatContext*, int, long*, long, long>
        public IntPtr read_play; // Func<AVFormatContext*, int>
        public IntPtr read_pause; // Func<AVFormatContext*, int>
        public IntPtr read_seek2; // Func<AVFormatContext*, int, long, long, long, int, int>
        public IntPtr get_device_list; // Func<AVFormatContext*, AVDeviceInfoList*, int>
        public IntPtr create_device_capabilities; // Func<AVFormatContext*, AVDeviceCapabilitiesQuery*, int>
        public IntPtr free_device_capabilities; // Func<AVFormatContext*, AVDeviceCapabilitiesQuery*, int>
    }
}