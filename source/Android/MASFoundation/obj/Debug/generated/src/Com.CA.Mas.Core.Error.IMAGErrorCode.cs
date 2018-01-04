using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Error {

	[Register ("com/ca/mas/core/error/MAGErrorCode", DoNotGenerateAcw=true)]
	public abstract class MAGErrorCode : Java.Lang.Object {

		internal MAGErrorCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='ACCESS_TOKEN_INVALID']"
		[Register ("ACCESS_TOKEN_INVALID")]
		public const int AccessTokenInvalid = (int) 130201;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='APPLICATION_ALREADY_REGISTERED']"
		[Register ("APPLICATION_ALREADY_REGISTERED")]
		public const int ApplicationAlreadyRegistered = (int) 110001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='APPLICATION_INVALID']"
		[Register ("APPLICATION_INVALID")]
		public const int ApplicationInvalid = (int) 110002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='APPLICATION_INVALID_MAG_IDENTIFER']"
		[Register ("APPLICATION_INVALID_MAG_IDENTIFER")]
		public const int ApplicationInvalidMagIdentifer = (int) 110004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='APPLICATION_NOT_REGISTERED']"
		[Register ("APPLICATION_NOT_REGISTERED")]
		public const int ApplicationNotRegistered = (int) 110003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='DEVICE_ALREADY_REGISTERED']"
		[Register ("DEVICE_ALREADY_REGISTERED")]
		public const int DeviceAlreadyRegistered = (int) 120001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='DEVICE_ALREADY_REGISTERED_WITH_DIFFERENT_FLOW']"
		[Register ("DEVICE_ALREADY_REGISTERED_WITH_DIFFERENT_FLOW")]
		public const int DeviceAlreadyRegisteredWithDifferentFlow = (int) 120002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='DEVICE_COULD_NOT_BE_DEREGISTERED']"
		[Register ("DEVICE_COULD_NOT_BE_DEREGISTERED")]
		public const int DeviceCouldNotBeDeregistered = (int) 120003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='DEVICE_NOT_LOGGED_IN']"
		[Register ("DEVICE_NOT_LOGGED_IN")]
		public const int DeviceNotLoggedIn = (int) 120005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='DEVICE_NOT_REGISTERED']"
		[Register ("DEVICE_NOT_REGISTERED")]
		public const int DeviceNotRegistered = (int) 120004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='DEVICE_NOT_RENEWED']"
		[Register ("DEVICE_NOT_RENEWED")]
		public const int DeviceNotRenewed = (int) 120009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='DEVICE_RECORD_IS_NOT_VALID']"
		[Register ("DEVICE_RECORD_IS_NOT_VALID")]
		public const int DeviceRecordIsNotValid = (int) 120006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='ENTERPRISE_BROWSER_APP_DOES_NOT_EXIST']"
		[Register ("ENTERPRISE_BROWSER_APP_DOES_NOT_EXIST")]
		public const int EnterpriseBrowserAppDoesNotExist = (int) 140004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='ENTERPRISE_BROWSER_INVALID_RESPONSE']"
		[Register ("ENTERPRISE_BROWSER_INVALID_RESPONSE")]
		public const int EnterpriseBrowserInvalidResponse = (int) 140005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='ENTERPRISE_BROWSER_NATIVE_APP_CANNOT_OPEN']"
		[Register ("ENTERPRISE_BROWSER_NATIVE_APP_CANNOT_OPEN")]
		public const int EnterpriseBrowserNativeAppCannotOpen = (int) 140003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='ENTERPRISE_BROWSER_NATIVE_APP_DOES_NOT_EXIST']"
		[Register ("ENTERPRISE_BROWSER_NATIVE_APP_DOES_NOT_EXIST")]
		public const int EnterpriseBrowserNativeAppDoesNotExist = (int) 140002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='ENTERPRISE_BROWSER_WEB_APP_INVALID_URL']"
		[Register ("ENTERPRISE_BROWSER_WEB_APP_INVALID_URL")]
		public const int EnterpriseBrowserWebAppInvalidUrl = (int) 140001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='FAILED_FILE_NOT_FOUND']"
		[Register ("FAILED_FILE_NOT_FOUND")]
		public const int FailedFileNotFound = (int) 100201;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='FAILED_JSON_SERIALIZATION']"
		[Register ("FAILED_JSON_SERIALIZATION")]
		public const int FailedJsonSerialization = (int) 100202;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='FAILED_JSON_VALIDATION']"
		[Register ("FAILED_JSON_VALIDATION")]
		public const int FailedJsonValidation = (int) 100203;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='GEOLOCATION_IS_INVALID']"
		[Register ("GEOLOCATION_IS_INVALID")]
		public const int GeolocationIsInvalid = (int) 100301;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='GEOLOCATION_IS_MISSING']"
		[Register ("GEOLOCATION_IS_MISSING")]
		public const int GeolocationIsMissing = (int) 100302;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='INVALID_ENDPOINT']"
		[Register ("INVALID_ENDPOINT")]
		public const int InvalidEndpoint = (int) 100204;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='INVALID_JSON']"
		[Register ("INVALID_JSON")]
		public const int InvalidJson = (int) 100002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='INVALID_URL']"
		[Register ("INVALID_URL")]
		public const int InvalidUrl = (int) 100001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='MSISDN_IS_INVALID']"
		[Register ("MSISDN_IS_INVALID")]
		public const int MsisdnIsInvalid = (int) 100304;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='MSISDN_IS_MISSING']"
		[Register ("MSISDN_IS_MISSING")]
		public const int MsisdnIsMissing = (int) 100305;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='REGISTRATION_ATTEMPTED_WITH_UNREGISTERED_SCOPE']"
		[Register ("REGISTRATION_ATTEMPTED_WITH_UNREGISTERED_SCOPE")]
		public const int RegistrationAttemptedWithUnregisteredScope = (int) 120007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='REGISTRATION_WITHOUT_REQUIRED_PARAMETERS']"
		[Register ("REGISTRATION_WITHOUT_REQUIRED_PARAMETERS")]
		public const int RegistrationWithoutRequiredParameters = (int) 120008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='TOKEN_ID_TOKEN_EXPIRED']"
		[Register ("TOKEN_ID_TOKEN_EXPIRED")]
		public const int TokenIdTokenExpired = (int) 130102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='TOKEN_ID_TOKEN_INVALID_AUD']"
		[Register ("TOKEN_ID_TOKEN_INVALID_AUD")]
		public const int TokenIdTokenInvalidAud = (int) 130103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='TOKEN_ID_TOKEN_INVALID_AZP']"
		[Register ("TOKEN_ID_TOKEN_INVALID_AZP")]
		public const int TokenIdTokenInvalidAzp = (int) 130104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='TOKEN_ID_TOKEN_INVALID_SIGNATURE']"
		[Register ("TOKEN_ID_TOKEN_INVALID_SIGNATURE")]
		public const int TokenIdTokenInvalidSignature = (int) 130105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='TOKEN_INVALID_ID_TOKEN']"
		[Register ("TOKEN_INVALID_ID_TOKEN")]
		public const int TokenInvalidIdToken = (int) 13101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='TYPE_UNSUPPORTED']"
		[Register ("TYPE_UNSUPPORTED")]
		public const int TypeUnsupported = (int) 100103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.error']/interface[@name='MAGErrorCode']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public const int Unknown = (int) -1;
	}

	[Register ("com/ca/mas/core/error/MAGErrorCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MAGErrorCode' type. This type will be removed in a future release.")]
	public abstract class MAGErrorCodeConsts : MAGErrorCode {

		private MAGErrorCodeConsts ()
		{
		}
	}

}
