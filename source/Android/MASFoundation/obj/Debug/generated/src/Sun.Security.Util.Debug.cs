using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']"
	[global::Android.Runtime.Register ("sun/security/util/Debug", DoNotGenerateAcw=true)]
	public partial class Debug : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/util/Debug", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Debug); }
		}

		protected Debug (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']/constructor[@name='Debug' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Debug ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Debug)) {
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

		static IntPtr id_Help;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']/method[@name='Help' and count(parameter)=0]"
		[Register ("Help", "()V", "")]
		public static unsafe void Help ()
		{
			if (id_Help == IntPtr.Zero)
				id_Help = JNIEnv.GetStaticMethodID (class_ref, "Help", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_Help);
			} finally {
			}
		}

		static IntPtr id_getInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInstance", "(Ljava/lang/String;)Lsun/security/util/Debug;", "")]
		public static unsafe global::Sun.Security.Util.Debug GetInstance (string option)
		{
			if (id_getInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Ljava/lang/String;)Lsun/security/util/Debug;");
			IntPtr native_option = JNIEnv.NewString (option);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_option);
				global::Sun.Security.Util.Debug __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Debug> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_option);
			}
		}

		static IntPtr id_getInstance_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Lsun/security/util/Debug;", "")]
		public static unsafe global::Sun.Security.Util.Debug GetInstance (string option, string prefix)
		{
			if (id_getInstance_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Lsun/security/util/Debug;");
			IntPtr native_option = JNIEnv.NewString (option);
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_option);
				__args [1] = new JValue (native_prefix);
				global::Sun.Security.Util.Debug __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Debug> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_option);
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		static IntPtr id_isOn_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']/method[@name='isOn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isOn", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsOn (string option)
		{
			if (id_isOn_Ljava_lang_String_ == IntPtr.Zero)
				id_isOn_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isOn", "(Ljava/lang/String;)Z");
			IntPtr native_option = JNIEnv.NewString (option);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_option);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isOn_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_option);
			}
		}

		static Delegate cb_println;
#pragma warning disable 0169
		static Delegate GetPrintlnHandler ()
		{
			if (cb_println == null)
				cb_println = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Println);
			return cb_println;
		}

		static void n_Println (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Println ();
		}
#pragma warning restore 0169

		static IntPtr id_println;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']/method[@name='println' and count(parameter)=0]"
		[Register ("println", "()V", "GetPrintlnHandler")]
		public virtual unsafe void Println ()
		{
			if (id_println == IntPtr.Zero)
				id_println = JNIEnv.GetMethodID (class_ref, "println", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_println);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "println", "()V"));
			} finally {
			}
		}

		static Delegate cb_println_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrintln_Ljava_lang_String_Handler ()
		{
			if (cb_println_Ljava_lang_String_ == null)
				cb_println_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Println_Ljava_lang_String_);
			return cb_println_Ljava_lang_String_;
		}

		static void n_Println_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Sun.Security.Util.Debug __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Debug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Println (message);
		}
#pragma warning restore 0169

		static IntPtr id_println_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']/method[@name='println' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("println", "(Ljava/lang/String;)V", "GetPrintln_Ljava_lang_String_Handler")]
		public virtual unsafe void Println (string message)
		{
			if (id_println_Ljava_lang_String_ == IntPtr.Zero)
				id_println_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "println", "(Ljava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_println_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "println", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_println_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']/method[@name='println' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("println", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Println (string prefix, string message)
		{
			if (id_println_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_println_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "println", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_prefix);
				__args [1] = new JValue (native_message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_println_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_toHexString_Ljava_math_BigInteger_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']/method[@name='toHexString' and count(parameter)=1 and parameter[1][@type='java.math.BigInteger']]"
		[Register ("toHexString", "(Ljava/math/BigInteger;)Ljava/lang/String;", "")]
		public static unsafe string ToHexString (global::Java.Math.BigInteger b)
		{
			if (id_toHexString_Ljava_math_BigInteger_ == IntPtr.Zero)
				id_toHexString_Ljava_math_BigInteger_ = JNIEnv.GetStaticMethodID (class_ref, "toHexString", "(Ljava/math/BigInteger;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (b);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHexString_Ljava_math_BigInteger_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Debug']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toString", "([B)Ljava/lang/String;", "")]
		public static unsafe string ToString (byte[] b)
		{
			if (id_toString_arrayB == IntPtr.Zero)
				id_toString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toString", "([B)Ljava/lang/String;");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

	}
}
