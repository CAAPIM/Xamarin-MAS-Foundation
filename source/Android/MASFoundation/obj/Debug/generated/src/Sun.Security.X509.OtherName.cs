using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='OtherName']"
	[global::Android.Runtime.Register ("sun/security/x509/OtherName", DoNotGenerateAcw=true)]
	public partial class OtherName : global::Java.Lang.Object, global::Sun.Security.X509.IGeneralNameInterface {


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
				return JNIEnv.FindClass ("sun/security/x509/OtherName", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OtherName); }
		}

		protected OtherName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lsun_security_util_ObjectIdentifier_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='OtherName']/constructor[@name='OtherName' and count(parameter)=2 and parameter[1][@type='sun.security.util.ObjectIdentifier'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lsun/security/util/ObjectIdentifier;[B)V", "")]
		public unsafe OtherName (global::Sun.Security.Util.ObjectIdentifier oid, byte[] value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (oid);
				__args [1] = new JValue (native_value);
				if (((object) this).GetType () != typeof (OtherName)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/ObjectIdentifier;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/ObjectIdentifier;[B)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_ObjectIdentifier_arrayB == IntPtr.Zero)
					id_ctor_Lsun_security_util_ObjectIdentifier_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/ObjectIdentifier;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_ObjectIdentifier_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_ObjectIdentifier_arrayB, __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Sun.Security.X509.OtherName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.OtherName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OID);
		}
#pragma warning restore 0169

		static IntPtr id_getOID;
		public virtual unsafe global::Sun.Security.Util.ObjectIdentifier OID {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OtherName']/method[@name='getOID' and count(parameter)=0]"
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
			global::Sun.Security.X509.OtherName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.OtherName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OtherName']/method[@name='getType' and count(parameter)=0]"
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
			global::Sun.Security.X509.OtherName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.OtherName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.IGeneralNameInterface inputName = (global::Sun.Security.X509.IGeneralNameInterface)global::Java.Lang.Object.GetObject<global::Sun.Security.X509.IGeneralNameInterface> (native_inputName, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Constrains (inputName);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_constrains_Lsun_security_x509_GeneralNameInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OtherName']/method[@name='constrains' and count(parameter)=1 and parameter[1][@type='sun.security.x509.GeneralNameInterface']]"
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
			global::Sun.Security.X509.OtherName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.OtherName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OtherName']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
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

		static Delegate cb_getNameValue;
#pragma warning disable 0169
		static Delegate GetGetNameValueHandler ()
		{
			if (cb_getNameValue == null)
				cb_getNameValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNameValue);
			return cb_getNameValue;
		}

		static IntPtr n_GetNameValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.OtherName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.OtherName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetNameValue ());
		}
#pragma warning restore 0169

		static IntPtr id_getNameValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OtherName']/method[@name='getNameValue' and count(parameter)=0]"
		[Register ("getNameValue", "()[B", "GetGetNameValueHandler")]
		public virtual unsafe byte[] GetNameValue ()
		{
			if (id_getNameValue == IntPtr.Zero)
				id_getNameValue = JNIEnv.GetMethodID (class_ref, "getNameValue", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNameValue), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNameValue", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Sun.Security.X509.OtherName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.OtherName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubtreeDepth ();
		}
#pragma warning restore 0169

		static IntPtr id_subtreeDepth;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='OtherName']/method[@name='subtreeDepth' and count(parameter)=0]"
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
