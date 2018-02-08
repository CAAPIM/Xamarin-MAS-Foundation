// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System;

using UIKit;
using MASFoundation;
using Foundation;

namespace BasicAuthSample
{
    public partial class ViewController : UIViewController
    {
        partial void GrantFlowToPassword_TouchUpInside(UIButton sender)
        {
            SetGrantFlowToPassword();
        }

        partial void GrantFlowToClientCredentials_TouchUpInside(UIButton sender)
        {
            SetGrantFlowToClientCredentials();
        }

        partial void StartSDKButton_TouchUpInside(UIButton sender)
        {
            StartSDK();
        }

        partial void InvokeAPIButton_TouchUpInside(UIButton sender)
        {
            invokeProtectedAPI();
        }

        partial void LogoutButton_TouchUpInside(UIButton sender)
        {
            Logout();
        }

        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            ShowLogin();
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //MAS.SetGatewayNetworkActivityLogging(true);
            MAS.GrantFlow = MASGrantFlow.Password;

            //
            //  MAS.GrantFlow must be set to MASGrantFlow.Password in order to trigger implicit login flow
            //  MAS.SetUserAuthCredentials block must be set before invoking an API
            // 
            MAS.SetUserAuthCredentials((authCredentialsBlock) => {

                var userName = String.Empty;
                var password = String.Empty;

                UIAlertView alert = new UIAlertView();
                alert.AlertViewStyle = UIAlertViewStyle.LoginAndPasswordInput;
                alert.Title = "MAS.LoginWithUserName";
                alert.AddButton("Login");
                alert.AddButton("Cancel");
                alert.Message = "Please enter your username and password";
                alert.Clicked += ((object sender, UIButtonEventArgs e) =>
                     {
                            UIAlertView parent_alert = (UIAlertView)sender;

                            if (e.ButtonIndex == 0)
                            {
                                // OK button
                                userName = parent_alert.GetTextField(0).Text;
                                password = parent_alert.GetTextField(1).Text;

                                 //  Build MASAuthCredentialsPassword with username and password
                                 MASAuthCredentialsPassword passwordCredentials = MASAuthCredentialsPassword.InitWithUsername(userName, password);

                                 //  Invoke callback block, authCredentialsBlock, with MASAuthCredentialsPassword object
                                 authCredentialsBlock(passwordCredentials, false, (bool completed, NSError error) =>
                                 {
                                     if (error != null)
                                     {
                                        ShowAlert("MAS.SetUserAuthCredentials", "ERROR: " + error.LocalizedDescription);
                                     }
                                     else
                                     {
                                        ShowAlert("MAS.SetUserAuthCredentials", "Welcome " + MASUser.CurrentUser.UserName);
                                     }
                                 });
                            }
                            else
                            {
                             // Cancel button
                             authCredentialsBlock(null, true, null);

                            }

                        });
                alert.Show();
            });

            //
            //  Initialize SDK always with default configuration
            // 
            StartSDK();
        }

        private void invokeProtectedAPI()
        {
            if (MAS.MASState != MASState.NotInitialized)
            {
                //  Create MASRequestBuilder with HTTP method 
                MASRequestBuilder requestBuilder = new MASRequestBuilder("GET");

                //
                //  Specify an endpoint path, any parameters or headers, and request/response type
                //
                requestBuilder.EndPoint = "/protected/resource/products";
                requestBuilder.SetQueryParameter("operation", "listProducts");
                requestBuilder.RequestType = MASRequestResponseType.WwwFormUrlEncoded;
                requestBuilder.ResponseType = MASRequestResponseType.Json;

                //  Build MASRequestBuilder to convert into MASRequest object
                MASRequest request = requestBuilder.Build();

                //  Using MASRequest object, invoke API
                MAS.Invoke(request, completion: (responseInfo, error) =>
                {
                    if (error != null)
                    {
                        //  If an error was returned
                        Console.WriteLine("Error: {0}", error.LocalizedDescription);
                    }
                    else if (responseInfo != null)
                    {
                        //  If a response is returned
                        string value = "No value";
                        //  MAG iOS Mobile SDK's response structure in JSON
                        if (responseInfo.ContainsKey(new NSString("MASResponseInfoBodyInfoKey")))
                        {
                            NSDictionary values = responseInfo;
                            value = values[NSObject.FromObject("MASResponseInfoBodyInfoKey")].ToString();
                        }
                        Console.WriteLine("Success: {0}", value);
                        ShowAlert("MAS.Invoke", value);
                    }
                });
            } else 
            {
                ShowAlert("MAS.Invoke", "You must initialize the SDK before calling API");
            }
        }


