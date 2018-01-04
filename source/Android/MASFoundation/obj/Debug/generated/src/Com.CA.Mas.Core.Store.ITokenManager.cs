using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Store {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']"
	[Register ("com/ca/mas/core/store/TokenManager", "", "Com.CA.Mas.Core.Store.ITokenManagerInvoker")]
	public partial interface ITokenManager : global::Com.CA.Mas.Core.Store.ITokenProvider {

		bool IsTokenStoreReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='isTokenStoreReady' and count(parameter)=0]"
			[Register ("isTokenStoreReady", "()Z", "GetIsTokenStoreReadyHandler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")] get;
		}

		global::Com.CA.Mas.Core.Datasource.IDataSource TokenStore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='getTokenStore' and count(parameter)=0]"
			[Register ("getTokenStore", "()Lcom/ca/mas/core/datasource/DataSource;", "GetGetTokenStoreHandler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")]
		void ClearAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='deleteIdToken' and count(parameter)=0]"
		[Register ("deleteIdToken", "()V", "GetDeleteIdTokenHandler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")]
		void DeleteIdToken ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='deleteSecureIdToken' and count(parameter)=0]"
		[Register ("deleteSecureIdToken", "()V", "GetDeleteSecureIdTokenHandler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")]
		void DeleteSecureIdToken ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='deleteUserProfile' and count(parameter)=0]"
		[Register ("deleteUserProfile", "()V", "GetDeleteUserProfileHandler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")]
		void DeleteUserProfile ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='saveClientCertificateChain' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate[]']]"
		[Register ("saveClientCertificateChain", "([Ljava/security/cert/X509Certificate;)V", "GetSaveClientCertificateChain_arrayLjava_security_cert_X509Certificate_Handler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")]
		void SaveClientCertificateChain (global::Java.Security.Cert.X509Certificate[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='saveIdToken' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.token.IdToken']]"
		[Register ("saveIdToken", "(Lcom/ca/mas/core/token/IdToken;)V", "GetSaveIdToken_Lcom_ca_mas_core_token_IdToken_Handler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")]
		void SaveIdToken (global::Com.CA.Mas.Core.Token.IdToken p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='saveMagIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveMagIdentifier", "(Ljava/lang/String;)V", "GetSaveMagIdentifier_Ljava_lang_String_Handler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")]
		void SaveMagIdentifier (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='saveSecureIdToken' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("saveSecureIdToken", "([B)V", "GetSaveSecureIdToken_arrayBHandler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")]
		void SaveSecureIdToken (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenManager']/method[@name='saveUserProfile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveUserProfile", "(Ljava/lang/String;)V", "GetSaveUserProfile_Ljava_lang_String_Handler:Com.CA.Mas.Core.Store.ITokenManagerInvoker, MASFoundation")]
		void SaveUserProfile (string p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/store/TokenManager", DoNotGenerateAcw=true)]
	internal class ITokenManagerInvoker : global::Java.Lang.Object, ITokenManager {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/store/TokenManager");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITokenManagerInvoker); }
		}

		IntPtr class_ref;

		public static ITokenManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITokenManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.store.TokenManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITokenManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isTokenStoreReady;
#pragma warning disable 0169
		static Delegate GetIsTokenStoreReadyHandler ()
		{
			if (cb_isTokenStoreReady == null)
				cb_isTokenStoreReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTokenStoreReady);
			return cb_isTokenStoreReady;
		}

		static bool n_IsTokenStoreReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTokenStoreReady;
		}
#pragma warning restore 0169

		IntPtr id_isTokenStoreReady;
		public unsafe bool IsTokenStoreReady {
			get {
				if (id_isTokenStoreReady == IntPtr.Zero)
					id_isTokenStoreReady = JNIEnv.GetMethodID (class_ref, "isTokenStoreReady", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTokenStoreReady);
			}
		}

		static Delegate cb_getTokenStore;
#pragma warning disable 0169
		static Delegate GetGetTokenStoreHandler ()
		{
			if (cb_getTokenStore == null)
				cb_getTokenStore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenStore);
			return cb_getTokenStore;
		}

		static IntPtr n_GetTokenStore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TokenStore);
		}
#pragma warning restore 0169

		IntPtr id_getTokenStore;
		public unsafe global::Com.CA.Mas.Core.Datasource.IDataSource TokenStore {
			get {
				if (id_getTokenStore == IntPtr.Zero)
					id_getTokenStore = JNIEnv.GetMethodID (class_ref, "getTokenStore", "()Lcom/ca/mas/core/datasource/DataSource;");
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenStore), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_clearAll;
#pragma warning disable 0169
		static Delegate GetClearAllHandler ()
		{
			if (cb_clearAll == null)
				cb_clearAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAll);
			return cb_clearAll;
		}

		static void n_ClearAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAll ();
		}
