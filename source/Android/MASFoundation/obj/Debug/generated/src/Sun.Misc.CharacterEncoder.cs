using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Misc {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']"
	[global::Android.Runtime.Register ("sun/misc/CharacterEncoder", DoNotGenerateAcw=true)]
	public abstract partial class CharacterEncoder : global::Java.Lang.Object {


		static IntPtr pStream_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/field[@name='pStream']"
		[Register ("pStream")]
		protected global::Java.IO.PrintStream PStream {
			get {
				if (pStream_jfieldId == IntPtr.Zero)
					pStream_jfieldId = JNIEnv.GetFieldID (class_ref, "pStream", "Ljava/io/PrintStream;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, pStream_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pStream_jfieldId == IntPtr.Zero)
					pStream_jfieldId = JNIEnv.GetFieldID (class_ref, "pStream", "Ljava/io/PrintStream;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pStream_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/misc/CharacterEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharacterEncoder); }
		}

		protected CharacterEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/constructor[@name='CharacterEncoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CharacterEncoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CharacterEncoder)) {
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
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesPerAtom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='bytesPerAtom' and count(parameter)=0]"
		[Register ("bytesPerAtom", "()I", "GetBytesPerAtomHandler")]
		protected abstract int BytesPerAtom ();

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
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesPerLine ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='bytesPerLine' and count(parameter)=0]"
		[Register ("bytesPerLine", "()I", "GetBytesPerLineHandler")]
		protected abstract int BytesPerLine ();

		static Delegate cb_encode_arrayB;
#pragma warning disable 0169
		static Delegate GetEncode_arrayBHandler ()
		{
			if (cb_encode_arrayB == null)
				cb_encode_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_arrayB);
			return cb_encode_arrayB;
		}

		static IntPtr n_Encode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_aBuffer)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] aBuffer = (byte[]) JNIEnv.GetArray (native_aBuffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.Encode (aBuffer));
			if (aBuffer != null)
				JNIEnv.CopyArray (aBuffer, native_aBuffer);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)Ljava/lang/String;", "GetEncode_arrayBHandler")]
		public virtual unsafe string Encode (byte[] aBuffer)
		{
			if (id_encode_arrayB == IntPtr.Zero)
				id_encode_arrayB = JNIEnv.GetMethodID (class_ref, "encode", "([B)Ljava/lang/String;");
			IntPtr native_aBuffer = JNIEnv.NewArray (aBuffer);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aBuffer);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (aBuffer != null) {
					JNIEnv.CopyArray (native_aBuffer, aBuffer);
					JNIEnv.DeleteLocalRef (native_aBuffer);
				}
			}
		}

		static Delegate cb_encode_arrayBLjava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_arrayBLjava_io_OutputStream_Handler ()
		{
			if (cb_encode_arrayBLjava_io_OutputStream_ == null)
				cb_encode_arrayBLjava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_arrayBLjava_io_OutputStream_);
			return cb_encode_arrayBLjava_io_OutputStream_;
		}

		static void n_Encode_arrayBLjava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aBuffer, IntPtr native_aStream)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] aBuffer = (byte[]) JNIEnv.GetArray (native_aBuffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
			System.IO.Stream aStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_aStream, JniHandleOwnership.DoNotTransfer);
			__this.Encode (aBuffer, aStream);
			if (aBuffer != null)
				JNIEnv.CopyArray (aBuffer, native_aBuffer);
		}
