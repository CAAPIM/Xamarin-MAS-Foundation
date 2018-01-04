using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Pkcs {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10']"
	[global::Android.Runtime.Register ("sun/security/pkcs/PKCS10", DoNotGenerateAcw=true)]
	public partial class PKCS10 : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/pkcs/PKCS10", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKCS10); }
		}

		protected PKCS10 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10']/constructor[@name='PKCS10' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe PKCS10 (byte[] data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				if (((object) this).GetType () != typeof (PKCS10)) {
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
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_ctor_Ljava_security_PublicKey_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10']/constructor[@name='PKCS10' and count(parameter)=1 and parameter[1][@type='java.security.PublicKey']]"
		[Register (".ctor", "(Ljava/security/PublicKey;)V", "")]
		public unsafe PKCS10 (global::Java.Security.IPublicKey publicKey)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (publicKey);
				if (((object) this).GetType () != typeof (PKCS10)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/security/PublicKey;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/security/PublicKey;)V", __args);
					return;
				}

				if (id_ctor_Ljava_security_PublicKey_ == IntPtr.Zero)
					id_ctor_Ljava_security_PublicKey_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/security/PublicKey;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_security_PublicKey_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_security_PublicKey_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_security_PublicKey_Lsun_security_pkcs_PKCS10Attributes_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10']/constructor[@name='PKCS10' and count(parameter)=2 and parameter[1][@type='java.security.PublicKey'] and parameter[2][@type='sun.security.pkcs.PKCS10Attributes']]"
		[Register (".ctor", "(Ljava/security/PublicKey;Lsun/security/pkcs/PKCS10Attributes;)V", "")]
		public unsafe PKCS10 (global::Java.Security.IPublicKey publicKey, global::Sun.Security.Pkcs.PKCS10Attributes attributes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (publicKey);
				__args [1] = new JValue (attributes);
				if (((object) this).GetType () != typeof (PKCS10)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/security/PublicKey;Lsun/security/pkcs/PKCS10Attributes;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/security/PublicKey;Lsun/security/pkcs/PKCS10Attributes;)V", __args);
					return;
				}

				if (id_ctor_Ljava_security_PublicKey_Lsun_security_pkcs_PKCS10Attributes_ == IntPtr.Zero)
					id_ctor_Ljava_security_PublicKey_Lsun_security_pkcs_PKCS10Attributes_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/security/PublicKey;Lsun/security/pkcs/PKCS10Attributes;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_security_PublicKey_Lsun_security_pkcs_PKCS10Attributes_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_security_PublicKey_Lsun_security_pkcs_PKCS10Attributes_, __args);
			} finally {
			}
		}

		static Delegate cb_getAttributes;
#pragma warning disable 0169
		static Delegate GetGetAttributesHandler ()
		{
			if (cb_getAttributes == null)
				cb_getAttributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributes);
			return cb_getAttributes;
		}

		static IntPtr n_GetAttributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.PKCS10 __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Attributes);
		}
#pragma warning restore 0169

		static IntPtr id_getAttributes;
		public virtual unsafe global::Sun.Security.Pkcs.PKCS10Attributes Attributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10']/method[@name='getAttributes' and count(parameter)=0]"
			[Register ("getAttributes", "()Lsun/security/pkcs/PKCS10Attributes;", "GetGetAttributesHandler")]
			get {
				if (id_getAttributes == IntPtr.Zero)
					id_getAttributes = JNIEnv.GetMethodID (class_ref, "getAttributes", "()Lsun/security/pkcs/PKCS10Attributes;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attributes> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttributes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attributes> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttributes", "()Lsun/security/pkcs/PKCS10Attributes;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubjectName;
#pragma warning disable 0169
		static Delegate GetGetSubjectNameHandler ()
		{
			if (cb_getSubjectName == null)
				cb_getSubjectName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubjectName);
			return cb_getSubjectName;
		}

		static IntPtr n_GetSubjectName (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.PKCS10 __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubjectName);
		}
