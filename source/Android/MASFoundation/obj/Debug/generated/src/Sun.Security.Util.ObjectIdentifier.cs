using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.util']/class[@name='ObjectIdentifier']"
	[global::Android.Runtime.Register ("sun/security/util/ObjectIdentifier", DoNotGenerateAcw=true)]
	public sealed partial class ObjectIdentifier : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/util/ObjectIdentifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectIdentifier); }
		}

		internal ObjectIdentifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='ObjectIdentifier']/constructor[@name='ObjectIdentifier' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register (".ctor", "([I)V", "")]
		public unsafe ObjectIdentifier (int[] values)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				if (((object) this).GetType () != typeof (ObjectIdentifier)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([I)V", __args);
					return;
				}

				if (id_ctor_arrayI == IntPtr.Zero)
					id_ctor_arrayI = JNIEnv.GetMethodID (class_ref, "<init>", "([I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayI, __args);
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='ObjectIdentifier']/constructor[@name='ObjectIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ObjectIdentifier (string oid)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_oid = JNIEnv.NewString (oid);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_oid);
				if (((object) this).GetType () != typeof (ObjectIdentifier)) {
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
				JNIEnv.DeleteLocalRef (native_oid);
			}
		}

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='ObjectIdentifier']/constructor[@name='ObjectIdentifier' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerInputStream']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;)V", "")]
		public unsafe ObjectIdentifier (global::Sun.Security.Util.DerInputStream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (ObjectIdentifier)) {
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

		static IntPtr id_equals_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='ObjectIdentifier']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Obsolete (@"deprecated")]
		[Register ("equals", "(Lsun/security/util/ObjectIdentifier;)Z", "")]
		public unsafe bool Equals (global::Sun.Security.Util.ObjectIdentifier other)
		{
			if (id_equals_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
				id_equals_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetMethodID (class_ref, "equals", "(Lsun/security/util/ObjectIdentifier;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Lsun_security_util_ObjectIdentifier_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newInternal_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='ObjectIdentifier']/method[@name='newInternal' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("newInternal", "([I)Lsun/security/util/ObjectIdentifier;", "")]
		public static unsafe global::Sun.Security.Util.ObjectIdentifier NewInternal (int[] values)
		{
			if (id_newInternal_arrayI == IntPtr.Zero)
				id_newInternal_arrayI = JNIEnv.GetStaticMethodID (class_ref, "newInternal", "([I)Lsun/security/util/ObjectIdentifier;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				global::Sun.Security.Util.ObjectIdentifier __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInternal_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_precedes_Lsun_security_util_ObjectIdentifier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='ObjectIdentifier']/method[@name='precedes' and count(parameter)=1 and parameter[1][@type='sun.security.util.ObjectIdentifier']]"
		[Register ("precedes", "(Lsun/security/util/ObjectIdentifier;)Z", "")]
		public unsafe bool Precedes (global::Sun.Security.Util.ObjectIdentifier other)
		{
			if (id_precedes_Lsun_security_util_ObjectIdentifier_ == IntPtr.Zero)
				id_precedes_Lsun_security_util_ObjectIdentifier_ = JNIEnv.GetMethodID (class_ref, "precedes", "(Lsun/security/util/ObjectIdentifier;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_precedes_Lsun_security_util_ObjectIdentifier_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
