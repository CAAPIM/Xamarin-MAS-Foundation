using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']"
	[global::Android.Runtime.Register ("sun/security/x509/X509CRLEntryImpl", DoNotGenerateAcw=true)]
	public partial class X509CRLEntryImpl : global::Java.Security.Cert.X509CRLEntry {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/X509CRLEntryImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (X509CRLEntryImpl); }
		}

		protected X509CRLEntryImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/constructor[@name='X509CRLEntryImpl' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe X509CRLEntryImpl (byte[] revokedCert)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_revokedCert = JNIEnv.NewArray (revokedCert);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_revokedCert);
				if (((object) this).GetType () != typeof (X509CRLEntryImpl)) {
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
				if (revokedCert != null) {
					JNIEnv.CopyArray (native_revokedCert, revokedCert);
					JNIEnv.DeleteLocalRef (native_revokedCert);
				}
			}
		}

		static IntPtr id_ctor_Ljava_math_BigInteger_Ljava_util_Date_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/constructor[@name='X509CRLEntryImpl' and count(parameter)=2 and parameter[1][@type='java.math.BigInteger'] and parameter[2][@type='java.util.Date']]"
		[Register (".ctor", "(Ljava/math/BigInteger;Ljava/util/Date;)V", "")]
		public unsafe X509CRLEntryImpl (global::Java.Math.BigInteger num, global::Java.Util.Date date)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (num);
				__args [1] = new JValue (date);
				if (((object) this).GetType () != typeof (X509CRLEntryImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/math/BigInteger;Ljava/util/Date;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/math/BigInteger;Ljava/util/Date;)V", __args);
					return;
				}

				if (id_ctor_Ljava_math_BigInteger_Ljava_util_Date_ == IntPtr.Zero)
					id_ctor_Ljava_math_BigInteger_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/math/BigInteger;Ljava/util/Date;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_math_BigInteger_Ljava_util_Date_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_math_BigInteger_Ljava_util_Date_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_math_BigInteger_Ljava_util_Date_Lsun_security_x509_CRLExtensions_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/constructor[@name='X509CRLEntryImpl' and count(parameter)=3 and parameter[1][@type='java.math.BigInteger'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='sun.security.x509.CRLExtensions']]"
		[Register (".ctor", "(Ljava/math/BigInteger;Ljava/util/Date;Lsun/security/x509/CRLExtensions;)V", "")]
		public unsafe X509CRLEntryImpl (global::Java.Math.BigInteger num, global::Java.Util.Date date, global::Sun.Security.X509.CRLExtensions crlEntryExts)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (num);
				__args [1] = new JValue (date);
				__args [2] = new JValue (crlEntryExts);
				if (((object) this).GetType () != typeof (X509CRLEntryImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/math/BigInteger;Ljava/util/Date;Lsun/security/x509/CRLExtensions;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/math/BigInteger;Ljava/util/Date;Lsun/security/x509/CRLExtensions;)V", __args);
					return;
				}

				if (id_ctor_Ljava_math_BigInteger_Ljava_util_Date_Lsun_security_x509_CRLExtensions_ == IntPtr.Zero)
					id_ctor_Ljava_math_BigInteger_Ljava_util_Date_Lsun_security_x509_CRLExtensions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/math/BigInteger;Ljava/util/Date;Lsun/security/x509/CRLExtensions;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_math_BigInteger_Ljava_util_Date_Lsun_security_x509_CRLExtensions_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_math_BigInteger_Ljava_util_Date_Lsun_security_x509_CRLExtensions_, __args);
			} finally {
			}
		}

		static Delegate cb_getCriticalExtensionOIDs;
#pragma warning disable 0169
		static Delegate GetGetCriticalExtensionOIDsHandler ()
		{
			if (cb_getCriticalExtensionOIDs == null)
				cb_getCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCriticalExtensionOIDs);
			return cb_getCriticalExtensionOIDs;
		}

		static IntPtr n_GetCriticalExtensionOIDs (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.CriticalExtensionOIDs);
		}
