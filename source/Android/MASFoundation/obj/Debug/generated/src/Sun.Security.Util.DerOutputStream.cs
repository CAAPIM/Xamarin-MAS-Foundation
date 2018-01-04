using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']"
	[global::Android.Runtime.Register ("sun/security/util/DerOutputStream", DoNotGenerateAcw=true)]
	public partial class DerOutputStream : global::Java.IO.ByteArrayOutputStream, global::Sun.Security.Util.IDerEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/util/DerOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DerOutputStream); }
		}

		protected DerOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/constructor[@name='DerOutputStream' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DerOutputStream ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DerOutputStream)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/constructor[@name='DerOutputStream' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe DerOutputStream (int size)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (size);
				if (((object) this).GetType () != typeof (DerOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_derEncode_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDerEncode_Ljava_io_OutputStream_Handler ()
		{
			if (cb_derEncode_Ljava_io_OutputStream_ == null)
				cb_derEncode_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DerEncode_Ljava_io_OutputStream_);
			return cb_derEncode_Ljava_io_OutputStream_;
		}

		static void n_DerEncode_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.DerEncode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_derEncode_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='derEncode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("derEncode", "(Ljava/io/OutputStream;)V", "GetDerEncode_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void DerEncode (global::System.IO.Stream @out)
		{
			if (id_derEncode_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_derEncode_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "derEncode", "(Ljava/io/OutputStream;)V");
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_derEncode_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "derEncode", "(Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		static Delegate cb_putBMPString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutBMPString_Ljava_lang_String_Handler ()
		{
			if (cb_putBMPString_Ljava_lang_String_ == null)
				cb_putBMPString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutBMPString_Ljava_lang_String_);
			return cb_putBMPString_Ljava_lang_String_;
		}

		static void n_PutBMPString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.PutBMPString (s);
		}
#pragma warning restore 0169

		static IntPtr id_putBMPString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putBMPString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putBMPString", "(Ljava/lang/String;)V", "GetPutBMPString_Ljava_lang_String_Handler")]
		public virtual unsafe void PutBMPString (string s)
		{
			if (id_putBMPString_Ljava_lang_String_ == IntPtr.Zero)
				id_putBMPString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putBMPString", "(Ljava/lang/String;)V");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBMPString_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putBMPString", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_putBitString_arrayB;
#pragma warning disable 0169
		static Delegate GetPutBitString_arrayBHandler ()
		{
			if (cb_putBitString_arrayB == null)
				cb_putBitString_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutBitString_arrayB);
			return cb_putBitString_arrayB;
		}

		static void n_PutBitString_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bits)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bits = (byte[]) JNIEnv.GetArray (native_bits, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PutBitString (bits);
			if (bits != null)
				JNIEnv.CopyArray (bits, native_bits);
		}
#pragma warning restore 0169

		static IntPtr id_putBitString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putBitString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("putBitString", "([B)V", "GetPutBitString_arrayBHandler")]
		public virtual unsafe void PutBitString (byte[] bits)
		{
			if (id_putBitString_arrayB == IntPtr.Zero)
				id_putBitString_arrayB = JNIEnv.GetMethodID (class_ref, "putBitString", "([B)V");
			IntPtr native_bits = JNIEnv.NewArray (bits);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bits);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBitString_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putBitString", "([B)V"), __args);
			} finally {
				if (bits != null) {
					JNIEnv.CopyArray (native_bits, bits);
					JNIEnv.DeleteLocalRef (native_bits);
				}
			}
		}

		static Delegate cb_putBoolean_Z;
#pragma warning disable 0169
		static Delegate GetPutBoolean_ZHandler ()
		{
			if (cb_putBoolean_Z == null)
				cb_putBoolean_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_PutBoolean_Z);
			return cb_putBoolean_Z;
		}

		static void n_PutBoolean_Z (IntPtr jnienv, IntPtr native__this, bool val)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PutBoolean (val);
		}
