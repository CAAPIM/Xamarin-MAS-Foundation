using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='MssoClient']"
	[global::Android.Runtime.Register ("com/ca/mas/core/service/MssoClient", DoNotGenerateAcw=true)]
	public partial class MssoClient : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/service/MssoClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MssoClient); }
		}

		protected MssoClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_context_MssoContext_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='MssoClient']/constructor[@name='MssoClient' and count(parameter)=2 and parameter[1][@type='com.ca.mas.core.context.MssoContext'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Lcom/ca/mas/core/context/MssoContext;Landroid/content/Context;)V", "")]
		public unsafe MssoClient (global::Com.CA.Mas.Core.Context.MssoContext mssoContext, global::Android.Content.Context sysContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (mssoContext);
				__args [1] = new JValue (sysContext);
				if (((object) this).GetType () != typeof (MssoClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/core/context/MssoContext;Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/core/context/MssoContext;Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_core_context_MssoContext_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_core_context_MssoContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/core/context/MssoContext;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_core_context_MssoContext_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_core_context_MssoContext_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_authenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_Handler ()
		{
			if (cb_authenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_ == null)
				cb_authenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Authenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_);
			return cb_authenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_;
		}

		static void n_Authenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_idToken, IntPtr native_resultReceiver)
		{
			global::Com.CA.Mas.Core.Service.MssoClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.MssoClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Token.IdToken idToken = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.IdToken> (native_idToken, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.MAGResultReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.MAGResultReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			__this.Authenticate (idToken, resultReceiver);
		}
#pragma warning restore 0169

		static IntPtr id_authenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='MssoClient']/method[@name='authenticate' and count(parameter)=2 and parameter[1][@type='com.ca.mas.core.token.IdToken'] and parameter[2][@type='com.ca.mas.core.MAGResultReceiver']]"
		[Register ("authenticate", "(Lcom/ca/mas/core/token/IdToken;Lcom/ca/mas/core/MAGResultReceiver;)V", "GetAuthenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_Handler")]
		public virtual unsafe void Authenticate (global::Com.CA.Mas.Core.Token.IdToken idToken, global::Com.CA.Mas.Core.MAGResultReceiver resultReceiver)
		{
			if (id_authenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_ == IntPtr.Zero)
				id_authenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Lcom/ca/mas/core/token/IdToken;Lcom/ca/mas/core/MAGResultReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (idToken);
				__args [1] = new JValue (resultReceiver);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_authenticate_Lcom_ca_mas_core_token_IdToken_Lcom_ca_mas_core_MAGResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authenticate", "(Lcom/ca/mas/core/token/IdToken;Lcom/ca/mas/core/MAGResultReceiver;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_authenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_Handler ()
		{
			if (cb_authenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_ == null)
				cb_authenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Authenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_);
			return cb_authenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_;
		}

		static void n_Authenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credentials, IntPtr native_resultReceiver)
		{
			global::Com.CA.Mas.Core.Service.MssoClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.MssoClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.IMASAuthCredentials credentials = (global::Com.CA.Mas.Foundation.IMASAuthCredentials)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (native_credentials, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.MAGResultReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.MAGResultReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			__this.Authenticate (credentials, resultReceiver);
		}
#pragma warning restore 0169

		static IntPtr id_authenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='MssoClient']/method[@name='authenticate' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASAuthCredentials'] and parameter[2][@type='com.ca.mas.core.MAGResultReceiver']]"
		[Register ("authenticate", "(Lcom/ca/mas/foundation/MASAuthCredentials;Lcom/ca/mas/core/MAGResultReceiver;)V", "GetAuthenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_Handler")]
		public virtual unsafe void Authenticate (global::Com.CA.Mas.Foundation.IMASAuthCredentials credentials, global::Com.CA.Mas.Core.MAGResultReceiver resultReceiver)
		{
			if (id_authenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_ == IntPtr.Zero)
				id_authenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Lcom/ca/mas/foundation/MASAuthCredentials;Lcom/ca/mas/core/MAGResultReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (credentials);
				__args [1] = new JValue (resultReceiver);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_authenticate_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_core_MAGResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authenticate", "(Lcom/ca/mas/foundation/MASAuthCredentials;Lcom/ca/mas/core/MAGResultReceiver;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_authenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_Handler ()
		{
			if (cb_authenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_ == null)
				cb_authenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Authenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_);
			return cb_authenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_;
		}

		static void n_Authenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_username, IntPtr native_password, IntPtr native_resultReceiver)
		{
			global::Com.CA.Mas.Core.Service.MssoClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.MssoClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string username = JNIEnv.GetString (native_username, JniHandleOwnership.DoNotTransfer);
			char[] password = (char[]) JNIEnv.GetArray (native_password, JniHandleOwnership.DoNotTransfer, typeof (char));
			global::Com.CA.Mas.Core.MAGResultReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.MAGResultReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			__this.Authenticate (username, password, resultReceiver);
			if (password != null)
				JNIEnv.CopyArray (password, native_password);
		}
#pragma warning restore 0169

		static IntPtr id_authenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='MssoClient']/method[@name='authenticate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char[]'] and parameter[3][@type='com.ca.mas.core.MAGResultReceiver']]"
		[Register ("authenticate", "(Ljava/lang/String;[CLcom/ca/mas/core/MAGResultReceiver;)V", "GetAuthenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_Handler")]
		public virtual unsafe void Authenticate (string username, char[] password, global::Com.CA.Mas.Core.MAGResultReceiver resultReceiver)
		{
			if (id_authenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_ == IntPtr.Zero)
				id_authenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Ljava/lang/String;[CLcom/ca/mas/core/MAGResultReceiver;)V");
			IntPtr native_username = JNIEnv.NewString (username);
			IntPtr native_password = JNIEnv.NewArray (password);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_username);
				__args [1] = new JValue (native_password);
				__args [2] = new JValue (resultReceiver);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_authenticate_Ljava_lang_String_arrayCLcom_ca_mas_core_MAGResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authenticate", "(Ljava/lang/String;[CLcom/ca/mas/core/MAGResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_username);
				if (password != null) {
					JNIEnv.CopyArray (native_password, password);
					JNIEnv.DeleteLocalRef (native_password);
				}
			}
		}

		static Delegate cb_authenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_Handler ()
		{
			if (cb_authenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_ == null)
				cb_authenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Authenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_);
			return cb_authenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_;
		}

		static void n_Authenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authCode, IntPtr native_state, IntPtr native_resultReceiver)
		{
			global::Com.CA.Mas.Core.Service.MssoClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.MssoClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string authCode = JNIEnv.GetString (native_authCode, JniHandleOwnership.DoNotTransfer);
			string state = JNIEnv.GetString (native_state, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.MAGResultReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.MAGResultReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			__this.Authenticate (authCode, state, resultReceiver);
		}
#pragma warning restore 0169

		static IntPtr id_authenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='MssoClient']/method[@name='authenticate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ca.mas.core.MAGResultReceiver']]"
		[Register ("authenticate", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/MAGResultReceiver;)V", "GetAuthenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_Handler")]
		public virtual unsafe void Authenticate (string authCode, string state, global::Com.CA.Mas.Core.MAGResultReceiver resultReceiver)
		{
			if (id_authenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_ == IntPtr.Zero)
				id_authenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/MAGResultReceiver;)V");
			IntPtr native_authCode = JNIEnv.NewString (authCode);
			IntPtr native_state = JNIEnv.NewString (state);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_authCode);
				__args [1] = new JValue (native_state);
				__args [2] = new JValue (resultReceiver);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_authenticate_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_MAGResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authenticate", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/MAGResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authCode);
				JNIEnv.DeleteLocalRef (native_state);
			}
		}

		static Delegate cb_cancelAll_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetCancelAll_Landroid_os_Bundle_Handler ()
		{
			if (cb_cancelAll_Landroid_os_Bundle_ == null)
				cb_cancelAll_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelAll_Landroid_os_Bundle_);
			return cb_cancelAll_Landroid_os_Bundle_;
		}

		static void n_CancelAll_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.CA.Mas.Core.Service.MssoClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.MssoClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle data = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.CancelAll (data);
		}
