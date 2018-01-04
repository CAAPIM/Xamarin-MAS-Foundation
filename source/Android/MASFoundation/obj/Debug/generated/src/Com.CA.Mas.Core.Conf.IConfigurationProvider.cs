using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Conf {

	[Register ("com/ca/mas/core/conf/ConfigurationProvider", DoNotGenerateAcw=true)]
	public abstract class ConfigurationProvider : Java.Lang.Object {

		internal ConfigurationProvider ()
		{
		}

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

		// The following are fields from: com.ca.mas.core.cert.TrustedCertificateConfiguration
	}

	[Register ("com/ca/mas/core/conf/ConfigurationProvider", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'ConfigurationProvider' type. This type will be removed in a future release.")]
	public abstract class ConfigurationProviderConsts : ConfigurationProvider {

		private ConfigurationProviderConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']"
	[Register ("com/ca/mas/core/conf/ConfigurationProvider", "", "Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker")]
	public partial interface IConfigurationProvider : global::Com.CA.Mas.Core.Cert.ITrustedCertificateConfiguration {

		string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")] get;
		}

		string ClientScope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getClientScope' and count(parameter)=0]"
			[Register ("getClientScope", "()Ljava/lang/String;", "GetGetClientScopeHandler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")] get;
		}

		string ClientSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getClientSecret' and count(parameter)=0]"
			[Register ("getClientSecret", "()Ljava/lang/String;", "GetGetClientSecretHandler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")] get;
		}

		string Prefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getPrefix' and count(parameter)=0]"
			[Register ("getPrefix", "()Ljava/lang/String;", "GetGetPrefixHandler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")] get;
		}

		global::Org.Json.JSONObject Raw {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getRaw' and count(parameter)=0]"
			[Register ("getRaw", "()Lorg/json/JSONObject;", "GetGetRawHandler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")] get;
		}

		global::Com.CA.Mas.Core.Conf.Server Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getServer' and count(parameter)=0]"
			[Register ("getServer", "()Lcom/ca/mas/core/conf/Server;", "GetGetServerHandler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")] get;
		}

		string TokenHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getTokenHost' and count(parameter)=0]"
			[Register ("getTokenHost", "()Ljava/lang/String;", "GetGetTokenHostHandler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")] get;
		}

		int TokenPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getTokenPort' and count(parameter)=0]"
			[Register ("getTokenPort", "()I", "GetGetTokenPortHandler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")] get;
		}

		global::Android.Net.Uri UserInfoUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getUserInfoUri' and count(parameter)=0]"
			[Register ("getUserInfoUri", "()Landroid/net/Uri;", "GetGetUserInfoUriHandler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetProperty_Ljava_lang_String_Handler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Java.Lang.Object GetProperty (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getTokenUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTokenUri", "(Ljava/lang/String;)Ljava/net/URI;", "GetGetTokenUri_Ljava_lang_String_Handler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")]
		global::Java.Net.URI GetTokenUri (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/interface[@name='ConfigurationProvider']/method[@name='getUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUri", "(Ljava/lang/String;)Ljava/net/URI;", "GetGetUri_Ljava_lang_String_Handler:Com.CA.Mas.Core.Conf.IConfigurationProviderInvoker, MASFoundation")]
		global::Java.Net.URI GetUri (string p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/conf/ConfigurationProvider", DoNotGenerateAcw=true)]
	internal class IConfigurationProviderInvoker : global::Java.Lang.Object, IConfigurationProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/conf/ConfigurationProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConfigurationProviderInvoker); }
		}

		IntPtr class_ref;

		public static IConfigurationProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfigurationProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.conf.ConfigurationProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigurationProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		IntPtr id_getClientId;
		public unsafe string ClientId {
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientScope);
		}
#pragma warning restore 0169

		IntPtr id_getClientScope;
		public unsafe string ClientScope {
			get {
				if (id_getClientScope == IntPtr.Zero)
					id_getClientScope = JNIEnv.GetMethodID (class_ref, "getClientScope", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientScope), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientSecret);
		}