#pragma warning restore 0169

		static IntPtr id_putBoolean_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putBoolean' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("putBoolean", "(Z)V", "GetPutBoolean_ZHandler")]
		public virtual unsafe void PutBoolean (bool val)
		{
			if (id_putBoolean_Z == IntPtr.Zero)
				id_putBoolean_Z = JNIEnv.GetMethodID (class_ref, "putBoolean", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (val);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBoolean_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putBoolean", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putEnumerated_I;
#pragma warning disable 0169
		static Delegate GetPutEnumerated_IHandler ()
		{
			if (cb_putEnumerated_I == null)
				cb_putEnumerated_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_PutEnumerated_I);
			return cb_putEnumerated_I;
		}

		static void n_PutEnumerated_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PutEnumerated (i);
		}
#pragma warning restore 0169

		static IntPtr id_putEnumerated_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putEnumerated' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("putEnumerated", "(I)V", "GetPutEnumerated_IHandler")]
		public virtual unsafe void PutEnumerated (int i)
		{
			if (id_putEnumerated_I == IntPtr.Zero)
				id_putEnumerated_I = JNIEnv.GetMethodID (class_ref, "putEnumerated", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putEnumerated_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putEnumerated", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putGeneralString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutGeneralString_Ljava_lang_String_Handler ()
		{
			if (cb_putGeneralString_Ljava_lang_String_ == null)
				cb_putGeneralString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutGeneralString_Ljava_lang_String_);
			return cb_putGeneralString_Ljava_lang_String_;
		}

		static void n_PutGeneralString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.PutGeneralString (s);
		}
#pragma warning restore 0169

		static IntPtr id_putGeneralString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putGeneralString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putGeneralString", "(Ljava/lang/String;)V", "GetPutGeneralString_Ljava_lang_String_Handler")]
		public virtual unsafe void PutGeneralString (string s)
		{
			if (id_putGeneralString_Ljava_lang_String_ == IntPtr.Zero)
				id_putGeneralString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putGeneralString", "(Ljava/lang/String;)V");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putGeneralString_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putGeneralString", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_putGeneralizedTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetPutGeneralizedTime_Ljava_util_Date_Handler ()
		{
			if (cb_putGeneralizedTime_Ljava_util_Date_ == null)
				cb_putGeneralizedTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutGeneralizedTime_Ljava_util_Date_);
			return cb_putGeneralizedTime_Ljava_util_Date_;
		}

		static void n_PutGeneralizedTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date d = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_d, JniHandleOwnership.DoNotTransfer);
			__this.PutGeneralizedTime (d);
		}
#pragma warning restore 0169

		static IntPtr id_putGeneralizedTime_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putGeneralizedTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("putGeneralizedTime", "(Ljava/util/Date;)V", "GetPutGeneralizedTime_Ljava_util_Date_Handler")]
		public virtual unsafe void PutGeneralizedTime (global::Java.Util.Date d)
		{
			if (id_putGeneralizedTime_Ljava_util_Date_ == IntPtr.Zero)
				id_putGeneralizedTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "putGeneralizedTime", "(Ljava/util/Date;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (d);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putGeneralizedTime_Ljava_util_Date_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putGeneralizedTime", "(Ljava/util/Date;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putIA5String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutIA5String_Ljava_lang_String_Handler ()
		{
			if (cb_putIA5String_Ljava_lang_String_ == null)
				cb_putIA5String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutIA5String_Ljava_lang_String_);
			return cb_putIA5String_Ljava_lang_String_;
		}

		static void n_PutIA5String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.PutIA5String (s);
		}
#pragma warning restore 0169

		static IntPtr id_putIA5String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putIA5String' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putIA5String", "(Ljava/lang/String;)V", "GetPutIA5String_Ljava_lang_String_Handler")]
		public virtual unsafe void PutIA5String (string s)
		{
			if (id_putIA5String_Ljava_lang_String_ == IntPtr.Zero)
				id_putIA5String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putIA5String", "(Ljava/lang/String;)V");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putIA5String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putIA5String", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_putInteger_I;
#pragma warning disable 0169
		static Delegate GetPutInteger_IHandler ()
		{
			if (cb_putInteger_I == null)
				cb_putInteger_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_PutInteger_I);
			return cb_putInteger_I;
		}

		static void n_PutInteger_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PutInteger (i);
		}
