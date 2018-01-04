using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']"
	[global::Android.Runtime.Register ("sun/security/x509/X509CRLImpl", DoNotGenerateAcw=true)]
	public partial class X509CRLImpl : global::Java.Security.Cert.X509CRL {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/X509CRLImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (X509CRLImpl); }
		}

		protected X509CRLImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/constructor[@name='X509CRLImpl' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe X509CRLImpl (byte[] crlData)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_crlData = JNIEnv.NewArray (crlData);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_crlData);
				if (((object) this).GetType () != typeof (X509CRLImpl)) {
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
				if (crlData != null) {
					JNIEnv.CopyArray (native_crlData, crlData);
					JNIEnv.DeleteLocalRef (native_crlData);
				}
			}
		}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/constructor[@name='X509CRLImpl' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe X509CRLImpl (global::System.IO.Stream inStrm)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_inStrm = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inStrm);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_inStrm);
				if (((object) this).GetType () != typeof (X509CRLImpl)) {
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
				JNIEnv.DeleteLocalRef (native_inStrm);
			}
		}

		static IntPtr id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/constructor[@name='X509CRLImpl' and count(parameter)=3 and parameter[1][@type='sun.security.x509.X500Name'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='java.util.Date']]"
		[Register (".ctor", "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;)V", "")]
		public unsafe X509CRLImpl (global::Sun.Security.X509.X500Name issuer, global::Java.Util.Date thisDate, global::Java.Util.Date nextDate)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (issuer);
				__args [1] = new JValue (thisDate);
				__args [2] = new JValue (nextDate);
				if (((object) this).GetType () != typeof (X509CRLImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_ == IntPtr.Zero)
					id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_arrayLjava_security_cert_X509CRLEntry_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/constructor[@name='X509CRLImpl' and count(parameter)=4 and parameter[1][@type='sun.security.x509.X500Name'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='java.util.Date'] and parameter[4][@type='java.security.cert.X509CRLEntry[]']]"
		[Register (".ctor", "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;[Ljava/security/cert/X509CRLEntry;)V", "")]
		public unsafe X509CRLImpl (global::Sun.Security.X509.X500Name issuer, global::Java.Util.Date thisDate, global::Java.Util.Date nextDate, global::Java.Security.Cert.X509CRLEntry[] badCerts)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_badCerts = JNIEnv.NewArray (badCerts);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (issuer);
				__args [1] = new JValue (thisDate);
				__args [2] = new JValue (nextDate);
				__args [3] = new JValue (native_badCerts);
				if (((object) this).GetType () != typeof (X509CRLImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;[Ljava/security/cert/X509CRLEntry;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;[Ljava/security/cert/X509CRLEntry;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_arrayLjava_security_cert_X509CRLEntry_ == IntPtr.Zero)
					id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_arrayLjava_security_cert_X509CRLEntry_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;[Ljava/security/cert/X509CRLEntry;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_arrayLjava_security_cert_X509CRLEntry_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_arrayLjava_security_cert_X509CRLEntry_, __args);
			} finally {
				if (badCerts != null) {
					JNIEnv.CopyArray (native_badCerts, badCerts);
					JNIEnv.DeleteLocalRef (native_badCerts);
				}
			}
		}

		static IntPtr id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_arrayLjava_security_cert_X509CRLEntry_Lsun_security_x509_CRLExtensions_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/constructor[@name='X509CRLImpl' and count(parameter)=5 and parameter[1][@type='sun.security.x509.X500Name'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='java.util.Date'] and parameter[4][@type='java.security.cert.X509CRLEntry[]'] and parameter[5][@type='sun.security.x509.CRLExtensions']]"
		[Register (".ctor", "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;[Ljava/security/cert/X509CRLEntry;Lsun/security/x509/CRLExtensions;)V", "")]
		public unsafe X509CRLImpl (global::Sun.Security.X509.X500Name issuer, global::Java.Util.Date thisDate, global::Java.Util.Date nextDate, global::Java.Security.Cert.X509CRLEntry[] badCerts, global::Sun.Security.X509.CRLExtensions crlExts)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_badCerts = JNIEnv.NewArray (badCerts);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (issuer);
				__args [1] = new JValue (thisDate);
				__args [2] = new JValue (nextDate);
				__args [3] = new JValue (native_badCerts);
				__args [4] = new JValue (crlExts);
				if (((object) this).GetType () != typeof (X509CRLImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;[Ljava/security/cert/X509CRLEntry;Lsun/security/x509/CRLExtensions;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;[Ljava/security/cert/X509CRLEntry;Lsun/security/x509/CRLExtensions;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_arrayLjava_security_cert_X509CRLEntry_Lsun_security_x509_CRLExtensions_ == IntPtr.Zero)
					id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_arrayLjava_security_cert_X509CRLEntry_Lsun_security_x509_CRLExtensions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/X500Name;Ljava/util/Date;Ljava/util/Date;[Ljava/security/cert/X509CRLEntry;Lsun/security/x509/CRLExtensions;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_arrayLjava_security_cert_X509CRLEntry_Lsun_security_x509_CRLExtensions_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_X500Name_Ljava_util_Date_Ljava_util_Date_arrayLjava_security_cert_X509CRLEntry_Lsun_security_x509_CRLExtensions_, __args);
			} finally {
				if (badCerts != null) {
					JNIEnv.CopyArray (native_badCerts, badCerts);
					JNIEnv.DeleteLocalRef (native_badCerts);
				}
			}
		}

		static Delegate cb_getAuthKeyId;
#pragma warning disable 0169
		static Delegate GetGetAuthKeyIdHandler ()
		{
			if (cb_getAuthKeyId == null)
				cb_getAuthKeyId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthKeyId);
			return cb_getAuthKeyId;
		}

		static IntPtr n_GetAuthKeyId (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthKeyId);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthKeyId;
		public virtual unsafe global::Sun.Security.X509.KeyIdentifier AuthKeyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getAuthKeyId' and count(parameter)=0]"
			[Register ("getAuthKeyId", "()Lsun/security/x509/KeyIdentifier;", "GetGetAuthKeyIdHandler")]
			get {
				if (id_getAuthKeyId == IntPtr.Zero)
					id_getAuthKeyId = JNIEnv.GetMethodID (class_ref, "getAuthKeyId", "()Lsun/security/x509/KeyIdentifier;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.KeyIdentifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthKeyId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.KeyIdentifier> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthKeyId", "()Lsun/security/x509/KeyIdentifier;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBaseCRLNumber;
#pragma warning disable 0169
		static Delegate GetGetBaseCRLNumberHandler ()
		{
			if (cb_getBaseCRLNumber == null)
				cb_getBaseCRLNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseCRLNumber);
			return cb_getBaseCRLNumber;
		}

		static IntPtr n_GetBaseCRLNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseCRLNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getBaseCRLNumber;
		public virtual unsafe global::Java.Math.BigInteger BaseCRLNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getBaseCRLNumber' and count(parameter)=0]"
			[Register ("getBaseCRLNumber", "()Ljava/math/BigInteger;", "GetGetBaseCRLNumberHandler")]
			get {
				if (id_getBaseCRLNumber == IntPtr.Zero)
					id_getBaseCRLNumber = JNIEnv.GetMethodID (class_ref, "getBaseCRLNumber", "()Ljava/math/BigInteger;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaseCRLNumber), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaseCRLNumber", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCRLNumber;
#pragma warning disable 0169
		static Delegate GetGetCRLNumberHandler ()
		{
			if (cb_getCRLNumber == null)
				cb_getCRLNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCRLNumber);
			return cb_getCRLNumber;
		}

		static IntPtr n_GetCRLNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CRLNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getCRLNumber;
		public virtual unsafe global::Java.Math.BigInteger CRLNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getCRLNumber' and count(parameter)=0]"
			[Register ("getCRLNumber", "()Ljava/math/BigInteger;", "GetGetCRLNumberHandler")]
			get {
				if (id_getCRLNumber == IntPtr.Zero)
					id_getCRLNumber = JNIEnv.GetMethodID (class_ref, "getCRLNumber", "()Ljava/math/BigInteger;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCRLNumber), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCRLNumber", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.CriticalExtensionOIDs);
		}
#pragma warning restore 0169

		static IntPtr id_getCriticalExtensionOIDs;
		public override unsafe global::System.Collections.Generic.ICollection<string> CriticalExtensionOIDs {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getCriticalExtensionOIDs' and count(parameter)=0]"
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUnsupportedCriticalExtension;
		}
#pragma warning restore 0169

		static IntPtr id_hasUnsupportedCriticalExtension;
		public override unsafe bool HasUnsupportedCriticalExtension {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='hasUnsupportedCriticalExtension' and count(parameter)=0]"
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IssuerDN);
		}
#pragma warning restore 0169

		static IntPtr id_getIssuerDN;
		public override unsafe global::Java.Security.IPrincipal IssuerDN {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getIssuerDN' and count(parameter)=0]"
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

		static Delegate cb_getNextUpdate;
#pragma warning disable 0169
		static Delegate GetGetNextUpdateHandler ()
		{
			if (cb_getNextUpdate == null)
				cb_getNextUpdate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextUpdate);
			return cb_getNextUpdate;
		}

		static IntPtr n_GetNextUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextUpdate);
		}
