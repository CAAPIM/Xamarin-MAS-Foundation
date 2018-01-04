using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtree']"
	[global::Android.Runtime.Register ("sun/security/x509/GeneralSubtree", DoNotGenerateAcw=true)]
	public partial class GeneralSubtree : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/GeneralSubtree", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneralSubtree); }
		}

		protected GeneralSubtree (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lsun_security_x509_GeneralName_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtree']/constructor[@name='GeneralSubtree' and count(parameter)=3 and parameter[1][@type='sun.security.x509.GeneralName'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lsun/security/x509/GeneralName;II)V", "")]
		public unsafe GeneralSubtree (global::Sun.Security.X509.GeneralName name, int min, int max)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (name);
				__args [1] = new JValue (min);
				__args [2] = new JValue (max);
				if (((object) this).GetType () != typeof (GeneralSubtree)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/GeneralName;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/GeneralName;II)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_GeneralName_II == IntPtr.Zero)
					id_ctor_Lsun_security_x509_GeneralName_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/GeneralName;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_GeneralName_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_GeneralName_II, __args);
			} finally {
			}
		}

		static Delegate cb_getMaximum;
#pragma warning disable 0169
		static Delegate GetGetMaximumHandler ()
		{
			if (cb_getMaximum == null)
				cb_getMaximum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaximum);
			return cb_getMaximum;
		}

		static int n_GetMaximum (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.GeneralSubtree __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Maximum;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximum;
		public virtual unsafe int Maximum {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtree']/method[@name='getMaximum' and count(parameter)=0]"
			[Register ("getMaximum", "()I", "GetGetMaximumHandler")]
			get {
				if (id_getMaximum == IntPtr.Zero)
					id_getMaximum = JNIEnv.GetMethodID (class_ref, "getMaximum", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaximum);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMinimum;
#pragma warning disable 0169
		static Delegate GetGetMinimumHandler ()
		{
			if (cb_getMinimum == null)
				cb_getMinimum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinimum);
			return cb_getMinimum;
		}

		static int n_GetMinimum (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.GeneralSubtree __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Minimum;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimum;
		public virtual unsafe int Minimum {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtree']/method[@name='getMinimum' and count(parameter)=0]"
			[Register ("getMinimum", "()I", "GetGetMinimumHandler")]
			get {
				if (id_getMinimum == IntPtr.Zero)
					id_getMinimum = JNIEnv.GetMethodID (class_ref, "getMinimum", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinimum);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinimum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.GeneralSubtree __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe global::Sun.Security.X509.GeneralName Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtree']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Lsun/security/x509/GeneralName;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Lsun/security/x509/GeneralName;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralName> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralName> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Lsun/security/x509/GeneralName;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Sun.Security.X509.GeneralSubtree __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtree']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
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

	}
}
