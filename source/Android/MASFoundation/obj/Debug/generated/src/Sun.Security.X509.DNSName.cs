using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='DNSName']"
	[global::Android.Runtime.Register ("sun/security/x509/DNSName", DoNotGenerateAcw=true)]
	public partial class DNSName : global::Java.Lang.Object, global::Sun.Security.X509.IGeneralNameInterface {


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
				return JNIEnv.FindClass ("sun/security/x509/DNSName", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DNSName); }
		}

		protected DNSName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='DNSName']/constructor[@name='DNSName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DNSName (string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				if (((object) this).GetType () != typeof (DNSName)) {
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
				JNIEnv.DeleteLocalRef (native_name);
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
			global::Sun.Security.X509.DNSName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.DNSName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='DNSName']/method[@name='getName' and count(parameter)=0]"
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
			global::Sun.Security.X509.DNSName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.DNSName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='DNSName']/method[@name='getType' and count(parameter)=0]"
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
			global::Sun.Security.X509.DNSName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.DNSName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.IGeneralNameInterface inputName = (global::Sun.Security.X509.IGeneralNameInterface)global::Java.Lang.Object.GetObject<global::Sun.Security.X509.IGeneralNameInterface> (native_inputName, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Constrains (inputName);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_constrains_Lsun_security_x509_GeneralNameInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='DNSName']/method[@name='constrains' and count(parameter)=1 and parameter[1][@type='sun.security.x509.GeneralNameInterface']]"
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
			global::Sun.Security.X509.DNSName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.DNSName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='DNSName']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
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
			global::Sun.Security.X509.DNSName __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.DNSName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubtreeDepth ();
		}
#pragma warning restore 0169

		static IntPtr id_subtreeDepth;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='DNSName']/method[@name='subtreeDepth' and count(parameter)=0]"
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
