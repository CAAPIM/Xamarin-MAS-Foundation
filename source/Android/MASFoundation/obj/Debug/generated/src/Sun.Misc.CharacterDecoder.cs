using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Misc {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']"
	[global::Android.Runtime.Register ("sun/misc/CharacterDecoder", DoNotGenerateAcw=true)]
	public abstract partial class CharacterDecoder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/misc/CharacterDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharacterDecoder); }
		}

		protected CharacterDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/constructor[@name='CharacterDecoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CharacterDecoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CharacterDecoder)) {
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
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesPerAtom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='bytesPerAtom' and count(parameter)=0]"
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
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesPerLine ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='bytesPerLine' and count(parameter)=0]"
		[Register ("bytesPerLine", "()I", "GetBytesPerLineHandler")]
		protected abstract int BytesPerLine ();

		static Delegate cb_decodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_I;
#pragma warning disable 0169
		static Delegate GetDecodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_IHandler ()
		{
			if (cb_decodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_I == null)
				cb_decodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_DecodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_I);
			return cb_decodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_I;
		}

		static void n_DecodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_I (IntPtr jnienv, IntPtr native__this, IntPtr native_aStream, IntPtr native_bStream, int l)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.PushbackInputStream aStream = global::Java.Lang.Object.GetObject<global::Java.IO.PushbackInputStream> (native_aStream, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream bStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_bStream, JniHandleOwnership.DoNotTransfer);
			__this.DecodeAtom (aStream, bStream, l);
		}
#pragma warning restore 0169

		static IntPtr id_decodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='decodeAtom' and count(parameter)=3 and parameter[1][@type='java.io.PushbackInputStream'] and parameter[2][@type='java.io.OutputStream'] and parameter[3][@type='int']]"
		[Register ("decodeAtom", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;I)V", "GetDecodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_IHandler")]
		protected virtual unsafe void DecodeAtom (global::Java.IO.PushbackInputStream aStream, global::System.IO.Stream bStream, int l)
		{
			if (id_decodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_I == IntPtr.Zero)
				id_decodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_I = JNIEnv.GetMethodID (class_ref, "decodeAtom", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;I)V");
			IntPtr native_bStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (bStream);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (aStream);
				__args [1] = new JValue (native_bStream);
				__args [2] = new JValue (l);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeAtom_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeAtom", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bStream);
			}
		}

		static Delegate cb_decodeBuffer_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetDecodeBuffer_Ljava_io_InputStream_Handler ()
		{
			if (cb_decodeBuffer_Ljava_io_InputStream_ == null)
				cb_decodeBuffer_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeBuffer_Ljava_io_InputStream_);
			return cb_decodeBuffer_Ljava_io_InputStream_;
		}

		static IntPtr n_DecodeBuffer_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.DecodeBuffer (@in));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeBuffer_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='decodeBuffer' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("decodeBuffer", "(Ljava/io/InputStream;)[B", "GetDecodeBuffer_Ljava_io_InputStream_Handler")]
		public virtual unsafe byte[] DecodeBuffer (global::System.IO.Stream @in)
		{
			if (id_decodeBuffer_Ljava_io_InputStream_ == IntPtr.Zero)
				id_decodeBuffer_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "decodeBuffer", "(Ljava/io/InputStream;)[B");
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__in);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeBuffer_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBuffer", "(Ljava/io/InputStream;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		static Delegate cb_decodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDecodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_decodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_ == null)
				cb_decodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_);
			return cb_decodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_;
		}

		static void n_DecodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aStream, IntPtr native_bStream)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream aStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_aStream, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream bStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_bStream, JniHandleOwnership.DoNotTransfer);
			__this.DecodeBuffer (aStream, bStream);
		}
#pragma warning restore 0169

		static IntPtr id_decodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='decodeBuffer' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("decodeBuffer", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V", "GetDecodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void DecodeBuffer (global::System.IO.Stream aStream, global::System.IO.Stream bStream)
		{
			if (id_decodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_decodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "decodeBuffer", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V");
			IntPtr native_aStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (aStream);
			IntPtr native_bStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (bStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_aStream);
				__args [1] = new JValue (native_bStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeBuffer_Ljava_io_InputStream_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBuffer", "(Ljava/io/InputStream;Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_aStream);
				JNIEnv.DeleteLocalRef (native_bStream);
			}
		}

		static Delegate cb_decodeBuffer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecodeBuffer_Ljava_lang_String_Handler ()
		{
			if (cb_decodeBuffer_Ljava_lang_String_ == null)
				cb_decodeBuffer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeBuffer_Ljava_lang_String_);
			return cb_decodeBuffer_Ljava_lang_String_;
		}

		static IntPtr n_DecodeBuffer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputString)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string inputString = JNIEnv.GetString (native_inputString, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.DecodeBuffer (inputString));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeBuffer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='decodeBuffer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeBuffer", "(Ljava/lang/String;)[B", "GetDecodeBuffer_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] DecodeBuffer (string inputString)
		{
			if (id_decodeBuffer_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeBuffer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decodeBuffer", "(Ljava/lang/String;)[B");
			IntPtr native_inputString = JNIEnv.NewString (inputString);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_inputString);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeBuffer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBuffer", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputString);
			}
		}

		static Delegate cb_decodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDecodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_decodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ == null)
				cb_decodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_);
			return cb_decodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
		}

		static void n_DecodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aStream, IntPtr native_bStream)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.PushbackInputStream aStream = global::Java.Lang.Object.GetObject<global::Java.IO.PushbackInputStream> (native_aStream, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream bStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_bStream, JniHandleOwnership.DoNotTransfer);
			__this.DecodeBufferPrefix (aStream, bStream);
		}
