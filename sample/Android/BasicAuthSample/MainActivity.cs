// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using Android.App;
using Android.Widget;
using Android.OS;
using Com.CA.Mas.Foundation;
using Android.Content;
using Org.Json;
using System.Threading.Tasks;

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
            Button setPasswordFlowButton = FindViewById<Button>(Resource.Id.setPasswordFlow);
            Button startSDKButton = FindViewById<Button>(Resource.Id.startSDK);
            Button loginButton = FindViewById<Button>(Resource.Id.login);
            Button invokeApiButton = FindViewById<Button>(Resource.Id.invokeApi);
            Button logoutButton = FindViewById<Button>(Resource.Id.logout);
            Button lockSessionButton = FindViewById<Button>(Resource.Id.lockSession);
            Button unlockSessionButton = FindViewById<Button>(Resource.Id.unlockSession);
            Button deregisterButton = FindViewById<Button>(Resource.Id.deregister);

            //
            // Button Actions
            //

            setClientCredentialsFlowButton.Click += (sender, e) =>
            {
                // MAS.SetGrantFlow(int type)
                MAS.SetGrantFlow(MASConstants.MasGrantFlowClientCredentials);
                Alert("MAS", "Grant flow set to Client Credentials Flow!");
            };

            setPasswordFlowButton.Click += (sender, e) =>
            {
                // MAS.SetGrantFlow(int type)
                MAS.SetGrantFlow(MASConstants.MasGrantFlowPassword);
                Alert("MAS", "Grant flow set to Password Flow!");
            };

            startSDKButton.Click += (sender, e) =>
            {
                // Comment/Uncomment desired start method (One uncommented at a time)
                SampleActions.startSDK(this);
                //SampleActions.startSDKChangeDefaultConfig(this);
                //SampleActions.startSDKCustomJson(this);
                //SampleActions.startSDKFileUrl(this);
                //SampleActions.startSDKEnrolmentURL(this);
            };

            //
            // Log in button action. See MyAuthenticationListener.cs for details on MASUser.Login();
            //
            loginButton.Click += async (sender, e) =>
            {
                // Check if user is already authenticated
                if (MASUser.CurrentUser != null)
                {
                    Alert("MAS", "User already authenticated as " + MASUser.CurrentUser.UserName);
                }
                else
                {
                    // Used only to trigger authentication with no callback
                    try
                    {
                        var user = await MASUser.LoginAsync();

                    } catch (Java.Lang.Throwable exception) {
                        Alert("Error", exception.ToString());
                        MAS.CancelAllRequests();
                    }
                }
            };

            //
            // Invoke a sample protected endpoint in the Gateway and display the returned JSON in a dialog
            //
            invokeApiButton.Click += async (sender, e) =>
            {
                try { 
                    //Use Uri.Builder() to build the Uri and pass it into a MASRequestBuilder.
                    Android.Net.Uri.Builder uriBuilder = new Android.Net.Uri.Builder();

                    //Append path
                    uriBuilder.AppendEncodedPath("protected/resource/products?operation=listProducts");

                    //Create MASRequestBuilder
                    MASRequestBuilder builder = new MASRequestBuilder(uriBuilder.Build());

                    //Add Response type
                    builder.ResponseBody(MASResponseBody.JsonBody());

                    //Invoke the API with builder
                    var response = await MAS.InvokeAsync(builder.Build());

                    JSONObject jsonObject = (JSONObject)response.Body.Content;
                    Alert("Response", jsonObject.ToString(4));

                } catch (Java.Lang.Throwable exception) {
                    Alert("MAS", exception.LocalizedMessage);
                }
            };

            //
            // Logs out current user
            //
            logoutButton.Click += async (sender, e) =>
            {
                if (MASUser.CurrentUser != null)
                {
                    try
                    {
                        await MASUser.CurrentUser.LogoutAsync();
                        Alert("MAS", "User Logout");
                    }
                    catch (Java.Lang.Throwable)
                    {
                        Alert("MAS", "User Logout Failed");
                    }
                }
                else
                {
                    Alert("MAS", "User is not authenticated");
                }
            };

            //
            // Lock current user session with device's local authentication
            // This will block most of operations except for MASUser.CurrentUser.Logout()
            // and MASDevice.CurrentDevice().Deregister()
            //
            lockSessionButton.Click += async (sender, e) =>
            {
                if (MASUser.CurrentUser != null)
                {
                    try
                    {
                        await MASUser.CurrentUser.LockSessionAsync();
                        Alert("Session Lock", "Session Locked!");
                    } catch (Java.Lang.Throwable) {
                        Alert("Session Lock", "Session Locked Failed!");
                    }
                }
                else
                {
                    Alert("MAS", "User is not authenticated");
                }
            };

            //
            // Unlock current user session and unblock all of the operations through SDK
            //
            unlockSessionButton.Click += async (sender, e) =>
            {
                if (MASUser.CurrentUser != null)
                {
                    if (MASUser.CurrentUser.IsSessionLocked)
                    {
                        //Unlock session
                        try
                        {
                            await MASUser.CurrentUser.UnlockSessionAsync();
                        } catch (MASUser.UserAuthenticationRequiredException) {
                            KeyguardManager keyguardManager = (KeyguardManager)Application.Context.GetSystemService(Context.KeyguardService);
                            Intent intent = keyguardManager.CreateConfirmDeviceCredentialIntent("Session Unlock", "Provide PIN or FingerPrint to unlock session.");
                            StartActivityForResult(intent, 1);
                        } catch (Java.Lang.Throwable) {
                            Alert("Session Unlock", "Session Unlocked Failed!");
                        }
                    }
                    else
                    {
                        Alert("Session Unlock", "Session not locked!");
                    }
                }
                else
                {
                    Alert("Session Unlock", "User not authenticated");
                }
            };

            //
            //  Deregister the device is an advanced feature available available in MASDevice. 
            //  It will remove the device's registered record in the Gateway and then clear all credentials
            //
            deregisterButton.Click += async (sender, e) =>
            {
                try {
                    await MASDevice.CurrentDevice.DeregisterAsync();
                    Alert("MASDevice", "Device Deregister");
                } catch (Java.Lang.Throwable) {
                    Alert("MASDevice", "Deregister Failed!");
                }
               
            };

            MAS.SetAuthenticationListener(new MyAuthenticationListener());
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

        protected override async void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (requestCode == 1)
            {
                // Credentials entered successfully!
                if (resultCode == Result.Ok)
                {
                    //Call unlock again after activity
                    try {
                        await MASUser.CurrentUser.UnlockSessionAsync();
                        Alert("MAS", "Session Unlocked!");
                    } catch(Java.Lang.Throwable) {
                        Alert("MAS", "Session Unlocked Failed!");
                    }

                }
            }
        }
    }
}

