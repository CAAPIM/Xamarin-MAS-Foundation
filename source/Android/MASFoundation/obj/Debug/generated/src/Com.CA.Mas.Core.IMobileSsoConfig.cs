using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core {

	[Register ("com/ca/mas/core/MobileSsoConfig", DoNotGenerateAcw=true)]
	public abstract class MobileSsoConfig : Java.Lang.Object {

		internal MobileSsoConfig ()
		{
		}

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

	[Register ("com/ca/mas/core/MobileSsoConfig", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MobileSsoConfig' type. This type will be removed in a future release.")]
	public abstract class MobileSsoConfigConsts : MobileSsoConfig {

		private MobileSsoConfigConsts ()
		{
		}
	}

}
