using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreAdapter']"
	[global::Android.Runtime.Register ("com/ca/mas/core/security/KeyStoreAdapter", DoNotGenerateAcw=true)]
	public partial class KeyStoreAdapter : global::Java.Lang.Object, global::Com.CA.Mas.Core.Security.IKeyStore {


		public static class InterfaceConsts {

			// The following are fields from: com.ca.mas.core.security.KeyStore

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/field[@name='KEY_NOT_FOUND']"
			[Register ("KEY_NOT_FOUND")]
			public const int KeyNotFound = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/field[@name='LOCKED']"
			[Register ("LOCKED")]
			public const int Locked = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/field[@name='NO_ERROR']"
			[Register ("NO_ERROR")]
			public const int NoError = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/field[@name='PERMISSION_DENIED']"
			[Register ("PERMISSION_DENIED")]
			public const int PermissionDenied = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/field[@name='PROTOCOL_ERROR']"
			[Register ("PROTOCOL_ERROR")]
			public const int ProtocolError = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/field[@name='SYSTEM_ERROR']"
			[Register ("SYSTEM_ERROR")]
			public const int SystemError = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/field[@name='UNDEFINED_ACTION']"
			[Register ("UNDEFINED_ACTION")]
			public const int UndefinedAction = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/field[@name='UNINITIALIZED']"
			[Register ("UNINITIALIZED")]
			public const int Uninitialized = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/field[@name='VALUE_CORRUPTED']"
			[Register ("VALUE_CORRUPTED")]
			public const int ValueCorrupted = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/field[@name='WRONG_PASSWORD']"
			[Register ("WRONG_PASSWORD")]
			public const int WrongPassword = (int) 10;
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/security/KeyStoreAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyStoreAdapter); }
		}

		protected KeyStoreAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isUnlocked;
#pragma warning disable 0169
		static Delegate GetIsUnlockedHandler ()
		{
			if (cb_isUnlocked == null)
				cb_isUnlocked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUnlocked);
			return cb_isUnlocked;
		}

		static bool n_IsUnlocked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreAdapter __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnlocked;
		}
#pragma warning restore 0169

		static IntPtr id_isUnlocked;
		public virtual unsafe bool IsUnlocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreAdapter']/method[@name='isUnlocked' and count(parameter)=0]"
			[Register ("isUnlocked", "()Z", "GetIsUnlockedHandler")]
			get {
				if (id_isUnlocked == IntPtr.Zero)
					id_isUnlocked = JNIEnv.GetMethodID (class_ref, "isUnlocked", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUnlocked);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUnlocked", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_getKeyStore;
		public static unsafe global::Com.CA.Mas.Core.Security.IKeyStore KeyStore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreAdapter']/method[@name='getKeyStore' and count(parameter)=0]"
			[Register ("getKeyStore", "()Lcom/ca/mas/core/security/KeyStore;", "GetGetKeyStoreHandler")]
			get {
				if (id_getKeyStore == IntPtr.Zero)
					id_getKeyStore = JNIEnv.GetStaticMethodID (class_ref, "getKeyStore", "()Lcom/ca/mas/core/security/KeyStore;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.IKeyStore> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getKeyStore), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLastError;
#pragma warning disable 0169
		static Delegate GetGetLastErrorHandler ()
		{
			if (cb_getLastError == null)
				cb_getLastError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastError);
			return cb_getLastError;
		}

		static int n_GetLastError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreAdapter __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastError;
		}
#pragma warning restore 0169

		static IntPtr id_getLastError;
		public virtual unsafe int LastError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreAdapter']/method[@name='getLastError' and count(parameter)=0]"
			[Register ("getLastError", "()I", "GetGetLastErrorHandler")]
			get {
				if (id_getLastError == IntPtr.Zero)
					id_getLastError = JNIEnv.GetMethodID (class_ref, "getLastError", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastError);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastError", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_contains_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_String_Handler ()
		{
			if (cb_contains_Ljava_lang_String_ == null)
				cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_String_);
			return cb_contains_Ljava_lang_String_;
		}

		static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreAdapter __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (key);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreAdapter']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler")]
		public virtual unsafe bool Contains (string key)
		{
			if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_delete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_ == null)
				cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Delete_Ljava_lang_String_);
			return cb_delete_Ljava_lang_String_;
		}

		static bool n_Delete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreAdapter __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Delete (key);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_delete_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreAdapter']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)Z", "GetDelete_Ljava_lang_String_Handler")]
		public virtual unsafe bool Delete (string key)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;)Z");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreAdapter __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreAdapter']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)[B", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] Get (string key)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)[B");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_put_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_put_Ljava_lang_String_arrayB == null)
				cb_put_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Put_Ljava_lang_String_arrayB);
			return cb_put_Ljava_lang_String_arrayB;
		}

		static bool n_Put_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreAdapter __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Put (key, value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreAdapter']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("put", "(Ljava/lang/String;[B)Z", "GetPut_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe bool Put (string key, byte[] value)
		{
			if (id_put_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_put_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;[B)Z");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;[B)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_saw_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaw_Ljava_lang_String_Handler ()
		{
			if (cb_saw_Ljava_lang_String_ == null)
				cb_saw_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Saw_Ljava_lang_String_);
			return cb_saw_Ljava_lang_String_;
		}

		static IntPtr n_Saw_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			global::Com.CA.Mas.Core.Security.KeyStoreAdapter __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.KeyStoreAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Saw (prefix));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_saw_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='KeyStoreAdapter']/method[@name='saw' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saw", "(Ljava/lang/String;)[Ljava/lang/String;", "GetSaw_Ljava_lang_String_Handler")]
		public virtual unsafe string[] Saw (string prefix)
		{
			if (id_saw_Ljava_lang_String_ == IntPtr.Zero)
				id_saw_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saw", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_prefix);

				string[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saw_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saw", "(Ljava/lang/String;)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

	}
}
