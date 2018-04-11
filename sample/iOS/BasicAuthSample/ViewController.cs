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

            SampleActions.Alert("Response", invokeResult.ResponseObject.ToString());
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


    }
}
