using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVBitStreamFilter
    {
        public sbyte* name;
        public int priv_data_size;
        public IntPtr filter; // Func<AVBitStreamFilterContext*, AVCodecContext*, String, byte**, int*, byte*, int, int, int>
        public IntPtr close; // Action<AVBitStreamFilterContext*>
        public AVBitStreamFilter* next;
    }
}