#pragma warning restore 0169

		static IntPtr id_getNextUpdate;
		public override unsafe global::Java.Util.Date NextUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getNextUpdate' and count(parameter)=0]"
			[Register ("getNextUpdate", "()Ljava/util/Date;", "GetGetNextUpdateHandler")]
			get {
				if (id_getNextUpdate == IntPtr.Zero)
					id_getNextUpdate = JNIEnv.GetMethodID (class_ref, "getNextUpdate", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNextUpdate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextUpdate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.NonCriticalExtensionOIDs);
		}
#pragma warning restore 0169

		static IntPtr id_getNonCriticalExtensionOIDs;
		public override unsafe global::System.Collections.Generic.ICollection<string> NonCriticalExtensionOIDs {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getNonCriticalExtensionOIDs' and count(parameter)=0]"
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

		static Delegate cb_getRevokedCertificates;
#pragma warning disable 0169
		static Delegate GetGetRevokedCertificatesHandler ()
		{
			if (cb_getRevokedCertificates == null)
				cb_getRevokedCertificates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRevokedCertificates);
			return cb_getRevokedCertificates;
		}

		static IntPtr n_GetRevokedCertificates (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Security.Cert.X509CRLEntry>.ToLocalJniHandle (__this.RevokedCertificates);
		}
