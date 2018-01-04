using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Pkcs {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']"
	[global::Android.Runtime.Register ("sun/security/pkcs/PKCS10Attributes", DoNotGenerateAcw=true)]
	public partial class PKCS10Attributes : global::Java.Lang.Object, global::Sun.Security.Util.IDerEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/pkcs/PKCS10Attributes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKCS10Attributes); }
		}

		protected PKCS10Attributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']/constructor[@name='PKCS10Attributes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PKCS10Attributes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PKCS10Attributes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayLsun_security_pkcs_PKCS10Attribute_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']/constructor[@name='PKCS10Attributes' and count(parameter)=1 and parameter[1][@type='sun.security.pkcs.PKCS10Attribute[]']]"
		[Register (".ctor", "([Lsun/security/pkcs/PKCS10Attribute;)V", "")]
		public unsafe PKCS10Attributes (global::Sun.Security.Pkcs.PKCS10Attribute[] attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_attrs = JNIEnv.NewArray (attrs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_attrs);
				if (((object) this).GetType () != typeof (PKCS10Attributes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lsun/security/pkcs/PKCS10Attribute;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lsun/security/pkcs/PKCS10Attribute;)V", __args);
					return;
				}

				if (id_ctor_arrayLsun_security_pkcs_PKCS10Attribute_ == IntPtr.Zero)
					id_ctor_arrayLsun_security_pkcs_PKCS10Attribute_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lsun/security/pkcs/PKCS10Attribute;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLsun_security_pkcs_PKCS10Attribute_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLsun_security_pkcs_PKCS10Attribute_, __args);
			} finally {
				if (attrs != null) {
					JNIEnv.CopyArray (native_attrs, attrs);
					JNIEnv.DeleteLocalRef (native_attrs);
				}
			}
		}

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']/constructor[@name='PKCS10Attributes' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerInputStream']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;)V", "")]
		public unsafe PKCS10Attributes (global::Sun.Security.Util.DerInputStream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (PKCS10Attributes)) {
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
			global::Sun.Security.Pkcs.PKCS10Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Sun.Security.Pkcs.PKCS10Attribute>.ToLocalJniHandle (__this.Attributes);
		}
#pragma warning restore 0169

		static IntPtr id_getAttributes;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Sun.Security.Pkcs.PKCS10Attribute> Attributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']/method[@name='getAttributes' and count(parameter)=0]"
			[Register ("getAttributes", "()Ljava/util/Collection;", "GetGetAttributesHandler")]
			get {
				if (id_getAttributes == IntPtr.Zero)
					id_getAttributes = JNIEnv.GetMethodID (class_ref, "getAttributes", "()Ljava/util/Collection;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<global::Sun.Security.Pkcs.PKCS10Attribute>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttributes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<global::Sun.Security.Pkcs.PKCS10Attribute>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttributes", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Sun.Security.Pkcs.PKCS10Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Elements);
		}
#pragma warning restore 0169

		static IntPtr id_getElements;
		public virtual unsafe global::Java.Util.IEnumeration Elements {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']/method[@name='getElements' and count(parameter)=0]"
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

		static Delegate cb_deleteAttribute_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteAttribute_Ljava_lang_String_Handler ()
		{
			if (cb_deleteAttribute_Ljava_lang_String_ == null)
				cb_deleteAttribute_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteAttribute_Ljava_lang_String_);
			return cb_deleteAttribute_Ljava_lang_String_;
		}

		static void n_DeleteAttribute_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Sun.Security.Pkcs.PKCS10Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAttribute (name);
		}
#pragma warning restore 0169

		static IntPtr id_deleteAttribute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']/method[@name='deleteAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteAttribute", "(Ljava/lang/String;)V", "GetDeleteAttribute_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteAttribute (string name)
		{
			if (id_deleteAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteAttribute", "(Ljava/lang/String;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAttribute_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAttribute", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_derEncode_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDerEncode_Ljava_io_OutputStream_Handler ()
		{
			if (cb_derEncode_Ljava_io_OutputStream_ == null)
				cb_derEncode_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DerEncode_Ljava_io_OutputStream_);
			return cb_derEncode_Ljava_io_OutputStream_;
		}

		static void n_DerEncode_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.Pkcs.PKCS10Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.DerEncode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_derEncode_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']/method[@name='derEncode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("derEncode", "(Ljava/io/OutputStream;)V", "GetDerEncode_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void DerEncode (global::System.IO.Stream @out)
		{
			if (id_derEncode_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_derEncode_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "derEncode", "(Ljava/io/OutputStream;)V");
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_derEncode_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "derEncode", "(Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		static Delegate cb_encode_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encode_Ljava_io_OutputStream_ == null)
				cb_encode_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_io_OutputStream_);
			return cb_encode_Ljava_io_OutputStream_;
		}

		static void n_Encode_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.Pkcs.PKCS10Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("encode", "(Ljava/io/OutputStream;)V", "GetEncode_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void Encode (global::System.IO.Stream @out)
		{
			if (id_encode_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encode_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/io/OutputStream;)V");
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/io/OutputStream;)V"), __args);
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
			global::Sun.Security.Pkcs.PKCS10Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAttribute (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAttribute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']/method[@name='getAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetAttribute_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetAttribute (string name)
		{
			if (id_getAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_getAttribute_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttribute_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setAttribute_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetAttribute_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setAttribute_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setAttribute_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAttribute_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setAttribute_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetAttribute_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_obj)
		{
			global::Sun.Security.Pkcs.PKCS10Attributes __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.SetAttribute (name, obj);
		}
#pragma warning restore 0169

		static IntPtr id_setAttribute_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attributes']/method[@name='setAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetAttribute_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetAttribute (string name, global::Java.Lang.Object obj)
		{
			if (id_setAttribute_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setAttribute_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (obj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAttribute_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
