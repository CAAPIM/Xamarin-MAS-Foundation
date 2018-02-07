﻿// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System;
using Android.Content;
using Com.CA.Mas.Foundation;
using Com.CA.Mas.Foundation.Auth;
using Android.App;
using Android.Widget;
using Org.Json;
using Java.Lang;
using Android.OS;

namespace BasicAuthSample
{
    public class MyAuthenticationListener : Java.Lang.Object, IMASAuthenticationListener
    {
        public void OnAuthenticateRequest(Context context, long requestId, MASAuthenticationProviders providers)
        {
            
            ((Activity)context).RunOnUiThread(new ShowPopUp((Activity)context));
        }

        public void OnOtpAuthenticateRequest(Context context, MASOtpAuthenticationHandler handler)
        {
            throw new NotImplementedException();
        }
    }

    public class ShowPopUp : Java.Lang.Object, Java.Lang.IRunnable
    {
        private Context context;
        public ShowPopUp(Context context)
        {
            this.context = context;
        }

        public void Run()
        {
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
                MASUser.Login(username.Text, password.Text.ToCharArray(), new LoginCallback((MainActivity)context));

            });

            alert.SetButton2("Cancel", (c, ev) =>
            {
                MAS.CancelAllRequests();
                alert.Cancel();
            });

            alert.Show();
        }

        private class LoginCallback : MASCallback
        {

            private MainActivity activity;
            public LoginCallback(MainActivity activity)
            {
                this.activity = activity;
            }

            public override Android.OS.Handler Handler
            {
                //run the callback on main thread
                get
                {
                    return new Android.OS.Handler(Looper.MainLooper);
                }
            }

            public override void OnError(Throwable e)
            {
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
}
