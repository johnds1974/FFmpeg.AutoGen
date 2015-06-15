namespace FFmpeg.AutoGen.Interop
{
    public enum AVOptionType
    {
        AV_OPT_TYPE_FLAGS,
        AV_OPT_TYPE_INT,
        AV_OPT_TYPE_INT64,
        AV_OPT_TYPE_DOUBLE,
        AV_OPT_TYPE_FLOAT,
        AV_OPT_TYPE_STRING,
        AV_OPT_TYPE_RATIONAL,
        AV_OPT_TYPE_BINARY,
        AV_OPT_TYPE_DICT,
        AV_OPT_TYPE_CONST = 0x80, // 128
        AV_OPT_TYPE_IMAGE_SIZE = 0x53495a45, // ((('E' | ('Z' << 8)) | ('I' << 16)) | ('S' << 24))
        AV_OPT_TYPE_PIXEL_FMT = 0x50464d54, // ((('T' | ('M' << 8)) | ('F' << 16)) | ('P' << 24))
        AV_OPT_TYPE_SAMPLE_FMT = 0x53464d54, // ((('T' | ('M' << 8)) | ('F' << 16)) | ('S' << 24))
        AV_OPT_TYPE_VIDEO_RATE = 0x56524154, // ((('T' | ('A' << 8)) | ('R' << 16)) | ('V' << 24))
        AV_OPT_TYPE_DURATION = 0x44555220, // (((' ' | ('R' << 8)) | ('U' << 16)) | ('D' << 24))
        AV_OPT_TYPE_COLOR = 0x434f4c52, // ((('R' | ('L' << 8)) | ('O' << 16)) | ('C' << 24))
        AV_OPT_TYPE_CHANNEL_LAYOUT = 0x43484c41, // ((('A' | ('L' << 8)) | ('H' << 16)) | ('C' << 24))
        FF_OPT_TYPE_FLAGS = 0x0, // 0
        FF_OPT_TYPE_INT,
        FF_OPT_TYPE_INT64,
        FF_OPT_TYPE_DOUBLE,
        FF_OPT_TYPE_FLOAT,
        FF_OPT_TYPE_STRING,
        FF_OPT_TYPE_RATIONAL,
        FF_OPT_TYPE_BINARY,
        FF_OPT_TYPE_CONST = 0x80, // 128
    }
}