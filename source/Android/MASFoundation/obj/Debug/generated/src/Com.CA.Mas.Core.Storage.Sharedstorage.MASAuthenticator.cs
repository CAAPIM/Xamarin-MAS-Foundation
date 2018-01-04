using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Storage.Sharedstorage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASAuthenticator']"
	[global::Android.Runtime.Register ("com/ca/mas/core/storage/sharedstorage/MASAuthenticator", DoNotGenerateAcw=true)]
	public partial class MASAuthenticator : global::Android.Accounts.AbstractAccountAuthenticator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/storage/sharedstorage/MASAuthenticator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASAuthenticator); }
		}

		protected MASAuthenticator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetAddAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_addAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_ == null)
				cb_addAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_);
			return cb_addAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_AddAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response, IntPtr native_accountType, IntPtr native_authTokenType, IntPtr native_requiredFeatures, IntPtr native_options)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Accounts.AccountAuthenticatorResponse response = global::Java.Lang.Object.GetObject<global::Android.Accounts.AccountAuthenticatorResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			string accountType = JNIEnv.GetString (native_accountType, JniHandleOwnership.DoNotTransfer);
			string authTokenType = JNIEnv.GetString (native_authTokenType, JniHandleOwnership.DoNotTransfer);
			string[] requiredFeatures = (string[]) JNIEnv.GetArray (native_requiredFeatures, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAccount (response, accountType, authTokenType, requiredFeatures, options));
			if (requiredFeatures != null)
				JNIEnv.CopyArray (requiredFeatures, native_requiredFeatures);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASAuthenticator']/method[@name='addAccount' and count(parameter)=5 and parameter[1][@type='android.accounts.AccountAuthenticatorResponse'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("addAccount", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetAddAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle AddAccount (global::Android.Accounts.AccountAuthenticatorResponse response, string accountType, string authTokenType, string[] requiredFeatures, global::Android.OS.Bundle options)
		{
			if (id_addAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_addAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "addAccount", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_accountType = JNIEnv.NewString (accountType);
			IntPtr native_authTokenType = JNIEnv.NewString (authTokenType);
			IntPtr native_requiredFeatures = JNIEnv.NewArray (requiredFeatures);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (response);
				__args [1] = new JValue (native_accountType);
				__args [2] = new JValue (native_authTokenType);
				__args [3] = new JValue (native_requiredFeatures);
				__args [4] = new JValue (options);

				global::Android.OS.Bundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addAccount_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAccount", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_accountType);
				JNIEnv.DeleteLocalRef (native_authTokenType);
				if (requiredFeatures != null) {
					JNIEnv.CopyArray (native_requiredFeatures, requiredFeatures);
					JNIEnv.DeleteLocalRef (native_requiredFeatures);
				}
			}
		}

		static Delegate cb_confirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetConfirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_Handler ()
		{
			if (cb_confirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_ == null)
				cb_confirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConfirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_);
			return cb_confirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_;
		}

		static IntPtr n_ConfirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response, IntPtr native_account, IntPtr native_options)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Accounts.AccountAuthenticatorResponse response = global::Java.Lang.Object.GetObject<global::Android.Accounts.AccountAuthenticatorResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			global::Android.Accounts.Account account = global::Java.Lang.Object.GetObject<global::Android.Accounts.Account> (native_account, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConfirmCredentials (response, account, options));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_confirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASAuthenticator']/method[@name='confirmCredentials' and count(parameter)=3 and parameter[1][@type='android.accounts.AccountAuthenticatorResponse'] and parameter[2][@type='android.accounts.Account'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("confirmCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetConfirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle ConfirmCredentials (global::Android.Accounts.AccountAuthenticatorResponse response, global::Android.Accounts.Account account, global::Android.OS.Bundle options)
		{
			if (id_confirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_ == IntPtr.Zero)
				id_confirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "confirmCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Landroid/os/Bundle;)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (response);
				__args [1] = new JValue (account);
				__args [2] = new JValue (options);

				global::Android.OS.Bundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_confirmCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "confirmCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Landroid/os/Bundle;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_editProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEditProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Handler ()
		{
			if (cb_editProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_ == null)
				cb_editProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_EditProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_);
			return cb_editProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_;
		}

		static IntPtr n_EditProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response, IntPtr native_accountType)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Accounts.AccountAuthenticatorResponse response = global::Java.Lang.Object.GetObject<global::Android.Accounts.AccountAuthenticatorResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			string accountType = JNIEnv.GetString (native_accountType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EditProperties (response, accountType));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_editProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASAuthenticator']/method[@name='editProperties' and count(parameter)=2 and parameter[1][@type='android.accounts.AccountAuthenticatorResponse'] and parameter[2][@type='java.lang.String']]"
		[Register ("editProperties", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;)Landroid/os/Bundle;", "GetEditProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_Handler")]
		public override unsafe global::Android.OS.Bundle EditProperties (global::Android.Accounts.AccountAuthenticatorResponse response, string accountType)
		{
			if (id_editProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_editProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "editProperties", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_accountType = JNIEnv.NewString (accountType);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (response);
				__args [1] = new JValue (native_accountType);

				global::Android.OS.Bundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_editProperties_Landroid_accounts_AccountAuthenticatorResponse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "editProperties", "(Landroid/accounts/AccountAuthenticatorResponse;Ljava/lang/String;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_accountType);
			}
		}

		static Delegate cb_getAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_getAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_getAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_getAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_GetAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response, IntPtr native_account, IntPtr native_authTokenType, IntPtr native_options)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Accounts.AccountAuthenticatorResponse response = global::Java.Lang.Object.GetObject<global::Android.Accounts.AccountAuthenticatorResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			global::Android.Accounts.Account account = global::Java.Lang.Object.GetObject<global::Android.Accounts.Account> (native_account, JniHandleOwnership.DoNotTransfer);
			string authTokenType = JNIEnv.GetString (native_authTokenType, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAuthToken (response, account, authTokenType, options));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASAuthenticator']/method[@name='getAuthToken' and count(parameter)=4 and parameter[1][@type='android.accounts.AccountAuthenticatorResponse'] and parameter[2][@type='android.accounts.Account'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("getAuthToken", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetGetAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle GetAuthToken (global::Android.Accounts.AccountAuthenticatorResponse response, global::Android.Accounts.Account account, string authTokenType, global::Android.OS.Bundle options)
		{
			if (id_getAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getAuthToken", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_authTokenType = JNIEnv.NewString (authTokenType);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (response);
				__args [1] = new JValue (account);
				__args [2] = new JValue (native_authTokenType);
				__args [3] = new JValue (options);

				global::Android.OS.Bundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthToken_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthToken", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_authTokenType);
			}
		}

		static Delegate cb_getAuthTokenLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAuthTokenLabel_Ljava_lang_String_Handler ()
		{
			if (cb_getAuthTokenLabel_Ljava_lang_String_ == null)
				cb_getAuthTokenLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAuthTokenLabel_Ljava_lang_String_);
			return cb_getAuthTokenLabel_Ljava_lang_String_;
		}

		static IntPtr n_GetAuthTokenLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authTokenType)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string authTokenType = JNIEnv.GetString (native_authTokenType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAuthTokenLabel (authTokenType));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthTokenLabel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASAuthenticator']/method[@name='getAuthTokenLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAuthTokenLabel_Ljava_lang_String_Handler")]
		public override unsafe string GetAuthTokenLabel (string authTokenType)
		{
			if (id_getAuthTokenLabel_Ljava_lang_String_ == IntPtr.Zero)
				id_getAuthTokenLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_authTokenType = JNIEnv.NewString (authTokenType);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_authTokenType);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthTokenLabel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthTokenLabel", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_authTokenType);
			}
		}

		static Delegate cb_hasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_Handler ()
		{
			if (cb_hasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_ == null)
				cb_hasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_);
			return cb_hasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_;
		}

		static IntPtr n_HasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response, IntPtr native_account, IntPtr native_features)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Accounts.AccountAuthenticatorResponse response = global::Java.Lang.Object.GetObject<global::Android.Accounts.AccountAuthenticatorResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			global::Android.Accounts.Account account = global::Java.Lang.Object.GetObject<global::Android.Accounts.Account> (native_account, JniHandleOwnership.DoNotTransfer);
			string[] features = (string[]) JNIEnv.GetArray (native_features, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HasFeatures (response, account, features));
			if (features != null)
				JNIEnv.CopyArray (features, native_features);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASAuthenticator']/method[@name='hasFeatures' and count(parameter)=3 and parameter[1][@type='android.accounts.AccountAuthenticatorResponse'] and parameter[2][@type='android.accounts.Account'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("hasFeatures", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;[Ljava/lang/String;)Landroid/os/Bundle;", "GetHasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_Handler")]
		public override unsafe global::Android.OS.Bundle HasFeatures (global::Android.Accounts.AccountAuthenticatorResponse response, global::Android.Accounts.Account account, string[] features)
		{
			if (id_hasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_ == IntPtr.Zero)
				id_hasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasFeatures", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;[Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_features = JNIEnv.NewArray (features);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (response);
				__args [1] = new JValue (account);
				__args [2] = new JValue (native_features);

				global::Android.OS.Bundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hasFeatures_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasFeatures", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;[Ljava/lang/String;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (features != null) {
					JNIEnv.CopyArray (native_features, features);
					JNIEnv.DeleteLocalRef (native_features);
				}
			}
		}

		static Delegate cb_updateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetUpdateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_updateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_updateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_updateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static IntPtr n_UpdateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_response, IntPtr native_account, IntPtr native_authTokenType, IntPtr native_options)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASAuthenticator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Accounts.AccountAuthenticatorResponse response = global::Java.Lang.Object.GetObject<global::Android.Accounts.AccountAuthenticatorResponse> (native_response, JniHandleOwnership.DoNotTransfer);
			global::Android.Accounts.Account account = global::Java.Lang.Object.GetObject<global::Android.Accounts.Account> (native_account, JniHandleOwnership.DoNotTransfer);
			string authTokenType = JNIEnv.GetString (native_authTokenType, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateCredentials (response, account, authTokenType, options));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASAuthenticator']/method[@name='updateCredentials' and count(parameter)=4 and parameter[1][@type='android.accounts.AccountAuthenticatorResponse'] and parameter[2][@type='android.accounts.Account'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("updateCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;", "GetUpdateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe global::Android.OS.Bundle UpdateCredentials (global::Android.Accounts.AccountAuthenticatorResponse response, global::Android.Accounts.Account account, string authTokenType, global::Android.OS.Bundle options)
		{
			if (id_updateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_updateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "updateCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;");
			IntPtr native_authTokenType = JNIEnv.NewString (authTokenType);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (response);
				__args [1] = new JValue (account);
				__args [2] = new JValue (native_authTokenType);
				__args [3] = new JValue (options);

				global::Android.OS.Bundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateCredentials_Landroid_accounts_AccountAuthenticatorResponse_Landroid_accounts_Account_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCredentials", "(Landroid/accounts/AccountAuthenticatorResponse;Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_authTokenType);
			}
		}

	}
}
