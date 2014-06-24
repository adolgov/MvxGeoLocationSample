using Cirrious.MvvmCross.ViewModels;
using MvxGeoLocationSample.Core.ViewModels;

namespace MvxGeoLocationSample.Core
{
    public class App
        : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart(new MvxAppStart<TestViewModel>());
        }
    }
}
