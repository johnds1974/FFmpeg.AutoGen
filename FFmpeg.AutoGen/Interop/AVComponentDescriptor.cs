using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVComponentDescriptor
    {
        public uint _bitfield0x00;
        //bit field plane uint16_t:2
        //bit field step_minus1 uint16_t:3
        //bit field offset_plus1 uint16_t:3
        //bit field shift uint16_t:3
        //bit field depth_minus1 uint16_t:4
    }
}