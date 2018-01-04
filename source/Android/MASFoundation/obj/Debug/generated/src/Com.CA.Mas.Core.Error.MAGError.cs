using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Error {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGError']"
	[global::Android.Runtime.Register ("com/ca/mas/core/error/MAGError", DoNotGenerateAcw=true)]
	public partial class MAGError : global::Java.Lang.Error {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/error/MAGError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGError); }
		}

		protected MAGError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGError']/constructor[@name='MAGError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe MAGError (string detailMessage, global::Java.Lang.Throwable throwable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_detailMessage = JNIEnv.NewString (detailMessage);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_detailMessage);
				__args [1] = new JValue (throwable);
				if (((object) this).GetType () != typeof (MAGError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_detailMessage);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGError']/constructor[@name='MAGError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe MAGError (global::Java.Lang.Throwable throwable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				if (((object) this).GetType () != typeof (MAGError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static Delegate cb_getResultCode;
#pragma warning disable 0169
		static Delegate GetGetResultCodeHandler ()
		{
			if (cb_getResultCode == null)
				cb_getResultCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResultCode);
			return cb_getResultCode;
		}

		static int n_GetResultCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Error.MAGError __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Error.MAGError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResultCode;
		}
#pragma warning restore 0169

		static Delegate cb_setResultCode_I;
#pragma warning disable 0169
		static Delegate GetSetResultCode_IHandler ()
		{
			if (cb_setResultCode_I == null)
				cb_setResultCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResultCode_I);
			return cb_setResultCode_I;
		}

		static void n_SetResultCode_I (IntPtr jnienv, IntPtr native__this, int resultCode)
		{
			global::Com.CA.Mas.Core.Error.MAGError __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Error.MAGError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResultCode = resultCode;
		}
#pragma warning restore 0169

		static IntPtr id_getResultCode;
		static IntPtr id_setResultCode_I;
		[Obsolete (@"deprecated")]
		public virtual unsafe int ResultCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGError']/method[@name='getResultCode' and count(parameter)=0]"
			[Register ("getResultCode", "()I", "GetGetResultCodeHandler")]
			get {
				if (id_getResultCode == IntPtr.Zero)
					id_getResultCode = JNIEnv.GetMethodID (class_ref, "getResultCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Throwable) this).Handle, id_getResultCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResultCode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='MAGError']/method[@name='setResultCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResultCode", "(I)V", "GetSetResultCode_IHandler")]
			set {
				if (id_setResultCode_I == IntPtr.Zero)
					id_setResultCode_I = JNIEnv.GetMethodID (class_ref, "setResultCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Throwable) this).Handle, id_setResultCode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResultCode", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