#pragma warning restore 0169

		static IntPtr id_putInteger_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putInteger' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("putInteger", "(I)V", "GetPutInteger_IHandler")]
		public virtual unsafe void PutInteger (int i)
		{
			if (id_putInteger_I == IntPtr.Zero)
				id_putInteger_I = JNIEnv.GetMethodID (class_ref, "putInteger", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putInteger_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putInteger", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putInteger_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetPutInteger_Ljava_lang_Integer_Handler ()
		{
			if (cb_putInteger_Ljava_lang_Integer_ == null)
				cb_putInteger_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutInteger_Ljava_lang_Integer_);
			return cb_putInteger_Ljava_lang_Integer_;
		}

		static void n_PutInteger_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_i)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer i = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_i, JniHandleOwnership.DoNotTransfer);
			__this.PutInteger (i);
		}
#pragma warning restore 0169

		static IntPtr id_putInteger_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putInteger' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("putInteger", "(Ljava/lang/Integer;)V", "GetPutInteger_Ljava_lang_Integer_Handler")]
		public virtual unsafe void PutInteger (global::Java.Lang.Integer i)
		{
			if (id_putInteger_Ljava_lang_Integer_ == IntPtr.Zero)
				id_putInteger_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "putInteger", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putInteger_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putInteger", "(Ljava/lang/Integer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putInteger_Ljava_math_BigInteger_;
#pragma warning disable 0169
		static Delegate GetPutInteger_Ljava_math_BigInteger_Handler ()
		{
			if (cb_putInteger_Ljava_math_BigInteger_ == null)
				cb_putInteger_Ljava_math_BigInteger_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutInteger_Ljava_math_BigInteger_);
			return cb_putInteger_Ljava_math_BigInteger_;
		}

		static void n_PutInteger_Ljava_math_BigInteger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_i)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigInteger i = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_i, JniHandleOwnership.DoNotTransfer);
			__this.PutInteger (i);
		}
#pragma warning restore 0169

		static IntPtr id_putInteger_Ljava_math_BigInteger_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putInteger' and count(parameter)=1 and parameter[1][@type='java.math.BigInteger']]"
		[Register ("putInteger", "(Ljava/math/BigInteger;)V", "GetPutInteger_Ljava_math_BigInteger_Handler")]
		public virtual unsafe void PutInteger (global::Java.Math.BigInteger i)
		{
			if (id_putInteger_Ljava_math_BigInteger_ == IntPtr.Zero)
				id_putInteger_Ljava_math_BigInteger_ = JNIEnv.GetMethodID (class_ref, "putInteger", "(Ljava/math/BigInteger;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (i);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putInteger_Ljava_math_BigInteger_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putInteger", "(Ljava/math/BigInteger;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putLength_I;
#pragma warning disable 0169
		static Delegate GetPutLength_IHandler ()
		{
			if (cb_putLength_I == null)
				cb_putLength_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_PutLength_I);
			return cb_putLength_I;
		}

		static void n_PutLength_I (IntPtr jnienv, IntPtr native__this, int len)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PutLength (len);
		}
#pragma warning restore 0169

		static IntPtr id_putLength_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putLength' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("putLength", "(I)V", "GetPutLength_IHandler")]
		public virtual unsafe void PutLength (int len)
		{
			if (id_putLength_I == IntPtr.Zero)
				id_putLength_I = JNIEnv.GetMethodID (class_ref, "putLength", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (len);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putLength_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putLength", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putNull;
#pragma warning disable 0169
		static Delegate GetPutNullHandler ()
		{
			if (cb_putNull == null)
				cb_putNull = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PutNull);
			return cb_putNull;
		}

		static void n_PutNull (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PutNull ();
		}
#pragma warning restore 0169

		static IntPtr id_putNull;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putNull' and count(parameter)=0]"
		[Register ("putNull", "()V", "GetPutNullHandler")]
		public virtual unsafe void PutNull ()
		{
			if (id_putNull == IntPtr.Zero)
				id_putNull = JNIEnv.GetMethodID (class_ref, "putNull", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putNull);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putNull", "()V"));
			} finally {
			}
		}

		static Delegate cb_putOID_Lsun_security_util_ObjectIdentifier_;
