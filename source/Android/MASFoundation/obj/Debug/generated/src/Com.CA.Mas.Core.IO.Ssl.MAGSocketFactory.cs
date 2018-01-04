using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.IO.Ssl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.io.ssl']/class[@name='MAGSocketFactory']"
	[global::Android.Runtime.Register ("com/ca/mas/core/io/ssl/MAGSocketFactory", DoNotGenerateAcw=true)]
	public partial class MAGSocketFactory : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/io/ssl/MAGSocketFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGSocketFactory); }
		}

		protected MAGSocketFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_foundation_MASSecurityConfiguration_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.io.ssl']/class[@name='MAGSocketFactory']/constructor[@name='MAGSocketFactory' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASSecurityConfiguration']]"
		[Register (".ctor", "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V", "")]
		public unsafe MAGSocketFactory (global::Com.CA.Mas.Foundation.IMASSecurityConfiguration config)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (config);
				if (((object) this).GetType () != typeof (MAGSocketFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_foundation_MASSecurityConfiguration_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_foundation_MASSecurityConfiguration_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_foundation_MASSecurityConfiguration_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_foundation_MASSecurityConfiguration_, __args);
			} finally {
			}
		}

		static Delegate cb_createTLSSocketFactory;
#pragma warning disable 0169
		static Delegate GetCreateTLSSocketFactoryHandler ()
		{
			if (cb_createTLSSocketFactory == null)
				cb_createTLSSocketFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateTLSSocketFactory);
			return cb_createTLSSocketFactory;
		}

		static IntPtr n_CreateTLSSocketFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.IO.Ssl.MAGSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IO.Ssl.MAGSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateTLSSocketFactory ());
		}
#pragma warning restore 0169

		static IntPtr id_createTLSSocketFactory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io.ssl']/class[@name='MAGSocketFactory']/method[@name='createTLSSocketFactory' and count(parameter)=0]"
		[Register ("createTLSSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", "GetCreateTLSSocketFactoryHandler")]
		public virtual unsafe global::Javax.Net.Ssl.SSLSocketFactory CreateTLSSocketFactory ()
		{
			if (id_createTLSSocketFactory == IntPtr.Zero)
				id_createTLSSocketFactory = JNIEnv.GetMethodID (class_ref, "createTLSSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createTLSSocketFactory), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createTLSSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
