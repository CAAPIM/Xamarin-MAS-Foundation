// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Com.CA.Mas.Foundation;
using Org.Json;
using Java.Lang;


namespace BasicAuthSample
{
    [Activity(Label = "BasicAuthSample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our UI controls from the loaded layout
            Android.Widget.Button loginButton = FindViewById<Android.Widget.Button>(Resource.Id.login);
            loginButton.Click += (sender, e) =>
            {
                login();
            };

            Android.Widget.Button logoutButton = FindViewById<Android.Widget.Button>(Resource.Id.logout);
            logoutButton.Click += (sender, e) =>
            {
                logout();
            };

            Android.Widget.Button invokeApiButton = FindViewById<Android.Widget.Button>(Resource.Id.invokeApi);
            invokeApiButton.Click += (sender, e) =>
            {
                invokeApi();
            };

            MAS.SetAuthenticationListener(new MyAuthenticationListener());
            // MAS - start
            MAS.Start(Android.App.Application.Context, true);

            if (MAS.GetState(Android.App.Application.Context) == MASConstants.MasStateStarted)
                Alert("MAS", "CA Mobile SDK started successfully!!");
            else
                Alert("MAS", "CA Mobile SDK did not start!!");

        }

        public void login()
        {
            // Check if user is already authenticated
            if (MASUser.CurrentUser != null && MASUser.CurrentUser.IsAuthenticated)
            {
                Alert("MAS", "User already authenticated as " + MASUser.CurrentUser.UserName);
            }
            else
            {
                // Used only to trigger authentication with no callback
                MASUser.Login(null);
            }


        }

        public void logout()
        {
            // Check if user is already authenticated
            if (MASUser.CurrentUser != null && MASUser.CurrentUser.IsAuthenticated)
            {
                MASUser.CurrentUser.Logout(null);

                Alert("MAS", "User logged out");
            }
            else
            {
                Alert("MAS", "User is not authenticated");
            }
        }


        public void invokeApi()
        {

            MAS.Debug();
            Android.Net.Uri.Builder uriBuilder = new Android.Net.Uri.Builder();
            uriBuilder.AppendEncodedPath("protected/resource/products?operation=listProducts");
            MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());
            builder.ResponseBody(MASResponseBody.JsonBody());
            MAS.Invoke(builder.Build(), new ProtectAPICallback(this));

        }

        public void Alert(string Title, string Message)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(Title);
            alert.SetMessage(Message);
            alert.SetButton("OK", (c, ev) =>
            {
                // Ok button click 
            });
            alert.Show();
        }


        private class ProtectAPICallback : MASCallback
        {
            
            private MainActivity activity;
            public ProtectAPICallback(MainActivity activity)
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
                Console.WriteLine(e);
            }

            public override void OnSuccess(Java.Lang.Object result)
            {
                IMASResponse response = (IMASResponse)result;
                JSONObject jsonObject = (JSONObject)response.Body.Content;
                activity.Alert("Result", jsonObject.ToString(4));
            }

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

