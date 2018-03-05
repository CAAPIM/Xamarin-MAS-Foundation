using System;
using Android.OS;
using Com.CA.Mas.Foundation;
using Java.Lang;

namespace BasicAuthSample
{
    public class LockSessionCallback : MASCallback
    {
        private MainActivity activity;
        public LockSessionCallback(MainActivity activity)
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
            //Handle error
            activity.Alert("Session Lock", "Session Lock Failed!");
        }

        public override void OnSuccess(Java.Lang.Object result)
        {
            activity.Alert("Session Lock", "Session Locked!");
        }

    }
}
