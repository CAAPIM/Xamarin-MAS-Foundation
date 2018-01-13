using System;
using Android.Content;
using Com.CA.Mas.Foundation;
using Com.CA.Mas.Foundation.Auth;
using Android.App;

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
            MASUser.Login("admin", "7layer".ToCharArray(), new LoginCallback(context));
        }

        public void OnOtpAuthenticateRequest(Context p0, MASOtpAuthenticationHandler p1)
        {
            throw new NotImplementedException();
        }

  
    }
}
