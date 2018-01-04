using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='IoUtils']"
	[global::Android.Runtime.Register ("com/ca/mas/core/io/IoUtils", DoNotGenerateAcw=true)]
	public partial class IoUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/io/IoUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IoUtils); }
		}

		protected IoUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_base64_Ljava_lang_String_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='IoUtils']/method[@name='base64' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("base64", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public static unsafe string Base64 (string str, global::Java.Nio.Charset.Charset charset)
		{
			if (id_base64_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
				id_base64_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetStaticMethodID (class_ref, "base64", "(Ljava/lang/String;Ljava/nio/charset/Charset;)Ljava/lang/String;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (charset);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_base64_Ljava_lang_String_Ljava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_closeQuietly_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='IoUtils']/method[@name='closeQuietly' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeQuietly", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseQuietly (global::Java.IO.ICloseable closeable)
		{
			if (id_closeQuietly_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeQuietly_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeQuietly", "(Ljava/io/Closeable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (closeable);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeQuietly_Ljava_io_Closeable_, __args);
			} finally {
			}
		}

		static IntPtr id_hexDump_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='IoUtils']/method[@name='hexDump' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("hexDump", "([B)Ljava/lang/String;", "")]
		public static unsafe string HexDump (byte[] binaryData)
		{
			if (id_hexDump_arrayB == IntPtr.Zero)
				id_hexDump_arrayB = JNIEnv.GetStaticMethodID (class_ref, "hexDump", "([B)Ljava/lang/String;");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_binaryData);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexDump_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_hexDump_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='IoUtils']/method[@name='hexDump' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("hexDump", "([BII)Ljava/lang/String;", "")]
		public static unsafe string HexDump (byte[] binaryData, int off, int len)
		{
			if (id_hexDump_arrayBII == IntPtr.Zero)
				id_hexDump_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "hexDump", "([BII)Ljava/lang/String;");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_binaryData);
				__args [1] = new JValue (off);
				__args [2] = new JValue (len);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexDump_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_hexDump_arrayBIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='IoUtils']/method[@name='hexDump' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("hexDump", "([BIIZ)Ljava/lang/String;", "")]
		public static unsafe string HexDump (byte[] binaryData, int off, int len, bool upperCase)
		{
			if (id_hexDump_arrayBIIZ == IntPtr.Zero)
				id_hexDump_arrayBIIZ = JNIEnv.GetStaticMethodID (class_ref, "hexDump", "([BIIZ)Ljava/lang/String;");
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_binaryData);
				__args [1] = new JValue (off);
				__args [2] = new JValue (len);
				__args [3] = new JValue (upperCase);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexDump_arrayBIIZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		static IntPtr id_hexToByteArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='IoUtils']/method[@name='hexToByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexToByteArray", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] HexToByteArray (string s)
		{
			if (id_hexToByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_hexToByteArray_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexToByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexToByteArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static IntPtr id_slurpStream_Ljava_io_InputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='IoUtils']/method[@name='slurpStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("slurpStream", "(Ljava/io/InputStream;I)[B", "")]
		public static unsafe byte[] SlurpStream (global::System.IO.Stream stream, int limit)
		{
			if (id_slurpStream_Ljava_io_InputStream_I == IntPtr.Zero)
				id_slurpStream_Ljava_io_InputStream_I = JNIEnv.GetStaticMethodID (class_ref, "slurpStream", "(Ljava/io/InputStream;I)[B");
			IntPtr native_stream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (stream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_stream);
				__args [1] = new JValue (limit);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_slurpStream_Ljava_io_InputStream_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_stream);
			}
		}

	}
}
