using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVIOInterruptCB
    {
        public IntPtr callback; // Func<void*, int>
        public void* opaque;
    }
}