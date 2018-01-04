using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Provider.Certpath {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.provider.certpath']/class[@name='X509CertificatePair']"
	[global::Android.Runtime.Register ("sun/security/provider/certpath/X509CertificatePair", DoNotGenerateAcw=true)]
	public partial class X509CertificatePair : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/provider/certpath/X509CertificatePair", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (X509CertificatePair); }
		}

		protected X509CertificatePair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.provider.certpath']/class[@name='X509CertificatePair']/constructor[@name='X509CertificatePair' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe X509CertificatePair ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (X509CertificatePair)) {
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

		static IntPtr id_ctor_Ljava_security_cert_X509Certificate_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.provider.certpath']/class[@name='X509CertificatePair']/constructor[@name='X509CertificatePair' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate'] and parameter[2][@type='java.security.cert.X509Certificate']]"
		[Register (".ctor", "(Ljava/security/cert/X509Certificate;Ljava/security/cert/X509Certificate;)V", "")]
		public unsafe X509CertificatePair (global::Java.Security.Cert.X509Certificate forward, global::Java.Security.Cert.X509Certificate reverse)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (forward);
				__args [1] = new JValue (reverse);
				if (((object) this).GetType () != typeof (X509CertificatePair)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/security/cert/X509Certificate;Ljava/security/cert/X509Certificate;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/security/cert/X509Certificate;Ljava/security/cert/X509Certificate;)V", __args);
					return;
				}

				if (id_ctor_Ljava_security_cert_X509Certificate_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
					id_ctor_Ljava_security_cert_X509Certificate_Ljava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/security/cert/X509Certificate;Ljava/security/cert/X509Certificate;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_security_cert_X509Certificate_Ljava_security_cert_X509Certificate_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_security_cert_X509Certificate_Ljava_security_cert_X509Certificate_, __args);
			} finally {
			}
		}

		static Delegate cb_getForward;
#pragma warning disable 0169
		static Delegate GetGetForwardHandler ()
		{
			if (cb_getForward == null)
				cb_getForward = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetForward);
			return cb_getForward;
		}

		static IntPtr n_GetForward (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Provider.Certpath.X509CertificatePair __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.Certpath.X509CertificatePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Forward);
		}
#pragma warning restore 0169

		static Delegate cb_setForward_Ljava_security_cert_X509Certificate_;
#pragma warning disable 0169
		static Delegate GetSetForward_Ljava_security_cert_X509Certificate_Handler ()
		{
			if (cb_setForward_Ljava_security_cert_X509Certificate_ == null)
				cb_setForward_Ljava_security_cert_X509Certificate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetForward_Ljava_security_cert_X509Certificate_);
			return cb_setForward_Ljava_security_cert_X509Certificate_;
		}

		static void n_SetForward_Ljava_security_cert_X509Certificate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cert)
		{
			global::Sun.Security.Provider.Certpath.X509CertificatePair __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.Certpath.X509CertificatePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.X509Certificate cert = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (native_cert, JniHandleOwnership.DoNotTransfer);
			__this.Forward = cert;
		}
#pragma warning restore 0169

		static IntPtr id_getForward;
		static IntPtr id_setForward_Ljava_security_cert_X509Certificate_;
		public virtual unsafe global::Java.Security.Cert.X509Certificate Forward {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider.certpath']/class[@name='X509CertificatePair']/method[@name='getForward' and count(parameter)=0]"
			[Register ("getForward", "()Ljava/security/cert/X509Certificate;", "GetGetForwardHandler")]
			get {
				if (id_getForward == IntPtr.Zero)
					id_getForward = JNIEnv.GetMethodID (class_ref, "getForward", "()Ljava/security/cert/X509Certificate;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getForward), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getForward", "()Ljava/security/cert/X509Certificate;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider.certpath']/class[@name='X509CertificatePair']/method[@name='setForward' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
			[Register ("setForward", "(Ljava/security/cert/X509Certificate;)V", "GetSetForward_Ljava_security_cert_X509Certificate_Handler")]
			set {
				if (id_setForward_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
					id_setForward_Ljava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "setForward", "(Ljava/security/cert/X509Certificate;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setForward_Ljava_security_cert_X509Certificate_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setForward", "(Ljava/security/cert/X509Certificate;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReverse;
#pragma warning disable 0169
		static Delegate GetGetReverseHandler ()
		{
			if (cb_getReverse == null)
				cb_getReverse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReverse);
			return cb_getReverse;
		}

		static IntPtr n_GetReverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Provider.Certpath.X509CertificatePair __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.Certpath.X509CertificatePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Reverse);
		}
#pragma warning restore 0169

		static Delegate cb_setReverse_Ljava_security_cert_X509Certificate_;
#pragma warning disable 0169
		static Delegate GetSetReverse_Ljava_security_cert_X509Certificate_Handler ()
		{
			if (cb_setReverse_Ljava_security_cert_X509Certificate_ == null)
				cb_setReverse_Ljava_security_cert_X509Certificate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReverse_Ljava_security_cert_X509Certificate_);
			return cb_setReverse_Ljava_security_cert_X509Certificate_;
		}

		static void n_SetReverse_Ljava_security_cert_X509Certificate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cert)
		{
			global::Sun.Security.Provider.Certpath.X509CertificatePair __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.Certpath.X509CertificatePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.X509Certificate cert = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (native_cert, JniHandleOwnership.DoNotTransfer);
			__this.Reverse = cert;
		}