#pragma warning disable 0169
		static Delegate GetPutOID_Lsun_security_util_ObjectIdentifier_Handler ()
		{
			if (cb_putOID_Lsun_security_util_ObjectIdentifier_ == null)
				cb_putOID_Lsun_security_util_ObjectIdentifier_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutOID_Lsun_security_util_ObjectIdentifier_);
			return cb_putOID_Lsun_security_util_ObjectIdentifier_;
		}

		static void n_PutOID_Lsun_security_util_ObjectIdentifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oid)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.ObjectIdentifier oid = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (native_oid, JniHandleOwnership.DoNotTransfer);
			__this.PutOID (oid);
		}
#pragma warning restore 0169

		static IntPtr id_putOID_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putOID' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Register ("putOID", "(Lsun/security/util/ObjectIdentifier;)V", "GetPutOID_Lsun_security_util_ObjectIdentifier_Handler")]
		public virtual unsafe void PutOID (global::Sun.Security.Util.ObjectIdentifier oid)
		{
			if (id_putOID_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
				id_putOID_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetMethodID (class_ref, "putOID", "(Lsun/security/util/ObjectIdentifier;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (oid);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putOID_Lsun_security_util_ObjectIdentifier_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putOID", "(Lsun/security/util/ObjectIdentifier;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putOctetString_arrayB;
#pragma warning disable 0169
		static Delegate GetPutOctetString_arrayBHandler ()
		{
			if (cb_putOctetString_arrayB == null)
				cb_putOctetString_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutOctetString_arrayB);
			return cb_putOctetString_arrayB;
		}

		static void n_PutOctetString_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_octets)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] octets = (byte[]) JNIEnv.GetArray (native_octets, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PutOctetString (octets);
			if (octets != null)
				JNIEnv.CopyArray (octets, native_octets);
		}
#pragma warning restore 0169

		static IntPtr id_putOctetString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putOctetString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("putOctetString", "([B)V", "GetPutOctetString_arrayBHandler")]
		public virtual unsafe void PutOctetString (byte[] octets)
		{
			if (id_putOctetString_arrayB == IntPtr.Zero)
				id_putOctetString_arrayB = JNIEnv.GetMethodID (class_ref, "putOctetString", "([B)V");
			IntPtr native_octets = JNIEnv.NewArray (octets);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_octets);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putOctetString_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putOctetString", "([B)V"), __args);
			} finally {
				if (octets != null) {
					JNIEnv.CopyArray (native_octets, octets);
					JNIEnv.DeleteLocalRef (native_octets);
				}
			}
		}

		static Delegate cb_putOrderedSet_BarrayLsun_security_util_DerEncoder_;
#pragma warning disable 0169
		static Delegate GetPutOrderedSet_BarrayLsun_security_util_DerEncoder_Handler ()
		{
			if (cb_putOrderedSet_BarrayLsun_security_util_DerEncoder_ == null)
				cb_putOrderedSet_BarrayLsun_security_util_DerEncoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, IntPtr>) n_PutOrderedSet_BarrayLsun_security_util_DerEncoder_);
			return cb_putOrderedSet_BarrayLsun_security_util_DerEncoder_;
		}

		static void n_PutOrderedSet_BarrayLsun_security_util_DerEncoder_ (IntPtr jnienv, IntPtr native__this, sbyte tag, IntPtr native_set)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.IDerEncoder[] set = (global::Sun.Security.Util.IDerEncoder[]) JNIEnv.GetArray (native_set, JniHandleOwnership.DoNotTransfer, typeof (global::Sun.Security.Util.IDerEncoder));
			__this.PutOrderedSet (tag, set);
			if (set != null)
				JNIEnv.CopyArray (set, native_set);
		}