#pragma warning restore 0169

		static IntPtr id_decodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='decodeBufferPrefix' and count(parameter)=2 and parameter[1][@type='java.io.PushbackInputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("decodeBufferPrefix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)V", "GetDecodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_Handler")]
		protected virtual unsafe void DecodeBufferPrefix (global::Java.IO.PushbackInputStream aStream, global::System.IO.Stream bStream)
		{
			if (id_decodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_decodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "decodeBufferPrefix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)V");
			IntPtr native_bStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (bStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aStream);
				__args [1] = new JValue (native_bStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeBufferPrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBufferPrefix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bStream);
			}
		}

		static Delegate cb_decodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDecodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_decodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ == null)
				cb_decodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_);
			return cb_decodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
		}

		static void n_DecodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aStream, IntPtr native_bStream)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.PushbackInputStream aStream = global::Java.Lang.Object.GetObject<global::Java.IO.PushbackInputStream> (native_aStream, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream bStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_bStream, JniHandleOwnership.DoNotTransfer);
			__this.DecodeBufferSuffix (aStream, bStream);
		}
#pragma warning restore 0169

		static IntPtr id_decodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='decodeBufferSuffix' and count(parameter)=2 and parameter[1][@type='java.io.PushbackInputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("decodeBufferSuffix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)V", "GetDecodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_Handler")]
		protected virtual unsafe void DecodeBufferSuffix (global::Java.IO.PushbackInputStream aStream, global::System.IO.Stream bStream)
		{
			if (id_decodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_decodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "decodeBufferSuffix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)V");
			IntPtr native_bStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (bStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aStream);
				__args [1] = new JValue (native_bStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeBufferSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBufferSuffix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bStream);
			}
		}

		static Delegate cb_decodeBufferToByteBuffer_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetDecodeBufferToByteBuffer_Ljava_io_InputStream_Handler ()
		{
			if (cb_decodeBufferToByteBuffer_Ljava_io_InputStream_ == null)
				cb_decodeBufferToByteBuffer_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeBufferToByteBuffer_Ljava_io_InputStream_);
			return cb_decodeBufferToByteBuffer_Ljava_io_InputStream_;
		}

		static IntPtr n_DecodeBufferToByteBuffer_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeBufferToByteBuffer (@in));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeBufferToByteBuffer_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='decodeBufferToByteBuffer' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("decodeBufferToByteBuffer", "(Ljava/io/InputStream;)Ljava/nio/ByteBuffer;", "GetDecodeBufferToByteBuffer_Ljava_io_InputStream_Handler")]
		public virtual unsafe global::Java.Nio.ByteBuffer DecodeBufferToByteBuffer (global::System.IO.Stream @in)
		{
			if (id_decodeBufferToByteBuffer_Ljava_io_InputStream_ == IntPtr.Zero)
				id_decodeBufferToByteBuffer_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "decodeBufferToByteBuffer", "(Ljava/io/InputStream;)Ljava/nio/ByteBuffer;");
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__in);

				global::Java.Nio.ByteBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeBufferToByteBuffer_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBufferToByteBuffer", "(Ljava/io/InputStream;)Ljava/nio/ByteBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		static Delegate cb_decodeBufferToByteBuffer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecodeBufferToByteBuffer_Ljava_lang_String_Handler ()
		{
			if (cb_decodeBufferToByteBuffer_Ljava_lang_String_ == null)
				cb_decodeBufferToByteBuffer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeBufferToByteBuffer_Ljava_lang_String_);
			return cb_decodeBufferToByteBuffer_Ljava_lang_String_;
		}

		static IntPtr n_DecodeBufferToByteBuffer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputString)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string inputString = JNIEnv.GetString (native_inputString, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DecodeBufferToByteBuffer (inputString));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeBufferToByteBuffer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='decodeBufferToByteBuffer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeBufferToByteBuffer", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;", "GetDecodeBufferToByteBuffer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Nio.ByteBuffer DecodeBufferToByteBuffer (string inputString)
		{
			if (id_decodeBufferToByteBuffer_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeBufferToByteBuffer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decodeBufferToByteBuffer", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;");
			IntPtr native_inputString = JNIEnv.NewString (inputString);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_inputString);

				global::Java.Nio.ByteBuffer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decodeBufferToByteBuffer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBufferToByteBuffer", "(Ljava/lang/String;)Ljava/nio/ByteBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputString);
			}
		}

		static Delegate cb_decodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDecodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_decodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ == null)
				cb_decodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_DecodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_);
			return cb_decodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
		}

		static int n_DecodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aStream, IntPtr native_bStream)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.PushbackInputStream aStream = global::Java.Lang.Object.GetObject<global::Java.IO.PushbackInputStream> (native_aStream, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream bStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_bStream, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DecodeLinePrefix (aStream, bStream);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='decodeLinePrefix' and count(parameter)=2 and parameter[1][@type='java.io.PushbackInputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("decodeLinePrefix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)I", "GetDecodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_Handler")]
		protected virtual unsafe int DecodeLinePrefix (global::Java.IO.PushbackInputStream aStream, global::System.IO.Stream bStream)
		{
			if (id_decodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_decodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "decodeLinePrefix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)I");
			IntPtr native_bStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (bStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aStream);
				__args [1] = new JValue (native_bStream);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_decodeLinePrefix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeLinePrefix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_bStream);
			}
		}

		static Delegate cb_decodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDecodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_Handler ()
		{
			if (cb_decodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ == null)
				cb_decodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_);
			return cb_decodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
		}

		static void n_DecodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aStream, IntPtr native_bStream)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.PushbackInputStream aStream = global::Java.Lang.Object.GetObject<global::Java.IO.PushbackInputStream> (native_aStream, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream bStream = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_bStream, JniHandleOwnership.DoNotTransfer);
			__this.DecodeLineSuffix (aStream, bStream);
		}
