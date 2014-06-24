using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MvxGeoLocationSample.Views
{
    [Activity(Label = "View for TestViewModel")]
    public class TestView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TestView);
        }
    }
}