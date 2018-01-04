using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Conf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']"
	[global::Android.Runtime.Register ("com/ca/mas/core/conf/DefaultConfiguration", DoNotGenerateAcw=true)]
	public partial class DefaultConfiguration : global::Java.Lang.Object, global::Com.CA.Mas.Core.Conf.IConfigurationProvider {


		public static class InterfaceConsts {

			// The following are fields from: com.ca.mas.core.conf.ConfigurationProvider

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/field[@name='PROP_LOCATION_MIN_DISTANCE']"
			[Register ("PROP_LOCATION_MIN_DISTANCE")]
			public const string PropLocationMinDistance = (string) "msso.location.min.distance";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/field[@name='PROP_LOCATION_MIN_TIME']"
			[Register ("PROP_LOCATION_MIN_TIME")]
			public const string PropLocationMinTime = (string) "msso.location.min.time";

			// The following are fields from: com.ca.mas.core.MobileSsoConfig

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='AUTHENTICATE_OTP_PATH']"
			[Register ("AUTHENTICATE_OTP_PATH")]
			public const string AuthenticateOtpPath = (string) "msso.url.auth_otp";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_ADD_CUSTOM_POLICIES']"
			[Register ("PROP_ADD_CUSTOM_POLICIES")]
			public const string PropAddCustomPolicies = (string) "msso.add.custom.policies";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_AUTHORIZE_REDIRECT_URI']"
			[Register ("PROP_AUTHORIZE_REDIRECT_URI")]
			public const string PropAuthorizeRedirectUri = (string) "msso.authorize.redirect.uri";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_BLE_CHARACTERISTIC_UUID']"
			[Register ("PROP_BLE_CHARACTERISTIC_UUID")]
			public const string PropBleCharacteristicUuid = (string) "msso.ble.characteristic.uuid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_BLE_RSSI']"
			[Register ("PROP_BLE_RSSI")]
			public const string PropBleRssi = (string) "msso.ble.rssi";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_BLE_SERVICE_UUID']"
			[Register ("PROP_BLE_SERVICE_UUID")]
			public const string PropBleServiceUuid = (string) "msso.ble.service.uuid";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_CLIENT_CERT_RSA_KEYBITS']"
			[Register ("PROP_CLIENT_CERT_RSA_KEYBITS")]
			public const string PropClientCertRsaKeybits = (string) "msso.cert.rsa.keybits";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_CLIENT_CREDENTIAL_MANAGER']"
			[Register ("PROP_CLIENT_CREDENTIAL_MANAGER")]
			public const string PropClientCredentialManager = (string) "msso.client.credential.manager";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_CLIENT_ID']"
			[Register ("PROP_CLIENT_ID")]
			public const string PropClientId = (string) "msso.oauth.client.id";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_CLIENT_SECRET']"
			[Register ("PROP_CLIENT_SECRET")]
			[Obsolete ("deprecated")]
			public const string PropClientSecret = (string) "msso.oauth.client.secret";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_LOCATION_ENABLED']"
			[Register ("PROP_LOCATION_ENABLED")]
			public const string PropLocationEnabled = (string) "msso.location.enabled";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_LOCATION_PROVIDER_NAME']"
			[Register ("PROP_LOCATION_PROVIDER_NAME")]
			public const string PropLocationProviderName = (string) "msso.location.provider.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_MSISDN_ENABLED']"
			[Register ("PROP_MSISDN_ENABLED")]
			public const string PropMsisdnEnabled = (string) "msso.msisdn.enabled";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_OAUTH_SCOPE']"
			[Register ("PROP_OAUTH_SCOPE")]
			public const string PropOauthScope = (string) "msso.oauth.scope";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_ORGANIZATION']"
			[Register ("PROP_ORGANIZATION")]
			public const string PropOrganization = (string) "msso.organization";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_PACKAGE_NAME']"
			[Register ("PROP_PACKAGE_NAME")]
			public const string PropPackageName = (string) "msso.package.name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_PRIVATE_TOKEN_MANAGER']"
			[Register ("PROP_PRIVATE_TOKEN_MANAGER")]
			public const string PropPrivateTokenManager = (string) "msso.private.token.manager";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_RESPONSE_BUFFERING_ENABLED']"
			[Register ("PROP_RESPONSE_BUFFERING_ENABLED")]
			public const string PropResponseBufferingEnabled = (string) "msso.response.buffer.enabled";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_RESPONSE_BUFFERING_MAX_SIZE']"
			[Register ("PROP_RESPONSE_BUFFERING_MAX_SIZE")]
			public const string PropResponseBufferingMaxSize = (string) "msso.response.buffer.maxSize";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_SHARE_TOKEN_MANAGER']"
			[Register ("PROP_SHARE_TOKEN_MANAGER")]
			public const string PropShareTokenManager = (string) "msso.share.token.manager";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_SSO_ENABLED']"
			[Register ("PROP_SSO_ENABLED")]
			public const string PropSsoEnabled = (string) "msso.sso.enabled";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_STORAGE']"
			[Register ("PROP_STORAGE")]
			public const string PropStorage = (string) "msso.storage";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_HOSTNAME']"
			[Register ("PROP_TOKEN_HOSTNAME")]
			public const string PropTokenHostname = (string) "msso.token.hostname";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_PORT_HTTP']"
			[Register ("PROP_TOKEN_PORT_HTTP")]
			public const string PropTokenPortHttp = (string) "msso.token.port.http";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_PORT_HTTPS']"
			[Register ("PROP_TOKEN_PORT_HTTPS")]
			public const string PropTokenPortHttps = (string) "msso.token.port.https";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URI_PREFIX']"
			[Register ("PROP_TOKEN_URI_PREFIX")]
			public const string PropTokenUriPrefix = (string) "msso.token.uri.prefix";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URL_SUFFIX_AUTHORIZE']"
			[Register ("PROP_TOKEN_URL_SUFFIX_AUTHORIZE")]
			public const string PropTokenUrlSuffixAuthorize = (string) "msso.url.authorize";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URL_SUFFIX_CLIENT_CREDENTIALS']"
			[Register ("PROP_TOKEN_URL_SUFFIX_CLIENT_CREDENTIALS")]
			public const string PropTokenUrlSuffixClientCredentials = (string) "msso.url.client_credentials";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URL_SUFFIX_ENTERPRISE_APPS']"
			[Register ("PROP_TOKEN_URL_SUFFIX_ENTERPRISE_APPS")]
			public const string PropTokenUrlSuffixEnterpriseApps = (string) "msso.url.enterprise_apps";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URL_SUFFIX_REGISTER_DEVICE']"
			[Register ("PROP_TOKEN_URL_SUFFIX_REGISTER_DEVICE")]
			public const string PropTokenUrlSuffixRegisterDevice = (string) "msso.url.register_device";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URL_SUFFIX_REGISTER_DEVICE_CLIENT']"
			[Register ("PROP_TOKEN_URL_SUFFIX_REGISTER_DEVICE_CLIENT")]
			public const string PropTokenUrlSuffixRegisterDeviceClient = (string) "msso.url.register_device_client";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URL_SUFFIX_REMOVE_DEVICE_X509']"
			[Register ("PROP_TOKEN_URL_SUFFIX_REMOVE_DEVICE_X509")]
			public const string PropTokenUrlSuffixRemoveDeviceX509 = (string) "msso.url.remove_device_x509";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URL_SUFFIX_RENEW_DEVICE']"
			[Register ("PROP_TOKEN_URL_SUFFIX_RENEW_DEVICE")]
			public const string PropTokenUrlSuffixRenewDevice = (string) "msso.url.renew_device";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URL_SUFFIX_REQUEST_TOKEN']"
			[Register ("PROP_TOKEN_URL_SUFFIX_REQUEST_TOKEN")]
			public const string PropTokenUrlSuffixRequestToken = (string) "msso.url.request_token";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URL_SUFFIX_REQUEST_TOKEN_SSO']"
			[Register ("PROP_TOKEN_URL_SUFFIX_REQUEST_TOKEN_SSO")]
			public const string PropTokenUrlSuffixRequestTokenSso = (string) "msso.url.request_token_sso";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TOKEN_URL_SUFFIX_RESOURCE_OWNER_LOGOUT']"
			[Register ("PROP_TOKEN_URL_SUFFIX_RESOURCE_OWNER_LOGOUT")]
			public const string PropTokenUrlSuffixResourceOwnerLogout = (string) "msso.url.resource_owner_logout";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TRUSTED_CERTS_PEM']"
			[Register ("PROP_TRUSTED_CERTS_PEM")]
			public const string PropTrustedCertsPem = (string) "msso.trust.certs.pem";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TRUSTED_CERT_PINNED_PUBLIC_KEY_HASHES']"
			[Register ("PROP_TRUSTED_CERT_PINNED_PUBLIC_KEY_HASHES")]
			public const string PropTrustedCertPinnedPublicKeyHashes = (string) "msso.trust.certs.pins.sha256";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/interface[@name='MobileSsoConfig']/field[@name='PROP_TRUSTED_PUBLIC_PKI']"
			[Register ("PROP_TRUSTED_PUBLIC_PKI")]
			public const string PropTrustedPublicPki = (string) "msso.trust.public.pki";
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/conf/DefaultConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultConfiguration); }
		}

		protected DefaultConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/constructor[@name='DefaultConfiguration' and count(parameter)=9 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Integer'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe DefaultConfiguration (global::Org.Json.JSONObject raw, string tokenHost, global::Java.Lang.Integer port, string tokenUriPrefix, string clientId, string clientSecret, string organization, string scope, string redirectUri)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tokenHost = JNIEnv.NewString (tokenHost);
			IntPtr native_tokenUriPrefix = JNIEnv.NewString (tokenUriPrefix);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_clientSecret = JNIEnv.NewString (clientSecret);
			IntPtr native_organization = JNIEnv.NewString (organization);
			IntPtr native_scope = JNIEnv.NewString (scope);
			IntPtr native_redirectUri = JNIEnv.NewString (redirectUri);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (raw);
				__args [1] = new JValue (native_tokenHost);
				__args [2] = new JValue (port);
				__args [3] = new JValue (native_tokenUriPrefix);
				__args [4] = new JValue (native_clientId);
				__args [5] = new JValue (native_clientSecret);
				__args [6] = new JValue (native_organization);
				__args [7] = new JValue (native_scope);
				__args [8] = new JValue (native_redirectUri);
				if (((object) this).GetType () != typeof (DefaultConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONObject_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tokenHost);
				JNIEnv.DeleteLocalRef (native_tokenUriPrefix);
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
				JNIEnv.DeleteLocalRef (native_organization);
				JNIEnv.DeleteLocalRef (native_scope);
				JNIEnv.DeleteLocalRef (native_redirectUri);
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientScope;
#pragma warning disable 0169
		static Delegate GetGetClientScopeHandler ()
		{
			if (cb_getClientScope == null)
				cb_getClientScope = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientScope);
			return cb_getClientScope;
		}

		static IntPtr n_GetClientScope (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientScope);
		}
