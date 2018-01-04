using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='CRLExtensions']"
	[global::Android.Runtime.Register ("sun/security/x509/CRLExtensions", DoNotGenerateAcw=true)]
	public partial class CRLExtensions : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/CRLExtensions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CRLExtensions); }
		}

		protected CRLExtensions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='CRLExtensions']/constructor[@name='CRLExtensions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CRLExtensions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CRLExtensions)) {
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

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='CRLExtensions']/constructor[@name='CRLExtensions' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerInputStream']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;)V", "")]
		public unsafe CRLExtensions (global::Sun.Security.Util.DerInputStream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (CRLExtensions)) {
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
			global::Sun.Security.X509.CRLExtensions __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CRLExtensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUnsupportedCriticalExtension;
		}
#pragma warning restore 0169

		static IntPtr id_hasUnsupportedCriticalExtension;
		public virtual unsafe bool HasUnsupportedCriticalExtension {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='CRLExtensions']/method[@name='hasUnsupportedCriticalExtension' and count(parameter)=0]"
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

		static Delegate cb_delete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_ == null)
				cb_delete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Ljava_lang_String_);
			return cb_delete_Ljava_lang_String_;
		}

		static void n_Delete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alias)
		{
			global::Sun.Security.X509.CRLExtensions __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CRLExtensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
			__this.Delete (alias);
		}
#pragma warning restore 0169

		static IntPtr id_delete_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='CRLExtensions']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)V", "GetDelete_Ljava_lang_String_Handler")]
		public virtual unsafe void Delete (string alias)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;)V");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_alias);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

		static Delegate cb_encode_Ljava_io_OutputStream_Z;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_io_OutputStream_ZHandler ()
		{
			if (cb_encode_Ljava_io_OutputStream_Z == null)
				cb_encode_Ljava_io_OutputStream_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Encode_Ljava_io_OutputStream_Z);
			return cb_encode_Ljava_io_OutputStream_Z;
		}

		static void n_Encode_Ljava_io_OutputStream_Z (IntPtr jnienv, IntPtr native__this, IntPtr native__out, bool isExplicit)
		{
			global::Sun.Security.X509.CRLExtensions __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CRLExtensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out, isExplicit);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_io_OutputStream_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='CRLExtensions']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='boolean']]"
		[Register ("encode", "(Ljava/io/OutputStream;Z)V", "GetEncode_Ljava_io_OutputStream_ZHandler")]
		public virtual unsafe void Encode (global::System.IO.Stream @out, bool isExplicit)
		{
			if (id_encode_Ljava_io_OutputStream_Z == IntPtr.Zero)
				id_encode_Ljava_io_OutputStream_Z = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/io/OutputStream;Z)V");
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__out);
				__args [1] = new JValue (isExplicit);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_io_OutputStream_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/io/OutputStream;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
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

		static void n_Set_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alias, IntPtr native_obj)
		{
			global::Sun.Security.X509.CRLExtensions __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.CRLExtensions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string alias = JNIEnv.GetString (native_alias, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			__this.Set (alias, obj);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='CRLExtensions']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("set", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSet_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void Set (string alias, global::Java.Lang.Object obj)
		{
			if (id_set_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_set_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_alias = JNIEnv.NewString (alias);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_alias);
				__args [1] = new JValue (obj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_alias);
			}
		}

	}
}