#pragma warning restore 0169

		static IntPtr id_encode_arrayBLjava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("encode", "([BLjava/io/OutputStream;)V", "GetEncode_arrayBLjava_io_OutputStream_Handler")]
		public virtual unsafe void Encode (byte[] aBuffer, global::System.IO.Stream aStream)
		{
			if (id_encode_arrayBLjava_io_OutputStream_ == IntPtr.Zero)
				id_encode_arrayBLjava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "([BLjava/io/OutputStream;)V");
			IntPtr native_aBuffer = JNIEnv.NewArray (aBuffer);
			IntPtr native_aStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (aStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_aBuffer);
				__args [1] = new JValue (native_aStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_arrayBLjava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "([BLjava/io/OutputStream;)V"), __args);
			} finally {
				if (aBuffer != null) {
					JNIEnv.CopyArray (native_aBuffer, aBuffer);
					JNIEnv.DeleteLocalRef (native_aBuffer);
				}
				JNIEnv.DeleteLocalRef (native_aStream);
			}
		}

		static Delegate cb_encode_Ljava_io_InputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_io_InputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encode_Ljava_io_InputStream_Ljava_io_OutputStream_ == null)
				cb_encode_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_io_InputStream_Ljava_io_OutputStream_);
			return cb_encode_Ljava_io_InputStream_Ljava_io_OutputStream_;
		}

		static void n_Encode_Ljava_io_InputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inStream, IntPtr native_outStream)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream inStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_inStream, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream outStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_outStream, JniHandleOwnership.DoNotTransfer);
			__this.Encode (inStream, outStream);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("encode", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "GetEncode_Ljava_io_InputStream_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void Encode (global::System.IO.Stream inStream, global::System.IO.Stream outStream)
		{
			if (id_encode_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encode_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V");
			IntPtr native_inStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inStream);
			IntPtr native_outStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_inStream);
				__args [1] = new JValue (native_outStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_io_InputStream_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_inStream);
				JNIEnv.DeleteLocalRef (native_outStream);
			}
		}

		static Delegate cb_encode_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_encode_Ljava_nio_ByteBuffer_ == null)
				cb_encode_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_nio_ByteBuffer_);
			return cb_encode_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_Encode_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aBuffer)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer aBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_aBuffer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (aBuffer));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("encode", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;", "GetEncode_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe string Encode (global::Java.Nio.ByteBuffer aBuffer)
		{
			if (id_encode_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_encode_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aBuffer);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_encode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_ == null)
				cb_encode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_);
			return cb_encode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_;
		}

		static void n_Encode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aBuffer, IntPtr native_aStream)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer aBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_aBuffer, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream aStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_aStream, JniHandleOwnership.DoNotTransfer);
			__this.Encode (aBuffer, aStream);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("encode", "(Ljava/nio/ByteBuffer;Ljava/io/OutputStream;)V", "GetEncode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void Encode (global::Java.Nio.ByteBuffer aBuffer, global::System.IO.Stream aStream)
		{
			if (id_encode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/nio/ByteBuffer;Ljava/io/OutputStream;)V");
			IntPtr native_aStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (aStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aBuffer);
				__args [1] = new JValue (native_aStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/nio/ByteBuffer;Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aStream);
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

		static void n_EncodeAtom_Ljava_io_OutputStream_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.EncodeAtom (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeAtom' and count(parameter)=4 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encodeAtom", "(Ljava/io/OutputStream;[BII)V", "GetEncodeAtom_Ljava_io_OutputStream_arrayBIIHandler")]
		protected abstract void EncodeAtom (global::System.IO.Stream p0, byte[] p1, int p2, int p3);

		static Delegate cb_encodeBuffer_arrayB;
#pragma warning disable 0169
		static Delegate GetEncodeBuffer_arrayBHandler ()
		{
			if (cb_encodeBuffer_arrayB == null)
				cb_encodeBuffer_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeBuffer_arrayB);
			return cb_encodeBuffer_arrayB;
		}

		static IntPtr n_EncodeBuffer_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_aBuffer)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] aBuffer = (byte[]) JNIEnv.GetArray (native_aBuffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.EncodeBuffer (aBuffer));
			if (aBuffer != null)
				JNIEnv.CopyArray (aBuffer, native_aBuffer);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeBuffer_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeBuffer' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBuffer", "([B)Ljava/lang/String;", "GetEncodeBuffer_arrayBHandler")]
		public virtual unsafe string EncodeBuffer (byte[] aBuffer)
		{
			if (id_encodeBuffer_arrayB == IntPtr.Zero)
				id_encodeBuffer_arrayB = JNIEnv.GetMethodID (class_ref, "encodeBuffer", "([B)Ljava/lang/String;");
			IntPtr native_aBuffer = JNIEnv.NewArray (aBuffer);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aBuffer);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeBuffer_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeBuffer", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (aBuffer != null) {
					JNIEnv.CopyArray (native_aBuffer, aBuffer);
					JNIEnv.DeleteLocalRef (native_aBuffer);
				}
			}
		}

		static Delegate cb_encodeBuffer_arrayBLjava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncodeBuffer_arrayBLjava_io_OutputStream_Handler ()
		{
			if (cb_encodeBuffer_arrayBLjava_io_OutputStream_ == null)
				cb_encodeBuffer_arrayBLjava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeBuffer_arrayBLjava_io_OutputStream_);
			return cb_encodeBuffer_arrayBLjava_io_OutputStream_;
		}

		static void n_EncodeBuffer_arrayBLjava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aBuffer, IntPtr native_aStream)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] aBuffer = (byte[]) JNIEnv.GetArray (native_aBuffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
			System.IO.Stream aStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_aStream, JniHandleOwnership.DoNotTransfer);
			__this.EncodeBuffer (aBuffer, aStream);
			if (aBuffer != null)
				JNIEnv.CopyArray (aBuffer, native_aBuffer);
		}