#pragma warning restore 0169

		static IntPtr id_getClientScope;
		public virtual unsafe string ClientScope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getClientScope' and count(parameter)=0]"
			[Register ("getClientScope", "()Ljava/lang/String;", "GetGetClientScopeHandler")]
			get {
				if (id_getClientScope == IntPtr.Zero)
					id_getClientScope = JNIEnv.GetMethodID (class_ref, "getClientScope", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientScope), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientScope", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientSecret;
#pragma warning disable 0169
		static Delegate GetGetClientSecretHandler ()
		{
			if (cb_getClientSecret == null)
				cb_getClientSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientSecret);
			return cb_getClientSecret;
		}

		static IntPtr n_GetClientSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getClientSecret;
		public virtual unsafe string ClientSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getClientSecret' and count(parameter)=0]"
			[Register ("getClientSecret", "()Ljava/lang/String;", "GetGetClientSecretHandler")]
			get {
				if (id_getClientSecret == IntPtr.Zero)
					id_getClientSecret = JNIEnv.GetMethodID (class_ref, "getClientSecret", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientSecret), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAlsoTrustPublicPki;
#pragma warning disable 0169
		static Delegate GetIsAlsoTrustPublicPkiHandler ()
		{
			if (cb_isAlsoTrustPublicPki == null)
				cb_isAlsoTrustPublicPki = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAlsoTrustPublicPki);
			return cb_isAlsoTrustPublicPki;
		}

		static bool n_IsAlsoTrustPublicPki (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAlsoTrustPublicPki;
		}