#pragma warning restore 0169

		static IntPtr id_putOrderedSet_BarrayLsun_security_util_DerEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putOrderedSet' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='sun.security.util.DerEncoder[]']]"
		[Register ("putOrderedSet", "(B[Lsun/security/util/DerEncoder;)V", "GetPutOrderedSet_BarrayLsun_security_util_DerEncoder_Handler")]
		public virtual unsafe void PutOrderedSet (sbyte tag, global::Sun.Security.Util.IDerEncoder[] set)
		{
			if (id_putOrderedSet_BarrayLsun_security_util_DerEncoder_ == IntPtr.Zero)
				id_putOrderedSet_BarrayLsun_security_util_DerEncoder_ = JNIEnv.GetMethodID (class_ref, "putOrderedSet", "(B[Lsun/security/util/DerEncoder;)V");
			IntPtr native_set = JNIEnv.NewArray (set);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (tag);
				__args [1] = new JValue (native_set);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putOrderedSet_BarrayLsun_security_util_DerEncoder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putOrderedSet", "(B[Lsun/security/util/DerEncoder;)V"), __args);
			} finally {
				if (set != null) {
					JNIEnv.CopyArray (native_set, set);
					JNIEnv.DeleteLocalRef (native_set);
				}
			}
		}

		static Delegate cb_putOrderedSetOf_BarrayLsun_security_util_DerEncoder_;
#pragma warning disable 0169
		static Delegate GetPutOrderedSetOf_BarrayLsun_security_util_DerEncoder_Handler ()
		{
			if (cb_putOrderedSetOf_BarrayLsun_security_util_DerEncoder_ == null)
				cb_putOrderedSetOf_BarrayLsun_security_util_DerEncoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, IntPtr>) n_PutOrderedSetOf_BarrayLsun_security_util_DerEncoder_);
			return cb_putOrderedSetOf_BarrayLsun_security_util_DerEncoder_;
		}

		static void n_PutOrderedSetOf_BarrayLsun_security_util_DerEncoder_ (IntPtr jnienv, IntPtr native__this, sbyte tag, IntPtr native_set)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.IDerEncoder[] set = (global::Sun.Security.Util.IDerEncoder[]) JNIEnv.GetArray (native_set, JniHandleOwnership.DoNotTransfer, typeof (global::Sun.Security.Util.IDerEncoder));
			__this.PutOrderedSetOf (tag, set);
			if (set != null)
				JNIEnv.CopyArray (set, native_set);
		}
#pragma warning restore 0169

		static IntPtr id_putOrderedSetOf_BarrayLsun_security_util_DerEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putOrderedSetOf' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='sun.security.util.DerEncoder[]']]"
		[Register ("putOrderedSetOf", "(B[Lsun/security/util/DerEncoder;)V", "GetPutOrderedSetOf_BarrayLsun_security_util_DerEncoder_Handler")]
		public virtual unsafe void PutOrderedSetOf (sbyte tag, global::Sun.Security.Util.IDerEncoder[] set)
		{
			if (id_putOrderedSetOf_BarrayLsun_security_util_DerEncoder_ == IntPtr.Zero)
				id_putOrderedSetOf_BarrayLsun_security_util_DerEncoder_ = JNIEnv.GetMethodID (class_ref, "putOrderedSetOf", "(B[Lsun/security/util/DerEncoder;)V");
			IntPtr native_set = JNIEnv.NewArray (set);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (tag);
				__args [1] = new JValue (native_set);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putOrderedSetOf_BarrayLsun_security_util_DerEncoder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putOrderedSetOf", "(B[Lsun/security/util/DerEncoder;)V"), __args);
			} finally {
				if (set != null) {
					JNIEnv.CopyArray (native_set, set);
					JNIEnv.DeleteLocalRef (native_set);
				}
			}
		}

		static Delegate cb_putPrintableString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutPrintableString_Ljava_lang_String_Handler ()
		{
			if (cb_putPrintableString_Ljava_lang_String_ == null)
				cb_putPrintableString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutPrintableString_Ljava_lang_String_);
			return cb_putPrintableString_Ljava_lang_String_;
		}

		static void n_PutPrintableString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.PutPrintableString (s);
		}
