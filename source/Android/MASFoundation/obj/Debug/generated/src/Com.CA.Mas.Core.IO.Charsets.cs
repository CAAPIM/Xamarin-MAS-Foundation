using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='Charsets']"
	[global::Android.Runtime.Register ("com/ca/mas/core/io/Charsets", DoNotGenerateAcw=true)]
	public partial class Charsets : global::Java.Lang.Object {


		static IntPtr ASCII_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='Charsets']/field[@name='ASCII']"
		[Register ("ASCII")]
		public static global::Java.Nio.Charset.Charset Ascii {
			get {
				if (ASCII_jfieldId == IntPtr.Zero)
					ASCII_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASCII", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASCII_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_8859_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='Charsets']/field[@name='ISO_8859_1']"
		[Register ("ISO_8859_1")]
		public static global::Java.Nio.Charset.Charset Iso88591 {
			get {
				if (ISO_8859_1_jfieldId == IntPtr.Zero)
					ISO_8859_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_8859_1", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_8859_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UTF8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.io']/class[@name='Charsets']/field[@name='UTF8']"
		[Register ("UTF8")]
		public static global::Java.Nio.Charset.Charset Utf8 {
			get {
				if (UTF8_jfieldId == IntPtr.Zero)
					UTF8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTF8", "Ljava/nio/charset/Charset;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UTF8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/io/Charsets", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Charsets); }
		}

		protected Charsets (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
