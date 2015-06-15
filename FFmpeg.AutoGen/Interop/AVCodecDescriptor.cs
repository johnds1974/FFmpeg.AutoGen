using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public unsafe struct AVCodecDescriptor
    {
        public AVCodecID id;
        public AVMediaType type;
        public sbyte* name;
        public sbyte* long_name;
        public int props;
        public sbyte** mime_types;
    }
}