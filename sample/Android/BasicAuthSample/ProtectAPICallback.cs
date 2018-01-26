using System;
using Com.CA.Mas.Foundation;
using Java.Lang;
using Org.Json;
using Android.App;
using Android.OS;

namespace BasicAuthSample
{
    public class ProtectAPICallback : MASCallback
    {
        private Activity context;

        public ProtectAPICallback(Activity context)
        {
            this.context = context;
        }

        public override Android.OS.Handler Handler
        {
            get
            {
                return new Android.OS.Handler(Looper.MainLooper);
            }
        }

        public override void OnError(Throwable p0)
        {
            Console.WriteLine(p0);
        }

        public override void OnSuccess(Java.Lang.Object result)
        {
            IMASResponse response = (IMASResponse) result;
            JSONObject jsonObject = (JSONObject)response.Body.Content;
            Alert("Result", jsonObject.ToString(4));
        }

        public void Alert(string Title, string Message)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(context);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(Title);
            alert.SetMessage(Message);
            alert.SetButton("OK", (c, ev) =>
            {
                // Ok button click 
            });
            alert.Show();
        }
    }
}
