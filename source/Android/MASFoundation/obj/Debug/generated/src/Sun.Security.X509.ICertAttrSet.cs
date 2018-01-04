using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='sun.security.x509']/interface[@name='CertAttrSet']"
	[Register ("sun/security/x509/CertAttrSet", "", "Sun.Security.X509.ICertAttrSetInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ICertAttrSet : IJavaObject {

		global::Java.Util.IEnumeration Elements {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='CertAttrSet']/method[@name='getElements' and count(parameter)=0]"
			[Register ("getElements", "()Ljava/util/Enumeration;", "GetGetElementsHandler:Sun.Security.X509.ICertAttrSetInvoker, MASFoundation")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='CertAttrSet']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Sun.Security.X509.ICertAttrSetInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='CertAttrSet']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)V", "GetDelete_Ljava_lang_String_Handler:Sun.Security.X509.ICertAttrSetInvoker, MASFoundation")]
		void Delete (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='CertAttrSet']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("encode", "(Ljava/io/OutputStream;)V", "GetEncode_Ljava_io_OutputStream_Handler:Sun.Security.X509.ICertAttrSetInvoker, MASFoundation")]
		void Encode (global::System.IO.Stream p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='CertAttrSet']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler:Sun.Security.X509.ICertAttrSetInvoker, MASFoundation")]
		global::Java.Lang.Object Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='CertAttrSet']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("set", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSet_Ljava_lang_String_Ljava_lang_Object_Handler:Sun.Security.X509.ICertAttrSetInvoker, MASFoundation")]
		void Set (string p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/interface[@name='CertAttrSet']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler:Sun.Security.X509.ICertAttrSetInvoker, MASFoundation")]
		string ToString ();

	}

	[global::Android.Runtime.Register ("sun/security/x509/CertAttrSet", DoNotGenerateAcw=true)]
	internal class ICertAttrSetInvoker : global::Java.Lang.Object, ICertAttrSet {

		static IntPtr java_class_ref = JNIEnv.FindClass ("sun/security/x509/CertAttrSet");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICertAttrSetInvoker); }
		}

		IntPtr class_ref;

		public static ICertAttrSet GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICertAttrSet> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "sun.security.x509.CertAttrSet"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICertAttrSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Sun.Security.X509.ICertAttrSet __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ICertAttrSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Elements);
		}
#pragma warning restore 0169

		IntPtr id_getElements;
		public unsafe global::Java.Util.IEnumeration Elements {
			get {
				if (id_getElements == IntPtr.Zero)
					id_getElements = JNIEnv.GetMethodID (class_ref, "getElements", "()Ljava/util/Enumeration;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.IEnumeration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getElements), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Security.X509.ICertAttrSet __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ICertAttrSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
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

		static void n_Delete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Security.X509.ICertAttrSet __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ICertAttrSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		IntPtr id_delete_Ljava_lang_String_;
		public unsafe void Delete (string p0)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_encode_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_io_OutputStream_Handler ()
		{
			if (cb_encode_Ljava_io_OutputStream_ == null)
				cb_encode_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_io_OutputStream_);
			return cb_encode_Ljava_io_OutputStream_;
		}

		static void n_Encode_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Security.X509.ICertAttrSet __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ICertAttrSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Encode (p0);
		}
#pragma warning restore 0169

		IntPtr id_encode_Ljava_io_OutputStream_;
		public unsafe void Encode (global::System.IO.Stream p0)
		{
			if (id_encode_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_encode_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_io_OutputStream_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Security.X509.ICertAttrSet __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ICertAttrSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe global::Java.Lang.Object Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_set_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_set_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_set_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_lang_Object_);
			return cb_set_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Set_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Sun.Security.X509.ICertAttrSet __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ICertAttrSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_set_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void Set (string p0, global::Java.Lang.Object p1)
		{
			if (id_set_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Sun.Security.X509.ICertAttrSet __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.ICertAttrSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
