using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVDeviceInfo
    {
        public sbyte* device_name;
        public sbyte* device_description;
    }
}