#pragma warning restore 0169

		IntPtr id_clearAll;
		public unsafe void ClearAll ()
		{
			if (id_clearAll == IntPtr.Zero)
				id_clearAll = JNIEnv.GetMethodID (class_ref, "clearAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAll);
		}

		static Delegate cb_deleteIdToken;
#pragma warning disable 0169
		static Delegate GetDeleteIdTokenHandler ()
		{
			if (cb_deleteIdToken == null)
				cb_deleteIdToken = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteIdToken);
			return cb_deleteIdToken;
		}

		static void n_DeleteIdToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteIdToken ();
		}
#pragma warning restore 0169

		IntPtr id_deleteIdToken;
		public unsafe void DeleteIdToken ()
		{
			if (id_deleteIdToken == IntPtr.Zero)
				id_deleteIdToken = JNIEnv.GetMethodID (class_ref, "deleteIdToken", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteIdToken);
		}

		static Delegate cb_deleteSecureIdToken;
#pragma warning disable 0169
		static Delegate GetDeleteSecureIdTokenHandler ()
		{
			if (cb_deleteSecureIdToken == null)
				cb_deleteSecureIdToken = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteSecureIdToken);
			return cb_deleteSecureIdToken;
		}

		static void n_DeleteSecureIdToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteSecureIdToken ();
		}
#pragma warning restore 0169

		IntPtr id_deleteSecureIdToken;
		public unsafe void DeleteSecureIdToken ()
		{
			if (id_deleteSecureIdToken == IntPtr.Zero)
				id_deleteSecureIdToken = JNIEnv.GetMethodID (class_ref, "deleteSecureIdToken", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteSecureIdToken);
		}

		static Delegate cb_deleteUserProfile;
#pragma warning disable 0169
		static Delegate GetDeleteUserProfileHandler ()
		{
			if (cb_deleteUserProfile == null)
				cb_deleteUserProfile = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteUserProfile);
			return cb_deleteUserProfile;
		}

		static void n_DeleteUserProfile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteUserProfile ();
		}
#pragma warning restore 0169

		IntPtr id_deleteUserProfile;
		public unsafe void DeleteUserProfile ()
		{
			if (id_deleteUserProfile == IntPtr.Zero)
				id_deleteUserProfile = JNIEnv.GetMethodID (class_ref, "deleteUserProfile", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteUserProfile);
		}

		static Delegate cb_saveClientCertificateChain_arrayLjava_security_cert_X509Certificate_;
#pragma warning disable 0169
		static Delegate GetSaveClientCertificateChain_arrayLjava_security_cert_X509Certificate_Handler ()
		{
			if (cb_saveClientCertificateChain_arrayLjava_security_cert_X509Certificate_ == null)
				cb_saveClientCertificateChain_arrayLjava_security_cert_X509Certificate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveClientCertificateChain_arrayLjava_security_cert_X509Certificate_);
			return cb_saveClientCertificateChain_arrayLjava_security_cert_X509Certificate_;
		}

		static void n_SaveClientCertificateChain_arrayLjava_security_cert_X509Certificate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.X509Certificate[] p0 = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.Cert.X509Certificate));
			__this.SaveClientCertificateChain (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_saveClientCertificateChain_arrayLjava_security_cert_X509Certificate_;
		public unsafe void SaveClientCertificateChain (global::Java.Security.Cert.X509Certificate[] p0)
		{
			if (id_saveClientCertificateChain_arrayLjava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_saveClientCertificateChain_arrayLjava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "saveClientCertificateChain", "([Ljava/security/cert/X509Certificate;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveClientCertificateChain_arrayLjava_security_cert_X509Certificate_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_saveIdToken_Lcom_ca_mas_core_token_IdToken_;
#pragma warning disable 0169
		static Delegate GetSaveIdToken_Lcom_ca_mas_core_token_IdToken_Handler ()
		{
			if (cb_saveIdToken_Lcom_ca_mas_core_token_IdToken_ == null)
				cb_saveIdToken_Lcom_ca_mas_core_token_IdToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveIdToken_Lcom_ca_mas_core_token_IdToken_);
			return cb_saveIdToken_Lcom_ca_mas_core_token_IdToken_;
		}

		static void n_SaveIdToken_Lcom_ca_mas_core_token_IdToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Token.IdToken p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.IdToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveIdToken (p0);
		}
#pragma warning restore 0169

		IntPtr id_saveIdToken_Lcom_ca_mas_core_token_IdToken_;
		public unsafe void SaveIdToken (global::Com.CA.Mas.Core.Token.IdToken p0)
		{
			if (id_saveIdToken_Lcom_ca_mas_core_token_IdToken_ == IntPtr.Zero)
				id_saveIdToken_Lcom_ca_mas_core_token_IdToken_ = JNIEnv.GetMethodID (class_ref, "saveIdToken", "(Lcom/ca/mas/core/token/IdToken;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveIdToken_Lcom_ca_mas_core_token_IdToken_, __args);
		}

		static Delegate cb_saveMagIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveMagIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_saveMagIdentifier_Ljava_lang_String_ == null)
				cb_saveMagIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveMagIdentifier_Ljava_lang_String_);
			return cb_saveMagIdentifier_Ljava_lang_String_;
		}

		static void n_SaveMagIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveMagIdentifier (p0);
		}
