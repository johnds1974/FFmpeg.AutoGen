using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVPicture
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
    }
}