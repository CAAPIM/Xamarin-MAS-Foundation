using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='CertificatePolicyMap']"
	[global::Android.Runtime.Register ("sun/security/x509/CertificatePolicyMap", DoNotGenerateAcw=true)]
	public partial class CertificatePolicyMap : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/CertificatePolicyMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CertificatePolicyMap); }
		}

		protected CertificatePolicyMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lsun_security_x509_CertificatePolicyId_Lsun_security_x509_CertificatePolicyId_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='CertificatePolicyMap']/constructor[@name='CertificatePolicyMap' and count(parameter)=2 and parameter[1][@type='sun.security.x509.CertificatePolicyId'] and parameter[2][@type='sun.security.x509.CertificatePolicyId']]"
		[Register (".ctor", "(Lsun/security/x509/CertificatePolicyId;Lsun/security/x509/CertificatePolicyId;)V", "")]
		public unsafe CertificatePolicyMap (global::Sun.Security.X509.CertificatePolicyId issuer, global::Sun.Security.X509.CertificatePolicyId subject)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (issuer);
				__args [1] = new JValue (subject);
				if (((object) this).GetType () != typeof (CertificatePolicyMap)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/CertificatePolicyId;Lsun/security/x509/CertificatePolicyId;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/CertificatePolicyId;Lsun/security/x509/CertificatePolicyId;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_CertificatePolicyId_Lsun_security_x509_CertificatePolicyId_ == IntPtr.Zero)
					id_ctor_Lsun_security_x509_CertificatePolicyId_Lsun_security_x509_CertificatePolicyId_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/CertificatePolicyId;Lsun/security/x509/CertificatePolicyId;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_CertificatePolicyId_Lsun_security_x509_CertificatePolicyId_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_CertificatePolicyId_Lsun_security_x509_CertificatePolicyId_, __args);
			} finally {
			}
		}

		static Delegate cb_getIssuerIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIssuerIdentifierHandler ()
		{
			if (cb_getIssuerIdentifier == null)
				cb_getIssuerIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIssuerIdentifier);
			return cb_getIssuerIdentifier;
		}

		static IntPtr n_GetIssuerIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.CertificatePolicyMap __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CertificatePolicyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IssuerIdentifier);
		}
#pragma warning restore 0169

		static IntPtr id_getIssuerIdentifier;
		public virtual unsafe global::Sun.Security.X509.CertificatePolicyId IssuerIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='CertificatePolicyMap']/method[@name='getIssuerIdentifier' and count(parameter)=0]"
			[Register ("getIssuerIdentifier", "()Lsun/security/x509/CertificatePolicyId;", "GetGetIssuerIdentifierHandler")]
			get {
				if (id_getIssuerIdentifier == IntPtr.Zero)
					id_getIssuerIdentifier = JNIEnv.GetMethodID (class_ref, "getIssuerIdentifier", "()Lsun/security/x509/CertificatePolicyId;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CertificatePolicyId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIssuerIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CertificatePolicyId> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIssuerIdentifier", "()Lsun/security/x509/CertificatePolicyId;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubjectIdentifier;
#pragma warning disable 0169
		static Delegate GetGetSubjectIdentifierHandler ()
		{
			if (cb_getSubjectIdentifier == null)
				cb_getSubjectIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubjectIdentifier);
			return cb_getSubjectIdentifier;
		}

		static IntPtr n_GetSubjectIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.CertificatePolicyMap __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CertificatePolicyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubjectIdentifier);
		}
#pragma warning restore 0169

		static IntPtr id_getSubjectIdentifier;
		public virtual unsafe global::Sun.Security.X509.CertificatePolicyId SubjectIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='CertificatePolicyMap']/method[@name='getSubjectIdentifier' and count(parameter)=0]"
			[Register ("getSubjectIdentifier", "()Lsun/security/x509/CertificatePolicyId;", "GetGetSubjectIdentifierHandler")]
			get {
				if (id_getSubjectIdentifier == IntPtr.Zero)
					id_getSubjectIdentifier = JNIEnv.GetMethodID (class_ref, "getSubjectIdentifier", "()Lsun/security/x509/CertificatePolicyId;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CertificatePolicyId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubjectIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CertificatePolicyId> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubjectIdentifier", "()Lsun/security/x509/CertificatePolicyId;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Sun.Security.X509.CertificatePolicyMap __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CertificatePolicyMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='CertificatePolicyMap']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
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

	}
}