#pragma warning restore 0169

		static IntPtr id_putPrintableString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putPrintableString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putPrintableString", "(Ljava/lang/String;)V", "GetPutPrintableString_Ljava_lang_String_Handler")]
		public virtual unsafe void PutPrintableString (string s)
		{
			if (id_putPrintableString_Ljava_lang_String_ == IntPtr.Zero)
				id_putPrintableString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putPrintableString", "(Ljava/lang/String;)V");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putPrintableString_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putPrintableString", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_putT61String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutT61String_Ljava_lang_String_Handler ()
		{
			if (cb_putT61String_Ljava_lang_String_ == null)
				cb_putT61String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutT61String_Ljava_lang_String_);
			return cb_putT61String_Ljava_lang_String_;
		}

		static void n_PutT61String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.PutT61String (s);
		}
#pragma warning restore 0169

		static IntPtr id_putT61String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putT61String' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putT61String", "(Ljava/lang/String;)V", "GetPutT61String_Ljava_lang_String_Handler")]
		public virtual unsafe void PutT61String (string s)
		{
			if (id_putT61String_Ljava_lang_String_ == IntPtr.Zero)
				id_putT61String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putT61String", "(Ljava/lang/String;)V");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putT61String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putT61String", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_putTag_BZB;
#pragma warning disable 0169
		static Delegate GetPutTag_BZBHandler ()
		{
			if (cb_putTag_BZB == null)
				cb_putTag_BZB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, bool, sbyte>) n_PutTag_BZB);
			return cb_putTag_BZB;
		}

		static void n_PutTag_BZB (IntPtr jnienv, IntPtr native__this, sbyte tagClass, bool form, sbyte val)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PutTag (tagClass, form, val);
		}
#pragma warning restore 0169

		static IntPtr id_putTag_BZB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putTag' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='boolean'] and parameter[3][@type='byte']]"
		[Register ("putTag", "(BZB)V", "GetPutTag_BZBHandler")]
		public virtual unsafe void PutTag (sbyte tagClass, bool form, sbyte val)
		{
			if (id_putTag_BZB == IntPtr.Zero)
				id_putTag_BZB = JNIEnv.GetMethodID (class_ref, "putTag", "(BZB)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (tagClass);
				__args [1] = new JValue (form);
				__args [2] = new JValue (val);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putTag_BZB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putTag", "(BZB)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putTruncatedUnalignedBitString_Lsun_security_util_BitArray_;
#pragma warning disable 0169
		static Delegate GetPutTruncatedUnalignedBitString_Lsun_security_util_BitArray_Handler ()
		{
			if (cb_putTruncatedUnalignedBitString_Lsun_security_util_BitArray_ == null)
				cb_putTruncatedUnalignedBitString_Lsun_security_util_BitArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutTruncatedUnalignedBitString_Lsun_security_util_BitArray_);
			return cb_putTruncatedUnalignedBitString_Lsun_security_util_BitArray_;
		}

		static void n_PutTruncatedUnalignedBitString_Lsun_security_util_BitArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ba)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.BitArray ba = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (native_ba, JniHandleOwnership.DoNotTransfer);
			__this.PutTruncatedUnalignedBitString (ba);
		}