#pragma warning restore 0169

		static IntPtr id_isAlsoTrustPublicPki;
		public virtual unsafe bool IsAlsoTrustPublicPki {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='isAlsoTrustPublicPki' and count(parameter)=0]"
			[Register ("isAlsoTrustPublicPki", "()Z", "GetIsAlsoTrustPublicPkiHandler")]
			get {
				if (id_isAlsoTrustPublicPki == IntPtr.Zero)
					id_isAlsoTrustPublicPki = JNIEnv.GetMethodID (class_ref, "isAlsoTrustPublicPki", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAlsoTrustPublicPki);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAlsoTrustPublicPki", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getPrefix;
#pragma warning disable 0169
		static Delegate GetGetPrefixHandler ()
		{
			if (cb_getPrefix == null)
				cb_getPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrefix);
			return cb_getPrefix;
		}

		static IntPtr n_GetPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Prefix);
		}
#pragma warning restore 0169

		static IntPtr id_getPrefix;
		public virtual unsafe string Prefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getPrefix' and count(parameter)=0]"
			[Register ("getPrefix", "()Ljava/lang/String;", "GetGetPrefixHandler")]
			get {
				if (id_getPrefix == IntPtr.Zero)
					id_getPrefix = JNIEnv.GetMethodID (class_ref, "getPrefix", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrefix), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrefix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRaw;
#pragma warning disable 0169
		static Delegate GetGetRawHandler ()
		{
			if (cb_getRaw == null)
				cb_getRaw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRaw);
			return cb_getRaw;
		}

		static IntPtr n_GetRaw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Raw);
		}
