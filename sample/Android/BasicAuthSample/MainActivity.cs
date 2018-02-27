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
using System.IO;
using System.Net;

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
                // Comment/Uncomment desired start method (One uncommented at a time)
                startSDK();
                //startSDKChangeDefaultConfig();
                //startSDKCustomJson();
                //startSDKFileUrl();
                //startSDKEnrolmentURL();
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

        }

        public void startSDK()
        {
            if (!checkSDKAlreadyInitialized())
            {
                // MAS.Start(Context context, bool shouldUseDefault);
                MAS.Start(this, true);

                checkSDKInitialized();
            }

        }

        // Start SDK with default after changing the default configuration file
        public void startSDKChangeDefaultConfig() {

            if (!checkSDKAlreadyInitialized())
            {

                // Change the default Configuration
                MAS.SetConfigurationFileName("custom.json");
                // MAS.Start(Context context, bool shouldUseDefault);
                MAS.Start(this, true);

                checkSDKInitialized();
            }
        }

        // Start SDK with a custom JSON Object
        public void startSDKCustomJson() {

            if (!checkSDKAlreadyInitialized())
            {
                //Reads existing msso config file and saves as a JSONObject
                string mssoString = "";
                Stream inputStream = Application.Context.Assets.Open("msso_config.json");
                using (StreamReader reader = new StreamReader(inputStream))
                {
                    mssoString = reader.ReadToEnd();
                }
                JSONObject mssoJson = new JSONObject(mssoString);

                // MAS.Start(Context context, JSONObject mssoJSON);
                MAS.Start(this, mssoJson);

                checkSDKInitialized();
            }
        }

        // Start SDK with a File URL
        public void startSDKFileUrl() {

            if (!checkSDKAlreadyInitialized())
            {
                //Reads existing msso config and saves as a JSONObject
                string mssoString = "";
                Stream inputStream = Application.Context.Assets.Open("msso_config.json");
                using (StreamReader reader = new StreamReader(inputStream))
                {
                    mssoString = reader.ReadToEnd();
                }
                JSONObject mssoJson = new JSONObject(mssoString);

                //Saves JSONObject as a new json file in file directory
                var path = Path.Combine(Application.Context.FilesDir.Path, "test.json");
                var fs = new FileStream(path, System.IO.FileMode.Create);
                var outputWriter = new Java.IO.OutputStreamWriter(fs);
                outputWriter.Write(mssoString);
                outputWriter.Close();

                // MAS.Start(Context context, URL fileUrl);
                MAS.Start(this, new Java.Net.URL("file:" + path));

                checkSDKInitialized();
            }
        }

        // Start SDK with an enrolment URL
        public void startSDKEnrolmentURL() {

            if (!checkSDKAlreadyInitialized())
            {
                // Get Enrolment URL
                Java.Net.URL enrolmentUrl = new Java.Net.URL(this.GetEnrollmentURLAsync("https://mobile-staging-xamarinautomation.l7tech.com:8443", "65437eae-a3fb-4c9c-843c-16a876064e07"));

                // MAS.Start(Context context, URL enrolmentUrl, MASCallback callback);
                MAS.Start(this, enrolmentUrl, new StartWithEnrollmentCallback(this));
            }
        }


        public void login()
        {
            // Check if user is already authenticated
            if (MASUser.CurrentUser != null)
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
            if (MASUser.CurrentUser != null)
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
            if (MASUser.CurrentUser != null)
            {
                if (MASUser.CurrentUser.IsSessionLocked)
                {
                    //Unlock session
                    MASUser.CurrentUser.UnlockSession(new UnlockCallback(this));
                }
                else
                {
                    Alert("MAS", "Session not locked!");
                }
            }
            else {
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
            if (MASUser.CurrentUser != null)
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

        protected void checkSDKInitialized()
        {
            if (MAS.GetState(Application.Context) == MASConstants.MasStateStarted)
                Alert("MAS", "CA Mobile SDK started successfully!!");
            else
                Alert("MAS", "CA Mobile SDK did not start!!");
        }

        protected bool checkSDKAlreadyInitialized() {
            bool isInitialized = MAS.GetState(Application.Context) == MASConstants.MasStateStarted;
            if (isInitialized)
            {
                Alert("MAS", "CA Mobile SDK has already been started.");
            }
            return isInitialized;
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

        //
        //  Usage: 
        //  string result = this.GetEnrollmentURLAsync("https://mobile-staging-iosautomation.l7tech.com:8443", "3d6fcaf7-2146-4bf7-8f57-0a8c8e425198");
        //
        public string GetEnrollmentURLAsync(string gatewayUrl, string clientId)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback +=
            (sender, cert, chain, sslPolicyErrors) =>
            {
                if (cert != null) System.Diagnostics.Debug.WriteLine(cert);
                return true;
            };
            string thisUri = gatewayUrl + "/connect/device/enrollment";
            string postData = "username=admin&sub=administrator&client_id=" + clientId;

            string responseString = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(thisUri);
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";

            byte[] data = System.Text.Encoding.ASCII.GetBytes(postData);
            request.ContentLength = data.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            //request

            HttpWebResponse myResp = (HttpWebResponse)request.GetResponse();

            using (var response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    responseString = reader.ReadToEnd();
                }
            }
            return responseString;
        }

        private class StartWithEnrollmentCallback : MASCallback
        {
            private MainActivity activity;
            public StartWithEnrollmentCallback(MainActivity activity) {
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
                Console.WriteLine(e.StackTrace);
            }

            public override void OnSuccess(Java.Lang.Object result)
            {
                activity.checkSDKInitialized();
            }
        }
    }
}