#pragma warning restore 0169

		static IntPtr id_encodeBuffer_arrayBLjava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeBuffer' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("encodeBuffer", "([BLjava/io/OutputStream;)V", "GetEncodeBuffer_arrayBLjava_io_OutputStream_Handler")]
		public virtual unsafe void EncodeBuffer (byte[] aBuffer, global::System.IO.Stream aStream)
		{
			if (id_encodeBuffer_arrayBLjava_io_OutputStream_ == IntPtr.Zero)
				id_encodeBuffer_arrayBLjava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encodeBuffer", "([BLjava/io/OutputStream;)V");
			IntPtr native_aBuffer = JNIEnv.NewArray (aBuffer);
			IntPtr native_aStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (aStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_aBuffer);
				__args [1] = new JValue (native_aStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeBuffer_arrayBLjava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeBuffer", "([BLjava/io/OutputStream;)V"), __args);
			} finally {
				if (aBuffer != null) {
					JNIEnv.CopyArray (native_aBuffer, aBuffer);
					JNIEnv.DeleteLocalRef (native_aBuffer);
				}
				JNIEnv.DeleteLocalRef (native_aStream);
			}
		}

		static Delegate cb_encodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_ == null)
				cb_encodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_);
			return cb_encodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_;
		}

		static void n_EncodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inStream, IntPtr native_outStream)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream inStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_inStream, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream outStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_outStream, JniHandleOwnership.DoNotTransfer);
			__this.EncodeBuffer (inStream, outStream);
		}
#pragma warning restore 0169

		static IntPtr id_encodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeBuffer' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("encodeBuffer", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "GetEncodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void EncodeBuffer (global::System.IO.Stream inStream, global::System.IO.Stream outStream)
		{
			if (id_encodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encodeBuffer", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V");
			IntPtr native_inStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inStream);
			IntPtr native_outStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_inStream);
				__args [1] = new JValue (native_outStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeBuffer", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_inStream);
				JNIEnv.DeleteLocalRef (native_outStream);
			}
		}

		static Delegate cb_encodeBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetEncodeBuffer_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_encodeBuffer_Ljava_nio_ByteBuffer_ == null)
				cb_encodeBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeBuffer_Ljava_nio_ByteBuffer_);
			return cb_encodeBuffer_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_EncodeBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aBuffer)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer aBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_aBuffer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.EncodeBuffer (aBuffer));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeBuffer_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeBuffer' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("encodeBuffer", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;", "GetEncodeBuffer_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe string EncodeBuffer (global::Java.Nio.ByteBuffer aBuffer)
		{
			if (id_encodeBuffer_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_encodeBuffer_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "encodeBuffer", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aBuffer);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeBuffer_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeBuffer", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_encodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_ == null)
				cb_encodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_);
			return cb_encodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_;
		}

		static void n_EncodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aBuffer, IntPtr native_aStream)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer aBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_aBuffer, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream aStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_aStream, JniHandleOwnership.DoNotTransfer);
			__this.EncodeBuffer (aBuffer, aStream);
		}
#pragma warning restore 0169

		static IntPtr id_encodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeBuffer' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("encodeBuffer", "(Ljava/nio/ByteBuffer;Ljava/io/OutputStream;)V", "GetEncodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void EncodeBuffer (global::Java.Nio.ByteBuffer aBuffer, global::System.IO.Stream aStream)
		{
			if (id_encodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encodeBuffer", "(Ljava/nio/ByteBuffer;Ljava/io/OutputStream;)V");
			IntPtr native_aStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (aStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aBuffer);
				__args [1] = new JValue (native_aStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeBuffer_Ljava_nio_ByteBuffer_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeBuffer", "(Ljava/nio/ByteBuffer;Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aStream);
			}
		}

		static Delegate cb_encodeBufferPrefix_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncodeBufferPrefix_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encodeBufferPrefix_Ljava_io_OutputStream_ == null)
				cb_encodeBufferPrefix_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EncodeBufferPrefix_Ljava_io_OutputStream_);
			return cb_encodeBufferPrefix_Ljava_io_OutputStream_;
		}

		static void n_EncodeBufferPrefix_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aStream)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream aStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_aStream, JniHandleOwnership.DoNotTransfer);
			__this.EncodeBufferPrefix (aStream);
		}
