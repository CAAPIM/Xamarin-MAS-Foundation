using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Pkcs {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']"
	[global::Android.Runtime.Register ("sun/security/pkcs/PKCS9Attribute", DoNotGenerateAcw=true)]
	public partial class PKCS9Attribute : global::Java.Lang.Object, global::Sun.Security.Util.IDerEncoder {


		static IntPtr CHALLENGE_PASSWORD_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='CHALLENGE_PASSWORD_OID']"
		[Register ("CHALLENGE_PASSWORD_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier ChallengePasswordOid {
			get {
				if (CHALLENGE_PASSWORD_OID_jfieldId == IntPtr.Zero)
					CHALLENGE_PASSWORD_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHALLENGE_PASSWORD_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHALLENGE_PASSWORD_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='CHALLENGE_PASSWORD_STR']"
		[Register ("CHALLENGE_PASSWORD_STR")]
		public const string ChallengePasswordStr = (string) "ChallengePassword";

		static IntPtr CONTENT_TYPE_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='CONTENT_TYPE_OID']"
		[Register ("CONTENT_TYPE_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier ContentTypeOid {
			get {
				if (CONTENT_TYPE_OID_jfieldId == IntPtr.Zero)
					CONTENT_TYPE_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT_TYPE_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTENT_TYPE_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='CONTENT_TYPE_STR']"
		[Register ("CONTENT_TYPE_STR")]
		public const string ContentTypeStr = (string) "ContentType";

		static IntPtr COUNTERSIGNATURE_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='COUNTERSIGNATURE_OID']"
		[Register ("COUNTERSIGNATURE_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier CountersignatureOid {
			get {
				if (COUNTERSIGNATURE_OID_jfieldId == IntPtr.Zero)
					COUNTERSIGNATURE_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COUNTERSIGNATURE_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COUNTERSIGNATURE_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='COUNTERSIGNATURE_STR']"
		[Register ("COUNTERSIGNATURE_STR")]
		public const string CountersignatureStr = (string) "Countersignature";

		static IntPtr EMAIL_ADDRESS_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='EMAIL_ADDRESS_OID']"
		[Register ("EMAIL_ADDRESS_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier EmailAddressOid {
			get {
				if (EMAIL_ADDRESS_OID_jfieldId == IntPtr.Zero)
					EMAIL_ADDRESS_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMAIL_ADDRESS_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMAIL_ADDRESS_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='EMAIL_ADDRESS_STR']"
		[Register ("EMAIL_ADDRESS_STR")]
		public const string EmailAddressStr = (string) "EmailAddress";

		static IntPtr EXTENDED_CERTIFICATE_ATTRIBUTES_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='EXTENDED_CERTIFICATE_ATTRIBUTES_OID']"
		[Register ("EXTENDED_CERTIFICATE_ATTRIBUTES_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier ExtendedCertificateAttributesOid {
			get {
				if (EXTENDED_CERTIFICATE_ATTRIBUTES_OID_jfieldId == IntPtr.Zero)
					EXTENDED_CERTIFICATE_ATTRIBUTES_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTENDED_CERTIFICATE_ATTRIBUTES_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTENDED_CERTIFICATE_ATTRIBUTES_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='EXTENDED_CERTIFICATE_ATTRIBUTES_STR']"
		[Register ("EXTENDED_CERTIFICATE_ATTRIBUTES_STR")]
		public const string ExtendedCertificateAttributesStr = (string) "ExtendedCertificateAttributes";

		static IntPtr EXTENSION_REQUEST_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='EXTENSION_REQUEST_OID']"
		[Register ("EXTENSION_REQUEST_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier ExtensionRequestOid {
			get {
				if (EXTENSION_REQUEST_OID_jfieldId == IntPtr.Zero)
					EXTENSION_REQUEST_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTENSION_REQUEST_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTENSION_REQUEST_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='EXTENSION_REQUEST_STR']"
		[Register ("EXTENSION_REQUEST_STR")]
		public const string ExtensionRequestStr = (string) "ExtensionRequest";

		static IntPtr ISSUER_SERIALNUMBER_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='ISSUER_SERIALNUMBER_OID']"
		[Register ("ISSUER_SERIALNUMBER_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier IssuerSerialnumberOid {
			get {
				if (ISSUER_SERIALNUMBER_OID_jfieldId == IntPtr.Zero)
					ISSUER_SERIALNUMBER_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISSUER_SERIALNUMBER_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISSUER_SERIALNUMBER_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='ISSUER_SERIALNUMBER_STR']"
		[Register ("ISSUER_SERIALNUMBER_STR")]
		public const string IssuerSerialnumberStr = (string) "IssuerAndSerialNumber";

		static IntPtr MESSAGE_DIGEST_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='MESSAGE_DIGEST_OID']"
		[Register ("MESSAGE_DIGEST_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier MessageDigestOid {
			get {
				if (MESSAGE_DIGEST_OID_jfieldId == IntPtr.Zero)
					MESSAGE_DIGEST_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_DIGEST_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_DIGEST_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='MESSAGE_DIGEST_STR']"
		[Register ("MESSAGE_DIGEST_STR")]
		public const string MessageDigestStr = (string) "MessageDigest";

		static IntPtr SIGNATURE_TIMESTAMP_TOKEN_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='SIGNATURE_TIMESTAMP_TOKEN_OID']"
		[Register ("SIGNATURE_TIMESTAMP_TOKEN_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier SignatureTimestampTokenOid {
			get {
				if (SIGNATURE_TIMESTAMP_TOKEN_OID_jfieldId == IntPtr.Zero)
					SIGNATURE_TIMESTAMP_TOKEN_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGNATURE_TIMESTAMP_TOKEN_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIGNATURE_TIMESTAMP_TOKEN_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='SIGNATURE_TIMESTAMP_TOKEN_STR']"
		[Register ("SIGNATURE_TIMESTAMP_TOKEN_STR")]
		public const string SignatureTimestampTokenStr = (string) "SignatureTimestampToken";

		static IntPtr SIGNING_CERTIFICATE_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='SIGNING_CERTIFICATE_OID']"
		[Register ("SIGNING_CERTIFICATE_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier SigningCertificateOid {
			get {
				if (SIGNING_CERTIFICATE_OID_jfieldId == IntPtr.Zero)
					SIGNING_CERTIFICATE_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGNING_CERTIFICATE_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIGNING_CERTIFICATE_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='SIGNING_CERTIFICATE_STR']"
		[Register ("SIGNING_CERTIFICATE_STR")]
		public const string SigningCertificateStr = (string) "SigningCertificate";

		static IntPtr SIGNING_TIME_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='SIGNING_TIME_OID']"
		[Register ("SIGNING_TIME_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier SigningTimeOid {
			get {
				if (SIGNING_TIME_OID_jfieldId == IntPtr.Zero)
					SIGNING_TIME_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGNING_TIME_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIGNING_TIME_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='SIGNING_TIME_STR']"
		[Register ("SIGNING_TIME_STR")]
		public const string SigningTimeStr = (string) "SigningTime";

		static IntPtr SMIME_CAPABILITY_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='SMIME_CAPABILITY_OID']"
		[Register ("SMIME_CAPABILITY_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier SmimeCapabilityOid {
			get {
				if (SMIME_CAPABILITY_OID_jfieldId == IntPtr.Zero)
					SMIME_CAPABILITY_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SMIME_CAPABILITY_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SMIME_CAPABILITY_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='SMIME_CAPABILITY_STR']"
		[Register ("SMIME_CAPABILITY_STR")]
		public const string SmimeCapabilityStr = (string) "SMIMECapability";

		static IntPtr UNSTRUCTURED_ADDRESS_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='UNSTRUCTURED_ADDRESS_OID']"
		[Register ("UNSTRUCTURED_ADDRESS_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier UnstructuredAddressOid {
			get {
				if (UNSTRUCTURED_ADDRESS_OID_jfieldId == IntPtr.Zero)
					UNSTRUCTURED_ADDRESS_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSTRUCTURED_ADDRESS_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSTRUCTURED_ADDRESS_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='UNSTRUCTURED_ADDRESS_STR']"
		[Register ("UNSTRUCTURED_ADDRESS_STR")]
		public const string UnstructuredAddressStr = (string) "UnstructuredAddress";

		static IntPtr UNSTRUCTURED_NAME_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='UNSTRUCTURED_NAME_OID']"
		[Register ("UNSTRUCTURED_NAME_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier UnstructuredNameOid {
			get {
				if (UNSTRUCTURED_NAME_OID_jfieldId == IntPtr.Zero)
					UNSTRUCTURED_NAME_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSTRUCTURED_NAME_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSTRUCTURED_NAME_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/field[@name='UNSTRUCTURED_NAME_STR']"
		[Register ("UNSTRUCTURED_NAME_STR")]
		public const string UnstructuredNameStr = (string) "UnstructuredName";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/pkcs/PKCS9Attribute", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKCS9Attribute); }
		}

		protected PKCS9Attribute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/constructor[@name='PKCS9Attribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe PKCS9Attribute (string name, global::Java.Lang.Object value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (value);
				if (((object) this).GetType () != typeof (PKCS9Attribute)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/constructor[@name='PKCS9Attribute' and count(parameter)=2 and parameter[1][@type='sun.security.util.ObjectIdentifier'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Lsun/security/util/ObjectIdentifier;Ljava/lang/Object;)V", "")]
		public unsafe PKCS9Attribute (global::Sun.Security.Util.ObjectIdentifier oid, global::Java.Lang.Object value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (oid);
				__args [1] = new JValue (value);
				if (((object) this).GetType () != typeof (PKCS9Attribute)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/ObjectIdentifier;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/ObjectIdentifier;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/ObjectIdentifier;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static Delegate cb_isSingleValued;
#pragma warning disable 0169
		static Delegate GetIsSingleValuedHandler ()
		{
			if (cb_isSingleValued == null)
				cb_isSingleValued = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSingleValued);
			return cb_isSingleValued;
		}

		static bool n_IsSingleValued (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.PKCS9Attribute __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSingleValued;
		}
#pragma warning restore 0169

		static IntPtr id_isSingleValued;
		public virtual unsafe bool IsSingleValued {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/method[@name='isSingleValued' and count(parameter)=0]"
			[Register ("isSingleValued", "()Z", "GetIsSingleValuedHandler")]
			get {
				if (id_isSingleValued == IntPtr.Zero)
					id_isSingleValued = JNIEnv.GetMethodID (class_ref, "isSingleValued", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSingleValued);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSingleValued", "()Z"));
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
			global::Sun.Security.Pkcs.PKCS9Attribute __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_getOID;
#pragma warning disable 0169
		static Delegate GetGetOIDHandler ()
		{
			if (cb_getOID == null)
				cb_getOID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOID);
			return cb_getOID;
		}

		static IntPtr n_GetOID (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.PKCS9Attribute __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OID);
		}
#pragma warning restore 0169

		static IntPtr id_getOID;
		public virtual unsafe global::Sun.Security.Util.ObjectIdentifier OID {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/method[@name='getOID' and count(parameter)=0]"
			[Register ("getOID", "()Lsun/security/util/ObjectIdentifier;", "GetGetOIDHandler")]
			get {
				if (id_getOID == IntPtr.Zero)
					id_getOID = JNIEnv.GetMethodID (class_ref, "getOID", "()Lsun/security/util/ObjectIdentifier;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOID", "()Lsun/security/util/ObjectIdentifier;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.PKCS9Attribute __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value);
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.Pkcs.PKCS9Attribute __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.DerEncode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_derEncode_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/method[@name='derEncode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
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

		static IntPtr id_getName_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Register ("getName", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/String;", "")]
		public static unsafe string GetName (global::Sun.Security.Util.ObjectIdentifier oid)
		{
			if (id_getName_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
				id_getName_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetStaticMethodID (class_ref, "getName", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (oid);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getName_Lsun_security_util_ObjectIdentifier_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getOID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attribute']/method[@name='getOID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOID", "(Ljava/lang/String;)Lsun/security/util/ObjectIdentifier;", "")]
		public static unsafe global::Sun.Security.Util.ObjectIdentifier GetOID (string name)
		{
			if (id_getOID_Ljava_lang_String_ == IntPtr.Zero)
				id_getOID_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getOID", "(Ljava/lang/String;)Lsun/security/util/ObjectIdentifier;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Sun.Security.Util.ObjectIdentifier __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOID_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
