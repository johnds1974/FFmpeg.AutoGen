using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using FFmpeg;
using FFmpeg.AutoGen;
using FFmpeg.AutoGen.Interop;
using System.Runtime.InteropServices;
using System.Threading;
using WpfVideoPlayerColigo.ViewModels;

namespace WpfVideoPlayerColigo.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaFile _mediaFile;
        private VideoScalingStream _videoScalingStream;
        private CancellationTokenSource _cancellationTokenSource;
        private SynchronizationContext _synchronizationContext;

        public MainWindow()
        {
            InitializeComponent();

//            DataContext = this;

            _synchronizationContext = SynchronizationContext.Current;

            // register path to ffmpeg
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                    string ffmpegPath = string.Format(@"../../../FFmpeg/bin/windows/{0}", Environment.Is64BitProcess ? "x64" : "x86");
                    InteropHelper.RegisterLibrariesSearchPath(ffmpegPath);
                    break;
                case PlatformID.Unix:
                case PlatformID.MacOSX:
                    string libraryPath = Environment.GetEnvironmentVariable(InteropHelper.LD_LIBRARY_PATH);
                    InteropHelper.RegisterLibrariesSearchPath(libraryPath);
                    break;
            }
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            NextFrame.IsEnabled = false;
            LoadStream.IsEnabled = false;

            MainWindowViewModel vm = DataContext as MainWindowViewModel;
            if (vm != null)
            {
                vm.LoadStream();
            }
            return;

            Task.Run(() =>
                {
//                    var filename = @"http://86.164.170.180/moviefiles/ElaAssemblysmall.mp4";
                    var filename = @"C:\Users\Public\Videos\Sample Videos\Wildlife.wmv";
                    _mediaFile = new MediaFile(filename);

                    foreach (DecoderStream stream in _mediaFile.Streams)
                    {
                        if (stream is VideoDecoderStream)
                        {
                            VideoDecoderStream videoStream = stream as VideoDecoderStream;

                            _videoScalingStream = new VideoScalingStream(
                                videoStream,
                                videoStream.Width,
                                videoStream.Height,
                                AVPixelFormat.AV_PIX_FMT_RGB24);

                            break;
                        }
                    }

                    Dispatcher.Invoke(() =>
                        {
                            LoadStream.IsEnabled = true;
                            NextFrame.IsEnabled = true;
                        });

                });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frame"></param>
        private void AssignFrame(byte[] frame)
        {
            if (FrameImage.Source == null)
            {
//                OnUIThread(o =>
//                {
                    FrameImage.Source = new WriteableBitmap(
                        _videoScalingStream.Width,
                        _videoScalingStream.Height,
                        72,
                        72,
                        PixelFormats.Rgb24,
                        null
                        );
//                }, null);
            }

//            OnUIThread(o =>
//            {
                ((WriteableBitmap)FrameImage.Source).WritePixels(
                    new Int32Rect(0, 0, _videoScalingStream.Width, _videoScalingStream.Height),
                    frame,
                    _videoScalingStream.Stride,
                    0
                    );

                ((WriteableBitmap)FrameImage.Source).Lock();
                ((WriteableBitmap)FrameImage.Source).AddDirtyRect(new Int32Rect(0, 0, _videoScalingStream.Width, _videoScalingStream.Height));
                ((WriteableBitmap)FrameImage.Source).Unlock();
//            }, null);

/*
            IntPtr ptr = Marshal.AllocHGlobal(frame.Length);
            Marshal.Copy(frame, 0, ptr, frame.Length);

            var bf = BitmapFrame.Create(
                _videoStream.Width,
                _videoStream.Height,
                72,
                72,
                PixelFormats.Rgb24,
                BitmapPalettes.BlackAndWhite,
                ptr,
                frame.Length,
                _videoStream.Stride);

            CurrentFrameImage = bf;

            // Call unmanaged code
            Marshal.FreeHGlobal(ptr);
*/

        }



        private void NextFrame_Click(object sender, RoutedEventArgs e)
        {
            byte[] frame;
            if (_videoScalingStream.ReadFrame(out frame))
            {
                AssignFrame(frame);
/*
                IntPtr ptr = Marshal.AllocHGlobal(frame.Length);
                Marshal.Copy(frame, 0, ptr, frame.Length);

                var bf = BitmapFrame.Create(
                    _videoScalingStream.Width,
                    _videoScalingStream.Height,
                    72,
                    72,
                    PixelFormats.Rgb24,
                    BitmapPalettes.BlackAndWhite,
                    ptr,
                    frame.Length,
                    _videoScalingStream.Stride);

                FrameImage.Source = bf;

                // Call unmanaged code
                Marshal.FreeHGlobal(ptr);
*/
            }

        }

        private async void Play_Click(object sender, RoutedEventArgs e)
        {
            LoadStream.IsEnabled = false;
            PlayStream.IsEnabled = false;


            MainWindowViewModel vm = DataContext as MainWindowViewModel;
            if (vm != null)
            {
                vm.PlayStream();
            }
            return;

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            await Task.Run(async () =>
                {
                    IntPtr ptr = IntPtr.Zero;

                    int framedelayms = (int)(1000 / _videoScalingStream.FrameRate);

                    Stopwatch sw = Stopwatch.StartNew();

                    byte[] frame;
                    while (_videoScalingStream.ReadFrame(out frame))
                    {
                        byte[] frame1 = frame;

                        _synchronizationContext.Send(state =>
                            {
                                AssignFrame(frame1);
                            }, null);

/*
                        if(ptr == IntPtr.Zero)
                            ptr = Marshal.AllocHGlobal(frame1.Length);

                        _synchronizationContext.Send(state =>
                            {
                                Marshal.Copy(frame1, 0, ptr, frame1.Length);

                                var bf = BitmapSource.Create(
                                    _videoScalingStream.Width,
                                    _videoScalingStream.Height,
                                    72,
                                    72,
                                    PixelFormats.Rgb24,
                                    BitmapPalettes.BlackAndWhite,
                                    ptr,
                                    frame1.Length,
                                    _videoScalingStream.Stride);

                                FrameImage.Source = bf;

                                sw.Stop();

                                FrameLoadDuration.Text = string.Format("FrameLoadDuration = {0}ms", sw.ElapsedMilliseconds);
                            }, null);
*/

                        if(sw.ElapsedMilliseconds < framedelayms)
                            await Task.Delay(framedelayms - (int)sw.ElapsedMilliseconds);

                        sw.Reset();

                        if (token.IsCancellationRequested)
                        {
                            _cancellationTokenSource.Dispose();
                            break;
                        }

                    } // end while(...)

                    // Free unmanaged memory...
                    if(ptr != IntPtr.Zero)
                        Marshal.FreeHGlobal(ptr);

                    Dispatcher.Invoke(() =>
                        {
                            PlayStream.IsEnabled = true;
                            LoadStream.IsEnabled = true;
                        });

                }, token);

        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
            }
        }

        private void WriteAudio_Click(object sender, RoutedEventArgs e)
        {
            using (AudioEncoderStream enc = new AudioEncoderStream(
                "audio.mp3",
                AudioCodec.MP2,
                128*1000,
                44100,
                2,
                false))
            {
                
            }


        }

    }
}
