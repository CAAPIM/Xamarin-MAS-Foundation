using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Error {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGServerException']"
	[global::Android.Runtime.Register ("com/ca/mas/core/error/MAGServerException", DoNotGenerateAcw=true)]
	public partial class MAGServerException : global::Java.Lang.Exception {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/error/MAGServerException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGServerException); }
		}

		protected MAGServerException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_error_MAGServerException_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGServerException']/constructor[@name='MAGServerException' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.error.MAGServerException']]"
		[Register (".ctor", "(Lcom/ca/mas/core/error/MAGServerException;)V", "")]
		public unsafe MAGServerException (global::Com.CA.Mas.Core.Error.MAGServerException e)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (e);
				if (((object) this).GetType () != typeof (MAGServerException)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGServerException']/constructor[@name='MAGServerException' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(IILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MAGServerException (int errorCode, int status, string contentType, string detailMessage)
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
				if (((object) this).GetType () != typeof (MAGServerException)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGServerException']/constructor[@name='MAGServerException' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Throwable']]"
		[Register (".ctor", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe MAGServerException (int errorCode, int status, string contentType, string detailMessage, global::Java.Lang.Throwable throwable)
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
				if (((object) this).GetType () != typeof (MAGServerException)) {
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

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Error.MAGServerException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Error.MAGServerException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGServerException']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Error.MAGServerException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Error.MAGServerException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCode;
		public virtual unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGServerException']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Throwable) this).Handle, id_getErrorCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Error.MAGServerException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Error.MAGServerException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual unsafe int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGServerException']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()I", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Throwable) this).Handle, id_getStatus);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()I"));
				} finally {
				}
			}
		}

	}
}
