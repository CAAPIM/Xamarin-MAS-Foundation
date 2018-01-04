using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Datasource {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataConverter']"
	[Register ("com/ca/mas/core/datasource/DataConverter", "", "Com.CA.Mas.Core.Datasource.IDataConverterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial interface IDataConverter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataConverter']/method[@name='convert' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='byte[]']]"
		[Register ("convert", "(Ljava/lang/Object;[B)Ljava/lang/Object;", "GetConvert_Ljava_lang_Object_arrayBHandler:Com.CA.Mas.Core.Datasource.IDataConverterInvoker, MASFoundation")]
		global::Java.Lang.Object Convert (global::Java.Lang.Object p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/datasource/DataConverter", DoNotGenerateAcw=true)]
	internal class IDataConverterInvoker : global::Java.Lang.Object, IDataConverter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/datasource/DataConverter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDataConverterInvoker); }
		}

		IntPtr class_ref;

		public static IDataConverter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataConverter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.datasource.DataConverter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataConverterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_convert_Ljava_lang_Object_arrayB;
#pragma warning disable 0169
		static Delegate GetConvert_Ljava_lang_Object_arrayBHandler ()
		{
			if (cb_convert_Ljava_lang_Object_arrayB == null)
				cb_convert_Ljava_lang_Object_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Convert_Ljava_lang_Object_arrayB);
			return cb_convert_Ljava_lang_Object_arrayB;
		}

		static IntPtr n_Convert_Ljava_lang_Object_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Core.Datasource.IDataConverter __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataConverter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Convert (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_convert_Ljava_lang_Object_arrayB;
		public unsafe global::Java.Lang.Object Convert (global::Java.Lang.Object p0, byte[] p1)
		{
			if (id_convert_Ljava_lang_Object_arrayB == IntPtr.Zero)
				id_convert_Ljava_lang_Object_arrayB = JNIEnv.GetMethodID (class_ref, "convert", "(Ljava/lang/Object;[B)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convert_Ljava_lang_Object_arrayB, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

	}

}
