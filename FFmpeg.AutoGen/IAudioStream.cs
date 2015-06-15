namespace FFmpeg.AutoGen
{
    public interface IAudioStream : IMediaStream
    {
        int Channels { get; }
        int SampleRate { get; }
        int SampleSize { get; }
        bool ReadSample(out byte[] buffer);
    }
}
