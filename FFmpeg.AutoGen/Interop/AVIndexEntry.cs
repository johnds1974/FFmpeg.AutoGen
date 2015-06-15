using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVIndexEntry
    {
        public long pos;
        public long timestamp;
        public uint _bitfield0x00;
        //bit field flags int:2
        //bit field size int:30
        public int min_distance;
    }
}