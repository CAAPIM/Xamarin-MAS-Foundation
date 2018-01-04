using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']"
	[global::Android.Runtime.Register ("sun/security/x509/ReasonFlags", DoNotGenerateAcw=true)]
	public partial class ReasonFlags : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/field[@name='AA_COMPROMISE']"
		[Register ("AA_COMPROMISE")]
		public const string AaCompromise = (string) "aa_compromise";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/field[@name='AFFILIATION_CHANGED']"
		[Register ("AFFILIATION_CHANGED")]
		public const string AffiliationChanged = (string) "affiliation_changed";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/field[@name='CA_COMPROMISE']"
		[Register ("CA_COMPROMISE")]
		public const string CaCompromise = (string) "ca_compromise";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/field[@name='CERTIFICATE_HOLD']"
		[Register ("CERTIFICATE_HOLD")]
		public const string CertificateHold = (string) "certificate_hold";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/field[@name='CESSATION_OF_OPERATION']"
		[Register ("CESSATION_OF_OPERATION")]
		public const string CessationOfOperation = (string) "cessation_of_operation";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/field[@name='KEY_COMPROMISE']"
		[Register ("KEY_COMPROMISE")]
		public const string KeyCompromise = (string) "key_compromise";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/field[@name='PRIVILEGE_WITHDRAWN']"
		[Register ("PRIVILEGE_WITHDRAWN")]
		public const string PrivilegeWithdrawn = (string) "privilege_withdrawn";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/field[@name='SUPERSEDED']"
		[Register ("SUPERSEDED")]
		public const string Superseded = (string) "superseded";

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/field[@name='UNUSED']"
		[Register ("UNUSED")]
		public const string Unused = (string) "unused";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/ReasonFlags", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReasonFlags); }
		}

		protected ReasonFlags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/constructor[@name='ReasonFlags' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register (".ctor", "([Z)V", "")]
		public unsafe ReasonFlags (bool[] reasons)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_reasons = JNIEnv.NewArray (reasons);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_reasons);
				if (((object) this).GetType () != typeof (ReasonFlags)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Z)V", __args);
					return;
				}

				if (id_ctor_arrayZ == IntPtr.Zero)
					id_ctor_arrayZ = JNIEnv.GetMethodID (class_ref, "<init>", "([Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayZ, __args);
			} finally {
				if (reasons != null) {
					JNIEnv.CopyArray (native_reasons, reasons);
					JNIEnv.DeleteLocalRef (native_reasons);
				}
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/constructor[@name='ReasonFlags' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe ReasonFlags (byte[] reasons)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_reasons = JNIEnv.NewArray (reasons);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_reasons);
				if (((object) this).GetType () != typeof (ReasonFlags)) {
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
				if (reasons != null) {
					JNIEnv.CopyArray (native_reasons, reasons);
					JNIEnv.DeleteLocalRef (native_reasons);
				}
			}
		}

		static IntPtr id_ctor_Lsun_security_util_BitArray_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/constructor[@name='ReasonFlags' and count(parameter)=1 and parameter[1][@type='sun.security.util.BitArray']]"
		[Register (".ctor", "(Lsun/security/util/BitArray;)V", "")]
		public unsafe ReasonFlags (global::Sun.Security.Util.BitArray reasons)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (reasons);
				if (((object) this).GetType () != typeof (ReasonFlags)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/BitArray;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/BitArray;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_BitArray_ == IntPtr.Zero)
					id_ctor_Lsun_security_util_BitArray_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/BitArray;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_BitArray_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_BitArray_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/constructor[@name='ReasonFlags' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerInputStream']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;)V", "")]
		public unsafe ReasonFlags (global::Sun.Security.Util.DerInputStream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (ReasonFlags)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/DerInputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/DerInputStream;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_DerInputStream_ == IntPtr.Zero)
					id_ctor_Lsun_security_util_DerInputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/DerInputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_DerInputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_DerInputStream_, __args);
			} finally {
			}
		}

		static Delegate cb_getElements;
#pragma warning disable 0169
		static Delegate GetGetElementsHandler ()
		{
			if (cb_getElements == null)
				cb_getElements = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetElements);
			return cb_getElements;
		}

		static IntPtr n_GetElements (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.ReasonFlags __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ReasonFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Elements);
		}
#pragma warning restore 0169

		static IntPtr id_getElements;
		public virtual unsafe global::Java.Util.IEnumeration Elements {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/method[@name='getElements' and count(parameter)=0]"
			[Register ("getElements", "()Ljava/util/Enumeration;", "GetGetElementsHandler")]
			get {
				if (id_getElements == IntPtr.Zero)
					id_getElements = JNIEnv.GetMethodID (class_ref, "getElements", "()Ljava/util/Enumeration;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getElements), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElements", "()Ljava/util/Enumeration;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_delete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_ == null)
				cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Ljava_lang_String_);
			return cb_delete_Ljava_lang_String_;
		}

		static void n_Delete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Sun.Security.X509.ReasonFlags __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ReasonFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Delete (name);
		}
#pragma warning restore 0169

		static IntPtr id_delete_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)V", "GetDelete_Ljava_lang_String_Handler")]
		public virtual unsafe void Delete (string name)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
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
			global::Sun.Security.X509.ReasonFlags __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ReasonFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
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

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Sun.Security.X509.ReasonFlags __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ReasonFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (string name)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFlags);
			return cb_getFlags;
		}

		static IntPtr n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.ReasonFlags __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ReasonFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFlags ());
		}
#pragma warning restore 0169

		static IntPtr id_getFlags;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/method[@name='getFlags' and count(parameter)=0]"
		[Register ("getFlags", "()[Z", "GetGetFlagsHandler")]
		public virtual unsafe bool[] GetFlags ()
		{
			if (id_getFlags == IntPtr.Zero)
				id_getFlags = JNIEnv.GetMethodID (class_ref, "getFlags", "()[Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFlags), JniHandleOwnership.TransferLocalRef, typeof (bool));
				else
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlags", "()[Z")), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

		static Delegate cb_set_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_set_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_set_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_lang_Object_);
			return cb_set_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Set_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_obj)
		{
			global::Sun.Security.X509.ReasonFlags __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ReasonFlags> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.Set (name, obj);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='ReasonFlags']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("set", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSet_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Set (string name, global::Java.Lang.Object obj)
		{
			if (id_set_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (obj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
