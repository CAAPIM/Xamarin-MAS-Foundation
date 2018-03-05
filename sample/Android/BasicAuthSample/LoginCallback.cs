using System;
using Android.OS;
using Com.CA.Mas.Foundation;
using Java.Lang;

namespace BasicAuthSample
{
    public class LoginCallback : MASCallback
    {

        private MainActivity activity;
        public LoginCallback(MainActivity activity)
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
            Console.WriteLine("Fail Login!!");
            Console.WriteLine(e);
            activity.Alert("Error", e.ToString());
            MAS.CancelAllRequests();
        }

        public override void OnSuccess(Java.Lang.Object result)
        {
            Console.WriteLine("Success Login!!");
            activity.Alert(((MASUser)result).DisplayName, ((MASUser)result).AsJSONObject.ToString(4));

        }
    }
}
