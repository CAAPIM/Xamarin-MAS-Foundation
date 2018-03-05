using System;
using Android.OS;
using Com.CA.Mas.Foundation;
using Java.Lang;

namespace BasicAuthSample
{
    public class DeregisterCallback : MASCallback
    {
        private MainActivity activity;
        public DeregisterCallback(MainActivity activity)
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
            activity.Alert("Deregister", "Did not successfully deregister!");
        }

        public override void OnSuccess(Java.Lang.Object result)
        {
            activity.Alert("Deregister", "Device successfully deregistered!");
        }
    }
}
