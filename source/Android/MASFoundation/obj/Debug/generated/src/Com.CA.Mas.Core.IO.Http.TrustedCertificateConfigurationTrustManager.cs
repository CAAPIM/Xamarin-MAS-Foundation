using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.IO.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='TrustedCertificateConfigurationTrustManager']"
	[global::Android.Runtime.Register ("com/ca/mas/core/io/http/TrustedCertificateConfigurationTrustManager", DoNotGenerateAcw=true)]
	public partial class TrustedCertificateConfigurationTrustManager : global::Java.Lang.Object, global::Javax.Net.Ssl.IX509TrustManager {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/io/http/TrustedCertificateConfigurationTrustManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrustedCertificateConfigurationTrustManager); }
		}

		protected TrustedCertificateConfigurationTrustManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_foundation_MASSecurityConfiguration_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='TrustedCertificateConfigurationTrustManager']/constructor[@name='TrustedCertificateConfigurationTrustManager' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASSecurityConfiguration']]"
		[Register (".ctor", "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V", "")]
		public unsafe TrustedCertificateConfigurationTrustManager (global::Com.CA.Mas.Foundation.IMASSecurityConfiguration config)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (config);
				if (((object) this).GetType () != typeof (TrustedCertificateConfigurationTrustManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_foundation_MASSecurityConfiguration_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_foundation_MASSecurityConfiguration_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_foundation_MASSecurityConfiguration_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_foundation_MASSecurityConfiguration_, __args);
			} finally {
			}
		}

		static Delegate cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler ()
		{
			if (cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == null)
				cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_);
			return cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
		}

		static void n_CheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_chain, IntPtr native_s)
		{
			global::Com.CA.Mas.Core.IO.Http.TrustedCertificateConfigurationTrustManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IO.Http.TrustedCertificateConfigurationTrustManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.X509Certificate[] chain = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (native_chain, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.Cert.X509Certificate));
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.CheckClientTrusted (chain, s);
			if (chain != null)
				JNIEnv.CopyArray (chain, native_chain);
		}
#pragma warning restore 0169

		static IntPtr id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='TrustedCertificateConfigurationTrustManager']/method[@name='checkClientTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "GetCheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler")]
		public virtual unsafe void CheckClientTrusted (global::Java.Security.Cert.X509Certificate[] chain, string s)
		{
			if (id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == IntPtr.Zero)
				id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
			IntPtr native_chain = JNIEnv.NewArray (chain);
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_chain);
				__args [1] = new JValue (native_s);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"), __args);
			} finally {
				if (chain != null) {
					JNIEnv.CopyArray (native_chain, chain);
					JNIEnv.DeleteLocalRef (native_chain);
				}
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler ()
		{
			if (cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == null)
				cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_);
			return cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
		}

		static void n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_chain, IntPtr native_s)
		{
			global::Com.CA.Mas.Core.IO.Http.TrustedCertificateConfigurationTrustManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IO.Http.TrustedCertificateConfigurationTrustManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.X509Certificate[] chain = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (native_chain, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.Cert.X509Certificate));
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.CheckServerTrusted (chain, s);
			if (chain != null)
				JNIEnv.CopyArray (chain, native_chain);
		}
#pragma warning restore 0169

		static IntPtr id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='TrustedCertificateConfigurationTrustManager']/method[@name='checkServerTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler")]
		public virtual unsafe void CheckServerTrusted (global::Java.Security.Cert.X509Certificate[] chain, string s)
		{
			if (id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == IntPtr.Zero)
				id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
			IntPtr native_chain = JNIEnv.NewArray (chain);
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_chain);
				__args [1] = new JValue (native_s);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V"), __args);
			} finally {
				if (chain != null) {
					JNIEnv.CopyArray (native_chain, chain);
					JNIEnv.DeleteLocalRef (native_chain);
				}
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_getAcceptedIssuers;
#pragma warning disable 0169
		static Delegate GetGetAcceptedIssuersHandler ()
		{
			if (cb_getAcceptedIssuers == null)
				cb_getAcceptedIssuers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAcceptedIssuers);
			return cb_getAcceptedIssuers;
		}

		static IntPtr n_GetAcceptedIssuers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.IO.Http.TrustedCertificateConfigurationTrustManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IO.Http.TrustedCertificateConfigurationTrustManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAcceptedIssuers ());
		}
#pragma warning restore 0169

		static IntPtr id_getAcceptedIssuers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='TrustedCertificateConfigurationTrustManager']/method[@name='getAcceptedIssuers' and count(parameter)=0]"
		[Register ("getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;", "GetGetAcceptedIssuersHandler")]
		public virtual unsafe global::Java.Security.Cert.X509Certificate[] GetAcceptedIssuers ()
		{
			if (id_getAcceptedIssuers == IntPtr.Zero)
				id_getAcceptedIssuers = JNIEnv.GetMethodID (class_ref, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAcceptedIssuers), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
				else
					return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
			} finally {
			}
		}

	}
}
