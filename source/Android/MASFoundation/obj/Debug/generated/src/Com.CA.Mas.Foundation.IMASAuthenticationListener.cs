using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthenticationListener']"
	[Register ("com/ca/mas/foundation/MASAuthenticationListener", "", "Com.CA.Mas.Foundation.IMASAuthenticationListenerInvoker")]
	public partial interface IMASAuthenticationListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthenticationListener']/method[@name='onAuthenticateRequest' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='com.ca.mas.foundation.auth.MASAuthenticationProviders']]"
		[Register ("onAuthenticateRequest", "(Landroid/content/Context;JLcom/ca/mas/foundation/auth/MASAuthenticationProviders;)V", "GetOnAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_Handler:Com.CA.Mas.Foundation.IMASAuthenticationListenerInvoker, MASFoundation")]
		void OnAuthenticateRequest (global::Android.Content.Context p0, long p1, global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthenticationListener']/method[@name='onOtpAuthenticateRequest' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.ca.mas.foundation.MASOtpAuthenticationHandler']]"
		[Register ("onOtpAuthenticateRequest", "(Landroid/content/Context;Lcom/ca/mas/foundation/MASOtpAuthenticationHandler;)V", "GetOnOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_Handler:Com.CA.Mas.Foundation.IMASAuthenticationListenerInvoker, MASFoundation")]
		void OnOtpAuthenticateRequest (global::Android.Content.Context p0, global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler p1);

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASAuthenticationListener", DoNotGenerateAcw=true)]
	internal class IMASAuthenticationListenerInvoker : global::Java.Lang.Object, IMASAuthenticationListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/MASAuthenticationListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASAuthenticationListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMASAuthenticationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASAuthenticationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.MASAuthenticationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASAuthenticationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_;
#pragma warning disable 0169
		static Delegate GetOnAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_Handler ()
		{
			if (cb_onAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ == null)
				cb_onAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_);
			return cb_onAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_;
		}

		static void n_OnAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Foundation.IMASAuthenticationListener __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthenticationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders p2 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthenticateRequest (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_;
		public unsafe void OnAuthenticateRequest (global::Android.Content.Context p0, long p1, global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders p2)
		{
			if (id_onAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ == IntPtr.Zero)
				id_onAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_ = JNIEnv.GetMethodID (class_ref, "onAuthenticateRequest", "(Landroid/content/Context;JLcom/ca/mas/foundation/auth/MASAuthenticationProviders;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthenticateRequest_Landroid_content_Context_JLcom_ca_mas_foundation_auth_MASAuthenticationProviders_, __args);
		}

		static Delegate cb_onOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_;
#pragma warning disable 0169
		static Delegate GetOnOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_Handler ()
		{
			if (cb_onOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_ == null)
				cb_onOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_);
			return cb_onOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_;
		}

		static void n_OnOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Foundation.IMASAuthenticationListener __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthenticationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnOtpAuthenticateRequest (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_;
		public unsafe void OnOtpAuthenticateRequest (global::Android.Content.Context p0, global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler p1)
		{
			if (id_onOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_ == IntPtr.Zero)
				id_onOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_ = JNIEnv.GetMethodID (class_ref, "onOtpAuthenticateRequest", "(Landroid/content/Context;Lcom/ca/mas/foundation/MASOtpAuthenticationHandler;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOtpAuthenticateRequest_Landroid_content_Context_Lcom_ca_mas_foundation_MASOtpAuthenticationHandler_, __args);
		}

	}

	public partial class AuthenticateRequestEventArgs : global::System.EventArgs {

		public AuthenticateRequestEventArgs (global::Android.Content.Context p0, long p1, global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Android.Content.Context p0;
		public global::Android.Content.Context P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders p2;
		public global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders P2 {
			get { return p2; }
		}
	}

	public partial class OtpAuthenticateRequestEventArgs : global::System.EventArgs {

		public OtpAuthenticateRequestEventArgs (global::Android.Content.Context p0, global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.Content.Context p0;
		public global::Android.Content.Context P0 {
			get { return p0; }
		}

		global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler p1;
		public global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/ca/mas/foundation/MASAuthenticationListenerImplementor")]
	internal sealed partial class IMASAuthenticationListenerImplementor : global::Java.Lang.Object, IMASAuthenticationListener {

		object sender;

		public IMASAuthenticationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/ca/mas/foundation/MASAuthenticationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AuthenticateRequestEventArgs> OnAuthenticateRequestHandler;
#pragma warning restore 0649

		public void OnAuthenticateRequest (global::Android.Content.Context p0, long p1, global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProviders p2)
		{
			var __h = OnAuthenticateRequestHandler;
			if (__h != null)
				__h (sender, new AuthenticateRequestEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<OtpAuthenticateRequestEventArgs> OnOtpAuthenticateRequestHandler;
#pragma warning restore 0649

		public void OnOtpAuthenticateRequest (global::Android.Content.Context p0, global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler p1)
		{
			var __h = OnOtpAuthenticateRequestHandler;
			if (__h != null)
				__h (sender, new OtpAuthenticateRequestEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IMASAuthenticationListenerImplementor value)
		{
			return value.OnAuthenticateRequestHandler == null && value.OnOtpAuthenticateRequestHandler == null;
		}
	}

}
