using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVBitStreamFilterContext
    {
        public void* priv_data;
        public AVBitStreamFilter* filter;
        public AVCodecParserContext* parser;
        public AVBitStreamFilterContext* next;
    }
}