using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Policy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.policy']/class[@name='PolicyManager']"
	[global::Android.Runtime.Register ("com/ca/mas/core/policy/PolicyManager", DoNotGenerateAcw=true)]
	public partial class PolicyManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/policy/PolicyManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolicyManager); }
		}

		protected PolicyManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.policy']/class[@name='PolicyManager']/constructor[@name='PolicyManager' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register (".ctor", "(Lcom/ca/mas/core/context/MssoContext;)V", "")]
		public unsafe PolicyManager (global::Com.CA.Mas.Core.Context.MssoContext mssoContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mssoContext);
				if (((object) this).GetType () != typeof (PolicyManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/core/context/MssoContext;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/core/context/MssoContext;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/core/context/MssoContext;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_core_context_MssoContext_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_core_context_MssoContext_, __args);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Policy.PolicyManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.PolicyManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy']/class[@name='PolicyManager']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sysContext)
		{
			global::Com.CA.Mas.Core.Policy.PolicyManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.PolicyManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context sysContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_sysContext, JniHandleOwnership.DoNotTransfer);
			__this.Init (sysContext);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy']/class[@name='PolicyManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context sysContext)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sysContext);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processRequest_Lcom_ca_mas_core_policy_RequestInfo_;
#pragma warning disable 0169
		static Delegate GetProcessRequest_Lcom_ca_mas_core_policy_RequestInfo_Handler ()
		{
			if (cb_processRequest_Lcom_ca_mas_core_policy_RequestInfo_ == null)
				cb_processRequest_Lcom_ca_mas_core_policy_RequestInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessRequest_Lcom_ca_mas_core_policy_RequestInfo_);
			return cb_processRequest_Lcom_ca_mas_core_policy_RequestInfo_;
		}

		static void n_ProcessRequest_Lcom_ca_mas_core_policy_RequestInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.CA.Mas.Core.Policy.PolicyManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.PolicyManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Policy.RequestInfo request = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.RequestInfo> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.ProcessRequest (request);
		}
#pragma warning restore 0169

		static IntPtr id_processRequest_Lcom_ca_mas_core_policy_RequestInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy']/class[@name='PolicyManager']/method[@name='processRequest' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.policy.RequestInfo']]"
		[Register ("processRequest", "(Lcom/ca/mas/core/policy/RequestInfo;)V", "GetProcessRequest_Lcom_ca_mas_core_policy_RequestInfo_Handler")]
		public virtual unsafe void ProcessRequest (global::Com.CA.Mas.Core.Policy.RequestInfo request)
		{
			if (id_processRequest_Lcom_ca_mas_core_policy_RequestInfo_ == IntPtr.Zero)
				id_processRequest_Lcom_ca_mas_core_policy_RequestInfo_ = JNIEnv.GetMethodID (class_ref, "processRequest", "(Lcom/ca/mas/core/policy/RequestInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (request);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processRequest_Lcom_ca_mas_core_policy_RequestInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processRequest", "(Lcom/ca/mas/core/policy/RequestInfo;)V"), __args);
			} finally {
			}
		}

	}
}
