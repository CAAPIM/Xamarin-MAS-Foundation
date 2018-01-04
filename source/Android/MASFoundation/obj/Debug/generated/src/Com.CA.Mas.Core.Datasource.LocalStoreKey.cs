using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Datasource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreKey']"
	[global::Android.Runtime.Register ("com/ca/mas/core/datasource/LocalStoreKey", DoNotGenerateAcw=true)]
	public partial class LocalStoreKey : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/datasource/LocalStoreKey", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalStoreKey); }
		}

		protected LocalStoreKey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreKey']/constructor[@name='LocalStoreKey' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V", "")]
		public unsafe LocalStoreKey (string key, global::Java.Lang.Integer segment, string createdBy)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_createdBy = JNIEnv.NewString (createdBy);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (segment);
				__args [2] = new JValue (native_createdBy);
				if (((object) this).GetType () != typeof (LocalStoreKey)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_createdBy);
			}
		}

		static Delegate cb_getCreatedBy;
#pragma warning disable 0169
		static Delegate GetGetCreatedByHandler ()
		{
			if (cb_getCreatedBy == null)
				cb_getCreatedBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedBy);
			return cb_getCreatedBy;
		}

		static IntPtr n_GetCreatedBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreKey __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreatedBy);
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedBy;
		public virtual unsafe string CreatedBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreKey']/method[@name='getCreatedBy' and count(parameter)=0]"
			[Register ("getCreatedBy", "()Ljava/lang/String;", "GetGetCreatedByHandler")]
			get {
				if (id_getCreatedBy == IntPtr.Zero)
					id_getCreatedBy = JNIEnv.GetMethodID (class_ref, "getCreatedBy", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreatedBy), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreatedBy", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreKey __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreKey']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSegment;
#pragma warning disable 0169
		static Delegate GetGetSegmentHandler ()
		{
			if (cb_getSegment == null)
				cb_getSegment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSegment);
			return cb_getSegment;
		}

		static IntPtr n_GetSegment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreKey __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreKey> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Segment);
		}
#pragma warning restore 0169

		static IntPtr id_getSegment;
		public virtual unsafe global::Java.Lang.Integer Segment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreKey']/method[@name='getSegment' and count(parameter)=0]"
			[Register ("getSegment", "()Ljava/lang/Integer;", "GetGetSegmentHandler")]
			get {
				if (id_getSegment == IntPtr.Zero)
					id_getSegment = JNIEnv.GetMethodID (class_ref, "getSegment", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSegment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSegment", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
