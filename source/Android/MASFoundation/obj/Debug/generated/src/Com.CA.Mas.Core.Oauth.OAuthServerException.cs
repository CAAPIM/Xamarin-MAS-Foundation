using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Oauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthServerException']"
	[global::Android.Runtime.Register ("com/ca/mas/core/oauth/OAuthServerException", DoNotGenerateAcw=true)]
	public partial class OAuthServerException : global::Com.CA.Mas.Core.Error.MAGServerException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/oauth/OAuthServerException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthServerException); }
		}

		protected OAuthServerException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_error_MAGServerException_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthServerException']/constructor[@name='OAuthServerException' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.error.MAGServerException']]"
		[Register (".ctor", "(Lcom/ca/mas/core/error/MAGServerException;)V", "")]
		public unsafe OAuthServerException (global::Com.CA.Mas.Core.Error.MAGServerException e)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				if (((object) this).GetType () != typeof (OAuthServerException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/core/error/MAGServerException;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lcom/ca/mas/core/error/MAGServerException;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_core_error_MAGServerException_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_core_error_MAGServerException_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/core/error/MAGServerException;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_core_error_MAGServerException_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lcom_ca_mas_core_error_MAGServerException_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthServerException']/constructor[@name='OAuthServerException' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(IILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OAuthServerException (int errorCode, int status, string contentType, string detailMessage)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_contentType = JNIEnv.NewString (contentType);
			IntPtr native_detailMessage = JNIEnv.NewString (detailMessage);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (errorCode);
				__args [1] = new JValue (status);
				__args [2] = new JValue (native_contentType);
				__args [3] = new JValue (native_detailMessage);
				if (((object) this).GetType () != typeof (OAuthServerException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IILjava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(IILjava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_IILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_IILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_IILjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_contentType);
				JNIEnv.DeleteLocalRef (native_detailMessage);
			}
		}

		static IntPtr id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthServerException']/constructor[@name='OAuthServerException' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Throwable']]"
		[Register (".ctor", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe OAuthServerException (int errorCode, int status, string contentType, string detailMessage, global::Java.Lang.Throwable throwable)
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
				__args [4] = new JValue (throwable);
				if (((object) this).GetType () != typeof (OAuthServerException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_IILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_contentType);
				JNIEnv.DeleteLocalRef (native_detailMessage);
			}
		}

	}
}
