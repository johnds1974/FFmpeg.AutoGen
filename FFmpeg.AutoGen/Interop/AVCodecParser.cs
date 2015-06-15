using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVCodecParser
    {
        public fixed int codec_ids[5]; // <Ctype "c_int * 5">
        public int priv_data_size;
        public IntPtr parser_init; // Func<AVCodecParserContext*, int>
        public IntPtr parser_parse; // Func<AVCodecParserContext*, AVCodecContext*, byte**, int*, byte*, int, int>
        public IntPtr parser_close; // Action<AVCodecParserContext*>
        public IntPtr split; // Func<AVCodecContext*, byte*, int, int>
        public AVCodecParser* next;
    }
}