using Android.Gms.Common;
using Android.Gms.Common.Apis;

namespace PlayServicesLocation.Droid
{
    public class PlayConnectionFailedListener
        : Java.Lang.Object
        , IGoogleApiClientOnConnectionFailedListener
    {
        private readonly IPlayConnectionFailedReceiver _owner;

        public PlayConnectionFailedListener(IPlayConnectionFailedReceiver owner)
        {
            _owner = owner;
        }

        public void OnConnectionFailed(ConnectionResult p0)
        {
            _owner.OnConnectionFailed(p0);
        }
    }
}