#pragma warning restore 0169

		static IntPtr id_getRevokedCertificates;
		public override unsafe global::System.Collections.Generic.ICollection<global::Java.Security.Cert.X509CRLEntry> RevokedCertificates {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getRevokedCertificates' and count(parameter)=0]"
			[Register ("getRevokedCertificates", "()Ljava/util/Set;", "GetGetRevokedCertificatesHandler")]
			get {
				if (id_getRevokedCertificates == IntPtr.Zero)
					id_getRevokedCertificates = JNIEnv.GetMethodID (class_ref, "getRevokedCertificates", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Java.Security.Cert.X509CRLEntry>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRevokedCertificates), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Java.Security.Cert.X509CRLEntry>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRevokedCertificates", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SigAlgName);
		}
#pragma warning restore 0169

		static IntPtr id_getSigAlgName;
		public override unsafe string SigAlgName {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getSigAlgName' and count(parameter)=0]"
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SigAlgOID);
		}
#pragma warning restore 0169

		static IntPtr id_getSigAlgOID;
		public override unsafe string SigAlgOID {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getSigAlgOID' and count(parameter)=0]"
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

		static Delegate cb_getThisUpdate;
#pragma warning disable 0169
		static Delegate GetGetThisUpdateHandler ()
		{
			if (cb_getThisUpdate == null)
				cb_getThisUpdate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThisUpdate);
			return cb_getThisUpdate;
		}

		static IntPtr n_GetThisUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThisUpdate);
		}
