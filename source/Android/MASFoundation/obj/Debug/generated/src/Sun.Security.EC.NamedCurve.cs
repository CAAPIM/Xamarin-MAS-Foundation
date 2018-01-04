using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.EC {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.ec']/class[@name='NamedCurve']"
	[global::Android.Runtime.Register ("sun/security/ec/NamedCurve", DoNotGenerateAcw=true)]
	public sealed partial class NamedCurve : global::Java.Security.Spec.ECParameterSpec {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/ec/NamedCurve", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NamedCurve); }
		}

		internal NamedCurve (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getECParameterSpec_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='NamedCurve']/method[@name='getECParameterSpec' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getECParameterSpec", "(I)Ljava/security/spec/ECParameterSpec;", "")]
		public static unsafe global::Java.Security.Spec.ECParameterSpec GetECParameterSpec (int length)
		{
			if (id_getECParameterSpec_I == IntPtr.Zero)
				id_getECParameterSpec_I = JNIEnv.GetStaticMethodID (class_ref, "getECParameterSpec", "(I)Ljava/security/spec/ECParameterSpec;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (length);
				return global::Java.Lang.Object.GetObject<global::Java.Security.Spec.ECParameterSpec> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getECParameterSpec_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getECParameterSpec_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='NamedCurve']/method[@name='getECParameterSpec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getECParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/ECParameterSpec;", "")]
		public static unsafe global::Java.Security.Spec.ECParameterSpec GetECParameterSpec (string name)
		{
			if (id_getECParameterSpec_Ljava_lang_String_ == IntPtr.Zero)
				id_getECParameterSpec_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getECParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/ECParameterSpec;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Java.Security.Spec.ECParameterSpec __ret = global::Java.Lang.Object.GetObject<global::Java.Security.Spec.ECParameterSpec> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getECParameterSpec_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_knownECParameterSpecs;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='NamedCurve']/method[@name='knownECParameterSpecs' and count(parameter)=0]"
		[Register ("knownECParameterSpecs", "()Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Security.Spec.ECParameterSpec> KnownECParameterSpecs ()
		{
			if (id_knownECParameterSpecs == IntPtr.Zero)
				id_knownECParameterSpecs = JNIEnv.GetStaticMethodID (class_ref, "knownECParameterSpecs", "()Ljava/util/Collection;");
			try {
				return global::Android.Runtime.JavaCollection<global::Java.Security.Spec.ECParameterSpec>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_knownECParameterSpecs), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
