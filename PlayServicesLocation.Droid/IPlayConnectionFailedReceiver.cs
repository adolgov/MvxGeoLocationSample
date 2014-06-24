using Android.Gms.Common;

namespace PlayServicesLocation.Droid
{
    public interface IPlayConnectionFailedReceiver
    {
        void OnConnectionFailed(ConnectionResult p0);
    }
}