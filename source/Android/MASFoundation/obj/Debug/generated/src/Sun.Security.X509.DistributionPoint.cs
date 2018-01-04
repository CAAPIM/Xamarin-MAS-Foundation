using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']"
	[global::Android.Runtime.Register ("sun/security/x509/DistributionPoint", DoNotGenerateAcw=true)]
	public partial class DistributionPoint : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/field[@name='AA_COMPROMISE']"
		[Register ("AA_COMPROMISE")]
		public const int AaCompromise = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/field[@name='AFFILIATION_CHANGED']"
		[Register ("AFFILIATION_CHANGED")]
		public const int AffiliationChanged = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/field[@name='CA_COMPROMISE']"
		[Register ("CA_COMPROMISE")]
		public const int CaCompromise = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/field[@name='CERTIFICATE_HOLD']"
		[Register ("CERTIFICATE_HOLD")]
		public const int CertificateHold = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/field[@name='CESSATION_OF_OPERATION']"
		[Register ("CESSATION_OF_OPERATION")]
		public const int CessationOfOperation = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/field[@name='KEY_COMPROMISE']"
		[Register ("KEY_COMPROMISE")]
		public const int KeyCompromise = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/field[@name='PRIVILEGE_WITHDRAWN']"
		[Register ("PRIVILEGE_WITHDRAWN")]
		public const int PrivilegeWithdrawn = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/field[@name='SUPERSEDED']"
		[Register ("SUPERSEDED")]
		public const int Superseded = (int) 4;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/DistributionPoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DistributionPoint); }
		}

		protected DistributionPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lsun_security_x509_GeneralNames_arrayZLsun_security_x509_GeneralNames_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/constructor[@name='DistributionPoint' and count(parameter)=3 and parameter[1][@type='sun.security.x509.GeneralNames'] and parameter[2][@type='boolean[]'] and parameter[3][@type='sun.security.x509.GeneralNames']]"
		[Register (".ctor", "(Lsun/security/x509/GeneralNames;[ZLsun/security/x509/GeneralNames;)V", "")]
		public unsafe DistributionPoint (global::Sun.Security.X509.GeneralNames fullName, bool[] reasonFlags, global::Sun.Security.X509.GeneralNames crlIssuer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_reasonFlags = JNIEnv.NewArray (reasonFlags);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (fullName);
				__args [1] = new JValue (native_reasonFlags);
				__args [2] = new JValue (crlIssuer);
				if (((object) this).GetType () != typeof (DistributionPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/GeneralNames;[ZLsun/security/x509/GeneralNames;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/GeneralNames;[ZLsun/security/x509/GeneralNames;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_GeneralNames_arrayZLsun_security_x509_GeneralNames_ == IntPtr.Zero)
					id_ctor_Lsun_security_x509_GeneralNames_arrayZLsun_security_x509_GeneralNames_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/GeneralNames;[ZLsun/security/x509/GeneralNames;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_GeneralNames_arrayZLsun_security_x509_GeneralNames_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_GeneralNames_arrayZLsun_security_x509_GeneralNames_, __args);
			} finally {
				if (reasonFlags != null) {
					JNIEnv.CopyArray (native_reasonFlags, reasonFlags);
					JNIEnv.DeleteLocalRef (native_reasonFlags);
				}
			}
		}

		static IntPtr id_ctor_Lsun_security_x509_RDN_arrayZLsun_security_x509_GeneralNames_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/constructor[@name='DistributionPoint' and count(parameter)=3 and parameter[1][@type='sun.security.x509.RDN'] and parameter[2][@type='boolean[]'] and parameter[3][@type='sun.security.x509.GeneralNames']]"
		[Register (".ctor", "(Lsun/security/x509/RDN;[ZLsun/security/x509/GeneralNames;)V", "")]
		public unsafe DistributionPoint (global::Sun.Security.X509.RDN relativeName, bool[] reasonFlags, global::Sun.Security.X509.GeneralNames crlIssuer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_reasonFlags = JNIEnv.NewArray (reasonFlags);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (relativeName);
				__args [1] = new JValue (native_reasonFlags);
				__args [2] = new JValue (crlIssuer);
				if (((object) this).GetType () != typeof (DistributionPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/x509/RDN;[ZLsun/security/x509/GeneralNames;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/x509/RDN;[ZLsun/security/x509/GeneralNames;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_x509_RDN_arrayZLsun_security_x509_GeneralNames_ == IntPtr.Zero)
					id_ctor_Lsun_security_x509_RDN_arrayZLsun_security_x509_GeneralNames_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/x509/RDN;[ZLsun/security/x509/GeneralNames;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_x509_RDN_arrayZLsun_security_x509_GeneralNames_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_x509_RDN_arrayZLsun_security_x509_GeneralNames_, __args);
			} finally {
				if (reasonFlags != null) {
					JNIEnv.CopyArray (native_reasonFlags, reasonFlags);
					JNIEnv.DeleteLocalRef (native_reasonFlags);
				}
			}
		}

		static Delegate cb_getCRLIssuer;
#pragma warning disable 0169
		static Delegate GetGetCRLIssuerHandler ()
		{
			if (cb_getCRLIssuer == null)
				cb_getCRLIssuer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCRLIssuer);
			return cb_getCRLIssuer;
		}

		static IntPtr n_GetCRLIssuer (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.DistributionPoint __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.DistributionPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CRLIssuer);
		}
#pragma warning restore 0169

		static IntPtr id_getCRLIssuer;
		public virtual unsafe global::Sun.Security.X509.GeneralNames CRLIssuer {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/method[@name='getCRLIssuer' and count(parameter)=0]"
			[Register ("getCRLIssuer", "()Lsun/security/x509/GeneralNames;", "GetGetCRLIssuerHandler")]
			get {
				if (id_getCRLIssuer == IntPtr.Zero)
					id_getCRLIssuer = JNIEnv.GetMethodID (class_ref, "getCRLIssuer", "()Lsun/security/x509/GeneralNames;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCRLIssuer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCRLIssuer", "()Lsun/security/x509/GeneralNames;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFullName;
#pragma warning disable 0169
		static Delegate GetGetFullNameHandler ()
		{
			if (cb_getFullName == null)
				cb_getFullName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFullName);
			return cb_getFullName;
		}

		static IntPtr n_GetFullName (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.DistributionPoint __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.DistributionPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FullName);
		}
#pragma warning restore 0169

		static IntPtr id_getFullName;
		public virtual unsafe global::Sun.Security.X509.GeneralNames FullName {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/method[@name='getFullName' and count(parameter)=0]"
			[Register ("getFullName", "()Lsun/security/x509/GeneralNames;", "GetGetFullNameHandler")]
			get {
				if (id_getFullName == IntPtr.Zero)
					id_getFullName = JNIEnv.GetMethodID (class_ref, "getFullName", "()Lsun/security/x509/GeneralNames;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFullName), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFullName", "()Lsun/security/x509/GeneralNames;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRelativeName;
#pragma warning disable 0169
		static Delegate GetGetRelativeNameHandler ()
		{
			if (cb_getRelativeName == null)
				cb_getRelativeName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRelativeName);
			return cb_getRelativeName;
		}

		static IntPtr n_GetRelativeName (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.DistributionPoint __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.DistributionPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RelativeName);
		}
#pragma warning restore 0169

		static IntPtr id_getRelativeName;
		public virtual unsafe global::Sun.Security.X509.RDN RelativeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/method[@name='getRelativeName' and count(parameter)=0]"
			[Register ("getRelativeName", "()Lsun/security/x509/RDN;", "GetGetRelativeNameHandler")]
			get {
				if (id_getRelativeName == IntPtr.Zero)
					id_getRelativeName = JNIEnv.GetMethodID (class_ref, "getRelativeName", "()Lsun/security/x509/RDN;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.RDN> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRelativeName), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.RDN> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelativeName", "()Lsun/security/x509/RDN;")), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.DistributionPoint __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.DistributionPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
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

		static Delegate cb_getReasonFlags;
#pragma warning disable 0169
		static Delegate GetGetReasonFlagsHandler ()
		{
			if (cb_getReasonFlags == null)
				cb_getReasonFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReasonFlags);
			return cb_getReasonFlags;
		}

		static IntPtr n_GetReasonFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.DistributionPoint __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.DistributionPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetReasonFlags ());
		}
#pragma warning restore 0169

		static IntPtr id_getReasonFlags;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='DistributionPoint']/method[@name='getReasonFlags' and count(parameter)=0]"
		[Register ("getReasonFlags", "()[Z", "GetGetReasonFlagsHandler")]
		public virtual unsafe bool[] GetReasonFlags ()
		{
			if (id_getReasonFlags == IntPtr.Zero)
				id_getReasonFlags = JNIEnv.GetMethodID (class_ref, "getReasonFlags", "()[Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReasonFlags), JniHandleOwnership.TransferLocalRef, typeof (bool));
				else
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReasonFlags", "()[Z")), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

	}
}
