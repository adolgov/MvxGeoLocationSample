using System;
using System.Windows.Input;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Plugins.Location;
using Cirrious.MvvmCross.ViewModels;

namespace MvxGeoLocationSample.Core.ViewModels
{
    public class TestViewModel 
        : MvxViewModel
    {
        private readonly IMvxLocationWatcher _locationWatcher;

        private bool _hasGpsLocation;
        private bool _started;

        public bool HasGpsLocation
        {
            get { return _hasGpsLocation; }
            set
            {
                _hasGpsLocation = value;
                RaisePropertyChanged(() => HasGpsLocation);
            }
        }

        public bool Started
        {
            get { return _started; }
            set
            {
                _started = value;
                RaisePropertyChanged(() => Started);
            }
        }

        private double _lng;
        public double Lng
        {
            get { return _lng; }
            set { _lng = value; RaisePropertyChanged(() => Lng); }
        }

        private double _lat;
        public double Lat
        {
            get { return _lat; }
            set { _lat = value; RaisePropertyChanged(() => Lat); }
        }

        public TestViewModel(IMvxLocationWatcher locationWatcher)
        {
            _locationWatcher = locationWatcher;
        }

        private MvxCommand _toggleGpsCommand;
        public ICommand ToggleGpsCommand
        {
            get
            {
                _toggleGpsCommand = _toggleGpsCommand ?? new MvxCommand(() =>
                {
                    if (!Started)
                        _locationWatcher.Start(
                            new MvxLocationOptions { Accuracy = MvxLocationAccuracy.Fine}, OnLocation, OnError);
                    else
                        _locationWatcher.Stop();
                    Started = !Started;
                });
                return _toggleGpsCommand;
            }
        }

        public void OnError(MvxLocationError obj)
        {
            Mvx.Trace(MvxTraceLevel.Error, "Failed to get location: {0}", obj.Code);
        }

        private void OnLocation(MvxGeoLocation location)
        {
            Lat = location.Coordinates.Latitude;
            Lng = location.Coordinates.Longitude;
            HasGpsLocation = true;
        }
    }
}