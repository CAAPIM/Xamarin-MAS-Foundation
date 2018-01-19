﻿using Android.App;
using Android.Widget;
using Android.OS;
using Com.CA.Mas.Foundation;
using Xamarin.Forms;


namespace BasicAuthSample
{
    [Activity(Label = "BasicAuthSample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Forms.Init(this, savedInstanceState);

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

            MAS.SetAuthenticationListener(new MyAuthenticationListener(this));
            // MAS - start
            MAS.Start(Android.App.Application.Context, true);

            if (MAS.GetState(Android.App.Application.Context) == MASConstants.MasStateStarted)
                Alert("MAS", "MAS SDK started successfully!!");
            else
                Alert("MAS", "MAS SDK NOT started!!");

        }

        public void login()
        {
            // Check if user is already authenticated
            if (MASUser.CurrentUser != null && MASUser.CurrentUser.IsAuthenticated)
            {
                Alert("MAS", "User already authenticated as " + MASUser.CurrentUser.UserName);
            } else {
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

                Alert("MAS", "User logged out.");
            }
            else
            {
                Alert("MAS", "User is not authenticated.");
            }    
        }


        public void invokeApi()
        {

            MAS.Debug();
            Android.Net.Uri.Builder uriBuilder = new Android.Net.Uri.Builder();
            uriBuilder.AppendEncodedPath("protected/resource/products?operation=listProducts");
            MASRequestMASRequestBuilder builder = new MASRequestMASRequestBuilder(uriBuilder.Build());
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

    }
}

