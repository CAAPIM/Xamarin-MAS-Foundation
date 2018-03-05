using System;
using Android.OS;
using Com.CA.Mas.Foundation;
using Java.Lang;

namespace BasicAuthSample
{
    public class StartWithEnrollmentCallback : MASCallback
    {
        private MainActivity activity;
        public StartWithEnrollmentCallback(MainActivity activity)
        {
            this.activity = activity;
        }

        public override Handler Handler
        {
            //run the callback on main thread
            get
            {
                return new Handler(Looper.MainLooper);
            }
        }

        public override void OnError(Throwable e)
        {
            Console.WriteLine(e.StackTrace);
        }

        public override void OnSuccess(Java.Lang.Object result)
        {
            SampleActions.checkSDKInitialized(activity);
        }
    }
}
