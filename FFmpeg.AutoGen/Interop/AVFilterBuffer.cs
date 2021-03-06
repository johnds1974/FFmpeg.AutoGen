using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVFilterBuffer
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
        public byte** extended_data;
        public fixed int linesize[8]; // <Ctype "c_int * 8">
        public void* priv;
        public IntPtr free; // Action<AVFilterBuffer*>
        public int format;
        public int w;
        public int h;
        public int refcount;
    }
}