using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']"
	[global::Android.Runtime.Register ("com/ca/mas/core/util/KeyUtilsSymmetric", DoNotGenerateAcw=true)]
	public partial class KeyUtilsSymmetric : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/field[@name='ANDROID_KEY_STORE']"
		[Register ("ANDROID_KEY_STORE")]
		protected const string AndroidKeyStore = (string) "AndroidKeyStore";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/field[@name='DEFAULT_ALGORITHM']"
		[Register ("DEFAULT_ALGORITHM")]
		protected const string DefaultAlgorithm = (string) "AES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/field[@name='DEFAULT_KEY_LENGTH']"
		[Register ("DEFAULT_KEY_LENGTH")]
		protected const int DefaultKeyLength = (int) 256;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/util/KeyUtilsSymmetric", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyUtilsSymmetric); }
		}

		protected KeyUtilsSymmetric (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/constructor[@name='KeyUtilsSymmetric' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe KeyUtilsSymmetric ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (KeyUtilsSymmetric)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_checkDeleteKeys_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='checkDeleteKeys' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("checkDeleteKeys", "(Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		protected static unsafe void CheckDeleteKeys (string alias, global::Java.Lang.Exception e)
		{
			if (id_checkDeleteKeys_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_checkDeleteKeys_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "checkDeleteKeys", "(Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_alias);
				__args [1] = new JValue (e);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkDeleteKeys_Ljava_lang_String_Ljava_lang_Exception_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_computeMac_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='computeMac' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("computeMac", "(Ljava/lang/String;[B)[B", "")]
		protected static unsafe byte[] ComputeMac (string key, byte[] cipherText)
		{
			if (id_computeMac_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_computeMac_Ljava_lang_String_arrayB = JNIEnv.GetStaticMethodID (class_ref, "computeMac", "(Ljava/lang/String;[B)[B");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_cipherText = JNIEnv.NewArray (cipherText);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_cipherText);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_computeMac_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (cipherText != null) {
					JNIEnv.CopyArray (native_cipherText, cipherText);
					JNIEnv.DeleteLocalRef (native_cipherText);
				}
			}
		}

		static IntPtr id_concatArrays_arrayBarrayBarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='concatArrays' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("concatArrays", "([B[B[B)[B", "")]
		protected static unsafe byte[] ConcatArrays (byte[] mac, byte[] iv, byte[] cipherText)
		{
			if (id_concatArrays_arrayBarrayBarrayB == IntPtr.Zero)
				id_concatArrays_arrayBarrayBarrayB = JNIEnv.GetStaticMethodID (class_ref, "concatArrays", "([B[B[B)[B");
			IntPtr native_mac = JNIEnv.NewArray (mac);
			IntPtr native_iv = JNIEnv.NewArray (iv);
			IntPtr native_cipherText = JNIEnv.NewArray (cipherText);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_mac);
				__args [1] = new JValue (native_iv);
				__args [2] = new JValue (native_cipherText);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatArrays_arrayBarrayBarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (mac != null) {
					JNIEnv.CopyArray (native_mac, mac);
					JNIEnv.DeleteLocalRef (native_mac);
				}
				if (iv != null) {
					JNIEnv.CopyArray (native_iv, iv);
					JNIEnv.DeleteLocalRef (native_iv);
				}
				if (cipherText != null) {
					JNIEnv.CopyArray (native_cipherText, cipherText);
					JNIEnv.DeleteLocalRef (native_cipherText);
				}
			}
		}

		static IntPtr id_decrypt_arrayBLjavax_crypto_SecretKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='decrypt' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='javax.crypto.SecretKey'] and parameter[3][@type='java.lang.String']]"
		[Register ("decrypt", "([BLjavax/crypto/SecretKey;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Decrypt (byte[] encryptedData, global::Javax.Crypto.ISecretKey secretKey, string key)
		{
			if (id_decrypt_arrayBLjavax_crypto_SecretKey_Ljava_lang_String_ == IntPtr.Zero)
				id_decrypt_arrayBLjavax_crypto_SecretKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decrypt", "([BLjavax/crypto/SecretKey;Ljava/lang/String;)[B");
			IntPtr native_encryptedData = JNIEnv.NewArray (encryptedData);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_encryptedData);
				__args [1] = new JValue (secretKey);
				__args [2] = new JValue (native_key);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decrypt_arrayBLjavax_crypto_SecretKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (encryptedData != null) {
					JNIEnv.CopyArray (native_encryptedData, encryptedData);
					JNIEnv.DeleteLocalRef (native_encryptedData);
				}
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_deleteKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='deleteKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteKey", "(Ljava/lang/String;)V", "")]
		public static unsafe void DeleteKey (string alias)
		{
			if (id_deleteKey_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "deleteKey", "(Ljava/lang/String;)V");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_deleteKey_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_deleteKeyAndroidM_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='deleteKeyAndroidM' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteKeyAndroidM", "(Ljava/lang/String;)V", "")]
		protected static unsafe void DeleteKeyAndroidM (string alias)
		{
			if (id_deleteKeyAndroidM_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteKeyAndroidM_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "deleteKeyAndroidM", "(Ljava/lang/String;)V");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_deleteKeyAndroidM_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_destroyKey_Ljavax_crypto_SecretKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='destroyKey' and count(parameter)=1 and parameter[1][@type='javax.crypto.SecretKey']]"
		[Register ("destroyKey", "(Ljavax/crypto/SecretKey;)V", "")]
		protected static unsafe void DestroyKey (global::Javax.Crypto.ISecretKey key)
		{
			if (id_destroyKey_Ljavax_crypto_SecretKey_ == IntPtr.Zero)
				id_destroyKey_Ljavax_crypto_SecretKey_ = JNIEnv.GetStaticMethodID (class_ref, "destroyKey", "(Ljavax/crypto/SecretKey;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (key);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_destroyKey_Ljavax_crypto_SecretKey_, __args);
			} finally {
			}
		}

		static IntPtr id_encrypt_arrayBLjavax_crypto_SecretKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='encrypt' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='javax.crypto.SecretKey'] and parameter[3][@type='java.lang.String']]"
		[Register ("encrypt", "([BLjavax/crypto/SecretKey;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Encrypt (byte[] data, global::Javax.Crypto.ISecretKey secretKey, string key)
		{
			if (id_encrypt_arrayBLjavax_crypto_SecretKey_Ljava_lang_String_ == IntPtr.Zero)
				id_encrypt_arrayBLjavax_crypto_SecretKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encrypt", "([BLjavax/crypto/SecretKey;Ljava/lang/String;)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_data);
				__args [1] = new JValue (secretKey);
				__args [2] = new JValue (native_key);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encrypt_arrayBLjavax_crypto_SecretKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_generateKey_Ljava_lang_String_Ljava_lang_String_IZZIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='generateKey' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='int'] and parameter[7][@type='boolean']]"
		[Register ("generateKey", "(Ljava/lang/String;Ljava/lang/String;IZZIZ)Ljavax/crypto/SecretKey;", "")]
		public static unsafe global::Javax.Crypto.ISecretKey GenerateKey (string alias, string algorithm, int keyLength, bool inMemory, bool userAuthenticationRequired, int userAuthenticationValiditySeconds, bool invalidatedByBiometricEnrollment)
		{
			if (id_generateKey_Ljava_lang_String_Ljava_lang_String_IZZIZ == IntPtr.Zero)
				id_generateKey_Ljava_lang_String_Ljava_lang_String_IZZIZ = JNIEnv.GetStaticMethodID (class_ref, "generateKey", "(Ljava/lang/String;Ljava/lang/String;IZZIZ)Ljavax/crypto/SecretKey;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			IntPtr native_algorithm = JNIEnv.NewString (algorithm);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_alias);
				__args [1] = new JValue (native_algorithm);
				__args [2] = new JValue (keyLength);
				__args [3] = new JValue (inMemory);
				__args [4] = new JValue (userAuthenticationRequired);
				__args [5] = new JValue (userAuthenticationValiditySeconds);
				__args [6] = new JValue (invalidatedByBiometricEnrollment);
				global::Javax.Crypto.ISecretKey __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateKey_Ljava_lang_String_Ljava_lang_String_IZZIZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
				JNIEnv.DeleteLocalRef (native_algorithm);
			}
		}

		static IntPtr id_generateKeyInAndroidKeyStoreAndroidM_Ljava_lang_String_Ljava_lang_String_IZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='generateKeyInAndroidKeyStoreAndroidM' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register ("generateKeyInAndroidKeyStoreAndroidM", "(Ljava/lang/String;Ljava/lang/String;IZI)Ljavax/crypto/SecretKey;", "")]
		protected static unsafe global::Javax.Crypto.ISecretKey GenerateKeyInAndroidKeyStoreAndroidM (string alias, string algorithm, int keyLength, bool userAuthenticationRequired, int userAuthenticationValiditySeconds)
		{
			if (id_generateKeyInAndroidKeyStoreAndroidM_Ljava_lang_String_Ljava_lang_String_IZI == IntPtr.Zero)
				id_generateKeyInAndroidKeyStoreAndroidM_Ljava_lang_String_Ljava_lang_String_IZI = JNIEnv.GetStaticMethodID (class_ref, "generateKeyInAndroidKeyStoreAndroidM", "(Ljava/lang/String;Ljava/lang/String;IZI)Ljavax/crypto/SecretKey;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			IntPtr native_algorithm = JNIEnv.NewString (algorithm);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_alias);
				__args [1] = new JValue (native_algorithm);
				__args [2] = new JValue (keyLength);
				__args [3] = new JValue (userAuthenticationRequired);
				__args [4] = new JValue (userAuthenticationValiditySeconds);
				global::Javax.Crypto.ISecretKey __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateKeyInAndroidKeyStoreAndroidM_Ljava_lang_String_Ljava_lang_String_IZI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
				JNIEnv.DeleteLocalRef (native_algorithm);
			}
		}

		static IntPtr id_generateKeyInAndroidKeyStoreAndroidN_Ljava_lang_String_Ljava_lang_String_IZIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='generateKeyInAndroidKeyStoreAndroidN' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='int'] and parameter[6][@type='boolean']]"
		[Register ("generateKeyInAndroidKeyStoreAndroidN", "(Ljava/lang/String;Ljava/lang/String;IZIZ)Ljavax/crypto/SecretKey;", "")]
		protected static unsafe global::Javax.Crypto.ISecretKey GenerateKeyInAndroidKeyStoreAndroidN (string alias, string algorithm, int keyLength, bool userAuthenticationRequired, int userAuthenticationValiditySeconds, bool invalidatedByBiometricEnrollment)
		{
			if (id_generateKeyInAndroidKeyStoreAndroidN_Ljava_lang_String_Ljava_lang_String_IZIZ == IntPtr.Zero)
				id_generateKeyInAndroidKeyStoreAndroidN_Ljava_lang_String_Ljava_lang_String_IZIZ = JNIEnv.GetStaticMethodID (class_ref, "generateKeyInAndroidKeyStoreAndroidN", "(Ljava/lang/String;Ljava/lang/String;IZIZ)Ljavax/crypto/SecretKey;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			IntPtr native_algorithm = JNIEnv.NewString (algorithm);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_alias);
				__args [1] = new JValue (native_algorithm);
				__args [2] = new JValue (keyLength);
				__args [3] = new JValue (userAuthenticationRequired);
				__args [4] = new JValue (userAuthenticationValiditySeconds);
				__args [5] = new JValue (invalidatedByBiometricEnrollment);
				global::Javax.Crypto.ISecretKey __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateKeyInAndroidKeyStoreAndroidN_Ljava_lang_String_Ljava_lang_String_IZIZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
				JNIEnv.DeleteLocalRef (native_algorithm);
			}
		}

		static IntPtr id_generateKeyInMemory_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='generateKeyInMemory' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("generateKeyInMemory", "(Ljava/lang/String;I)Ljavax/crypto/SecretKey;", "")]
		protected static unsafe global::Javax.Crypto.ISecretKey GenerateKeyInMemory (string algorithm, int keyLength)
		{
			if (id_generateKeyInMemory_Ljava_lang_String_I == IntPtr.Zero)
				id_generateKeyInMemory_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "generateKeyInMemory", "(Ljava/lang/String;I)Ljavax/crypto/SecretKey;");
			IntPtr native_algorithm = JNIEnv.NewString (algorithm);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_algorithm);
				__args [1] = new JValue (keyLength);
				global::Javax.Crypto.ISecretKey __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateKeyInMemory_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_algorithm);
			}
		}

		static IntPtr id_retrieveKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='retrieveKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retrieveKey", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", "")]
		public static unsafe global::Javax.Crypto.ISecretKey RetrieveKey (string alias)
		{
			if (id_retrieveKey_Ljava_lang_String_ == IntPtr.Zero)
				id_retrieveKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "retrieveKey", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);
				global::Javax.Crypto.ISecretKey __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_retrieveKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_retrieveKeyAndroidM_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='retrieveKeyAndroidM' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("retrieveKeyAndroidM", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", "")]
		protected static unsafe global::Javax.Crypto.ISecretKey RetrieveKeyAndroidM (string alias)
		{
			if (id_retrieveKeyAndroidM_Ljava_lang_String_ == IntPtr.Zero)
				id_retrieveKeyAndroidM_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "retrieveKeyAndroidM", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);
				global::Javax.Crypto.ISecretKey __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_retrieveKeyAndroidM_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_storeKeyAndroidM_Ljava_lang_String_Ljavax_crypto_SecretKey_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='storeKeyAndroidM' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='javax.crypto.SecretKey'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("storeKeyAndroidM", "(Ljava/lang/String;Ljavax/crypto/SecretKey;ZI)Z", "")]
		public static unsafe bool StoreKeyAndroidM (string alias, global::Javax.Crypto.ISecretKey secretKey, bool userAuthenticationRequired, int userAuthenticationValiditySeconds)
		{
			if (id_storeKeyAndroidM_Ljava_lang_String_Ljavax_crypto_SecretKey_ZI == IntPtr.Zero)
				id_storeKeyAndroidM_Ljava_lang_String_Ljavax_crypto_SecretKey_ZI = JNIEnv.GetStaticMethodID (class_ref, "storeKeyAndroidM", "(Ljava/lang/String;Ljavax/crypto/SecretKey;ZI)Z");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_alias);
				__args [1] = new JValue (secretKey);
				__args [2] = new JValue (userAuthenticationRequired);
				__args [3] = new JValue (userAuthenticationValiditySeconds);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_storeKeyAndroidM_Ljava_lang_String_Ljavax_crypto_SecretKey_ZI, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_storeKeyAndroidN_Ljava_lang_String_Ljavax_crypto_SecretKey_ZIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsSymmetric']/method[@name='storeKeyAndroidN' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='javax.crypto.SecretKey'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("storeKeyAndroidN", "(Ljava/lang/String;Ljavax/crypto/SecretKey;ZIZ)Z", "")]
		public static unsafe bool StoreKeyAndroidN (string alias, global::Javax.Crypto.ISecretKey secretKey, bool userAuthenticationRequired, int userAuthenticationValiditySeconds, bool invalidatedByBiometricEnrollment)
		{
			if (id_storeKeyAndroidN_Ljava_lang_String_Ljavax_crypto_SecretKey_ZIZ == IntPtr.Zero)
				id_storeKeyAndroidN_Ljava_lang_String_Ljavax_crypto_SecretKey_ZIZ = JNIEnv.GetStaticMethodID (class_ref, "storeKeyAndroidN", "(Ljava/lang/String;Ljavax/crypto/SecretKey;ZIZ)Z");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_alias);
				__args [1] = new JValue (secretKey);
				__args [2] = new JValue (userAuthenticationRequired);
				__args [3] = new JValue (userAuthenticationValiditySeconds);
				__args [4] = new JValue (invalidatedByBiometricEnrollment);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_storeKeyAndroidN_Ljava_lang_String_Ljavax_crypto_SecretKey_ZIZ, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

	}
}
