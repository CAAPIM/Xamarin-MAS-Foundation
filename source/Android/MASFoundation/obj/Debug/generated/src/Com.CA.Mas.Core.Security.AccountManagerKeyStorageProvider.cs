using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='AccountManagerKeyStorageProvider']"
	[global::Android.Runtime.Register ("com/ca/mas/core/security/AccountManagerKeyStorageProvider", DoNotGenerateAcw=true)]
	public partial class AccountManagerKeyStorageProvider : global::Com.CA.Mas.Core.Security.KeyStoreKeyStorageProvider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/security/AccountManagerKeyStorageProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountManagerKeyStorageProvider); }
		}

		protected AccountManagerKeyStorageProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='AccountManagerKeyStorageProvider']/constructor[@name='AccountManagerKeyStorageProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AccountManagerKeyStorageProvider (global::Android.Content.Context ctx)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ctx);
				if (((object) this).GetType () != typeof (AccountManagerKeyStorageProvider)) {
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

		static Delegate cb_deleteSecretKeyLocally_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteSecretKeyLocally_Ljava_lang_String_Handler ()
		{
			if (cb_deleteSecretKeyLocally_Ljava_lang_String_ == null)
				cb_deleteSecretKeyLocally_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteSecretKeyLocally_Ljava_lang_String_);
			return cb_deleteSecretKeyLocally_Ljava_lang_String_;
		}

		static bool n_DeleteSecretKeyLocally_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alias)
		{
			global::Com.CA.Mas.Core.Security.AccountManagerKeyStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.AccountManagerKeyStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteSecretKeyLocally (alias);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteSecretKeyLocally_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='AccountManagerKeyStorageProvider']/method[@name='deleteSecretKeyLocally' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteSecretKeyLocally", "(Ljava/lang/String;)Z", "GetDeleteSecretKeyLocally_Ljava_lang_String_Handler")]
		protected virtual unsafe bool DeleteSecretKeyLocally (string alias)
		{
			if (id_deleteSecretKeyLocally_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteSecretKeyLocally_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteSecretKeyLocally", "(Ljava/lang/String;)Z");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deleteSecretKeyLocally_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteSecretKeyLocally", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static Delegate cb_getEncryptedSecretKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEncryptedSecretKey_Ljava_lang_String_Handler ()
		{
			if (cb_getEncryptedSecretKey_Ljava_lang_String_ == null)
				cb_getEncryptedSecretKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEncryptedSecretKey_Ljava_lang_String_);
			return cb_getEncryptedSecretKey_Ljava_lang_String_;
		}

		static IntPtr n_GetEncryptedSecretKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alias)
		{
			global::Com.CA.Mas.Core.Security.AccountManagerKeyStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.AccountManagerKeyStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetEncryptedSecretKey (alias));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getEncryptedSecretKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='AccountManagerKeyStorageProvider']/method[@name='getEncryptedSecretKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEncryptedSecretKey", "(Ljava/lang/String;)[B", "GetGetEncryptedSecretKey_Ljava_lang_String_Handler")]
		protected virtual unsafe byte[] GetEncryptedSecretKey (string alias)
		{
			if (id_getEncryptedSecretKey_Ljava_lang_String_ == IntPtr.Zero)
				id_getEncryptedSecretKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getEncryptedSecretKey", "(Ljava/lang/String;)[B");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncryptedSecretKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncryptedSecretKey", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static Delegate cb_storeSecretKeyLocally_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetStoreSecretKeyLocally_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_storeSecretKeyLocally_Ljava_lang_String_arrayB == null)
				cb_storeSecretKeyLocally_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_StoreSecretKeyLocally_Ljava_lang_String_arrayB);
			return cb_storeSecretKeyLocally_Ljava_lang_String_arrayB;
		}

		static bool n_StoreSecretKeyLocally_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_alias, IntPtr native_encryptedSecretkey)
		{
			global::Com.CA.Mas.Core.Security.AccountManagerKeyStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.AccountManagerKeyStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
			byte[] encryptedSecretkey = (byte[]) JNIEnv.GetArray (native_encryptedSecretkey, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.StoreSecretKeyLocally (alias, encryptedSecretkey);
			if (encryptedSecretkey != null)
				JNIEnv.CopyArray (encryptedSecretkey, native_encryptedSecretkey);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_storeSecretKeyLocally_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='AccountManagerKeyStorageProvider']/method[@name='storeSecretKeyLocally' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("storeSecretKeyLocally", "(Ljava/lang/String;[B)Z", "GetStoreSecretKeyLocally_Ljava_lang_String_arrayBHandler")]
		protected virtual unsafe bool StoreSecretKeyLocally (string alias, byte[] encryptedSecretkey)
		{
			if (id_storeSecretKeyLocally_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_storeSecretKeyLocally_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "storeSecretKeyLocally", "(Ljava/lang/String;[B)Z");
			IntPtr native_alias = JNIEnv.NewString (alias);
			IntPtr native_encryptedSecretkey = JNIEnv.NewArray (encryptedSecretkey);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_alias);
				__args [1] = new JValue (native_encryptedSecretkey);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_storeSecretKeyLocally_Ljava_lang_String_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "storeSecretKeyLocally", "(Ljava/lang/String;[B)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
				if (encryptedSecretkey != null) {
					JNIEnv.CopyArray (native_encryptedSecretkey, encryptedSecretkey);
					JNIEnv.DeleteLocalRef (native_encryptedSecretkey);
				}
			}
		}

	}
}
