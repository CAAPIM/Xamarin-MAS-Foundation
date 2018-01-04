using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Request.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='OAuthTokenRequest']"
	[global::Android.Runtime.Register ("com/ca/mas/core/request/internal/OAuthTokenRequest", DoNotGenerateAcw=true)]
	public partial class OAuthTokenRequest : global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='OAuthTokenRequest']/field[@name='ACCESSTOKEN']"
		[Register ("ACCESSTOKEN")]
		public const string Accesstoken = (string) "accesstoken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='OAuthTokenRequest']/field[@name='EXPIRY']"
		[Register ("EXPIRY")]
		public const string Expiry = (string) "expiry";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='OAuthTokenRequest']/field[@name='REFRESHTOKEN']"
		[Register ("REFRESHTOKEN")]
		public const string Refreshtoken = (string) "refreshtoken";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/request/internal/OAuthTokenRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthTokenRequest); }
		}

		protected OAuthTokenRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='OAuthTokenRequest']/constructor[@name='OAuthTokenRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OAuthTokenRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OAuthTokenRequest)) {
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