#pragma warning restore 0169

		static IntPtr id_putTruncatedUnalignedBitString_Lsun_security_util_BitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putTruncatedUnalignedBitString' and count(parameter)=1 and parameter[1][@type='sun.security.util.BitArray']]"
		[Register ("putTruncatedUnalignedBitString", "(Lsun/security/util/BitArray;)V", "GetPutTruncatedUnalignedBitString_Lsun_security_util_BitArray_Handler")]
		public virtual unsafe void PutTruncatedUnalignedBitString (global::Sun.Security.Util.BitArray ba)
		{
			if (id_putTruncatedUnalignedBitString_Lsun_security_util_BitArray_ == IntPtr.Zero)
				id_putTruncatedUnalignedBitString_Lsun_security_util_BitArray_ = JNIEnv.GetMethodID (class_ref, "putTruncatedUnalignedBitString", "(Lsun/security/util/BitArray;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ba);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putTruncatedUnalignedBitString_Lsun_security_util_BitArray_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putTruncatedUnalignedBitString", "(Lsun/security/util/BitArray;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putUTCTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetPutUTCTime_Ljava_util_Date_Handler ()
		{
			if (cb_putUTCTime_Ljava_util_Date_ == null)
				cb_putUTCTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutUTCTime_Ljava_util_Date_);
			return cb_putUTCTime_Ljava_util_Date_;
		}

		static void n_PutUTCTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date d = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_d, JniHandleOwnership.DoNotTransfer);
			__this.PutUTCTime (d);
		}
#pragma warning restore 0169

		static IntPtr id_putUTCTime_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putUTCTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("putUTCTime", "(Ljava/util/Date;)V", "GetPutUTCTime_Ljava_util_Date_Handler")]
		public virtual unsafe void PutUTCTime (global::Java.Util.Date d)
		{
			if (id_putUTCTime_Ljava_util_Date_ == IntPtr.Zero)
				id_putUTCTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "putUTCTime", "(Ljava/util/Date;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (d);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putUTCTime_Ljava_util_Date_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putUTCTime", "(Ljava/util/Date;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putUTF8String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutUTF8String_Ljava_lang_String_Handler ()
		{
			if (cb_putUTF8String_Ljava_lang_String_ == null)
				cb_putUTF8String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutUTF8String_Ljava_lang_String_);
			return cb_putUTF8String_Ljava_lang_String_;
		}

		static void n_PutUTF8String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.PutUTF8String (s);
		}
#pragma warning restore 0169

		static IntPtr id_putUTF8String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putUTF8String' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putUTF8String", "(Ljava/lang/String;)V", "GetPutUTF8String_Ljava_lang_String_Handler")]
		public virtual unsafe void PutUTF8String (string s)
		{
			if (id_putUTF8String_Ljava_lang_String_ == IntPtr.Zero)
				id_putUTF8String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putUTF8String", "(Ljava/lang/String;)V");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putUTF8String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putUTF8String", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_putUnalignedBitString_Lsun_security_util_BitArray_;
#pragma warning disable 0169
		static Delegate GetPutUnalignedBitString_Lsun_security_util_BitArray_Handler ()
		{
			if (cb_putUnalignedBitString_Lsun_security_util_BitArray_ == null)
				cb_putUnalignedBitString_Lsun_security_util_BitArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutUnalignedBitString_Lsun_security_util_BitArray_);
			return cb_putUnalignedBitString_Lsun_security_util_BitArray_;
		}

		static void n_PutUnalignedBitString_Lsun_security_util_BitArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ba)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.BitArray ba = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (native_ba, JniHandleOwnership.DoNotTransfer);
			__this.PutUnalignedBitString (ba);
		}
#pragma warning restore 0169

		static IntPtr id_putUnalignedBitString_Lsun_security_util_BitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='putUnalignedBitString' and count(parameter)=1 and parameter[1][@type='sun.security.util.BitArray']]"
		[Register ("putUnalignedBitString", "(Lsun/security/util/BitArray;)V", "GetPutUnalignedBitString_Lsun_security_util_BitArray_Handler")]
		public virtual unsafe void PutUnalignedBitString (global::Sun.Security.Util.BitArray ba)
		{
			if (id_putUnalignedBitString_Lsun_security_util_BitArray_ == IntPtr.Zero)
				id_putUnalignedBitString_Lsun_security_util_BitArray_ = JNIEnv.GetMethodID (class_ref, "putUnalignedBitString", "(Lsun/security/util/BitArray;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ba);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putUnalignedBitString_Lsun_security_util_BitArray_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putUnalignedBitString", "(Lsun/security/util/BitArray;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_BarrayB;
#pragma warning disable 0169
		static Delegate GetWrite_BarrayBHandler ()
		{
			if (cb_write_BarrayB == null)
				cb_write_BarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, IntPtr>) n_Write_BarrayB);
			return cb_write_BarrayB;
		}

		static void n_Write_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte tag, IntPtr native_buf)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] buf = (byte[]) JNIEnv.GetArray (native_buf, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Write (tag, buf);
			if (buf != null)
				JNIEnv.CopyArray (buf, native_buf);
		}
