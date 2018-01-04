using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Error {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGRuntimeException']"
	[global::Android.Runtime.Register ("com/ca/mas/core/error/MAGRuntimeException", DoNotGenerateAcw=true)]
	public partial class MAGRuntimeException : global::Java.Lang.RuntimeException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/error/MAGRuntimeException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGRuntimeException); }
		}

		protected MAGRuntimeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGRuntimeException']/constructor[@name='MAGRuntimeException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe MAGRuntimeException (int errorCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorCode);
				if (((object) this).GetType () != typeof (MAGRuntimeException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGRuntimeException']/constructor[@name='MAGRuntimeException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe MAGRuntimeException (int errorCode, string detailMessage)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_detailMessage = JNIEnv.NewString (detailMessage);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (errorCode);
				__args [1] = new JValue (native_detailMessage);
				if (((object) this).GetType () != typeof (MAGRuntimeException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_detailMessage);
			}
		}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGRuntimeException']/constructor[@name='MAGRuntimeException' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe MAGRuntimeException (int errorCode, string detailMessage, global::Java.Lang.Throwable throwable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_detailMessage = JNIEnv.NewString (detailMessage);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (errorCode);
				__args [1] = new JValue (native_detailMessage);
				__args [2] = new JValue (throwable);
				if (((object) this).GetType () != typeof (MAGRuntimeException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(ILjava/lang/String;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_detailMessage);
			}
		}

		static IntPtr id_ctor_ILjava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGRuntimeException']/constructor[@name='MAGRuntimeException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(ILjava/lang/Throwable;)V", "")]
		public unsafe MAGRuntimeException (int errorCode, global::Java.Lang.Throwable throwable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (errorCode);
				__args [1] = new JValue (throwable);
				if (((object) this).GetType () != typeof (MAGRuntimeException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(ILjava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_ILjava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_ILjava_lang_Throwable_, __args);
			} finally {
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
			global::Com.CA.Mas.Core.Error.MAGRuntimeException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Error.MAGRuntimeException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCode;
		public virtual unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGRuntimeException']/method[@name='getErrorCode' and count(parameter)=0]"
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

	}
}
