using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation.Notify {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation.notify']/class[@name='Callback']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/notify/Callback", DoNotGenerateAcw=true)]
	public partial class Callback : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/notify/Callback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Callback); }
		}

		protected Callback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation.notify']/class[@name='Callback']/constructor[@name='Callback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Callback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Callback)) {
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

		static IntPtr id_getHandler_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.notify']/class[@name='Callback']/method[@name='getHandler' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback']]"
		[Register ("getHandler", "(Lcom/ca/mas/foundation/MASCallback;)Landroid/os/Handler;", "")]
		public static unsafe global::Android.OS.Handler GetHandler (global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_getHandler_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getHandler_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "getHandler", "(Lcom/ca/mas/foundation/MASCallback;)Landroid/os/Handler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);
				global::Android.OS.Handler __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHandler_Lcom_ca_mas_foundation_MASCallback_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onError_Lcom_ca_mas_foundation_MASCallback_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.notify']/class[@name='Callback']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASCallback'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onError", "(Lcom/ca/mas/foundation/MASCallback;Ljava/lang/Throwable;)V", "")]
		public static unsafe void OnError (global::Com.CA.Mas.Foundation.MASCallback @callback, global::Java.Lang.Throwable t)
		{
			if (id_onError_Lcom_ca_mas_foundation_MASCallback_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Lcom_ca_mas_foundation_MASCallback_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "onError", "(Lcom/ca/mas/foundation/MASCallback;Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@callback);
				__args [1] = new JValue (t);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onError_Lcom_ca_mas_foundation_MASCallback_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_onSuccess_Lcom_ca_mas_foundation_MASCallback_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.notify']/class[@name='Callback']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;T&gt;'] and parameter[2][@type='T']]"
		[Register ("onSuccess", "(Lcom/ca/mas/foundation/MASCallback;Ljava/lang/Object;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe void OnSuccess (global::Com.CA.Mas.Foundation.MASCallback @callback, global::Java.Lang.Object value)
		{
			if (id_onSuccess_Lcom_ca_mas_foundation_MASCallback_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Lcom_ca_mas_foundation_MASCallback_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "onSuccess", "(Lcom/ca/mas/foundation/MASCallback;Ljava/lang/Object;)V");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@callback);
				__args [1] = new JValue (native_value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onSuccess_Lcom_ca_mas_foundation_MASCallback_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
