using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Misc {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.misc']/class[@name='BASE64Encoder']"
	[global::Android.Runtime.Register ("sun/misc/BASE64Encoder", DoNotGenerateAcw=true)]
	public partial class BASE64Encoder : global::Sun.Misc.CharacterEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/misc/BASE64Encoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BASE64Encoder); }
		}

		protected BASE64Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.misc']/class[@name='BASE64Encoder']/constructor[@name='BASE64Encoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BASE64Encoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BASE64Encoder)) {
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

		static Delegate cb_bytesPerAtom;
#pragma warning disable 0169
		static Delegate GetBytesPerAtomHandler ()
		{
			if (cb_bytesPerAtom == null)
				cb_bytesPerAtom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BytesPerAtom);
			return cb_bytesPerAtom;
		}

		static int n_BytesPerAtom (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Misc.BASE64Encoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.BASE64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesPerAtom ();
		}
#pragma warning restore 0169

		static IntPtr id_bytesPerAtom;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='BASE64Encoder']/method[@name='bytesPerAtom' and count(parameter)=0]"
		[Register ("bytesPerAtom", "()I", "GetBytesPerAtomHandler")]
		protected override unsafe int BytesPerAtom ()
		{
			if (id_bytesPerAtom == IntPtr.Zero)
				id_bytesPerAtom = JNIEnv.GetMethodID (class_ref, "bytesPerAtom", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_bytesPerAtom);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bytesPerAtom", "()I"));
			} finally {
			}
		}

		static Delegate cb_bytesPerLine;
#pragma warning disable 0169
		static Delegate GetBytesPerLineHandler ()
		{
			if (cb_bytesPerLine == null)
				cb_bytesPerLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BytesPerLine);
			return cb_bytesPerLine;
		}

		static int n_BytesPerLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Misc.BASE64Encoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.BASE64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesPerLine ();
		}
#pragma warning restore 0169

		static IntPtr id_bytesPerLine;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='BASE64Encoder']/method[@name='bytesPerLine' and count(parameter)=0]"
		[Register ("bytesPerLine", "()I", "GetBytesPerLineHandler")]
		protected override unsafe int BytesPerLine ()
		{
			if (id_bytesPerLine == IntPtr.Zero)
				id_bytesPerLine = JNIEnv.GetMethodID (class_ref, "bytesPerLine", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_bytesPerLine);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bytesPerLine", "()I"));
			} finally {
			}
		}

		static Delegate cb_encodeAtom_Ljava_io_OutputStream_arrayBII;
#pragma warning disable 0169
		static Delegate GetEncodeAtom_Ljava_io_OutputStream_arrayBIIHandler ()
		{
			if (cb_encodeAtom_Ljava_io_OutputStream_arrayBII == null)
				cb_encodeAtom_Ljava_io_OutputStream_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_EncodeAtom_Ljava_io_OutputStream_arrayBII);
			return cb_encodeAtom_Ljava_io_OutputStream_arrayBII;
		}

		static void n_EncodeAtom_Ljava_io_OutputStream_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_outStream, IntPtr native_data, int offset, int len)
		{
			global::Sun.Misc.BASE64Encoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.BASE64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream outStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_outStream, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.EncodeAtom (outStream, data, offset, len);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		static IntPtr id_encodeAtom_Ljava_io_OutputStream_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='BASE64Encoder']/method[@name='encodeAtom' and count(parameter)=4 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encodeAtom", "(Ljava/io/OutputStream;[BII)V", "GetEncodeAtom_Ljava_io_OutputStream_arrayBIIHandler")]
		protected override unsafe void EncodeAtom (global::System.IO.Stream outStream, byte[] data, int offset, int len)
		{
			if (id_encodeAtom_Ljava_io_OutputStream_arrayBII == IntPtr.Zero)
				id_encodeAtom_Ljava_io_OutputStream_arrayBII = JNIEnv.GetMethodID (class_ref, "encodeAtom", "(Ljava/io/OutputStream;[BII)V");
			IntPtr native_outStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outStream);
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_outStream);
				__args [1] = new JValue (native_data);
				__args [2] = new JValue (offset);
				__args [3] = new JValue (len);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeAtom_Ljava_io_OutputStream_arrayBII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeAtom", "(Ljava/io/OutputStream;[BII)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_outStream);
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

	}
}
