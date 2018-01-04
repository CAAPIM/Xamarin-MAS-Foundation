using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Datasource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='StringDataConverter']"
	[global::Android.Runtime.Register ("com/ca/mas/core/datasource/StringDataConverter", DoNotGenerateAcw=true)]
	public partial class StringDataConverter : global::Java.Lang.Object, global::Com.CA.Mas.Core.Datasource.IDataConverter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/datasource/StringDataConverter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringDataConverter); }
		}

		protected StringDataConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='StringDataConverter']/constructor[@name='StringDataConverter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringDataConverter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StringDataConverter)) {
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

		static Delegate cb_convert_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetConvert_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_convert_Ljava_lang_String_arrayB == null)
				cb_convert_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Convert_Ljava_lang_String_arrayB);
			return cb_convert_Ljava_lang_String_arrayB;
		}

		static IntPtr n_Convert_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Datasource.StringDataConverter __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.StringDataConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			byte[] value = (byte[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.Convert (key, value));
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_convert_Ljava_lang_String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='StringDataConverter']/method[@name='convert' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("convert", "(Ljava/lang/String;[B)Ljava/lang/String;", "GetConvert_Ljava_lang_String_arrayBHandler")]
		public virtual unsafe string Convert (string key, byte[] value)
		{
			if (id_convert_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_convert_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "convert", "(Ljava/lang/String;[B)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convert_Ljava_lang_String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convert", "(Ljava/lang/String;[B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.CA.Mas.Core.Datasource.IDataConverter
		global::Java.Lang.Object global::Com.CA.Mas.Core.Datasource.IDataConverter.Convert (global::Java.Lang.Object p0, byte[] p1)
		{
			return Convert (p0.ToString (), p1).ToString ();
		}

	}
}
