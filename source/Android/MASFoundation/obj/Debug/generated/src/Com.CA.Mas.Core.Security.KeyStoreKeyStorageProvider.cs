using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreKeyStorageProvider']"
	[global::Android.Runtime.Register ("com/ca/mas/core/security/KeyStoreKeyStorageProvider", DoNotGenerateAcw=true)]
	public abstract partial class KeyStoreKeyStorageProvider : global::Java.Lang.Object, global::Com.CA.Mas.Core.Security.IKeyStorageProvider {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreKeyStorageProvider']/field[@name='ASYM_KEY_ALIAS']"
		[Register ("ASYM_KEY_ALIAS")]
		protected const string AsymKeyAlias = (string) "ASYM_KEY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreKeyStorageProvider']/field[@name='RSA_ECB_PKCS1_PADDING']"
		[Register ("RSA_ECB_PKCS1_PADDING")]
		public const string RsaEcbPkcs1Padding = (string) "RSA/ECB/PKCS1PADDING";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/security/KeyStoreKeyStorageProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyStoreKeyStorageProvider); }
		}

		protected KeyStoreKeyStorageProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreKeyStorageProvider']/constructor[@name='KeyStoreKeyStorageProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe KeyStoreKeyStorageProvider (global::Android.Content.Context ctx)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ctx);
				if (((object) this).GetType () != typeof (KeyStoreKeyStorageProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreKeyStorageProvider']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_decryptSecretKey_arrayB;
#pragma warning disable 0169
		static Delegate GetDecryptSecretKey_arrayBHandler ()
		{
			if (cb_decryptSecretKey_arrayB == null)
				cb_decryptSecretKey_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecryptSecretKey_arrayB);
			return cb_decryptSecretKey_arrayB;
		}

		static IntPtr n_DecryptSecretKey_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_encryptedSecretKey)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] encryptedSecretKey = (byte[]) JNIEnv.GetArray (native_encryptedSecretKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecryptSecretKey (encryptedSecretKey));
			if (encryptedSecretKey != null)
				JNIEnv.CopyArray (encryptedSecretKey, native_encryptedSecretKey);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decryptSecretKey_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreKeyStorageProvider']/method[@name='decryptSecretKey' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decryptSecretKey", "([B)Ljavax/crypto/SecretKey;", "GetDecryptSecretKey_arrayBHandler")]
		protected virtual unsafe global::Javax.Crypto.ISecretKey DecryptSecretKey (byte[] encryptedSecretKey)
		{
			if (id_decryptSecretKey_arrayB == IntPtr.Zero)
				id_decryptSecretKey_arrayB = JNIEnv.GetMethodID (class_ref, "decryptSecretKey", "([B)Ljavax/crypto/SecretKey;");
			IntPtr native_encryptedSecretKey = JNIEnv.NewArray (encryptedSecretKey);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_encryptedSecretKey);

				global::Javax.Crypto.ISecretKey __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decryptSecretKey_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decryptSecretKey", "([B)Ljavax/crypto/SecretKey;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (encryptedSecretKey != null) {
					JNIEnv.CopyArray (native_encryptedSecretKey, encryptedSecretKey);
					JNIEnv.DeleteLocalRef (native_encryptedSecretKey);
				}
			}
		}

		static Delegate cb_encryptSecretKey_Ljavax_crypto_SecretKey_;
#pragma warning disable 0169
		static Delegate GetEncryptSecretKey_Ljavax_crypto_SecretKey_Handler ()
		{
			if (cb_encryptSecretKey_Ljavax_crypto_SecretKey_ == null)
				cb_encryptSecretKey_Ljavax_crypto_SecretKey_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncryptSecretKey_Ljavax_crypto_SecretKey_);
			return cb_encryptSecretKey_Ljavax_crypto_SecretKey_;
		}

		static IntPtr n_EncryptSecretKey_Ljavax_crypto_SecretKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_secretKey)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Crypto.ISecretKey secretKey = (global::Javax.Crypto.ISecretKey)global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (native_secretKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.EncryptSecretKey (secretKey));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encryptSecretKey_Ljavax_crypto_SecretKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreKeyStorageProvider']/method[@name='encryptSecretKey' and count(parameter)=1 and parameter[1][@type='javax.crypto.SecretKey']]"
		[Register ("encryptSecretKey", "(Ljavax/crypto/SecretKey;)[B", "GetEncryptSecretKey_Ljavax_crypto_SecretKey_Handler")]
		protected virtual unsafe byte[] EncryptSecretKey (global::Javax.Crypto.ISecretKey secretKey)
		{
			if (id_encryptSecretKey_Ljavax_crypto_SecretKey_ == IntPtr.Zero)
				id_encryptSecretKey_Ljavax_crypto_SecretKey_ = JNIEnv.GetMethodID (class_ref, "encryptSecretKey", "(Ljavax/crypto/SecretKey;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (secretKey);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encryptSecretKey_Ljavax_crypto_SecretKey_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encryptSecretKey", "(Ljavax/crypto/SecretKey;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getKey_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetKey_Ljava_lang_String_ZHandler ()
		{
			if (cb_getKey_Ljava_lang_String_Z == null)
				cb_getKey_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetKey_Ljava_lang_String_Z);
			return cb_getKey_Ljava_lang_String_Z;
		}

		static IntPtr n_GetKey_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_alias, bool userAuthenticationRequired)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetKey (alias, userAuthenticationRequired));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getKey_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreKeyStorageProvider']/method[@name='getKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getKey", "(Ljava/lang/String;Z)Ljavax/crypto/SecretKey;", "GetGetKey_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Javax.Crypto.ISecretKey GetKey (string alias, bool userAuthenticationRequired)
		{
			if (id_getKey_Ljava_lang_String_Z == IntPtr.Zero)
				id_getKey_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getKey", "(Ljava/lang/String;Z)Ljavax/crypto/SecretKey;");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_alias);
				__args [1] = new JValue (userAuthenticationRequired);

				global::Javax.Crypto.ISecretKey __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "(Ljava/lang/String;Z)Ljavax/crypto/SecretKey;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static Delegate cb_removeKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveKey_Ljava_lang_String_Handler ()
		{
			if (cb_removeKey_Ljava_lang_String_ == null)
				cb_removeKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveKey_Ljava_lang_String_);
			return cb_removeKey_Ljava_lang_String_;
		}

		static bool n_RemoveKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alias)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveKey (alias);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreKeyStorageProvider']/method[@name='removeKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeKey", "(Ljava/lang/String;)Z", "GetRemoveKey_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemoveKey (string alias)
		{
			if (id_removeKey_Ljava_lang_String_ == IntPtr.Zero)
				id_removeKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeKey", "(Ljava/lang/String;)Z");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeKey_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeKey", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/security/KeyStoreKeyStorageProvider", DoNotGenerateAcw=true)]
	internal partial class KeyStoreKeyStorageProviderInvoker : KeyStoreKeyStorageProvider {

		public KeyStoreKeyStorageProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyStoreKeyStorageProviderInvoker); }
		}

	}

}
