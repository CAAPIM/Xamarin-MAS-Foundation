using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core']/class[@name='MAGResultReceiver']"
	[global::Android.Runtime.Register ("com/ca/mas/core/MAGResultReceiver", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class MAGResultReceiver : global::Android.OS.ResultReceiver {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/MAGResultReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGResultReceiver); }
		}

		protected MAGResultReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core']/class[@name='MAGResultReceiver']/constructor[@name='MAGResultReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MAGResultReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MAGResultReceiver)) {
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

		static IntPtr id_ctor_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core']/class[@name='MAGResultReceiver']/constructor[@name='MAGResultReceiver' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register (".ctor", "(Landroid/os/Handler;)V", "")]
		public unsafe MAGResultReceiver (global::Android.OS.Handler handler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (handler);
				if (((object) this).GetType () != typeof (MAGResultReceiver)) {
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

		static Delegate cb_onError_Lcom_ca_mas_core_error_MAGError_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_ca_mas_core_error_MAGError_Handler ()
		{
			if (cb_onError_Lcom_ca_mas_core_error_MAGError_ == null)
				cb_onError_Lcom_ca_mas_core_error_MAGError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_ca_mas_core_error_MAGError_);
			return cb_onError_Lcom_ca_mas_core_error_MAGError_;
		}

		static void n_OnError_Lcom_ca_mas_core_error_MAGError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.MAGResultReceiver __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.MAGResultReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Error.MAGError p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Error.MAGError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core']/class[@name='MAGResultReceiver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.error.MAGError']]"
		[Register ("onError", "(Lcom/ca/mas/core/error/MAGError;)V", "GetOnError_Lcom_ca_mas_core_error_MAGError_Handler")]
		public abstract void OnError (global::Com.CA.Mas.Core.Error.MAGError p0);

		static Delegate cb_onRequestCancelled_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnRequestCancelled_Landroid_os_Bundle_Handler ()
		{
			if (cb_onRequestCancelled_Landroid_os_Bundle_ == null)
				cb_onRequestCancelled_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestCancelled_Landroid_os_Bundle_);
			return cb_onRequestCancelled_Landroid_os_Bundle_;
		}

		static void n_OnRequestCancelled_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.MAGResultReceiver __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.MAGResultReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestCancelled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core']/class[@name='MAGResultReceiver']/method[@name='onRequestCancelled' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onRequestCancelled", "(Landroid/os/Bundle;)V", "GetOnRequestCancelled_Landroid_os_Bundle_Handler")]
		public abstract void OnRequestCancelled (global::Android.OS.Bundle p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/MAGResultReceiver", DoNotGenerateAcw=true)]
	internal partial class MAGResultReceiverInvoker : MAGResultReceiver {

		public MAGResultReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGResultReceiverInvoker); }
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
