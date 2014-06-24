using System;
using Android.Gms.Common;
using Android.OS;

namespace PlayServicesLocation.Droid
{
    public class PlayConnectionCallbacksListener
            : Java.Lang.Object
            , IGooglePlayServicesClientConnectionCallbacks
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
    }
}