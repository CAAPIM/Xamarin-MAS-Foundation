using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth.Otp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpConstants']"
	[global::Android.Runtime.Register ("com/ca/mas/core/auth/otp/OtpConstants", DoNotGenerateAcw=true)]
	public partial class OtpConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpConstants']/field[@name='ACTION_DISPLAY_OTP_PROTECTED_DATA']"
		[Register ("ACTION_DISPLAY_OTP_PROTECTED_DATA")]
		public const string ActionDisplayOtpProtectedData = (string) "com.ca.mas.core.service.action.DISPLAY_OTP_PROTECTED_DATA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpConstants']/field[@name='IS_INVALID_OTP']"
		[Register ("IS_INVALID_OTP")]
		public const string IsInvalidOtp = (string) "IS_INVALID_OTP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpConstants']/field[@name='X_CA_ERR']"
		[Register ("X_CA_ERR")]
		public const string XCaErr = (string) "x-ca-err";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpConstants']/field[@name='X_OTP']"
		[Register ("X_OTP")]
		public const string XOtp = (string) "X-OTP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpConstants']/field[@name='X_OTP_CHANNEL']"
		[Register ("X_OTP_CHANNEL")]
		public const string XOtpChannel = (string) "X-OTP-CHANNEL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpConstants']/field[@name='X_OTP_RETRY']"
		[Register ("X_OTP_RETRY")]
		public const string XOtpRetry = (string) "X-OTP-RETRY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpConstants']/field[@name='X_OTP_RETRY_INTERVAL']"
		[Register ("X_OTP_RETRY_INTERVAL")]
		public const string XOtpRetryInterval = (string) "X-OTP-RETRY-INTERVAL";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/auth/otp/OtpConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OtpConstants); }
		}

		protected OtpConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpConstants']/constructor[@name='OtpConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OtpConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OtpConstants)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