#pragma warning restore 0169

		static IntPtr id_cancelAll_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='MssoClient']/method[@name='cancelAll' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("cancelAll", "(Landroid/os/Bundle;)V", "GetCancelAll_Landroid_os_Bundle_Handler")]
		public virtual unsafe void CancelAll (global::Android.OS.Bundle data)
		{
			if (id_cancelAll_Landroid_os_Bundle_ == IntPtr.Zero)
				id_cancelAll_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "cancelAll", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelAll_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelAll", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cancelRequest_JLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetCancelRequest_JLandroid_os_Bundle_Handler ()
		{
			if (cb_cancelRequest_JLandroid_os_Bundle_ == null)
				cb_cancelRequest_JLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_CancelRequest_JLandroid_os_Bundle_);
			return cb_cancelRequest_JLandroid_os_Bundle_;
		}

		static void n_CancelRequest_JLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, long requestId, IntPtr native_data)
		{
			global::Com.CA.Mas.Core.Service.MssoClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.MssoClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle data = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.CancelRequest (requestId, data);
		}
#pragma warning restore 0169

		static IntPtr id_cancelRequest_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='MssoClient']/method[@name='cancelRequest' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("cancelRequest", "(JLandroid/os/Bundle;)V", "GetCancelRequest_JLandroid_os_Bundle_Handler")]
		public virtual unsafe void CancelRequest (long requestId, global::Android.OS.Bundle data)
		{
			if (id_cancelRequest_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_cancelRequest_JLandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "cancelRequest", "(JLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (requestId);
				__args [1] = new JValue (data);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelRequest_JLandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelRequest", "(JLandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processPendingRequests;
#pragma warning disable 0169
		static Delegate GetProcessPendingRequestsHandler ()
		{
			if (cb_processPendingRequests == null)
				cb_processPendingRequests = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessPendingRequests);
			return cb_processPendingRequests;
		}

		static void n_ProcessPendingRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Service.MssoClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.MssoClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessPendingRequests ();
		}
#pragma warning restore 0169

		static IntPtr id_processPendingRequests;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='MssoClient']/method[@name='processPendingRequests' and count(parameter)=0]"
		[Register ("processPendingRequests", "()V", "GetProcessPendingRequestsHandler")]
		public virtual unsafe void ProcessPendingRequests ()
		{
			if (id_processPendingRequests == IntPtr.Zero)
				id_processPendingRequests = JNIEnv.GetMethodID (class_ref, "processPendingRequests", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processPendingRequests);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processPendingRequests", "()V"));
			} finally {
			}
		}

	}
}