#pragma warning restore 0169

		static IntPtr id_getCriticalExtensionOIDs;
		public override unsafe global::System.Collections.Generic.ICollection<string> CriticalExtensionOIDs {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='getCriticalExtensionOIDs' and count(parameter)=0]"
			[Register ("getCriticalExtensionOIDs", "()Ljava/util/Set;", "GetGetCriticalExtensionOIDsHandler")]
			get {
				if (id_getCriticalExtensionOIDs == IntPtr.Zero)
					id_getCriticalExtensionOIDs = JNIEnv.GetMethodID (class_ref, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCriticalExtensionOIDs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCriticalExtensionOIDs", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasExtensions;
#pragma warning disable 0169
		static Delegate GetHasExtensionsHandler ()
		{
			if (cb_hasExtensions == null)
				cb_hasExtensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasExtensions);
			return cb_hasExtensions;
		}

		static bool n_HasExtensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasExtensions;
		}
#pragma warning restore 0169

		static IntPtr id_hasExtensions;
		public override unsafe bool HasExtensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='hasExtensions' and count(parameter)=0]"
			[Register ("hasExtensions", "()Z", "GetHasExtensionsHandler")]
			get {
				if (id_hasExtensions == IntPtr.Zero)
					id_hasExtensions = JNIEnv.GetMethodID (class_ref, "hasExtensions", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasExtensions);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasExtensions", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasUnsupportedCriticalExtension;
#pragma warning disable 0169
		static Delegate GetHasUnsupportedCriticalExtensionHandler ()
		{
			if (cb_hasUnsupportedCriticalExtension == null)
				cb_hasUnsupportedCriticalExtension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasUnsupportedCriticalExtension);
			return cb_hasUnsupportedCriticalExtension;
		}

		static bool n_HasUnsupportedCriticalExtension (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUnsupportedCriticalExtension;
		}
#pragma warning restore 0169

		static IntPtr id_hasUnsupportedCriticalExtension;
		public override unsafe bool HasUnsupportedCriticalExtension {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='hasUnsupportedCriticalExtension' and count(parameter)=0]"
			[Register ("hasUnsupportedCriticalExtension", "()Z", "GetHasUnsupportedCriticalExtensionHandler")]
			get {
				if (id_hasUnsupportedCriticalExtension == IntPtr.Zero)
					id_hasUnsupportedCriticalExtension = JNIEnv.GetMethodID (class_ref, "hasUnsupportedCriticalExtension", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasUnsupportedCriticalExtension);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasUnsupportedCriticalExtension", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNonCriticalExtensionOIDs;
#pragma warning disable 0169
		static Delegate GetGetNonCriticalExtensionOIDsHandler ()
		{
			if (cb_getNonCriticalExtensionOIDs == null)
				cb_getNonCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNonCriticalExtensionOIDs);
			return cb_getNonCriticalExtensionOIDs;
		}

		static IntPtr n_GetNonCriticalExtensionOIDs (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.NonCriticalExtensionOIDs);
		}
#pragma warning restore 0169

		static IntPtr id_getNonCriticalExtensionOIDs;
		public override unsafe global::System.Collections.Generic.ICollection<string> NonCriticalExtensionOIDs {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='getNonCriticalExtensionOIDs' and count(parameter)=0]"
			[Register ("getNonCriticalExtensionOIDs", "()Ljava/util/Set;", "GetGetNonCriticalExtensionOIDsHandler")]
			get {
				if (id_getNonCriticalExtensionOIDs == IntPtr.Zero)
					id_getNonCriticalExtensionOIDs = JNIEnv.GetMethodID (class_ref, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNonCriticalExtensionOIDs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReasonCode;
#pragma warning disable 0169
		static Delegate GetGetReasonCodeHandler ()
		{
			if (cb_getReasonCode == null)
				cb_getReasonCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReasonCode);
			return cb_getReasonCode;
		}

		static IntPtr n_GetReasonCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReasonCode);
		}
#pragma warning restore 0169

		static IntPtr id_getReasonCode;
		public virtual unsafe global::Java.Lang.Integer ReasonCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='getReasonCode' and count(parameter)=0]"
			[Register ("getReasonCode", "()Ljava/lang/Integer;", "GetGetReasonCodeHandler")]
			get {
				if (id_getReasonCode == IntPtr.Zero)
					id_getReasonCode = JNIEnv.GetMethodID (class_ref, "getReasonCode", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReasonCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReasonCode", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRevocationDate;
#pragma warning disable 0169
		static Delegate GetGetRevocationDateHandler ()
		{
			if (cb_getRevocationDate == null)
				cb_getRevocationDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRevocationDate);
			return cb_getRevocationDate;
		}

		static IntPtr n_GetRevocationDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RevocationDate);
		}
