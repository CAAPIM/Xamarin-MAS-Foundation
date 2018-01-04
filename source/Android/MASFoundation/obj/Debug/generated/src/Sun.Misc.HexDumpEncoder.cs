using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Misc {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.misc']/class[@name='HexDumpEncoder']"
	[global::Android.Runtime.Register ("sun/misc/HexDumpEncoder", DoNotGenerateAcw=true)]
	public partial class HexDumpEncoder : global::Sun.Misc.CharacterEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/misc/HexDumpEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HexDumpEncoder); }
		}

		protected HexDumpEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.misc']/class[@name='HexDumpEncoder']/constructor[@name='HexDumpEncoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HexDumpEncoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HexDumpEncoder)) {
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
			global::Sun.Misc.HexDumpEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.HexDumpEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesPerAtom ();
		}
#pragma warning restore 0169

		static IntPtr id_bytesPerAtom;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='HexDumpEncoder']/method[@name='bytesPerAtom' and count(parameter)=0]"
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
			global::Sun.Misc.HexDumpEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.HexDumpEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesPerLine ();
		}
#pragma warning restore 0169

		static IntPtr id_bytesPerLine;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='HexDumpEncoder']/method[@name='bytesPerLine' and count(parameter)=0]"
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

		static void n_EncodeAtom_Ljava_io_OutputStream_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_o, IntPtr native_buf, int off, int len)
		{
			global::Sun.Misc.HexDumpEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.HexDumpEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream o = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_o, JniHandleOwnership.DoNotTransfer);
			byte[] buf = (byte[]) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.EncodeAtom (o, buf, off, len);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
		}
#pragma warning restore 0169

		static IntPtr id_encodeAtom_Ljava_io_OutputStream_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='HexDumpEncoder']/method[@name='encodeAtom' and count(parameter)=4 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encodeAtom", "(Ljava/io/OutputStream;[BII)V", "GetEncodeAtom_Ljava_io_OutputStream_arrayBIIHandler")]
		protected override unsafe void EncodeAtom (global::System.IO.Stream o, byte[] buf, int off, int len)
		{
			if (id_encodeAtom_Ljava_io_OutputStream_arrayBII == IntPtr.Zero)
				id_encodeAtom_Ljava_io_OutputStream_arrayBII = JNIEnv.GetMethodID (class_ref, "encodeAtom", "(Ljava/io/OutputStream;[BII)V");
			IntPtr native_o = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (o);
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_o);
				__args [1] = new JValue (native_buf);
				__args [2] = new JValue (off);
				__args [3] = new JValue (len);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeAtom_Ljava_io_OutputStream_arrayBII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeAtom", "(Ljava/io/OutputStream;[BII)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_o);
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
			}
		}

	}
}