#pragma warning restore 0169

		static IntPtr id_encodeBufferPrefix_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeBufferPrefix' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("encodeBufferPrefix", "(Ljava/io/OutputStream;)V", "GetEncodeBufferPrefix_Ljava_io_OutputStream_Handler")]
		protected virtual unsafe void EncodeBufferPrefix (global::System.IO.Stream aStream)
		{
			if (id_encodeBufferPrefix_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encodeBufferPrefix_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encodeBufferPrefix", "(Ljava/io/OutputStream;)V");
			IntPtr native_aStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (aStream);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeBufferPrefix_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeBufferPrefix", "(Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aStream);
			}
		}

		static Delegate cb_encodeBufferSuffix_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncodeBufferSuffix_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encodeBufferSuffix_Ljava_io_OutputStream_ == null)
				cb_encodeBufferSuffix_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EncodeBufferSuffix_Ljava_io_OutputStream_);
			return cb_encodeBufferSuffix_Ljava_io_OutputStream_;
		}

		static void n_EncodeBufferSuffix_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aStream)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream aStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_aStream, JniHandleOwnership.DoNotTransfer);
			__this.EncodeBufferSuffix (aStream);
		}
#pragma warning restore 0169

		static IntPtr id_encodeBufferSuffix_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeBufferSuffix' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("encodeBufferSuffix", "(Ljava/io/OutputStream;)V", "GetEncodeBufferSuffix_Ljava_io_OutputStream_Handler")]
		protected virtual unsafe void EncodeBufferSuffix (global::System.IO.Stream aStream)
		{
			if (id_encodeBufferSuffix_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encodeBufferSuffix_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encodeBufferSuffix", "(Ljava/io/OutputStream;)V");
			IntPtr native_aStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (aStream);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeBufferSuffix_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeBufferSuffix", "(Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aStream);
			}
		}

		static Delegate cb_encodeLinePrefix_Ljava_io_OutputStream_I;
#pragma warning disable 0169
		static Delegate GetEncodeLinePrefix_Ljava_io_OutputStream_IHandler ()
		{
			if (cb_encodeLinePrefix_Ljava_io_OutputStream_I == null)
				cb_encodeLinePrefix_Ljava_io_OutputStream_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_EncodeLinePrefix_Ljava_io_OutputStream_I);
			return cb_encodeLinePrefix_Ljava_io_OutputStream_I;
		}

		static void n_EncodeLinePrefix_Ljava_io_OutputStream_I (IntPtr jnienv, IntPtr native__this, IntPtr native_aStream, int aLength)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream aStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_aStream, JniHandleOwnership.DoNotTransfer);
			__this.EncodeLinePrefix (aStream, aLength);
		}
#pragma warning restore 0169

		static IntPtr id_encodeLinePrefix_Ljava_io_OutputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeLinePrefix' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='int']]"
		[Register ("encodeLinePrefix", "(Ljava/io/OutputStream;I)V", "GetEncodeLinePrefix_Ljava_io_OutputStream_IHandler")]
		protected virtual unsafe void EncodeLinePrefix (global::System.IO.Stream aStream, int aLength)
		{
			if (id_encodeLinePrefix_Ljava_io_OutputStream_I == IntPtr.Zero)
				id_encodeLinePrefix_Ljava_io_OutputStream_I = JNIEnv.GetMethodID (class_ref, "encodeLinePrefix", "(Ljava/io/OutputStream;I)V");
			IntPtr native_aStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (aStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_aStream);
				__args [1] = new JValue (aLength);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeLinePrefix_Ljava_io_OutputStream_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeLinePrefix", "(Ljava/io/OutputStream;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aStream);
			}
		}

		static Delegate cb_encodeLineSuffix_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncodeLineSuffix_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encodeLineSuffix_Ljava_io_OutputStream_ == null)
				cb_encodeLineSuffix_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EncodeLineSuffix_Ljava_io_OutputStream_);
			return cb_encodeLineSuffix_Ljava_io_OutputStream_;
		}

		static void n_EncodeLineSuffix_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aStream)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream aStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_aStream, JniHandleOwnership.DoNotTransfer);
			__this.EncodeLineSuffix (aStream);
		}
