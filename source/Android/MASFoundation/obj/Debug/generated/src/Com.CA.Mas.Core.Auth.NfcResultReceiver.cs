using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NfcResultReceiver']"
	[global::Android.Runtime.Register ("com/ca/mas/core/auth/NfcResultReceiver", DoNotGenerateAcw=true)]
	public abstract partial class NfcResultReceiver : global::Com.CA.Mas.Core.MAGResultReceiver, global::Com.CA.Mas.Core.Auth.IAuthResultReceiver {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/auth/NfcResultReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NfcResultReceiver); }
		}

		protected NfcResultReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NfcResultReceiver']/constructor[@name='NfcResultReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NfcResultReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NfcResultReceiver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.NfcResultReceiver __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.NfcResultReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		public virtual unsafe global::Org.Json.JSONObject Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NfcResultReceiver']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Lorg/json/JSONObject;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setData_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetData_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setData_Lorg_json_JSONObject_ == null)
				cb_setData_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lorg_json_JSONObject_);
			return cb_setData_Lorg_json_JSONObject_;
		}

		static void n_SetData_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.CA.Mas.Core.Auth.NfcResultReceiver __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.NfcResultReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject data = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SetData (data);
		}
#pragma warning restore 0169

		static IntPtr id_setData_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NfcResultReceiver']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("setData", "(Lorg/json/JSONObject;)V", "GetSetData_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void SetData (global::Org.Json.JSONObject data)
		{
			if (id_setData_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setData_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setData", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/auth/NfcResultReceiver", DoNotGenerateAcw=true)]
	internal partial class NfcResultReceiverInvoker : NfcResultReceiver {

		public NfcResultReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (NfcResultReceiverInvoker); }
		}

		static IntPtr id_onError_Lcom_ca_mas_core_error_MAGError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core']/class[@name='MAGResultReceiver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.error.MAGError']]"
		[Register ("onError", "(Lcom/ca/mas/core/error/MAGError;)V", "GetOnError_Lcom_ca_mas_core_error_MAGError_Handler")]
		public override unsafe void OnError (global::Com.CA.Mas.Core.Error.MAGError p0)
		{
			if (id_onError_Lcom_ca_mas_core_error_MAGError_ == IntPtr.Zero)
				id_onError_Lcom_ca_mas_core_error_MAGError_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/ca/mas/core/error/MAGError;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_ca_mas_core_error_MAGError_, __args);
			} finally {
			}
		}

		static IntPtr id_onRequestCancelled_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core']/class[@name='MAGResultReceiver']/method[@name='onRequestCancelled' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onRequestCancelled", "(Landroid/os/Bundle;)V", "GetOnRequestCancelled_Landroid_os_Bundle_Handler")]
		public override unsafe void OnRequestCancelled (global::Android.OS.Bundle p0)
		{
			if (id_onRequestCancelled_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onRequestCancelled_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onRequestCancelled", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestCancelled_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

	}

}
