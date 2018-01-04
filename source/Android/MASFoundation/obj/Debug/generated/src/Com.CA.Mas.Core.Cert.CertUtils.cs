using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Cert {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='CertUtils']"
	[global::Android.Runtime.Register ("com/ca/mas/core/cert/CertUtils", DoNotGenerateAcw=true)]
	public partial class CertUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/cert/CertUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CertUtils); }
		}

		protected CertUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_decodeCertFromPem_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='CertUtils']/method[@name='decodeCertFromPem' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeCertFromPem", "(Ljava/lang/String;)Ljava/security/cert/X509Certificate;", "")]
		public static unsafe global::Java.Security.Cert.X509Certificate DecodeCertFromPem (string certificateText)
		{
			if (id_decodeCertFromPem_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeCertFromPem_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeCertFromPem", "(Ljava/lang/String;)Ljava/security/cert/X509Certificate;");
			IntPtr native_certificateText = JNIEnv.NewString (certificateText);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_certificateText);
				global::Java.Security.Cert.X509Certificate __ret = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeCertFromPem_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_certificateText);
			}
		}

		static IntPtr id_decodeCertificateChain_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='CertUtils']/method[@name='decodeCertificateChain' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeCertificateChain", "([B)[Ljava/security/cert/X509Certificate;", "")]
		public static unsafe global::Java.Security.Cert.X509Certificate[] DecodeCertificateChain (byte[] chainBytes)
		{
			if (id_decodeCertificateChain_arrayB == IntPtr.Zero)
				id_decodeCertificateChain_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decodeCertificateChain", "([B)[Ljava/security/cert/X509Certificate;");
			IntPtr native_chainBytes = JNIEnv.NewArray (chainBytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_chainBytes);
				global::Java.Security.Cert.X509Certificate[] __ret = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeCertificateChain_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
				return __ret;
			} finally {
				if (chainBytes != null) {
					JNIEnv.CopyArray (native_chainBytes, chainBytes);
					JNIEnv.DeleteLocalRef (native_chainBytes);
				}
			}
		}

		static IntPtr id_generateCertificateSigningRequest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_Ljava_security_PrivateKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='CertUtils']/method[@name='generateCertificateSigningRequest' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.security.PublicKey'] and parameter[6][@type='java.security.PrivateKey']]"
		[Register ("generateCertificateSigningRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/security/PublicKey;Ljava/security/PrivateKey;)[B", "")]
		public static unsafe byte[] GenerateCertificateSigningRequest (string commonName, string deviceId, string deviceName, string organization, global::Java.Security.IPublicKey publicKey, global::Java.Security.IPrivateKey privateKey)
		{
			if (id_generateCertificateSigningRequest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_Ljava_security_PrivateKey_ == IntPtr.Zero)
				id_generateCertificateSigningRequest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_Ljava_security_PrivateKey_ = JNIEnv.GetStaticMethodID (class_ref, "generateCertificateSigningRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/security/PublicKey;Ljava/security/PrivateKey;)[B");
			IntPtr native_commonName = JNIEnv.NewString (commonName);
			IntPtr native_deviceId = JNIEnv.NewString (deviceId);
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			IntPtr native_organization = JNIEnv.NewString (organization);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_commonName);
				__args [1] = new JValue (native_deviceId);
				__args [2] = new JValue (native_deviceName);
				__args [3] = new JValue (native_organization);
				__args [4] = new JValue (publicKey);
				__args [5] = new JValue (privateKey);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateCertificateSigningRequest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_Ljava_security_PrivateKey_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_commonName);
				JNIEnv.DeleteLocalRef (native_deviceId);
				JNIEnv.DeleteLocalRef (native_deviceName);
				JNIEnv.DeleteLocalRef (native_organization);
			}
		}

	}
}
