using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Policy.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='OtpException']"
	[global::Android.Runtime.Register ("com/ca/mas/core/policy/exceptions/OtpException", DoNotGenerateAcw=true)]
	public partial class OtpException : global::Com.CA.Mas.Core.Error.MAGServerException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/policy/exceptions/OtpException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OtpException); }
		}

		protected OtpException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IILjava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='OtpException']/constructor[@name='OtpException' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.ca.mas.core.auth.otp.model.OtpResponseHeaders']]"
		[Register (".ctor", "(IILjava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;)V", "")]
		public unsafe OtpException (int errorCode, int status, string contentType, string detailMessage, global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders otpResponseHeaders)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_contentType = JNIEnv.NewString (contentType);
			IntPtr native_detailMessage = JNIEnv.NewString (detailMessage);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (errorCode);
				__args [1] = new JValue (status);
				__args [2] = new JValue (native_contentType);
				__args [3] = new JValue (native_detailMessage);
				__args [4] = new JValue (otpResponseHeaders);
				if (((object) this).GetType () != typeof (OtpException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IILjava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(IILjava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;)V", __args);
					return;
				}

				if (id_ctor_IILjava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_ == IntPtr.Zero)
					id_ctor_IILjava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_IILjava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_contentType);
				JNIEnv.DeleteLocalRef (native_detailMessage);
			}
		}

		static IntPtr id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='OtpException']/constructor[@name='OtpException' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Throwable'] and parameter[6][@type='com.ca.mas.core.auth.otp.model.OtpResponseHeaders']]"
		[Register (".ctor", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;)V", "")]
		public unsafe OtpException (int errorCode, int status, string contentType, string detailMessage, global::Java.Lang.Throwable throwable, global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders otpResponseHeaders)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_contentType = JNIEnv.NewString (contentType);
			IntPtr native_detailMessage = JNIEnv.NewString (detailMessage);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (errorCode);
				__args [1] = new JValue (status);
				__args [2] = new JValue (native_contentType);
				__args [3] = new JValue (native_detailMessage);
				__args [4] = new JValue (throwable);
				__args [5] = new JValue (otpResponseHeaders);
				if (((object) this).GetType () != typeof (OtpException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;)V", __args);
					return;
				}

				if (id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_ == IntPtr.Zero)
					id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_contentType);
				JNIEnv.DeleteLocalRef (native_detailMessage);
			}
		}

		static Delegate cb_getOtpResponseHeaders;
#pragma warning disable 0169
		static Delegate GetGetOtpResponseHeadersHandler ()
		{
			if (cb_getOtpResponseHeaders == null)
				cb_getOtpResponseHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOtpResponseHeaders);
			return cb_getOtpResponseHeaders;
		}

		static IntPtr n_GetOtpResponseHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Policy.Exceptions.OtpException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.Exceptions.OtpException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OtpResponseHeaders);
		}
#pragma warning restore 0169

		static IntPtr id_getOtpResponseHeaders;
		public virtual unsafe global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders OtpResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='OtpException']/method[@name='getOtpResponseHeaders' and count(parameter)=0]"
			[Register ("getOtpResponseHeaders", "()Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;", "GetGetOtpResponseHeadersHandler")]
			get {
				if (id_getOtpResponseHeaders == IntPtr.Zero)
					id_getOtpResponseHeaders = JNIEnv.GetMethodID (class_ref, "getOtpResponseHeaders", "()Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getOtpResponseHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOtpResponseHeaders", "()Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
