using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Storage {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']"
	[global::Android.Runtime.Register ("com/ca/mas/core/storage/StorageException", DoNotGenerateAcw=true)]
	public partial class StorageException : global::Java.Lang.Exception, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='DATA_SIZE_LIMIT_EXCEEDED']"
		[Register ("DATA_SIZE_LIMIT_EXCEEDED")]
		public const int DataSizeLimitExceeded = (int) 114;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='DO_NOT_USE']"
		[Register ("DO_NOT_USE")]
		public const int DoNotUse = (int) 107;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='INSTANTIATION_ERROR']"
		[Register ("INSTANTIATION_ERROR")]
		public const int InstantiationError = (int) 106;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='INSTANTIATION_ERROR_UNAUTHORIZED']"
		[Register ("INSTANTIATION_ERROR_UNAUTHORIZED")]
		public const int InstantiationErrorUnauthorized = (int) 115;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='INVALID_INPUT']"
		[Register ("INVALID_INPUT")]
		public const int InvalidInput = (int) 111;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='INVALID_INPUT_CALLBACK']"
		[Register ("INVALID_INPUT_CALLBACK")]
		public const int InvalidInputCallback = (int) 103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='INVALID_INPUT_KEY']"
		[Register ("INVALID_INPUT_KEY")]
		public const int InvalidInputKey = (int) 101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='INVALID_INPUT_VALUE']"
		[Register ("INVALID_INPUT_VALUE")]
		public const int InvalidInputValue = (int) 102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='KEYSTORE_DATA_SIZE_LIMIT_EXCEEDED']"
		[Register ("KEYSTORE_DATA_SIZE_LIMIT_EXCEEDED")]
		public const int KeystoreDataSizeLimitExceeded = (int) 152;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='KEYSTORE_KEY_SIZE_LIMIT_EXCEEDED']"
		[Register ("KEYSTORE_KEY_SIZE_LIMIT_EXCEEDED")]
		public const int KeystoreKeySizeLimitExceeded = (int) 151;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='KEY_SIZE_LIMIT_EXCEEDED']"
		[Register ("KEY_SIZE_LIMIT_EXCEEDED")]
		public const int KeySizeLimitExceeded = (int) 113;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='OPERATION_FAILED']"
		[Register ("OPERATION_FAILED")]
		public const int OperationFailed = (int) 110;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='READ_DATA_NOT_FOUND']"
		[Register ("READ_DATA_NOT_FOUND")]
		public const int ReadDataNotFound = (int) 105;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='STORE_NOT_FOUND']"
		[Register ("STORE_NOT_FOUND")]
		public const int StoreNotFound = (int) 108;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='STORE_NOT_UNLOCKED']"
		[Register ("STORE_NOT_UNLOCKED")]
		public const int StoreNotUnlocked = (int) 153;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public const int UnknownError = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='UNSUPPORTED_DATA']"
		[Register ("UNSUPPORTED_DATA")]
		public const int UnsupportedData = (int) 109;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='UNSUPPORTED_OPERATION']"
		[Register ("UNSUPPORTED_OPERATION")]
		public const int UnsupportedOperation = (int) 112;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/field[@name='WRITE_DATA_ALREADY_EXISTS']"
		[Register ("WRITE_DATA_ALREADY_EXISTS")]
		public const int WriteDataAlreadyExists = (int) 104;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/storage/StorageException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StorageException); }
		}

		protected StorageException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/constructor[@name='StorageException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe StorageException (int code)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (code);
				if (((object) this).GetType () != typeof (StorageException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/constructor[@name='StorageException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;I)V", "")]
		public unsafe StorageException (string detailMessage, global::Java.Lang.Throwable throwable, int code)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_detailMessage = JNIEnv.NewString (detailMessage);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_detailMessage);
				__args [1] = new JValue (throwable);
				__args [2] = new JValue (code);
				if (((object) this).GetType () != typeof (StorageException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Throwable;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;Ljava/lang/Throwable;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Throwable_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Throwable_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_detailMessage);
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCode);
			return cb_getCode;
		}

		static int n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Storage.StorageException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		public virtual unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Throwable) this).Handle, id_getCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()I"));
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
			global::Com.CA.Mas.Core.Storage.StorageException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Throwable) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
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

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_destination, int native_flags)
		{
			global::Com.CA.Mas.Core.Storage.StorageException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Storage.StorageException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel destination = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_destination, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (destination, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.storage']/class[@name='StorageException']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel destination, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (destination);
				__args [1] = new JValue ((int) flags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Throwable) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
