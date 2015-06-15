namespace FFmpeg.AutoGen.Interop
{
    public enum AVAppToDevMessageType
    {
        AV_APP_TO_DEV_NONE = 0x4e4f4e45, // ((('E' | ('N' << 8)) | ('O' << 16)) | ('N' << 24))
        AV_APP_TO_DEV_WINDOW_SIZE = 0x47454f4d, // ((('M' | ('O' << 8)) | ('E' << 16)) | ('G' << 24))
        AV_APP_TO_DEV_WINDOW_REPAINT = 0x52455041, // ((('A' | ('P' << 8)) | ('E' << 16)) | ('R' << 24))
        AV_APP_TO_DEV_PAUSE = 0x50415520, // (((' ' | ('U' << 8)) | ('A' << 16)) | ('P' << 24))
        AV_APP_TO_DEV_PLAY = 0x504c4159, // ((('Y' | ('A' << 8)) | ('L' << 16)) | ('P' << 24))
        AV_APP_TO_DEV_TOGGLE_PAUSE = 0x50415554, // ((('T' | ('U' << 8)) | ('A' << 16)) | ('P' << 24))
        AV_APP_TO_DEV_SET_VOLUME = 0x53564f4c, // ((('L' | ('O' << 8)) | ('V' << 16)) | ('S' << 24))
        AV_APP_TO_DEV_MUTE = 0x204d5554, // ((('T' | ('U' << 8)) | ('M' << 16)) | (' ' << 24))
        AV_APP_TO_DEV_UNMUTE = 0x554d5554, // ((('T' | ('U' << 8)) | ('M' << 16)) | ('U' << 24))
        AV_APP_TO_DEV_TOGGLE_MUTE = 0x544d5554, // ((('T' | ('U' << 8)) | ('M' << 16)) | ('T' << 24))
        AV_APP_TO_DEV_GET_VOLUME = 0x47564f4c, // ((('L' | ('O' << 8)) | ('V' << 16)) | ('G' << 24))
        AV_APP_TO_DEV_GET_MUTE = 0x474d5554, // ((('T' | ('U' << 8)) | ('M' << 16)) | ('G' << 24))
    }
}