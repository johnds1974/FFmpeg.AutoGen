using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVPacket
    {
        public AVBufferRef* buf;
        public long pts;
        public long dts;
        public byte* data;
        public int size;
        public int stream_index;
        public int flags;
        public AVPacketSideData* side_data;
        public int side_data_elems;
        public int duration;
        public IntPtr destruct; // Action<AVPacket*>
        public void* priv;
        public long pos;
        public long convergence_duration;
    }
}