#pragma warning restore 0169

		static IntPtr id_getRaw;
		public virtual unsafe global::Org.Json.JSONObject Raw {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getRaw' and count(parameter)=0]"
			[Register ("getRaw", "()Lorg/json/JSONObject;", "GetGetRawHandler")]
			get {
				if (id_getRaw == IntPtr.Zero)
					id_getRaw = JNIEnv.GetMethodID (class_ref, "getRaw", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRaw), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRaw", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetRedirectUriHandler ()
		{
			if (cb_getRedirectUri == null)
				cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUri);
			return cb_getRedirectUri;
		}

		static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedirectUri);
		}
#pragma warning restore 0169

		static IntPtr id_getRedirectUri;
		public virtual unsafe string RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Ljava/lang/String;", "GetGetRedirectUriHandler")]
			get {
				if (id_getRedirectUri == IntPtr.Zero)
					id_getRedirectUri = JNIEnv.GetMethodID (class_ref, "getRedirectUri", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRedirectUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedirectUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScope;
#pragma warning disable 0169
		static Delegate GetGetScopeHandler ()
		{
			if (cb_getScope == null)
				cb_getScope = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScope);
			return cb_getScope;
		}

		static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scope);
		}
#pragma warning restore 0169

		static IntPtr id_getScope;
		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				if (id_getScope == IntPtr.Zero)
					id_getScope = JNIEnv.GetMethodID (class_ref, "getScope", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScope), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScope", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServer;
#pragma warning disable 0169
		static Delegate GetGetServerHandler ()
		{
			if (cb_getServer == null)
				cb_getServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServer);
			return cb_getServer;
		}

		static IntPtr n_GetServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		static IntPtr id_getServer;
		public virtual unsafe global::Com.CA.Mas.Core.Conf.Server Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getServer' and count(parameter)=0]"
			[Register ("getServer", "()Lcom/ca/mas/core/conf/Server;", "GetGetServerHandler")]
			get {
				if (id_getServer == IntPtr.Zero)
					id_getServer = JNIEnv.GetMethodID (class_ref, "getServer", "()Lcom/ca/mas/core/conf/Server;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServer", "()Lcom/ca/mas/core/conf/Server;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenHost;
#pragma warning disable 0169
		static Delegate GetGetTokenHostHandler ()
		{
			if (cb_getTokenHost == null)
				cb_getTokenHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenHost);
			return cb_getTokenHost;
		}

		static IntPtr n_GetTokenHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenHost);
		}
