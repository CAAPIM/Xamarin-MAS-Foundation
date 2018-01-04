using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginNFC']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASProximityLoginNFC", DoNotGenerateAcw=true)]
	public partial class MASProximityLoginNFC : global::Com.CA.Mas.Core.Auth.NFCRenderer, global::Com.CA.Mas.Foundation.Auth.IMASProximityLogin {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/auth/MASProximityLoginNFC", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASProximityLoginNFC); }
		}

		protected MASProximityLoginNFC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginNFC']/constructor[@name='MASProximityLoginNFC' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASProximityLoginNFC ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASProximityLoginNFC)) {
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

		static IntPtr id_authorize_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginNFC']/method[@name='authorize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("authorize", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "")]
		public static unsafe void Authorize (string authenticateUrl, global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_authorize_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_authorize_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "authorize", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_authenticateUrl = JNIEnv.NewString (authenticateUrl);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_authenticateUrl);
				__args [1] = new JValue (@callback);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_authorize_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authenticateUrl);
			}
		}

		static Delegate cb_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_Handler ()
		{
			if (cb_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ == null)
				cb_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, bool>) n_Init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_);
			return cb_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_;
		}

		static bool n_Init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, long requestId, IntPtr native_providers)
		{
			global::Com.CA.Mas.Foundation.Auth.MASProximityLoginNFC __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASProximityLoginNFC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders providers = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders> (native_providers, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Init (activity, requestId, providers);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginNFC']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='long'] and parameter[3][@type='com.ca.mas.foundation.auth.MASAuthenticationProviders']]"
		[Register ("init", "(Landroid/app/Activity;JLcom/ca/mas/foundation/auth/MASAuthenticationProviders;)Z", "GetInit_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_Handler")]
		public virtual unsafe bool Init (global::Android.App.Activity activity, long requestId, global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders providers)
		{
			if (id_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ == IntPtr.Zero)
				id_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/app/Activity;JLcom/ca/mas/foundation/auth/MASAuthenticationProviders;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (activity);
				__args [1] = new JValue (requestId);
				__args [2] = new JValue (providers);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/app/Activity;JLcom/ca/mas/foundation/auth/MASAuthenticationProviders;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASProximityLoginNFC __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASProximityLoginNFC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginNFC']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASProximityLoginNFC __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASProximityLoginNFC> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginNFC']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
