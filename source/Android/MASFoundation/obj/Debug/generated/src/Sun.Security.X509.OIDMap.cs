using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='OIDMap']"
	[global::Android.Runtime.Register ("sun/security/x509/OIDMap", DoNotGenerateAcw=true)]
	public partial class OIDMap : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/OIDMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OIDMap); }
		}

		protected OIDMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_addAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OIDMap']/method[@name='addAttribute' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class']]"
		[Register ("addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public static unsafe void AddAttribute (string name, string oid, global::Java.Lang.Class clazz)
		{
			if (id_addAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_addAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "addAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Class;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_oid = JNIEnv.NewString (oid);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (native_oid);
				__args [2] = new JValue (clazz);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addAttribute_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_oid);
			}
		}

		static IntPtr id_getClass_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OIDMap']/method[@name='getClass' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClass", "(Ljava/lang/String;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class GetClass (string name)
		{
			if (id_getClass_Ljava_lang_String_ == IntPtr.Zero)
				id_getClass_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClass_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_getClass_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OIDMap']/method[@name='getClass' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Register ("getClass", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/Class;", "")]
		public static unsafe global::Java.Lang.Class GetClass (global::Sun.Security.Util.ObjectIdentifier oid)
		{
			if (id_getClass_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
				id_getClass_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetStaticMethodID (class_ref, "getClass", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/Class;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (oid);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getClass_Lsun_security_util_ObjectIdentifier_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getName_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OIDMap']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Register ("getName", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/String;", "")]
		public static unsafe string GetName (global::Sun.Security.Util.ObjectIdentifier oid)
		{
			if (id_getName_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
				id_getName_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetStaticMethodID (class_ref, "getName", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (oid);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getName_Lsun_security_util_ObjectIdentifier_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getOID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OIDMap']/method[@name='getOID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOID", "(Ljava/lang/String;)Lsun/security/util/ObjectIdentifier;", "")]
		public static unsafe global::Sun.Security.Util.ObjectIdentifier GetOID (string name)
		{
			if (id_getOID_Ljava_lang_String_ == IntPtr.Zero)
				id_getOID_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getOID", "(Ljava/lang/String;)Lsun/security/util/ObjectIdentifier;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Sun.Security.Util.ObjectIdentifier __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOID_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
