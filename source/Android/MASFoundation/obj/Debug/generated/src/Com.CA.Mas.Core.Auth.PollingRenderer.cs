using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']"
	[global::Android.Runtime.Register ("com/ca/mas/core/auth/PollingRenderer", DoNotGenerateAcw=true)]
	public abstract partial class PollingRenderer : global::Com.CA.Mas.Core.Auth.AuthRenderer {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/field[@name='INVALID_SESSION_ID_OR_POLL_URL']"
		[Register ("INVALID_SESSION_ID_OR_POLL_URL")]
		public const int InvalidSessionIdOrPollUrl = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/field[@name='SESSION_EXPIRED']"
		[Register ("SESSION_EXPIRED")]
		public const int SessionExpired = (int) 11;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/auth/PollingRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PollingRenderer); }
		}

		protected PollingRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/constructor[@name='PollingRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PollingRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PollingRenderer)) {
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

		static Delegate cb_getDelay;
#pragma warning disable 0169
		static Delegate GetGetDelayHandler ()
		{
			if (cb_getDelay == null)
				cb_getDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDelay);
			return cb_getDelay;
		}

		static long n_GetDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.PollingRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.PollingRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Delay;
		}
#pragma warning restore 0169

		static IntPtr id_getDelay;
		protected virtual unsafe long Delay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/method[@name='getDelay' and count(parameter)=0]"
			[Register ("getDelay", "()J", "GetGetDelayHandler")]
			get {
				if (id_getDelay == IntPtr.Zero)
					id_getDelay = JNIEnv.GetMethodID (class_ref, "getDelay", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDelay);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelay", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxPollCount;
#pragma warning disable 0169
		static Delegate GetGetMaxPollCountHandler ()
		{
			if (cb_getMaxPollCount == null)
				cb_getMaxPollCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMaxPollCount);
			return cb_getMaxPollCount;
		}

		static long n_GetMaxPollCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.PollingRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.PollingRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxPollCount;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxPollCount;
		protected virtual unsafe long MaxPollCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/method[@name='getMaxPollCount' and count(parameter)=0]"
			[Register ("getMaxPollCount", "()J", "GetGetMaxPollCountHandler")]
			get {
				if (id_getMaxPollCount == IntPtr.Zero)
					id_getMaxPollCount = JNIEnv.GetMethodID (class_ref, "getMaxPollCount", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMaxPollCount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxPollCount", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getPollInterval;
#pragma warning disable 0169
		static Delegate GetGetPollIntervalHandler ()
		{
			if (cb_getPollInterval == null)
				cb_getPollInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPollInterval);
			return cb_getPollInterval;
		}

		static long n_GetPollInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.PollingRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.PollingRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PollInterval;
		}
#pragma warning restore 0169

		static IntPtr id_getPollInterval;
		protected virtual unsafe long PollInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/method[@name='getPollInterval' and count(parameter)=0]"
			[Register ("getPollInterval", "()J", "GetGetPollIntervalHandler")]
			get {
				if (id_getPollInterval == IntPtr.Zero)
					id_getPollInterval = JNIEnv.GetMethodID (class_ref, "getPollInterval", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPollInterval);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPollInterval", "()J"));
				} finally {
				}
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
			global::Com.CA.Mas.Core.Auth.PollingRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.PollingRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
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

		static Delegate cb_onAuthCodeReceived_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAuthCodeReceived_Ljava_lang_String_Handler ()
		{
			if (cb_onAuthCodeReceived_Ljava_lang_String_ == null)
				cb_onAuthCodeReceived_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAuthCodeReceived_Ljava_lang_String_);
			return cb_onAuthCodeReceived_Ljava_lang_String_;
		}

		static void n_OnAuthCodeReceived_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_code)
		{
			global::Com.CA.Mas.Core.Auth.PollingRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.PollingRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string code = JNIEnv.GetString (native_code, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthCodeReceived (code);
		}
#pragma warning restore 0169

		static IntPtr id_onAuthCodeReceived_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/method[@name='onAuthCodeReceived' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAuthCodeReceived", "(Ljava/lang/String;)V", "GetOnAuthCodeReceived_Ljava_lang_String_Handler")]
		protected override unsafe void OnAuthCodeReceived (string code)
		{
			if (id_onAuthCodeReceived_Ljava_lang_String_ == IntPtr.Zero)
				id_onAuthCodeReceived_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAuthCodeReceived", "(Ljava/lang/String;)V");
			IntPtr native_code = JNIEnv.NewString (code);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_code);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthCodeReceived_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAuthCodeReceived", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_code);
			}
		}

		static Delegate cb_onRenderCompleted;
