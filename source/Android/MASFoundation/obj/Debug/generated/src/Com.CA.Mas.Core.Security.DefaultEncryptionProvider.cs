using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='DefaultEncryptionProvider']"
	[global::Android.Runtime.Register ("com/ca/mas/core/security/DefaultEncryptionProvider", DoNotGenerateAcw=true)]
	public partial class DefaultEncryptionProvider : global::Java.Lang.Object, global::Com.CA.Mas.Core.Security.IEncryptionProvider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/security/DefaultEncryptionProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultEncryptionProvider); }
		}

		protected DefaultEncryptionProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='DefaultEncryptionProvider']/constructor[@name='DefaultEncryptionProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DefaultEncryptionProvider (global::Android.Content.Context ctx)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ctx);
				if (((object) this).GetType () != typeof (DefaultEncryptionProvider)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Lcom_ca_mas_core_security_KeyStorageProvider_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='DefaultEncryptionProvider']/constructor[@name='DefaultEncryptionProvider' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.ca.mas.core.security.KeyStorageProvider']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/ca/mas/core/security/KeyStorageProvider;)V", "")]
		public unsafe DefaultEncryptionProvider (global::Android.Content.Context ctx, global::Com.CA.Mas.Core.Security.IKeyStorageProvider keyStorageProvider)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ctx);
				__args [1] = new JValue (keyStorageProvider);
				if (((object) this).GetType () != typeof (DefaultEncryptionProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/ca/mas/core/security/KeyStorageProvider;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/ca/mas/core/security/KeyStorageProvider;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_ca_mas_core_security_KeyStorageProvider_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_ca_mas_core_security_KeyStorageProvider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/ca/mas/core/security/KeyStorageProvider;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_ca_mas_core_security_KeyStorageProvider_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_ca_mas_core_security_KeyStorageProvider_, __args);
			} finally {
			}
		}

		static Delegate cb_getKeyAlias;
#pragma warning disable 0169
		static Delegate GetGetKeyAliasHandler ()
		{
			if (cb_getKeyAlias == null)
				cb_getKeyAlias = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeyAlias);
			return cb_getKeyAlias;
		}

		static IntPtr n_GetKeyAlias (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.DefaultEncryptionProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.DefaultEncryptionProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KeyAlias);
		}
#pragma warning restore 0169

		static IntPtr id_getKeyAlias;
		protected virtual unsafe string KeyAlias {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='DefaultEncryptionProvider']/method[@name='getKeyAlias' and count(parameter)=0]"
			[Register ("getKeyAlias", "()Ljava/lang/String;", "GetGetKeyAliasHandler")]
			get {
				if (id_getKeyAlias == IntPtr.Zero)
					id_getKeyAlias = JNIEnv.GetMethodID (class_ref, "getKeyAlias", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeyAlias), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyAlias", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_decrypt_arrayB;
#pragma warning disable 0169
		static Delegate GetDecrypt_arrayBHandler ()
		{
			if (cb_decrypt_arrayB == null)
				cb_decrypt_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decrypt_arrayB);
			return cb_decrypt_arrayB;
		}

		static IntPtr n_Decrypt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_encryptedData)
		{
			global::Com.CA.Mas.Core.Security.DefaultEncryptionProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.DefaultEncryptionProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] encryptedData = (byte[]) JNIEnv.GetArray (native_encryptedData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (encryptedData));
			if (encryptedData != null)
				JNIEnv.CopyArray (encryptedData, native_encryptedData);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decrypt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='DefaultEncryptionProvider']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decrypt", "([B)[B", "GetDecrypt_arrayBHandler")]
		public virtual unsafe byte[] Decrypt (byte[] encryptedData)
		{
			if (id_decrypt_arrayB == IntPtr.Zero)
				id_decrypt_arrayB = JNIEnv.GetMethodID (class_ref, "decrypt", "([B)[B");
			IntPtr native_encryptedData = JNIEnv.NewArray (encryptedData);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_encryptedData);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decrypt", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (encryptedData != null) {
					JNIEnv.CopyArray (native_encryptedData, encryptedData);
					JNIEnv.DeleteLocalRef (native_encryptedData);
				}
			}
		}

		static Delegate cb_encrypt_arrayB;
#pragma warning disable 0169
		static Delegate GetEncrypt_arrayBHandler ()
		{
			if (cb_encrypt_arrayB == null)
				cb_encrypt_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encrypt_arrayB);
			return cb_encrypt_arrayB;
		}

		static IntPtr n_Encrypt_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.CA.Mas.Core.Security.DefaultEncryptionProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.DefaultEncryptionProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encrypt (data));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encrypt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='DefaultEncryptionProvider']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encrypt", "([B)[B", "GetEncrypt_arrayBHandler")]
		public virtual unsafe byte[] Encrypt (byte[] data)
		{
			if (id_encrypt_arrayB == IntPtr.Zero)
				id_encrypt_arrayB = JNIEnv.GetMethodID (class_ref, "encrypt", "([B)[B");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encrypt_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encrypt", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

	}
}
