using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	[Register ("sun/security/x509/GeneralNameInterface", DoNotGenerateAcw=true)]
	public abstract class GeneralNameInterface : Java.Lang.Object {

		internal GeneralNameInterface ()
		{
		}

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

	[Register ("sun/security/x509/GeneralNameInterface", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'GeneralNameInterface' type. This type will be removed in a future release.")]
	public abstract class GeneralNameInterfaceConsts : GeneralNameInterface {

		private GeneralNameInterfaceConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']"
	[Register ("sun/security/x509/GeneralNameInterface", "", "Sun.Security.X509.IGeneralNameInterfaceInvoker")]
	public partial interface IGeneralNameInterface : IJavaObject {

		int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler:Sun.Security.X509.IGeneralNameInterfaceInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/method[@name='constrains' and count(parameter)=1 and parameter[1][@type='sun.security.x509.GeneralNameInterface']]"
		[Register ("constrains", "(Lsun/security/x509/GeneralNameInterface;)I", "GetConstrains_Lsun_security_x509_GeneralNameInterface_Handler:Sun.Security.X509.IGeneralNameInterfaceInvoker, MASFoundation")]
		int Constrains (global::Sun.Security.X509.IGeneralNameInterface p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
		[Register ("encode", "(Lsun/security/util/DerOutputStream;)V", "GetEncode_Lsun_security_util_DerOutputStream_Handler:Sun.Security.X509.IGeneralNameInterfaceInvoker, MASFoundation")]
		void Encode (global::Sun.Security.Util.DerOutputStream p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='GeneralNameInterface']/method[@name='subtreeDepth' and count(parameter)=0]"
		[Register ("subtreeDepth", "()I", "GetSubtreeDepthHandler:Sun.Security.X509.IGeneralNameInterfaceInvoker, MASFoundation")]
		int SubtreeDepth ();

	}

	[global::Android.Runtime.Register ("sun/security/x509/GeneralNameInterface", DoNotGenerateAcw=true)]
	internal class IGeneralNameInterfaceInvoker : global::Java.Lang.Object, IGeneralNameInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("sun/security/x509/GeneralNameInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IGeneralNameInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static IGeneralNameInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGeneralNameInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "sun.security.x509.GeneralNameInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGeneralNameInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Sun.Security.X509.IGeneralNameInterface __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.IGeneralNameInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe int Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
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

		static int n_Constrains_Lsun_security_x509_GeneralNameInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Security.X509.IGeneralNameInterface __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.IGeneralNameInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.IGeneralNameInterface p0 = (global::Sun.Security.X509.IGeneralNameInterface)global::Java.Lang.Object.GetObject<global::Sun.Security.X509.IGeneralNameInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Constrains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_constrains_Lsun_security_x509_GeneralNameInterface_;
		public unsafe int Constrains (global::Sun.Security.X509.IGeneralNameInterface p0)
		{
			if (id_constrains_Lsun_security_x509_GeneralNameInterface_ == IntPtr.Zero)
				id_constrains_Lsun_security_x509_GeneralNameInterface_ = JNIEnv.GetMethodID (class_ref, "constrains", "(Lsun/security/x509/GeneralNameInterface;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_constrains_Lsun_security_x509_GeneralNameInterface_, __args);
			return __ret;
		}

		static Delegate cb_encode_Lsun_security_util_DerOutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Lsun_security_util_DerOutputStream_Handler ()
		{
			if (cb_encode_Lsun_security_util_DerOutputStream_ == null)
				cb_encode_Lsun_security_util_DerOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Encode_Lsun_security_util_DerOutputStream_);
			return cb_encode_Lsun_security_util_DerOutputStream_;
		}

		static void n_Encode_Lsun_security_util_DerOutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Security.X509.IGeneralNameInterface __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.IGeneralNameInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream p0 = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		public unsafe void Encode (global::Sun.Security.Util.DerOutputStream p0)
		{
			if (id_encode_Lsun_security_util_DerOutputStream_ == IntPtr.Zero)
				id_encode_Lsun_security_util_DerOutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lsun/security/util/DerOutputStream;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Lsun_security_util_DerOutputStream_, __args);
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
			global::Sun.Security.X509.IGeneralNameInterface __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.IGeneralNameInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubtreeDepth ();
		}
#pragma warning restore 0169

		IntPtr id_subtreeDepth;
		public unsafe int SubtreeDepth ()
		{
			if (id_subtreeDepth == IntPtr.Zero)
				id_subtreeDepth = JNIEnv.GetMethodID (class_ref, "subtreeDepth", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_subtreeDepth);
		}

	}

}
