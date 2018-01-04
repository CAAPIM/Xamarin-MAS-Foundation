using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Policy.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='CertificateExpiredException']"
	[global::Android.Runtime.Register ("com/ca/mas/core/policy/exceptions/CertificateExpiredException", DoNotGenerateAcw=true)]
	public partial class CertificateExpiredException : global::Com.CA.Mas.Core.Policy.Exceptions.RetryRequestException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/policy/exceptions/CertificateExpiredException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CertificateExpiredException); }
		}

		protected CertificateExpiredException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='CertificateExpiredException']/constructor[@name='CertificateExpiredException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe CertificateExpiredException (string message)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);
				if (((object) this).GetType () != typeof (CertificateExpiredException)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='CertificateExpiredException']/constructor[@name='CertificateExpiredException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe CertificateExpiredException (global::Java.Lang.Throwable throwable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (throwable);
				if (((object) this).GetType () != typeof (CertificateExpiredException)) {
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

		static void n_Recover_Lcom_ca_mas_core_context_MssoContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.CA.Mas.Core.Policy.Exceptions.CertificateExpiredException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.Exceptions.CertificateExpiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Context.MssoContext context = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Recover (context);
		}
#pragma warning restore 0169

		static IntPtr id_recover_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='CertificateExpiredException']/method[@name='recover' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register ("recover", "(Lcom/ca/mas/core/context/MssoContext;)V", "GetRecover_Lcom_ca_mas_core_context_MssoContext_Handler")]
		public override unsafe void Recover (global::Com.CA.Mas.Core.Context.MssoContext context)
		{
			if (id_recover_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
				id_recover_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "recover", "(Lcom/ca/mas/core/context/MssoContext;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Throwable) this).Handle, id_recover_Lcom_ca_mas_core_context_MssoContext_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recover", "(Lcom/ca/mas/core/context/MssoContext;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_renewDevice_Lcom_ca_mas_core_context_MssoContext_;
#pragma warning disable 0169
		static Delegate GetRenewDevice_Lcom_ca_mas_core_context_MssoContext_Handler ()
		{
			if (cb_renewDevice_Lcom_ca_mas_core_context_MssoContext_ == null)
				cb_renewDevice_Lcom_ca_mas_core_context_MssoContext_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenewDevice_Lcom_ca_mas_core_context_MssoContext_);
			return cb_renewDevice_Lcom_ca_mas_core_context_MssoContext_;
		}

		static void n_RenewDevice_Lcom_ca_mas_core_context_MssoContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mssoContext)
		{
			global::Com.CA.Mas.Core.Policy.Exceptions.CertificateExpiredException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.Exceptions.CertificateExpiredException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Context.MssoContext mssoContext = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (native_mssoContext, JniHandleOwnership.DoNotTransfer);
			__this.RenewDevice (mssoContext);
		}
#pragma warning restore 0169

		static IntPtr id_renewDevice_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy.exceptions']/class[@name='CertificateExpiredException']/method[@name='renewDevice' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register ("renewDevice", "(Lcom/ca/mas/core/context/MssoContext;)V", "GetRenewDevice_Lcom_ca_mas_core_context_MssoContext_Handler")]
		public virtual unsafe void RenewDevice (global::Com.CA.Mas.Core.Context.MssoContext mssoContext)
		{
			if (id_renewDevice_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
				id_renewDevice_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "renewDevice", "(Lcom/ca/mas/core/context/MssoContext;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mssoContext);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Throwable) this).Handle, id_renewDevice_Lcom_ca_mas_core_context_MssoContext_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "renewDevice", "(Lcom/ca/mas/core/context/MssoContext;)V"), __args);
			} finally {
			}
		}

	}
}
