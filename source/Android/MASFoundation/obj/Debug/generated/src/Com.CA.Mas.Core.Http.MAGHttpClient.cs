using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGHttpClient']"
	[global::Android.Runtime.Register ("com/ca/mas/core/http/MAGHttpClient", DoNotGenerateAcw=true)]
	public partial class MAGHttpClient : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/http/MAGHttpClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGHttpClient); }
		}

		protected MAGHttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGHttpClient']/constructor[@name='MAGHttpClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MAGHttpClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MAGHttpClient)) {
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

		static Delegate cb_onConnectionObtained_Ljava_net_HttpURLConnection_;
#pragma warning disable 0169
		static Delegate GetOnConnectionObtained_Ljava_net_HttpURLConnection_Handler ()
		{
			if (cb_onConnectionObtained_Ljava_net_HttpURLConnection_ == null)
				cb_onConnectionObtained_Ljava_net_HttpURLConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionObtained_Ljava_net_HttpURLConnection_);
			return cb_onConnectionObtained_Ljava_net_HttpURLConnection_;
		}

		static void n_OnConnectionObtained_Ljava_net_HttpURLConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_connection)
		{
			global::Com.CA.Mas.Core.Http.MAGHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.HttpURLConnection connection = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (native_connection, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionObtained (connection);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionObtained_Ljava_net_HttpURLConnection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGHttpClient']/method[@name='onConnectionObtained' and count(parameter)=1 and parameter[1][@type='java.net.HttpURLConnection']]"
		[Register ("onConnectionObtained", "(Ljava/net/HttpURLConnection;)V", "GetOnConnectionObtained_Ljava_net_HttpURLConnection_Handler")]
		protected virtual unsafe void OnConnectionObtained (global::Java.Net.HttpURLConnection connection)
		{
			if (id_onConnectionObtained_Ljava_net_HttpURLConnection_ == IntPtr.Zero)
				id_onConnectionObtained_Ljava_net_HttpURLConnection_ = JNIEnv.GetMethodID (class_ref, "onConnectionObtained", "(Ljava/net/HttpURLConnection;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (connection);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionObtained_Ljava_net_HttpURLConnection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionObtained", "(Ljava/net/HttpURLConnection;)V"), __args);
			} finally {
			}
		}

	}
}