#pragma warning restore 0169

		static IntPtr id_getTokenHost;
		public virtual unsafe string TokenHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getTokenHost' and count(parameter)=0]"
			[Register ("getTokenHost", "()Ljava/lang/String;", "GetGetTokenHostHandler")]
			get {
				if (id_getTokenHost == IntPtr.Zero)
					id_getTokenHost = JNIEnv.GetMethodID (class_ref, "getTokenHost", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenHost), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenHost", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenPort;
#pragma warning disable 0169
		static Delegate GetGetTokenPortHandler ()
		{
			if (cb_getTokenPort == null)
				cb_getTokenPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTokenPort);
			return cb_getTokenPort;
		}

		static int n_GetTokenPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TokenPort;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenPort;
		public virtual unsafe int TokenPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getTokenPort' and count(parameter)=0]"
			[Register ("getTokenPort", "()I", "GetGetTokenPortHandler")]
			get {
				if (id_getTokenPort == IntPtr.Zero)
					id_getTokenPort = JNIEnv.GetMethodID (class_ref, "getTokenPort", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTokenPort);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenPort", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTrustedCertificateAnchors;
#pragma warning disable 0169
		static Delegate GetGetTrustedCertificateAnchorsHandler ()
		{
			if (cb_getTrustedCertificateAnchors == null)
				cb_getTrustedCertificateAnchors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrustedCertificateAnchors);
			return cb_getTrustedCertificateAnchors;
		}

		static IntPtr n_GetTrustedCertificateAnchors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Java.Security.Cert.X509Certificate>.ToLocalJniHandle (__this.TrustedCertificateAnchors);
		}
#pragma warning restore 0169

		static IntPtr id_getTrustedCertificateAnchors;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Security.Cert.X509Certificate> TrustedCertificateAnchors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getTrustedCertificateAnchors' and count(parameter)=0]"
			[Register ("getTrustedCertificateAnchors", "()Ljava/util/Collection;", "GetGetTrustedCertificateAnchorsHandler")]
			get {
				if (id_getTrustedCertificateAnchors == IntPtr.Zero)
					id_getTrustedCertificateAnchors = JNIEnv.GetMethodID (class_ref, "getTrustedCertificateAnchors", "()Ljava/util/Collection;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<global::Java.Security.Cert.X509Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrustedCertificateAnchors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<global::Java.Security.Cert.X509Certificate>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrustedCertificateAnchors", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrustedCertificatePinnedPublicKeyHashes;
#pragma warning disable 0169
		static Delegate GetGetTrustedCertificatePinnedPublicKeyHashesHandler ()
		{
			if (cb_getTrustedCertificatePinnedPublicKeyHashes == null)
				cb_getTrustedCertificatePinnedPublicKeyHashes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrustedCertificatePinnedPublicKeyHashes);
			return cb_getTrustedCertificatePinnedPublicKeyHashes;
		}

		static IntPtr n_GetTrustedCertificatePinnedPublicKeyHashes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash>.ToLocalJniHandle (__this.TrustedCertificatePinnedPublicKeyHashes);
		}
#pragma warning restore 0169

		static IntPtr id_getTrustedCertificatePinnedPublicKeyHashes;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash> TrustedCertificatePinnedPublicKeyHashes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getTrustedCertificatePinnedPublicKeyHashes' and count(parameter)=0]"
			[Register ("getTrustedCertificatePinnedPublicKeyHashes", "()Ljava/util/Collection;", "GetGetTrustedCertificatePinnedPublicKeyHashesHandler")]
			get {
				if (id_getTrustedCertificatePinnedPublicKeyHashes == IntPtr.Zero)
					id_getTrustedCertificatePinnedPublicKeyHashes = JNIEnv.GetMethodID (class_ref, "getTrustedCertificatePinnedPublicKeyHashes", "()Ljava/util/Collection;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrustedCertificatePinnedPublicKeyHashes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrustedCertificatePinnedPublicKeyHashes", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserInfoUri;
#pragma warning disable 0169
		static Delegate GetGetUserInfoUriHandler ()
		{
			if (cb_getUserInfoUri == null)
				cb_getUserInfoUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserInfoUri);
			return cb_getUserInfoUri;
		}

		static IntPtr n_GetUserInfoUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserInfoUri);
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfoUri;
		public virtual unsafe global::Android.Net.Uri UserInfoUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getUserInfoUri' and count(parameter)=0]"
			[Register ("getUserInfoUri", "()Landroid/net/Uri;", "GetGetUserInfoUriHandler")]
			get {
				if (id_getUserInfoUri == IntPtr.Zero)
					id_getUserInfoUri = JNIEnv.GetMethodID (class_ref, "getUserInfoUri", "()Landroid/net/Uri;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserInfoUri), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfoUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addTrustedCertificateAnchors_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddTrustedCertificateAnchors_arrayLjava_lang_String_Handler ()
		{
			if (cb_addTrustedCertificateAnchors_arrayLjava_lang_String_ == null)
				cb_addTrustedCertificateAnchors_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTrustedCertificateAnchors_arrayLjava_lang_String_);
			return cb_addTrustedCertificateAnchors_arrayLjava_lang_String_;
		}

		static void n_AddTrustedCertificateAnchors_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_certs)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] certs = (string[]) JNIEnv.GetArray (native_certs, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.AddTrustedCertificateAnchors (certs);
			if (certs != null)
				JNIEnv.CopyArray (certs, native_certs);
		}
