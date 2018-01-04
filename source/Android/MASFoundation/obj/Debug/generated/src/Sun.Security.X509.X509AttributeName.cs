using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='X509AttributeName']"
	[global::Android.Runtime.Register ("sun/security/x509/X509AttributeName", DoNotGenerateAcw=true)]
	public partial class X509AttributeName : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/X509AttributeName", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (X509AttributeName); }
		}

		protected X509AttributeName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509AttributeName']/constructor[@name='X509AttributeName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe X509AttributeName (string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				if (((object) this).GetType () != typeof (X509AttributeName)) {
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

		static Delegate cb_getPrefix;
#pragma warning disable 0169
		static Delegate GetGetPrefixHandler ()
		{
			if (cb_getPrefix == null)
				cb_getPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrefix);
			return cb_getPrefix;
		}

		static IntPtr n_GetPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509AttributeName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509AttributeName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Prefix);
		}
#pragma warning restore 0169

		static IntPtr id_getPrefix;
		public virtual unsafe string Prefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509AttributeName']/method[@name='getPrefix' and count(parameter)=0]"
			[Register ("getPrefix", "()Ljava/lang/String;", "GetGetPrefixHandler")]
			get {
				if (id_getPrefix == IntPtr.Zero)
					id_getPrefix = JNIEnv.GetMethodID (class_ref, "getPrefix", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrefix), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrefix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSuffix;
#pragma warning disable 0169
		static Delegate GetGetSuffixHandler ()
		{
			if (cb_getSuffix == null)
				cb_getSuffix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuffix);
			return cb_getSuffix;
		}

		static IntPtr n_GetSuffix (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509AttributeName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509AttributeName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Suffix);
		}
#pragma warning restore 0169

		static IntPtr id_getSuffix;
		public virtual unsafe string Suffix {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509AttributeName']/method[@name='getSuffix' and count(parameter)=0]"
			[Register ("getSuffix", "()Ljava/lang/String;", "GetGetSuffixHandler")]
			get {
				if (id_getSuffix == IntPtr.Zero)
					id_getSuffix = JNIEnv.GetMethodID (class_ref, "getSuffix", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSuffix), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuffix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
