using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVDeviceInfoList
    {
        public AVDeviceInfo** devices;
        public int nb_devices;
        public int default_device;
    }
}