using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='sun.security.util']/interface[@name='DerEncoder']"
	[Register ("sun/security/util/DerEncoder", "", "Sun.Security.Util.IDerEncoderInvoker")]
	public partial interface IDerEncoder : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/interface[@name='DerEncoder']/method[@name='derEncode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("derEncode", "(Ljava/io/OutputStream;)V", "GetDerEncode_Ljava_io_OutputStream_Handler:Sun.Security.Util.IDerEncoderInvoker, MASFoundation")]
		void DerEncode (global::System.IO.Stream p0);

	}

	[global::Android.Runtime.Register ("sun/security/util/DerEncoder", DoNotGenerateAcw=true)]
	internal class IDerEncoderInvoker : global::Java.Lang.Object, IDerEncoder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("sun/security/util/DerEncoder");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDerEncoderInvoker); }
		}

		IntPtr class_ref;

		public static IDerEncoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDerEncoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "sun.security.util.DerEncoder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDerEncoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_derEncode_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDerEncode_Ljava_io_OutputStream_Handler ()
		{
			if (cb_derEncode_Ljava_io_OutputStream_ == null)
				cb_derEncode_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DerEncode_Ljava_io_OutputStream_);
			return cb_derEncode_Ljava_io_OutputStream_;
		}

		static void n_DerEncode_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Security.Util.IDerEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.IDerEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DerEncode (p0);
		}
#pragma warning restore 0169

		IntPtr id_derEncode_Ljava_io_OutputStream_;
		public unsafe void DerEncode (global::System.IO.Stream p0)
		{
			if (id_derEncode_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_derEncode_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "derEncode", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_derEncode_Ljava_io_OutputStream_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
