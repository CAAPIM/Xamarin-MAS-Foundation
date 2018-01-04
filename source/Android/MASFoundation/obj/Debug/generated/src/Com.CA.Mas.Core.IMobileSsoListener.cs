using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoListener']"
	[Register ("com/ca/mas/core/MobileSsoListener", "", "Com.CA.Mas.Core.IMobileSsoListenerInvoker")]
	public partial interface IMobileSsoListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoListener']/method[@name='onAuthenticateRequest' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.ca.mas.core.service.AuthenticationProvider']]"
		[Register ("onAuthenticateRequest", "(JLcom/ca/mas/core/service/AuthenticationProvider;)V", "GetOnAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_Handler:Com.CA.Mas.Core.IMobileSsoListenerInvoker, MASFoundation")]
		void OnAuthenticateRequest (long p0, global::Com.CA.Mas.Core.Service.AuthenticationProvider p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoListener']/method[@name='onOtpAuthenticationRequest' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.auth.otp.OtpAuthenticationHandler']]"
		[Register ("onOtpAuthenticationRequest", "(Lcom/ca/mas/core/auth/otp/OtpAuthenticationHandler;)V", "GetOnOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_Handler:Com.CA.Mas.Core.IMobileSsoListenerInvoker, MASFoundation")]
		void OnOtpAuthenticationRequest (global::Com.CA.Mas.Core.Auth.Otp.OtpAuthenticationHandler p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/MobileSsoListener", DoNotGenerateAcw=true)]
	internal class IMobileSsoListenerInvoker : global::Java.Lang.Object, IMobileSsoListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/MobileSsoListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMobileSsoListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMobileSsoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMobileSsoListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.MobileSsoListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMobileSsoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_;
#pragma warning disable 0169
		static Delegate GetOnAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_Handler ()
		{
			if (cb_onAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_ == null)
				cb_onAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_OnAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_);
			return cb_onAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_;
		}

		static void n_OnAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Core.IMobileSsoListener __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IMobileSsoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Service.AuthenticationProvider p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.AuthenticationProvider> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthenticateRequest (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_;
		public unsafe void OnAuthenticateRequest (long p0, global::Com.CA.Mas.Core.Service.AuthenticationProvider p1)
		{
			if (id_onAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_ == IntPtr.Zero)
				id_onAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_ = JNIEnv.GetMethodID (class_ref, "onAuthenticateRequest", "(JLcom/ca/mas/core/service/AuthenticationProvider;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthenticateRequest_JLcom_ca_mas_core_service_AuthenticationProvider_, __args);
		}

		static Delegate cb_onOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_;
#pragma warning disable 0169
		static Delegate GetOnOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_Handler ()
		{
			if (cb_onOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_ == null)
				cb_onOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_);
			return cb_onOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_;
		}

		static void n_OnOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.IMobileSsoListener __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IMobileSsoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Auth.Otp.OtpAuthenticationHandler p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.OtpAuthenticationHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOtpAuthenticationRequest (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_;
		public unsafe void OnOtpAuthenticationRequest (global::Com.CA.Mas.Core.Auth.Otp.OtpAuthenticationHandler p0)
		{
			if (id_onOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_ == IntPtr.Zero)
				id_onOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_ = JNIEnv.GetMethodID (class_ref, "onOtpAuthenticationRequest", "(Lcom/ca/mas/core/auth/otp/OtpAuthenticationHandler;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOtpAuthenticationRequest_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_, __args);
		}

	}

	public partial class AuthenticateRequestEventArgs : global::System.EventArgs {

		public AuthenticateRequestEventArgs (long p0, global::Com.CA.Mas.Core.Service.AuthenticationProvider p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		long p0;
		public long P0 {
			get { return p0; }
		}

		global::Com.CA.Mas.Core.Service.AuthenticationProvider p1;
		public global::Com.CA.Mas.Core.Service.AuthenticationProvider P1 {
			get { return p1; }
		}
	}

	public partial class OtpAuthenticationRequestEventArgs : global::System.EventArgs {

		public OtpAuthenticationRequestEventArgs (global::Com.CA.Mas.Core.Auth.Otp.OtpAuthenticationHandler p0)
		{
			this.p0 = p0;
		}

		global::Com.CA.Mas.Core.Auth.Otp.OtpAuthenticationHandler p0;
		public global::Com.CA.Mas.Core.Auth.Otp.OtpAuthenticationHandler P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/ca/mas/core/MobileSsoListenerImplementor")]
	internal sealed partial class IMobileSsoListenerImplementor : global::Java.Lang.Object, IMobileSsoListener {

		object sender;

		public IMobileSsoListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/ca/mas/core/MobileSsoListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AuthenticateRequestEventArgs> OnAuthenticateRequestHandler;
#pragma warning restore 0649

		public void OnAuthenticateRequest (long p0, global::Com.CA.Mas.Core.Service.AuthenticationProvider p1)
		{
			var __h = OnAuthenticateRequestHandler;
			if (__h != null)
				__h (sender, new AuthenticateRequestEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<OtpAuthenticationRequestEventArgs> OnOtpAuthenticationRequestHandler;
#pragma warning restore 0649

		public void OnOtpAuthenticationRequest (global::Com.CA.Mas.Core.Auth.Otp.OtpAuthenticationHandler p0)
		{
			var __h = OnOtpAuthenticationRequestHandler;
			if (__h != null)
				__h (sender, new OtpAuthenticationRequestEventArgs (p0));
		}

		internal static bool __IsEmpty (IMobileSsoListenerImplementor value)
		{
			return value.OnAuthenticateRequestHandler == null && value.OnOtpAuthenticationRequestHandler == null;
		}
	}

}
