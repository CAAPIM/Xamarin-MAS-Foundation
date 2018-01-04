using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation.Auth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation.auth']/interface[@name='MASProximityLogin']"
	[Register ("com/ca/mas/foundation/auth/MASProximityLogin", "", "Com.CA.Mas.Foundation.Auth.IMASProximityLoginInvoker")]
	public partial interface IMASProximityLogin : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/interface[@name='MASProximityLogin']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='long'] and parameter[3][@type='com.ca.mas.foundation.auth.MASAuthenticationProviders']]"
		[Register ("init", "(Landroid/app/Activity;JLcom/ca/mas/foundation/auth/MASAuthenticationProviders;)Z", "GetInit_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_Handler:Com.CA.Mas.Foundation.Auth.IMASProximityLoginInvoker, MASFoundation")]
		bool Init (global::Android.App.Activity p0, long p1, global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/interface[@name='MASProximityLogin']/method[@name='render' and count(parameter)=0]"
		[Register ("render", "()Landroid/view/View;", "GetRenderHandler:Com.CA.Mas.Foundation.Auth.IMASProximityLoginInvoker, MASFoundation")]
		global::Android.Views.View Render ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/interface[@name='MASProximityLogin']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Com.CA.Mas.Foundation.Auth.IMASProximityLoginInvoker, MASFoundation")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/interface[@name='MASProximityLogin']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.CA.Mas.Foundation.Auth.IMASProximityLoginInvoker, MASFoundation")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASProximityLogin", DoNotGenerateAcw=true)]
	internal class IMASProximityLoginInvoker : global::Java.Lang.Object, IMASProximityLogin {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/auth/MASProximityLogin");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASProximityLoginInvoker); }
		}

		IntPtr class_ref;

		public static IMASProximityLogin GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASProximityLogin> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.auth.MASProximityLogin"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASProximityLoginInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_Handler ()
		{
			if (cb_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ == null)
				cb_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, bool>) n_Init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_);
			return cb_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_;
		}

		static bool n_Init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Foundation.Auth.IMASProximityLogin __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.IMASProximityLogin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders p2 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Init (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_;
		public unsafe bool Init (global::Android.App.Activity p0, long p1, global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders p2)
		{
			if (id_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ == IntPtr.Zero)
				id_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/app/Activity;JLcom/ca/mas/foundation/auth/MASAuthenticationProviders;)Z");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_app_Activity_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_, __args);
			return __ret;
		}

		static Delegate cb_render;
#pragma warning disable 0169
		static Delegate GetRenderHandler ()
		{
			if (cb_render == null)
				cb_render = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Render);
			return cb_render;
		}

		static IntPtr n_Render (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.IMASProximityLogin __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.IMASProximityLogin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Render ());
		}
#pragma warning restore 0169

		IntPtr id_render;
		public unsafe global::Android.Views.View Render ()
		{
			if (id_render == IntPtr.Zero)
				id_render = JNIEnv.GetMethodID (class_ref, "render", "()Landroid/view/View;");
			return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_render), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Foundation.Auth.IMASProximityLogin __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.IMASProximityLogin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
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
			global::Com.CA.Mas.Foundation.Auth.IMASProximityLogin __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.IMASProximityLogin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}

}