#pragma warning disable 0169
		static Delegate GetOnRenderCompletedHandler ()
		{
			if (cb_onRenderCompleted == null)
				cb_onRenderCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRenderCompleted);
			return cb_onRenderCompleted;
		}

		static void n_OnRenderCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.PollingRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.PollingRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRenderCompleted ();
		}
#pragma warning restore 0169

		static IntPtr id_onRenderCompleted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/method[@name='onRenderCompleted' and count(parameter)=0]"
		[Register ("onRenderCompleted", "()V", "GetOnRenderCompletedHandler")]
		public override unsafe void OnRenderCompleted ()
		{
			if (id_onRenderCompleted == IntPtr.Zero)
				id_onRenderCompleted = JNIEnv.GetMethodID (class_ref, "onRenderCompleted", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRenderCompleted);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRenderCompleted", "()V"));
			} finally {
			}
		}

		static Delegate cb_poll;
#pragma warning disable 0169
		static Delegate GetPollHandler ()
		{
			if (cb_poll == null)
				cb_poll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Poll);
			return cb_poll;
		}

		static void n_Poll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.PollingRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.PollingRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Poll ();
		}
#pragma warning restore 0169

		static IntPtr id_poll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/method[@name='poll' and count(parameter)=0]"
		[Register ("poll", "()V", "GetPollHandler")]
		protected virtual unsafe void Poll ()
		{
			if (id_poll == IntPtr.Zero)
				id_poll = JNIEnv.GetMethodID (class_ref, "poll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_poll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "poll", "()V"));
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
			global::Com.CA.Mas.Core.Auth.PollingRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.PollingRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartPollingOnStartup ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/method[@name='startPollingOnStartup' and count(parameter)=0]"
		[Register ("startPollingOnStartup", "()Z", "GetStartPollingOnStartupHandler")]
		protected abstract bool StartPollingOnStartup ();

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/auth/PollingRenderer", DoNotGenerateAcw=true)]
	internal partial class PollingRendererInvoker : PollingRenderer {

		public PollingRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PollingRendererInvoker); }
		}

		static IntPtr id_startPollingOnStartup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='PollingRenderer']/method[@name='startPollingOnStartup' and count(parameter)=0]"
		[Register ("startPollingOnStartup", "()Z", "GetStartPollingOnStartupHandler")]
		protected override unsafe bool StartPollingOnStartup ()
		{
			if (id_startPollingOnStartup == IntPtr.Zero)
				id_startPollingOnStartup = JNIEnv.GetMethodID (class_ref, "startPollingOnStartup", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startPollingOnStartup);
			} finally {
			}
		}

		static IntPtr id_onError_ILjava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("onError", "(ILjava/lang/String;Ljava/lang/Exception;)V", "GetOnError_ILjava_lang_String_Ljava_lang_Exception_Handler")]
		protected override unsafe void OnError (int p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_onError_ILjava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_ILjava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(ILjava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_ILjava_lang_String_Ljava_lang_Exception_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_render;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='render' and count(parameter)=0]"
		[Register ("render", "()Landroid/view/View;", "GetRenderHandler")]
		public override unsafe global::Android.Views.View Render ()
		{
			if (id_render == IntPtr.Zero)
				id_render = JNIEnv.GetMethodID (class_ref, "render", "()Landroid/view/View;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_render), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
