using System;
using System.IO;
using System.Text;
using FFmpeg.AutoGen.Interop;
using System.Xml.Serialization;

namespace FFmpeg.AutoGen
{
    public class EncoderInformation
    {
        public readonly AudioCodec Codec;
        /// <summary>
        /// The bitrate of the audio if doing constant bitrate encoding (VBR == false)
        /// </summary>
        public readonly int Bitrate;

        public readonly int SampleRate;

        public readonly int Channels;

        /// <summary>
        /// Quality Scale if using VBR (valid values, 1-100)
        /// </summary>
        public readonly float QualityScale;

        /// <summary> Sample Size (in bits) </summary>
        public readonly int SampleSize;

        public readonly bool VBR;

        public EncoderInformation(AudioCodec Codec, int Bitrate, int SampleRate, int Channels, bool VBR)
        {
            this.Codec = Codec;
            this.Bitrate = Bitrate;
            this.SampleRate = SampleRate;
            this.Channels = Channels;
            this.VBR = VBR;
            this.QualityScale = 0;
            this.SampleSize = sizeof(short);
        }

        public static EncoderInformation Deserialize(String xmlString)
        {
            StringReader reader = new StringReader(xmlString);

            XmlSerializer s = new XmlSerializer(typeof(EncoderInformation));
            EncoderInformation info;
            info = (EncoderInformation)s.Deserialize(reader);

            return info;
        }

        public string SerializeToXML()
        {
            StringBuilder sb = new StringBuilder();

            XmlSerializer s = new XmlSerializer(typeof(EncoderInformation));
            TextWriter w = new StringWriter(sb);
            s.Serialize(w, this);

            return sb.ToString();
        }

        public int FFmpegQualityScale
        {
            get
            {
                float ffqscale = 0;

                if (this.Codec == AudioCodec.AAC)
                {
                    ffqscale = QualityScale * 5;
                    ffqscale = ffqscale < 10 ? 10 : ffqscale;
                }

                if (this.Codec == AudioCodec.MP3)
                {
                    ffqscale = (float)Math.Round(QualityScale / 11);
                    ffqscale = ffqscale > 9 ? 9 : ffqscale;
                }
                if (this.Codec == AudioCodec.Vorbis)
                {
                    ffqscale = QualityScale / 100;
                }

                return (int)Math.Round(ffqscale) * FFmpegInvoke.FF_QP2LAMBDA;
            }
        }
    }
}