#pragma warning restore 0169

		IntPtr id_saveMagIdentifier_Ljava_lang_String_;
		public unsafe void SaveMagIdentifier (string p0)
		{
			if (id_saveMagIdentifier_Ljava_lang_String_ == IntPtr.Zero)
				id_saveMagIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveMagIdentifier", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveMagIdentifier_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_saveSecureIdToken_arrayB;
#pragma warning disable 0169
		static Delegate GetSaveSecureIdToken_arrayBHandler ()
		{
			if (cb_saveSecureIdToken_arrayB == null)
				cb_saveSecureIdToken_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveSecureIdToken_arrayB);
			return cb_saveSecureIdToken_arrayB;
		}

		static void n_SaveSecureIdToken_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SaveSecureIdToken (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_saveSecureIdToken_arrayB;
		public unsafe void SaveSecureIdToken (byte[] p0)
		{
			if (id_saveSecureIdToken_arrayB == IntPtr.Zero)
				id_saveSecureIdToken_arrayB = JNIEnv.GetMethodID (class_ref, "saveSecureIdToken", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveSecureIdToken_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_saveUserProfile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveUserProfile_Ljava_lang_String_Handler ()
		{
			if (cb_saveUserProfile_Ljava_lang_String_ == null)
				cb_saveUserProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveUserProfile_Ljava_lang_String_);
			return cb_saveUserProfile_Ljava_lang_String_;
		}

		static void n_SaveUserProfile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveUserProfile (p0);
		}
#pragma warning restore 0169

		IntPtr id_saveUserProfile_Ljava_lang_String_;
		public unsafe void SaveUserProfile (string p0)
		{
			if (id_saveUserProfile_Ljava_lang_String_ == IntPtr.Zero)
				id_saveUserProfile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveUserProfile", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveUserProfile_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getClientPrivateKey;
#pragma warning disable 0169
		static Delegate GetGetClientPrivateKeyHandler ()
		{
			if (cb_getClientPrivateKey == null)
				cb_getClientPrivateKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientPrivateKey);
			return cb_getClientPrivateKey;
		}

		static IntPtr n_GetClientPrivateKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientPrivateKey);
		}
#pragma warning restore 0169

		IntPtr id_getClientPrivateKey;
		public unsafe global::Java.Security.IPrivateKey ClientPrivateKey {
			get {
				if (id_getClientPrivateKey == IntPtr.Zero)
					id_getClientPrivateKey = JNIEnv.GetMethodID (class_ref, "getClientPrivateKey", "()Ljava/security/PrivateKey;");
				return global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientPrivateKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getClientPublicKey;
#pragma warning disable 0169
		static Delegate GetGetClientPublicKeyHandler ()
		{
			if (cb_getClientPublicKey == null)
				cb_getClientPublicKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientPublicKey);
			return cb_getClientPublicKey;
		}

		static IntPtr n_GetClientPublicKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientPublicKey);
		}
#pragma warning restore 0169

		IntPtr id_getClientPublicKey;
		public unsafe global::Java.Security.IPublicKey ClientPublicKey {
			get {
				if (id_getClientPublicKey == IntPtr.Zero)
					id_getClientPublicKey = JNIEnv.GetMethodID (class_ref, "getClientPublicKey", "()Ljava/security/PublicKey;");
				return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientPublicKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIdToken;
#pragma warning disable 0169
		static Delegate GetGetIdTokenHandler ()
		{
			if (cb_getIdToken == null)
				cb_getIdToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdToken);
			return cb_getIdToken;
		}

		static IntPtr n_GetIdToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IdToken);
		}
