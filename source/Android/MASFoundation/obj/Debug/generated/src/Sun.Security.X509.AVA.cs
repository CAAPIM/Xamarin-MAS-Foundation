using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='AVA']"
	[global::Android.Runtime.Register ("sun/security/x509/AVA", DoNotGenerateAcw=true)]
	public partial class AVA : global::Java.Lang.Object, global::Sun.Security.Util.IDerEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/AVA", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AVA); }
		}

		protected AVA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getObjectIdentifier;
#pragma warning disable 0169
		static Delegate GetGetObjectIdentifierHandler ()
		{
			if (cb_getObjectIdentifier == null)
				cb_getObjectIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObjectIdentifier);
			return cb_getObjectIdentifier;
		}

		static IntPtr n_GetObjectIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.AVA __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AVA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObjectIdentifier);
		}
#pragma warning restore 0169

		static IntPtr id_getObjectIdentifier;
		public virtual unsafe global::Sun.Security.Util.ObjectIdentifier ObjectIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AVA']/method[@name='getObjectIdentifier' and count(parameter)=0]"
			[Register ("getObjectIdentifier", "()Lsun/security/util/ObjectIdentifier;", "GetGetObjectIdentifierHandler")]
			get {
				if (id_getObjectIdentifier == IntPtr.Zero)
					id_getObjectIdentifier = JNIEnv.GetMethodID (class_ref, "getObjectIdentifier", "()Lsun/security/util/ObjectIdentifier;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObjectIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjectIdentifier", "()Lsun/security/util/ObjectIdentifier;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValueString;
#pragma warning disable 0169
		static Delegate GetGetValueStringHandler ()
		{
			if (cb_getValueString == null)
				cb_getValueString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueString);
			return cb_getValueString;
		}

		static IntPtr n_GetValueString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.AVA __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AVA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ValueString);
		}
#pragma warning restore 0169

		static IntPtr id_getValueString;
		public virtual unsafe string ValueString {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AVA']/method[@name='getValueString' and count(parameter)=0]"
			[Register ("getValueString", "()Ljava/lang/String;", "GetGetValueStringHandler")]
			get {
				if (id_getValueString == IntPtr.Zero)
					id_getValueString = JNIEnv.GetMethodID (class_ref, "getValueString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValueString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValueString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Sun.Security.X509.AVA __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AVA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.DerEncode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_derEncode_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AVA']/method[@name='derEncode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
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

		static Delegate cb_encode_Lsun_security_util_DerOutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Lsun_security_util_DerOutputStream_Handler ()
		{
			if (cb_encode_Lsun_security_util_DerOutputStream_ == null)
				cb_encode_Lsun_security_util_DerOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Encode_Lsun_security_util_DerOutputStream_);
			return cb_encode_Lsun_security_util_DerOutputStream_;
		}

		static void n_Encode_Lsun_security_util_DerOutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.X509.AVA __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AVA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AVA']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
		[Register ("encode", "(Lsun/security/util/DerOutputStream;)V", "GetEncode_Lsun_security_util_DerOutputStream_Handler")]
		public virtual unsafe void Encode (global::Sun.Security.Util.DerOutputStream @out)
		{
			if (id_encode_Lsun_security_util_DerOutputStream_ == IntPtr.Zero)
				id_encode_Lsun_security_util_DerOutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lsun/security/util/DerOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Lsun_security_util_DerOutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Lsun/security/util/DerOutputStream;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toRFC1779String;
#pragma warning disable 0169
		static Delegate GetToRFC1779StringHandler ()
		{
			if (cb_toRFC1779String == null)
				cb_toRFC1779String = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToRFC1779String);
			return cb_toRFC1779String;
		}

		static IntPtr n_ToRFC1779String (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.AVA __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AVA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToRFC1779String ());
		}
#pragma warning restore 0169

		static IntPtr id_toRFC1779String;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AVA']/method[@name='toRFC1779String' and count(parameter)=0]"
		[Register ("toRFC1779String", "()Ljava/lang/String;", "GetToRFC1779StringHandler")]
		public virtual unsafe string ToRFC1779String ()
		{
			if (id_toRFC1779String == IntPtr.Zero)
				id_toRFC1779String = JNIEnv.GetMethodID (class_ref, "toRFC1779String", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toRFC1779String), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toRFC1779String", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toRFC1779String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetToRFC1779String_Ljava_util_Map_Handler ()
		{
			if (cb_toRFC1779String_Ljava_util_Map_ == null)
				cb_toRFC1779String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToRFC1779String_Ljava_util_Map_);
			return cb_toRFC1779String_Ljava_util_Map_;
		}

		static IntPtr n_ToRFC1779String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oidMap)
		{
			global::Sun.Security.X509.AVA __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AVA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oidMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_oidMap, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToRFC1779String (oidMap));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toRFC1779String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AVA']/method[@name='toRFC1779String' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("toRFC1779String", "(Ljava/util/Map;)Ljava/lang/String;", "GetToRFC1779String_Ljava_util_Map_Handler")]
		public virtual unsafe string ToRFC1779String (global::System.Collections.Generic.IDictionary<string, string> oidMap)
		{
			if (id_toRFC1779String_Ljava_util_Map_ == IntPtr.Zero)
				id_toRFC1779String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "toRFC1779String", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_oidMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (oidMap);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_oidMap);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toRFC1779String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toRFC1779String", "(Ljava/util/Map;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_oidMap);
			}
		}

		static Delegate cb_toRFC2253CanonicalString;