#pragma warning restore 0169

		static IntPtr id_addTrustedCertificateAnchors_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='addTrustedCertificateAnchors' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("addTrustedCertificateAnchors", "([Ljava/lang/String;)V", "GetAddTrustedCertificateAnchors_arrayLjava_lang_String_Handler")]
		public virtual unsafe void AddTrustedCertificateAnchors (params  string[] certs)
		{
			if (id_addTrustedCertificateAnchors_arrayLjava_lang_String_ == IntPtr.Zero)
				id_addTrustedCertificateAnchors_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addTrustedCertificateAnchors", "([Ljava/lang/String;)V");
			IntPtr native_certs = JNIEnv.NewArray (certs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_certs);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTrustedCertificateAnchors_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTrustedCertificateAnchors", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (certs != null) {
					JNIEnv.CopyArray (native_certs, certs);
					JNIEnv.DeleteLocalRef (native_certs);
				}
			}
		}

		static Delegate cb_addTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_Handler ()
		{
			if (cb_addTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_ == null)
				cb_addTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_);
			return cb_addTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_;
		}

		static void n_AddTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hashes)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] hashes = (string[]) JNIEnv.GetArray (native_hashes, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.AddTrustedCertificatePinnedPublicKeyHashes (hashes);
			if (hashes != null)
				JNIEnv.CopyArray (hashes, native_hashes);
		}
