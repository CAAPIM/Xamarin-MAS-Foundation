using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Oauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']"
	[global::Android.Runtime.Register ("com/ca/mas/core/oauth/OAuthClient", DoNotGenerateAcw=true)]
	public partial class OAuthClient : global::Com.CA.Mas.Core.Client.ServerClient {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='AUTHORIZATION']"
		[Register ("AUTHORIZATION")]
		public const string Authorization = (string) "authorization";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='AUTH_URL']"
		[Register ("AUTH_URL")]
		public const string AuthUrl = (string) "auth_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='CODE']"
		[Register ("CODE")]
		public const string Code = (string) "code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='CODE_CHALLENGE']"
		[Register ("CODE_CHALLENGE")]
		public const string CodeChallenge = (string) "code_challenge";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='CODE_CHALLENGE_METHOD']"
		[Register ("CODE_CHALLENGE_METHOD")]
		public const string CodeChallengeMethod = (string) "code_challenge_method";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='DISPLAY']"
		[Register ("DISPLAY")]
		public const string Display = (string) "display";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='ID']"
		[Register ("ID")]
		public const string Id = (string) "id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='IDP']"
		[Register ("IDP")]
		public const string Idp = (string) "idp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='ID_TOKEN']"
		[Register ("ID_TOKEN")]
		public const string IdToken = (string) "id_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='ID_TOKEN_TYPE']"
		[Register ("ID_TOKEN_TYPE")]
		public const string IdTokenType = (string) "id_token_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='LOGOUT_APPS']"
		[Register ("LOGOUT_APPS")]
		public const string LogoutApps = (string) "logout_apps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='MSSO_REGISTER']"
		[Register ("MSSO_REGISTER")]
		public const string MssoRegister = (string) "msso_register";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='POLL_URL']"
		[Register ("POLL_URL")]
		public const string PollUrl = (string) "poll_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='PROVIDER']"
		[Register ("PROVIDER")]
		public const string Provider = (string) "provider";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='PROVIDERS']"
		[Register ("PROVIDERS")]
		public const string Providers = (string) "providers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='REDIRECT_URI']"
		[Register ("REDIRECT_URI")]
		public const string RedirectUri = (string) "redirect_uri";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='RESPONSE_TYPE']"
		[Register ("RESPONSE_TYPE")]
		public const string ResponseType = (string) "response_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/field[@name='STATE']"
		[Register ("STATE")]
		public const string State = (string) "state";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/oauth/OAuthClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthClient); }
		}

		protected OAuthClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/constructor[@name='OAuthClient' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register (".ctor", "(Lcom/ca/mas/core/context/MssoContext;)V", "")]
		public unsafe OAuthClient (global::Com.CA.Mas.Core.Context.MssoContext mssoContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mssoContext);
				if (((object) this).GetType () != typeof (OAuthClient)) {
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

		static Delegate cb_getSocialPlatformProvider_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetSocialPlatformProvider_Landroid_content_Context_Handler ()
		{
			if (cb_getSocialPlatformProvider_Landroid_content_Context_ == null)
				cb_getSocialPlatformProvider_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSocialPlatformProvider_Landroid_content_Context_);
			return cb_getSocialPlatformProvider_Landroid_content_Context_;
		}

		static IntPtr n_GetSocialPlatformProvider_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.CA.Mas.Core.Oauth.OAuthClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSocialPlatformProvider (context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSocialPlatformProvider_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/method[@name='getSocialPlatformProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getSocialPlatformProvider", "(Landroid/content/Context;)Lcom/ca/mas/core/service/AuthenticationProvider;", "GetGetSocialPlatformProvider_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.CA.Mas.Core.Service.AuthenticationProvider GetSocialPlatformProvider (global::Android.Content.Context context)
		{
			if (id_getSocialPlatformProvider_Landroid_content_Context_ == IntPtr.Zero)
				id_getSocialPlatformProvider_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getSocialPlatformProvider", "(Landroid/content/Context;)Lcom/ca/mas/core/service/AuthenticationProvider;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				global::Com.CA.Mas.Core.Service.AuthenticationProvider __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.AuthenticationProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSocialPlatformProvider_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.AuthenticationProvider> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSocialPlatformProvider", "(Landroid/content/Context;)Lcom/ca/mas/core/service/AuthenticationProvider;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_logout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetLogout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_logout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_logout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Logout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_logout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_Logout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_idToken, IntPtr native_clientId, IntPtr native_clientSecret, bool logoutApps)
		{
			global::Com.CA.Mas.Core.Oauth.OAuthClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Token.IdToken idToken = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.IdToken> (native_idToken, JniHandleOwnership.DoNotTransfer);
			string clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
			string clientSecret = JNIEnv.GetString (native_clientSecret, JniHandleOwnership.DoNotTransfer);
			__this.Logout (idToken, clientId, clientSecret, logoutApps);
		}
#pragma warning restore 0169

		static IntPtr id_logout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClient']/method[@name='logout' and count(parameter)=4 and parameter[1][@type='com.ca.mas.core.token.IdToken'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("logout", "(Lcom/ca/mas/core/token/IdToken;Ljava/lang/String;Ljava/lang/String;Z)V", "GetLogout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe void Logout (global::Com.CA.Mas.Core.Token.IdToken idToken, string clientId, string clientSecret, bool logoutApps)
		{
			if (id_logout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_logout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "logout", "(Lcom/ca/mas/core/token/IdToken;Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_clientSecret = JNIEnv.NewString (clientSecret);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (idToken);
				__args [1] = new JValue (native_clientId);
				__args [2] = new JValue (native_clientSecret);
				__args [3] = new JValue (logoutApps);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Lcom/ca/mas/core/token/IdToken;Ljava/lang/String;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

	}
}
