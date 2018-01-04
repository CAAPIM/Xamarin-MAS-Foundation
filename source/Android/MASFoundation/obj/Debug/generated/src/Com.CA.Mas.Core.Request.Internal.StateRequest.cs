using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Request.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='StateRequest']"
	[global::Android.Runtime.Register ("com/ca/mas/core/request/internal/StateRequest", DoNotGenerateAcw=true)]
	public partial class StateRequest : global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='StateRequest']/field[@name='ACCESS_TOKEN']"
		[Register ("ACCESS_TOKEN")]
		public const string AccessToken = (string) "access_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='StateRequest']/field[@name='CLIENT_ID']"
		[Register ("CLIENT_ID")]
		public const string ClientId = (string) "client_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='StateRequest']/field[@name='MAG_IDENTIFIER']"
		[Register ("MAG_IDENTIFIER")]
		public const string MagIdentifier = (string) "mag_identifier";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/request/internal/StateRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StateRequest); }
		}

		protected StateRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='StateRequest']/constructor[@name='StateRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StateRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StateRequest)) {
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
