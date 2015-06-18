using System.Threading;
using System.Windows;
using Coligo.Core;
using Coligo.Platform.Container;
using WpfVideoPlayerColigo.ViewModels;

namespace WpfVideoPlayer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            DefaultContainer container = new DefaultContainer();

            var sc = SynchronizationContext.Current;
            ColigoEngine.Initialize(container);

            container.AsSingle<MainWindowViewModel>();


        }
    }
}
