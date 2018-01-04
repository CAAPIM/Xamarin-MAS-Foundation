using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Storage.Implementation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='MASStorageManager']"
	[global::Android.Runtime.Register ("com/ca/mas/core/storage/implementation/MASStorageManager", DoNotGenerateAcw=true)]
	public partial class MASStorageManager : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='MASStorageManager.MASStorageType']"
		[global::Android.Runtime.Register ("com/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType", DoNotGenerateAcw=true)]
		public sealed partial class MASStorageType : global::Java.Lang.Enum {


			static IntPtr TYPE_AMS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='MASStorageManager.MASStorageType']/field[@name='TYPE_AMS']"
			[Register ("TYPE_AMS")]
			public static global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType TypeAms {
				get {
					if (TYPE_AMS_jfieldId == IntPtr.Zero)
						TYPE_AMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_AMS", "Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_AMS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TYPE_KEYSTORE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='MASStorageManager.MASStorageType']/field[@name='TYPE_KEYSTORE']"
			[Register ("TYPE_KEYSTORE")]
			public static global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType TypeKeystore {
				get {
					if (TYPE_KEYSTORE_jfieldId == IntPtr.Zero)
						TYPE_KEYSTORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_KEYSTORE", "Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TYPE_KEYSTORE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MASStorageType); }
			}

			internal MASStorageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='MASStorageManager.MASStorageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;", "")]
			public static unsafe global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='MASStorageManager.MASStorageType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;", "")]
			public static unsafe global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;");
				try {
					return (global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/storage/implementation/MASStorageManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASStorageManager); }
		}

		protected MASStorageManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='MASStorageManager']/constructor[@name='MASStorageManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASStorageManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASStorageManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_Handler ()
		{
			if (cb_getStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_ == null)
				cb_getStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_);
			return cb_getStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_;
		}

		static IntPtr n_GetStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_options)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType type = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType> (native_type, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object options = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStorage (type, options));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='MASStorageManager']/method[@name='getStorage' and count(parameter)=2 and parameter[1][@type='com.ca.mas.core.storage.implementation.MASStorageManager.MASStorageType'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStorage", "(Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;Ljava/lang/Object;)Lcom/ca/mas/core/storage/Storage;", "GetGetStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.CA.Mas.Core.Storage.Storage GetStorage (global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager.MASStorageType type, global::Java.Lang.Object options)
		{
			if (id_getStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStorage", "(Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;Ljava/lang/Object;)Lcom/ca/mas/core/storage/Storage;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (type);
				__args [1] = new JValue (options);

				global::Com.CA.Mas.Core.Storage.Storage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Storage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStorage_Lcom_ca_mas_core_storage_implementation_MASStorageManager_MASStorageType_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Storage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStorage", "(Lcom/ca/mas/core/storage/implementation/MASStorageManager$MASStorageType;Ljava/lang/Object;)Lcom/ca/mas/core/storage/Storage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getStorage_Ljava_lang_Class_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStorage_Ljava_lang_Class_Ljava_lang_Object_Handler ()
		{
			if (cb_getStorage_Ljava_lang_Class_Ljava_lang_Object_ == null)
				cb_getStorage_Ljava_lang_Class_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStorage_Ljava_lang_Class_Ljava_lang_Object_);
			return cb_getStorage_Ljava_lang_Class_Ljava_lang_Object_;
		}

		static IntPtr n_GetStorage_Ljava_lang_Class_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_options)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class c = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object options = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStorage (c, options));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStorage_Ljava_lang_Class_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='MASStorageManager']/method[@name='getStorage' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends com.ca.mas.core.storage.Storage&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStorage", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/ca/mas/core/storage/Storage;", "GetGetStorage_Ljava_lang_Class_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.CA.Mas.Core.Storage.Storage GetStorage (global::Java.Lang.Class c, global::Java.Lang.Object options)
		{
			if (id_getStorage_Ljava_lang_Class_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStorage_Ljava_lang_Class_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStorage", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/ca/mas/core/storage/Storage;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (c);
				__args [1] = new JValue (options);

				global::Com.CA.Mas.Core.Storage.Storage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Storage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStorage_Ljava_lang_Class_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Storage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStorage", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/ca/mas/core/storage/Storage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getStorage_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetStorage_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_getStorage_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_getStorage_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStorage_Ljava_lang_String_Ljava_lang_Object_);
			return cb_getStorage_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_GetStorage_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_className, IntPtr native_options)
		{
			global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Implementation.MASStorageManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string className = JNIEnv.GetString (native_className, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object options = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStorage (className, options));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStorage_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage.implementation']/class[@name='MASStorageManager']/method[@name='getStorage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("getStorage", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/ca/mas/core/storage/Storage;", "GetGetStorage_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.CA.Mas.Core.Storage.Storage GetStorage (string className, global::Java.Lang.Object options)
		{
			if (id_getStorage_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_getStorage_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getStorage", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/ca/mas/core/storage/Storage;");
			IntPtr native_className = JNIEnv.NewString (className);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_className);
				__args [1] = new JValue (options);

				global::Com.CA.Mas.Core.Storage.Storage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Storage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStorage_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.Storage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStorage", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/ca/mas/core/storage/Storage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
			}
		}

	}
}
