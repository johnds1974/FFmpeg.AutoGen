namespace FFmpeg.AutoGen.Interop
{
    public enum AVDiscard
    {
        AVDISCARD_NONE = -0x10, // (-16)
        AVDISCARD_DEFAULT = 0x0, // 0
        AVDISCARD_NONREF = 0x8, // 8
        AVDISCARD_BIDIR = 0x10, // 16
        AVDISCARD_NONINTRA = 0x18, // 24
        AVDISCARD_NONKEY = 0x20, // 32
        AVDISCARD_ALL = 0x30, // 48
    }
}