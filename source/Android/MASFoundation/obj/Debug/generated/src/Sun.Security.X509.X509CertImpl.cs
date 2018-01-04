using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']"
	[global::Android.Runtime.Register ("sun/security/x509/X509CertImpl", DoNotGenerateAcw=true)]
	public partial class X509CertImpl : global::Java.Security.Cert.X509Certificate, global::Sun.Security.Util.IDerEncoder {


		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/field[@name='ALG_ID']"
		[Register ("ALG_ID")]
		public const string AlgId = (string) "algorithm";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/field[@name='INFO']"
		[Register ("INFO")]
		public const string Info = (string) "info";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/field[@name='ISSUER_DN']"
		[Register ("ISSUER_DN")]
		public const string IssuerDn = (string) "x509.info.issuer.dname";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/field[@name='SERIAL_ID']"
		[Register ("SERIAL_ID")]
		public const string SerialId = (string) "x509.info.serialNumber.number";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/field[@name='SIG']"
		[Register ("SIG")]
		public const string Sig = (string) "x509.signature";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/field[@name='SIGNATURE']"
		[Register ("SIGNATURE")]
		public const string Signature = (string) "signature";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/field[@name='SIGNED_CERT']"
		[Register ("SIGNED_CERT")]
		public const string SignedCert = (string) "signed_cert";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/field[@name='SIG_ALG']"
		[Register ("SIG_ALG")]
		public const string SigAlg = (string) "x509.algorithm";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/field[@name='SUBJECT_DN']"
		[Register ("SUBJECT_DN")]
		public const string SubjectDn = (string) "x509.info.subject.dname";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/X509CertImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (X509CertImpl); }
		}

		protected X509CertImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/constructor[@name='X509CertImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe X509CertImpl ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (X509CertImpl)) {
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

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/constructor[@name='X509CertImpl' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe X509CertImpl (byte[] certData)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_certData = JNIEnv.NewArray (certData);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_certData);
				if (((object) this).GetType () != typeof (X509CertImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (certData != null) {
					JNIEnv.CopyArray (native_certData, certData);
					JNIEnv.DeleteLocalRef (native_certData);
				}
			}
		}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/constructor[@name='X509CertImpl' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe X509CertImpl (global::System.IO.Stream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__in);
				if (((object) this).GetType () != typeof (X509CertImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		static IntPtr id_ctor_Lsun_security_x509_X509CertInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/constructor[@name='X509CertImpl' and count(parameter)=1 and parameter[1][@type='sun.security.x509.X509CertInfo']]"
		[Register (".ctor", "(Lsun/security/x509/X509CertInfo;)V", "")]
		public unsafe X509CertImpl (global::Sun.Security.X509.X509CertInfo certInfo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (certInfo);
				if (((object) this).GetType () != typeof (X509CertImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/X509CertInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/X509CertInfo;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_X509CertInfo_ == IntPtr.Zero)
					id_ctor_Lsun_security_x509_X509CertInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/X509CertInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_X509CertInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_X509CertInfo_, __args);
			} finally {
			}
		}

		static Delegate cb_getBasicConstraints;
#pragma warning disable 0169
		static Delegate GetGetBasicConstraintsHandler ()
		{
			if (cb_getBasicConstraints == null)
				cb_getBasicConstraints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBasicConstraints);
			return cb_getBasicConstraints;
		}

		static int n_GetBasicConstraints (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BasicConstraints;
		}
#pragma warning restore 0169

		static IntPtr id_getBasicConstraints;
		public override unsafe int BasicConstraints {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getBasicConstraints' and count(parameter)=0]"
			[Register ("getBasicConstraints", "()I", "GetGetBasicConstraintsHandler")]
			get {
				if (id_getBasicConstraints == IntPtr.Zero)
					id_getBasicConstraints = JNIEnv.GetMethodID (class_ref, "getBasicConstraints", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBasicConstraints);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBasicConstraints", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCriticalExtensionOIDs;
#pragma warning disable 0169
		static Delegate GetGetCriticalExtensionOIDsHandler ()
		{
			if (cb_getCriticalExtensionOIDs == null)
				cb_getCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCriticalExtensionOIDs);
			return cb_getCriticalExtensionOIDs;
		}

		static IntPtr n_GetCriticalExtensionOIDs (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.CriticalExtensionOIDs);
		}
#pragma warning restore 0169

		static IntPtr id_getCriticalExtensionOIDs;
		public override unsafe global::System.Collections.Generic.ICollection<string> CriticalExtensionOIDs {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getCriticalExtensionOIDs' and count(parameter)=0]"
			[Register ("getCriticalExtensionOIDs", "()Ljava/util/Set;", "GetGetCriticalExtensionOIDsHandler")]
			get {
				if (id_getCriticalExtensionOIDs == IntPtr.Zero)
					id_getCriticalExtensionOIDs = JNIEnv.GetMethodID (class_ref, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCriticalExtensionOIDs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getElements;
#pragma warning disable 0169
		static Delegate GetGetElementsHandler ()
		{
			if (cb_getElements == null)
				cb_getElements = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetElements);
			return cb_getElements;
		}

		static IntPtr n_GetElements (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Elements);
		}
#pragma warning restore 0169

		static IntPtr id_getElements;
		public virtual unsafe global::Java.Util.IEnumeration Elements {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getElements' and count(parameter)=0]"
			[Register ("getElements", "()Ljava/util/Enumeration;", "GetGetElementsHandler")]
			get {
				if (id_getElements == IntPtr.Zero)
					id_getElements = JNIEnv.GetMethodID (class_ref, "getElements", "()Ljava/util/Enumeration;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getElements), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElements", "()Ljava/util/Enumeration;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasUnsupportedCriticalExtension;
#pragma warning disable 0169
		static Delegate GetHasUnsupportedCriticalExtensionHandler ()
		{
			if (cb_hasUnsupportedCriticalExtension == null)
				cb_hasUnsupportedCriticalExtension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasUnsupportedCriticalExtension);
			return cb_hasUnsupportedCriticalExtension;
		}

		static bool n_HasUnsupportedCriticalExtension (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUnsupportedCriticalExtension;
		}
#pragma warning restore 0169

		static IntPtr id_hasUnsupportedCriticalExtension;
		public override unsafe bool HasUnsupportedCriticalExtension {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='hasUnsupportedCriticalExtension' and count(parameter)=0]"
			[Register ("hasUnsupportedCriticalExtension", "()Z", "GetHasUnsupportedCriticalExtensionHandler")]
			get {
				if (id_hasUnsupportedCriticalExtension == IntPtr.Zero)
					id_hasUnsupportedCriticalExtension = JNIEnv.GetMethodID (class_ref, "hasUnsupportedCriticalExtension", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasUnsupportedCriticalExtension);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasUnsupportedCriticalExtension", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getIssuerDN;
#pragma warning disable 0169
		static Delegate GetGetIssuerDNHandler ()
		{
			if (cb_getIssuerDN == null)
				cb_getIssuerDN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIssuerDN);
			return cb_getIssuerDN;
		}

		static IntPtr n_GetIssuerDN (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IssuerDN);
		}
#pragma warning restore 0169

		static IntPtr id_getIssuerDN;
		public override unsafe global::Java.Security.IPrincipal IssuerDN {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getIssuerDN' and count(parameter)=0]"
			[Register ("getIssuerDN", "()Ljava/security/Principal;", "GetGetIssuerDNHandler")]
			get {
				if (id_getIssuerDN == IntPtr.Zero)
					id_getIssuerDN = JNIEnv.GetMethodID (class_ref, "getIssuerDN", "()Ljava/security/Principal;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIssuerDN), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIssuerDN", "()Ljava/security/Principal;")), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNonCriticalExtensionOIDs;
#pragma warning disable 0169
		static Delegate GetGetNonCriticalExtensionOIDsHandler ()
		{
			if (cb_getNonCriticalExtensionOIDs == null)
				cb_getNonCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNonCriticalExtensionOIDs);
			return cb_getNonCriticalExtensionOIDs;
		}

		static IntPtr n_GetNonCriticalExtensionOIDs (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.NonCriticalExtensionOIDs);
		}
#pragma warning restore 0169

		static IntPtr id_getNonCriticalExtensionOIDs;
		public override unsafe global::System.Collections.Generic.ICollection<string> NonCriticalExtensionOIDs {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getNonCriticalExtensionOIDs' and count(parameter)=0]"
			[Register ("getNonCriticalExtensionOIDs", "()Ljava/util/Set;", "GetGetNonCriticalExtensionOIDsHandler")]
			get {
				if (id_getNonCriticalExtensionOIDs == IntPtr.Zero)
					id_getNonCriticalExtensionOIDs = JNIEnv.GetMethodID (class_ref, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNonCriticalExtensionOIDs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNotAfter;
#pragma warning disable 0169
		static Delegate GetGetNotAfterHandler ()
		{
			if (cb_getNotAfter == null)
				cb_getNotAfter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotAfter);
			return cb_getNotAfter;
		}

		static IntPtr n_GetNotAfter (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotAfter);
		}
#pragma warning restore 0169

		static IntPtr id_getNotAfter;
		public override unsafe global::Java.Util.Date NotAfter {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getNotAfter' and count(parameter)=0]"
			[Register ("getNotAfter", "()Ljava/util/Date;", "GetGetNotAfterHandler")]
			get {
				if (id_getNotAfter == IntPtr.Zero)
					id_getNotAfter = JNIEnv.GetMethodID (class_ref, "getNotAfter", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotAfter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotAfter", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNotBefore;
#pragma warning disable 0169
		static Delegate GetGetNotBeforeHandler ()
		{
			if (cb_getNotBefore == null)
				cb_getNotBefore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotBefore);
			return cb_getNotBefore;
		}

		static IntPtr n_GetNotBefore (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotBefore);
		}
#pragma warning restore 0169

		static IntPtr id_getNotBefore;
		public override unsafe global::Java.Util.Date NotBefore {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getNotBefore' and count(parameter)=0]"
			[Register ("getNotBefore", "()Ljava/util/Date;", "GetGetNotBeforeHandler")]
			get {
				if (id_getNotBefore == IntPtr.Zero)
					id_getNotBefore = JNIEnv.GetMethodID (class_ref, "getNotBefore", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotBefore), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotBefore", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPublicKey;
#pragma warning disable 0169
		static Delegate GetGetPublicKeyHandler ()
		{
			if (cb_getPublicKey == null)
				cb_getPublicKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPublicKey);
			return cb_getPublicKey;
		}

		static IntPtr n_GetPublicKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PublicKey);
		}
#pragma warning restore 0169

		static IntPtr id_getPublicKey;
		public override unsafe global::Java.Security.IPublicKey PublicKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getPublicKey' and count(parameter)=0]"
			[Register ("getPublicKey", "()Ljava/security/PublicKey;", "GetGetPublicKeyHandler")]
			get {
				if (id_getPublicKey == IntPtr.Zero)
					id_getPublicKey = JNIEnv.GetMethodID (class_ref, "getPublicKey", "()Ljava/security/PublicKey;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublicKey), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPublicKey", "()Ljava/security/PublicKey;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetSerialNumberHandler ()
		{
			if (cb_getSerialNumber == null)
				cb_getSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNumber);
			return cb_getSerialNumber;
		}

		static IntPtr n_GetSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerialNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getSerialNumber;
		public override unsafe global::Java.Math.BigInteger SerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getSerialNumber' and count(parameter)=0]"
			[Register ("getSerialNumber", "()Ljava/math/BigInteger;", "GetGetSerialNumberHandler")]
			get {
				if (id_getSerialNumber == IntPtr.Zero)
					id_getSerialNumber = JNIEnv.GetMethodID (class_ref, "getSerialNumber", "()Ljava/math/BigInteger;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialNumber), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSerialNumber", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSerialNumberObject;
#pragma warning disable 0169
		static Delegate GetGetSerialNumberObjectHandler ()
		{
			if (cb_getSerialNumberObject == null)
				cb_getSerialNumberObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNumberObject);
			return cb_getSerialNumberObject;
		}

		static IntPtr n_GetSerialNumberObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerialNumberObject);
		}
#pragma warning restore 0169

		static IntPtr id_getSerialNumberObject;
		public virtual unsafe global::Sun.Security.X509.SerialNumber SerialNumberObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getSerialNumberObject' and count(parameter)=0]"
			[Register ("getSerialNumberObject", "()Lsun/security/x509/SerialNumber;", "GetGetSerialNumberObjectHandler")]
			get {
				if (id_getSerialNumberObject == IntPtr.Zero)
					id_getSerialNumberObject = JNIEnv.GetMethodID (class_ref, "getSerialNumberObject", "()Lsun/security/x509/SerialNumber;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.SerialNumber> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialNumberObject), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.SerialNumber> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSerialNumberObject", "()Lsun/security/x509/SerialNumber;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSigAlgName;
#pragma warning disable 0169
		static Delegate GetGetSigAlgNameHandler ()
		{
			if (cb_getSigAlgName == null)
				cb_getSigAlgName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSigAlgName);
			return cb_getSigAlgName;
		}

		static IntPtr n_GetSigAlgName (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SigAlgName);
		}
#pragma warning restore 0169

		static IntPtr id_getSigAlgName;
		public override unsafe string SigAlgName {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getSigAlgName' and count(parameter)=0]"
			[Register ("getSigAlgName", "()Ljava/lang/String;", "GetGetSigAlgNameHandler")]
			get {
				if (id_getSigAlgName == IntPtr.Zero)
					id_getSigAlgName = JNIEnv.GetMethodID (class_ref, "getSigAlgName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSigAlgName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSigAlgName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSigAlgOID;
#pragma warning disable 0169
		static Delegate GetGetSigAlgOIDHandler ()
		{
			if (cb_getSigAlgOID == null)
				cb_getSigAlgOID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSigAlgOID);
			return cb_getSigAlgOID;
		}

		static IntPtr n_GetSigAlgOID (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SigAlgOID);
		}
#pragma warning restore 0169

		static IntPtr id_getSigAlgOID;
		public override unsafe string SigAlgOID {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getSigAlgOID' and count(parameter)=0]"
			[Register ("getSigAlgOID", "()Ljava/lang/String;", "GetGetSigAlgOIDHandler")]
			get {
				if (id_getSigAlgOID == IntPtr.Zero)
					id_getSigAlgOID = JNIEnv.GetMethodID (class_ref, "getSigAlgOID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSigAlgOID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSigAlgOID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubjectDN;
#pragma warning disable 0169
		static Delegate GetGetSubjectDNHandler ()
		{
			if (cb_getSubjectDN == null)
				cb_getSubjectDN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubjectDN);
			return cb_getSubjectDN;
		}

		static IntPtr n_GetSubjectDN (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubjectDN);
		}
#pragma warning restore 0169

		static IntPtr id_getSubjectDN;
		public override unsafe global::Java.Security.IPrincipal SubjectDN {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getSubjectDN' and count(parameter)=0]"
			[Register ("getSubjectDN", "()Ljava/security/Principal;", "GetGetSubjectDNHandler")]
			get {
				if (id_getSubjectDN == IntPtr.Zero)
					id_getSubjectDN = JNIEnv.GetMethodID (class_ref, "getSubjectDN", "()Ljava/security/Principal;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubjectDN), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubjectDN", "()Ljava/security/Principal;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public override unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVersion);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_checkValidity;
#pragma warning disable 0169
		static Delegate GetCheckValidityHandler ()
		{
			if (cb_checkValidity == null)
				cb_checkValidity = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckValidity);
			return cb_checkValidity;
		}

		static void n_CheckValidity (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckValidity ();
		}
#pragma warning restore 0169

		static IntPtr id_checkValidity;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='checkValidity' and count(parameter)=0]"
		[Register ("checkValidity", "()V", "GetCheckValidityHandler")]
		public override unsafe void CheckValidity ()
		{
			if (id_checkValidity == IntPtr.Zero)
				id_checkValidity = JNIEnv.GetMethodID (class_ref, "checkValidity", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkValidity);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkValidity", "()V"));
			} finally {
			}
		}

		static Delegate cb_checkValidity_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetCheckValidity_Ljava_util_Date_Handler ()
		{
			if (cb_checkValidity_Ljava_util_Date_ == null)
				cb_checkValidity_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CheckValidity_Ljava_util_Date_);
			return cb_checkValidity_Ljava_util_Date_;
		}

		static void n_CheckValidity_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.CheckValidity (date);
		}
#pragma warning restore 0169

		static IntPtr id_checkValidity_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='checkValidity' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("checkValidity", "(Ljava/util/Date;)V", "GetCheckValidity_Ljava_util_Date_Handler")]
		public override unsafe void CheckValidity (global::Java.Util.Date date)
		{
			if (id_checkValidity_Ljava_util_Date_ == IntPtr.Zero)
				id_checkValidity_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "checkValidity", "(Ljava/util/Date;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkValidity_Ljava_util_Date_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkValidity", "(Ljava/util/Date;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_delete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_ == null)
				cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Ljava_lang_String_);
			return cb_delete_Ljava_lang_String_;
		}

		static void n_Delete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Delete (name);
		}
#pragma warning restore 0169

		static IntPtr id_delete_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)V", "GetDelete_Ljava_lang_String_Handler")]
		public virtual unsafe void Delete (string name)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
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
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.DerEncode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_derEncode_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='derEncode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
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

		static Delegate cb_encode_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encode_Ljava_io_OutputStream_ == null)
				cb_encode_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_io_OutputStream_);
			return cb_encode_Ljava_io_OutputStream_;
		}

		static void n_Encode_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("encode", "(Ljava/io/OutputStream;)V", "GetEncode_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void Encode (global::System.IO.Stream @out)
		{
			if (id_encode_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encode_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/io/OutputStream;)V");
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (string name)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
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
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncoded ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncoded;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getEncoded' and count(parameter)=0]"
		[Register ("getEncoded", "()[B", "GetGetEncodedHandler")]
		public override unsafe byte[] GetEncoded ()
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

		static Delegate cb_getEncodedInternal;
#pragma warning disable 0169
		static Delegate GetGetEncodedInternalHandler ()
		{
			if (cb_getEncodedInternal == null)
				cb_getEncodedInternal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncodedInternal);
			return cb_getEncodedInternal;
		}

		static IntPtr n_GetEncodedInternal (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncodedInternal ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncodedInternal;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getEncodedInternal' and count(parameter)=0]"
		[Register ("getEncodedInternal", "()[B", "GetGetEncodedInternalHandler")]
		public virtual unsafe byte[] GetEncodedInternal ()
		{
			if (id_getEncodedInternal == IntPtr.Zero)
				id_getEncodedInternal = JNIEnv.GetMethodID (class_ref, "getEncodedInternal", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncodedInternal), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncodedInternal", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getEncodedInternal_Ljava_security_cert_Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getEncodedInternal' and count(parameter)=1 and parameter[1][@type='java.security.cert.Certificate']]"
		[Register ("getEncodedInternal", "(Ljava/security/cert/Certificate;)[B", "")]
		public static unsafe byte[] GetEncodedInternal (global::Java.Security.Cert.Certificate cert)
		{
			if (id_getEncodedInternal_Ljava_security_cert_Certificate_ == IntPtr.Zero)
				id_getEncodedInternal_Ljava_security_cert_Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "getEncodedInternal", "(Ljava/security/cert/Certificate;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cert);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEncodedInternal_Ljava_security_cert_Certificate_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getExtendedKeyUsage_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getExtendedKeyUsage' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("getExtendedKeyUsage", "(Ljava/security/cert/X509Certificate;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> GetExtendedKeyUsage (global::Java.Security.Cert.X509Certificate cert)
		{
			if (id_getExtendedKeyUsage_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_getExtendedKeyUsage_Ljava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "getExtendedKeyUsage", "(Ljava/security/cert/X509Certificate;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cert);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getExtendedKeyUsage_Ljava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getExtensionValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetExtensionValue_Ljava_lang_String_Handler ()
		{
			if (cb_getExtensionValue_Ljava_lang_String_ == null)
				cb_getExtensionValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetExtensionValue_Ljava_lang_String_);
			return cb_getExtensionValue_Ljava_lang_String_;
		}

		static IntPtr n_GetExtensionValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oid)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string oid = JNIEnv.GetString (native_oid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetExtensionValue (oid));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getExtensionValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getExtensionValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExtensionValue", "(Ljava/lang/String;)[B", "GetGetExtensionValue_Ljava_lang_String_Handler")]
		public override unsafe byte[] GetExtensionValue (string oid)
		{
			if (id_getExtensionValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getExtensionValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getExtensionValue", "(Ljava/lang/String;)[B");
			IntPtr native_oid = JNIEnv.NewString (oid);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_oid);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtensionValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtensionValue", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_oid);
			}
		}

		static IntPtr id_getIssuerAlternativeNames_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getIssuerAlternativeNames' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("getIssuerAlternativeNames", "(Ljava/security/cert/X509Certificate;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::System.Collections.Generic.IList<object>> GetIssuerAlternativeNames (global::Java.Security.Cert.X509Certificate cert)
		{
			if (id_getIssuerAlternativeNames_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_getIssuerAlternativeNames_Ljava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "getIssuerAlternativeNames", "(Ljava/security/cert/X509Certificate;)Ljava/util/Collection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cert);
				global::System.Collections.Generic.ICollection<global::System.Collections.Generic.IList<object>> __ret = global::Android.Runtime.JavaCollection<global::System.Collections.Generic.IList<object>>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIssuerAlternativeNames_Ljava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getIssuerUniqueID;
#pragma warning disable 0169
		static Delegate GetGetIssuerUniqueIDHandler ()
		{
			if (cb_getIssuerUniqueID == null)
				cb_getIssuerUniqueID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIssuerUniqueID);
			return cb_getIssuerUniqueID;
		}

		static IntPtr n_GetIssuerUniqueID (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetIssuerUniqueID ());
		}
#pragma warning restore 0169

		static IntPtr id_getIssuerUniqueID;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getIssuerUniqueID' and count(parameter)=0]"
		[Register ("getIssuerUniqueID", "()[Z", "GetGetIssuerUniqueIDHandler")]
		public override unsafe bool[] GetIssuerUniqueID ()
		{
			if (id_getIssuerUniqueID == IntPtr.Zero)
				id_getIssuerUniqueID = JNIEnv.GetMethodID (class_ref, "getIssuerUniqueID", "()[Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIssuerUniqueID), JniHandleOwnership.TransferLocalRef, typeof (bool));
				else
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIssuerUniqueID", "()[Z")), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

		static IntPtr id_getIssuerX500Principal_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getIssuerX500Principal' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("getIssuerX500Principal", "(Ljava/security/cert/X509Certificate;)Ljavax/security/auth/x500/X500Principal;", "")]
		public static unsafe global::Javax.Security.Auth.X500.X500Principal GetIssuerX500Principal (global::Java.Security.Cert.X509Certificate cert)
		{
			if (id_getIssuerX500Principal_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_getIssuerX500Principal_Ljava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "getIssuerX500Principal", "(Ljava/security/cert/X509Certificate;)Ljavax/security/auth/x500/X500Principal;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cert);
				global::Javax.Security.Auth.X500.X500Principal __ret = global::Java.Lang.Object.GetObject<global::Javax.Security.Auth.X500.X500Principal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIssuerX500Principal_Ljava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getKeyUsage;
#pragma warning disable 0169
		static Delegate GetGetKeyUsageHandler ()
		{
			if (cb_getKeyUsage == null)
				cb_getKeyUsage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeyUsage);
			return cb_getKeyUsage;
		}

		static IntPtr n_GetKeyUsage (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetKeyUsage ());
		}
#pragma warning restore 0169

		static IntPtr id_getKeyUsage;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getKeyUsage' and count(parameter)=0]"
		[Register ("getKeyUsage", "()[Z", "GetGetKeyUsageHandler")]
		public override unsafe bool[] GetKeyUsage ()
		{
			if (id_getKeyUsage == IntPtr.Zero)
				id_getKeyUsage = JNIEnv.GetMethodID (class_ref, "getKeyUsage", "()[Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeyUsage), JniHandleOwnership.TransferLocalRef, typeof (bool));
				else
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyUsage", "()[Z")), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

		static Delegate cb_getSigAlgParams;
#pragma warning disable 0169
		static Delegate GetGetSigAlgParamsHandler ()
		{
			if (cb_getSigAlgParams == null)
				cb_getSigAlgParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSigAlgParams);
			return cb_getSigAlgParams;
		}

		static IntPtr n_GetSigAlgParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSigAlgParams ());
		}
#pragma warning restore 0169

		static IntPtr id_getSigAlgParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getSigAlgParams' and count(parameter)=0]"
		[Register ("getSigAlgParams", "()[B", "GetGetSigAlgParamsHandler")]
		public override unsafe byte[] GetSigAlgParams ()
		{
			if (id_getSigAlgParams == IntPtr.Zero)
				id_getSigAlgParams = JNIEnv.GetMethodID (class_ref, "getSigAlgParams", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSigAlgParams), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSigAlgParams", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getSignature;
#pragma warning disable 0169
		static Delegate GetGetSignatureHandler ()
		{
			if (cb_getSignature == null)
				cb_getSignature = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignature);
			return cb_getSignature;
		}

		static IntPtr n_GetSignature (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSignature ());
		}
#pragma warning restore 0169

		static IntPtr id_getSignature;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getSignature' and count(parameter)=0]"
		[Register ("getSignature", "()[B", "GetGetSignatureHandler")]
		public override unsafe byte[] GetSignature ()
		{
			if (id_getSignature == IntPtr.Zero)
				id_getSignature = JNIEnv.GetMethodID (class_ref, "getSignature", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignature), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSignature", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getSubjectAlternativeNames_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getSubjectAlternativeNames' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("getSubjectAlternativeNames", "(Ljava/security/cert/X509Certificate;)Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::System.Collections.Generic.IList<object>> GetSubjectAlternativeNames (global::Java.Security.Cert.X509Certificate cert)
		{
			if (id_getSubjectAlternativeNames_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_getSubjectAlternativeNames_Ljava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "getSubjectAlternativeNames", "(Ljava/security/cert/X509Certificate;)Ljava/util/Collection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cert);
				global::System.Collections.Generic.ICollection<global::System.Collections.Generic.IList<object>> __ret = global::Android.Runtime.JavaCollection<global::System.Collections.Generic.IList<object>>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSubjectAlternativeNames_Ljava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSubjectUniqueID;
#pragma warning disable 0169
		static Delegate GetGetSubjectUniqueIDHandler ()
		{
			if (cb_getSubjectUniqueID == null)
				cb_getSubjectUniqueID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubjectUniqueID);
			return cb_getSubjectUniqueID;
		}

		static IntPtr n_GetSubjectUniqueID (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSubjectUniqueID ());
		}
#pragma warning restore 0169

		static IntPtr id_getSubjectUniqueID;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getSubjectUniqueID' and count(parameter)=0]"
		[Register ("getSubjectUniqueID", "()[Z", "GetGetSubjectUniqueIDHandler")]
		public override unsafe bool[] GetSubjectUniqueID ()
		{
			if (id_getSubjectUniqueID == IntPtr.Zero)
				id_getSubjectUniqueID = JNIEnv.GetMethodID (class_ref, "getSubjectUniqueID", "()[Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubjectUniqueID), JniHandleOwnership.TransferLocalRef, typeof (bool));
				else
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubjectUniqueID", "()[Z")), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

		static IntPtr id_getSubjectX500Principal_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getSubjectX500Principal' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("getSubjectX500Principal", "(Ljava/security/cert/X509Certificate;)Ljavax/security/auth/x500/X500Principal;", "")]
		public static unsafe global::Javax.Security.Auth.X500.X500Principal GetSubjectX500Principal (global::Java.Security.Cert.X509Certificate cert)
		{
			if (id_getSubjectX500Principal_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_getSubjectX500Principal_Ljava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "getSubjectX500Principal", "(Ljava/security/cert/X509Certificate;)Ljavax/security/auth/x500/X500Principal;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cert);
				global::Javax.Security.Auth.X500.X500Principal __ret = global::Java.Lang.Object.GetObject<global::Javax.Security.Auth.X500.X500Principal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSubjectX500Principal_Ljava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getTBSCertificate;
#pragma warning disable 0169
		static Delegate GetGetTBSCertificateHandler ()
		{
			if (cb_getTBSCertificate == null)
				cb_getTBSCertificate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTBSCertificate);
			return cb_getTBSCertificate;
		}

		static IntPtr n_GetTBSCertificate (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTBSCertificate ());
		}
#pragma warning restore 0169

		static IntPtr id_getTBSCertificate;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='getTBSCertificate' and count(parameter)=0]"
		[Register ("getTBSCertificate", "()[B", "GetGetTBSCertificateHandler")]
		public override unsafe byte[] GetTBSCertificate ()
		{
			if (id_getTBSCertificate == IntPtr.Zero)
				id_getTBSCertificate = JNIEnv.GetMethodID (class_ref, "getTBSCertificate", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTBSCertificate), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTBSCertificate", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_isSelfIssued_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='isSelfIssued' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("isSelfIssued", "(Ljava/security/cert/X509Certificate;)Z", "")]
		public static unsafe bool IsSelfIssued (global::Java.Security.Cert.X509Certificate cert)
		{
			if (id_isSelfIssued_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_isSelfIssued_Ljava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "isSelfIssued", "(Ljava/security/cert/X509Certificate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cert);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSelfIssued_Ljava_security_cert_X509Certificate_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isSelfSigned_Ljava_security_cert_X509Certificate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='isSelfSigned' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate'] and parameter[2][@type='java.lang.String']]"
		[Register ("isSelfSigned", "(Ljava/security/cert/X509Certificate;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsSelfSigned (global::Java.Security.Cert.X509Certificate cert, string sigProvider)
		{
			if (id_isSelfSigned_Ljava_security_cert_X509Certificate_Ljava_lang_String_ == IntPtr.Zero)
				id_isSelfSigned_Ljava_security_cert_X509Certificate_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isSelfSigned", "(Ljava/security/cert/X509Certificate;Ljava/lang/String;)Z");
			IntPtr native_sigProvider = JNIEnv.NewString (sigProvider);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cert);
				__args [1] = new JValue (native_sigProvider);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSelfSigned_Ljava_security_cert_X509Certificate_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_sigProvider);
			}
		}

		static Delegate cb_set_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_set_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_set_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_lang_Object_);
			return cb_set_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Set_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_obj)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.Set (name, obj);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("set", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSet_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Set (string name, global::Java.Lang.Object obj)
		{
			if (id_set_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (obj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_sign_Ljava_security_PrivateKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSign_Ljava_security_PrivateKey_Ljava_lang_String_Handler ()
		{
			if (cb_sign_Ljava_security_PrivateKey_Ljava_lang_String_ == null)
				cb_sign_Ljava_security_PrivateKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Ljava_security_PrivateKey_Ljava_lang_String_);
			return cb_sign_Ljava_security_PrivateKey_Ljava_lang_String_;
		}

		static void n_Sign_Ljava_security_PrivateKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_algorithm)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPrivateKey key = (global::Java.Security.IPrivateKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (native_key, JniHandleOwnership.DoNotTransfer);
			string algorithm = JNIEnv.GetString (native_algorithm, JniHandleOwnership.DoNotTransfer);
			__this.Sign (key, algorithm);
		}
#pragma warning restore 0169

		static IntPtr id_sign_Ljava_security_PrivateKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='sign' and count(parameter)=2 and parameter[1][@type='java.security.PrivateKey'] and parameter[2][@type='java.lang.String']]"
		[Register ("sign", "(Ljava/security/PrivateKey;Ljava/lang/String;)V", "GetSign_Ljava_security_PrivateKey_Ljava_lang_String_Handler")]
		public virtual unsafe void Sign (global::Java.Security.IPrivateKey key, string algorithm)
		{
			if (id_sign_Ljava_security_PrivateKey_Ljava_lang_String_ == IntPtr.Zero)
				id_sign_Ljava_security_PrivateKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sign", "(Ljava/security/PrivateKey;Ljava/lang/String;)V");
			IntPtr native_algorithm = JNIEnv.NewString (algorithm);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (key);
				__args [1] = new JValue (native_algorithm);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sign_Ljava_security_PrivateKey_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sign", "(Ljava/security/PrivateKey;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_algorithm);
			}
		}

		static Delegate cb_sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_algorithm, IntPtr native_provider)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPrivateKey key = (global::Java.Security.IPrivateKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (native_key, JniHandleOwnership.DoNotTransfer);
			string algorithm = JNIEnv.GetString (native_algorithm, JniHandleOwnership.DoNotTransfer);
			string provider = JNIEnv.GetString (native_provider, JniHandleOwnership.DoNotTransfer);
			__this.Sign (key, algorithm, provider);
		}
#pragma warning restore 0169

		static IntPtr id_sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='sign' and count(parameter)=3 and parameter[1][@type='java.security.PrivateKey'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sign", "(Ljava/security/PrivateKey;Ljava/lang/String;Ljava/lang/String;)V", "GetSign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Sign (global::Java.Security.IPrivateKey key, string algorithm, string provider)
		{
			if (id_sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sign", "(Ljava/security/PrivateKey;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_algorithm = JNIEnv.NewString (algorithm);
			IntPtr native_provider = JNIEnv.NewString (provider);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (key);
				__args [1] = new JValue (native_algorithm);
				__args [2] = new JValue (native_provider);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sign", "(Ljava/security/PrivateKey;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_algorithm);
				JNIEnv.DeleteLocalRef (native_provider);
			}
		}

		static IntPtr id_toImpl_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='toImpl' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("toImpl", "(Ljava/security/cert/X509Certificate;)Lsun/security/x509/X509CertImpl;", "")]
		public static unsafe global::Sun.Security.X509.X509CertImpl ToImpl (global::Java.Security.Cert.X509Certificate cert)
		{
			if (id_toImpl_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_toImpl_Ljava_security_cert_X509Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "toImpl", "(Ljava/security/cert/X509Certificate;)Lsun/security/x509/X509CertImpl;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cert);
				global::Sun.Security.X509.X509CertImpl __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toImpl_Ljava_security_cert_X509Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler")]
		public override unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_verify_Ljava_security_PublicKey_;
#pragma warning disable 0169
		static Delegate GetVerify_Ljava_security_PublicKey_Handler ()
		{
			if (cb_verify_Ljava_security_PublicKey_ == null)
				cb_verify_Ljava_security_PublicKey_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Verify_Ljava_security_PublicKey_);
			return cb_verify_Ljava_security_PublicKey_;
		}

		static void n_Verify_Ljava_security_PublicKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPublicKey key = (global::Java.Security.IPublicKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Verify (key);
		}
#pragma warning restore 0169

		static IntPtr id_verify_Ljava_security_PublicKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='verify' and count(parameter)=1 and parameter[1][@type='java.security.PublicKey']]"
		[Register ("verify", "(Ljava/security/PublicKey;)V", "GetVerify_Ljava_security_PublicKey_Handler")]
		public override unsafe void Verify (global::Java.Security.IPublicKey key)
		{
			if (id_verify_Ljava_security_PublicKey_ == IntPtr.Zero)
				id_verify_Ljava_security_PublicKey_ = JNIEnv.GetMethodID (class_ref, "verify", "(Ljava/security/PublicKey;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (key);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verify_Ljava_security_PublicKey_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "verify", "(Ljava/security/PublicKey;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_verify_Ljava_security_PublicKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetVerify_Ljava_security_PublicKey_Ljava_lang_String_Handler ()
		{
			if (cb_verify_Ljava_security_PublicKey_Ljava_lang_String_ == null)
				cb_verify_Ljava_security_PublicKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Verify_Ljava_security_PublicKey_Ljava_lang_String_);
			return cb_verify_Ljava_security_PublicKey_Ljava_lang_String_;
		}

		static void n_Verify_Ljava_security_PublicKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_sigProvider)
		{
			global::Sun.Security.X509.X509CertImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CertImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPublicKey key = (global::Java.Security.IPublicKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (native_key, JniHandleOwnership.DoNotTransfer);
			string sigProvider = JNIEnv.GetString (native_sigProvider, JniHandleOwnership.DoNotTransfer);
			__this.Verify (key, sigProvider);
		}
#pragma warning restore 0169

		static IntPtr id_verify_Ljava_security_PublicKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CertImpl']/method[@name='verify' and count(parameter)=2 and parameter[1][@type='java.security.PublicKey'] and parameter[2][@type='java.lang.String']]"
		[Register ("verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", "GetVerify_Ljava_security_PublicKey_Ljava_lang_String_Handler")]
		public override unsafe void Verify (global::Java.Security.IPublicKey key, string sigProvider)
		{
			if (id_verify_Ljava_security_PublicKey_Ljava_lang_String_ == IntPtr.Zero)
				id_verify_Ljava_security_PublicKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V");
			IntPtr native_sigProvider = JNIEnv.NewString (sigProvider);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (key);
				__args [1] = new JValue (native_sigProvider);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verify_Ljava_security_PublicKey_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sigProvider);
			}
		}

	}
}
