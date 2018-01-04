using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']"
	[global::Android.Runtime.Register ("sun/security/x509/AlgorithmId", DoNotGenerateAcw=true)]
	public partial class AlgorithmId : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Sun.Security.Util.IDerEncoder {


		static IntPtr DH_PKIX_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='DH_PKIX_oid']"
		[Register ("DH_PKIX_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier DHPKIXOid {
			get {
				if (DH_PKIX_oid_jfieldId == IntPtr.Zero)
					DH_PKIX_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DH_PKIX_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DH_PKIX_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DH_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='DH_oid']"
		[Register ("DH_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier DHOid {
			get {
				if (DH_oid_jfieldId == IntPtr.Zero)
					DH_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DH_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DH_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DSA_OIW_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='DSA_OIW_oid']"
		[Register ("DSA_OIW_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier DSAOIWOid {
			get {
				if (DSA_OIW_oid_jfieldId == IntPtr.Zero)
					DSA_OIW_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSA_OIW_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSA_OIW_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DSA_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='DSA_oid']"
		[Register ("DSA_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier DSAOid {
			get {
				if (DSA_oid_jfieldId == IntPtr.Zero)
					DSA_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSA_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSA_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EC_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='EC_oid']"
		[Register ("EC_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier ECOid {
			get {
				if (EC_oid_jfieldId == IntPtr.Zero)
					EC_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EC_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EC_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MD2_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='MD2_oid']"
		[Register ("MD2_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier MD2Oid {
			get {
				if (MD2_oid_jfieldId == IntPtr.Zero)
					MD2_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MD2_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MD2_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MD5_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='MD5_oid']"
		[Register ("MD5_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier MD5Oid {
			get {
				if (MD5_oid_jfieldId == IntPtr.Zero)
					MD5_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MD5_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MD5_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RSAEncryption_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='RSAEncryption_oid']"
		[Register ("RSAEncryption_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier RSAEncryptionOid {
			get {
				if (RSAEncryption_oid_jfieldId == IntPtr.Zero)
					RSAEncryption_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RSAEncryption_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RSAEncryption_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RSA_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='RSA_oid']"
		[Register ("RSA_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier RSAOid {
			get {
				if (RSA_oid_jfieldId == IntPtr.Zero)
					RSA_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RSA_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RSA_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHA256_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='SHA256_oid']"
		[Register ("SHA256_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier SHA256Oid {
			get {
				if (SHA256_oid_jfieldId == IntPtr.Zero)
					SHA256_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHA256_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHA256_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHA384_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='SHA384_oid']"
		[Register ("SHA384_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier SHA384Oid {
			get {
				if (SHA384_oid_jfieldId == IntPtr.Zero)
					SHA384_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHA384_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHA384_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHA512_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='SHA512_oid']"
		[Register ("SHA512_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier SHA512Oid {
			get {
				if (SHA512_oid_jfieldId == IntPtr.Zero)
					SHA512_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHA512_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHA512_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHA_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='SHA_oid']"
		[Register ("SHA_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier SHAOid {
			get {
				if (SHA_oid_jfieldId == IntPtr.Zero)
					SHA_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHA_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHA_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr md2WithRSAEncryption_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='md2WithRSAEncryption_oid']"
		[Register ("md2WithRSAEncryption_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Md2WithRSAEncryptionOid {
			get {
				if (md2WithRSAEncryption_oid_jfieldId == IntPtr.Zero)
					md2WithRSAEncryption_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "md2WithRSAEncryption_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, md2WithRSAEncryption_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr md5WithRSAEncryption_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='md5WithRSAEncryption_oid']"
		[Register ("md5WithRSAEncryption_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Md5WithRSAEncryptionOid {
			get {
				if (md5WithRSAEncryption_oid_jfieldId == IntPtr.Zero)
					md5WithRSAEncryption_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "md5WithRSAEncryption_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, md5WithRSAEncryption_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr pbeWithMD5AndDES_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='pbeWithMD5AndDES_oid']"
		[Register ("pbeWithMD5AndDES_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier PbeWithMD5AndDESOid {
			get {
				if (pbeWithMD5AndDES_oid_jfieldId == IntPtr.Zero)
					pbeWithMD5AndDES_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pbeWithMD5AndDES_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, pbeWithMD5AndDES_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr pbeWithMD5AndRC2_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='pbeWithMD5AndRC2_oid']"
		[Register ("pbeWithMD5AndRC2_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier PbeWithMD5AndRC2Oid {
			get {
				if (pbeWithMD5AndRC2_oid_jfieldId == IntPtr.Zero)
					pbeWithMD5AndRC2_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pbeWithMD5AndRC2_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, pbeWithMD5AndRC2_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr pbeWithSHA1AndDES_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='pbeWithSHA1AndDES_oid']"
		[Register ("pbeWithSHA1AndDES_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier PbeWithSHA1AndDESOid {
			get {
				if (pbeWithSHA1AndDES_oid_jfieldId == IntPtr.Zero)
					pbeWithSHA1AndDES_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pbeWithSHA1AndDES_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, pbeWithSHA1AndDES_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr pbeWithSHA1AndDESede_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='pbeWithSHA1AndDESede_oid']"
		[Register ("pbeWithSHA1AndDESede_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier PbeWithSHA1AndDESedeOid {
			get {
				if (pbeWithSHA1AndDESede_oid_jfieldId == IntPtr.Zero)
					pbeWithSHA1AndDESede_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pbeWithSHA1AndDESede_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, pbeWithSHA1AndDESede_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pbeWithSHA1AndDESede_oid_jfieldId == IntPtr.Zero)
					pbeWithSHA1AndDESede_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pbeWithSHA1AndDESede_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, pbeWithSHA1AndDESede_oid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pbeWithSHA1AndRC2_40_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='pbeWithSHA1AndRC2_40_oid']"
		[Register ("pbeWithSHA1AndRC2_40_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier PbeWithSHA1AndRC240Oid {
			get {
				if (pbeWithSHA1AndRC2_40_oid_jfieldId == IntPtr.Zero)
					pbeWithSHA1AndRC2_40_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pbeWithSHA1AndRC2_40_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, pbeWithSHA1AndRC2_40_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pbeWithSHA1AndRC2_40_oid_jfieldId == IntPtr.Zero)
					pbeWithSHA1AndRC2_40_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pbeWithSHA1AndRC2_40_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, pbeWithSHA1AndRC2_40_oid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pbeWithSHA1AndRC2_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='pbeWithSHA1AndRC2_oid']"
		[Register ("pbeWithSHA1AndRC2_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier PbeWithSHA1AndRC2Oid {
			get {
				if (pbeWithSHA1AndRC2_oid_jfieldId == IntPtr.Zero)
					pbeWithSHA1AndRC2_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pbeWithSHA1AndRC2_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, pbeWithSHA1AndRC2_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha1WithDSA_OIW_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha1WithDSA_OIW_oid']"
		[Register ("sha1WithDSA_OIW_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha1WithDSAOIWOid {
			get {
				if (sha1WithDSA_OIW_oid_jfieldId == IntPtr.Zero)
					sha1WithDSA_OIW_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha1WithDSA_OIW_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha1WithDSA_OIW_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha1WithDSA_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha1WithDSA_oid']"
		[Register ("sha1WithDSA_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha1WithDSAOid {
			get {
				if (sha1WithDSA_oid_jfieldId == IntPtr.Zero)
					sha1WithDSA_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha1WithDSA_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha1WithDSA_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha1WithECDSA_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha1WithECDSA_oid']"
		[Register ("sha1WithECDSA_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha1WithECDSAOid {
			get {
				if (sha1WithECDSA_oid_jfieldId == IntPtr.Zero)
					sha1WithECDSA_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha1WithECDSA_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha1WithECDSA_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha1WithRSAEncryption_OIW_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha1WithRSAEncryption_OIW_oid']"
		[Register ("sha1WithRSAEncryption_OIW_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha1WithRSAEncryptionOIWOid {
			get {
				if (sha1WithRSAEncryption_OIW_oid_jfieldId == IntPtr.Zero)
					sha1WithRSAEncryption_OIW_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha1WithRSAEncryption_OIW_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha1WithRSAEncryption_OIW_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha1WithRSAEncryption_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha1WithRSAEncryption_oid']"
		[Register ("sha1WithRSAEncryption_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha1WithRSAEncryptionOid {
			get {
				if (sha1WithRSAEncryption_oid_jfieldId == IntPtr.Zero)
					sha1WithRSAEncryption_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha1WithRSAEncryption_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha1WithRSAEncryption_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha224WithECDSA_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha224WithECDSA_oid']"
		[Register ("sha224WithECDSA_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha224WithECDSAOid {
			get {
				if (sha224WithECDSA_oid_jfieldId == IntPtr.Zero)
					sha224WithECDSA_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha224WithECDSA_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha224WithECDSA_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha256WithECDSA_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha256WithECDSA_oid']"
		[Register ("sha256WithECDSA_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha256WithECDSAOid {
			get {
				if (sha256WithECDSA_oid_jfieldId == IntPtr.Zero)
					sha256WithECDSA_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha256WithECDSA_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha256WithECDSA_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha256WithRSAEncryption_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha256WithRSAEncryption_oid']"
		[Register ("sha256WithRSAEncryption_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha256WithRSAEncryptionOid {
			get {
				if (sha256WithRSAEncryption_oid_jfieldId == IntPtr.Zero)
					sha256WithRSAEncryption_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha256WithRSAEncryption_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha256WithRSAEncryption_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha384WithECDSA_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha384WithECDSA_oid']"
		[Register ("sha384WithECDSA_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha384WithECDSAOid {
			get {
				if (sha384WithECDSA_oid_jfieldId == IntPtr.Zero)
					sha384WithECDSA_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha384WithECDSA_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha384WithECDSA_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha384WithRSAEncryption_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha384WithRSAEncryption_oid']"
		[Register ("sha384WithRSAEncryption_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha384WithRSAEncryptionOid {
			get {
				if (sha384WithRSAEncryption_oid_jfieldId == IntPtr.Zero)
					sha384WithRSAEncryption_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha384WithRSAEncryption_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha384WithRSAEncryption_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha512WithECDSA_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha512WithECDSA_oid']"
		[Register ("sha512WithECDSA_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha512WithECDSAOid {
			get {
				if (sha512WithECDSA_oid_jfieldId == IntPtr.Zero)
					sha512WithECDSA_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha512WithECDSA_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha512WithECDSA_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sha512WithRSAEncryption_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='sha512WithRSAEncryption_oid']"
		[Register ("sha512WithRSAEncryption_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier Sha512WithRSAEncryptionOid {
			get {
				if (sha512WithRSAEncryption_oid_jfieldId == IntPtr.Zero)
					sha512WithRSAEncryption_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sha512WithRSAEncryption_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sha512WithRSAEncryption_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr shaWithDSA_OIW_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='shaWithDSA_OIW_oid']"
		[Register ("shaWithDSA_OIW_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier ShaWithDSAOIWOid {
			get {
				if (shaWithDSA_OIW_oid_jfieldId == IntPtr.Zero)
					shaWithDSA_OIW_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "shaWithDSA_OIW_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, shaWithDSA_OIW_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr specifiedWithECDSA_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/field[@name='specifiedWithECDSA_oid']"
		[Register ("specifiedWithECDSA_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier SpecifiedWithECDSAOid {
			get {
				if (specifiedWithECDSA_oid_jfieldId == IntPtr.Zero)
					specifiedWithECDSA_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "specifiedWithECDSA_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, specifiedWithECDSA_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/AlgorithmId", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlgorithmId); }
		}

		protected AlgorithmId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/constructor[@name='AlgorithmId' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlgorithmId ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AlgorithmId)) {
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

		static IntPtr id_ctor_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/constructor[@name='AlgorithmId' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Register (".ctor", "(Lsun/security/util/ObjectIdentifier;)V", "")]
		public unsafe AlgorithmId (global::Sun.Security.Util.ObjectIdentifier oid)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (oid);
				if (((object) this).GetType () != typeof (AlgorithmId)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/ObjectIdentifier;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/ObjectIdentifier;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
					id_ctor_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/ObjectIdentifier;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_ObjectIdentifier_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_ObjectIdentifier_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_security_AlgorithmParameters_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/constructor[@name='AlgorithmId' and count(parameter)=2 and parameter[1][@type='sun.security.util.ObjectIdentifier'] and parameter[2][@type='java.security.AlgorithmParameters']]"
		[Register (".ctor", "(Lsun/security/util/ObjectIdentifier;Ljava/security/AlgorithmParameters;)V", "")]
		public unsafe AlgorithmId (global::Sun.Security.Util.ObjectIdentifier oid, global::Java.Security.AlgorithmParameters algparams)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (oid);
				__args [1] = new JValue (algparams);
				if (((object) this).GetType () != typeof (AlgorithmId)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/ObjectIdentifier;Ljava/security/AlgorithmParameters;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/ObjectIdentifier;Ljava/security/AlgorithmParameters;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_security_AlgorithmParameters_ == IntPtr.Zero)
					id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_security_AlgorithmParameters_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/ObjectIdentifier;Ljava/security/AlgorithmParameters;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_security_AlgorithmParameters_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_security_AlgorithmParameters_, __args);
			} finally {
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
			global::Sun.Security.X509.AlgorithmId __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='getName' and count(parameter)=0]"
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

		static IntPtr id_getOID;
		public unsafe global::Sun.Security.Util.ObjectIdentifier OID {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='getOID' and count(parameter)=0]"
			[Register ("getOID", "()Lsun/security/util/ObjectIdentifier;", "GetGetOIDHandler")]
			get {
				if (id_getOID == IntPtr.Zero)
					id_getOID = JNIEnv.GetMethodID (class_ref, "getOID", "()Lsun/security/util/ObjectIdentifier;");
				try {
					return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParameters;
#pragma warning disable 0169
		static Delegate GetGetParametersHandler ()
		{
			if (cb_getParameters == null)
				cb_getParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParameters);
			return cb_getParameters;
		}

		static IntPtr n_GetParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.AlgorithmId __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parameters);
		}
#pragma warning restore 0169

		static IntPtr id_getParameters;
		public virtual unsafe global::Java.Security.AlgorithmParameters Parameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='getParameters' and count(parameter)=0]"
			[Register ("getParameters", "()Ljava/security/AlgorithmParameters;", "GetGetParametersHandler")]
			get {
				if (id_getParameters == IntPtr.Zero)
					id_getParameters = JNIEnv.GetMethodID (class_ref, "getParameters", "()Ljava/security/AlgorithmParameters;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Security.AlgorithmParameters> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Security.AlgorithmParameters> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParameters", "()Ljava/security/AlgorithmParameters;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_decodeParams;
#pragma warning disable 0169
		static Delegate GetDecodeParamsHandler ()
		{
			if (cb_decodeParams == null)
				cb_decodeParams = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DecodeParams);
			return cb_decodeParams;
		}

		static void n_DecodeParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.AlgorithmId __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DecodeParams ();
		}
#pragma warning restore 0169

		static IntPtr id_decodeParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='decodeParams' and count(parameter)=0]"
		[Register ("decodeParams", "()V", "GetDecodeParamsHandler")]
		protected virtual unsafe void DecodeParams ()
		{
			if (id_decodeParams == IntPtr.Zero)
				id_decodeParams = JNIEnv.GetMethodID (class_ref, "decodeParams", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeParams);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeParams", "()V"));
			} finally {
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
			global::Sun.Security.X509.AlgorithmId __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.DerEncode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_derEncode_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='derEncode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
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

		static IntPtr id_encode;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='encode' and count(parameter)=0]"
		[Register ("encode", "()[B", "")]
		public unsafe byte[] Encode ()
		{
			if (id_encode == IntPtr.Zero)
				id_encode = JNIEnv.GetMethodID (class_ref, "encode", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
		[Register ("encode", "(Lsun/security/util/DerOutputStream;)V", "")]
		public unsafe void Encode (global::Sun.Security.Util.DerOutputStream @out)
		{
			if (id_encode_Lsun_security_util_DerOutputStream_ == IntPtr.Zero)
				id_encode_Lsun_security_util_DerOutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lsun/security/util/DerOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@out);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Lsun_security_util_DerOutputStream_, __args);
			} finally {
			}
		}

		static IntPtr id_equals_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Register ("equals", "(Lsun/security/util/ObjectIdentifier;)Z", "")]
		public unsafe bool Equals (global::Sun.Security.Util.ObjectIdentifier id)
		{
			if (id_equals_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
				id_equals_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetMethodID (class_ref, "equals", "(Lsun/security/util/ObjectIdentifier;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (id);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Lsun_security_util_ObjectIdentifier_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_equals_Lsun_security_x509_AlgorithmId_;
#pragma warning disable 0169
		static Delegate GetEquals_Lsun_security_x509_AlgorithmId_Handler ()
		{
			if (cb_equals_Lsun_security_x509_AlgorithmId_ == null)
				cb_equals_Lsun_security_x509_AlgorithmId_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Lsun_security_x509_AlgorithmId_);
			return cb_equals_Lsun_security_x509_AlgorithmId_;
		}

		static bool n_Equals_Lsun_security_x509_AlgorithmId_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Sun.Security.X509.AlgorithmId __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.AlgorithmId other = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Lsun_security_x509_AlgorithmId_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='sun.security.x509.AlgorithmId']]"
		[Register ("equals", "(Lsun/security/x509/AlgorithmId;)Z", "GetEquals_Lsun_security_x509_AlgorithmId_Handler")]
		public virtual unsafe bool Equals (global::Sun.Security.X509.AlgorithmId other)
		{
			if (id_equals_Lsun_security_x509_AlgorithmId_ == IntPtr.Zero)
				id_equals_Lsun_security_x509_AlgorithmId_ = JNIEnv.GetMethodID (class_ref, "equals", "(Lsun/security/x509/AlgorithmId;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Lsun_security_x509_AlgorithmId_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "equals", "(Lsun/security/x509/AlgorithmId;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lsun/security/x509/AlgorithmId;", "")]
		public static unsafe global::Sun.Security.X509.AlgorithmId Get (string algname)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)Lsun/security/x509/AlgorithmId;");
			IntPtr native_algname = JNIEnv.NewString (algname);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_algname);
				global::Sun.Security.X509.AlgorithmId __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_algname);
			}
		}

		static IntPtr id_get_Ljava_security_AlgorithmParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.security.AlgorithmParameters']]"
		[Register ("get", "(Ljava/security/AlgorithmParameters;)Lsun/security/x509/AlgorithmId;", "")]
		public static unsafe global::Sun.Security.X509.AlgorithmId Get (global::Java.Security.AlgorithmParameters algparams)
		{
			if (id_get_Ljava_security_AlgorithmParameters_ == IntPtr.Zero)
				id_get_Ljava_security_AlgorithmParameters_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/security/AlgorithmParameters;)Lsun/security/x509/AlgorithmId;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (algparams);
				global::Sun.Security.X509.AlgorithmId __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_security_AlgorithmParameters_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAlgorithmId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='getAlgorithmId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("getAlgorithmId", "(Ljava/lang/String;)Lsun/security/x509/AlgorithmId;", "")]
		public static unsafe global::Sun.Security.X509.AlgorithmId GetAlgorithmId (string algname)
		{
			if (id_getAlgorithmId_Ljava_lang_String_ == IntPtr.Zero)
				id_getAlgorithmId_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAlgorithmId", "(Ljava/lang/String;)Lsun/security/x509/AlgorithmId;");
			IntPtr native_algname = JNIEnv.NewString (algname);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_algname);
				global::Sun.Security.X509.AlgorithmId __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAlgorithmId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_algname);
			}
		}

		static Delegate cb_getEncodedParams;
#pragma warning disable 0169
		static Delegate GetGetEncodedParamsHandler ()
		{
			if (cb_getEncodedParams == null)
				cb_getEncodedParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncodedParams);
			return cb_getEncodedParams;
		}

		static IntPtr n_GetEncodedParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.AlgorithmId __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncodedParams ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncodedParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='getEncodedParams' and count(parameter)=0]"
		[Register ("getEncodedParams", "()[B", "GetGetEncodedParamsHandler")]
		public virtual unsafe byte[] GetEncodedParams ()
		{
			if (id_getEncodedParams == IntPtr.Zero)
				id_getEncodedParams = JNIEnv.GetMethodID (class_ref, "getEncodedParams", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncodedParams), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncodedParams", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_paramsToString;
#pragma warning disable 0169
		static Delegate GetParamsToStringHandler ()
		{
			if (cb_paramsToString == null)
				cb_paramsToString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ParamsToString);
			return cb_paramsToString;
		}

		static IntPtr n_ParamsToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.AlgorithmId __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ParamsToString ());
		}
#pragma warning restore 0169

		static IntPtr id_paramsToString;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AlgorithmId']/method[@name='paramsToString' and count(parameter)=0]"
		[Register ("paramsToString", "()Ljava/lang/String;", "GetParamsToStringHandler")]
		protected virtual unsafe string ParamsToString ()
		{
			if (id_paramsToString == IntPtr.Zero)
				id_paramsToString = JNIEnv.GetMethodID (class_ref, "paramsToString", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_paramsToString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "paramsToString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
