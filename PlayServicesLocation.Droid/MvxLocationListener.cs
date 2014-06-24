// MvxLocationListener.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com


using Android.Locations;
using Android.OS;
using ILocationListener = Android.Gms.Location.ILocationListener;

namespace PlayServicesLocation.Droid
{
    public class MvxLocationListener
        : Java.Lang.Object
        , ILocationListener
    {
        private readonly IMvxLocationReceiver _owner;

        public MvxLocationListener(IMvxLocationReceiver owner)
        {
            _owner = owner;
        }

        public void OnLocationChanged(Location p0)
        {
            _owner.OnLocationChanged(p0);
        }
    }
}