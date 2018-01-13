using System;
using Android.App;
using Com.CA.Mas.Foundation;
using Java.Lang;
using Android.OS;

namespace BasicAuthSample
{
    public class LoginCallback : MASCallback
    {
        private Activity context;
        public LoginCallback(Activity activity)
        {
            this.context = activity;
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
            Console.WriteLine("Fail Login!!");
            Console.WriteLine(p0);
        }

        public override void OnSuccess(Java.Lang.Object user)
        {
            Console.WriteLine("Success Login!!");
            Alert(((MASUser)user).DisplayName, ((MASUser)user).AsJSONObject.ToString(4));

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
