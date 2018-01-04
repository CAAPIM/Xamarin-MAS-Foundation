using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Conf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']"
	[global::Android.Runtime.Register ("com/ca/mas/core/conf/Config", DoNotGenerateAcw=true)]
	public partial class Config : global::Java.Lang.Object {


		static IntPtr AUTHENTICATE_OTP_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='AUTHENTICATE_OTP_PATH']"
		[Register ("AUTHENTICATE_OTP_PATH")]
		public static global::Com.CA.Mas.Core.Conf.Config AuthenticateOtpPath {
			get {
				if (AUTHENTICATE_OTP_PATH_jfieldId == IntPtr.Zero)
					AUTHENTICATE_OTP_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHENTICATE_OTP_PATH", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHENTICATE_OTP_PATH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AUTHORIZE_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='AUTHORIZE_PATH']"
		[Register ("AUTHORIZE_PATH")]
		public static global::Com.CA.Mas.Core.Conf.Config AuthorizePath {
			get {
				if (AUTHORIZE_PATH_jfieldId == IntPtr.Zero)
					AUTHORIZE_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZE_PATH", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZE_PATH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BLE_RSSI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='BLE_RSSI']"
		[Register ("BLE_RSSI")]
		public static global::Com.CA.Mas.Core.Conf.Config BleRssi {
			get {
				if (BLE_RSSI_jfieldId == IntPtr.Zero)
					BLE_RSSI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLE_RSSI", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BLE_RSSI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BLE_SERVICE_UUID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='BLE_SERVICE_UUID']"
		[Register ("BLE_SERVICE_UUID")]
		public static global::Com.CA.Mas.Core.Conf.Config BleServiceUuid {
			get {
				if (BLE_SERVICE_UUID_jfieldId == IntPtr.Zero)
					BLE_SERVICE_UUID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLE_SERVICE_UUID", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BLE_SERVICE_UUID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BLE_USER_SESSION_CHARACTERISTIC_UUID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='BLE_USER_SESSION_CHARACTERISTIC_UUID']"
		[Register ("BLE_USER_SESSION_CHARACTERISTIC_UUID")]
		public static global::Com.CA.Mas.Core.Conf.Config BleUserSessionCharacteristicUuid {
			get {
				if (BLE_USER_SESSION_CHARACTERISTIC_UUID_jfieldId == IntPtr.Zero)
					BLE_USER_SESSION_CHARACTERISTIC_UUID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLE_USER_SESSION_CHARACTERISTIC_UUID", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BLE_USER_SESSION_CHARACTERISTIC_UUID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CLIENT_CERT_RSA_KEYBITS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='CLIENT_CERT_RSA_KEYBITS']"
		[Register ("CLIENT_CERT_RSA_KEYBITS")]
		public static global::Com.CA.Mas.Core.Conf.Config ClientCertRsaKeybits {
			get {
				if (CLIENT_CERT_RSA_KEYBITS_jfieldId == IntPtr.Zero)
					CLIENT_CERT_RSA_KEYBITS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_CERT_RSA_KEYBITS", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_CERT_RSA_KEYBITS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CLIENT_CREDENTIAL_INIT_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='CLIENT_CREDENTIAL_INIT_PATH']"
		[Register ("CLIENT_CREDENTIAL_INIT_PATH")]
		public static global::Com.CA.Mas.Core.Conf.Config ClientCredentialInitPath {
			get {
				if (CLIENT_CREDENTIAL_INIT_PATH_jfieldId == IntPtr.Zero)
					CLIENT_CREDENTIAL_INIT_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_CREDENTIAL_INIT_PATH", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_CREDENTIAL_INIT_PATH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CLIENT_KEY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='CLIENT_KEY']"
		[Register ("CLIENT_KEY")]
		public static global::Com.CA.Mas.Core.Conf.Config ClientKey {
			get {
				if (CLIENT_KEY_jfieldId == IntPtr.Zero)
					CLIENT_KEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_KEY", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_KEY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CLIENT_SECRET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='CLIENT_SECRET']"
		[Register ("CLIENT_SECRET")]
		public static global::Com.CA.Mas.Core.Conf.Config ClientSecret {
			get {
				if (CLIENT_SECRET_jfieldId == IntPtr.Zero)
					CLIENT_SECRET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_SECRET", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_SECRET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CLIENT_STORAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='CLIENT_STORAGE']"
		[Register ("CLIENT_STORAGE")]
		public static global::Com.CA.Mas.Core.Conf.Config ClientStorage {
			get {
				if (CLIENT_STORAGE_jfieldId == IntPtr.Zero)
					CLIENT_STORAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_STORAGE", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_STORAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ENTERPRISE_APP_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='ENTERPRISE_APP_PATH']"
		[Register ("ENTERPRISE_APP_PATH")]
		public static global::Com.CA.Mas.Core.Conf.Config EnterpriseAppPath {
			get {
				if (ENTERPRISE_APP_PATH_jfieldId == IntPtr.Zero)
					ENTERPRISE_APP_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENTERPRISE_APP_PATH", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENTERPRISE_APP_PATH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HOSTNAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='HOSTNAME']"
		[Register ("HOSTNAME")]
		public static global::Com.CA.Mas.Core.Conf.Config Hostname {
			get {
				if (HOSTNAME_jfieldId == IntPtr.Zero)
					HOSTNAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HOSTNAME", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HOSTNAME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOCATION_ENABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='LOCATION_ENABLED']"
		[Register ("LOCATION_ENABLED")]
		public static global::Com.CA.Mas.Core.Conf.Config LocationEnabled {
			get {
				if (LOCATION_ENABLED_jfieldId == IntPtr.Zero)
					LOCATION_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_ENABLED", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCATION_ENABLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOCATION_PROVIDER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='LOCATION_PROVIDER']"
		[Register ("LOCATION_PROVIDER")]
		public static global::Com.CA.Mas.Core.Conf.Config LocationProvider {
			get {
				if (LOCATION_PROVIDER_jfieldId == IntPtr.Zero)
					LOCATION_PROVIDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION_PROVIDER", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCATION_PROVIDER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOGOUT_DEVICE_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='LOGOUT_DEVICE_PATH']"
		[Register ("LOGOUT_DEVICE_PATH")]
		public static global::Com.CA.Mas.Core.Conf.Config LogoutDevicePath {
			get {
				if (LOGOUT_DEVICE_PATH_jfieldId == IntPtr.Zero)
					LOGOUT_DEVICE_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOGOUT_DEVICE_PATH", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOGOUT_DEVICE_PATH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MSISDN_ENABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='MSISDN_ENABLED']"
		[Register ("MSISDN_ENABLED")]
		public static global::Com.CA.Mas.Core.Conf.Config MsisdnEnabled {
			get {
				if (MSISDN_ENABLED_jfieldId == IntPtr.Zero)
					MSISDN_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MSISDN_ENABLED", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MSISDN_ENABLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ORGANIZATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='ORGANIZATION']"
		[Register ("ORGANIZATION")]
		public static global::Com.CA.Mas.Core.Conf.Config Organization {
			get {
				if (ORGANIZATION_jfieldId == IntPtr.Zero)
					ORGANIZATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ORGANIZATION", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ORGANIZATION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PORT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='PORT']"
		[Register ("PORT")]
		public static global::Com.CA.Mas.Core.Conf.Config Port {
			get {
				if (PORT_jfieldId == IntPtr.Zero)
					PORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PORT", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PORT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PREFIX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='PREFIX']"
		[Register ("PREFIX")]
		public static global::Com.CA.Mas.Core.Conf.Config Prefix {
			get {
				if (PREFIX_jfieldId == IntPtr.Zero)
					PREFIX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREFIX", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREFIX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REDIRECT_URI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='REDIRECT_URI']"
		[Register ("REDIRECT_URI")]
		public static global::Com.CA.Mas.Core.Conf.Config RedirectUri {
			get {
				if (REDIRECT_URI_jfieldId == IntPtr.Zero)
					REDIRECT_URI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REDIRECT_URI", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REDIRECT_URI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REGISTER_DEVICE_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='REGISTER_DEVICE_PATH']"
		[Register ("REGISTER_DEVICE_PATH")]
		public static global::Com.CA.Mas.Core.Conf.Config RegisterDevicePath {
			get {
				if (REGISTER_DEVICE_PATH_jfieldId == IntPtr.Zero)
					REGISTER_DEVICE_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGISTER_DEVICE_PATH", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REGISTER_DEVICE_PATH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REGISTER_DEVICE_PATH_CLIENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='REGISTER_DEVICE_PATH_CLIENT']"
		[Register ("REGISTER_DEVICE_PATH_CLIENT")]
		public static global::Com.CA.Mas.Core.Conf.Config RegisterDevicePathClient {
			get {
				if (REGISTER_DEVICE_PATH_CLIENT_jfieldId == IntPtr.Zero)
					REGISTER_DEVICE_PATH_CLIENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGISTER_DEVICE_PATH_CLIENT", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REGISTER_DEVICE_PATH_CLIENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REGISTER_TOKEN_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='REGISTER_TOKEN_PATH']"
		[Register ("REGISTER_TOKEN_PATH")]
		public static global::Com.CA.Mas.Core.Conf.Config RegisterTokenPath {
			get {
				if (REGISTER_TOKEN_PATH_jfieldId == IntPtr.Zero)
					REGISTER_TOKEN_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGISTER_TOKEN_PATH", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REGISTER_TOKEN_PATH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REGISTER_TOKEN_PATH_SSO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='REGISTER_TOKEN_PATH_SSO']"
		[Register ("REGISTER_TOKEN_PATH_SSO")]
		public static global::Com.CA.Mas.Core.Conf.Config RegisterTokenPathSso {
			get {
				if (REGISTER_TOKEN_PATH_SSO_jfieldId == IntPtr.Zero)
					REGISTER_TOKEN_PATH_SSO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGISTER_TOKEN_PATH_SSO", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REGISTER_TOKEN_PATH_SSO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REMOVE_DEVICE_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='REMOVE_DEVICE_PATH']"
		[Register ("REMOVE_DEVICE_PATH")]
		public static global::Com.CA.Mas.Core.Conf.Config RemoveDevicePath {
			get {
				if (REMOVE_DEVICE_PATH_jfieldId == IntPtr.Zero)
					REMOVE_DEVICE_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REMOVE_DEVICE_PATH", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REMOVE_DEVICE_PATH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RENEW_DEVICE_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='RENEW_DEVICE_PATH']"
		[Register ("RENEW_DEVICE_PATH")]
		public static global::Com.CA.Mas.Core.Conf.Config RenewDevicePath {
			get {
				if (RENEW_DEVICE_PATH_jfieldId == IntPtr.Zero)
					RENEW_DEVICE_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RENEW_DEVICE_PATH", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RENEW_DEVICE_PATH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SCOPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='SCOPE']"
		[Register ("SCOPE")]
		public static global::Com.CA.Mas.Core.Conf.Config Scope {
			get {
				if (SCOPE_jfieldId == IntPtr.Zero)
					SCOPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCOPE", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCOPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SERVER_CERTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='SERVER_CERTS']"
		[Register ("SERVER_CERTS")]
		public static global::Com.CA.Mas.Core.Conf.Config ServerCerts {
			get {
				if (SERVER_CERTS_jfieldId == IntPtr.Zero)
					SERVER_CERTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVER_CERTS", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVER_CERTS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SSO_ENABLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='SSO_ENABLED']"
		[Register ("SSO_ENABLED")]
		public static global::Com.CA.Mas.Core.Conf.Config SsoEnabled {
			get {
				if (SSO_ENABLED_jfieldId == IntPtr.Zero)
					SSO_ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SSO_ENABLED", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SSO_ENABLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TRUSTED_CERT_PINNED_PUBLIC_KEY_HASHES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='TRUSTED_CERT_PINNED_PUBLIC_KEY_HASHES']"
		[Register ("TRUSTED_CERT_PINNED_PUBLIC_KEY_HASHES")]
		public static global::Com.CA.Mas.Core.Conf.Config TrustedCertPinnedPublicKeyHashes {
			get {
				if (TRUSTED_CERT_PINNED_PUBLIC_KEY_HASHES_jfieldId == IntPtr.Zero)
					TRUSTED_CERT_PINNED_PUBLIC_KEY_HASHES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRUSTED_CERT_PINNED_PUBLIC_KEY_HASHES", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRUSTED_CERT_PINNED_PUBLIC_KEY_HASHES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TRUSTED_PUBLIC_PKI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='TRUSTED_PUBLIC_PKI']"
		[Register ("TRUSTED_PUBLIC_PKI")]
		public static global::Com.CA.Mas.Core.Conf.Config TrustedPublicPki {
			get {
				if (TRUSTED_PUBLIC_PKI_jfieldId == IntPtr.Zero)
					TRUSTED_PUBLIC_PKI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRUSTED_PUBLIC_PKI", "Lcom/ca/mas/core/conf/Config;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRUSTED_PUBLIC_PKI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Config> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr key_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='key']"
		[Register ("key")]
		public string Key {
			get {
				if (key_jfieldId == IntPtr.Zero)
					key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, key_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (key_jfieldId == IntPtr.Zero)
					key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, key_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mandatory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='mandatory']"
		[Register ("mandatory")]
		public bool Mandatory {
			get {
				if (mandatory_jfieldId == IntPtr.Zero)
					mandatory_jfieldId = JNIEnv.GetFieldID (class_ref, "mandatory", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mandatory_jfieldId);
			}
			set {
				if (mandatory_jfieldId == IntPtr.Zero)
					mandatory_jfieldId = JNIEnv.GetFieldID (class_ref, "mandatory", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mandatory_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr path_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='path']"
		[Register ("path")]
		public string Path {
			get {
				if (path_jfieldId == IntPtr.Zero)
					path_jfieldId = JNIEnv.GetFieldID (class_ref, "path", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, path_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (path_jfieldId == IntPtr.Zero)
					path_jfieldId = JNIEnv.GetFieldID (class_ref, "path", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, path_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='type']"
		[Register ("type")]
		public global::Java.Lang.Class Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Ljava/lang/Class;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Ljava/lang/Class;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr values_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/field[@name='values']"
		[Register ("values")]
		public static IList<Com.CA.Mas.Core.Conf.Config> Values {
			get {
				if (values_jfieldId == IntPtr.Zero)
					values_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "values", "[Lcom/ca/mas/core/conf/Config;");
				return global::Android.Runtime.JavaArray<global::Com.CA.Mas.Core.Conf.Config>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, values_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (values_jfieldId == IntPtr.Zero)
					values_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "values", "[Lcom/ca/mas/core/conf/Config;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.CA.Mas.Core.Conf.Config>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, values_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/conf/Config", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Config); }
		}

		protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Config']/constructor[@name='Config' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Class']]"
		[Register (".ctor", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public unsafe Config (bool mandatory, string key, string path, global::Java.Lang.Class type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (mandatory);
				__args [1] = new JValue (native_key);
				__args [2] = new JValue (native_path);
				__args [3] = new JValue (type);
				if (((object) this).GetType () != typeof (Config)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_Class_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

	}
}
