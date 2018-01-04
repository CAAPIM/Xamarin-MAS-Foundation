using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='LockableEncryptionProvider']"
	[global::Android.Runtime.Register ("com/ca/mas/core/security/LockableEncryptionProvider", DoNotGenerateAcw=true)]
	public partial class LockableEncryptionProvider : global::Java.Lang.Object, global::Com.CA.Mas.Core.Security.IEncryptionProvider {


		static IntPtr ctx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='LockableEncryptionProvider']/field[@name='ctx']"
		[Register ("ctx")]
		protected global::Android.Content.Context Ctx {
			get {
				if (ctx_jfieldId == IntPtr.Zero)
					ctx_jfieldId = JNIEnv.GetFieldID (class_ref, "ctx", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ctx_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ctx_jfieldId == IntPtr.Zero)
					ctx_jfieldId = JNIEnv.GetFieldID (class_ref, "ctx", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ctx_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/security/LockableEncryptionProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LockableEncryptionProvider); }
		}

		protected LockableEncryptionProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='LockableEncryptionProvider']/constructor[@name='LockableEncryptionProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LockableEncryptionProvider (global::Android.Content.Context ctx)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ctx);
				if (((object) this).GetType () != typeof (LockableEncryptionProvider)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='LockableEncryptionProvider']/constructor[@name='LockableEncryptionProvider' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe LockableEncryptionProvider (global::Android.Content.Context ctx, string keyAlias)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_keyAlias = JNIEnv.NewString (keyAlias);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ctx);
				__args [1] = new JValue (native_keyAlias);
				if (((object) this).GetType () != typeof (LockableEncryptionProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keyAlias);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Clear);
			return cb_clear;
		}

		static bool n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.LockableEncryptionProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.LockableEncryptionProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='LockableEncryptionProvider']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Z", "GetClearHandler")]
		public virtual unsafe bool Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()Z"));
			} finally {
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
			global::Com.CA.Mas.Core.Security.LockableEncryptionProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.LockableEncryptionProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] encryptedData = (byte[]) JNIEnv.GetArray (native_encryptedData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Decrypt (encryptedData));
			if (encryptedData != null)
				JNIEnv.CopyArray (encryptedData, native_encryptedData);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decrypt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='LockableEncryptionProvider']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
			global::Com.CA.Mas.Core.Security.LockableEncryptionProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.LockableEncryptionProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Encrypt (data));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encrypt_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='LockableEncryptionProvider']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
