using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Oauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenClient']"
	[global::Android.Runtime.Register ("com/ca/mas/core/oauth/OAuthTokenClient", DoNotGenerateAcw=true)]
	public partial class OAuthTokenClient : global::Com.CA.Mas.Core.Client.ServerClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/oauth/OAuthTokenClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthTokenClient); }
		}

		protected OAuthTokenClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenClient']/constructor[@name='OAuthTokenClient' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register (".ctor", "(Lcom/ca/mas/core/context/MssoContext;)V", "")]
		public unsafe OAuthTokenClient (global::Com.CA.Mas.Core.Context.MssoContext mssoContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mssoContext);
				if (((object) this).GetType () != typeof (OAuthTokenClient)) {
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

		static Delegate cb_obtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_obtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_obtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ObtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_obtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ObtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_idToken, IntPtr native_clientId, IntPtr native_clientSecret, IntPtr native_scope)
		{
			global::Com.CA.Mas.Core.Oauth.OAuthTokenClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Token.IdToken idToken = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.IdToken> (native_idToken, JniHandleOwnership.DoNotTransfer);
			string clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			string clientSecret = JNIEnv.GetString (native_clientSecret, JniHandleOwnership.DoNotTransfer);
			string scope = JNIEnv.GetString (native_scope, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ObtainAccessTokenUsingIdToken (idToken, clientId, clientSecret, scope));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_obtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenClient']/method[@name='obtainAccessTokenUsingIdToken' and count(parameter)=4 and parameter[1][@type='com.ca.mas.core.token.IdToken'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("obtainAccessTokenUsingIdToken", "(Lcom/ca/mas/core/token/IdToken;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/oauth/OAuthTokenResponse;", "GetObtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse ObtainAccessTokenUsingIdToken (global::Com.CA.Mas.Core.Token.IdToken idToken, string clientId, string clientSecret, string scope)
		{
			if (id_obtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_obtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "obtainAccessTokenUsingIdToken", "(Lcom/ca/mas/core/token/IdToken;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/oauth/OAuthTokenResponse;");
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_clientSecret = JNIEnv.NewString (clientSecret);
			IntPtr native_scope = JNIEnv.NewString (scope);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (idToken);
				__args [1] = new JValue (native_clientId);
				__args [2] = new JValue (native_clientSecret);
				__args [3] = new JValue (native_scope);

				global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainAccessTokenUsingIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "obtainAccessTokenUsingIdToken", "(Lcom/ca/mas/core/token/IdToken;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/oauth/OAuthTokenResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
				JNIEnv.DeleteLocalRef (native_scope);
			}
		}

		static Delegate cb_obtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_obtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_obtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ObtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_obtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ObtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshToken, IntPtr native_clientId, IntPtr native_clientSecret)
		{
			global::Com.CA.Mas.Core.Oauth.OAuthTokenClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string refreshToken = JNIEnv.GetString (native_refreshToken, JniHandleOwnership.DoNotTransfer);
			string clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			string clientSecret = JNIEnv.GetString (native_clientSecret, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ObtainTokenUsingRefreshToken (refreshToken, clientId, clientSecret));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_obtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenClient']/method[@name='obtainTokenUsingRefreshToken' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("obtainTokenUsingRefreshToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/oauth/OAuthTokenResponse;", "GetObtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse ObtainTokenUsingRefreshToken (string refreshToken, string clientId, string clientSecret)
		{
			if (id_obtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_obtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "obtainTokenUsingRefreshToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/oauth/OAuthTokenResponse;");
			IntPtr native_refreshToken = JNIEnv.NewString (refreshToken);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_clientSecret = JNIEnv.NewString (clientSecret);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_refreshToken);
				__args [1] = new JValue (native_clientId);
				__args [2] = new JValue (native_clientSecret);

				global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainTokenUsingRefreshToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "obtainTokenUsingRefreshToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/oauth/OAuthTokenResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_refreshToken);
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		static Delegate cb_obtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetObtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_obtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_obtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_ObtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_obtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static IntPtr n_ObtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_clientId, IntPtr native_clientSecret, bool requestIdToken)
		{
			global::Com.CA.Mas.Core.Oauth.OAuthTokenClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Request.MAGInternalRequest request = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.MAGInternalRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			string clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			string clientSecret = JNIEnv.GetString (native_clientSecret, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ObtainTokensUsingCredentials (request, clientId, clientSecret, requestIdToken));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_obtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenClient']/method[@name='obtainTokensUsingCredentials' and count(parameter)=4 and parameter[1][@type='com.ca.mas.core.request.MAGInternalRequest'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("obtainTokensUsingCredentials", "(Lcom/ca/mas/core/request/MAGInternalRequest;Ljava/lang/String;Ljava/lang/String;Z)Lcom/ca/mas/core/oauth/OAuthTokenResponse;", "GetObtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse ObtainTokensUsingCredentials (global::Com.CA.Mas.Core.Request.MAGInternalRequest request, string clientId, string clientSecret, bool requestIdToken)
		{
			if (id_obtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_obtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "obtainTokensUsingCredentials", "(Lcom/ca/mas/core/request/MAGInternalRequest;Ljava/lang/String;Ljava/lang/String;Z)Lcom/ca/mas/core/oauth/OAuthTokenResponse;");
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_clientSecret = JNIEnv.NewString (clientSecret);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (request);
				__args [1] = new JValue (native_clientId);
				__args [2] = new JValue (native_clientSecret);
				__args [3] = new JValue (requestIdToken);

				global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainTokensUsingCredentials_Lcom_ca_mas_core_request_MAGInternalRequest_Ljava_lang_String_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "obtainTokensUsingCredentials", "(Lcom/ca/mas/core/request/MAGInternalRequest;Ljava/lang/String;Ljava/lang/String;Z)Lcom/ca/mas/core/oauth/OAuthTokenResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

	}
}
