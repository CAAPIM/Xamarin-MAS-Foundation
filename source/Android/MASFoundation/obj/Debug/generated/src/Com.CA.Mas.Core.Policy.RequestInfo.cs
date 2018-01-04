using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Policy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.policy']/class[@name='RequestInfo']"
	[global::Android.Runtime.Register ("com/ca/mas/core/policy/RequestInfo", DoNotGenerateAcw=true)]
	public partial class RequestInfo : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/policy/RequestInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestInfo); }
		}

		protected RequestInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getExtra;
#pragma warning disable 0169
		static Delegate GetGetExtraHandler ()
		{
			if (cb_getExtra == null)
				cb_getExtra = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtra);
			return cb_getExtra;
		}

		static IntPtr n_GetExtra (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Policy.RequestInfo __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.RequestInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Extra);
		}
#pragma warning restore 0169

		static IntPtr id_getExtra;
		public virtual unsafe global::Android.OS.Bundle Extra {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy']/class[@name='RequestInfo']/method[@name='getExtra' and count(parameter)=0]"
			[Register ("getExtra", "()Landroid/os/Bundle;", "GetGetExtraHandler")]
			get {
				if (id_getExtra == IntPtr.Zero)
					id_getExtra = JNIEnv.GetMethodID (class_ref, "getExtra", "()Landroid/os/Bundle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtra), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtra", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNumAttempts;
#pragma warning disable 0169
		static Delegate GetGetNumAttemptsHandler ()
		{
			if (cb_getNumAttempts == null)
				cb_getNumAttempts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumAttempts);
			return cb_getNumAttempts;
		}

		static int n_GetNumAttempts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Policy.RequestInfo __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.RequestInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumAttempts;
		}
#pragma warning restore 0169

		static IntPtr id_getNumAttempts;
		public virtual unsafe int NumAttempts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy']/class[@name='RequestInfo']/method[@name='getNumAttempts' and count(parameter)=0]"
			[Register ("getNumAttempts", "()I", "GetGetNumAttemptsHandler")]
			get {
				if (id_getNumAttempts == IntPtr.Zero)
					id_getNumAttempts = JNIEnv.GetMethodID (class_ref, "getNumAttempts", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumAttempts);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumAttempts", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Policy.RequestInfo __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.RequestInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		static IntPtr id_getRequest;
		public virtual unsafe global::Com.CA.Mas.Core.Request.MAGInternalRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy']/class[@name='RequestInfo']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/ca/mas/core/request/MAGInternalRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lcom/ca/mas/core/request/MAGInternalRequest;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.MAGInternalRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.MAGInternalRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequest", "()Lcom/ca/mas/core/request/MAGInternalRequest;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_incrementNumAttempts;
#pragma warning disable 0169
		static Delegate GetIncrementNumAttemptsHandler ()
		{
			if (cb_incrementNumAttempts == null)
				cb_incrementNumAttempts = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_IncrementNumAttempts);
			return cb_incrementNumAttempts;
		}

		static void n_IncrementNumAttempts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Policy.RequestInfo __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Policy.RequestInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IncrementNumAttempts ();
		}
#pragma warning restore 0169

		static IntPtr id_incrementNumAttempts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.policy']/class[@name='RequestInfo']/method[@name='incrementNumAttempts' and count(parameter)=0]"
		[Register ("incrementNumAttempts", "()V", "GetIncrementNumAttemptsHandler")]
		public virtual unsafe void IncrementNumAttempts ()
		{
			if (id_incrementNumAttempts == IntPtr.Zero)
				id_incrementNumAttempts = JNIEnv.GetMethodID (class_ref, "incrementNumAttempts", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_incrementNumAttempts);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "incrementNumAttempts", "()V"));
			} finally {
			}
		}

	}
}
