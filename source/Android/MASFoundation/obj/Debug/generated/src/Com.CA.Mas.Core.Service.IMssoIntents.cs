using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Service {

	[Register ("com/ca/mas/core/service/MssoIntents", DoNotGenerateAcw=true)]
	public abstract class MssoIntents : Java.Lang.Object {

		internal MssoIntents ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='ACTION_CREDENTIALS_OBTAINED']"
		[Register ("ACTION_CREDENTIALS_OBTAINED")]
		public const string ActionCredentialsObtained = (string) "com.ca.mas.core.service.action.CREDENTIALS_OBTAINED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='ACTION_LAUNCH_ENTERPRISE_BROWSER']"
		[Register ("ACTION_LAUNCH_ENTERPRISE_BROWSER")]
		public const string ActionLaunchEnterpriseBrowser = (string) "com.ca.mas.core.service.action.LAUNCH_ENTERPRISE_BROWSER";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='ACTION_OBTAIN_CREDENTIALS']"
		[Register ("ACTION_OBTAIN_CREDENTIALS")]
		public const string ActionObtainCredentials = (string) "com.ca.mas.core.service.action.OBTAIN_CREDENTIALS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='ACTION_PROCESS_REQUEST']"
		[Register ("ACTION_PROCESS_REQUEST")]
		public const string ActionProcessRequest = (string) "com.ca.mas.core.service.action.PROCESS_REQUEST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='ACTION_RENDER_WEBVIEW']"
		[Register ("ACTION_RENDER_WEBVIEW")]
		public const string ActionRenderWebview = (string) "com.ca.mas.core.service.action.RENDER_WEBVIEW";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='ACTION_SYNC']"
		[Register ("ACTION_SYNC")]
		public const string ActionSync = (string) "com.ca.mas.core.service.action.SYNC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='ACTION_VALIDATE_OTP']"
		[Register ("ACTION_VALIDATE_OTP")]
		public const string ActionValidateOtp = (string) "com.ca.mas.core.service.action.VALIDATE_OTP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='EXTRA_APP']"
		[Register ("EXTRA_APP")]
		public const string ExtraApp = (string) "com.ca.mas.core.service.extra.app";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='EXTRA_APPS']"
		[Register ("EXTRA_APPS")]
		public const string ExtraApps = (string) "com.ca.mas.core.service.extra.apps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='EXTRA_AUTH_PROVIDERS']"
		[Register ("EXTRA_AUTH_PROVIDERS")]
		public const string ExtraAuthProviders = (string) "com.ca.mas.core.service.req.extra.social.login.providers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='EXTRA_CREDENTIALS']"
		[Register ("EXTRA_CREDENTIALS")]
		public const string ExtraCredentials = (string) "com.ca.mas.core.service.req.extra.credentials";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='EXTRA_OTP_HANDLER']"
		[Register ("EXTRA_OTP_HANDLER")]
		public const string ExtraOtpHandler = (string) "com.ca.mas.core.service.req.extra.auth.otp.handler";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='EXTRA_OTP_SELECTED_CHANNELS']"
		[Register ("EXTRA_OTP_SELECTED_CHANNELS")]
		public const string ExtraOtpSelectedChannels = (string) "com.ca.mas.core.service.req.extra.auth.otp.channels";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='EXTRA_OTP_VALUE']"
		[Register ("EXTRA_OTP_VALUE")]
		public const string ExtraOtpValue = (string) "com.ca.mas.core.service.req.extra.auth.otp.value";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='EXTRA_REQUEST_ID']"
		[Register ("EXTRA_REQUEST_ID")]
		public const string ExtraRequestId = (string) "com.ca.mas.core.service.req.extra.requestId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='EXTRA_SOCIAL_LOGIN_URL']"
		[Register ("EXTRA_SOCIAL_LOGIN_URL")]
		public const string ExtraSocialLoginUrl = (string) "com.ca.mas.core.service.req.extra.social.login.url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_AUTHORIZE']"
		[Register ("RESULT_CODE_ERR_AUTHORIZE")]
		[Obsolete ("deprecated")]
		public const int ResultCodeErrAuthorize = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_AWAITING_REGISTRATION']"
		[Register ("RESULT_CODE_ERR_AWAITING_REGISTRATION")]
		public const int ResultCodeErrAwaitingRegistration = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_BAD_REQUEST_ID']"
		[Register ("RESULT_CODE_ERR_BAD_REQUEST_ID")]
		public const int ResultCodeErrBadRequestId = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_CANCELED']"
		[Register ("RESULT_CODE_ERR_CANCELED")]
		public const int ResultCodeErrCanceled = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_CLIENT_CREDENTIALS']"
		[Register ("RESULT_CODE_ERR_CLIENT_CREDENTIALS")]
		public const int ResultCodeErrClientCredentials = (int) -901;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_ENTERPRISE_BROWSER_APP_NOT_EXIST']"
		[Register ("RESULT_CODE_ERR_ENTERPRISE_BROWSER_APP_NOT_EXIST")]
		public const int ResultCodeErrEnterpriseBrowserAppNotExist = (int) -804;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_ENTERPRISE_BROWSER_INVALID_JSON']"
		[Register ("RESULT_CODE_ERR_ENTERPRISE_BROWSER_INVALID_JSON")]
		public const int ResultCodeErrEnterpriseBrowserInvalidJson = (int) -801;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_ENTERPRISE_BROWSER_INVALID_URL']"
		[Register ("RESULT_CODE_ERR_ENTERPRISE_BROWSER_INVALID_URL")]
		public const int ResultCodeErrEnterpriseBrowserInvalidUrl = (int) -803;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_ENTERPRISE_BROWSER_NATIVE_APP_NOT_EXIST']"
		[Register ("RESULT_CODE_ERR_ENTERPRISE_BROWSER_NATIVE_APP_NOT_EXIST")]
		public const int ResultCodeErrEnterpriseBrowserNativeAppNotExist = (int) -802;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_IO']"
		[Register ("RESULT_CODE_ERR_IO")]
		public const int ResultCodeErrIo = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_JWT_AUD_INVALID']"
		[Register ("RESULT_CODE_ERR_JWT_AUD_INVALID")]
		public const int ResultCodeErrJwtAudInvalid = (int) -702;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_JWT_AZP_INVALID']"
		[Register ("RESULT_CODE_ERR_JWT_AZP_INVALID")]
		public const int ResultCodeErrJwtAzpInvalid = (int) -703;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_JWT_EXPIRED']"
		[Register ("RESULT_CODE_ERR_JWT_EXPIRED")]
		public const int ResultCodeErrJwtExpired = (int) -704;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_JWT_INVALID']"
		[Register ("RESULT_CODE_ERR_JWT_INVALID")]
		public const int ResultCodeErrJwtInvalid = (int) -705;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_JWT_SIGNATURE_INVALID']"
		[Register ("RESULT_CODE_ERR_JWT_SIGNATURE_INVALID")]
		public const int ResultCodeErrJwtSignatureInvalid = (int) -701;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_LOCATION_REQUIRED']"
		[Register ("RESULT_CODE_ERR_LOCATION_REQUIRED")]
		public const int ResultCodeErrLocationRequired = (int) -301;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_LOCATION_UNAUTHORIZED']"
		[Register ("RESULT_CODE_ERR_LOCATION_UNAUTHORIZED")]
		public const int ResultCodeErrLocationUnauthorized = (int) -302;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_MSISDN_REQUIRED']"
		[Register ("RESULT_CODE_ERR_MSISDN_REQUIRED")]
		public const int ResultCodeErrMsisdnRequired = (int) -601;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_MSISDN_UNAUTHORIZED']"
		[Register ("RESULT_CODE_ERR_MSISDN_UNAUTHORIZED")]
		public const int ResultCodeErrMsisdnUnauthorized = (int) -602;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_OAUTH']"
		[Register ("RESULT_CODE_ERR_OAUTH")]
		public const int ResultCodeErrOauth = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_REGISTRATION']"
		[Register ("RESULT_CODE_ERR_REGISTRATION")]
		public const int ResultCodeErrRegistration = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_ERR_UNKNOWN']"
		[Register ("RESULT_CODE_ERR_UNKNOWN")]
		public const int ResultCodeErrUnknown = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_CODE_SUCCESS']"
		[Register ("RESULT_CODE_SUCCESS")]
		public const int ResultCodeSuccess = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_ERROR']"
		[Register ("RESULT_ERROR")]
		public const string ResultError = (string) "com.ca.mas.core.service.result.error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_ERROR_MESSAGE']"
		[Register ("RESULT_ERROR_MESSAGE")]
		public const string ResultErrorMessage = (string) "com.ca.mas.core.service.result.errorMessage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/interface[@name='MssoIntents']/field[@name='RESULT_REQUEST_ID']"
		[Register ("RESULT_REQUEST_ID")]
		public const string ResultRequestId = (string) "com.ca.mas.core.service.result.requestId";
	}

	[Register ("com/ca/mas/core/service/MssoIntents", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MssoIntents' type. This type will be removed in a future release.")]
	public abstract class MssoIntentsConsts : MssoIntents {

		private MssoIntentsConsts ()
		{
		}
	}

}
