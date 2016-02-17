using System;
using Android.Gms.Common;
using Android.OS;
using Android.Gms.Common.Apis;

namespace PlayServicesLocation.Droid
{
    public class PlayConnectionCallbacksListener
            : Java.Lang.Object
            , GoogleApiClient.IConnectionCallbacks
    {
        private readonly IPlayConnectionCallbacksReceiver _owner;

        public PlayConnectionCallbacksListener(IPlayConnectionCallbacksReceiver owner)
        {
            _owner = owner;
        }

        public void OnConnected(Bundle p0)
        {
            _owner.OnConnected(p0);
        }

        public void OnDisconnected()
        {
            _owner.OnDisconnected();
        }

        public void OnConnectionSuspended(int cause)
        {
            throw new NotImplementedException();
        }
    }
}