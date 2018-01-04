using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Security {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStorageProvider']"
	[Register ("com/ca/mas/core/security/KeyStorageProvider", "", "Com.CA.Mas.Core.Security.IKeyStorageProviderInvoker")]
	public partial interface IKeyStorageProvider : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStorageProvider']/method[@name='getKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getKey", "(Ljava/lang/String;Z)Ljavax/crypto/SecretKey;", "GetGetKey_Ljava_lang_String_ZHandler:Com.CA.Mas.Core.Security.IKeyStorageProviderInvoker, MASFoundation")]
		global::Javax.Crypto.ISecretKey GetKey (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/interface[@name='KeyStorageProvider']/method[@name='removeKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeKey", "(Ljava/lang/String;)Z", "GetRemoveKey_Ljava_lang_String_Handler:Com.CA.Mas.Core.Security.IKeyStorageProviderInvoker, MASFoundation")]
		bool RemoveKey (string p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/security/KeyStorageProvider", DoNotGenerateAcw=true)]
	internal class IKeyStorageProviderInvoker : global::Java.Lang.Object, IKeyStorageProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/security/KeyStorageProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IKeyStorageProviderInvoker); }
		}

		IntPtr class_ref;

		public static IKeyStorageProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKeyStorageProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.security.KeyStorageProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKeyStorageProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getKey_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetKey_Ljava_lang_String_ZHandler ()
		{
			if (cb_getKey_Ljava_lang_String_Z == null)
				cb_getKey_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetKey_Ljava_lang_String_Z);
			return cb_getKey_Ljava_lang_String_Z;
		}

		static IntPtr n_GetKey_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.CA.Mas.Core.Security.IKeyStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.IKeyStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetKey (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getKey_Ljava_lang_String_Z;
		public unsafe global::Javax.Crypto.ISecretKey GetKey (string p0, bool p1)
		{
			if (id_getKey_Ljava_lang_String_Z == IntPtr.Zero)
				id_getKey_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getKey", "(Ljava/lang/String;Z)Ljavax/crypto/SecretKey;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Javax.Crypto.ISecretKey __ret = global::Java.Lang.Object.GetObject<global::Javax.Crypto.ISecretKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removeKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveKey_Ljava_lang_String_Handler ()
		{
			if (cb_removeKey_Ljava_lang_String_ == null)
				cb_removeKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveKey_Ljava_lang_String_);
			return cb_removeKey_Ljava_lang_String_;
		}

		static bool n_RemoveKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Security.IKeyStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.IKeyStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeKey_Ljava_lang_String_;
		public unsafe bool RemoveKey (string p0)
		{
			if (id_removeKey_Ljava_lang_String_ == IntPtr.Zero)
				id_removeKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeKey", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeKey_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
