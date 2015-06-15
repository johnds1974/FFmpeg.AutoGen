using FFmpeg.AutoGen.Interop;

namespace FFmpeg.AutoGen
{
    public interface IVideoStream : IMediaStream
    {
        int Width { get; }
        int Height { get; }
        double FrameRate { get; }
        long FrameCount { get; }
        int FrameSize { get; }
        int Stride { get; }
        AVPixelFormat PixelFormat { get; }
        bool ReadFrame(out byte[] frame);
    }
}