        //
        //  Login with username and password
        //
        private void Login(string user,string password)
        {
            MASUser.LoginWithUserName(user, password, completion: (completed, error) =>
            {
                if (completed)
                {
                    // Logged in without an error
                    ShowAlert("MAS.LoginWithUserName", "Welcome " + MASUser.CurrentUser.UserName);
                }

                if (error != null)
                {
                    // Logged in with an error
                    ShowAlert("MAS.LoginWithUserName", "ERROR: " + error.LocalizedDescription);
                }
            });
        }


        //
        //  Logout currently authenticated user
        //
        private void Logout()
        {
            if(MASUser.CurrentUser != null)
            {
                MASUser.CurrentUser.LogoutWithCompletion(completion: (completed, error) =>
                {
                    if (error != null)
                    {
                        // Logged out with an error
                        ShowAlert("MAS.LogoutWithCompletion", "ERROR: " + error.LocalizedDescription);
                    }
                    else if (completed)
                    {
                        // Logged out without an error
                        ShowAlert("MAS.LogoutWithCompletion", "Logout completed successfully");
                    }
                });               
            }
            else
            {
                // Logged out without an error
                ShowAlert("MAS.LogoutWithCompletion", "No user logged in");
            }

        }

        private void StartSDK()
        {
            //
            //  Initialize SDK always with default configuration
            // 
            if (MAS.MASState == MASState.DidStart) 
            {
                ShowAlert("MAS.Start", "CA Mobile SDK already started.");
            } else 
            {
                MAS.StartWithDefaultConfiguration(true, completion: (completed, error) =>
                {
                    if (completed)
                    {
                        //  SDK initialized without an error
                        ShowAlert("MAS.Start", "CA Mobile SDK started successfully!!");
                    }
                    if (error != null)
                    {
                        //  SDK initialized with an error
                        ShowAlert("MAS.Start", "ERROR: " + error.LocalizedDescription);
                    }
                });  
            }

        }

        private void SetGrantFlowToPassword()
        {
            //  Set grantFlow to Password
            MAS.GrantFlow = MASGrantFlow.Password;
            ShowAlert("MAS.GrantFlow", "Flow is now Password Flow");
        }

        private void SetGrantFlowToClientCredentials()
        {
            //  Set grantFlow to Client Credentials
            MAS.GrantFlow = MASGrantFlow.ClientCredentials;
            ShowAlert("MAS.GrantFlow", "Flow is now Client Credentials");
        }

        private void ShowAlert(string title, string message)
        {
            UIAlertView alert = new UIAlertView()
            {
                Title = title,
                Message = message
            };
            alert.AddButton("OK");
            alert.Show();
        }

        private void ShowLogin()
        {

            if (MASUser.CurrentUser != null) {
                ShowAlert("MAS.LoginWithUserName", "User already logged in");
            } else
            {
                UIAlertView alert = new UIAlertView();

                alert.AlertViewStyle = UIAlertViewStyle.LoginAndPasswordInput;
                alert.Title = "MAS.LoginWithUserName";
                alert.AddButton("Login");
                alert.AddButton("Cancel");
                alert.Message = "Please enter your username and password";
                alert.Clicked += ProcessLogin;
                alert.Show();   
            }
        }

        public void ProcessLogin(object sender, UIButtonEventArgs e)
        {
            UIAlertView parent_alert = (UIAlertView)sender;

            if (e.ButtonIndex == 0)
            {
                // OK button
                string user = parent_alert.GetTextField(0).Text;
                string password = parent_alert.GetTextField(1).Text;

                Login(user, password);
            }
            else
            {
                // Cancel button
            }

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }
    }
}
