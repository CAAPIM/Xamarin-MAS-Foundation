using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Pkcs {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']"
	[global::Android.Runtime.Register ("sun/security/pkcs/PKCS9Attributes", DoNotGenerateAcw=true)]
	public partial class PKCS9Attributes : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/pkcs/PKCS9Attributes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKCS9Attributes); }
		}

		protected PKCS9Attributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLsun_security_pkcs_PKCS9Attribute_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/constructor[@name='PKCS9Attributes' and count(parameter)=1 and parameter[1][@type='sun.security.pkcs.PKCS9Attribute[]']]"
		[Register (".ctor", "([Lsun/security/pkcs/PKCS9Attribute;)V", "")]
		public unsafe PKCS9Attributes (global::Sun.Security.Pkcs.PKCS9Attribute[] attribs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_attribs = JNIEnv.NewArray (attribs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_attribs);
				if (((object) this).GetType () != typeof (PKCS9Attributes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lsun/security/pkcs/PKCS9Attribute;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lsun/security/pkcs/PKCS9Attribute;)V", __args);
					return;
				}

				if (id_ctor_arrayLsun_security_pkcs_PKCS9Attribute_ == IntPtr.Zero)
					id_ctor_arrayLsun_security_pkcs_PKCS9Attribute_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lsun/security/pkcs/PKCS9Attribute;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLsun_security_pkcs_PKCS9Attribute_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLsun_security_pkcs_PKCS9Attribute_, __args);
			} finally {
				if (attribs != null) {
					JNIEnv.CopyArray (native_attribs, attribs);
					JNIEnv.DeleteLocalRef (native_attribs);
				}
			}
		}

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/constructor[@name='PKCS9Attributes' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerInputStream']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;)V", "")]
		public unsafe PKCS9Attributes (global::Sun.Security.Util.DerInputStream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (PKCS9Attributes)) {
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

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/constructor[@name='PKCS9Attributes' and count(parameter)=2 and parameter[1][@type='sun.security.util.DerInputStream'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;Z)V", "")]
		public unsafe PKCS9Attributes (global::Sun.Security.Util.DerInputStream @in, bool ignoreUnsupportedAttributes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@in);
				__args [1] = new JValue (ignoreUnsupportedAttributes);
				if (((object) this).GetType () != typeof (PKCS9Attributes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/DerInputStream;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/DerInputStream;Z)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_DerInputStream_Z == IntPtr.Zero)
					id_ctor_Lsun_security_util_DerInputStream_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/DerInputStream;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_DerInputStream_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_DerInputStream_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayLsun_security_util_ObjectIdentifier_Lsun_security_util_DerInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/constructor[@name='PKCS9Attributes' and count(parameter)=2 and parameter[1][@type='sun.security.util.ObjectIdentifier[]'] and parameter[2][@type='sun.security.util.DerInputStream']]"
		[Register (".ctor", "([Lsun/security/util/ObjectIdentifier;Lsun/security/util/DerInputStream;)V", "")]
		public unsafe PKCS9Attributes (global::Sun.Security.Util.ObjectIdentifier[] permittedAttributes, global::Sun.Security.Util.DerInputStream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_permittedAttributes = JNIEnv.NewArray (permittedAttributes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_permittedAttributes);
				__args [1] = new JValue (@in);
				if (((object) this).GetType () != typeof (PKCS9Attributes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lsun/security/util/ObjectIdentifier;Lsun/security/util/DerInputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lsun/security/util/ObjectIdentifier;Lsun/security/util/DerInputStream;)V", __args);
					return;
				}

				if (id_ctor_arrayLsun_security_util_ObjectIdentifier_Lsun_security_util_DerInputStream_ == IntPtr.Zero)
					id_ctor_arrayLsun_security_util_ObjectIdentifier_Lsun_security_util_DerInputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lsun/security/util/ObjectIdentifier;Lsun/security/util/DerInputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLsun_security_util_ObjectIdentifier_Lsun_security_util_DerInputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLsun_security_util_ObjectIdentifier_Lsun_security_util_DerInputStream_, __args);
			} finally {
				if (permittedAttributes != null) {
					JNIEnv.CopyArray (native_permittedAttributes, permittedAttributes);
					JNIEnv.DeleteLocalRef (native_permittedAttributes);
				}
			}
		}

		static Delegate cb_encode_BLjava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_BLjava_io_OutputStream_Handler ()
		{
			if (cb_encode_BLjava_io_OutputStream_ == null)
				cb_encode_BLjava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte, IntPtr>) n_Encode_BLjava_io_OutputStream_);
			return cb_encode_BLjava_io_OutputStream_;
		}

		static void n_Encode_BLjava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, sbyte tag, IntPtr native__out)
		{
			global::Sun.Security.Pkcs.PKCS9Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (tag, @out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_BLjava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("encode", "(BLjava/io/OutputStream;)V", "GetEncode_BLjava_io_OutputStream_Handler")]
		public virtual unsafe void Encode (sbyte tag, global::System.IO.Stream @out)
		{
			if (id_encode_BLjava_io_OutputStream_ == IntPtr.Zero)
				id_encode_BLjava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(BLjava/io/OutputStream;)V");
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (tag);
				__args [1] = new JValue (native__out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_BLjava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(BLjava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		static Delegate cb_getAttribute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAttribute_Ljava_lang_String_Handler ()
		{
			if (cb_getAttribute_Ljava_lang_String_ == null)
				cb_getAttribute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAttribute_Ljava_lang_String_);
			return cb_getAttribute_Ljava_lang_String_;
		}

		static IntPtr n_GetAttribute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Sun.Security.Pkcs.PKCS9Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAttribute (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAttribute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/method[@name='getAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttribute", "(Ljava/lang/String;)Lsun/security/pkcs/PKCS9Attribute;", "GetGetAttribute_Ljava_lang_String_Handler")]
		public virtual unsafe global::Sun.Security.Pkcs.PKCS9Attribute GetAttribute (string name)
		{
			if (id_getAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_getAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAttribute", "(Ljava/lang/String;)Lsun/security/pkcs/PKCS9Attribute;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				global::Sun.Security.Pkcs.PKCS9Attribute __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attribute> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttribute_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attribute> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttribute", "(Ljava/lang/String;)Lsun/security/pkcs/PKCS9Attribute;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getAttribute_Lsun_security_util_ObjectIdentifier_;
#pragma warning disable 0169
		static Delegate GetGetAttribute_Lsun_security_util_ObjectIdentifier_Handler ()
		{
			if (cb_getAttribute_Lsun_security_util_ObjectIdentifier_ == null)
				cb_getAttribute_Lsun_security_util_ObjectIdentifier_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAttribute_Lsun_security_util_ObjectIdentifier_);
			return cb_getAttribute_Lsun_security_util_ObjectIdentifier_;
		}

		static IntPtr n_GetAttribute_Lsun_security_util_ObjectIdentifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oid)
		{
			global::Sun.Security.Pkcs.PKCS9Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.ObjectIdentifier oid = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (native_oid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAttribute (oid));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAttribute_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/method[@name='getAttribute' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Register ("getAttribute", "(Lsun/security/util/ObjectIdentifier;)Lsun/security/pkcs/PKCS9Attribute;", "GetGetAttribute_Lsun_security_util_ObjectIdentifier_Handler")]
		public virtual unsafe global::Sun.Security.Pkcs.PKCS9Attribute GetAttribute (global::Sun.Security.Util.ObjectIdentifier oid)
		{
			if (id_getAttribute_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
				id_getAttribute_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetMethodID (class_ref, "getAttribute", "(Lsun/security/util/ObjectIdentifier;)Lsun/security/pkcs/PKCS9Attribute;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (oid);

				global::Sun.Security.Pkcs.PKCS9Attribute __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attribute> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttribute_Lsun_security_util_ObjectIdentifier_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attribute> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttribute", "(Lsun/security/util/ObjectIdentifier;)Lsun/security/pkcs/PKCS9Attribute;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAttributeValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAttributeValue_Ljava_lang_String_Handler ()
		{
			if (cb_getAttributeValue_Ljava_lang_String_ == null)
				cb_getAttributeValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAttributeValue_Ljava_lang_String_);
			return cb_getAttributeValue_Ljava_lang_String_;
		}

		static IntPtr n_GetAttributeValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Sun.Security.Pkcs.PKCS9Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAttributeValue (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAttributeValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/method[@name='getAttributeValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttributeValue", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetAttributeValue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetAttributeValue (string name)
		{
			if (id_getAttributeValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getAttributeValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAttributeValue", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttributeValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttributeValue", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getAttributeValue_Lsun_security_util_ObjectIdentifier_;
#pragma warning disable 0169
		static Delegate GetGetAttributeValue_Lsun_security_util_ObjectIdentifier_Handler ()
		{
			if (cb_getAttributeValue_Lsun_security_util_ObjectIdentifier_ == null)
				cb_getAttributeValue_Lsun_security_util_ObjectIdentifier_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAttributeValue_Lsun_security_util_ObjectIdentifier_);
			return cb_getAttributeValue_Lsun_security_util_ObjectIdentifier_;
		}

		static IntPtr n_GetAttributeValue_Lsun_security_util_ObjectIdentifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oid)
		{
			global::Sun.Security.Pkcs.PKCS9Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.ObjectIdentifier oid = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (native_oid, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAttributeValue (oid));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAttributeValue_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/method[@name='getAttributeValue' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Register ("getAttributeValue", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/Object;", "GetGetAttributeValue_Lsun_security_util_ObjectIdentifier_Handler")]
		public virtual unsafe global::Java.Lang.Object GetAttributeValue (global::Sun.Security.Util.ObjectIdentifier oid)
		{
			if (id_getAttributeValue_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
				id_getAttributeValue_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetMethodID (class_ref, "getAttributeValue", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (oid);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttributeValue_Lsun_security_util_ObjectIdentifier_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttributeValue", "(Lsun/security/util/ObjectIdentifier;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Sun.Security.Pkcs.PKCS9Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAttributes ());
		}
#pragma warning restore 0169

		static IntPtr id_getAttributes;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/method[@name='getAttributes' and count(parameter)=0]"
		[Register ("getAttributes", "()[Lsun/security/pkcs/PKCS9Attribute;", "GetGetAttributesHandler")]
		public virtual unsafe global::Sun.Security.Pkcs.PKCS9Attribute[] GetAttributes ()
		{
			if (id_getAttributes == IntPtr.Zero)
				id_getAttributes = JNIEnv.GetMethodID (class_ref, "getAttributes", "()[Lsun/security/pkcs/PKCS9Attribute;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Sun.Security.Pkcs.PKCS9Attribute[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttributes), JniHandleOwnership.TransferLocalRef, typeof (global::Sun.Security.Pkcs.PKCS9Attribute));
				else
					return (global::Sun.Security.Pkcs.PKCS9Attribute[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttributes", "()[Lsun/security/pkcs/PKCS9Attribute;")), JniHandleOwnership.TransferLocalRef, typeof (global::Sun.Security.Pkcs.PKCS9Attribute));
			} finally {
			}
		}

		static Delegate cb_getDerEncoding;
#pragma warning disable 0169
		static Delegate GetGetDerEncodingHandler ()
		{
			if (cb_getDerEncoding == null)
				cb_getDerEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDerEncoding);
			return cb_getDerEncoding;
		}

		static IntPtr n_GetDerEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.PKCS9Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS9Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDerEncoding ());
		}
#pragma warning restore 0169

		static IntPtr id_getDerEncoding;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS9Attributes']/method[@name='getDerEncoding' and count(parameter)=0]"
		[Register ("getDerEncoding", "()[B", "GetGetDerEncodingHandler")]
		public virtual unsafe byte[] GetDerEncoding ()
		{
			if (id_getDerEncoding == IntPtr.Zero)
				id_getDerEncoding = JNIEnv.GetMethodID (class_ref, "getDerEncoding", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDerEncoding), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDerEncoding", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
