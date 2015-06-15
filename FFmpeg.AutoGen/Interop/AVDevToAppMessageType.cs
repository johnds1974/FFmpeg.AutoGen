namespace FFmpeg.AutoGen.Interop
{
    public enum AVDevToAppMessageType
    {
        AV_DEV_TO_APP_NONE = 0x4e4f4e45, // ((('E' | ('N' << 8)) | ('O' << 16)) | ('N' << 24))
        AV_DEV_TO_APP_CREATE_WINDOW_BUFFER = 0x42435245, // ((('E' | ('R' << 8)) | ('C' << 16)) | ('B' << 24))
        AV_DEV_TO_APP_PREPARE_WINDOW_BUFFER = 0x42505245, // ((('E' | ('R' << 8)) | ('P' << 16)) | ('B' << 24))
        AV_DEV_TO_APP_DISPLAY_WINDOW_BUFFER = 0x42444953, // ((('S' | ('I' << 8)) | ('D' << 16)) | ('B' << 24))
        AV_DEV_TO_APP_DESTROY_WINDOW_BUFFER = 0x42444553, // ((('S' | ('E' << 8)) | ('D' << 16)) | ('B' << 24))
        AV_DEV_TO_APP_BUFFER_OVERFLOW = 0x424f464c, // ((('L' | ('F' << 8)) | ('O' << 16)) | ('B' << 24))
        AV_DEV_TO_APP_BUFFER_UNDERFLOW = 0x4255464c, // ((('L' | ('F' << 8)) | ('U' << 16)) | ('B' << 24))
        AV_DEV_TO_APP_BUFFER_READABLE = 0x42524420, // (((' ' | ('D' << 8)) | ('R' << 16)) | ('B' << 24))
        AV_DEV_TO_APP_BUFFER_WRITABLE = 0x42575220, // (((' ' | ('R' << 8)) | ('W' << 16)) | ('B' << 24))
        AV_DEV_TO_APP_MUTE_STATE_CHANGED = 0x434d5554, // ((('T' | ('U' << 8)) | ('M' << 16)) | ('C' << 24))
        AV_DEV_TO_APP_VOLUME_LEVEL_CHANGED = 0x43564f4c, // ((('L' | ('O' << 8)) | ('V' << 16)) | ('C' << 24))
    }
}