using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Pkcs {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']"
	[global::Android.Runtime.Register ("sun/security/pkcs/SignerInfo", DoNotGenerateAcw=true)]
	public partial class SignerInfo : global::Java.Lang.Object, global::Sun.Security.Util.IDerEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/pkcs/SignerInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SignerInfo); }
		}

		protected SignerInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/constructor[@name='SignerInfo' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerInputStream']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;)V", "")]
		public unsafe SignerInfo (global::Sun.Security.Util.DerInputStream derin)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (derin);
				if (((object) this).GetType () != typeof (SignerInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/DerInputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/DerInputStream;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_DerInputStream_ == IntPtr.Zero)
					id_ctor_Lsun_security_util_DerInputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/DerInputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_DerInputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_DerInputStream_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/constructor[@name='SignerInfo' and count(parameter)=2 and parameter[1][@type='sun.security.util.DerInputStream'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;Z)V", "")]
		public unsafe SignerInfo (global::Sun.Security.Util.DerInputStream derin, bool oldStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (derin);
				__args [1] = new JValue (oldStyle);
				if (((object) this).GetType () != typeof (SignerInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/DerInputStream;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/DerInputStream;Z)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_DerInputStream_Z == IntPtr.Zero)
					id_ctor_Lsun_security_util_DerInputStream_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/DerInputStream;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_DerInputStream_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_DerInputStream_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lsun_security_x509_X500Name_Ljava_math_BigInteger_Lsun_security_x509_AlgorithmId_Lsun_security_pkcs_PKCS9Attributes_Lsun_security_x509_AlgorithmId_arrayBLsun_security_pkcs_PKCS9Attributes_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/constructor[@name='SignerInfo' and count(parameter)=7 and parameter[1][@type='sun.security.x509.X500Name'] and parameter[2][@type='java.math.BigInteger'] and parameter[3][@type='sun.security.x509.AlgorithmId'] and parameter[4][@type='sun.security.pkcs.PKCS9Attributes'] and parameter[5][@type='sun.security.x509.AlgorithmId'] and parameter[6][@type='byte[]'] and parameter[7][@type='sun.security.pkcs.PKCS9Attributes']]"
		[Register (".ctor", "(Lsun/security/x509/X500Name;Ljava/math/BigInteger;Lsun/security/x509/AlgorithmId;Lsun/security/pkcs/PKCS9Attributes;Lsun/security/x509/AlgorithmId;[BLsun/security/pkcs/PKCS9Attributes;)V", "")]
		public unsafe SignerInfo (global::Sun.Security.X509.X500Name issuerName, global::Java.Math.BigInteger serial, global::Sun.Security.X509.AlgorithmId digestAlgorithmId, global::Sun.Security.Pkcs.PKCS9Attributes authenticatedAttributes, global::Sun.Security.X509.AlgorithmId digestEncryptionAlgorithmId, byte[] encryptedDigest, global::Sun.Security.Pkcs.PKCS9Attributes unauthenticatedAttributes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_encryptedDigest = JNIEnv.NewArray (encryptedDigest);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (issuerName);
				__args [1] = new JValue (serial);
				__args [2] = new JValue (digestAlgorithmId);
				__args [3] = new JValue (authenticatedAttributes);
				__args [4] = new JValue (digestEncryptionAlgorithmId);
				__args [5] = new JValue (native_encryptedDigest);
				__args [6] = new JValue (unauthenticatedAttributes);
				if (((object) this).GetType () != typeof (SignerInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/X500Name;Ljava/math/BigInteger;Lsun/security/x509/AlgorithmId;Lsun/security/pkcs/PKCS9Attributes;Lsun/security/x509/AlgorithmId;[BLsun/security/pkcs/PKCS9Attributes;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/X500Name;Ljava/math/BigInteger;Lsun/security/x509/AlgorithmId;Lsun/security/pkcs/PKCS9Attributes;Lsun/security/x509/AlgorithmId;[BLsun/security/pkcs/PKCS9Attributes;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_X500Name_Ljava_math_BigInteger_Lsun_security_x509_AlgorithmId_Lsun_security_pkcs_PKCS9Attributes_Lsun_security_x509_AlgorithmId_arrayBLsun_security_pkcs_PKCS9Attributes_ == IntPtr.Zero)
					id_ctor_Lsun_security_x509_X500Name_Ljava_math_BigInteger_Lsun_security_x509_AlgorithmId_Lsun_security_pkcs_PKCS9Attributes_Lsun_security_x509_AlgorithmId_arrayBLsun_security_pkcs_PKCS9Attributes_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/X500Name;Ljava/math/BigInteger;Lsun/security/x509/AlgorithmId;Lsun/security/pkcs/PKCS9Attributes;Lsun/security/x509/AlgorithmId;[BLsun/security/pkcs/PKCS9Attributes;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_X500Name_Ljava_math_BigInteger_Lsun_security_x509_AlgorithmId_Lsun_security_pkcs_PKCS9Attributes_Lsun_security_x509_AlgorithmId_arrayBLsun_security_pkcs_PKCS9Attributes_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_X500Name_Ljava_math_BigInteger_Lsun_security_x509_AlgorithmId_Lsun_security_pkcs_PKCS9Attributes_Lsun_security_x509_AlgorithmId_arrayBLsun_security_pkcs_PKCS9Attributes_, __args);
			} finally {
				if (encryptedDigest != null) {
					JNIEnv.CopyArray (native_encryptedDigest, encryptedDigest);
					JNIEnv.DeleteLocalRef (native_encryptedDigest);
				}
			}
		}

		static IntPtr id_ctor_Lsun_security_x509_X500Name_Ljava_math_BigInteger_Lsun_security_x509_AlgorithmId_Lsun_security_x509_AlgorithmId_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/constructor[@name='SignerInfo' and count(parameter)=5 and parameter[1][@type='sun.security.x509.X500Name'] and parameter[2][@type='java.math.BigInteger'] and parameter[3][@type='sun.security.x509.AlgorithmId'] and parameter[4][@type='sun.security.x509.AlgorithmId'] and parameter[5][@type='byte[]']]"
		[Register (".ctor", "(Lsun/security/x509/X500Name;Ljava/math/BigInteger;Lsun/security/x509/AlgorithmId;Lsun/security/x509/AlgorithmId;[B)V", "")]
		public unsafe SignerInfo (global::Sun.Security.X509.X500Name issuerName, global::Java.Math.BigInteger serial, global::Sun.Security.X509.AlgorithmId digestAlgorithmId, global::Sun.Security.X509.AlgorithmId digestEncryptionAlgorithmId, byte[] encryptedDigest)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_encryptedDigest = JNIEnv.NewArray (encryptedDigest);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (issuerName);
				__args [1] = new JValue (serial);
				__args [2] = new JValue (digestAlgorithmId);
				__args [3] = new JValue (digestEncryptionAlgorithmId);
				__args [4] = new JValue (native_encryptedDigest);
				if (((object) this).GetType () != typeof (SignerInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/X500Name;Ljava/math/BigInteger;Lsun/security/x509/AlgorithmId;Lsun/security/x509/AlgorithmId;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/X500Name;Ljava/math/BigInteger;Lsun/security/x509/AlgorithmId;Lsun/security/x509/AlgorithmId;[B)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_X500Name_Ljava_math_BigInteger_Lsun_security_x509_AlgorithmId_Lsun_security_x509_AlgorithmId_arrayB == IntPtr.Zero)
					id_ctor_Lsun_security_x509_X500Name_Ljava_math_BigInteger_Lsun_security_x509_AlgorithmId_Lsun_security_x509_AlgorithmId_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/X500Name;Ljava/math/BigInteger;Lsun/security/x509/AlgorithmId;Lsun/security/x509/AlgorithmId;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_X500Name_Ljava_math_BigInteger_Lsun_security_x509_AlgorithmId_Lsun_security_x509_AlgorithmId_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_X500Name_Ljava_math_BigInteger_Lsun_security_x509_AlgorithmId_Lsun_security_x509_AlgorithmId_arrayB, __args);
			} finally {
				if (encryptedDigest != null) {
					JNIEnv.CopyArray (native_encryptedDigest, encryptedDigest);
					JNIEnv.DeleteLocalRef (native_encryptedDigest);
				}
			}
		}

		static Delegate cb_getAuthenticatedAttributes;
#pragma warning disable 0169
		static Delegate GetGetAuthenticatedAttributesHandler ()
		{
			if (cb_getAuthenticatedAttributes == null)
				cb_getAuthenticatedAttributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthenticatedAttributes);
			return cb_getAuthenticatedAttributes;
		}

		static IntPtr n_GetAuthenticatedAttributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.SignerInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SignerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthenticatedAttributes);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthenticatedAttributes;
		public virtual unsafe global::Sun.Security.Pkcs.PKCS9Attributes AuthenticatedAttributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/method[@name='getAuthenticatedAttributes' and count(parameter)=0]"
			[Register ("getAuthenticatedAttributes", "()Lsun/security/pkcs/PKCS9Attributes;", "GetGetAuthenticatedAttributesHandler")]
			get {
				if (id_getAuthenticatedAttributes == IntPtr.Zero)
					id_getAuthenticatedAttributes = JNIEnv.GetMethodID (class_ref, "getAuthenticatedAttributes", "()Lsun/security/pkcs/PKCS9Attributes;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthenticatedAttributes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthenticatedAttributes", "()Lsun/security/pkcs/PKCS9Attributes;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCertificateSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetCertificateSerialNumberHandler ()
		{
			if (cb_getCertificateSerialNumber == null)
				cb_getCertificateSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCertificateSerialNumber);
			return cb_getCertificateSerialNumber;
		}

		static IntPtr n_GetCertificateSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.SignerInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SignerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CertificateSerialNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getCertificateSerialNumber;
		public virtual unsafe global::Java.Math.BigInteger CertificateSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/method[@name='getCertificateSerialNumber' and count(parameter)=0]"
			[Register ("getCertificateSerialNumber", "()Ljava/math/BigInteger;", "GetGetCertificateSerialNumberHandler")]
			get {
				if (id_getCertificateSerialNumber == IntPtr.Zero)
					id_getCertificateSerialNumber = JNIEnv.GetMethodID (class_ref, "getCertificateSerialNumber", "()Ljava/math/BigInteger;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCertificateSerialNumber), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCertificateSerialNumber", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDigestAlgorithmId;
#pragma warning disable 0169
		static Delegate GetGetDigestAlgorithmIdHandler ()
		{
			if (cb_getDigestAlgorithmId == null)
				cb_getDigestAlgorithmId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDigestAlgorithmId);
			return cb_getDigestAlgorithmId;
		}

		static IntPtr n_GetDigestAlgorithmId (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.SignerInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SignerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DigestAlgorithmId);
		}
#pragma warning restore 0169

		static IntPtr id_getDigestAlgorithmId;
		public virtual unsafe global::Sun.Security.X509.AlgorithmId DigestAlgorithmId {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/method[@name='getDigestAlgorithmId' and count(parameter)=0]"
			[Register ("getDigestAlgorithmId", "()Lsun/security/x509/AlgorithmId;", "GetGetDigestAlgorithmIdHandler")]
			get {
				if (id_getDigestAlgorithmId == IntPtr.Zero)
					id_getDigestAlgorithmId = JNIEnv.GetMethodID (class_ref, "getDigestAlgorithmId", "()Lsun/security/x509/AlgorithmId;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDigestAlgorithmId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDigestAlgorithmId", "()Lsun/security/x509/AlgorithmId;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDigestEncryptionAlgorithmId;
#pragma warning disable 0169
		static Delegate GetGetDigestEncryptionAlgorithmIdHandler ()
		{
			if (cb_getDigestEncryptionAlgorithmId == null)
				cb_getDigestEncryptionAlgorithmId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDigestEncryptionAlgorithmId);
			return cb_getDigestEncryptionAlgorithmId;
		}

		static IntPtr n_GetDigestEncryptionAlgorithmId (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.SignerInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SignerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DigestEncryptionAlgorithmId);
		}
#pragma warning restore 0169

		static IntPtr id_getDigestEncryptionAlgorithmId;
		public virtual unsafe global::Sun.Security.X509.AlgorithmId DigestEncryptionAlgorithmId {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/method[@name='getDigestEncryptionAlgorithmId' and count(parameter)=0]"
			[Register ("getDigestEncryptionAlgorithmId", "()Lsun/security/x509/AlgorithmId;", "GetGetDigestEncryptionAlgorithmIdHandler")]
			get {
				if (id_getDigestEncryptionAlgorithmId == IntPtr.Zero)
					id_getDigestEncryptionAlgorithmId = JNIEnv.GetMethodID (class_ref, "getDigestEncryptionAlgorithmId", "()Lsun/security/x509/AlgorithmId;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDigestEncryptionAlgorithmId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDigestEncryptionAlgorithmId", "()Lsun/security/x509/AlgorithmId;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIssuerName;
#pragma warning disable 0169
		static Delegate GetGetIssuerNameHandler ()
		{
			if (cb_getIssuerName == null)
				cb_getIssuerName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIssuerName);
			return cb_getIssuerName;
		}

		static IntPtr n_GetIssuerName (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.SignerInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SignerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IssuerName);
		}
#pragma warning restore 0169

		static IntPtr id_getIssuerName;
		public virtual unsafe global::Sun.Security.X509.X500Name IssuerName {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/method[@name='getIssuerName' and count(parameter)=0]"
			[Register ("getIssuerName", "()Lsun/security/x509/X500Name;", "GetGetIssuerNameHandler")]
			get {
				if (id_getIssuerName == IntPtr.Zero)
					id_getIssuerName = JNIEnv.GetMethodID (class_ref, "getIssuerName", "()Lsun/security/x509/X500Name;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIssuerName), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIssuerName", "()Lsun/security/x509/X500Name;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnauthenticatedAttributes;
#pragma warning disable 0169
		static Delegate GetGetUnauthenticatedAttributesHandler ()
		{
			if (cb_getUnauthenticatedAttributes == null)
				cb_getUnauthenticatedAttributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnauthenticatedAttributes);
			return cb_getUnauthenticatedAttributes;
		}

		static IntPtr n_GetUnauthenticatedAttributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.SignerInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SignerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnauthenticatedAttributes);
		}
#pragma warning restore 0169

		static IntPtr id_getUnauthenticatedAttributes;
		public virtual unsafe global::Sun.Security.Pkcs.PKCS9Attributes UnauthenticatedAttributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/method[@name='getUnauthenticatedAttributes' and count(parameter)=0]"
			[Register ("getUnauthenticatedAttributes", "()Lsun/security/pkcs/PKCS9Attributes;", "GetGetUnauthenticatedAttributesHandler")]
			get {
				if (id_getUnauthenticatedAttributes == IntPtr.Zero)
					id_getUnauthenticatedAttributes = JNIEnv.GetMethodID (class_ref, "getUnauthenticatedAttributes", "()Lsun/security/pkcs/PKCS9Attributes;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUnauthenticatedAttributes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnauthenticatedAttributes", "()Lsun/security/pkcs/PKCS9Attributes;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.SignerInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SignerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual unsafe global::Java.Math.BigInteger Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/math/BigInteger;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/math/BigInteger;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.Pkcs.SignerInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SignerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.DerEncode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_derEncode_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/method[@name='derEncode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
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
			global::Sun.Security.Pkcs.SignerInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SignerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
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

		static Delegate cb_getEncryptedDigest;
#pragma warning disable 0169
		static Delegate GetGetEncryptedDigestHandler ()
		{
			if (cb_getEncryptedDigest == null)
				cb_getEncryptedDigest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncryptedDigest);
			return cb_getEncryptedDigest;
		}

		static IntPtr n_GetEncryptedDigest (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.SignerInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SignerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncryptedDigest ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncryptedDigest;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SignerInfo']/method[@name='getEncryptedDigest' and count(parameter)=0]"
		[Register ("getEncryptedDigest", "()[B", "GetGetEncryptedDigestHandler")]
		public virtual unsafe byte[] GetEncryptedDigest ()
		{
			if (id_getEncryptedDigest == IntPtr.Zero)
				id_getEncryptedDigest = JNIEnv.GetMethodID (class_ref, "getEncryptedDigest", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncryptedDigest), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncryptedDigest", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