#pragma warning restore 0169

		static IntPtr id_write_BarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("write", "(B[B)V", "GetWrite_BarrayBHandler")]
		public virtual unsafe void Write (sbyte tag, byte[] buf)
		{
			if (id_write_BarrayB == IntPtr.Zero)
				id_write_BarrayB = JNIEnv.GetMethodID (class_ref, "write", "(B[B)V");
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (tag);
				__args [1] = new JValue (native_buf);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_BarrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(B[B)V"), __args);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
			}
		}

		static Delegate cb_write_BLsun_security_util_DerOutputStream_;
#pragma warning disable 0169
		static Delegate GetWrite_BLsun_security_util_DerOutputStream_Handler ()
		{
			if (cb_write_BLsun_security_util_DerOutputStream_ == null)
				cb_write_BLsun_security_util_DerOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, IntPtr>) n_Write_BLsun_security_util_DerOutputStream_);
			return cb_write_BLsun_security_util_DerOutputStream_;
		}

		static void n_Write_BLsun_security_util_DerOutputStream_ (IntPtr jnienv, IntPtr native__this, sbyte tag, IntPtr native__out)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Write (tag, @out);
		}
#pragma warning restore 0169

		static IntPtr id_write_BLsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='sun.security.util.DerOutputStream']]"
		[Register ("write", "(BLsun/security/util/DerOutputStream;)V", "GetWrite_BLsun_security_util_DerOutputStream_Handler")]
		public virtual unsafe void Write (sbyte tag, global::Sun.Security.Util.DerOutputStream @out)
		{
			if (id_write_BLsun_security_util_DerOutputStream_ == IntPtr.Zero)
				id_write_BLsun_security_util_DerOutputStream_ = JNIEnv.GetMethodID (class_ref, "write", "(BLsun/security/util/DerOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (tag);
				__args [1] = new JValue (@out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_BLsun_security_util_DerOutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(BLsun/security/util/DerOutputStream;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeImplicit_BLsun_security_util_DerOutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteImplicit_BLsun_security_util_DerOutputStream_Handler ()
		{
			if (cb_writeImplicit_BLsun_security_util_DerOutputStream_ == null)
				cb_writeImplicit_BLsun_security_util_DerOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, IntPtr>) n_WriteImplicit_BLsun_security_util_DerOutputStream_);
			return cb_writeImplicit_BLsun_security_util_DerOutputStream_;
		}

		static void n_WriteImplicit_BLsun_security_util_DerOutputStream_ (IntPtr jnienv, IntPtr native__this, sbyte tag, IntPtr native_value)
		{
			global::Sun.Security.Util.DerOutputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream value = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.WriteImplicit (tag, value);
		}
#pragma warning restore 0169

		static IntPtr id_writeImplicit_BLsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerOutputStream']/method[@name='writeImplicit' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='sun.security.util.DerOutputStream']]"
		[Register ("writeImplicit", "(BLsun/security/util/DerOutputStream;)V", "GetWriteImplicit_BLsun_security_util_DerOutputStream_Handler")]
		public virtual unsafe void WriteImplicit (sbyte tag, global::Sun.Security.Util.DerOutputStream value)
		{
			if (id_writeImplicit_BLsun_security_util_DerOutputStream_ == IntPtr.Zero)
				id_writeImplicit_BLsun_security_util_DerOutputStream_ = JNIEnv.GetMethodID (class_ref, "writeImplicit", "(BLsun/security/util/DerOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (tag);
				__args [1] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeImplicit_BLsun_security_util_DerOutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeImplicit", "(BLsun/security/util/DerOutputStream;)V"), __args);
			} finally {
			}
		}

	}
}