#pragma warning restore 0169

		IntPtr id_getIdToken;
		public unsafe global::Com.CA.Mas.Core.Token.IdToken IdToken {
			get {
				if (id_getIdToken == IntPtr.Zero)
					id_getIdToken = JNIEnv.GetMethodID (class_ref, "getIdToken", "()Lcom/ca/mas/core/token/IdToken;");
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.IdToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isClientCertificateChainAvailable;
#pragma warning disable 0169
		static Delegate GetIsClientCertificateChainAvailableHandler ()
		{
			if (cb_isClientCertificateChainAvailable == null)
				cb_isClientCertificateChainAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClientCertificateChainAvailable);
			return cb_isClientCertificateChainAvailable;
		}

		static bool n_IsClientCertificateChainAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClientCertificateChainAvailable;
		}
#pragma warning restore 0169

		IntPtr id_isClientCertificateChainAvailable;
		public unsafe bool IsClientCertificateChainAvailable {
			get {
				if (id_isClientCertificateChainAvailable == IntPtr.Zero)
					id_isClientCertificateChainAvailable = JNIEnv.GetMethodID (class_ref, "isClientCertificateChainAvailable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClientCertificateChainAvailable);
			}
		}

		static Delegate cb_getMagIdentifier;
#pragma warning disable 0169
		static Delegate GetGetMagIdentifierHandler ()
		{
			if (cb_getMagIdentifier == null)
				cb_getMagIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagIdentifier);
			return cb_getMagIdentifier;
		}

		static IntPtr n_GetMagIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MagIdentifier);
		}
#pragma warning restore 0169

		IntPtr id_getMagIdentifier;
		public unsafe string MagIdentifier {
			get {
				if (id_getMagIdentifier == IntPtr.Zero)
					id_getMagIdentifier = JNIEnv.GetMethodID (class_ref, "getMagIdentifier", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMagIdentifier), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserProfile;
#pragma warning disable 0169
		static Delegate GetGetUserProfileHandler ()
		{
			if (cb_getUserProfile == null)
				cb_getUserProfile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserProfile);
			return cb_getUserProfile;
		}

		static IntPtr n_GetUserProfile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserProfile);
		}
#pragma warning restore 0169

		IntPtr id_getUserProfile;
		public unsafe string UserProfile {
			get {
				if (id_getUserProfile == IntPtr.Zero)
					id_getUserProfile = JNIEnv.GetMethodID (class_ref, "getUserProfile", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserProfile), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_createPrivateKey_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetCreatePrivateKey_Landroid_content_Context_IHandler ()
		{
			if (cb_createPrivateKey_Landroid_content_Context_I == null)
				cb_createPrivateKey_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CreatePrivateKey_Landroid_content_Context_I);
			return cb_createPrivateKey_Landroid_content_Context_I;
		}

		static IntPtr n_CreatePrivateKey_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePrivateKey (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createPrivateKey_Landroid_content_Context_I;
		public unsafe global::Java.Security.IPrivateKey CreatePrivateKey (global::Android.Content.Context p0, int p1)
		{
			if (id_createPrivateKey_Landroid_content_Context_I == IntPtr.Zero)
				id_createPrivateKey_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "createPrivateKey", "(Landroid/content/Context;I)Ljava/security/PrivateKey;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Java.Security.IPrivateKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createPrivateKey_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getClientCertificateChain;
#pragma warning disable 0169
		static Delegate GetGetClientCertificateChainHandler ()
		{
			if (cb_getClientCertificateChain == null)
				cb_getClientCertificateChain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientCertificateChain);
			return cb_getClientCertificateChain;
		}

		static IntPtr n_GetClientCertificateChain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetClientCertificateChain ());
		}
#pragma warning restore 0169

		IntPtr id_getClientCertificateChain;
		public unsafe global::Java.Security.Cert.X509Certificate[] GetClientCertificateChain ()
		{
			if (id_getClientCertificateChain == IntPtr.Zero)
				id_getClientCertificateChain = JNIEnv.GetMethodID (class_ref, "getClientCertificateChain", "()[Ljava/security/cert/X509Certificate;");
			return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientCertificateChain), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
		}

		static Delegate cb_getSecureIdToken;
#pragma warning disable 0169
		static Delegate GetGetSecureIdTokenHandler ()
		{
			if (cb_getSecureIdToken == null)
				cb_getSecureIdToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecureIdToken);
			return cb_getSecureIdToken;
		}

		static IntPtr n_GetSecureIdToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSecureIdToken ());
		}
#pragma warning restore 0169

		IntPtr id_getSecureIdToken;
		public unsafe byte[] GetSecureIdToken ()
		{
			if (id_getSecureIdToken == IntPtr.Zero)
				id_getSecureIdToken = JNIEnv.GetMethodID (class_ref, "getSecureIdToken", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecureIdToken), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}

}
