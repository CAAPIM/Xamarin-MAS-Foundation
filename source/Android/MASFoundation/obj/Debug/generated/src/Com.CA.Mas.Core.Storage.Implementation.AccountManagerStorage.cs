using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Storage.Implementation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']"
	[global::Android.Runtime.Register ("com/ca/mas/core/storage/implementation/AccountManagerStorage", DoNotGenerateAcw=true)]
	public partial class AccountManagerStorage : global::Com.CA.Mas.Core.Storage.Storage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/storage/implementation/AccountManagerStorage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountManagerStorage); }
		}

		protected AccountManagerStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/constructor[@name='AccountManagerStorage' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;)V", "")]
		protected unsafe AccountManagerStorage (global::Java.Lang.Object options)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (options);
				if (((object) this).GetType () != typeof (AccountManagerStorage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static Delegate cb_getAllKeys;
#pragma warning disable 0169
		static Delegate GetGetAllKeysHandler ()
		{
			if (cb_getAllKeys == null)
				cb_getAllKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllKeys);
			return cb_getAllKeys;
		}

		static IntPtr n_GetAllKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AllKeys);
		}
#pragma warning restore 0169

		static IntPtr id_getAllKeys;
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult AllKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='getAllKeys' and count(parameter)=0]"
			[Register ("getAllKeys", "()Lcom/ca/mas/core/storage/StorageResult;", "GetGetAllKeysHandler")]
			get {
				if (id_getAllKeys == IntPtr.Zero)
					id_getAllKeys = JNIEnv.GetMethodID (class_ref, "getAllKeys", "()Lcom/ca/mas/core/storage/StorageResult;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllKeys), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllKeys", "()Lcom/ca/mas/core/storage/StorageResult;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_deleteAll;
#pragma warning disable 0169
		static Delegate GetDeleteAllHandler ()
		{
			if (cb_deleteAll == null)
				cb_deleteAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DeleteAll);
			return cb_deleteAll;
		}

		static IntPtr n_DeleteAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeleteAll ());
		}