#pragma warning restore 0169

		static IntPtr id_getThisUpdate;
		public override unsafe global::Java.Util.Date ThisUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getThisUpdate' and count(parameter)=0]"
			[Register ("getThisUpdate", "()Ljava/util/Date;", "GetGetThisUpdateHandler")]
			get {
				if (id_getThisUpdate == IntPtr.Zero)
					id_getThisUpdate = JNIEnv.GetMethodID (class_ref, "getThisUpdate", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThisUpdate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThisUpdate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public override unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getVersion' and count(parameter)=0]"
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

		static Delegate cb_encodeInfo_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncodeInfo_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encodeInfo_Ljava_io_OutputStream_ == null)
				cb_encodeInfo_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EncodeInfo_Ljava_io_OutputStream_);
			return cb_encodeInfo_Ljava_io_OutputStream_;
		}

		static void n_EncodeInfo_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.EncodeInfo (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encodeInfo_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='encodeInfo' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("encodeInfo", "(Ljava/io/OutputStream;)V", "GetEncodeInfo_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void EncodeInfo (global::System.IO.Stream @out)
		{
			if (id_encodeInfo_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encodeInfo_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encodeInfo", "(Ljava/io/OutputStream;)V");
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeInfo_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeInfo", "(Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncoded ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncoded;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getEncoded' and count(parameter)=0]"
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncodedInternal ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncodedInternal;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getEncodedInternal' and count(parameter)=0]"
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

		static IntPtr id_getEncodedInternal_Ljava_security_cert_X509CRL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getEncodedInternal' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509CRL']]"
		[Register ("getEncodedInternal", "(Ljava/security/cert/X509CRL;)[B", "")]
		public static unsafe byte[] GetEncodedInternal (global::Java.Security.Cert.X509CRL crl)
		{
			if (id_getEncodedInternal_Ljava_security_cert_X509CRL_ == IntPtr.Zero)
				id_getEncodedInternal_Ljava_security_cert_X509CRL_ = JNIEnv.GetStaticMethodID (class_ref, "getEncodedInternal", "(Ljava/security/cert/X509CRL;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (crl);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEncodedInternal_Ljava_security_cert_X509CRL_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getExtension_Lsun_security_util_ObjectIdentifier_;
#pragma warning disable 0169
		static Delegate GetGetExtension_Lsun_security_util_ObjectIdentifier_Handler ()
		{
			if (cb_getExtension_Lsun_security_util_ObjectIdentifier_ == null)
				cb_getExtension_Lsun_security_util_ObjectIdentifier_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetExtension_Lsun_security_util_ObjectIdentifier_);
			return cb_getExtension_Lsun_security_util_ObjectIdentifier_;
		}

		static IntPtr n_GetExtension_Lsun_security_util_ObjectIdentifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oid)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.ObjectIdentifier oid = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (native_oid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetExtension (oid));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getExtension_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getExtension' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Register ("getExtension", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/Object;", "GetGetExtension_Lsun_security_util_ObjectIdentifier_Handler")]
		public virtual unsafe global::Java.Lang.Object GetExtension (global::Sun.Security.Util.ObjectIdentifier oid)
		{
			if (id_getExtension_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
				id_getExtension_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetMethodID (class_ref, "getExtension", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (oid);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtension_Lsun_security_util_ObjectIdentifier_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtension", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string oid = JNIEnv.GetString (native_oid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetExtensionValue (oid));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getExtensionValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getExtensionValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_getIssuerX500Principal_Ljava_security_cert_X509CRL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getIssuerX500Principal' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509CRL']]"
		[Register ("getIssuerX500Principal", "(Ljava/security/cert/X509CRL;)Ljavax/security/auth/x500/X500Principal;", "")]
		public static unsafe global::Javax.Security.Auth.X500.X500Principal GetIssuerX500Principal (global::Java.Security.Cert.X509CRL crl)
		{
			if (id_getIssuerX500Principal_Ljava_security_cert_X509CRL_ == IntPtr.Zero)
				id_getIssuerX500Principal_Ljava_security_cert_X509CRL_ = JNIEnv.GetStaticMethodID (class_ref, "getIssuerX500Principal", "(Ljava/security/cert/X509CRL;)Ljavax/security/auth/x500/X500Principal;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (crl);
				global::Javax.Security.Auth.X500.X500Principal __ret = global::Java.Lang.Object.GetObject<global::Javax.Security.Auth.X500.X500Principal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIssuerX500Principal_Ljava_security_cert_X509CRL_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getRevokedCertificate_Ljava_math_BigInteger_;
#pragma warning disable 0169
		static Delegate GetGetRevokedCertificate_Ljava_math_BigInteger_Handler ()
		{
			if (cb_getRevokedCertificate_Ljava_math_BigInteger_ == null)
				cb_getRevokedCertificate_Ljava_math_BigInteger_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRevokedCertificate_Ljava_math_BigInteger_);
			return cb_getRevokedCertificate_Ljava_math_BigInteger_;
		}

		static IntPtr n_GetRevokedCertificate_Ljava_math_BigInteger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serialNumber)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Math.BigInteger serialNumber = global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (native_serialNumber, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRevokedCertificate (serialNumber));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRevokedCertificate_Ljava_math_BigInteger_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getRevokedCertificate' and count(parameter)=1 and parameter[1][@type='java.math.BigInteger']]"
		[Register ("getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;", "GetGetRevokedCertificate_Ljava_math_BigInteger_Handler")]
		public override unsafe global::Java.Security.Cert.X509CRLEntry GetRevokedCertificate (global::Java.Math.BigInteger serialNumber)
		{
			if (id_getRevokedCertificate_Ljava_math_BigInteger_ == IntPtr.Zero)
				id_getRevokedCertificate_Ljava_math_BigInteger_ = JNIEnv.GetMethodID (class_ref, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (serialNumber);

				global::Java.Security.Cert.X509CRLEntry __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509CRLEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRevokedCertificate_Ljava_math_BigInteger_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509CRLEntry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSigAlgParams ());
		}
#pragma warning restore 0169

		static IntPtr id_getSigAlgParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getSigAlgParams' and count(parameter)=0]"
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSignature ());
		}
#pragma warning restore 0169

		static IntPtr id_getSignature;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getSignature' and count(parameter)=0]"
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

		static Delegate cb_getTBSCertList;
#pragma warning disable 0169
		static Delegate GetGetTBSCertListHandler ()
		{
			if (cb_getTBSCertList == null)
				cb_getTBSCertList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTBSCertList);
			return cb_getTBSCertList;
		}

		static IntPtr n_GetTBSCertList (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTBSCertList ());
		}
#pragma warning restore 0169

		static IntPtr id_getTBSCertList;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='getTBSCertList' and count(parameter)=0]"
		[Register ("getTBSCertList", "()[B", "GetGetTBSCertListHandler")]
		public override unsafe byte[] GetTBSCertList ()
		{
			if (id_getTBSCertList == IntPtr.Zero)
				id_getTBSCertList = JNIEnv.GetMethodID (class_ref, "getTBSCertList", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTBSCertList), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTBSCertList", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_isRevoked_Ljava_security_cert_Certificate_;
#pragma warning disable 0169
		static Delegate GetIsRevoked_Ljava_security_cert_Certificate_Handler ()
		{
			if (cb_isRevoked_Ljava_security_cert_Certificate_ == null)
				cb_isRevoked_Ljava_security_cert_Certificate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsRevoked_Ljava_security_cert_Certificate_);
			return cb_isRevoked_Ljava_security_cert_Certificate_;
		}

		static bool n_IsRevoked_Ljava_security_cert_Certificate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cert)
		{
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.Certificate cert = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.Certificate> (native_cert, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsRevoked (cert);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isRevoked_Ljava_security_cert_Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='isRevoked' and count(parameter)=1 and parameter[1][@type='java.security.cert.Certificate']]"
		[Register ("isRevoked", "(Ljava/security/cert/Certificate;)Z", "GetIsRevoked_Ljava_security_cert_Certificate_Handler")]
		public override unsafe bool IsRevoked (global::Java.Security.Cert.Certificate cert)
		{
			if (id_isRevoked_Ljava_security_cert_Certificate_ == IntPtr.Zero)
				id_isRevoked_Ljava_security_cert_Certificate_ = JNIEnv.GetMethodID (class_ref, "isRevoked", "(Ljava/security/cert/Certificate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cert);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRevoked_Ljava_security_cert_Certificate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRevoked", "(Ljava/security/cert/Certificate;)Z"), __args);
				return __ret;
			} finally {
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPrivateKey key = (global::Java.Security.IPrivateKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (native_key, JniHandleOwnership.DoNotTransfer);
			string algorithm = JNIEnv.GetString (native_algorithm, JniHandleOwnership.DoNotTransfer);
			__this.Sign (key, algorithm);
		}
#pragma warning restore 0169

		static IntPtr id_sign_Ljava_security_PrivateKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='sign' and count(parameter)=2 and parameter[1][@type='java.security.PrivateKey'] and parameter[2][@type='java.lang.String']]"
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPrivateKey key = (global::Java.Security.IPrivateKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (native_key, JniHandleOwnership.DoNotTransfer);
			string algorithm = JNIEnv.GetString (native_algorithm, JniHandleOwnership.DoNotTransfer);
			string provider = JNIEnv.GetString (native_provider, JniHandleOwnership.DoNotTransfer);
			__this.Sign (key, algorithm, provider);
		}
