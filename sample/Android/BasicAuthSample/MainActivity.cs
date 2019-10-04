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
            Button uploadFile = FindViewById<Button>(Resource.Id.uploadFile);
            Button logoutButton = FindViewById<Button>(Resource.Id.logout);
            Button lockSessionButton = FindViewById<Button>(Resource.Id.lockSession);
            Button unlockSessionButton = FindViewById<Button>(Resource.Id.unlockSession);
            Button deregisterButton = FindViewById<Button>(Resource.Id.deregister);

            //
            // Button Actions
            //

            setClientCredentialsFlowButton.Click += (sender, e) =>
            {
				SampleActions.SetGrantFlowToClientCredential(this);
            };

            setPasswordFlowButton.Click += (sender, e) =>
            {
				SampleActions.SetGrantFlowToPassword(this);
            };

            startSDKButton.Click += (sender, e) =>
            {
                // Comment/Uncomment desired start method (One uncommented at a time)
                SampleActions.StartSDK(this);
                //SampleActions.StartSDKChangeDefaultConfig(this);
                //SampleActions.StartSDKCustomJson(this);
                //SampleActions.StartSDKFileUrl(this);
                //SampleActions.StartSDKEnrolmentURL(this);
            };

            //
            // Log in button action. See MyAuthenticationListener.cs for details on MASUser.Login();
            //
            loginButton.Click += async (sender, e) =>
            {
				await SampleActions.LoginAsync(this);
            };

            //
            // Invoke a sample protected endpoint in the Gateway and display the returned JSON in a dialog
            //
            invokeApiButton.Click += async (sender, e) =>
            {
				await SampleActions.InvokeApiAsync(this);
            };

            //
            // Upload multi-part form data
            //
            uploadFile.Click += async (sender, e) =>
            {
                await SampleActions.PostMultiPartFormAsync(this);
            };

            //
            // Logs out current user
            //
            logoutButton.Click += async (sender, e) =>
            {
				await SampleActions.LogoutAsync(this);
            };

            //
            // Lock current user session with device's local authentication
            // This will block most of operations except for MASUser.CurrentUser.Logout()
            // and MASDevice.CurrentDevice().Deregister()
            //
            lockSessionButton.Click += async (sender, e) =>
            {
				await SampleActions.LockSessionAsync(this);
            };

            //
            // Unlock current user session and unblock all of the operations through SDK
            //
            unlockSessionButton.Click += async (sender, e) =>
            {
				await SampleActions.UnLockSessionAsync(this);
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

        public void ConfirmCredential()
		{
			KeyguardManager keyguardManager = (KeyguardManager)Application.Context.GetSystemService(Context.KeyguardService);
            Intent intent = keyguardManager.CreateConfirmDeviceCredentialIntent("Session Unlock", "Provide PIN or FingerPrint to unlock session.");
            StartActivityForResult(intent, 1);			
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

