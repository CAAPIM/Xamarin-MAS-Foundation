using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASException']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASException", DoNotGenerateAcw=true)]
	public partial class MASException : global::Java.Lang.Throwable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASException); }
		}

		protected MASException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASException']/constructor[@name='MASException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe MASException (string message, global::Java.Lang.Throwable cause)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (cause);
				if (((object) this).GetType () != typeof (MASException)) {
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
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASException']/constructor[@name='MASException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe MASException (global::Java.Lang.Throwable cause)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cause);
				if (((object) this).GetType () != typeof (MASException)) {
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

		static Delegate cb_getRootCause;
#pragma warning disable 0169
		static Delegate GetGetRootCauseHandler ()
		{
			if (cb_getRootCause == null)
				cb_getRootCause = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRootCause);
			return cb_getRootCause;
		}

		static IntPtr n_GetRootCause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RootCause);
		}
#pragma warning restore 0169

		static IntPtr id_getRootCause;
		public virtual unsafe global::Java.Lang.Throwable RootCause {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASException']/method[@name='getRootCause' and count(parameter)=0]"
			[Register ("getRootCause", "()Ljava/lang/Throwable;", "GetGetRootCauseHandler")]
			get {
				if (id_getRootCause == IntPtr.Zero)
					id_getRootCause = JNIEnv.GetMethodID (class_ref, "getRootCause", "()Ljava/lang/Throwable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getRootCause), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRootCause", "()Ljava/lang/Throwable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRootCause_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetGetRootCause_Ljava_lang_Throwable_Handler ()
		{
			if (cb_getRootCause_Ljava_lang_Throwable_ == null)
				cb_getRootCause_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRootCause_Ljava_lang_Throwable_);
			return cb_getRootCause_Ljava_lang_Throwable_;
		}

		static IntPtr n_GetRootCause_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			global::Com.CA.Mas.Foundation.MASException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable t = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_t, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRootCause (t));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRootCause_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASException']/method[@name='getRootCause' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("getRootCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", "GetGetRootCause_Ljava_lang_Throwable_Handler")]
		protected virtual unsafe global::Java.Lang.Throwable GetRootCause (global::Java.Lang.Throwable t)
		{
			if (id_getRootCause_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_getRootCause_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "getRootCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (t);

				global::Java.Lang.Throwable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getRootCause_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRootCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
