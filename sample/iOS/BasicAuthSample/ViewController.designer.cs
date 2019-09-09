// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
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
		UIKit.UIButton MultiPartFormButton { get; set; }

		[Outlet]
		UIKit.UIProgressView progressBar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton StartSDKButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton UnlockButton { get; set; }

		[Action ("DeregisterButton_TouchUpInside:")]
		partial void DeregisterButton_TouchUpInside (UIKit.UIButton sender);

		[Action ("GrantFlowToClientCredentials_TouchUpInside:")]
		partial void GrantFlowToClientCredentials_TouchUpInside (UIKit.UIButton sender);

		[Action ("GrantFlowToPassword_TouchUpInside:")]
		partial void GrantFlowToPassword_TouchUpInside (UIKit.UIButton sender);

		[Action ("InvokeAPIButton_TouchUpInside:")]
		partial void InvokeAPIButton_TouchUpInside (UIKit.UIButton sender);

		[Action ("LockButton_TouchUpInside:")]
		partial void LockButton_TouchUpInside (UIKit.UIButton sender);

		[Action ("LoginButton_TouchUpInside:")]
		partial void LoginButton_TouchUpInside (UIKit.UIButton sender);

		[Action ("LogoutButton_TouchUpInside:")]
		partial void LogoutButton_TouchUpInside (UIKit.UIButton sender);

		[Action ("MultiPartFormButton_TouchUpInside:")]
		partial void MultiPartFormButton_TouchUpInside (UIKit.UIButton sender);

		[Action ("StartSDKButton_TouchUpInside:")]
		partial void StartSDKButton_TouchUpInside (UIKit.UIButton sender);

		[Action ("UnlockButton_TouchUpInside:")]
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

			if (MultiPartFormButton != null) {
				MultiPartFormButton.Dispose ();
				MultiPartFormButton = null;
			}

			if (StartSDKButton != null) {
				StartSDKButton.Dispose ();
				StartSDKButton = null;
			}

			if (UnlockButton != null) {
				UnlockButton.Dispose ();
				UnlockButton = null;
			}

			if (progressBar != null) {
				progressBar.Dispose ();
				progressBar = null;
			}
		}
	}
}
