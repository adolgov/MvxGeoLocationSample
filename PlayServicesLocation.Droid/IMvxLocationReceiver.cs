using Android.Locations;

namespace PlayServicesLocation.Droid
{
    public interface IMvxLocationReceiver
    {
        void OnLocationChanged(Location p0);
    }
}