#pragma warning disable 0169
		static Delegate GetToRFC2253CanonicalStringHandler ()
		{
			if (cb_toRFC2253CanonicalString == null)
				cb_toRFC2253CanonicalString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToRFC2253CanonicalString);
			return cb_toRFC2253CanonicalString;
		}

		static IntPtr n_ToRFC2253CanonicalString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.AVA __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AVA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToRFC2253CanonicalString ());
		}
#pragma warning restore 0169

		static IntPtr id_toRFC2253CanonicalString;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AVA']/method[@name='toRFC2253CanonicalString' and count(parameter)=0]"
		[Register ("toRFC2253CanonicalString", "()Ljava/lang/String;", "GetToRFC2253CanonicalStringHandler")]
		public virtual unsafe string ToRFC2253CanonicalString ()
		{
			if (id_toRFC2253CanonicalString == IntPtr.Zero)
				id_toRFC2253CanonicalString = JNIEnv.GetMethodID (class_ref, "toRFC2253CanonicalString", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toRFC2253CanonicalString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toRFC2253CanonicalString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toRFC2253String;
#pragma warning disable 0169
		static Delegate GetToRFC2253StringHandler ()
		{
			if (cb_toRFC2253String == null)
				cb_toRFC2253String = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToRFC2253String);
			return cb_toRFC2253String;
		}

		static IntPtr n_ToRFC2253String (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.AVA __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AVA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToRFC2253String ());
		}
#pragma warning restore 0169

		static IntPtr id_toRFC2253String;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AVA']/method[@name='toRFC2253String' and count(parameter)=0]"
		[Register ("toRFC2253String", "()Ljava/lang/String;", "GetToRFC2253StringHandler")]
		public virtual unsafe string ToRFC2253String ()
		{
			if (id_toRFC2253String == IntPtr.Zero)
				id_toRFC2253String = JNIEnv.GetMethodID (class_ref, "toRFC2253String", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toRFC2253String), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toRFC2253String", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toRFC2253String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetToRFC2253String_Ljava_util_Map_Handler ()
		{
			if (cb_toRFC2253String_Ljava_util_Map_ == null)
				cb_toRFC2253String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToRFC2253String_Ljava_util_Map_);
			return cb_toRFC2253String_Ljava_util_Map_;
		}

		static IntPtr n_ToRFC2253String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oidMap)
		{
			global::Sun.Security.X509.AVA __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AVA> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oidMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_oidMap, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToRFC2253String (oidMap));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toRFC2253String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AVA']/method[@name='toRFC2253String' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("toRFC2253String", "(Ljava/util/Map;)Ljava/lang/String;", "GetToRFC2253String_Ljava_util_Map_Handler")]
		public virtual unsafe string ToRFC2253String (global::System.Collections.Generic.IDictionary<string, string> oidMap)
		{
			if (id_toRFC2253String_Ljava_util_Map_ == IntPtr.Zero)
				id_toRFC2253String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "toRFC2253String", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_oidMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (oidMap);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_oidMap);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toRFC2253String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toRFC2253String", "(Ljava/util/Map;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_oidMap);
			}
		}

	}
}