#pragma warning restore 0169

		static IntPtr id_getSubjectName;
		public virtual unsafe global::Sun.Security.X509.X500Name SubjectName {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10']/method[@name='getSubjectName' and count(parameter)=0]"
			[Register ("getSubjectName", "()Lsun/security/x509/X500Name;", "GetGetSubjectNameHandler")]
			get {
				if (id_getSubjectName == IntPtr.Zero)
					id_getSubjectName = JNIEnv.GetMethodID (class_ref, "getSubjectName", "()Lsun/security/x509/X500Name;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubjectName), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Name> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubjectName", "()Lsun/security/x509/X500Name;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubjectPublicKeyInfo;
#pragma warning disable 0169
		static Delegate GetGetSubjectPublicKeyInfoHandler ()
		{
			if (cb_getSubjectPublicKeyInfo == null)
				cb_getSubjectPublicKeyInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubjectPublicKeyInfo);
			return cb_getSubjectPublicKeyInfo;
		}

		static IntPtr n_GetSubjectPublicKeyInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.PKCS10 __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubjectPublicKeyInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getSubjectPublicKeyInfo;
		public virtual unsafe global::Java.Security.IPublicKey SubjectPublicKeyInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10']/method[@name='getSubjectPublicKeyInfo' and count(parameter)=0]"
			[Register ("getSubjectPublicKeyInfo", "()Ljava/security/PublicKey;", "GetGetSubjectPublicKeyInfoHandler")]
			get {
				if (id_getSubjectPublicKeyInfo == IntPtr.Zero)
					id_getSubjectPublicKeyInfo = JNIEnv.GetMethodID (class_ref, "getSubjectPublicKeyInfo", "()Ljava/security/PublicKey;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubjectPublicKeyInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubjectPublicKeyInfo", "()Ljava/security/PublicKey;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_encodeAndSign_Lsun_security_x509_X500Signer_;
#pragma warning disable 0169
		static Delegate GetEncodeAndSign_Lsun_security_x509_X500Signer_Handler ()
		{
			if (cb_encodeAndSign_Lsun_security_x509_X500Signer_ == null)
				cb_encodeAndSign_Lsun_security_x509_X500Signer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EncodeAndSign_Lsun_security_x509_X500Signer_);
			return cb_encodeAndSign_Lsun_security_x509_X500Signer_;
		}

		static void n_EncodeAndSign_Lsun_security_x509_X500Signer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requester)
		{
			global::Sun.Security.Pkcs.PKCS10 __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.X500Signer requester = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X500Signer> (native_requester, JniHandleOwnership.DoNotTransfer);
			__this.EncodeAndSign (requester);
		}
#pragma warning restore 0169

		static IntPtr id_encodeAndSign_Lsun_security_x509_X500Signer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10']/method[@name='encodeAndSign' and count(parameter)=1 and parameter[1][@type='sun.security.x509.X500Signer']]"
		[Register ("encodeAndSign", "(Lsun/security/x509/X500Signer;)V", "GetEncodeAndSign_Lsun_security_x509_X500Signer_Handler")]
		public virtual unsafe void EncodeAndSign (global::Sun.Security.X509.X500Signer requester)
		{
			if (id_encodeAndSign_Lsun_security_x509_X500Signer_ == IntPtr.Zero)
				id_encodeAndSign_Lsun_security_x509_X500Signer_ = JNIEnv.GetMethodID (class_ref, "encodeAndSign", "(Lsun/security/x509/X500Signer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (requester);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeAndSign_Lsun_security_x509_X500Signer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeAndSign", "(Lsun/security/x509/X500Signer;)V"), __args);
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
			global::Sun.Security.Pkcs.PKCS10 __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncoded ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncoded;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10']/method[@name='getEncoded' and count(parameter)=0]"
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

		static Delegate cb_print_Ljava_io_PrintStream_;
#pragma warning disable 0169
		static Delegate GetPrint_Ljava_io_PrintStream_Handler ()
		{
			if (cb_print_Ljava_io_PrintStream_ == null)
				cb_print_Ljava_io_PrintStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Print_Ljava_io_PrintStream_);
			return cb_print_Ljava_io_PrintStream_;
		}

		static void n_Print_Ljava_io_PrintStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.Pkcs.PKCS10 __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.PrintStream @out = global::Java.Lang.Object.GetObject<global::Java.IO.PrintStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Print (@out);
		}
#pragma warning restore 0169

		static IntPtr id_print_Ljava_io_PrintStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10']/method[@name='print' and count(parameter)=1 and parameter[1][@type='java.io.PrintStream']]"
		[Register ("print", "(Ljava/io/PrintStream;)V", "GetPrint_Ljava_io_PrintStream_Handler")]
		public virtual unsafe void Print (global::Java.IO.PrintStream @out)
		{
			if (id_print_Ljava_io_PrintStream_ == IntPtr.Zero)
				id_print_Ljava_io_PrintStream_ = JNIEnv.GetMethodID (class_ref, "print", "(Ljava/io/PrintStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_print_Ljava_io_PrintStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "print", "(Ljava/io/PrintStream;)V"), __args);
			} finally {
			}
		}

	}
}
