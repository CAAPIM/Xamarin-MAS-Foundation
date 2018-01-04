using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']"
	[global::Android.Runtime.Register ("com/ca/mas/core/auth/AuthRenderer", DoNotGenerateAcw=true)]
	public abstract partial class AuthRenderer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/field[@name='AUTH_CODE_ERR']"
		[Register ("AUTH_CODE_ERR")]
		public const int AuthCodeErr = (int) 1;

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/field[@name='context']"
		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr provider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/field[@name='provider']"
		[Register ("provider")]
		protected global::Com.CA.Mas.Core.Service.Provider Provider {
			get {
				if (provider_jfieldId == IntPtr.Zero)
					provider_jfieldId = JNIEnv.GetFieldID (class_ref, "provider", "Lcom/ca/mas/core/service/Provider;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, provider_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.Provider> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (provider_jfieldId == IntPtr.Zero)
					provider_jfieldId = JNIEnv.GetFieldID (class_ref, "provider", "Lcom/ca/mas/core/service/Provider;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, provider_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr requestId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/field[@name='requestId']"
		[Register ("requestId")]
		protected long RequestId {
			get {
				if (requestId_jfieldId == IntPtr.Zero)
					requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId);
			}
			set {
				if (requestId_jfieldId == IntPtr.Zero)
					requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/auth/AuthRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthRenderer); }
		}

		protected AuthRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/constructor[@name='AuthRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AuthRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AuthRenderer)) {
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

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.AuthRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.AuthRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Auth.AuthRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.AuthRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public abstract void Close ();

		static Delegate cb_init_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_ == null)
				cb_init_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Init_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_);
			return cb_init_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_;
		}

		static bool n_Init_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_provider)
		{
			global::Com.CA.Mas.Core.Auth.AuthRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.AuthRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Service.Provider provider = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.Provider> (native_provider, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Init (context, provider);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.ca.mas.core.service.Provider']]"
		[Register ("init", "(Landroid/content/Context;Lcom/ca/mas/core/service/Provider;)Z", "GetInit_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_Handler")]
		public virtual unsafe bool Init (global::Android.Content.Context context, global::Com.CA.Mas.Core.Service.Provider provider)
		{
			if (id_init_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Lcom/ca/mas/core/service/Provider;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (provider);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Lcom_ca_mas_core_service_Provider_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;Lcom/ca/mas/core/service/Provider;)Z"), __args);
				return __ret;
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

		static void n_OnAuthCodeReceived_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Auth.AuthRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.AuthRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthCodeReceived (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='onAuthCodeReceived' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAuthCodeReceived", "(Ljava/lang/String;)V", "GetOnAuthCodeReceived_Ljava_lang_String_Handler")]
		protected abstract void OnAuthCodeReceived (string p0);

		static Delegate cb_onError_ILjava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_ILjava_lang_String_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_ILjava_lang_String_Ljava_lang_Exception_ == null)
				cb_onError_ILjava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnError_ILjava_lang_String_Ljava_lang_Exception_);
			return cb_onError_ILjava_lang_String_Ljava_lang_Exception_;
		}

		static void n_OnError_ILjava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Core.Auth.AuthRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.AuthRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("onError", "(ILjava/lang/String;Ljava/lang/Exception;)V", "GetOnError_ILjava_lang_String_Ljava_lang_Exception_Handler")]
		protected abstract void OnError (int p0, string p1, global::Java.Lang.Exception p2);

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
			global::Com.CA.Mas.Core.Auth.AuthRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.AuthRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRenderCompleted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='onRenderCompleted' and count(parameter)=0]"
		[Register ("onRenderCompleted", "()V", "GetOnRenderCompletedHandler")]
		public abstract void OnRenderCompleted ();

		static Delegate cb_proceed;
#pragma warning disable 0169
		static Delegate GetProceedHandler ()
		{
			if (cb_proceed == null)
				cb_proceed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Proceed);
			return cb_proceed;
		}

		static void n_Proceed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.AuthRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.AuthRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Proceed ();
		}
#pragma warning restore 0169

		static IntPtr id_proceed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='proceed' and count(parameter)=0]"
		[Register ("proceed", "()V", "GetProceedHandler")]
		protected virtual unsafe void Proceed ()
		{
			if (id_proceed == IntPtr.Zero)
				id_proceed = JNIEnv.GetMethodID (class_ref, "proceed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_proceed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "proceed", "()V"));
			} finally {
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
			global::Com.CA.Mas.Core.Auth.AuthRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.AuthRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Render ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='render' and count(parameter)=0]"
		[Register ("render", "()Landroid/view/View;", "GetRenderHandler")]
		public abstract global::Android.Views.View Render ();

		static Delegate cb_sendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_;
#pragma warning disable 0169
		static Delegate GetSendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_Handler ()
		{
			if (cb_sendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_ == null)
				cb_sendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_);
			return cb_sendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_;
		}

		static void n_SendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credentials)
		{
			global::Com.CA.Mas.Core.Auth.AuthRenderer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.AuthRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.IMASAuthCredentials credentials = (global::Com.CA.Mas.Foundation.IMASAuthCredentials)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (native_credentials, JniHandleOwnership.DoNotTransfer);
			__this.SendCredentialsIntent (credentials);
		}
#pragma warning restore 0169

		static IntPtr id_sendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='sendCredentialsIntent' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASAuthCredentials']]"
		[Register ("sendCredentialsIntent", "(Lcom/ca/mas/foundation/MASAuthCredentials;)V", "GetSendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_Handler")]
		public virtual unsafe void SendCredentialsIntent (global::Com.CA.Mas.Foundation.IMASAuthCredentials credentials)
		{
			if (id_sendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_ == IntPtr.Zero)
				id_sendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_ = JNIEnv.GetMethodID (class_ref, "sendCredentialsIntent", "(Lcom/ca/mas/foundation/MASAuthCredentials;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (credentials);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCredentialsIntent_Lcom_ca_mas_foundation_MASAuthCredentials_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendCredentialsIntent", "(Lcom/ca/mas/foundation/MASAuthCredentials;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/auth/AuthRenderer", DoNotGenerateAcw=true)]
	internal partial class AuthRendererInvoker : AuthRenderer {

		public AuthRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthRendererInvoker); }
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_onAuthCodeReceived_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='onAuthCodeReceived' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAuthCodeReceived", "(Ljava/lang/String;)V", "GetOnAuthCodeReceived_Ljava_lang_String_Handler")]
		protected override unsafe void OnAuthCodeReceived (string p0)
		{
			if (id_onAuthCodeReceived_Ljava_lang_String_ == IntPtr.Zero)
				id_onAuthCodeReceived_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAuthCodeReceived", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAuthCodeReceived_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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

		static IntPtr id_onRenderCompleted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/class[@name='AuthRenderer']/method[@name='onRenderCompleted' and count(parameter)=0]"
		[Register ("onRenderCompleted", "()V", "GetOnRenderCompletedHandler")]
		public override unsafe void OnRenderCompleted ()
		{
			if (id_onRenderCompleted == IntPtr.Zero)
				id_onRenderCompleted = JNIEnv.GetMethodID (class_ref, "onRenderCompleted", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRenderCompleted);
			} finally {
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