#pragma warning restore 0169

		static IntPtr id_addTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='addTrustedCertificatePinnedPublicKeyHashes' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("addTrustedCertificatePinnedPublicKeyHashes", "([Ljava/lang/String;)V", "GetAddTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_Handler")]
		public virtual unsafe void AddTrustedCertificatePinnedPublicKeyHashes (params  string[] hashes)
		{
			if (id_addTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_ == IntPtr.Zero)
				id_addTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addTrustedCertificatePinnedPublicKeyHashes", "([Ljava/lang/String;)V");
			IntPtr native_hashes = JNIEnv.NewArray (hashes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_hashes);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTrustedCertificatePinnedPublicKeyHashes_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTrustedCertificatePinnedPublicKeyHashes", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (hashes != null) {
					JNIEnv.CopyArray (native_hashes, hashes);
					JNIEnv.DeleteLocalRef (native_hashes);
				}
			}
		}

		static Delegate cb_getProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getProperty_Ljava_lang_String_ == null)
				cb_getProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProperty_Ljava_lang_String_);
			return cb_getProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_propertyName)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string propertyName = JNIEnv.GetString (native_propertyName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProperty (propertyName));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProperty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetProperty_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object GetProperty (string propertyName)
		{
			if (id_getProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_getProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_propertyName);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
			}
		}

		static Delegate cb_getTokenUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTokenUri_Ljava_lang_String_Handler ()
		{
			if (cb_getTokenUri_Ljava_lang_String_ == null)
				cb_getTokenUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTokenUri_Ljava_lang_String_);
			return cb_getTokenUri_Ljava_lang_String_;
		}

		static IntPtr n_GetTokenUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operation)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string operation = JNIEnv.GetString (native_operation, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTokenUri (operation));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenUri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getTokenUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTokenUri", "(Ljava/lang/String;)Ljava/net/URI;", "GetGetTokenUri_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Net.URI GetTokenUri (string operation)
		{
			if (id_getTokenUri_Ljava_lang_String_ == IntPtr.Zero)
				id_getTokenUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTokenUri", "(Ljava/lang/String;)Ljava/net/URI;");
			IntPtr native_operation = JNIEnv.NewString (operation);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_operation);

				global::Java.Net.URI __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenUri", "(Ljava/lang/String;)Ljava/net/URI;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_operation);
			}
		}

		static Delegate cb_getTokenUrlSuffix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTokenUrlSuffix_Ljava_lang_String_Handler ()
		{
			if (cb_getTokenUrlSuffix_Ljava_lang_String_ == null)
				cb_getTokenUrlSuffix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTokenUrlSuffix_Ljava_lang_String_);
			return cb_getTokenUrlSuffix_Ljava_lang_String_;
		}

		static IntPtr n_GetTokenUrlSuffix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_operation)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string operation = JNIEnv.GetString (native_operation, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTokenUrlSuffix (operation));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenUrlSuffix_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getTokenUrlSuffix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTokenUrlSuffix", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTokenUrlSuffix_Ljava_lang_String_Handler")]
		protected virtual unsafe string GetTokenUrlSuffix (string operation)
		{
			if (id_getTokenUrlSuffix_Ljava_lang_String_ == IntPtr.Zero)
				id_getTokenUrlSuffix_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTokenUrlSuffix", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_operation = JNIEnv.NewString (operation);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_operation);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenUrlSuffix_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenUrlSuffix", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_operation);
			}
		}

		static Delegate cb_getUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUri_Ljava_lang_String_Handler ()
		{
			if (cb_getUri_Ljava_lang_String_ == null)
				cb_getUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUri_Ljava_lang_String_);
			return cb_getUri_Ljava_lang_String_;
		}

		static IntPtr n_GetUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_relativePath)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string relativePath = JNIEnv.GetString (native_relativePath, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUri (relativePath));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='getUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUri", "(Ljava/lang/String;)Ljava/net/URI;", "GetGetUri_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Net.URI GetUri (string relativePath)
		{
			if (id_getUri_Ljava_lang_String_ == IntPtr.Zero)
				id_getUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getUri", "(Ljava/lang/String;)Ljava/net/URI;");
			IntPtr native_relativePath = JNIEnv.NewString (relativePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_relativePath);

				global::Java.Net.URI __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUri", "(Ljava/lang/String;)Ljava/net/URI;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_relativePath);
			}
		}

		static Delegate cb_putProperty_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPutProperty_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_putProperty_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_putProperty_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutProperty_Ljava_lang_String_Ljava_lang_Object_);
			return cb_putProperty_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_PutProperty_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_propertyName, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string propertyName = JNIEnv.GetString (native_propertyName, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PutProperty (propertyName, value);
		}
#pragma warning restore 0169

		static IntPtr id_putProperty_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='putProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("putProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetPutProperty_Ljava_lang_String_Ljava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe void PutProperty (string propertyName, global::Java.Lang.Object value)
		{
			if (id_putProperty_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_putProperty_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "putProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_propertyName = JNIEnv.NewString (propertyName);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_propertyName);
				__args [1] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putProperty_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_propertyName);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setAlsoTrustPublicPki_Z;
#pragma warning disable 0169
		static Delegate GetSetAlsoTrustPublicPki_ZHandler ()
		{
			if (cb_setAlsoTrustPublicPki_Z == null)
				cb_setAlsoTrustPublicPki_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAlsoTrustPublicPki_Z);
			return cb_setAlsoTrustPublicPki_Z;
		}

		static void n_SetAlsoTrustPublicPki_Z (IntPtr jnienv, IntPtr native__this, bool alsoTrustPublicPki)
		{
			global::Com.CA.Mas.Core.Conf.DefaultConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.DefaultConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlsoTrustPublicPki (alsoTrustPublicPki);
		}
#pragma warning restore 0169

		static IntPtr id_setAlsoTrustPublicPki_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='DefaultConfiguration']/method[@name='setAlsoTrustPublicPki' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAlsoTrustPublicPki", "(Z)V", "GetSetAlsoTrustPublicPki_ZHandler")]
		public virtual unsafe void SetAlsoTrustPublicPki (bool alsoTrustPublicPki)
		{
			if (id_setAlsoTrustPublicPki_Z == IntPtr.Zero)
				id_setAlsoTrustPublicPki_Z = JNIEnv.GetMethodID (class_ref, "setAlsoTrustPublicPki", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (alsoTrustPublicPki);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlsoTrustPublicPki_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlsoTrustPublicPki", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
