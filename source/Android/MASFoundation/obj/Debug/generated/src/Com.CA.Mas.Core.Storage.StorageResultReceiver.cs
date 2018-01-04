using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResultReceiver']"
	[global::Android.Runtime.Register ("com/ca/mas/core/storage/StorageResultReceiver", DoNotGenerateAcw=true)]
	public partial class StorageResultReceiver : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/storage/StorageResultReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StorageResultReceiver); }
		}

		protected StorageResultReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResultReceiver']/constructor[@name='StorageResultReceiver' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register (".ctor", "(Landroid/os/Handler;)V", "")]
		public unsafe StorageResultReceiver (global::Android.OS.Handler handler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (handler);
				if (((object) this).GetType () != typeof (StorageResultReceiver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Handler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Handler;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Handler_ == IntPtr.Zero)
					id_ctor_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Handler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Handler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Handler_, __args);
			} finally {
			}
		}

		static Delegate cb_onReceiveResult_Lcom_ca_mas_core_storage_StorageResult_;
#pragma warning disable 0169
		static Delegate GetOnReceiveResult_Lcom_ca_mas_core_storage_StorageResult_Handler ()
		{
			if (cb_onReceiveResult_Lcom_ca_mas_core_storage_StorageResult_ == null)
				cb_onReceiveResult_Lcom_ca_mas_core_storage_StorageResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReceiveResult_Lcom_ca_mas_core_storage_StorageResult_);
			return cb_onReceiveResult_Lcom_ca_mas_core_storage_StorageResult_;
		}

		static void n_OnReceiveResult_Lcom_ca_mas_core_storage_StorageResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResult result = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnReceiveResult (result);
		}
#pragma warning restore 0169

		static IntPtr id_onReceiveResult_Lcom_ca_mas_core_storage_StorageResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResultReceiver']/method[@name='onReceiveResult' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.storage.StorageResult']]"
		[Register ("onReceiveResult", "(Lcom/ca/mas/core/storage/StorageResult;)V", "GetOnReceiveResult_Lcom_ca_mas_core_storage_StorageResult_Handler")]
		public virtual unsafe void OnReceiveResult (global::Com.CA.Mas.Core.Storage.StorageResult result)
		{
			if (id_onReceiveResult_Lcom_ca_mas_core_storage_StorageResult_ == IntPtr.Zero)
				id_onReceiveResult_Lcom_ca_mas_core_storage_StorageResult_ = JNIEnv.GetMethodID (class_ref, "onReceiveResult", "(Lcom/ca/mas/core/storage/StorageResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (result);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveResult_Lcom_ca_mas_core_storage_StorageResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceiveResult", "(Lcom/ca/mas/core/storage/StorageResult;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_send_Lcom_ca_mas_core_storage_StorageResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResultReceiver']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.storage.StorageResult']]"
		[Register ("send", "(Lcom/ca/mas/core/storage/StorageResult;)V", "")]
		public unsafe void Send (global::Com.CA.Mas.Core.Storage.StorageResult result)
		{
			if (id_send_Lcom_ca_mas_core_storage_StorageResult_ == IntPtr.Zero)
				id_send_Lcom_ca_mas_core_storage_StorageResult_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/ca/mas/core/storage/StorageResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (result);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Lcom_ca_mas_core_storage_StorageResult_, __args);
			} finally {
			}
		}

	}
}
