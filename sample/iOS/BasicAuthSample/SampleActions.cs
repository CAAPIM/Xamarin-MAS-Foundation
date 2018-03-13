// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Foundation;
using MASFoundation;
using UIKit;

namespace BasicAuthSample
{
    public class SampleActions
    {
        public SampleActions()
        {
        }


        //
        //  Set grantFlow to Client Credentials
        //
        public static void SetGrantFlowToClientCredentials()
        {
            MAS.GrantFlow = MASGrantFlow.ClientCredentials;
            Alert("MAS.GrantFlow", "Flow is now Client Credentials");
        }


        //
        //  Set grantFlow to Password
        //
        public static void SetGrantFlowToPassword()
        {            
            MAS.GrantFlow = MASGrantFlow.Password;
            Alert("MAS.GrantFlow", "Flow is now Password Flow");
        }


        //
        // The following methods demonstrates the various ways to start the Mobile SDK
        //

        //
        // Start the SDK with default configuration
        //
        public static void StartSDK()
        {
            if (!isSDKAlreadyInitialized())
            {
                MAS.StartWithDefaultConfiguration(true, completion: checkSDKInitialization);
            }
        }


        //
        // Start the Mobile SDK after change the default configuration file
        //
        public static void StartSDKChangeDefaultConfig()
        {
            if (!isSDKAlreadyInitialized())
            {
                //MAS.SetConfigurationFileName("msso_config2");
                MAS.SetConfigurationFileName("msso_config_public");
                MAS.StartWithDefaultConfiguration(true, completion: checkSDKInitialization);     
            }
        }


        //
        // Start the Mobile SDK using the contents of an msso_config file saved in the projects root directory
        // Alternatively, you could use a custom json hard coded into mssoString variable
        //
        public static void StartSDKCustomJson()
        {
            if (!isSDKAlreadyInitialized())
            {
                var file = System.IO.File.Open("msso_config.json", System.IO.FileMode.Open);

                NSString mssoString;
                using (System.IO.StreamReader reader = new System.IO.StreamReader(file))
                {
                    mssoString = new NSString(reader.ReadToEnd());
                }
                NSData mssoData = NSData.FromString(mssoString);
                NSError parsingError;
                NSDictionary jsonConfig = (NSDictionary)NSJsonSerialization.Deserialize(mssoData, NSJsonReadingOptions.MutableLeaves, out parsingError);

                MAS.StartWithJSON(jsonConfig, completion: checkSDKInitialization);
            }
        }


        //
        // Start the Mobile SDK with the url of a file containing the msso_config you wish to use.
        // You must either have a config file named msso_config.json in the root directory of your project
        // or change the the file name in the NSUrl constructor.
        //
        public static void StartSDKFileUrl()
        {
            if (!isSDKAlreadyInitialized())
            {
                NSUrl nSUrl = new NSUrl("msso_config.json", false);
                MAS.StartWithURL(nSUrl, completion: checkSDKInitialization);  
            }          
        }


        //
        // Start the Mobile SDK using an enrolment URL
        //
        public static void StartSDKEnrolmentURL()
        {
            if(!isSDKAlreadyInitialized())
            {
                NSUrl nsUrl = new NSUrl(GetEnrollmentURL("https://mobile-staging-xamarinautomation.l7tech.com:8443",
                                              // This client id must match the client id of the config you are using
                                              "44fd840b-45e6-439f-9ff9-9976947d9e26"));

                MAS.StartWithURL(nsUrl, completion: checkSDKInitialization);
            }
        }


        //
        // Display a dialog with SDK Initialiation Status
        //
        private static void checkSDKInitialization(bool startCompletedSuccessfully, NSError error)
        {
            if (startCompletedSuccessfully)
            {
                // SDK initialized without an error
                Alert("MAS.Start", "CA Mobile SDK started successfully!");
            }
            else
            {
                //  SDK initialized with an error
                Alert("MAS.Start", "MAS Started did not start successfully.");
                Console.WriteLine("MAS Started did not start successfully. ERROR: " + error);
            }
        }


        //
        // Check if the SDK is already initialized
        //
        private static bool isSDKAlreadyInitialized()
        {
            bool isInitialized = (MAS.MASState == MASState.DidStart);
            if (isInitialized)
            {
                Alert("MAS.Start", "CA Mobile SDK has already been started.");
            }
            return isInitialized;
        }


        //
        //  Retrieve the Enrollment URL from the Gateway
        //
        private static string GetEnrollmentURL(string gatewayUrl, string clientId)
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


        //
        //  Login with username and password
        //
        public static void Login(string user, string password)
        {
            MASUser.LoginWithUserName(user, password, completion: (completed, error) =>
            {
                if (completed)
                {
                    // Logged in without an error
                    Alert("MAS.LoginWithUserName", "Welcome " + MASUser.CurrentUser.UserName);
                }

                if (error != null)
                {
                    // Logged in with an error
                    Alert("MAS.LoginWithUserName", "ERROR: " + error.LocalizedDescription);
                }
            });
        }


