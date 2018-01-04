using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Security {

	[Register ("com/ca/mas/core/security/KeyStore", DoNotGenerateAcw=true)]
	public abstract class KeyStore : Java.Lang.Object {

		internal KeyStore ()
		{
		}

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

	[Register ("com/ca/mas/core/security/KeyStore", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'KeyStore' type. This type will be removed in a future release.")]
	public abstract class KeyStoreConsts : KeyStore {

		private KeyStoreConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']"
	[Register ("com/ca/mas/core/security/KeyStore", "", "Com.CA.Mas.Core.Security.IKeyStoreInvoker")]
	public partial interface IKeyStore : IJavaObject {

		bool IsUnlocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/method[@name='isUnlocked' and count(parameter)=0]"
			[Register ("isUnlocked", "()Z", "GetIsUnlockedHandler:Com.CA.Mas.Core.Security.IKeyStoreInvoker, MASFoundation")] get;
		}

		int LastError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/method[@name='getLastError' and count(parameter)=0]"
			[Register ("getLastError", "()I", "GetGetLastErrorHandler:Com.CA.Mas.Core.Security.IKeyStoreInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler:Com.CA.Mas.Core.Security.IKeyStoreInvoker, MASFoundation")]
		bool Contains (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)Z", "GetDelete_Ljava_lang_String_Handler:Com.CA.Mas.Core.Security.IKeyStoreInvoker, MASFoundation")]
		bool Delete (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)[B", "GetGet_Ljava_lang_String_Handler:Com.CA.Mas.Core.Security.IKeyStoreInvoker, MASFoundation")]
		byte[] Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("put", "(Ljava/lang/String;[B)Z", "GetPut_Ljava_lang_String_arrayBHandler:Com.CA.Mas.Core.Security.IKeyStoreInvoker, MASFoundation")]
		bool Put (string p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStore']/method[@name='saw' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saw", "(Ljava/lang/String;)[Ljava/lang/String;", "GetSaw_Ljava_lang_String_Handler:Com.CA.Mas.Core.Security.IKeyStoreInvoker, MASFoundation")]
		string[] Saw (string p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/security/KeyStore", DoNotGenerateAcw=true)]
	internal class IKeyStoreInvoker : global::Java.Lang.Object, IKeyStore {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/security/KeyStore");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IKeyStoreInvoker); }
		}

		IntPtr class_ref;

		public static IKeyStore GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKeyStore> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.security.KeyStore"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKeyStoreInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Com.CA.Mas.Core.Security.IKeyStore __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.IKeyStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnlocked;
		}
#pragma warning restore 0169

		IntPtr id_isUnlocked;
		public unsafe bool IsUnlocked {
			get {
				if (id_isUnlocked == IntPtr.Zero)
					id_isUnlocked = JNIEnv.GetMethodID (class_ref, "isUnlocked", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUnlocked);
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
			global::Com.CA.Mas.Core.Security.IKeyStore __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.IKeyStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastError;
		}
#pragma warning restore 0169

		IntPtr id_getLastError;
		public unsafe int LastError {
			get {
				if (id_getLastError == IntPtr.Zero)
					id_getLastError = JNIEnv.GetMethodID (class_ref, "getLastError", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastError);
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

		static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Security.IKeyStore __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.IKeyStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Ljava_lang_String_;
		public unsafe bool Contains (string p0)
		{
			if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_delete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_ == null)
				cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Delete_Ljava_lang_String_);
			return cb_delete_Ljava_lang_String_;
		}

		static bool n_Delete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Security.IKeyStore __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.IKeyStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Delete (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_delete_Ljava_lang_String_;
		public unsafe bool Delete (string p0)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Security.IKeyStore __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.IKeyStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe byte[] Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_put_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_put_Ljava_lang_String_arrayB == null)
				cb_put_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Put_Ljava_lang_String_arrayB);
			return cb_put_Ljava_lang_String_arrayB;
		}

		static bool n_Put_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Core.Security.IKeyStore __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.IKeyStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Put (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_arrayB;
		public unsafe bool Put (string p0, byte[] p1)
		{
			if (id_put_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_put_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;[B)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_saw_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaw_Ljava_lang_String_Handler ()
		{
			if (cb_saw_Ljava_lang_String_ == null)
				cb_saw_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Saw_Ljava_lang_String_);
			return cb_saw_Ljava_lang_String_;
		}

		static IntPtr n_Saw_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Security.IKeyStore __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.IKeyStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Saw (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_saw_Ljava_lang_String_;
		public unsafe string[] Saw (string p0)
		{
			if (id_saw_Ljava_lang_String_ == IntPtr.Zero)
				id_saw_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saw", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saw_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