#pragma warning restore 0169

		static IntPtr id_encodeLineSuffix_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeLineSuffix' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("encodeLineSuffix", "(Ljava/io/OutputStream;)V", "GetEncodeLineSuffix_Ljava_io_OutputStream_Handler")]
		protected virtual unsafe void EncodeLineSuffix (global::System.IO.Stream aStream)
		{
			if (id_encodeLineSuffix_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encodeLineSuffix_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encodeLineSuffix", "(Ljava/io/OutputStream;)V");
			IntPtr native_aStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (aStream);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeLineSuffix_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeLineSuffix", "(Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aStream);
			}
		}

		static Delegate cb_readFully_Ljava_io_InputStream_arrayB;
#pragma warning disable 0169
		static Delegate GetReadFully_Ljava_io_InputStream_arrayBHandler ()
		{
			if (cb_readFully_Ljava_io_InputStream_arrayB == null)
				cb_readFully_Ljava_io_InputStream_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ReadFully_Ljava_io_InputStream_arrayB);
			return cb_readFully_Ljava_io_InputStream_arrayB;
		}

		static int n_ReadFully_Ljava_io_InputStream_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native_buffer)
		{
			global::Sun.Misc.CharacterEncoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			byte[] buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadFully (@in, buffer);
			if (buffer != null)
				JNIEnv.CopyArray (buffer, native_buffer);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readFully_Ljava_io_InputStream_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='readFully' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]']]"
		[Register ("readFully", "(Ljava/io/InputStream;[B)I", "GetReadFully_Ljava_io_InputStream_arrayBHandler")]
		protected virtual unsafe int ReadFully (global::System.IO.Stream @in, byte[] buffer)
		{
			if (id_readFully_Ljava_io_InputStream_arrayB == IntPtr.Zero)
				id_readFully_Ljava_io_InputStream_arrayB = JNIEnv.GetMethodID (class_ref, "readFully", "(Ljava/io/InputStream;[B)I");
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__in);
				__args [1] = new JValue (native_buffer);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readFully_Ljava_io_InputStream_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFully", "(Ljava/io/InputStream;[B)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("sun/misc/CharacterEncoder", DoNotGenerateAcw=true)]
	internal partial class CharacterEncoderInvoker : CharacterEncoder {

		public CharacterEncoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharacterEncoderInvoker); }
		}

		static IntPtr id_bytesPerAtom;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='bytesPerAtom' and count(parameter)=0]"
		[Register ("bytesPerAtom", "()I", "GetBytesPerAtomHandler")]
		protected override unsafe int BytesPerAtom ()
		{
			if (id_bytesPerAtom == IntPtr.Zero)
				id_bytesPerAtom = JNIEnv.GetMethodID (class_ref, "bytesPerAtom", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_bytesPerAtom);
			} finally {
			}
		}

		static IntPtr id_bytesPerLine;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='bytesPerLine' and count(parameter)=0]"
		[Register ("bytesPerLine", "()I", "GetBytesPerLineHandler")]
		protected override unsafe int BytesPerLine ()
		{
			if (id_bytesPerLine == IntPtr.Zero)
				id_bytesPerLine = JNIEnv.GetMethodID (class_ref, "bytesPerLine", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_bytesPerLine);
			} finally {
			}
		}

		static IntPtr id_encodeAtom_Ljava_io_OutputStream_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterEncoder']/method[@name='encodeAtom' and count(parameter)=4 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encodeAtom", "(Ljava/io/OutputStream;[BII)V", "GetEncodeAtom_Ljava_io_OutputStream_arrayBIIHandler")]
		protected override unsafe void EncodeAtom (global::System.IO.Stream p0, byte[] p1, int p2, int p3)
		{
			if (id_encodeAtom_Ljava_io_OutputStream_arrayBII == IntPtr.Zero)
				id_encodeAtom_Ljava_io_OutputStream_arrayBII = JNIEnv.GetMethodID (class_ref, "encodeAtom", "(Ljava/io/OutputStream;[BII)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeAtom_Ljava_io_OutputStream_arrayBII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}

}