#pragma warning restore 0169

		IntPtr id_getClientSecret;
		public unsafe string ClientSecret {
			get {
				if (id_getClientSecret == IntPtr.Zero)
					id_getClientSecret = JNIEnv.GetMethodID (class_ref, "getClientSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientSecret), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Prefix);
		}
#pragma warning restore 0169

		IntPtr id_getPrefix;
		public unsafe string Prefix {
			get {
				if (id_getPrefix == IntPtr.Zero)
					id_getPrefix = JNIEnv.GetMethodID (class_ref, "getPrefix", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrefix), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Raw);
		}
#pragma warning restore 0169

		IntPtr id_getRaw;
		public unsafe global::Org.Json.JSONObject Raw {
			get {
				if (id_getRaw == IntPtr.Zero)
					id_getRaw = JNIEnv.GetMethodID (class_ref, "getRaw", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRaw), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Server);
		}
#pragma warning restore 0169

		IntPtr id_getServer;
		public unsafe global::Com.CA.Mas.Core.Conf.Server Server {
			get {
				if (id_getServer == IntPtr.Zero)
					id_getServer = JNIEnv.GetMethodID (class_ref, "getServer", "()Lcom/ca/mas/core/conf/Server;");
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServer), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenHost);
		}
#pragma warning restore 0169

		IntPtr id_getTokenHost;
		public unsafe string TokenHost {
			get {
				if (id_getTokenHost == IntPtr.Zero)
					id_getTokenHost = JNIEnv.GetMethodID (class_ref, "getTokenHost", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenHost), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TokenPort;
		}
#pragma warning restore 0169

		IntPtr id_getTokenPort;
		public unsafe int TokenPort {
			get {
				if (id_getTokenPort == IntPtr.Zero)
					id_getTokenPort = JNIEnv.GetMethodID (class_ref, "getTokenPort", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTokenPort);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserInfoUri);
		}
#pragma warning restore 0169

		IntPtr id_getUserInfoUri;
		public unsafe global::Android.Net.Uri UserInfoUri {
			get {
				if (id_getUserInfoUri == IntPtr.Zero)
					id_getUserInfoUri = JNIEnv.GetMethodID (class_ref, "getUserInfoUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserInfoUri), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_GetProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getProperty_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object GetProperty (string p0)
		{
			if (id_getProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_getProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getTokenUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTokenUri_Ljava_lang_String_Handler ()
		{
			if (cb_getTokenUri_Ljava_lang_String_ == null)
				cb_getTokenUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTokenUri_Ljava_lang_String_);
			return cb_getTokenUri_Ljava_lang_String_;
		}

		static IntPtr n_GetTokenUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTokenUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getTokenUri_Ljava_lang_String_;
		public unsafe global::Java.Net.URI GetTokenUri (string p0)
		{
			if (id_getTokenUri_Ljava_lang_String_ == IntPtr.Zero)
				id_getTokenUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTokenUri", "(Ljava/lang/String;)Ljava/net/URI;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Net.URI __ret = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUri_Ljava_lang_String_Handler ()
		{
			if (cb_getUri_Ljava_lang_String_ == null)
				cb_getUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUri_Ljava_lang_String_);
			return cb_getUri_Ljava_lang_String_;
		}

		static IntPtr n_GetUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getUri_Ljava_lang_String_;
		public unsafe global::Java.Net.URI GetUri (string p0)
		{
			if (id_getUri_Ljava_lang_String_ == IntPtr.Zero)
				id_getUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getUri", "(Ljava/lang/String;)Ljava/net/URI;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Net.URI __ret = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAlsoTrustPublicPki;
		}
#pragma warning restore 0169

		IntPtr id_isAlsoTrustPublicPki;
		public unsafe bool IsAlsoTrustPublicPki {
			get {
				if (id_isAlsoTrustPublicPki == IntPtr.Zero)
					id_isAlsoTrustPublicPki = JNIEnv.GetMethodID (class_ref, "isAlsoTrustPublicPki", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAlsoTrustPublicPki);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Java.Security.Cert.X509Certificate>.ToLocalJniHandle (__this.TrustedCertificateAnchors);
		}
#pragma warning restore 0169

		IntPtr id_getTrustedCertificateAnchors;
		public unsafe global::System.Collections.Generic.ICollection<global::Java.Security.Cert.X509Certificate> TrustedCertificateAnchors {
			get {
				if (id_getTrustedCertificateAnchors == IntPtr.Zero)
					id_getTrustedCertificateAnchors = JNIEnv.GetMethodID (class_ref, "getTrustedCertificateAnchors", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Java.Security.Cert.X509Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrustedCertificateAnchors), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash>.ToLocalJniHandle (__this.TrustedCertificatePinnedPublicKeyHashes);
		}
#pragma warning restore 0169

		IntPtr id_getTrustedCertificatePinnedPublicKeyHashes;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash> TrustedCertificatePinnedPublicKeyHashes {
			get {
				if (id_getTrustedCertificatePinnedPublicKeyHashes == IntPtr.Zero)
					id_getTrustedCertificatePinnedPublicKeyHashes = JNIEnv.GetMethodID (class_ref, "getTrustedCertificatePinnedPublicKeyHashes", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrustedCertificatePinnedPublicKeyHashes), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
