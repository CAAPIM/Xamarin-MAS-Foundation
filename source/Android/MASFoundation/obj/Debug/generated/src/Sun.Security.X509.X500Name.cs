using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']"
	[global::Android.Runtime.Register ("sun/security/x509/X500Name", DoNotGenerateAcw=true)]
	public partial class X500Name : global::Java.Lang.Object, global::Java.Security.IPrincipal, global::Sun.Security.X509.IGeneralNameInterface {


		static IntPtr DNQUALIFIER_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='DNQUALIFIER_OID']"
		[Register ("DNQUALIFIER_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier DnqualifierOid {
			get {
				if (DNQUALIFIER_OID_jfieldId == IntPtr.Zero)
					DNQUALIFIER_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DNQUALIFIER_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DNQUALIFIER_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DOMAIN_COMPONENT_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='DOMAIN_COMPONENT_OID']"
		[Register ("DOMAIN_COMPONENT_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier DomainComponentOid {
			get {
				if (DOMAIN_COMPONENT_OID_jfieldId == IntPtr.Zero)
					DOMAIN_COMPONENT_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOMAIN_COMPONENT_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOMAIN_COMPONENT_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GENERATIONQUALIFIER_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='GENERATIONQUALIFIER_OID']"
		[Register ("GENERATIONQUALIFIER_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier GenerationqualifierOid {
			get {
				if (GENERATIONQUALIFIER_OID_jfieldId == IntPtr.Zero)
					GENERATIONQUALIFIER_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERATIONQUALIFIER_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GENERATIONQUALIFIER_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GIVENNAME_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='GIVENNAME_OID']"
		[Register ("GIVENNAME_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier GivennameOid {
			get {
				if (GIVENNAME_OID_jfieldId == IntPtr.Zero)
					GIVENNAME_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GIVENNAME_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GIVENNAME_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INITIALS_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='INITIALS_OID']"
		[Register ("INITIALS_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier InitialsOid {
			get {
				if (INITIALS_OID_jfieldId == IntPtr.Zero)
					INITIALS_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALS_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIALS_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SERIALNUMBER_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='SERIALNUMBER_OID']"
		[Register ("SERIALNUMBER_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier SerialnumberOid {
			get {
				if (SERIALNUMBER_OID_jfieldId == IntPtr.Zero)
					SERIALNUMBER_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERIALNUMBER_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERIALNUMBER_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SURNAME_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='SURNAME_OID']"
		[Register ("SURNAME_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier SurnameOid {
			get {
				if (SURNAME_OID_jfieldId == IntPtr.Zero)
					SURNAME_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SURNAME_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SURNAME_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr commonName_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='commonName_oid']"
		[Register ("commonName_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier CommonNameOid {
			get {
				if (commonName_oid_jfieldId == IntPtr.Zero)
					commonName_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "commonName_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, commonName_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr countryName_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='countryName_oid']"
		[Register ("countryName_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier CountryNameOid {
			get {
				if (countryName_oid_jfieldId == IntPtr.Zero)
					countryName_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "countryName_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, countryName_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ipAddress_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='ipAddress_oid']"
		[Register ("ipAddress_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier IpAddressOid {
			get {
				if (ipAddress_oid_jfieldId == IntPtr.Zero)
					ipAddress_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ipAddress_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ipAddress_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr localityName_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='localityName_oid']"
		[Register ("localityName_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier LocalityNameOid {
			get {
				if (localityName_oid_jfieldId == IntPtr.Zero)
					localityName_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "localityName_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, localityName_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr orgName_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='orgName_oid']"
		[Register ("orgName_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier OrgNameOid {
			get {
				if (orgName_oid_jfieldId == IntPtr.Zero)
					orgName_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "orgName_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, orgName_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr orgUnitName_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='orgUnitName_oid']"
		[Register ("orgUnitName_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier OrgUnitNameOid {
			get {
				if (orgUnitName_oid_jfieldId == IntPtr.Zero)
					orgUnitName_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "orgUnitName_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, orgUnitName_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr stateName_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='stateName_oid']"
		[Register ("stateName_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier StateNameOid {
			get {
				if (stateName_oid_jfieldId == IntPtr.Zero)
					stateName_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "stateName_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, stateName_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr streetAddress_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='streetAddress_oid']"
		[Register ("streetAddress_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier StreetAddressOid {
			get {
				if (streetAddress_oid_jfieldId == IntPtr.Zero)
					streetAddress_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "streetAddress_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, streetAddress_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr title_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='title_oid']"
		[Register ("title_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier TitleOid {
			get {
				if (title_oid_jfieldId == IntPtr.Zero)
					title_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "title_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, title_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr userid_oid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/field[@name='userid_oid']"
		[Register ("userid_oid")]
		public static global::Sun.Security.Util.ObjectIdentifier UseridOid {
			get {
				if (userid_oid_jfieldId == IntPtr.Zero)
					userid_oid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "userid_oid", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, userid_oid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: sun.security.x509.GeneralNameInterface

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_ANY']"
			[Register ("NAME_ANY")]
			public const int NameAny = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_DIFF_TYPE']"
			[Register ("NAME_DIFF_TYPE")]
			public const int NameDiffType = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_DIRECTORY']"
			[Register ("NAME_DIRECTORY")]
			public const int NameDirectory = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_DNS']"
			[Register ("NAME_DNS")]
			public const int NameDns = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_EDI']"
			[Register ("NAME_EDI")]
			public const int NameEdi = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_IP']"
			[Register ("NAME_IP")]
			public const int NameIp = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_MATCH']"
			[Register ("NAME_MATCH")]
			public const int NameMatch = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_NARROWS']"
			[Register ("NAME_NARROWS")]
			public const int NameNarrows = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_OID']"
			[Register ("NAME_OID")]
			public const int NameOid = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_RFC822']"
			[Register ("NAME_RFC822")]
			public const int NameRfc822 = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_SAME_TYPE']"
			[Register ("NAME_SAME_TYPE")]
			public const int NameSameType = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_URI']"
			[Register ("NAME_URI")]
			public const int NameUri = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_WIDENS']"
			[Register ("NAME_WIDENS")]
			public const int NameWidens = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/field[@name='NAME_X400']"
			[Register ("NAME_X400")]
			public const int NameX400 = (int) 3;
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/X500Name", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (X500Name); }
		}

		protected X500Name (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/constructor[@name='X500Name' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe X500Name (byte[] name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewArray (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				if (((object) this).GetType () != typeof (X500Name)) {
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
				if (name != null) {
					JNIEnv.CopyArray (native_name, name);
					JNIEnv.DeleteLocalRef (native_name);
				}
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/constructor[@name='X500Name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe X500Name (string dname)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dname = JNIEnv.NewString (dname);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_dname);
				if (((object) this).GetType () != typeof (X500Name)) {
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
				JNIEnv.DeleteLocalRef (native_dname);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/constructor[@name='X500Name' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe X500Name (string dname, string format)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dname = JNIEnv.NewString (dname);
			IntPtr native_format = JNIEnv.NewString (format);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_dname);
				__args [1] = new JValue (native_format);
				if (((object) this).GetType () != typeof (X500Name)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dname);
				JNIEnv.DeleteLocalRef (native_format);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/constructor[@name='X500Name' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe X500Name (string commonName, string organizationUnit, string organizationName, string country)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_commonName = JNIEnv.NewString (commonName);
			IntPtr native_organizationUnit = JNIEnv.NewString (organizationUnit);
			IntPtr native_organizationName = JNIEnv.NewString (organizationName);
			IntPtr native_country = JNIEnv.NewString (country);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_commonName);
				__args [1] = new JValue (native_organizationUnit);
				__args [2] = new JValue (native_organizationName);
				__args [3] = new JValue (native_country);
				if (((object) this).GetType () != typeof (X500Name)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_commonName);
				JNIEnv.DeleteLocalRef (native_organizationUnit);
				JNIEnv.DeleteLocalRef (native_organizationName);
				JNIEnv.DeleteLocalRef (native_country);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/constructor[@name='X500Name' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public unsafe X500Name (string commonName, string organizationUnit, string domainComponent, string organization, bool containsDC)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_commonName = JNIEnv.NewString (commonName);
			IntPtr native_organizationUnit = JNIEnv.NewString (organizationUnit);
			IntPtr native_domainComponent = JNIEnv.NewString (domainComponent);
			IntPtr native_organization = JNIEnv.NewString (organization);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_commonName);
				__args [1] = new JValue (native_organizationUnit);
				__args [2] = new JValue (native_domainComponent);
				__args [3] = new JValue (native_organization);
				__args [4] = new JValue (containsDC);
				if (((object) this).GetType () != typeof (X500Name)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_commonName);
				JNIEnv.DeleteLocalRef (native_organizationUnit);
				JNIEnv.DeleteLocalRef (native_domainComponent);
				JNIEnv.DeleteLocalRef (native_organization);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/constructor[@name='X500Name' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe X500Name (string commonName, string organizationUnit, string organizationName, string localityName, string stateName, string country)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_commonName = JNIEnv.NewString (commonName);
			IntPtr native_organizationUnit = JNIEnv.NewString (organizationUnit);
			IntPtr native_organizationName = JNIEnv.NewString (organizationName);
			IntPtr native_localityName = JNIEnv.NewString (localityName);
			IntPtr native_stateName = JNIEnv.NewString (stateName);
			IntPtr native_country = JNIEnv.NewString (country);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_commonName);
				__args [1] = new JValue (native_organizationUnit);
				__args [2] = new JValue (native_organizationName);
				__args [3] = new JValue (native_localityName);
				__args [4] = new JValue (native_stateName);
				__args [5] = new JValue (native_country);
				if (((object) this).GetType () != typeof (X500Name)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_commonName);
				JNIEnv.DeleteLocalRef (native_organizationUnit);
				JNIEnv.DeleteLocalRef (native_organizationName);
				JNIEnv.DeleteLocalRef (native_localityName);
				JNIEnv.DeleteLocalRef (native_stateName);
				JNIEnv.DeleteLocalRef (native_country);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/constructor[@name='X500Name' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe X500Name (string dname, global::System.Collections.Generic.IDictionary<string, string> keywordMap)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dname = JNIEnv.NewString (dname);
			IntPtr native_keywordMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (keywordMap);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_dname);
				__args [1] = new JValue (native_keywordMap);
				if (((object) this).GetType () != typeof (X500Name)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dname);
				JNIEnv.DeleteLocalRef (native_keywordMap);
			}
		}

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/constructor[@name='X500Name' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerInputStream']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;)V", "")]
		public unsafe X500Name (global::Sun.Security.Util.DerInputStream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (X500Name)) {
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

		static IntPtr id_ctor_arrayLsun_security_x509_RDN_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/constructor[@name='X500Name' and count(parameter)=1 and parameter[1][@type='sun.security.x509.RDN[]']]"
		[Register (".ctor", "([Lsun/security/x509/RDN;)V", "")]
		public unsafe X500Name (global::Sun.Security.X509.RDN[] rdnArray)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rdnArray = JNIEnv.NewArray (rdnArray);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_rdnArray);
				if (((object) this).GetType () != typeof (X500Name)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lsun/security/x509/RDN;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lsun/security/x509/RDN;)V", __args);
					return;
				}

				if (id_ctor_arrayLsun_security_x509_RDN_ == IntPtr.Zero)
					id_ctor_arrayLsun_security_x509_RDN_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lsun/security/x509/RDN;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLsun_security_x509_RDN_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLsun_security_x509_RDN_, __args);
			} finally {
				if (rdnArray != null) {
					JNIEnv.CopyArray (native_rdnArray, rdnArray);
					JNIEnv.DeleteLocalRef (native_rdnArray);
				}
			}
		}

		static Delegate cb_getCommonName;
#pragma warning disable 0169
		static Delegate GetGetCommonNameHandler ()
		{
			if (cb_getCommonName == null)
				cb_getCommonName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCommonName);
			return cb_getCommonName;
		}

		static IntPtr n_GetCommonName (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CommonName);
		}
#pragma warning restore 0169

		static IntPtr id_getCommonName;
		public virtual unsafe string CommonName {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getCommonName' and count(parameter)=0]"
			[Register ("getCommonName", "()Ljava/lang/String;", "GetGetCommonNameHandler")]
			get {
				if (id_getCommonName == IntPtr.Zero)
					id_getCommonName = JNIEnv.GetMethodID (class_ref, "getCommonName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCommonName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommonName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCountry;
#pragma warning disable 0169
		static Delegate GetGetCountryHandler ()
		{
			if (cb_getCountry == null)
				cb_getCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountry);
			return cb_getCountry;
		}

		static IntPtr n_GetCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Country);
		}
#pragma warning restore 0169

		static IntPtr id_getCountry;
		public virtual unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				if (id_getCountry == IntPtr.Zero)
					id_getCountry = JNIEnv.GetMethodID (class_ref, "getCountry", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCountry), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCountry", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDNQualifier;
#pragma warning disable 0169
		static Delegate GetGetDNQualifierHandler ()
		{
			if (cb_getDNQualifier == null)
				cb_getDNQualifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDNQualifier);
			return cb_getDNQualifier;
		}

		static IntPtr n_GetDNQualifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DNQualifier);
		}
#pragma warning restore 0169

		static IntPtr id_getDNQualifier;
		public virtual unsafe string DNQualifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getDNQualifier' and count(parameter)=0]"
			[Register ("getDNQualifier", "()Ljava/lang/String;", "GetGetDNQualifierHandler")]
			get {
				if (id_getDNQualifier == IntPtr.Zero)
					id_getDNQualifier = JNIEnv.GetMethodID (class_ref, "getDNQualifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDNQualifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDNQualifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDomain;
#pragma warning disable 0169
		static Delegate GetGetDomainHandler ()
		{
			if (cb_getDomain == null)
				cb_getDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDomain);
			return cb_getDomain;
		}

		static IntPtr n_GetDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Domain);
		}
#pragma warning restore 0169

		static IntPtr id_getDomain;
		public virtual unsafe string Domain {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getDomain' and count(parameter)=0]"
			[Register ("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler")]
			get {
				if (id_getDomain == IntPtr.Zero)
					id_getDomain = JNIEnv.GetMethodID (class_ref, "getDomain", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDomain), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDomain", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGeneration;
#pragma warning disable 0169
		static Delegate GetGetGenerationHandler ()
		{
			if (cb_getGeneration == null)
				cb_getGeneration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeneration);
			return cb_getGeneration;
		}

		static IntPtr n_GetGeneration (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Generation);
		}
#pragma warning restore 0169

		static IntPtr id_getGeneration;
		public virtual unsafe string Generation {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getGeneration' and count(parameter)=0]"
			[Register ("getGeneration", "()Ljava/lang/String;", "GetGetGenerationHandler")]
			get {
				if (id_getGeneration == IntPtr.Zero)
					id_getGeneration = JNIEnv.GetMethodID (class_ref, "getGeneration", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGeneration), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeneration", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGivenName;
#pragma warning disable 0169
		static Delegate GetGetGivenNameHandler ()
		{
			if (cb_getGivenName == null)
				cb_getGivenName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGivenName);
			return cb_getGivenName;
		}

		static IntPtr n_GetGivenName (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GivenName);
		}
#pragma warning restore 0169

		static IntPtr id_getGivenName;
		public virtual unsafe string GivenName {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getGivenName' and count(parameter)=0]"
			[Register ("getGivenName", "()Ljava/lang/String;", "GetGetGivenNameHandler")]
			get {
				if (id_getGivenName == IntPtr.Zero)
					id_getGivenName = JNIEnv.GetMethodID (class_ref, "getGivenName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGivenName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGivenName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIP;
#pragma warning disable 0169
		static Delegate GetGetIPHandler ()
		{
			if (cb_getIP == null)
				cb_getIP = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIP);
			return cb_getIP;
		}

		static IntPtr n_GetIP (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IP);
		}
#pragma warning restore 0169

		static IntPtr id_getIP;
		public virtual unsafe string IP {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getIP' and count(parameter)=0]"
			[Register ("getIP", "()Ljava/lang/String;", "GetGetIPHandler")]
			get {
				if (id_getIP == IntPtr.Zero)
					id_getIP = JNIEnv.GetMethodID (class_ref, "getIP", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIP), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIP", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInitials;
#pragma warning disable 0169
		static Delegate GetGetInitialsHandler ()
		{
			if (cb_getInitials == null)
				cb_getInitials = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitials);
			return cb_getInitials;
		}

		static IntPtr n_GetInitials (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Initials);
		}
#pragma warning restore 0169

		static IntPtr id_getInitials;
		public virtual unsafe string Initials {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getInitials' and count(parameter)=0]"
			[Register ("getInitials", "()Ljava/lang/String;", "GetGetInitialsHandler")]
			get {
				if (id_getInitials == IntPtr.Zero)
					id_getInitials = JNIEnv.GetMethodID (class_ref, "getInitials", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInitials), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitials", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLocality;
#pragma warning disable 0169
		static Delegate GetGetLocalityHandler ()
		{
			if (cb_getLocality == null)
				cb_getLocality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocality);
			return cb_getLocality;
		}

		static IntPtr n_GetLocality (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Locality);
		}
#pragma warning restore 0169

		static IntPtr id_getLocality;
		public virtual unsafe string Locality {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getLocality' and count(parameter)=0]"
			[Register ("getLocality", "()Ljava/lang/String;", "GetGetLocalityHandler")]
			get {
				if (id_getLocality == IntPtr.Zero)
					id_getLocality = JNIEnv.GetMethodID (class_ref, "getLocality", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocality), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocality", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_getOrganization;
#pragma warning disable 0169
		static Delegate GetGetOrganizationHandler ()
		{
			if (cb_getOrganization == null)
				cb_getOrganization = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrganization);
			return cb_getOrganization;
		}

		static IntPtr n_GetOrganization (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Organization);
		}
#pragma warning restore 0169

		static IntPtr id_getOrganization;
		public virtual unsafe string Organization {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getOrganization' and count(parameter)=0]"
			[Register ("getOrganization", "()Ljava/lang/String;", "GetGetOrganizationHandler")]
			get {
				if (id_getOrganization == IntPtr.Zero)
					id_getOrganization = JNIEnv.GetMethodID (class_ref, "getOrganization", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrganization), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrganization", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrganizationalUnit;
#pragma warning disable 0169
		static Delegate GetGetOrganizationalUnitHandler ()
		{
			if (cb_getOrganizationalUnit == null)
				cb_getOrganizationalUnit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrganizationalUnit);
			return cb_getOrganizationalUnit;
		}

		static IntPtr n_GetOrganizationalUnit (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OrganizationalUnit);
		}
#pragma warning restore 0169

		static IntPtr id_getOrganizationalUnit;
		public virtual unsafe string OrganizationalUnit {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getOrganizationalUnit' and count(parameter)=0]"
			[Register ("getOrganizationalUnit", "()Ljava/lang/String;", "GetGetOrganizationalUnitHandler")]
			get {
				if (id_getOrganizationalUnit == IntPtr.Zero)
					id_getOrganizationalUnit = JNIEnv.GetMethodID (class_ref, "getOrganizationalUnit", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrganizationalUnit), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrganizationalUnit", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRFC1779Name;
#pragma warning disable 0169
		static Delegate GetGetRFC1779NameHandler ()
		{
			if (cb_getRFC1779Name == null)
				cb_getRFC1779Name = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRFC1779Name);
			return cb_getRFC1779Name;
		}

		static IntPtr n_GetRFC1779Name (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RFC1779Name);
		}
#pragma warning restore 0169

		static IntPtr id_getRFC1779Name;
		public virtual unsafe string RFC1779Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getRFC1779Name' and count(parameter)=0]"
			[Register ("getRFC1779Name", "()Ljava/lang/String;", "GetGetRFC1779NameHandler")]
			get {
				if (id_getRFC1779Name == IntPtr.Zero)
					id_getRFC1779Name = JNIEnv.GetMethodID (class_ref, "getRFC1779Name", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRFC1779Name), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRFC1779Name", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRFC2253CanonicalName;
#pragma warning disable 0169
		static Delegate GetGetRFC2253CanonicalNameHandler ()
		{
			if (cb_getRFC2253CanonicalName == null)
				cb_getRFC2253CanonicalName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRFC2253CanonicalName);
			return cb_getRFC2253CanonicalName;
		}

		static IntPtr n_GetRFC2253CanonicalName (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RFC2253CanonicalName);
		}
#pragma warning restore 0169

		static IntPtr id_getRFC2253CanonicalName;
		public virtual unsafe string RFC2253CanonicalName {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getRFC2253CanonicalName' and count(parameter)=0]"
			[Register ("getRFC2253CanonicalName", "()Ljava/lang/String;", "GetGetRFC2253CanonicalNameHandler")]
			get {
				if (id_getRFC2253CanonicalName == IntPtr.Zero)
					id_getRFC2253CanonicalName = JNIEnv.GetMethodID (class_ref, "getRFC2253CanonicalName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRFC2253CanonicalName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRFC2253CanonicalName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRFC2253Name;
#pragma warning disable 0169
		static Delegate GetGetRFC2253NameHandler ()
		{
			if (cb_getRFC2253Name == null)
				cb_getRFC2253Name = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRFC2253Name);
			return cb_getRFC2253Name;
		}

		static IntPtr n_GetRFC2253Name (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RFC2253Name);
		}
#pragma warning restore 0169

		static IntPtr id_getRFC2253Name;
		public virtual unsafe string RFC2253Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getRFC2253Name' and count(parameter)=0]"
			[Register ("getRFC2253Name", "()Ljava/lang/String;", "GetGetRFC2253NameHandler")]
			get {
				if (id_getRFC2253Name == IntPtr.Zero)
					id_getRFC2253Name = JNIEnv.GetMethodID (class_ref, "getRFC2253Name", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRFC2253Name), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRFC2253Name", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual unsafe string State {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Ljava/lang/String;", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSurname;
#pragma warning disable 0169
		static Delegate GetGetSurnameHandler ()
		{
			if (cb_getSurname == null)
				cb_getSurname = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSurname);
			return cb_getSurname;
		}

		static IntPtr n_GetSurname (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Surname);
		}
#pragma warning restore 0169

		static IntPtr id_getSurname;
		public virtual unsafe string Surname {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getSurname' and count(parameter)=0]"
			[Register ("getSurname", "()Ljava/lang/String;", "GetGetSurnameHandler")]
			get {
				if (id_getSurname == IntPtr.Zero)
					id_getSurname = JNIEnv.GetMethodID (class_ref, "getSurname", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurname), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSurname", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_allAvas;
#pragma warning disable 0169
		static Delegate GetAllAvasHandler ()
		{
			if (cb_allAvas == null)
				cb_allAvas = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AllAvas);
			return cb_allAvas;
		}

		static IntPtr n_AllAvas (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Sun.Security.X509.AVA>.ToLocalJniHandle (__this.AllAvas ());
		}
#pragma warning restore 0169

		static IntPtr id_allAvas;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='allAvas' and count(parameter)=0]"
		[Register ("allAvas", "()Ljava/util/List;", "GetAllAvasHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Sun.Security.X509.AVA> AllAvas ()
		{
			if (id_allAvas == IntPtr.Zero)
				id_allAvas = JNIEnv.GetMethodID (class_ref, "allAvas", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Sun.Security.X509.AVA>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_allAvas), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Sun.Security.X509.AVA>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "allAvas", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asX500Name_Ljavax_security_auth_x500_X500Principal_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='asX500Name' and count(parameter)=1 and parameter[1][@type='javax.security.auth.x500.X500Principal']]"
		[Register ("asX500Name", "(Ljavax/security/auth/x500/X500Principal;)Lsun/security/x509/X500Name;", "")]
		public static unsafe global::Sun.Security.X509.X500Name AsX500Name (global::Javax.Security.Auth.X500.X500Principal p)
		{
			if (id_asX500Name_Ljavax_security_auth_x500_X500Principal_ == IntPtr.Zero)
				id_asX500Name_Ljavax_security_auth_x500_X500Principal_ = JNIEnv.GetStaticMethodID (class_ref, "asX500Name", "(Ljavax/security/auth/x500/X500Principal;)Lsun/security/x509/X500Name;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p);
				global::Sun.Security.X509.X500Name __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asX500Name_Ljavax_security_auth_x500_X500Principal_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_asX500Principal;
#pragma warning disable 0169
		static Delegate GetAsX500PrincipalHandler ()
		{
			if (cb_asX500Principal == null)
				cb_asX500Principal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsX500Principal);
			return cb_asX500Principal;
		}

		static IntPtr n_AsX500Principal (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsX500Principal ());
		}
#pragma warning restore 0169

		static IntPtr id_asX500Principal;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='asX500Principal' and count(parameter)=0]"
		[Register ("asX500Principal", "()Ljavax/security/auth/x500/X500Principal;", "GetAsX500PrincipalHandler")]
		public virtual unsafe global::Javax.Security.Auth.X500.X500Principal AsX500Principal ()
		{
			if (id_asX500Principal == IntPtr.Zero)
				id_asX500Principal = JNIEnv.GetMethodID (class_ref, "asX500Principal", "()Ljavax/security/auth/x500/X500Principal;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Javax.Security.Auth.X500.X500Principal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asX500Principal), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Javax.Security.Auth.X500.X500Principal> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asX500Principal", "()Ljavax/security/auth/x500/X500Principal;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_avaSize;
#pragma warning disable 0169
		static Delegate GetAvaSizeHandler ()
		{
			if (cb_avaSize == null)
				cb_avaSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_AvaSize);
			return cb_avaSize;
		}

		static int n_AvaSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvaSize ();
		}
#pragma warning restore 0169

		static IntPtr id_avaSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='avaSize' and count(parameter)=0]"
		[Register ("avaSize", "()I", "GetAvaSizeHandler")]
		public virtual unsafe int AvaSize ()
		{
			if (id_avaSize == IntPtr.Zero)
				id_avaSize = JNIEnv.GetMethodID (class_ref, "avaSize", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_avaSize);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "avaSize", "()I"));
			} finally {
			}
		}

		static Delegate cb_commonAncestor_Lsun_security_x509_X500Name_;
#pragma warning disable 0169
		static Delegate GetCommonAncestor_Lsun_security_x509_X500Name_Handler ()
		{
			if (cb_commonAncestor_Lsun_security_x509_X500Name_ == null)
				cb_commonAncestor_Lsun_security_x509_X500Name_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CommonAncestor_Lsun_security_x509_X500Name_);
			return cb_commonAncestor_Lsun_security_x509_X500Name_;
		}

		static IntPtr n_CommonAncestor_Lsun_security_x509_X500Name_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.X500Name other = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CommonAncestor (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_commonAncestor_Lsun_security_x509_X500Name_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='commonAncestor' and count(parameter)=1 and parameter[1][@type='sun.security.x509.X500Name']]"
		[Register ("commonAncestor", "(Lsun/security/x509/X500Name;)Lsun/security/x509/X500Name;", "GetCommonAncestor_Lsun_security_x509_X500Name_Handler")]
		public virtual unsafe global::Sun.Security.X509.X500Name CommonAncestor (global::Sun.Security.X509.X500Name other)
		{
			if (id_commonAncestor_Lsun_security_x509_X500Name_ == IntPtr.Zero)
				id_commonAncestor_Lsun_security_x509_X500Name_ = JNIEnv.GetMethodID (class_ref, "commonAncestor", "(Lsun/security/x509/X500Name;)Lsun/security/x509/X500Name;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Sun.Security.X509.X500Name __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_commonAncestor_Lsun_security_x509_X500Name_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commonAncestor", "(Lsun/security/x509/X500Name;)Lsun/security/x509/X500Name;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_constrains_Lsun_security_x509_GeneralNameInterface_;
#pragma warning disable 0169
		static Delegate GetConstrains_Lsun_security_x509_GeneralNameInterface_Handler ()
		{
			if (cb_constrains_Lsun_security_x509_GeneralNameInterface_ == null)
				cb_constrains_Lsun_security_x509_GeneralNameInterface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Constrains_Lsun_security_x509_GeneralNameInterface_);
			return cb_constrains_Lsun_security_x509_GeneralNameInterface_;
		}

		static int n_Constrains_Lsun_security_x509_GeneralNameInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputName)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.IGeneralNameInterface inputName = (global::Sun.Security.X509.IGeneralNameInterface)global::Java.Lang.Object.GetObject<global::Sun.Security.X509.IGeneralNameInterface> (native_inputName, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Constrains (inputName);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_constrains_Lsun_security_x509_GeneralNameInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='constrains' and count(parameter)=1 and parameter[1][@type='sun.security.x509.GeneralNameInterface']]"
		[Register ("constrains", "(Lsun/security/x509/GeneralNameInterface;)I", "GetConstrains_Lsun_security_x509_GeneralNameInterface_Handler")]
		public virtual unsafe int Constrains (global::Sun.Security.X509.IGeneralNameInterface inputName)
		{
			if (id_constrains_Lsun_security_x509_GeneralNameInterface_ == IntPtr.Zero)
				id_constrains_Lsun_security_x509_GeneralNameInterface_ = JNIEnv.GetMethodID (class_ref, "constrains", "(Lsun/security/x509/GeneralNameInterface;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (inputName);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_constrains_Lsun_security_x509_GeneralNameInterface_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "constrains", "(Lsun/security/x509/GeneralNameInterface;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_emit_Lsun_security_util_DerOutputStream_;
#pragma warning disable 0169
		static Delegate GetEmit_Lsun_security_util_DerOutputStream_Handler ()
		{
			if (cb_emit_Lsun_security_util_DerOutputStream_ == null)
				cb_emit_Lsun_security_util_DerOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Emit_Lsun_security_util_DerOutputStream_);
			return cb_emit_Lsun_security_util_DerOutputStream_;
		}

		static void n_Emit_Lsun_security_util_DerOutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Emit (@out);
		}
#pragma warning restore 0169

		static IntPtr id_emit_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='emit' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
		[Obsolete (@"deprecated")]
		[Register ("emit", "(Lsun/security/util/DerOutputStream;)V", "GetEmit_Lsun_security_util_DerOutputStream_Handler")]
		public virtual unsafe void Emit (global::Sun.Security.Util.DerOutputStream @out)
		{
			if (id_emit_Lsun_security_util_DerOutputStream_ == IntPtr.Zero)
				id_emit_Lsun_security_util_DerOutputStream_ = JNIEnv.GetMethodID (class_ref, "emit", "(Lsun/security/util/DerOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_emit_Lsun_security_util_DerOutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "emit", "(Lsun/security/util/DerOutputStream;)V"), __args);
			} finally {
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
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
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
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncoded ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncoded;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getEncoded' and count(parameter)=0]"
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
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncodedInternal ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncodedInternal;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getEncodedInternal' and count(parameter)=0]"
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

		static Delegate cb_getRFC1779Name_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetRFC1779Name_Ljava_util_Map_Handler ()
		{
			if (cb_getRFC1779Name_Ljava_util_Map_ == null)
				cb_getRFC1779Name_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRFC1779Name_Ljava_util_Map_);
			return cb_getRFC1779Name_Ljava_util_Map_;
		}

		static IntPtr n_GetRFC1779Name_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oidMap)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oidMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_oidMap, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetRFC1779Name (oidMap));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRFC1779Name_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getRFC1779Name' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getRFC1779Name", "(Ljava/util/Map;)Ljava/lang/String;", "GetGetRFC1779Name_Ljava_util_Map_Handler")]
		public virtual unsafe string GetRFC1779Name (global::System.Collections.Generic.IDictionary<string, string> oidMap)
		{
			if (id_getRFC1779Name_Ljava_util_Map_ == IntPtr.Zero)
				id_getRFC1779Name_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getRFC1779Name", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_oidMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (oidMap);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_oidMap);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRFC1779Name_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRFC1779Name", "(Ljava/util/Map;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_oidMap);
			}
		}

		static Delegate cb_getRFC2253Name_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetRFC2253Name_Ljava_util_Map_Handler ()
		{
			if (cb_getRFC2253Name_Ljava_util_Map_ == null)
				cb_getRFC2253Name_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRFC2253Name_Ljava_util_Map_);
			return cb_getRFC2253Name_Ljava_util_Map_;
		}

		static IntPtr n_GetRFC2253Name_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oidMap)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oidMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_oidMap, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetRFC2253Name (oidMap));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRFC2253Name_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='getRFC2253Name' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getRFC2253Name", "(Ljava/util/Map;)Ljava/lang/String;", "GetGetRFC2253Name_Ljava_util_Map_Handler")]
		public virtual unsafe string GetRFC2253Name (global::System.Collections.Generic.IDictionary<string, string> oidMap)
		{
			if (id_getRFC2253Name_Ljava_util_Map_ == IntPtr.Zero)
				id_getRFC2253Name_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getRFC2253Name", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_oidMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (oidMap);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_oidMap);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRFC2253Name_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRFC2253Name", "(Ljava/util/Map;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_oidMap);
			}
		}

		static Delegate cb_rdns;
#pragma warning disable 0169
		static Delegate GetRdnsHandler ()
		{
			if (cb_rdns == null)
				cb_rdns = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Rdns);
			return cb_rdns;
		}

		static IntPtr n_Rdns (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Sun.Security.X509.RDN>.ToLocalJniHandle (__this.Rdns ());
		}
#pragma warning restore 0169

		static IntPtr id_rdns;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='rdns' and count(parameter)=0]"
		[Register ("rdns", "()Ljava/util/List;", "GetRdnsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Sun.Security.X509.RDN> Rdns ()
		{
			if (id_rdns == IntPtr.Zero)
				id_rdns = JNIEnv.GetMethodID (class_ref, "rdns", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Sun.Security.X509.RDN>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rdns), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Sun.Security.X509.RDN>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rdns", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

		static Delegate cb_subtreeDepth;
#pragma warning disable 0169
		static Delegate GetSubtreeDepthHandler ()
		{
			if (cb_subtreeDepth == null)
				cb_subtreeDepth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_SubtreeDepth);
			return cb_subtreeDepth;
		}

		static int n_SubtreeDepth (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X500Name __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubtreeDepth ();
		}
#pragma warning restore 0169

		static IntPtr id_subtreeDepth;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Name']/method[@name='subtreeDepth' and count(parameter)=0]"
		[Register ("subtreeDepth", "()I", "GetSubtreeDepthHandler")]
		public virtual unsafe int SubtreeDepth ()
		{
			if (id_subtreeDepth == IntPtr.Zero)
				id_subtreeDepth = JNIEnv.GetMethodID (class_ref, "subtreeDepth", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_subtreeDepth);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subtreeDepth", "()I"));
			} finally {
			}
		}

	}
}
