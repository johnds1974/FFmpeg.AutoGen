using System;

namespace FFmpeg
{
    public class EncoderException : ApplicationException
    {
        public EncoderException() { }
        public EncoderException(string Message) : base(Message) { }
    }
}