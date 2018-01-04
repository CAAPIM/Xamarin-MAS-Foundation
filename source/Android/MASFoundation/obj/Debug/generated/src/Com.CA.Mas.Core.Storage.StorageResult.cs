using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']"
	[global::Android.Runtime.Register ("com/ca/mas/core/storage/StorageResult", DoNotGenerateAcw=true)]
	public partial class StorageResult : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationStatus']"
		[global::Android.Runtime.Register ("com/ca/mas/core/storage/StorageResult$StorageOperationStatus", DoNotGenerateAcw=true)]
		public sealed partial class StorageOperationStatus : global::Java.Lang.Enum {


			static IntPtr FAILURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationStatus']/field[@name='FAILURE']"
			[Register ("FAILURE")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus Failure {
				get {
					if (FAILURE_jfieldId == IntPtr.Zero)
						FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILURE", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUCCESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationStatus']/field[@name='SUCCESS']"
			[Register ("SUCCESS")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus Success {
				get {
					if (SUCCESS_jfieldId == IntPtr.Zero)
						SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/core/storage/StorageResult$StorageOperationStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StorageOperationStatus); }
			}

			internal StorageOperationStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;", "")]
			public static unsafe global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;", "")]
			public static unsafe global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;");
				try {
					return (global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']"
		[global::Android.Runtime.Register ("com/ca/mas/core/storage/StorageResult$StorageOperationType", DoNotGenerateAcw=true)]
		public sealed partial class StorageOperationType : global::Java.Lang.Enum {


			static IntPtr DELETE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='DELETE']"
			[Register ("DELETE")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType Delete {
				get {
					if (DELETE_jfieldId == IntPtr.Zero)
						DELETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELETE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DELETE_ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='DELETE_ALL']"
			[Register ("DELETE_ALL")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType DeleteAll {
				get {
					if (DELETE_ALL_jfieldId == IntPtr.Zero)
						DELETE_ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE_ALL", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELETE_ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DELETE_STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='DELETE_STRING']"
			[Register ("DELETE_STRING")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType DeleteString {
				get {
					if (DELETE_STRING_jfieldId == IntPtr.Zero)
						DELETE_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE_STRING", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELETE_STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GET_ALL_KEYS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='GET_ALL_KEYS']"
			[Register ("GET_ALL_KEYS")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType GetAllKeys {
				get {
					if (GET_ALL_KEYS_jfieldId == IntPtr.Zero)
						GET_ALL_KEYS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_ALL_KEYS", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_ALL_KEYS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='READ']"
			[Register ("READ")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType Read {
				get {
					if (READ_jfieldId == IntPtr.Zero)
						READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr READ_STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='READ_STRING']"
			[Register ("READ_STRING")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType ReadString {
				get {
					if (READ_STRING_jfieldId == IntPtr.Zero)
						READ_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ_STRING", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UPDATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='UPDATE']"
			[Register ("UPDATE")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType Update {
				get {
					if (UPDATE_jfieldId == IntPtr.Zero)
						UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPDATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UPDATE_STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='UPDATE_STRING']"
			[Register ("UPDATE_STRING")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType UpdateString {
				get {
					if (UPDATE_STRING_jfieldId == IntPtr.Zero)
						UPDATE_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE_STRING", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPDATE_STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WRITE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='WRITE']"
			[Register ("WRITE")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType Write {
				get {
					if (WRITE_jfieldId == IntPtr.Zero)
						WRITE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WRITE", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WRITE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WRITE_OR_UPDATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='WRITE_OR_UPDATE']"
			[Register ("WRITE_OR_UPDATE")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType WriteOrUpdate {
				get {
					if (WRITE_OR_UPDATE_jfieldId == IntPtr.Zero)
						WRITE_OR_UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WRITE_OR_UPDATE", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WRITE_OR_UPDATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WRITE_OR_UPDATE_STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='WRITE_OR_UPDATE_STRING']"
			[Register ("WRITE_OR_UPDATE_STRING")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType WriteOrUpdateString {
				get {
					if (WRITE_OR_UPDATE_STRING_jfieldId == IntPtr.Zero)
						WRITE_OR_UPDATE_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WRITE_OR_UPDATE_STRING", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WRITE_OR_UPDATE_STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WRITE_STRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/field[@name='WRITE_STRING']"
			[Register ("WRITE_STRING")]
			public static global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType WriteString {
				get {
					if (WRITE_STRING_jfieldId == IntPtr.Zero)
						WRITE_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WRITE_STRING", "Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WRITE_STRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/core/storage/StorageResult$StorageOperationType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StorageOperationType); }
			}

			internal StorageOperationType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;", "")]
			public static unsafe global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult.StorageOperationType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;", "")]
			public static unsafe global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
				try {
					return (global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/storage/StorageResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StorageResult); }
		}

		protected StorageResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']/constructor[@name='StorageResult' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.storage.StorageResult.StorageOperationType']]"
		[Register (".ctor", "(Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;)V", "")]
		public unsafe StorageResult (global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				if (((object) this).GetType () != typeof (StorageResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_, __args);
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Storage.StorageResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_lang_Object_Handler ()
		{
			if (cb_setData_Ljava_lang_Object_ == null)
				cb_setData_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_lang_Object_);
			return cb_setData_Ljava_lang_Object_;
		}

		static void n_SetData_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.CA.Mas.Core.Storage.StorageResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object data = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.Data = data;
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		static IntPtr id_setData_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/Object;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setData", "(Ljava/lang/Object;)V", "GetSetData_Ljava_lang_Object_Handler")]
			set {
				if (id_setData_Ljava_lang_Object_ == IntPtr.Zero)
					id_setData_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/lang/Object;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Storage.StorageResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_Handler ()
		{
			if (cb_setStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_ == null)
				cb_setStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_);
			return cb_setStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_;
		}

		static void n_SetStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_status)
		{
			global::Com.CA.Mas.Core.Storage.StorageResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus status = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus> (native_status, JniHandleOwnership.DoNotTransfer);
			__this.Status = status;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_;
		public virtual unsafe global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.storage.StorageResult.StorageOperationStatus']]"
			[Register ("setStatus", "(Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;)V", "GetSetStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_Handler")]
			set {
				if (id_setStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_ == IntPtr.Zero)
					id_setStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatus_Lcom_ca_mas_core_storage_StorageResult_StorageOperationStatus_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Lcom/ca/mas/core/storage/StorageResult$StorageOperationStatus;)V"), __args);
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
			global::Com.CA.Mas.Core.Storage.StorageResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_Handler ()
		{
			if (cb_setType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_ == null)
				cb_setType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_);
			return cb_setType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_;
		}

		static void n_SetType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.CA.Mas.Core.Storage.StorageResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType type = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.Type = type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_;
		public virtual unsafe global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult.StorageOperationType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.storage.StorageResult.StorageOperationType']]"
			[Register ("setType", "(Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;)V", "GetSetType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_Handler")]
			set {
				if (id_setType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_ == IntPtr.Zero)
					id_setType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_ = JNIEnv.GetMethodID (class_ref, "setType", "(Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Lcom_ca_mas_core_storage_StorageResult_StorageOperationType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Lcom/ca/mas/core/storage/StorageResult$StorageOperationType;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Storage.StorageResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.CA.Mas.Core.Storage.StorageResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageResult']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
