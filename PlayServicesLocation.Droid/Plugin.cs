using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;
using MvvmCross.Plugins.Location;

namespace PlayServicesLocation.Droid
{
    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterSingleton<IMvxLocationWatcher>(() => new PlayServicesLocationWatcher());
        }
    }
}