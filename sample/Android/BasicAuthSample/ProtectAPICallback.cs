using System;
using Android.OS;
using Com.CA.Mas.Foundation;
using Java.Lang;
using Org.Json;

namespace BasicAuthSample
{
    public class ProtectAPICallback : MASCallback
    {
        private MainActivity activity;
        public ProtectAPICallback(MainActivity activity)
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
            activity.Alert("Access API", e.ToString());
            Console.WriteLine(e);
        }

        public override void OnSuccess(Java.Lang.Object result)
        {
            IMASResponse response = (IMASResponse)result;
            JSONObject jsonObject = (JSONObject)response.Body.Content;
            activity.Alert("Result", jsonObject.ToString(4));
        }
    }
}
