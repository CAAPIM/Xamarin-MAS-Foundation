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
                SampleActions.SetGrantFlowToClientCredential(this);
            };

            setPasswordFlowButton.Click += (sender, e) =>
            {
                SampleActions.SetGrantFlowToPassword(this);
            };

            startSDKButton.Click += (sender, e) =>
            {
                // Comment/Uncomment desired start method (One uncommented at a time)
                //SampleActions.startSDK(this);
                SampleActions.startSDKChangeDefaultConfig(this);
                //SampleActions.startSDKCustomJson(this);
                //SampleActions.startSDKFileUrl(this);
                //SampleActions.startSDKEnrolmentURL(this);
            };

            loginButton.Click += (sender, e) =>
            {
                SampleActions.login(this);
            };

            invokeApiButton.Click += async (sender, e) =>
            {
                var response = await SampleActions.InvokeApi();

                JSONObject jsonObject = (JSONObject)response.Body.Content;
                Alert("Response", jsonObject.ToString(4));
            };

            logoutButton.Click += (sender, e) =>
            {
                SampleActions.logout(this);
            };

            lockSessionButton.Click += (sender, e) =>
            {
                SampleActions.lockSession(this);
            };

            unlockSessionButton.Click += (sender, e) =>
            {
                SampleActions.unLockSession(this);
            };

            deregisterButton.Click += (sender, e) =>
            {
                SampleActions.deregister(this);
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
    }
}

