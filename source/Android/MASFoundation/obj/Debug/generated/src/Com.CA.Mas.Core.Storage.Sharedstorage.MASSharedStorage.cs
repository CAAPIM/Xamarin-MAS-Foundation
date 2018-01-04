using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Storage.Sharedstorage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASSharedStorage']"
	[global::Android.Runtime.Register ("com/ca/mas/core/storage/sharedstorage/MASSharedStorage", DoNotGenerateAcw=true)]
	public partial class MASSharedStorage : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/storage/sharedstorage/MASSharedStorage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASSharedStorage); }
		}

		protected MASSharedStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASSharedStorage']/constructor[@name='MASSharedStorage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MASSharedStorage (string accountName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_accountName = JNIEnv.NewString (accountName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_accountName);
				if (((object) this).GetType () != typeof (MASSharedStorage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountName);
			}
		}

		static Delegate cb_delete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_ == null)
				cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Ljava_lang_String_);
			return cb_delete_Ljava_lang_String_;
		}

		static void n_Delete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASSharedStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASSharedStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Delete (key);
		}
#pragma warning restore 0169

		static IntPtr id_delete_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASSharedStorage']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)V", "GetDelete_Ljava_lang_String_Handler")]
		public virtual unsafe void Delete (string key)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getBytes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBytes_Ljava_lang_String_Handler ()
		{
			if (cb_getBytes_Ljava_lang_String_ == null)
				cb_getBytes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBytes_Ljava_lang_String_);
			return cb_getBytes_Ljava_lang_String_;
		}

		static IntPtr n_GetBytes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASSharedStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASSharedStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetBytes (key));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBytes_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASSharedStorage']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytes", "(Ljava/lang/String;)[B", "GetGetBytes_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] GetBytes (string key)
		{
			if (id_getBytes_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytes_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBytes", "(Ljava/lang/String;)[B");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBytes_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBytes", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASSharedStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASSharedStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (key));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASSharedStorage']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetString (string key)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_save_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_save_Ljava_lang_String_arrayB == null)
				cb_save_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Save_Ljava_lang_String_arrayB);
			return cb_save_Ljava_lang_String_arrayB;
		}

		static void n_Save_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASSharedStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASSharedStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Save (key, value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASSharedStorage']/method[@name='save' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("save", "(Ljava/lang/String;[B)V", "GetSave_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe void Save (string key, byte[] value)
		{
			if (id_save_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_save_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;[B)V");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Ljava_lang_String_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;[B)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_save_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_save_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_save_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Save_Ljava_lang_String_Ljava_lang_String_);
			return cb_save_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Save_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Storage.Sharedstorage.MASSharedStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Sharedstorage.MASSharedStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Save (key, value);
		}
#pragma warning restore 0169

		static IntPtr id_save_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.sharedstorage']/class[@name='MASSharedStorage']/method[@name='save' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("save", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSave_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Save (string key, string value)
		{
			if (id_save_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_save_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
