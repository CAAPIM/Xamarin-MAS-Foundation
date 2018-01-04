using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Storage.Implementation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']"
	[global::Android.Runtime.Register ("com/ca/mas/core/storage/implementation/KeyStoreStorage", DoNotGenerateAcw=true)]
	public sealed partial class KeyStoreStorage : global::Com.CA.Mas.Core.Storage.Storage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/storage/implementation/KeyStoreStorage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyStoreStorage); }
		}

		internal KeyStoreStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAllKeys;
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult AllKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='getAllKeys' and count(parameter)=0]"
			[Register ("getAllKeys", "()Lcom/ca/mas/core/storage/StorageResult;", "GetGetAllKeysHandler")]
			get {
				if (id_getAllKeys == IntPtr.Zero)
					id_getAllKeys = JNIEnv.GetMethodID (class_ref, "getAllKeys", "()Lcom/ca/mas/core/storage/StorageResult;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllKeys), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getType;
		public override unsafe global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_deleteAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='deleteAll' and count(parameter)=0]"
		[Register ("deleteAll", "()Lcom/ca/mas/core/storage/StorageResult;", "")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult DeleteAll ()
		{
			if (id_deleteAll == IntPtr.Zero)
				id_deleteAll = JNIEnv.GetMethodID (class_ref, "deleteAll", "()Lcom/ca/mas/core/storage/StorageResult;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='deleteAll' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("deleteAll", "(Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
		public override unsafe void DeleteAll (global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "deleteAll", "(Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
			}
		}

		static IntPtr id_deleteData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='deleteData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteData", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult DeleteData (string key)
		{
			if (id_deleteData_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteData", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Com.CA.Mas.Core.Storage.StorageResult __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='deleteData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("deleteData", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
		public override unsafe void DeleteData (string key, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "deleteData", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (@callback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_deleteString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='deleteString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteString", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult DeleteString (string key)
		{
			if (id_deleteString_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteString", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Com.CA.Mas.Core.Storage.StorageResult __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='deleteString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("deleteString", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
		public override unsafe void DeleteString (string key, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "deleteString", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (@callback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='getAllKeys' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("getAllKeys", "(Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
		public override unsafe void GetAllKeys (global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "getAllKeys", "(Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAllKeys_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
			}
		}

		static IntPtr id_readData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='readData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readData", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult ReadData (string key)
		{
			if (id_readData_Ljava_lang_String_ == IntPtr.Zero)
				id_readData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readData", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Com.CA.Mas.Core.Storage.StorageResult __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='readData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("readData", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
		public override unsafe void ReadData (string key, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "readData", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (@callback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readData_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_readString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='readString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readString", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "")]
		public override unsafe global::Com.CA.Mas.Core.Storage.StorageResult ReadString (string key)
		{
			if (id_readString_Ljava_lang_String_ == IntPtr.Zero)
				id_readString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readString", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);
				global::Com.CA.Mas.Core.Storage.StorageResult __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='readString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("readString", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
		public override unsafe void ReadString (string key, global::Com.CA.Mas.Core.Storage.StorageResultReceiver @callback)
		{
			if (id_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ == IntPtr.Zero)
				id_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_ = JNIEnv.GetMethodID (class_ref, "readString", "(Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (@callback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readString_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static IntPtr id_updateData_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='updateData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("updateData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;", "")]
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
				global::Com.CA.Mas.Core.Storage.StorageResult __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateData_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_updateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='updateData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("updateData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_updateString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='updateString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "")]
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
				global::Com.CA.Mas.Core.Storage.StorageResult __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_updateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='updateString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("updateString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_writeData_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='writeData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("writeData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;", "")]
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
				global::Com.CA.Mas.Core.Storage.StorageResult __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeData_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_writeData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='writeData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("writeData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_writeOrUpdateData_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='writeOrUpdateData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("writeOrUpdateData", "(Ljava/lang/String;[B)Lcom/ca/mas/core/storage/StorageResult;", "")]
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
				global::Com.CA.Mas.Core.Storage.StorageResult __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeOrUpdateData_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_writeOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='writeOrUpdateData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("writeOrUpdateData", "(Ljava/lang/String;[BLcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeOrUpdateData_Ljava_lang_String_arrayBLcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='writeOrUpdateString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeOrUpdateString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "")]
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
				global::Com.CA.Mas.Core.Storage.StorageResult __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='writeOrUpdateString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("writeOrUpdateString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeOrUpdateString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_writeString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='writeString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult;", "")]
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
				global::Com.CA.Mas.Core.Storage.StorageResult __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_writeString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='KeyStoreStorage']/method[@name='writeString' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ca.mas.core.storage.StorageResultReceiver']]"
		[Register ("writeString", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/core/storage/StorageResultReceiver;)V", "")]
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeString_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_core_storage_StorageResultReceiver_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
