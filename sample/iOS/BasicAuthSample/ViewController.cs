// Copyright (c) 2018 CA. All rights reserved.
// This software is provided under the terms of CA’s Pre-Release Agreement.
// See the LICENSE [https://github.com/CAAPIM/Xamarin-MAS-Foundation/blob/LICENSE.md] file for details. 
// This software is for evaluation purposes only and currently not supported by CA.

using System;
using System.Threading.Tasks;
using UIKit;
using MASFoundation;
using Foundation;

namespace BasicAuthSample
{
    public partial class ViewController : UIViewController
    {
        //
        // The following methods are used by the UIButtons in the Main.storyboard
        //
        partial void GrantFlowToPassword_TouchUpInside(UIButton sender)
        {
            SampleActions.SetGrantFlowToPassword();
        }


        partial void GrantFlowToClientCredentials_TouchUpInside(UIButton sender)
        {
            SampleActions.SetGrantFlowToClientCredentials();
        }


        async partial void StartSDKButton_TouchUpInside(UIButton sender)
        {
            // Comment/Uncomment desired start method (One uncommented at a time)
            await SampleActions.StartSDKAsync();
            //await SampleActions.StartSDKChangeDefaultConfigAsync();
            //await SampleActions.StartSDKCustomJsonAsync();
            //await SampleActions.StartSDKFileUrlAsync();
            //await SampleActions.StartSDKEnrolmentURLAsync();
        }


        async partial void InvokeAPIButton_TouchUpInside(UIButton sender)
        {
            var invokeResult = await SampleActions.InvokeProtectedAPIAsync();

            if (invokeResult != null)
                SampleActions.Alert("Response", invokeResult.ResponseObject.ToString());
        }

        partial void MultiPartFormButton_TouchUpInside(UIButton sender)
        {

            //SampleActions.PostMultiPartForm();
            if (MAS.MASState != MASState.DidStart)
            {
                Alert("MAS.Invoke", "You must initialize the SDK before calling API");
            }
            else
            {
                try
                {
                    //  Create MASRequestBuilder with HTTP method 
                    MASRequestBuilder requestBuilder = new MASRequestBuilder("POST");
                    //
                    //  Specify an endpoint path, any parameters or headers, and request/response type
                    //
                    requestBuilder.EndPoint = "/test/multipart/";
                    requestBuilder.RequestType = MASRequestResponseType.FormData;
                    requestBuilder.Header = new NSDictionary("test", "test");
                    requestBuilder.Body = new NSDictionary("name", "aditya");
                    requestBuilder.ResponseType = MASRequestResponseType.TextPlain;
                    //  Build MASRequestBuilder to convert into MASRequest object
                    MASRequest request = requestBuilder.Build();

                    NSUrl fileURL = null;

                    UIImagePickerController picker = new UIImagePickerController();
                    picker = new UIImagePickerController();

                    // set our source to the photo library
                    picker.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;

                    // set what media types
                    picker.MediaTypes = UIImagePickerController.AvailableMediaTypes(UIImagePickerControllerSourceType.PhotoLibrary);

                    picker.FinishedPickingMedia += (object sender1, UIImagePickerMediaPickedEventArgs e) =>
                    {
                        Console.WriteLine("Image url is - " + e.ImageUrl);
                        fileURL = e.ImageUrl;
                        picker.DismissModalViewController(true);
                        MAS.PostMultiPartForm(request, (formData) =>
                        {
                            NSError error = null;
                            formData.appendPartWithFileURL(fileURL, "aditya.jpg", out error);
                        }, (prog) =>
                        {
                            InvokeOnMainThread(() =>
                            {
                                progressBar.Hidden = false;
                                progressBar.Progress = (float)prog.FractionCompleted;
                            });

                        }, (response, responseObject, error) =>
                        {
                            if (error != null)
                            {
                                progressBar.Hidden = true;
                                //  If an error was returned
                                Console.WriteLine("Error: {0}", error.LocalizedDescription);
                                Alert("MAS.PostMultipartForm", error.LocalizedDescription);
                            }
                            else if (responseObject != null)
                            {
                                //  If a response is returned
                                progressBar.Hidden = true;
                                Console.WriteLine("Success: {0}", responseObject.Description);
                                Alert("MAS.PostMultipartForm", responseObject.Description);
                            }
                        });
                    };
                    picker.Canceled += (sender1, evt) =>
                    {
                        Console.WriteLine("picker cancelled");
                        picker.DismissModalViewController(true);
                    };
                    UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(picker, true, null);
                }
                catch (Exception ex)
                {
                    Alert("MAS.PostMultipartForm", "MAS PostMultiPartForm could not be completed successfully. Check log to see the exception details.");
                    Console.WriteLine("MAS PostMultiPartForm could not be completed successfully. ERROR: " + ex.Message);
                }
            }
        }


        async partial void LogoutButton_TouchUpInside(UIButton sender)
        {
            await SampleActions.LogoutAsync();
        }


        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            SampleActions.ShowLogin();
        }


        async partial void LockButton_TouchUpInside(UIButton sender)
        {
            await SampleActions.LockSessionAsync();
        }


        async partial void UnlockButton_TouchUpInside(UIButton sender)
        {
            await SampleActions.UnlockSessionAsync();
        }


        async partial void DeregisterButton_TouchUpInside(UIButton sender)
        {
            await SampleActions.DeregisterDeviceAsync();
        }


        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }


        //
        // Set the grant flow type and MAS.SetUserAuthCredentials after load the view
        //
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            progressBar.Hidden = true;

            //MAS.SetGatewayNetworkActivityLogging(true);

            // Set the grant from to password in order to trigger implicit login flow
            MAS.GrantFlow = MASGrantFlow.Password;

            //
            // Set the MAS.SetUserAuthCredentials block. It must be set before invoking an API   
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
                                        SampleActions.Alert("MAS.SetUserAuthCredentials", "ERROR: " + error.LocalizedDescription);
                                     }
                                     else
                                     {
                                        SampleActions.Alert("MAS.SetUserAuthCredentials", "Welcome " + MASUser.CurrentUser.UserName);
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


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
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
