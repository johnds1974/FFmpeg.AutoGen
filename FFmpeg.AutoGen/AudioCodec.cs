using FFmpeg.AutoGen.Interop;

namespace FFmpeg.AutoGen
{
    public class AudioCodec
    {
        private string _shortname;
        private AVCodecID _id;

        public string ShortName { get { return _shortname; } }
        public AVCodecID CodecID { get { return _id; } }

        public AudioCodec(string ShortName, AVCodecID ID)
        {
            _shortname = ShortName;
            _id = ID;
        }

        public static readonly AudioCodec AAC = new AudioCodec("mp4", AVCodecID.CODEC_ID_AAC);
        public static readonly AudioCodec AC3 = new AudioCodec("ac3", AVCodecID.CODEC_ID_AC3);
        public static readonly AudioCodec FLAC = new AudioCodec("flac", AVCodecID.CODEC_ID_FLAC);
        public static readonly AudioCodec MP2 = new AudioCodec("mp2", AVCodecID.CODEC_ID_MP2);
        public static readonly AudioCodec MP3 = new AudioCodec("mp3", AVCodecID.CODEC_ID_MP3);
        public static readonly AudioCodec PCM = new AudioCodec("wav", AVCodecID.CODEC_ID_PCM_S16BE);
        public static readonly AudioCodec Vorbis = new AudioCodec("ogg", AVCodecID.CODEC_ID_VORBIS);
        public static readonly AudioCodec WMA = new AudioCodec("asf", AVCodecID.CODEC_ID_WMAV2);
    }
}