#pragma warning restore 0169

		static IntPtr id_getReverse;
		static IntPtr id_setReverse_Ljava_security_cert_X509Certificate_;
		public virtual unsafe global::Java.Security.Cert.X509Certificate Reverse {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider.certpath']/class[@name='X509CertificatePair']/method[@name='getReverse' and count(parameter)=0]"
			[Register ("getReverse", "()Ljava/security/cert/X509Certificate;", "GetGetReverseHandler")]
			get {
				if (id_getReverse == IntPtr.Zero)
					id_getReverse = JNIEnv.GetMethodID (class_ref, "getReverse", "()Ljava/security/cert/X509Certificate;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReverse), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReverse", "()Ljava/security/cert/X509Certificate;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider.certpath']/class[@name='X509CertificatePair']/method[@name='setReverse' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
			[Register ("setReverse", "(Ljava/security/cert/X509Certificate;)V", "GetSetReverse_Ljava_security_cert_X509Certificate_Handler")]
			set {
				if (id_setReverse_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
					id_setReverse_Ljava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "setReverse", "(Ljava/security/cert/X509Certificate;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReverse_Ljava_security_cert_X509Certificate_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReverse", "(Ljava/security/cert/X509Certificate;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_clearCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider.certpath']/class[@name='X509CertificatePair']/method[@name='clearCache' and count(parameter)=0]"
		[Register ("clearCache", "()V", "")]
		public static unsafe void ClearCache ()
		{
			if (id_clearCache == IntPtr.Zero)
				id_clearCache = JNIEnv.GetStaticMethodID (class_ref, "clearCache", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearCache);
			} finally {
			}
		}

		static IntPtr id_generateCertificatePair_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider.certpath']/class[@name='X509CertificatePair']/method[@name='generateCertificatePair' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("generateCertificatePair", "([B)Lsun/security/provider/certpath/X509CertificatePair;", "")]
		public static unsafe global::Sun.Security.Provider.Certpath.X509CertificatePair GenerateCertificatePair (byte[] encoded)
		{
			if (id_generateCertificatePair_arrayB == IntPtr.Zero)
				id_generateCertificatePair_arrayB = JNIEnv.GetStaticMethodID (class_ref, "generateCertificatePair", "([B)Lsun/security/provider/certpath/X509CertificatePair;");
			IntPtr native_encoded = JNIEnv.NewArray (encoded);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_encoded);
				global::Sun.Security.Provider.Certpath.X509CertificatePair __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.Certpath.X509CertificatePair> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateCertificatePair_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (encoded != null) {
					JNIEnv.CopyArray (native_encoded, encoded);
					JNIEnv.DeleteLocalRef (native_encoded);
				}
			}
		}

		static Delegate cb_getEncoded;
#pragma warning disable 0169
		static Delegate GetGetEncodedHandler ()
		{
			if (cb_getEncoded == null)
				cb_getEncoded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncoded);
			return cb_getEncoded;
		}

		static IntPtr n_GetEncoded (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Provider.Certpath.X509CertificatePair __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.Certpath.X509CertificatePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncoded ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncoded;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider.certpath']/class[@name='X509CertificatePair']/method[@name='getEncoded' and count(parameter)=0]"
		[Register ("getEncoded", "()[B", "GetGetEncodedHandler")]
		public virtual unsafe byte[] GetEncoded ()
		{
			if (id_getEncoded == IntPtr.Zero)
				id_getEncoded = JNIEnv.GetMethodID (class_ref, "getEncoded", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncoded), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncoded", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