#pragma warning restore 0169

		static IntPtr id_deleteAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='deleteAll' and count(parameter)=0]"
		[Register ("deleteAll", "()Lcom/ca/mas/core/storage/StorageResult;", "GetDeleteAllHandler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult DeleteAll ()
		{
			if (id_deleteAll == IntPtr.Zero)
				id_deleteAll = JNIEnv.GetMethodID (class_ref, "deleteAll", "()Lcom/ca/mas/core/storage/StorageResult;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAll", "()Lcom/ca/mas/core/storage/StorageResult;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetDeleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_DeleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAll (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='deleteAll' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("deleteAll", "(Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetDeleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void DeleteAll (global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "deleteAll", "(Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAll", "(Lcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteData_Ljava_lang_String_Handler ()
		{
			if (cb_deleteData_Ljava_lang_String_ == null)
				cb_deleteData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteData_Ljava_lang_String_);
			return cb_deleteData_Ljava_lang_String_;
		}

		static IntPtr n_DeleteData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteData (key));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='deleteData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteData", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "GetDeleteData_Ljava_lang_String_Handler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult DeleteData (string key)
		{
			if (id_deleteData_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteData", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				global::Com.CA.Mas.Core.Storage.StorageResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteData", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetDeleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_DeleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.DeleteData (key, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='deleteData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("deleteData", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetDeleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void DeleteData (string key, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "deleteData", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteData", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_deleteString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteString_Ljava_lang_String_Handler ()
		{
			if (cb_deleteString_Ljava_lang_String_ == null)
				cb_deleteString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteString_Ljava_lang_String_);
			return cb_deleteString_Ljava_lang_String_;
		}

		static IntPtr n_DeleteString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteString (key));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='deleteString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteString", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "GetDeleteString_Ljava_lang_String_Handler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult DeleteString (string key)
		{
			if (id_deleteString_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteString", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				global::Com.CA.Mas.Core.Storage.StorageResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteString", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetDeleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_DeleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.DeleteString (key, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='deleteString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("deleteString", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetDeleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void DeleteString (string key, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "deleteString", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteString", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetGetAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_GetAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetAllKeys (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='getAllKeys' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("getAllKeys", "(Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetGetAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void GetAllKeys (global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "getAllKeys", "(Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllKeys", "(Lcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadData_Ljava_lang_String_Handler ()
		{
			if (cb_readData_Ljava_lang_String_ == null)
				cb_readData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadData_Ljava_lang_String_);
			return cb_readData_Ljava_lang_String_;
		}

		static IntPtr n_ReadData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadData (key));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='readData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readData", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "GetReadData_Ljava_lang_String_Handler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult ReadData (string key)
		{
			if (id_readData_Ljava_lang_String_ == IntPtr.Zero)
				id_readData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readData", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				global::Com.CA.Mas.Core.Storage.StorageResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readData", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetReadData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_ReadData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.ReadData (key, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='readData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("readData", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetReadData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void ReadData (string key, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "readData", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readData", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_readString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadString_Ljava_lang_String_Handler ()
		{
			if (cb_readString_Ljava_lang_String_ == null)
				cb_readString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadString_Ljava_lang_String_);
			return cb_readString_Ljava_lang_String_;
		}

		static IntPtr n_ReadString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReadString (key));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='readString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readString", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "GetReadString_Ljava_lang_String_Handler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult ReadString (string key)
		{
			if (id_readString_Ljava_lang_String_ == IntPtr.Zero)
				id_readString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readString", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				global::Com.CA.Mas.Core.Storage.StorageResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readString", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetReadString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_ReadString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.ReadString (key, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='readString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("readString", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetReadString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void ReadString (string key, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "readString", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readString", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_updateData_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetUpdateData_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_updateData_Ljava_lang_String_arrayB == null)
				cb_updateData_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateData_Ljava_lang_String_arrayB);
			return cb_updateData_Ljava_lang_String_arrayB;
		}

		static IntPtr n_UpdateData_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateData (key, value));
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateData_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='updateData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("updateData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;", "GetUpdateData_Ljava_lang_String_arrayBHandler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult UpdateData (string key, byte[] value)
		{
			if (id_updateData_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_updateData_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "updateData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				global::Com.CA.Mas.Core.Storage.StorageResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateData_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_updateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_updateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_updateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_updateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_UpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.UpdateData (key, value, @callback);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_updateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='updateData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("updateData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void UpdateData (string key, byte[] value, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_updateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_updateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "updateData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_updateString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateString_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_UpdateString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateString (key, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='updateString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "GetUpdateString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult UpdateString (string key, string value)
		{
			if (id_updateString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				global::Com.CA.Mas.Core.Storage.StorageResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_updateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_updateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_updateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_updateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_UpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.UpdateString (key, value, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_updateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='updateString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("updateString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void UpdateString (string key, string value, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_updateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_updateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "updateString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_writeData_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteData_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_writeData_Ljava_lang_String_arrayB == null)
				cb_writeData_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteData_Ljava_lang_String_arrayB);
			return cb_writeData_Ljava_lang_String_arrayB;
		}

		static IntPtr n_WriteData_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteData (key, value));
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_writeData_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='writeData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("writeData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;", "GetWriteData_Ljava_lang_String_arrayBHandler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult WriteData (string key, byte[] value)
		{
			if (id_writeData_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_writeData_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "writeData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				global::Com.CA.Mas.Core.Storage.StorageResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeData_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_writeData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetWriteData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_writeData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_writeData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_writeData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_WriteData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.WriteData (key, value, @callback);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_writeData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='writeData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("writeData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetWriteData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void WriteData (string key, byte[] value, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_writeData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_writeData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "writeData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_writeOrUpdateData_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteOrUpdateData_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_writeOrUpdateData_Ljava_lang_String_arrayB == null)
				cb_writeOrUpdateData_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteOrUpdateData_Ljava_lang_String_arrayB);
			return cb_writeOrUpdateData_Ljava_lang_String_arrayB;
		}

		static IntPtr n_WriteOrUpdateData_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteOrUpdateData (key, value));
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_writeOrUpdateData_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='writeOrUpdateData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("writeOrUpdateData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;", "GetWriteOrUpdateData_Ljava_lang_String_arrayBHandler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult WriteOrUpdateData (string key, byte[] value)
		{
			if (id_writeOrUpdateData_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_writeOrUpdateData_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "writeOrUpdateData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				global::Com.CA.Mas.Core.Storage.StorageResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeOrUpdateData_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeOrUpdateData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_writeOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetWriteOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_writeOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_writeOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_writeOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_WriteOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.WriteOrUpdateData (key, value, @callback);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_writeOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='writeOrUpdateData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("writeOrUpdateData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetWriteOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void WriteOrUpdateData (string key, byte[] value, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_writeOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_writeOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "writeOrUpdateData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeOrUpdateData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteOrUpdateString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteOrUpdateString_Ljava_lang_String_Ljava_lang_String_);
			return cb_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_WriteOrUpdateString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteOrUpdateString (key, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='writeOrUpdateString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeOrUpdateString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "GetWriteOrUpdateString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult WriteOrUpdateString (string key, string value)
		{
			if (id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeOrUpdateString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				global::Com.CA.Mas.Core.Storage.StorageResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeOrUpdateString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetWriteOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_WriteOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.WriteOrUpdateString (key, value, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='writeOrUpdateString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("writeOrUpdateString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetWriteOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void WriteOrUpdateString (string key, string value, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "writeOrUpdateString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeOrUpdateString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_writeString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_writeString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_writeString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteString_Ljava_lang_String_Ljava_lang_String_);
			return cb_writeString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_WriteString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WriteString (key, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_writeString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='writeString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "GetWriteString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult WriteString (string key, string value)
		{
			if (id_writeString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_writeString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				global::Com.CA.Mas.Core.Storage.StorageResult __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_writeString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
#pragma warning disable 0169
		static Delegate GetWriteString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler ()
		{
			if (cb_writeString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == null)
				cb_writeString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_);
			return cb_writeString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		}

		static void n_WriteString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.AccountManagerStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResultReceiver> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.WriteString (key, value, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_writeString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='AccountManagerStorage']/method[@name='writeString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("writeString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "GetWriteString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_Handler")]
		public override unsafe void WriteString (string key, string value, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_writeString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_writeString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "writeString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
