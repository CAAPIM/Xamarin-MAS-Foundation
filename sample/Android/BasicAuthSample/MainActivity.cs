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
using Android.Content;


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
            Button setClientCredentialsFlowButton = FindViewById<Button>(Resource.Id.setClientCredentialsFlow);
            setClientCredentialsFlowButton.Click += (sender, e) =>
            {
                // MAS.SetGrantFlow(int type)
                // Set Grant flow to Client Credentials
                MAS.SetGrantFlow(MASConstants.MasGrantFlowClientCredentials);
                Alert("MAS", "Grant flow set to Client Credentials Flow!");
            };

            Button setPasswordFlowButton = FindViewById<Button>(Resource.Id.setPasswordFlow);
            setPasswordFlowButton.Click += (sender, e) =>
            {
                // MAS.SetGrantFlow(int type);
                // Set Grant flow to Password
                MAS.SetGrantFlow(MASConstants.MasGrantFlowPassword);
                Alert("MAS", "Grant flow set to Password Flow!");
            };

            Button startSDKButton = FindViewById<Button>(Resource.Id.startSDKButton);
            startSDKButton.Click += (sender, e) =>
            {
                startSDK();
            };

            Button loginButton = FindViewById<Button>(Resource.Id.login);
            loginButton.Click += (sender, e) =>
            {
                login();
            };

            Button invokeApiButton = FindViewById<Button>(Resource.Id.invokeApi);
            invokeApiButton.Click += (sender, e) =>
            {
                invokeApi();
            };


            Button logoutButton = FindViewById<Button>(Resource.Id.logout);
            logoutButton.Click += (sender, e) =>
            {
                logout();
            };

            Button lockSessionButton = FindViewById<Button>(Resource.Id.lockSession);
            lockSessionButton.Click += (sender, e) =>
            {
                lockSession();
            };
            Button unlockSessionButton = FindViewById<Button>(Resource.Id.unlockSession);
            unlockSessionButton.Click += (sender, e) =>
            {
                unLockSession();
            };

            MAS.SetAuthenticationListener(new MyAuthenticationListener());

            startSDK();
        }

        public void startSDK()
        {
            if (MAS.GetState(Application.Context) == MASConstants.MasStateStarted)
            {
                Alert("MAS", "CA Mobile SDK has already been started.");
            } else
            {
                // MAS.Start(Context, context, bool shouldUseDefault);
                MAS.Start(this, true);

                if (MAS.GetState(Application.Context) == MASConstants.MasStateStarted)
                    Alert("MAS", "CA Mobile SDK started successfully!!");
                else
                    Alert("MAS", "CA Mobile SDK did not start!!");
            }

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

            //Use Uri.Builder() to build the Uri and pass it into a MASRequestBuilder.
            Android.Net.Uri.Builder uriBuilder = new Android.Net.Uri.Builder();

            //Append path
            uriBuilder.AppendEncodedPath("protected/resource/products?operation=listProducts");

            //Create MASRequestBuilder
            MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());

            //Add Response type
            builder.ResponseBody(MASResponseBody.JsonBody());

            //Invoke the API with builder and API Callback
            MAS.Invoke(builder.Build(), new ProtectAPICallback(this));

        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (requestCode == 1)
            {
                // Credentials entered successfully!
                if (resultCode == Result.Ok)
                {
                    //Call unlock again after activity
                    MASUser.CurrentUser.UnlockSession(new UnlockCallback(this));
                }
            }
        }

        private void unLockSession()
        {
            try 
            {
                if (MASUser.CurrentUser.IsSessionLocked) {
                    //Unlock session
                    MASUser.CurrentUser.UnlockSession(new UnlockCallback(this));
                }
                else
                {
                    Alert("MAS", "Session not locked!");
                }
            } 
            catch (NullReferenceException e) 
            {
                Alert("MAS", "User not authenticated");
            }
        }

        private class UnlockCallback : MASSessionUnlockCallback
        {
            private MainActivity activity;
            public UnlockCallback(MainActivity activity)
            {
                this.activity = activity;
            }

            public override void OnError(Throwable e)
            {
                //Handle error
                activity.Alert("Session Unlock", "Session Unlocked Failed!");
            }

            public override void OnSuccess(Java.Lang.Object result)
            {
                activity.Alert("Session Unlock", "Session Unlocked!");
            }

            public override void OnUserAuthenticationRequired()
            {
                KeyguardManager keyguardManager = (KeyguardManager)Application.Context.GetSystemService(Context.KeyguardService);
                Intent intent = keyguardManager.CreateConfirmDeviceCredentialIntent("Session Unlock", "Provide PIN or FingerPrint to unlock session.");
                activity.StartActivityForResult(intent, 1);
            }
        }


        private void lockSession()
        {
            //Check that a user is logged in
            if (MASUser.CurrentUser != null && MASUser.CurrentUser.IsAuthenticated)
            {
                //Lock session
                MASUser.CurrentUser.LockSession(new LockSessionCallback(this));
            }
            else
            {
                Alert("MAS", "User is not authenticated");
            }
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

        private class LoginCallback : MASCallback
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

        private class LockSessionCallback : MASCallback
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
}

