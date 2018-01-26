using System;
using Android.Content;
using Com.CA.Mas.Foundation;
using Com.CA.Mas.Foundation.Auth;
using Android.App;
using Android.Widget;
using Xamarin.Forms;

namespace BasicAuthSample
{
    public class MyAuthenticationListener : Java.Lang.Object, IMASAuthenticationListener
    {
        private Activity context;
        public MyAuthenticationListener(Activity activity)
        {
            this.context = activity;
        }

        public void OnAuthenticateRequest(Context p0, long p1, MASAuthenticationProviders p2)
        {

            Device.BeginInvokeOnMainThread(()=> {
                AlertDialog.Builder dialog = new AlertDialog.Builder(context);
                EditText username = new EditText(context);
                EditText password = new EditText(context);
                LinearLayout layout = new LinearLayout(context);

                username.Hint = "Username";
                password.Hint = "Password";

                layout.AddView(username);
                layout.AddView(password);
                layout.Orientation = Orientation.Vertical;

                AlertDialog alert = dialog.Create();
                alert.SetView(layout);
                alert.SetTitle("Login");
                alert.SetCancelable(true);

                alert.SetButton("Login", (c, ev) => {
                    MASUser.Login(username.Text, password.Text.ToCharArray(), new LoginCallback(context));

                });

                alert.SetButton2("Cancel", (c, ev) =>
                {
                    MAS.CancelAllRequests();
                    alert.Cancel();
                });

                alert.Show();
            });
        }

        public void OnOtpAuthenticateRequest(Context p0, MASOtpAuthenticationHandler p1)
        {
            throw new NotImplementedException();
        }

  
    }
}