#pragma warning restore 0169

		static IntPtr id_decodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='decodeLineSuffix' and count(parameter)=2 and parameter[1][@type='java.io.PushbackInputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("decodeLineSuffix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)V", "GetDecodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_Handler")]
		protected virtual unsafe void DecodeLineSuffix (global::Java.IO.PushbackInputStream aStream, global::System.IO.Stream bStream)
		{
			if (id_decodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_decodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "decodeLineSuffix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)V");
			IntPtr native_bStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (bStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (aStream);
				__args [1] = new JValue (native_bStream);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeLineSuffix_Ljava_io_PushbackInputStream_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeLineSuffix", "(Ljava/io/PushbackInputStream;Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bStream);
			}
		}

		static Delegate cb_readFully_Ljava_io_InputStream_arrayBII;
#pragma warning disable 0169
		static Delegate GetReadFully_Ljava_io_InputStream_arrayBIIHandler ()
		{
			if (cb_readFully_Ljava_io_InputStream_arrayBII == null)
				cb_readFully_Ljava_io_InputStream_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int>) n_ReadFully_Ljava_io_InputStream_arrayBII);
			return cb_readFully_Ljava_io_InputStream_arrayBII;
		}

		static int n_ReadFully_Ljava_io_InputStream_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native_buffer, int offset, int len)
		{
			global::Sun.Misc.CharacterDecoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.CharacterDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			byte[] buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadFully (@in, buffer, offset, len);
			if (buffer != null)
				JNIEnv.CopyArray (buffer, native_buffer);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readFully_Ljava_io_InputStream_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='readFully' and count(parameter)=4 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("readFully", "(Ljava/io/InputStream;[BII)I", "GetReadFully_Ljava_io_InputStream_arrayBIIHandler")]
		protected virtual unsafe int ReadFully (global::System.IO.Stream @in, byte[] buffer, int offset, int len)
		{
			if (id_readFully_Ljava_io_InputStream_arrayBII == IntPtr.Zero)
				id_readFully_Ljava_io_InputStream_arrayBII = JNIEnv.GetMethodID (class_ref, "readFully", "(Ljava/io/InputStream;[BII)I");
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native__in);
				__args [1] = new JValue (native_buffer);
				__args [2] = new JValue (offset);
				__args [3] = new JValue (len);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readFully_Ljava_io_InputStream_arrayBII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFully", "(Ljava/io/InputStream;[BII)I"), __args);
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

	[global::Android.Runtime.Register ("sun/misc/CharacterDecoder", DoNotGenerateAcw=true)]
	internal partial class CharacterDecoderInvoker : CharacterDecoder {

		public CharacterDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharacterDecoderInvoker); }
		}

		static IntPtr id_bytesPerAtom;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='bytesPerAtom' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='CharacterDecoder']/method[@name='bytesPerLine' and count(parameter)=0]"
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

	}

}
