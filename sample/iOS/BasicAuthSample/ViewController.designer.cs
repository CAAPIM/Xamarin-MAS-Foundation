// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BasicAuthSample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DeregisterButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GrantFlowToClientCredentials { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GrantFlowToPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton InvokeAPIButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LockButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LogoutButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton StartSDKButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton UnlockButton { get; set; }

        [Action ("DeregisterButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DeregisterButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("GrantFlowToClientCredentials_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GrantFlowToClientCredentials_TouchUpInside (UIKit.UIButton sender);

        [Action ("GrantFlowToPassword_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GrantFlowToPassword_TouchUpInside (UIKit.UIButton sender);

        [Action ("InvokeAPIButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void InvokeAPIButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("LockButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LockButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("LoginButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LoginButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("LogoutButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LogoutButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("StartSDKButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StartSDKButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("UnlockButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UnlockButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (DeregisterButton != null) {
                DeregisterButton.Dispose ();
                DeregisterButton = null;
            }

            if (GrantFlowToClientCredentials != null) {
                GrantFlowToClientCredentials.Dispose ();
                GrantFlowToClientCredentials = null;
            }

            if (GrantFlowToPassword != null) {
                GrantFlowToPassword.Dispose ();
                GrantFlowToPassword = null;
            }

            if (InvokeAPIButton != null) {
                InvokeAPIButton.Dispose ();
                InvokeAPIButton = null;
            }

            if (LockButton != null) {
                LockButton.Dispose ();
                LockButton = null;
            }

            if (LoginButton != null) {
                LoginButton.Dispose ();
                LoginButton = null;
            }

            if (LogoutButton != null) {
                LogoutButton.Dispose ();
                LogoutButton = null;
            }

            if (StartSDKButton != null) {
                StartSDKButton.Dispose ();
                StartSDKButton = null;
            }

            if (UnlockButton != null) {
                UnlockButton.Dispose ();
                UnlockButton = null;
            }
        }
    }
}