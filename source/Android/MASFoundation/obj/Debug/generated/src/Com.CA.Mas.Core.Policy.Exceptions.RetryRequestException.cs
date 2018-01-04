using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Policy.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='RetryRequestException']"
	[global::Android.Runtime.Register ("com/ca/mas/core/policy/exceptions/RetryRequestException", DoNotGenerateAcw=true)]
	public abstract partial class RetryRequestException : global::Com.CA.Mas.Core.Error.MAGStateException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/policy/exceptions/RetryRequestException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RetryRequestException); }
		}

		protected RetryRequestException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='RetryRequestException']/constructor[@name='RetryRequestException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RetryRequestException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RetryRequestException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='RetryRequestException']/constructor[@name='RetryRequestException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe RetryRequestException (string message)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);
				if (((object) this).GetType () != typeof (RetryRequestException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='RetryRequestException']/constructor[@name='RetryRequestException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe RetryRequestException (global::Java.Lang.Throwable throwable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				if (((object) this).GetType () != typeof (RetryRequestException)) {
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

		static Delegate cb_recover_Lcom_ca_mas_core_context_MssoContext_;
#pragma warning disable 0169
		static Delegate GetRecover_Lcom_ca_mas_core_context_MssoContext_Handler ()
		{
			if (cb_recover_Lcom_ca_mas_core_context_MssoContext_ == null)
				cb_recover_Lcom_ca_mas_core_context_MssoContext_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Recover_Lcom_ca_mas_core_context_MssoContext_);
			return cb_recover_Lcom_ca_mas_core_context_MssoContext_;
		}

		static void n_Recover_Lcom_ca_mas_core_context_MssoContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Policy.Exceptions.RetryRequestException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.Exceptions.RetryRequestException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Context.MssoContext p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Recover (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='RetryRequestException']/method[@name='recover' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register ("recover", "(Lcom/ca/mas/core/context/MssoContext;)V", "GetRecover_Lcom_ca_mas_core_context_MssoContext_Handler")]
		public abstract void Recover (global::Com.CA.Mas.Core.Context.MssoContext p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/policy/exceptions/RetryRequestException", DoNotGenerateAcw=true)]
	internal partial class RetryRequestExceptionInvoker : RetryRequestException {

		public RetryRequestExceptionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RetryRequestExceptionInvoker); }
		}

		static IntPtr id_recover_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='RetryRequestException']/method[@name='recover' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register ("recover", "(Lcom/ca/mas/core/context/MssoContext;)V", "GetRecover_Lcom_ca_mas_core_context_MssoContext_Handler")]
		public override unsafe void Recover (global::Com.CA.Mas.Core.Context.MssoContext p0)
		{
			if (id_recover_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
				id_recover_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "recover", "(Lcom/ca/mas/core/context/MssoContext;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Throwable) this).Handle, id_recover_Lcom_ca_mas_core_context_MssoContext_, __args);
			} finally {
			}
		}

	}

}
