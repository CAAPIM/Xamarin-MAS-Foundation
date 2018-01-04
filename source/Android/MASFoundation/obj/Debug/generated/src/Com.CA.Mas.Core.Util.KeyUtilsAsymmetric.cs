using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']"
	[global::Android.Runtime.Register ("com/ca/mas/core/util/KeyUtilsAsymmetric", DoNotGenerateAcw=true)]
	public partial class KeyUtilsAsymmetric : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/util/KeyUtilsAsymmetric", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyUtilsAsymmetric); }
		}

		protected KeyUtilsAsymmetric (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/constructor[@name='KeyUtilsAsymmetric' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe KeyUtilsAsymmetric ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (KeyUtilsAsymmetric)) {
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

		static IntPtr id_arrayConcat_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='arrayConcat' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;byte[]&gt;']]"
		[Register ("arrayConcat", "(Ljava/util/ArrayList;)[B", "")]
		protected static unsafe byte[] ArrayConcat (global::System.Collections.Generic.IList<byte[]> byteArrayList)
		{
			if (id_arrayConcat_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_arrayConcat_Ljava_util_ArrayList_ = JNIEnv.GetStaticMethodID (class_ref, "arrayConcat", "(Ljava/util/ArrayList;)[B");
			IntPtr native_byteArrayList = global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (byteArrayList);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_byteArrayList);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_arrayConcat_Ljava_util_ArrayList_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_byteArrayList);
			}
		}

		static IntPtr id_arraySplit_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='arraySplit' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("arraySplit", "([BI)Ljava/util/ArrayList;", "")]
		protected static unsafe global::System.Collections.Generic.IList<byte[]> ArraySplit (byte[] bytes, int eachLength)
		{
			if (id_arraySplit_arrayBI == IntPtr.Zero)
				id_arraySplit_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "arraySplit", "([BI)Ljava/util/ArrayList;");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_bytes);
				__args [1] = new JValue (eachLength);
				global::System.Collections.Generic.IList<byte[]> __ret = global::Android.Runtime.JavaList<byte[]>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_arraySplit_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_clearCertificateChain_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='clearCertificateChain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearCertificateChain", "(Ljava/lang/String;)V", "")]
		public static unsafe void ClearCertificateChain (string aliasPrefix)
		{
			if (id_clearCertificateChain_Ljava_lang_String_ == IntPtr.Zero)
				id_clearCertificateChain_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "clearCertificateChain", "(Ljava/lang/String;)V");
			IntPtr native_aliasPrefix = JNIEnv.NewString (aliasPrefix);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aliasPrefix);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearCertificateChain_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aliasPrefix);
			}
		}

		static IntPtr id_decrypt_Ljava_security_PrivateKey_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='decrypt' and count(parameter)=3 and parameter[1][@type='java.security.PrivateKey'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("decrypt", "(Ljava/security/PrivateKey;I[B)[B", "")]
		public static unsafe byte[] Decrypt (global::Java.Security.IPrivateKey privateKey, int keysize, byte[] contentToDecrypt)
		{
			if (id_decrypt_Ljava_security_PrivateKey_IarrayB == IntPtr.Zero)
				id_decrypt_Ljava_security_PrivateKey_IarrayB = JNIEnv.GetStaticMethodID (class_ref, "decrypt", "(Ljava/security/PrivateKey;I[B)[B");
			IntPtr native_contentToDecrypt = JNIEnv.NewArray (contentToDecrypt);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (privateKey);
				__args [1] = new JValue (keysize);
				__args [2] = new JValue (native_contentToDecrypt);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decrypt_Ljava_security_PrivateKey_IarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (contentToDecrypt != null) {
					JNIEnv.CopyArray (native_contentToDecrypt, contentToDecrypt);
					JNIEnv.DeleteLocalRef (native_contentToDecrypt);
				}
			}
		}

		static IntPtr id_decryptSection_Ljava_security_PrivateKey_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='decryptSection' and count(parameter)=2 and parameter[1][@type='java.security.PrivateKey'] and parameter[2][@type='byte[]']]"
		[Register ("decryptSection", "(Ljava/security/PrivateKey;[B)[B", "")]
		public static unsafe byte[] DecryptSection (global::Java.Security.IPrivateKey privateKey, byte[] contentToDecrypt)
		{
			if (id_decryptSection_Ljava_security_PrivateKey_arrayB == IntPtr.Zero)
				id_decryptSection_Ljava_security_PrivateKey_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decryptSection", "(Ljava/security/PrivateKey;[B)[B");
			IntPtr native_contentToDecrypt = JNIEnv.NewArray (contentToDecrypt);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (privateKey);
				__args [1] = new JValue (native_contentToDecrypt);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decryptSection_Ljava_security_PrivateKey_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (contentToDecrypt != null) {
					JNIEnv.CopyArray (native_contentToDecrypt, contentToDecrypt);
					JNIEnv.DeleteLocalRef (native_contentToDecrypt);
				}
			}
		}

		static IntPtr id_deletePrivateKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='deletePrivateKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deletePrivateKey", "(Ljava/lang/String;)V", "")]
		public static unsafe void DeletePrivateKey (string alias)
		{
			if (id_deletePrivateKey_Ljava_lang_String_ == IntPtr.Zero)
				id_deletePrivateKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "deletePrivateKey", "(Ljava/lang/String;)V");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_deletePrivateKey_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_encrypt_Ljava_security_PublicKey_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='encrypt' and count(parameter)=3 and parameter[1][@type='java.security.PublicKey'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("encrypt", "(Ljava/security/PublicKey;I[B)[B", "")]
		public static unsafe byte[] Encrypt (global::Java.Security.IPublicKey publicKey, int keysize, byte[] contentToEncrypt)
		{
			if (id_encrypt_Ljava_security_PublicKey_IarrayB == IntPtr.Zero)
				id_encrypt_Ljava_security_PublicKey_IarrayB = JNIEnv.GetStaticMethodID (class_ref, "encrypt", "(Ljava/security/PublicKey;I[B)[B");
			IntPtr native_contentToEncrypt = JNIEnv.NewArray (contentToEncrypt);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (publicKey);
				__args [1] = new JValue (keysize);
				__args [2] = new JValue (native_contentToEncrypt);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encrypt_Ljava_security_PublicKey_IarrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (contentToEncrypt != null) {
					JNIEnv.CopyArray (native_contentToEncrypt, contentToEncrypt);
					JNIEnv.DeleteLocalRef (native_contentToEncrypt);
				}
			}
		}

		static IntPtr id_encryptSection_Ljava_security_PublicKey_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='encryptSection' and count(parameter)=2 and parameter[1][@type='java.security.PublicKey'] and parameter[2][@type='byte[]']]"
		[Register ("encryptSection", "(Ljava/security/PublicKey;[B)[B", "")]
		public static unsafe byte[] EncryptSection (global::Java.Security.IPublicKey publicKey, byte[] contentToEncrypt)
		{
			if (id_encryptSection_Ljava_security_PublicKey_arrayB == IntPtr.Zero)
				id_encryptSection_Ljava_security_PublicKey_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encryptSection", "(Ljava/security/PublicKey;[B)[B");
			IntPtr native_contentToEncrypt = JNIEnv.NewArray (contentToEncrypt);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (publicKey);
				__args [1] = new JValue (native_contentToEncrypt);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encryptSection_Ljava_security_PublicKey_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (contentToEncrypt != null) {
					JNIEnv.CopyArray (native_contentToEncrypt, contentToEncrypt);
					JNIEnv.DeleteLocalRef (native_contentToEncrypt);
				}
			}
		}

		static IntPtr id_generateRsaPrivateKey_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_ZZIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='generateRsaPrivateKey' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='int'] and parameter[8][@type='boolean']]"
		[Register ("generateRsaPrivateKey", "(Landroid/content/Context;ILjava/lang/String;Ljava/lang/String;ZZIZ)Ljava/security/PrivateKey;", "")]
		public static unsafe global::Java.Security.IPrivateKey GenerateRsaPrivateKey (global::Android.Content.Context context, int keysize, string alias, string dn, bool lollipopEncryptionRequired, bool marshmallowUserAuthenticationRequired, int marshmallowUserAuthenticationValidityDurationSeconds, bool nougatInvalidatedByBiometricEnrollment)
		{
			if (id_generateRsaPrivateKey_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_ZZIZ == IntPtr.Zero)
				id_generateRsaPrivateKey_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_ZZIZ = JNIEnv.GetStaticMethodID (class_ref, "generateRsaPrivateKey", "(Landroid/content/Context;ILjava/lang/String;Ljava/lang/String;ZZIZ)Ljava/security/PrivateKey;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			IntPtr native_dn = JNIEnv.NewString (dn);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (context);
				__args [1] = new JValue (keysize);
				__args [2] = new JValue (native_alias);
				__args [3] = new JValue (native_dn);
				__args [4] = new JValue (lollipopEncryptionRequired);
				__args [5] = new JValue (marshmallowUserAuthenticationRequired);
				__args [6] = new JValue (marshmallowUserAuthenticationValidityDurationSeconds);
				__args [7] = new JValue (nougatInvalidatedByBiometricEnrollment);
				global::Java.Security.IPrivateKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateRsaPrivateKey_Landroid_content_Context_ILjava_lang_String_Ljava_lang_String_ZZIZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
				JNIEnv.DeleteLocalRef (native_dn);
			}
		}

		static IntPtr id_getCertificateChain_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='getCertificateChain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;", "")]
		public static unsafe global::Java.Security.Cert.X509Certificate[] GetCertificateChain (string aliasPrefix)
		{
			if (id_getCertificateChain_Ljava_lang_String_ == IntPtr.Zero)
				id_getCertificateChain_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;");
			IntPtr native_aliasPrefix = JNIEnv.NewString (aliasPrefix);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aliasPrefix);
				global::Java.Security.Cert.X509Certificate[] __ret = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCertificateChain_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_aliasPrefix);
			}
		}

		static IntPtr id_getKeystoreKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='getKeystoreKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getKeystoreKey", "(Ljava/lang/String;)Ljava/security/Key;", "")]
		public static unsafe global::Java.Security.IKey GetKeystoreKey (string alias)
		{
			if (id_getKeystoreKey_Ljava_lang_String_ == IntPtr.Zero)
				id_getKeystoreKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getKeystoreKey", "(Ljava/lang/String;)Ljava/security/Key;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);
				global::Java.Security.IKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.IKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getKeystoreKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_getRsaPrivateKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='getRsaPrivateKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRsaPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;", "")]
		public static unsafe global::Java.Security.IPrivateKey GetRsaPrivateKey (string alias)
		{
			if (id_getRsaPrivateKey_Ljava_lang_String_ == IntPtr.Zero)
				id_getRsaPrivateKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRsaPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);
				global::Java.Security.IPrivateKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRsaPrivateKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_getRsaPublicKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='getRsaPublicKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRsaPublicKey", "(Ljava/lang/String;)Ljava/security/PublicKey;", "")]
		public static unsafe global::Java.Security.IPublicKey GetRsaPublicKey (string alias)
		{
			if (id_getRsaPublicKey_Ljava_lang_String_ == IntPtr.Zero)
				id_getRsaPublicKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRsaPublicKey", "(Ljava/lang/String;)Ljava/security/PublicKey;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);
				global::Java.Security.IPublicKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRsaPublicKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static IntPtr id_setCertificateChain_Ljava_lang_String_arrayLjava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='KeyUtilsAsymmetric']/method[@name='setCertificateChain' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.security.cert.X509Certificate[]']]"
		[Register ("setCertificateChain", "(Ljava/lang/String;[Ljava/security/cert/X509Certificate;)V", "")]
		public static unsafe void SetCertificateChain (string aliasPrefix, global::Java.Security.Cert.X509Certificate[] chain)
		{
			if (id_setCertificateChain_Ljava_lang_String_arrayLjava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_setCertificateChain_Ljava_lang_String_arrayLjava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "setCertificateChain", "(Ljava/lang/String;[Ljava/security/cert/X509Certificate;)V");
			IntPtr native_aliasPrefix = JNIEnv.NewString (aliasPrefix);
			IntPtr native_chain = JNIEnv.NewArray (chain);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_aliasPrefix);
				__args [1] = new JValue (native_chain);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCertificateChain_Ljava_lang_String_arrayLjava_security_cert_X509Certificate_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aliasPrefix);
				if (chain != null) {
					JNIEnv.CopyArray (native_chain, chain);
					JNIEnv.DeleteLocalRef (native_chain);
				}
			}
		}

	}
}
