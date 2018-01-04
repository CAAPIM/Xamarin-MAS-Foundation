using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Provider {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']"
	[global::Android.Runtime.Register ("sun/security/provider/X509Factory", DoNotGenerateAcw=true)]
	public partial class X509Factory : global::Java.Security.Cert.CertificateFactorySpi {


		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']/field[@name='BEGIN_CERT']"
		[Register ("BEGIN_CERT")]
		public const string BeginCert = (string) "-----BEGIN CERTIFICATE-----";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']/field[@name='END_CERT']"
		[Register ("END_CERT")]
		public const string EndCert = (string) "-----END CERTIFICATE-----";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/provider/X509Factory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (X509Factory); }
		}

		protected X509Factory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']/constructor[@name='X509Factory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe X509Factory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (X509Factory)) {
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

		static Delegate cb_engineGenerateCRL_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetEngineGenerateCRL_Ljava_io_InputStream_Handler ()
		{
			if (cb_engineGenerateCRL_Ljava_io_InputStream_ == null)
				cb_engineGenerateCRL_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EngineGenerateCRL_Ljava_io_InputStream_);
			return cb_engineGenerateCRL_Ljava_io_InputStream_;
		}

		static IntPtr n_EngineGenerateCRL_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__is)
		{
			global::Sun.Security.Provider.X509Factory __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.X509Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @is = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__is, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EngineGenerateCRL (@is));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_engineGenerateCRL_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']/method[@name='engineGenerateCRL' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;", "GetEngineGenerateCRL_Ljava_io_InputStream_Handler")]
		public override unsafe global::Java.Security.Cert.CRL EngineGenerateCRL (global::System.IO.Stream @is)
		{
			if (id_engineGenerateCRL_Ljava_io_InputStream_ == IntPtr.Zero)
				id_engineGenerateCRL_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;");
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__is);

				global::Java.Security.Cert.CRL __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.CRL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGenerateCRL_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.CRL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
			}
		}

		static Delegate cb_engineGenerateCRLs_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetEngineGenerateCRLs_Ljava_io_InputStream_Handler ()
		{
			if (cb_engineGenerateCRLs_Ljava_io_InputStream_ == null)
				cb_engineGenerateCRLs_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EngineGenerateCRLs_Ljava_io_InputStream_);
			return cb_engineGenerateCRLs_Ljava_io_InputStream_;
		}

		static IntPtr n_EngineGenerateCRLs_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__is)
		{
			global::Sun.Security.Provider.X509Factory __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.X509Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @is = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__is, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection<global::Java.Security.Cert.CRL>.ToLocalJniHandle (__this.EngineGenerateCRLs (@is));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_engineGenerateCRLs_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']/method[@name='engineGenerateCRLs' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;", "GetEngineGenerateCRLs_Ljava_io_InputStream_Handler")]
		public override unsafe global::System.Collections.Generic.ICollection<global::Java.Security.Cert.CRL> EngineGenerateCRLs (global::System.IO.Stream @is)
		{
			if (id_engineGenerateCRLs_Ljava_io_InputStream_ == IntPtr.Zero)
				id_engineGenerateCRLs_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__is);

				global::System.Collections.Generic.ICollection<global::Java.Security.Cert.CRL> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaCollection<global::Java.Security.Cert.CRL>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGenerateCRLs_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaCollection<global::Java.Security.Cert.CRL>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
			}
		}

		static Delegate cb_engineGenerateCertPath_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetEngineGenerateCertPath_Ljava_util_List_Handler ()
		{
			if (cb_engineGenerateCertPath_Ljava_util_List_ == null)
				cb_engineGenerateCertPath_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EngineGenerateCertPath_Ljava_util_List_);
			return cb_engineGenerateCertPath_Ljava_util_List_;
		}

		static IntPtr n_EngineGenerateCertPath_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_certificates)
		{
			global::Sun.Security.Provider.X509Factory __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.X509Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var certificates = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (native_certificates, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EngineGenerateCertPath (certificates));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_engineGenerateCertPath_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']/method[@name='engineGenerateCertPath' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends java.security.cert.Certificate&gt;']]"
		[Register ("engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;", "GetEngineGenerateCertPath_Ljava_util_List_Handler")]
		public virtual unsafe global::Java.Security.Cert.CertPath EngineGenerateCertPath (global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> certificates)
		{
			if (id_engineGenerateCertPath_Ljava_util_List_ == IntPtr.Zero)
				id_engineGenerateCertPath_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;");
			IntPtr native_certificates = global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (certificates);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_certificates);

				global::Java.Security.Cert.CertPath __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.CertPath> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGenerateCertPath_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.CertPath> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_certificates);
			}
		}

		static Delegate cb_engineGenerateCertificate_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetEngineGenerateCertificate_Ljava_io_InputStream_Handler ()
		{
			if (cb_engineGenerateCertificate_Ljava_io_InputStream_ == null)
				cb_engineGenerateCertificate_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EngineGenerateCertificate_Ljava_io_InputStream_);
			return cb_engineGenerateCertificate_Ljava_io_InputStream_;
		}

		static IntPtr n_EngineGenerateCertificate_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__is)
		{
			global::Sun.Security.Provider.X509Factory __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.X509Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @is = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__is, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EngineGenerateCertificate (@is));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_engineGenerateCertificate_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']/method[@name='engineGenerateCertificate' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", "GetEngineGenerateCertificate_Ljava_io_InputStream_Handler")]
		public override unsafe global::Java.Security.Cert.Certificate EngineGenerateCertificate (global::System.IO.Stream @is)
		{
			if (id_engineGenerateCertificate_Ljava_io_InputStream_ == IntPtr.Zero)
				id_engineGenerateCertificate_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;");
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__is);

				global::Java.Security.Cert.Certificate __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.Certificate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGenerateCertificate_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.Certificate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
			}
		}

		static Delegate cb_engineGenerateCertificates_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetEngineGenerateCertificates_Ljava_io_InputStream_Handler ()
		{
			if (cb_engineGenerateCertificates_Ljava_io_InputStream_ == null)
				cb_engineGenerateCertificates_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EngineGenerateCertificates_Ljava_io_InputStream_);
			return cb_engineGenerateCertificates_Ljava_io_InputStream_;
		}

		static IntPtr n_EngineGenerateCertificates_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__is)
		{
			global::Sun.Security.Provider.X509Factory __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Provider.X509Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @is = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__is, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (__this.EngineGenerateCertificates (@is));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_engineGenerateCertificates_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']/method[@name='engineGenerateCertificates' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;", "GetEngineGenerateCertificates_Ljava_io_InputStream_Handler")]
		public override unsafe global::System.Collections.Generic.ICollection<global::Java.Security.Cert.Certificate> EngineGenerateCertificates (global::System.IO.Stream @is)
		{
			if (id_engineGenerateCertificates_Ljava_io_InputStream_ == IntPtr.Zero)
				id_engineGenerateCertificates_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;");
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__is);

				global::System.Collections.Generic.ICollection<global::Java.Security.Cert.Certificate> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaCollection<global::Java.Security.Cert.Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGenerateCertificates_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaCollection<global::Java.Security.Cert.Certificate>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
			}
		}

		static IntPtr id_intern_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']/method[@name='intern' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("intern", "(Ljava/security/cert/X509Certificate;)Lsun/security/x509/X509CertImpl;", "")]
		public static unsafe global::Sun.Security.X509.X509CertImpl Intern (global::Java.Security.Cert.X509Certificate c)
		{
			if (id_intern_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_intern_Ljava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "intern", "(Ljava/security/cert/X509Certificate;)Lsun/security/x509/X509CertImpl;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (c);
				global::Sun.Security.X509.X509CertImpl __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_intern_Ljava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_intern_Ljava_security_cert_X509CRL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.provider']/class[@name='X509Factory']/method[@name='intern' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509CRL']]"
		[Register ("intern", "(Ljava/security/cert/X509CRL;)Lsun/security/x509/X509CRLImpl;", "")]
		public static unsafe global::Sun.Security.X509.X509CRLImpl Intern (global::Java.Security.Cert.X509CRL c)
		{
			if (id_intern_Ljava_security_cert_X509CRL_ == IntPtr.Zero)
				id_intern_Ljava_security_cert_X509CRL_ = JNIEnv.GetStaticMethodID (class_ref, "intern", "(Ljava/security/cert/X509CRL;)Lsun/security/x509/X509CRLImpl;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (c);
				global::Sun.Security.X509.X509CRLImpl __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_intern_Ljava_security_cert_X509CRL_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
