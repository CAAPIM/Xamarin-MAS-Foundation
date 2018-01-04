using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Signer']"
	[global::Android.Runtime.Register ("sun/security/x509/X500Signer", DoNotGenerateAcw=true)]
	public sealed partial class X500Signer : global::Java.Security.Signer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/X500Signer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (X500Signer); }
		}

		internal X500Signer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_security_Signature_Lsun_security_x509_X500Name_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Signer']/constructor[@name='X500Signer' and count(parameter)=2 and parameter[1][@type='java.security.Signature'] and parameter[2][@type='sun.security.x509.X500Name']]"
		[Register (".ctor", "(Ljava/security/Signature;Lsun/security/x509/X500Name;)V", "")]
		public unsafe X500Signer (global::Java.Security.Signature sig, global::Sun.Security.X509.X500Name agent)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (sig);
				__args [1] = new JValue (agent);
				if (((object) this).GetType () != typeof (X500Signer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/security/Signature;Lsun/security/x509/X500Name;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/security/Signature;Lsun/security/x509/X500Name;)V", __args);
					return;
				}

				if (id_ctor_Ljava_security_Signature_Lsun_security_x509_X500Name_ == IntPtr.Zero)
					id_ctor_Ljava_security_Signature_Lsun_security_x509_X500Name_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/security/Signature;Lsun/security/x509/X500Name;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_security_Signature_Lsun_security_x509_X500Name_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_security_Signature_Lsun_security_x509_X500Name_, __args);
			} finally {
			}
		}

		static IntPtr id_getAlgorithmId;
		public unsafe global::Sun.Security.X509.AlgorithmId AlgorithmId {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Signer']/method[@name='getAlgorithmId' and count(parameter)=0]"
			[Register ("getAlgorithmId", "()Lsun/security/x509/AlgorithmId;", "GetGetAlgorithmIdHandler")]
			get {
				if (id_getAlgorithmId == IntPtr.Zero)
					id_getAlgorithmId = JNIEnv.GetMethodID (class_ref, "getAlgorithmId", "()Lsun/security/x509/AlgorithmId;");
				try {
					return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlgorithmId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSigner;
		public unsafe global::Sun.Security.X509.X500Name Signer {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Signer']/method[@name='getSigner' and count(parameter)=0]"
			[Register ("getSigner", "()Lsun/security/x509/X500Name;", "GetGetSignerHandler")]
			get {
				if (id_getSigner == IntPtr.Zero)
					id_getSigner = JNIEnv.GetMethodID (class_ref, "getSigner", "()Lsun/security/x509/X500Name;");
				try {
					return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSigner), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_sign;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Signer']/method[@name='sign' and count(parameter)=0]"
		[Register ("sign", "()[B", "")]
		public unsafe byte[] Sign ()
		{
			if (id_sign == IntPtr.Zero)
				id_sign = JNIEnv.GetMethodID (class_ref, "sign", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sign), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_update_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X500Signer']/method[@name='update' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("update", "([BII)V", "")]
		public unsafe void Update (byte[] buf, int offset, int len)
		{
			if (id_update_arrayBII == IntPtr.Zero)
				id_update_arrayBII = JNIEnv.GetMethodID (class_ref, "update", "([BII)V");
			IntPtr native_buf = JNIEnv.NewArray (buf);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_buf);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (len);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_arrayBII, __args);
			} finally {
				if (buf != null) {
					JNIEnv.CopyArray (native_buf, buf);
					JNIEnv.DeleteLocalRef (native_buf);
				}
			}
		}

	}
}
