using System;
using Android.Util;
using Cirrious.CrossCore.Platform;

namespace MvxGeoLocationSample
{
    public class DebugTrace : IMvxTrace
    {
        public void Trace(MvxTraceLevel level, string tag, Func<string> message)
        {
            switch (level)
            {
                case MvxTraceLevel.Error:
                    Log.Error(tag, message());
                break;
                case MvxTraceLevel.Diagnostic:
                    Log.Debug(tag, message());
                break;
                case MvxTraceLevel.Warning:
                    Log.Warn(tag, message());
                break;
            }
        }

        public void Trace(MvxTraceLevel level, string tag, string message)
        {
            switch (level)
            {
                case MvxTraceLevel.Error:
                    Log.Error(tag, message);
                    break;
                case MvxTraceLevel.Diagnostic:
                    Log.Debug(tag, message);
                    break;
                case MvxTraceLevel.Warning:
                    Log.Warn(tag, message);
                    break;
            }
        }

        public void Trace(MvxTraceLevel level, string tag, string message, params object[] args)
        {
            try
            {
                switch (level)
                {
                    case MvxTraceLevel.Error:
                        Log.Error(tag, string.Format(message, args));
                        break;
                    case MvxTraceLevel.Diagnostic:
                        Log.Debug(tag, string.Format(message, args));
                        break;
                    case MvxTraceLevel.Warning:
                        Log.Warn(tag, string.Format(message, args));
                        break;
                }
            }
            catch (FormatException)
            {
                Trace(MvxTraceLevel.Error, tag, "Exception during trace of {0} {1} {2}", level, message);
            }
        }
    }
}