        //
        // Display a custom login dialog to the user
        //
        public static void ShowLogin()
        {
            if (MAS.MASState == MASState.DidStart)
            {
                if (MASUser.CurrentUser != null)
                {
                    Alert("MAS.LoginWithUserName", "User already logged in");
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
                Alert("MAS.LoginWithUserName", "You must initialize the SDK before logging in");
            }
        }


        //
        // Call the login using credentials provided in the ShowLogin dialog
        //
        public static void ProcessLogin(object sender, UIButtonEventArgs e)
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


        //
        // Invoke a sample protected endpoint in the Gateway and display the returned JSON in a dialog
        //
        public static void InvokeProtectedAPI()
        {
            if (MAS.MASState != MASState.NotInitialized)
            {
                //  Create MASRequestBuilder with HTTP method 
                MASRequestBuilder requestBuilder = new MASRequestBuilder("GET");

                //
                //  Specify an endpoint path, any parameters or headers, and request/response type
                //
                requestBuilder.EndPoint = "/protected/resource/products";
                requestBuilder.Body = new NSDictionary("operation", "listProducts");

                //  Build MASRequestBuilder to convert into MASRequest object
                MASRequest request = requestBuilder.Build();

                //  Using MASRequest object, invoke API
                MAS.Invoke(request, completion: (response, responseObject, error) =>
                {
                    if (error != null)
                    {
                        //  If an error was returned
                        Console.WriteLine("Error: {0}", error.LocalizedDescription);
                        Alert("MAS.Invoke", error.LocalizedDescription);
                    }
                    else if (responseObject != null)
                    {
                        Console.WriteLine("Success: {0}", responseObject.ToString());
                        Alert("MAS.Invoke", responseObject.ToString());
                    }
                });

            }
            else
            {
                Alert("MAS.Invoke", "You must initialize the SDK before calling API");
            }
        }


        //
        //  Logout currently authenticated user
        //
        public static void Logout()
        {
            if (MASUser.CurrentUser != null)
            {
                MASUser.CurrentUser.LogoutWithCompletion(completion: (completed, error) =>
                {
                    if (error != null)
                    {
                        // Logged out with an error
                        Alert("MAS.LogoutWithCompletion", "ERROR: " + error.LocalizedDescription);
                    }
                    else if (completed)
                    {
                        // Logged out without an error
                        Alert("MAS.LogoutWithCompletion", "Logout completed successfully");
                    }
                });
            }
            else
            {
                // Logged out without an error
                Alert("MAS.LogoutWithCompletion", "No user logged in");
            }

        }


        //
        // Lock current user session with device's local authentication
        // This will block most of operations except for MASUser.CurrentUser.LogoutWithCompletion()
        // and MASDevice.CurrentDevice().DeregisterWithCompletion()
        //
        public static void LockSession()
        {
            if (MASUser.CurrentUser != null)
            {
                // Lock Session
                MASUser.CurrentUser.LockSessionWithCompletion(completion: (completed, error) =>
                {
                    if (error != null)
                    {
                        // Error
                        Alert("MAS.LockSessionWithCompletion", "ERROR: " + error.LocalizedDescription);
                    }
                    else if (completed)
                    {
                        // Session locked without an error
                        Alert("MAS.LockSessionWithCompletion", "Session Locked!");
                    }
                });
            }
            else
            {
                Alert("MAS.LockSessionWithCompletion", "User is not authenticated");
            }
        }


        //
        // Unlock current user session and unblock all of the operations through SDK
        //
        public static void UnlockSession()
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
                            Alert("MAS.UnlockSessionWithCompletion", "ERROR: " + error.LocalizedDescription);
                        }
                        else if (completed)
                        {
                            // Session unlocked without error
                            Alert("MAS.UnlockedSessionWithCompletion", "Session Unlocked!");
                        }
                    });
                }
                else
                {
                    Alert("MAS.UnlockedSessionWithCompletion", "Session is not locked!");
                }
            }
            else
            {
                Alert("MAS.UnlockedSessionWithCompletion", "User is not authenticated");
            }
        }


        //
        //  Deregister the device is an advanced feature available available in MASDevice. 
        //  It will remove the device's registered record in the Gateway and then clear all credentials
        //
        public static void DeregisterDevice()
        {
            MASDevice.CurrentDevice().DeregisterWithCompletion(completion: (deregisteredSuccessfully, error) =>
            {
                if (deregisteredSuccessfully)
                    Alert("MAS", "Device deregistered successfully.");
                if (error != null)
                    Alert("MAS", "Failed to deregister device: " + error.LocalizedDescription);
            });
        }


        //
        // Display a dialog to the user 
        //
        public static void Alert(string title, string message)
        {
            UIAlertView alert = new UIAlertView()
            {
                Title = title,
                Message = message
            };
            alert.AddButton("OK");
            alert.Show();
        }


    }
}
