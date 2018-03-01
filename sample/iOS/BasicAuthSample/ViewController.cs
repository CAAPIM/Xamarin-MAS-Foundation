// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using UIKit;
using MASFoundation;
using Foundation;
using System.Collections.Generic;

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

        partial void LockButton_TouchUpInside(UIButton sender)
        {
            LockSession();
        }

        partial void UnlockButton_TouchUpInside(UIButton sender)
        {
            UnlockSession();
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
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

            string responseString = "";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(gatewayUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", "admin"),
                    new KeyValuePair<string, string>("sub", "administrator"),
                    new KeyValuePair<string, string>("client_id", clientId)
                });
                var response = client.PostAsync("/connect/device/enrollment", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    responseString = responseContent.ReadAsStringAsync().Result;
                }
            }

            return responseString;
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
                        ShowAlert("MAS.Invoke", error.LocalizedDescription);
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

        // This method demonstrates the various ways to start the Mobile SDK
        // Simply uncomment whichever segment you wish to use and comment out 
        // all others including segment 0
        private void StartSDK()
        {
            //
            //  Initialize SDK always with default configuration
            // 
            if (MAS.MASState == MASState.DidStart)
            {
                ShowAlert("MAS.Start", "CA Mobile SDK already started.");
            }
            else
            {
                // --------------------- START OF SEGMENT 0 --------------------------------------
                MAS.StartWithDefaultConfiguration(true, completion: (completed, error) =>
                {
                    if (completed)
                    {
                        //  SDK initialized without an error
                        ShowAlert("MAS.Start", "CA Mobile SDK started successfully!");
                    }
                    if (error != null)
                    {
                        // SDK initialized with an error
                        ShowAlert("MAS.Start", "ERROR: " + error.LocalizedDescription);
                    }
                });
                // --------------------- START OF SEGMENT 0 --------------------------------------


                // The following code segment demonstrates how to start the Mobile SDK
                // using the contents of an msso_config file saved in the projects root directory
                // To use a different file, simply change the file open in the next line
                // Alternatively, you could use a custom json hard coded into mssoString variable

                // --------------------- START OF SEGMENT 1 --------------------------------------
                //var file = System.IO.File.Open("msso_config.json", System.IO.FileMode.Open);

                //NSString mssoString;
                //using (System.IO.StreamReader reader = new System.IO.StreamReader(file))
                //{
                //    mssoString = new NSString(reader.ReadToEnd());
                //}
                //NSData mssoData = NSData.FromString(mssoString);
                //NSError parsingError;
                //NSDictionary jsonConfig = (NSDictionary)NSJsonSerialization.Deserialize(mssoData, NSJsonReadingOptions.MutableLeaves, out parsingError);

                //MAS.StartWithJSON(jsonConfig, completion: (startCompletedSuccessfully, error) =>
                //{
                //    if (startCompletedSuccessfully)
                //        // SDK initialized without an error
                //        ShowAlert("MAS.Start", "CA Mobile SDK started successfully!");
                //    else
                //        Console.WriteLine("MAS Started did not start successfully." + error);
                //});
                // --------------------- END OF SEGMENT 1 --------------------------------------


                // The following code segment demonstrates how to start the Mobile SDK
                // with the url of a file containing the msso_config you wish to use.
                // For this segment, you must either have a config file named msso_config.json
                // in the root directory of your project or change the the file name in the 
                // NSUrl constructor.

                // --------------------- START OF SEGMENT 2 --------------------------------------
                //NSUrl nSUrl = new NSUrl("msso_config.json", false);
                //MAS.StartWithURL(nSUrl, completion: (startCompletedSuccessfully, error) =>
                //{
                //    if (startCompletedSuccessfully)
                ////  SDK initialized without an error
                //          ShowAlert("MAS.Start", "CA Mobile SDK started successfully with file url!");
                //    else
                //        Console.WriteLine("MAS Started did not start successfully." + error);
                //});
                // --------------------- END OF SEGMENT 2--------------------------------------


                // The following code segment demonstrates how to change the 
                // default configuration file used whenever you call
                // the MAS.StartWithDefaultConfiguration method

                // --------------------- START OF SEGMENT 3 --------------------------------------
                //MAS.SetConfigurationFileName("msso_config2");
                //MAS.StartWithDefaultConfiguration(true, completion: (completed, error) =>
                //{
                //    if (completed)
                //    {
                //        //  SDK initialized without an error
                //        ShowAlert("MAS.Start", "CA Mobile SDK started successfully with secondary configuration!");
                //    }
                //    if (error != null)
                //    {
                //        //  SDK initialized with an error
                //        ShowAlert("MAS.Start", "ERROR: " + error.LocalizedDescription);
                //    }
                //});
                // --------------------- END OF SEGMENT 3 --------------------------------------


                // The following code segment shows how to start the Mobile SDK using an enrolment URL

                // --------------------- START OF SEGMENT 4 --------------------------------------
                //NSUrl nsUrl = new NSUrl(GetEnrollmentURLAsync("https://mobile-staging-xamarinautomation.l7tech.com:8443",
                //                                              // This client id must match the client id of the config you are using
                //                                              "44fd840b-45e6-439f-9ff9-9976947d9e26"));

                //MAS.StartWithURL(nsUrl, completion: (startCompletedSuccessfully, error) =>
                //{
                //    if (startCompletedSuccessfully)
                //    {
                //        //  SDK initialized without an error
                //        ShowAlert("MAS.Start", "CA Mobile SDK started successfully with enrolment URL!");
                //    }
                //    if (error != null)
                //    {
                //        //  SDK initialized with an error
                //        ShowAlert("MAS.Start", "ERROR: " + error.LocalizedDescription);
                //    }
                //});
                // --------------------- END OF SEGMENT 4 --------------------------------------
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
            if (MAS.MASState == MASState.DidStart)
            {
                if (MASUser.CurrentUser != null)
                {
                    ShowAlert("MAS.LoginWithUserName", "User already logged in");
                }
                else
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
            else
            {
                ShowAlert("MAS.LoginWithUserName", "You must initialize the SDK before logging in");
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

        public void LockSession()
        {
            if (MASUser.CurrentUser != null)
            {
                // Lock Session
                MASUser.CurrentUser.LockSessionWithCompletion(completion: (completed, error) =>
                {
                    if (error != null)
                    {
                        // Error
                        ShowAlert("MAS.LockSessionWithCompletion", "ERROR: " + error.LocalizedDescription);
                    }
                    else if (completed)
                    {
                        // Session locked without an error
                        ShowAlert("MAS.LockSessionWithCopmletion", "Session Locked!");
                    }
                });
            }
            else
            {
                ShowAlert("MAS", "User is not authenticated");
            }
        }

        public void UnlockSession()
        {
            if (MASUser.CurrentUser != null)
            {
                if (MASUser.CurrentUser.IsSessionLocked)
                {
                    // Unlock Session
                    MASUser.CurrentUser.UnlockSessionWithCompletion(completion: (completed, error) =>
                     {
                         if (error != null)
                         {
                             // Error
                             ShowAlert("MAS.UnlockSessionWithCompletion", "ERROR: " + error.LocalizedDescription);
                         }
                         else if (completed)
                         {
                             // Session unlocked without error
                             ShowAlert("MAS.UnlockedSessionWithCompletion", "Session Unlocked!");
                         }
                     });
                }
                else
                {
                    ShowAlert("MAS", "Session is not locked!");
                }
            }
            else
            {
                ShowAlert("MAS", "User is not authenticated");
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }
    }
}
