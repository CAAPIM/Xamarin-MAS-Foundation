using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='AccessDescription']"
	[global::Android.Runtime.Register ("sun/security/x509/AccessDescription", DoNotGenerateAcw=true)]
	public sealed partial class AccessDescription : global::Java.Lang.Object {


		static IntPtr Ad_CAISSUERS_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AccessDescription']/field[@name='Ad_CAISSUERS_Id']"
		[Register ("Ad_CAISSUERS_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier AdCAISSUERSId {
			get {
				if (Ad_CAISSUERS_Id_jfieldId == IntPtr.Zero)
					Ad_CAISSUERS_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ad_CAISSUERS_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ad_CAISSUERS_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ad_CAREPOSITORY_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AccessDescription']/field[@name='Ad_CAREPOSITORY_Id']"
		[Register ("Ad_CAREPOSITORY_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier AdCAREPOSITORYId {
			get {
				if (Ad_CAREPOSITORY_Id_jfieldId == IntPtr.Zero)
					Ad_CAREPOSITORY_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ad_CAREPOSITORY_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ad_CAREPOSITORY_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ad_OCSP_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AccessDescription']/field[@name='Ad_OCSP_Id']"
		[Register ("Ad_OCSP_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier AdOCSPId {
			get {
				if (Ad_OCSP_Id_jfieldId == IntPtr.Zero)
					Ad_OCSP_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ad_OCSP_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ad_OCSP_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ad_TIMESTAMPING_Id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='AccessDescription']/field[@name='Ad_TIMESTAMPING_Id']"
		[Register ("Ad_TIMESTAMPING_Id")]
		public static global::Sun.Security.Util.ObjectIdentifier AdTIMESTAMPINGId {
			get {
				if (Ad_TIMESTAMPING_Id_jfieldId == IntPtr.Zero)
					Ad_TIMESTAMPING_Id_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ad_TIMESTAMPING_Id", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ad_TIMESTAMPING_Id_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/AccessDescription", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccessDescription); }
		}

		internal AccessDescription (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAccessLocation;
		public unsafe global::Sun.Security.X509.GeneralName AccessLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AccessDescription']/method[@name='getAccessLocation' and count(parameter)=0]"
			[Register ("getAccessLocation", "()Lsun/security/x509/GeneralName;", "GetGetAccessLocationHandler")]
			get {
				if (id_getAccessLocation == IntPtr.Zero)
					id_getAccessLocation = JNIEnv.GetMethodID (class_ref, "getAccessLocation", "()Lsun/security/x509/GeneralName;");
				try {
					return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralName> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessLocation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAccessMethod;
		public unsafe global::Sun.Security.Util.ObjectIdentifier AccessMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AccessDescription']/method[@name='getAccessMethod' and count(parameter)=0]"
			[Register ("getAccessMethod", "()Lsun/security/util/ObjectIdentifier;", "GetGetAccessMethodHandler")]
			get {
				if (id_getAccessMethod == IntPtr.Zero)
					id_getAccessMethod = JNIEnv.GetMethodID (class_ref, "getAccessMethod", "()Lsun/security/util/ObjectIdentifier;");
				try {
					return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessMethod), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='AccessDescription']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
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

	}
}
