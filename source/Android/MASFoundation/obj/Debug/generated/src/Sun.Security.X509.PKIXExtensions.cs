using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']"
	[global::Android.Runtime.Register ("sun/security/x509/PKIXExtensions", DoNotGenerateAcw=true)]
	public partial class PKIXExtensions : global::Java.Lang.Object {


		static IntPtr AuthInfoAccess_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='AuthInfoAccess_Id']"
		[Register ("AuthInfoAccess_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier AuthInfoAccessId {
			get {
				if (AuthInfoAccess_Id_jfieldId == IntPtr.Zero)
					AuthInfoAccess_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AuthInfoAccess_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AuthInfoAccess_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AuthorityKey_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='AuthorityKey_Id']"
		[Register ("AuthorityKey_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier AuthorityKeyId {
			get {
				if (AuthorityKey_Id_jfieldId == IntPtr.Zero)
					AuthorityKey_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AuthorityKey_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AuthorityKey_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BasicConstraints_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='BasicConstraints_Id']"
		[Register ("BasicConstraints_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier BasicConstraintsId {
			get {
				if (BasicConstraints_Id_jfieldId == IntPtr.Zero)
					BasicConstraints_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BasicConstraints_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BasicConstraints_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CRLDistributionPoints_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='CRLDistributionPoints_Id']"
		[Register ("CRLDistributionPoints_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier CRLDistributionPointsId {
			get {
				if (CRLDistributionPoints_Id_jfieldId == IntPtr.Zero)
					CRLDistributionPoints_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CRLDistributionPoints_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CRLDistributionPoints_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CRLNumber_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='CRLNumber_Id']"
		[Register ("CRLNumber_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier CRLNumberId {
			get {
				if (CRLNumber_Id_jfieldId == IntPtr.Zero)
					CRLNumber_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CRLNumber_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CRLNumber_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CertificateIssuer_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='CertificateIssuer_Id']"
		[Register ("CertificateIssuer_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier CertificateIssuerId {
			get {
				if (CertificateIssuer_Id_jfieldId == IntPtr.Zero)
					CertificateIssuer_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CertificateIssuer_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CertificateIssuer_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CertificatePolicies_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='CertificatePolicies_Id']"
		[Register ("CertificatePolicies_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier CertificatePoliciesId {
			get {
				if (CertificatePolicies_Id_jfieldId == IntPtr.Zero)
					CertificatePolicies_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CertificatePolicies_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CertificatePolicies_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DeltaCRLIndicator_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='DeltaCRLIndicator_Id']"
		[Register ("DeltaCRLIndicator_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier DeltaCRLIndicatorId {
			get {
				if (DeltaCRLIndicator_Id_jfieldId == IntPtr.Zero)
					DeltaCRLIndicator_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DeltaCRLIndicator_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DeltaCRLIndicator_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ExtendedKeyUsage_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='ExtendedKeyUsage_Id']"
		[Register ("ExtendedKeyUsage_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier ExtendedKeyUsageId {
			get {
				if (ExtendedKeyUsage_Id_jfieldId == IntPtr.Zero)
					ExtendedKeyUsage_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ExtendedKeyUsage_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ExtendedKeyUsage_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FreshestCRL_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='FreshestCRL_Id']"
		[Register ("FreshestCRL_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier FreshestCRLId {
			get {
				if (FreshestCRL_Id_jfieldId == IntPtr.Zero)
					FreshestCRL_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FreshestCRL_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FreshestCRL_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HoldInstructionCode_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='HoldInstructionCode_Id']"
		[Register ("HoldInstructionCode_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier HoldInstructionCodeId {
			get {
				if (HoldInstructionCode_Id_jfieldId == IntPtr.Zero)
					HoldInstructionCode_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HoldInstructionCode_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HoldInstructionCode_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr InhibitAnyPolicy_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='InhibitAnyPolicy_Id']"
		[Register ("InhibitAnyPolicy_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier InhibitAnyPolicyId {
			get {
				if (InhibitAnyPolicy_Id_jfieldId == IntPtr.Zero)
					InhibitAnyPolicy_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InhibitAnyPolicy_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InhibitAnyPolicy_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr InvalidityDate_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='InvalidityDate_Id']"
		[Register ("InvalidityDate_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier InvalidityDateId {
			get {
				if (InvalidityDate_Id_jfieldId == IntPtr.Zero)
					InvalidityDate_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InvalidityDate_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InvalidityDate_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IssuerAlternativeName_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='IssuerAlternativeName_Id']"
		[Register ("IssuerAlternativeName_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier IssuerAlternativeNameId {
			get {
				if (IssuerAlternativeName_Id_jfieldId == IntPtr.Zero)
					IssuerAlternativeName_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IssuerAlternativeName_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IssuerAlternativeName_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IssuingDistributionPoint_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='IssuingDistributionPoint_Id']"
		[Register ("IssuingDistributionPoint_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier IssuingDistributionPointId {
			get {
				if (IssuingDistributionPoint_Id_jfieldId == IntPtr.Zero)
					IssuingDistributionPoint_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IssuingDistributionPoint_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IssuingDistributionPoint_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr KeyUsage_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='KeyUsage_Id']"
		[Register ("KeyUsage_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier KeyUsageId {
			get {
				if (KeyUsage_Id_jfieldId == IntPtr.Zero)
					KeyUsage_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KeyUsage_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KeyUsage_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NameConstraints_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='NameConstraints_Id']"
		[Register ("NameConstraints_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier NameConstraintsId {
			get {
				if (NameConstraints_Id_jfieldId == IntPtr.Zero)
					NameConstraints_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NameConstraints_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NameConstraints_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PolicyConstraints_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='PolicyConstraints_Id']"
		[Register ("PolicyConstraints_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier PolicyConstraintsId {
			get {
				if (PolicyConstraints_Id_jfieldId == IntPtr.Zero)
					PolicyConstraints_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PolicyConstraints_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PolicyConstraints_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PolicyMappings_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='PolicyMappings_Id']"
		[Register ("PolicyMappings_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier PolicyMappingsId {
			get {
				if (PolicyMappings_Id_jfieldId == IntPtr.Zero)
					PolicyMappings_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PolicyMappings_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PolicyMappings_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PrivateKeyUsage_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='PrivateKeyUsage_Id']"
		[Register ("PrivateKeyUsage_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier PrivateKeyUsageId {
			get {
				if (PrivateKeyUsage_Id_jfieldId == IntPtr.Zero)
					PrivateKeyUsage_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PrivateKeyUsage_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PrivateKeyUsage_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ReasonCode_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='ReasonCode_Id']"
		[Register ("ReasonCode_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier ReasonCodeId {
			get {
				if (ReasonCode_Id_jfieldId == IntPtr.Zero)
					ReasonCode_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ReasonCode_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ReasonCode_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SubjectAlternativeName_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='SubjectAlternativeName_Id']"
		[Register ("SubjectAlternativeName_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier SubjectAlternativeNameId {
			get {
				if (SubjectAlternativeName_Id_jfieldId == IntPtr.Zero)
					SubjectAlternativeName_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SubjectAlternativeName_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SubjectAlternativeName_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SubjectDirectoryAttributes_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='SubjectDirectoryAttributes_Id']"
		[Register ("SubjectDirectoryAttributes_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier SubjectDirectoryAttributesId {
			get {
				if (SubjectDirectoryAttributes_Id_jfieldId == IntPtr.Zero)
					SubjectDirectoryAttributes_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SubjectDirectoryAttributes_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SubjectDirectoryAttributes_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SubjectInfoAccess_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='SubjectInfoAccess_Id']"
		[Register ("SubjectInfoAccess_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier SubjectInfoAccessId {
			get {
				if (SubjectInfoAccess_Id_jfieldId == IntPtr.Zero)
					SubjectInfoAccess_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SubjectInfoAccess_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SubjectInfoAccess_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SubjectKey_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/field[@name='SubjectKey_Id']"
		[Register ("SubjectKey_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier SubjectKeyId {
			get {
				if (SubjectKey_Id_jfieldId == IntPtr.Zero)
					SubjectKey_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SubjectKey_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SubjectKey_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/PKIXExtensions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKIXExtensions); }
		}

		protected PKIXExtensions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='PKIXExtensions']/constructor[@name='PKIXExtensions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PKIXExtensions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PKIXExtensions)) {
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

	}
}
