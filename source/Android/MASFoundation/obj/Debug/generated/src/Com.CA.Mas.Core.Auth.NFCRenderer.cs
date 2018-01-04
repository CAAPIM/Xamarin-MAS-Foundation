using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']"
	[global::Android.Runtime.Register ("com/ca/mas/core/auth/NFCRenderer", DoNotGenerateAcw=true)]
	public partial class NFCRenderer : global::Com.CA.Mas.Core.Auth.PollingRenderer {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']/field[@name='ADDRESS']"
		[Register ("ADDRESS")]
		public const string Address = (string) "address";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']/field[@name='BLUETOOTH_CONN_ERR']"
		[Register ("BLUETOOTH_CONN_ERR")]
		public const int BluetoothConnErr = (int) 102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']/field[@name='BLUETOOTH_ERR']"
		[Register ("BLUETOOTH_ERR")]
		public const int BluetoothErr = (int) 101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']/field[@name='NFC_ERR']"
		[Register ("NFC_ERR")]
		public const int NfcErr = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']/field[@name='PROVIDER_URL']"
		[Register ("PROVIDER_URL")]
		public const string ProviderUrl = (string) "provider_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']/field[@name='UUID']"
		[Register ("UUID")]
		public const string Uuid = (string) "uuid";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/auth/NFCRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NFCRenderer); }
		}

		protected NFCRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']/constructor[@name='NFCRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NFCRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NFCRenderer)) {
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

		static Delegate cb_onError_ILjava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_ILjava_lang_String_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_ILjava_lang_String_Ljava_lang_Exception_ == null)
				cb_onError_ILjava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnError_ILjava_lang_String_Ljava_lang_Exception_);
			return cb_onError_ILjava_lang_String_Ljava_lang_Exception_;
		}

		static void n_OnError_ILjava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_message, IntPtr native_e)
		{
			global::Com.CA.Mas.Core.Auth.NFCRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.NFCRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception e = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnError (code, message, e);
		}
#pragma warning restore 0169

		static IntPtr id_onError_ILjava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("onError", "(ILjava/lang/String;Ljava/lang/Exception;)V", "GetOnError_ILjava_lang_String_Ljava_lang_Exception_Handler")]
		protected override unsafe void OnError (int code, string message, global::Java.Lang.Exception e)
		{
			if (id_onError_ILjava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_ILjava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(ILjava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (code);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (e);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_ILjava_lang_String_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(ILjava/lang/String;Ljava/lang/Exception;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_render;
#pragma warning disable 0169
		static Delegate GetRenderHandler ()
		{
			if (cb_render == null)
				cb_render = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Render);
			return cb_render;
		}

		static IntPtr n_Render (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.NFCRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.NFCRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Render ());
		}
#pragma warning restore 0169

		static IntPtr id_render;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']/method[@name='render' and count(parameter)=0]"
		[Register ("render", "()Landroid/view/View;", "GetRenderHandler")]
		public override unsafe global::Android.Views.View Render ()
		{
			if (id_render == IntPtr.Zero)
				id_render = JNIEnv.GetMethodID (class_ref, "render", "()Landroid/view/View;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_render), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "render", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_startPollingOnStartup;
#pragma warning disable 0169
		static Delegate GetStartPollingOnStartupHandler ()
		{
			if (cb_startPollingOnStartup == null)
				cb_startPollingOnStartup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StartPollingOnStartup);
			return cb_startPollingOnStartup;
		}

		static bool n_StartPollingOnStartup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.NFCRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.NFCRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartPollingOnStartup ();
		}
#pragma warning restore 0169

		static IntPtr id_startPollingOnStartup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='NFCRenderer']/method[@name='startPollingOnStartup' and count(parameter)=0]"
		[Register ("startPollingOnStartup", "()Z", "GetStartPollingOnStartupHandler")]
		protected override unsafe bool StartPollingOnStartup ()
		{
			if (id_startPollingOnStartup == IntPtr.Zero)
				id_startPollingOnStartup = JNIEnv.GetMethodID (class_ref, "startPollingOnStartup", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startPollingOnStartup);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startPollingOnStartup", "()Z"));
			} finally {
			}
		}

	}
}