#pragma warning restore 0169

		static IntPtr id_getRevocationDate;
		public override unsafe global::Java.Util.Date RevocationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='getRevocationDate' and count(parameter)=0]"
			[Register ("getRevocationDate", "()Ljava/util/Date;", "GetGetRevocationDateHandler")]
			get {
				if (id_getRevocationDate == IntPtr.Zero)
					id_getRevocationDate = JNIEnv.GetMethodID (class_ref, "getRevocationDate", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRevocationDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRevocationDate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetSerialNumberHandler ()
		{
			if (cb_getSerialNumber == null)
				cb_getSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNumber);
			return cb_getSerialNumber;
		}

		static IntPtr n_GetSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerialNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getSerialNumber;
		public override unsafe global::Java.Math.BigInteger SerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='getSerialNumber' and count(parameter)=0]"
			[Register ("getSerialNumber", "()Ljava/math/BigInteger;", "GetGetSerialNumberHandler")]
			get {
				if (id_getSerialNumber == IntPtr.Zero)
					id_getSerialNumber = JNIEnv.GetMethodID (class_ref, "getSerialNumber", "()Ljava/math/BigInteger;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialNumber), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSerialNumber", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
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

		static void n_Encode_Lsun_security_util_DerOutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_outStrm)
		{
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream outStrm = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native_outStrm, JniHandleOwnership.DoNotTransfer);
			__this.Encode (outStrm);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
		[Register ("encode", "(Lsun/security/util/DerOutputStream;)V", "GetEncode_Lsun_security_util_DerOutputStream_Handler")]
		public virtual unsafe void Encode (global::Sun.Security.Util.DerOutputStream outStrm)
		{
			if (id_encode_Lsun_security_util_DerOutputStream_ == IntPtr.Zero)
				id_encode_Lsun_security_util_DerOutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lsun/security/util/DerOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (outStrm);

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
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncoded ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncoded;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='getEncoded' and count(parameter)=0]"
		[Register ("getEncoded", "()[B", "GetGetEncodedHandler")]
		public override unsafe byte[] GetEncoded ()
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

		static Delegate cb_getExtensionValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetExtensionValue_Ljava_lang_String_Handler ()
		{
			if (cb_getExtensionValue_Ljava_lang_String_ == null)
				cb_getExtensionValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetExtensionValue_Ljava_lang_String_);
			return cb_getExtensionValue_Ljava_lang_String_;
		}

		static IntPtr n_GetExtensionValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oid)
		{
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string oid = JNIEnv.GetString (native_oid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetExtensionValue (oid));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getExtensionValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='getExtensionValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExtensionValue", "(Ljava/lang/String;)[B", "GetGetExtensionValue_Ljava_lang_String_Handler")]
		public override unsafe byte[] GetExtensionValue (string oid)
		{
			if (id_getExtensionValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getExtensionValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getExtensionValue", "(Ljava/lang/String;)[B");
			IntPtr native_oid = JNIEnv.NewString (oid);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_oid);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtensionValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtensionValue", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_oid);
			}
		}

		static IntPtr id_toImpl_Ljava_security_cert_X509CRLEntry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='toImpl' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509CRLEntry']]"
		[Register ("toImpl", "(Ljava/security/cert/X509CRLEntry;)Lsun/security/x509/X509CRLEntryImpl;", "")]
		public static unsafe global::Sun.Security.X509.X509CRLEntryImpl ToImpl (global::Java.Security.Cert.X509CRLEntry entry)
		{
			if (id_toImpl_Ljava_security_cert_X509CRLEntry_ == IntPtr.Zero)
				id_toImpl_Ljava_security_cert_X509CRLEntry_ = JNIEnv.GetStaticMethodID (class_ref, "toImpl", "(Ljava/security/cert/X509CRLEntry;)Lsun/security/x509/X509CRLEntryImpl;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (entry);
				global::Sun.Security.X509.X509CRLEntryImpl __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toImpl_Ljava_security_cert_X509CRLEntry_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509CRLEntryImpl __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509CRLEntryImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509CRLEntryImpl']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler")]
		public override unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
