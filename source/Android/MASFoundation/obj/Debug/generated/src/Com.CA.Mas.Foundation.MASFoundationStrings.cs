using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASFoundationStrings", DoNotGenerateAcw=true)]
	public partial class MASFoundationStrings : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='API_TARGET_EXCEPTION']"
		[Register ("API_TARGET_EXCEPTION")]
		public const string ApiTargetException = (string) "Device API level does not meet the target API requirements.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='SDK_UNINITIALIZED']"
		[Register ("SDK_UNINITIALIZED")]
		public const string SdkUninitialized = (string) "MAS SDK has not been initialized.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='SECURE_LOCK_FAILED_TO_DELETE_ID_TOKEN']"
		[Register ("SECURE_LOCK_FAILED_TO_DELETE_ID_TOKEN")]
		public const string SecureLockFailedToDeleteIdToken = (string) "Failed to delete encrypted ID token.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='SECURE_LOCK_FAILED_TO_DELETE_SECURE_ID_TOKEN']"
		[Register ("SECURE_LOCK_FAILED_TO_DELETE_SECURE_ID_TOKEN")]
		public const string SecureLockFailedToDeleteSecureIdToken = (string) "Failed to delete encrypted ID token.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='SECURE_LOCK_FAILED_TO_RETRIEVE_ID_TOKEN']"
		[Register ("SECURE_LOCK_FAILED_TO_RETRIEVE_ID_TOKEN")]
		public const string SecureLockFailedToRetrieveIdToken = (string) "Failed to retrieve ID token.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='SECURE_LOCK_FAILED_TO_SAVE_ID_TOKEN']"
		[Register ("SECURE_LOCK_FAILED_TO_SAVE_ID_TOKEN")]
		public const string SecureLockFailedToSaveIdToken = (string) "Failed to save ID token.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='SECURE_LOCK_FAILED_TO_SAVE_SECURE_ID_TOKEN']"
		[Register ("SECURE_LOCK_FAILED_TO_SAVE_SECURE_ID_TOKEN")]
		public const string SecureLockFailedToSaveSecureIdToken = (string) "Failed to save encrypted ID token.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='SECURE_LOCK_SESSION_CURRENTLY_LOCKED']"
		[Register ("SECURE_LOCK_SESSION_CURRENTLY_LOCKED")]
		public const string SecureLockSessionCurrentlyLocked = (string) "The session is currently locked.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='SHARED_STORAGE_NULL_ACCOUNT_NAME']"
		[Register ("SHARED_STORAGE_NULL_ACCOUNT_NAME")]
		public const string SharedStorageNullAccountName = (string) "Account name cannot be null.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='SHARED_STORAGE_NULL_ACCOUNT_TYPE']"
		[Register ("SHARED_STORAGE_NULL_ACCOUNT_TYPE")]
		public const string SharedStorageNullAccountType = (string) "Account type cannot be null.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='TOKEN_ID_EXPIRED']"
		[Register ("TOKEN_ID_EXPIRED")]
		public const string TokenIdExpired = (string) "ID token is expired.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASFoundationStrings']/field[@name='USER_NOT_CURRENTLY_AUTHENTICATED']"
		[Register ("USER_NOT_CURRENTLY_AUTHENTICATED")]
		public const string UserNotCurrentlyAuthenticated = (string) "No currently authenticated user.";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASFoundationStrings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASFoundationStrings); }
		}

		protected MASFoundationStrings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
