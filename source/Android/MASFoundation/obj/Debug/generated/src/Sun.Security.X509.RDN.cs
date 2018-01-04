using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']"
	[global::Android.Runtime.Register ("sun/security/x509/RDN", DoNotGenerateAcw=true)]
	public partial class RDN : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/RDN", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RDN); }
		}

		protected RDN (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/constructor[@name='RDN' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe RDN (string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				if (((object) this).GetType () != typeof (RDN)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/constructor[@name='RDN' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe RDN (string name, global::System.Collections.Generic.IDictionary<string, string> keywordMap)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_keywordMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (keywordMap);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (native_keywordMap);
				if (((object) this).GetType () != typeof (RDN)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_keywordMap);
			}
		}

		static IntPtr id_ctor_Lsun_security_x509_AVA_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/constructor[@name='RDN' and count(parameter)=1 and parameter[1][@type='sun.security.x509.AVA']]"
		[Register (".ctor", "(Lsun/security/x509/AVA;)V", "")]
		public unsafe RDN (global::Sun.Security.X509.AVA ava)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ava);
				if (((object) this).GetType () != typeof (RDN)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/AVA;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/AVA;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_AVA_ == IntPtr.Zero)
					id_ctor_Lsun_security_x509_AVA_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/AVA;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_AVA_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_AVA_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayLsun_security_x509_AVA_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/constructor[@name='RDN' and count(parameter)=1 and parameter[1][@type='sun.security.x509.AVA[]']]"
		[Register (".ctor", "([Lsun/security/x509/AVA;)V", "")]
		public unsafe RDN (global::Sun.Security.X509.AVA[] avas)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_avas = JNIEnv.NewArray (avas);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_avas);
				if (((object) this).GetType () != typeof (RDN)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lsun/security/x509/AVA;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lsun/security/x509/AVA;)V", __args);
					return;
				}

				if (id_ctor_arrayLsun_security_x509_AVA_ == IntPtr.Zero)
					id_ctor_arrayLsun_security_x509_AVA_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lsun/security/x509/AVA;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLsun_security_x509_AVA_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLsun_security_x509_AVA_, __args);
			} finally {
				if (avas != null) {
					JNIEnv.CopyArray (native_avas, avas);
					JNIEnv.DeleteLocalRef (native_avas);
				}
			}
		}

		static Delegate cb_avas;
#pragma warning disable 0169
		static Delegate GetAvasHandler ()
		{
			if (cb_avas == null)
				cb_avas = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Avas);
			return cb_avas;
		}

		static IntPtr n_Avas (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.RDN __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.RDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Sun.Security.X509.AVA>.ToLocalJniHandle (__this.Avas ());
		}
#pragma warning restore 0169

		static IntPtr id_avas;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/method[@name='avas' and count(parameter)=0]"
		[Register ("avas", "()Ljava/util/List;", "GetAvasHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Sun.Security.X509.AVA> Avas ()
		{
			if (id_avas == IntPtr.Zero)
				id_avas = JNIEnv.GetMethodID (class_ref, "avas", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Sun.Security.X509.AVA>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_avas), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Sun.Security.X509.AVA>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "avas", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.RDN __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.RDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
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
			global::Sun.Security.X509.RDN __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.RDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToRFC1779String ());
		}
#pragma warning restore 0169

		static IntPtr id_toRFC1779String;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/method[@name='toRFC1779String' and count(parameter)=0]"
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
			global::Sun.Security.X509.RDN __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.RDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oidMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_oidMap, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToRFC1779String (oidMap));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toRFC1779String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/method[@name='toRFC1779String' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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
			global::Sun.Security.X509.RDN __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.RDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToRFC2253String ());
		}
#pragma warning restore 0169

		static IntPtr id_toRFC2253String;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/method[@name='toRFC2253String' and count(parameter)=0]"
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

		static Delegate cb_toRFC2253String_Z;
#pragma warning disable 0169
		static Delegate GetToRFC2253String_ZHandler ()
		{
			if (cb_toRFC2253String_Z == null)
				cb_toRFC2253String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ToRFC2253String_Z);
			return cb_toRFC2253String_Z;
		}

		static IntPtr n_ToRFC2253String_Z (IntPtr jnienv, IntPtr native__this, bool canonical)
		{
			global::Sun.Security.X509.RDN __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.RDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToRFC2253String (canonical));
		}
#pragma warning restore 0169

		static IntPtr id_toRFC2253String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/method[@name='toRFC2253String' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("toRFC2253String", "(Z)Ljava/lang/String;", "GetToRFC2253String_ZHandler")]
		public virtual unsafe string ToRFC2253String (bool canonical)
		{
			if (id_toRFC2253String_Z == IntPtr.Zero)
				id_toRFC2253String_Z = JNIEnv.GetMethodID (class_ref, "toRFC2253String", "(Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (canonical);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toRFC2253String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toRFC2253String", "(Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.RDN __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.RDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oidMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_oidMap, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ToRFC2253String (oidMap));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toRFC2253String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='RDN']/method[@name='toRFC2253String' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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
