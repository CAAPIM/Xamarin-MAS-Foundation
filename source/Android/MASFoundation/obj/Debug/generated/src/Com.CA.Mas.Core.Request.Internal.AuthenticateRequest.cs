using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Request.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='AuthenticateRequest']"
	[global::Android.Runtime.Register ("com/ca/mas/core/request/internal/AuthenticateRequest", DoNotGenerateAcw=true)]
	public partial class AuthenticateRequest : global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/request/internal/AuthenticateRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthenticateRequest); }
		}

		protected AuthenticateRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='AuthenticateRequest']/constructor[@name='AuthenticateRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthenticateRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AuthenticateRequest)) {
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