#pragma warning restore 0169

		static IntPtr id_sign_Ljava_security_PrivateKey_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='sign' and count(parameter)=3 and parameter[1][@type='java.security.PrivateKey'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
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

		static IntPtr id_toImpl_Ljava_security_cert_X509CRL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='toImpl' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509CRL']]"
		[Register ("toImpl", "(Ljava/security/cert/X509CRL;)Lsun/security/x509/X509CRLImpl;", "")]
		public static unsafe global::Sun.Security.X509.X509CRLImpl ToImpl (global::Java.Security.Cert.X509CRL crl)
		{
			if (id_toImpl_Ljava_security_cert_X509CRL_ == IntPtr.Zero)
				id_toImpl_Ljava_security_cert_X509CRL_ = JNIEnv.GetStaticMethodID (class_ref, "toImpl", "(Ljava/security/cert/X509CRL;)Lsun/security/x509/X509CRLImpl;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (crl);
				global::Sun.Security.X509.X509CRLImpl __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toImpl_Ljava_security_cert_X509CRL_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='toString' and count(parameter)=0]"
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPublicKey key = (global::Java.Security.IPublicKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Verify (key);
		}
#pragma warning restore 0169

		static IntPtr id_verify_Ljava_security_PublicKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='verify' and count(parameter)=1 and parameter[1][@type='java.security.PublicKey']]"
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
			global::Sun.Security.X509.X509CRLImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPublicKey key = (global::Java.Security.IPublicKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (native_key, JniHandleOwnership.DoNotTransfer);
			string sigProvider = JNIEnv.GetString (native_sigProvider, JniHandleOwnership.DoNotTransfer);
			__this.Verify (key, sigProvider);
		}
#pragma warning restore 0169

		static IntPtr id_verify_Ljava_security_PublicKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLImpl']/method[@name='verify' and count(parameter)=2 and parameter[1][@type='java.security.PublicKey'] and parameter[2][@type='java.lang.String']]"
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
