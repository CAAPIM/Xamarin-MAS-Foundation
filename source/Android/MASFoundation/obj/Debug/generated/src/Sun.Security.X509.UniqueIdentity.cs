using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='UniqueIdentity']"
	[global::Android.Runtime.Register ("sun/security/x509/UniqueIdentity", DoNotGenerateAcw=true)]
	public partial class UniqueIdentity : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/UniqueIdentity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UniqueIdentity); }
		}

		protected UniqueIdentity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='UniqueIdentity']/constructor[@name='UniqueIdentity' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe UniqueIdentity (byte[] id)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewArray (id);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_id);
				if (((object) this).GetType () != typeof (UniqueIdentity)) {
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
				if (id != null) {
					JNIEnv.CopyArray (native_id, id);
					JNIEnv.DeleteLocalRef (native_id);
				}
			}
		}

		static IntPtr id_ctor_Lsun_security_util_BitArray_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='UniqueIdentity']/constructor[@name='UniqueIdentity' and count(parameter)=1 and parameter[1][@type='sun.security.util.BitArray']]"
		[Register (".ctor", "(Lsun/security/util/BitArray;)V", "")]
		public unsafe UniqueIdentity (global::Sun.Security.Util.BitArray id)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (id);
				if (((object) this).GetType () != typeof (UniqueIdentity)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='UniqueIdentity']/constructor[@name='UniqueIdentity' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerInputStream']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;)V", "")]
		public unsafe UniqueIdentity (global::Sun.Security.Util.DerInputStream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (UniqueIdentity)) {
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

		static Delegate cb_encode_Lsun_security_util_DerOutputStream_B;
#pragma warning disable 0169
		static Delegate GetEncode_Lsun_security_util_DerOutputStream_BHandler ()
		{
			if (cb_encode_Lsun_security_util_DerOutputStream_B == null)
				cb_encode_Lsun_security_util_DerOutputStream_B = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, sbyte>) n_Encode_Lsun_security_util_DerOutputStream_B);
			return cb_encode_Lsun_security_util_DerOutputStream_B;
		}

		static void n_Encode_Lsun_security_util_DerOutputStream_B (IntPtr jnienv, IntPtr native__this, IntPtr native__out, sbyte tag)
		{
			global::Sun.Security.X509.UniqueIdentity __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.UniqueIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out, tag);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='UniqueIdentity']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='sun.security.util.DerOutputStream'] and parameter[2][@type='byte']]"
		[Register ("encode", "(Lsun/security/util/DerOutputStream;B)V", "GetEncode_Lsun_security_util_DerOutputStream_BHandler")]
		public virtual unsafe void Encode (global::Sun.Security.Util.DerOutputStream @out, sbyte tag)
		{
			if (id_encode_Lsun_security_util_DerOutputStream_B == IntPtr.Zero)
				id_encode_Lsun_security_util_DerOutputStream_B = JNIEnv.GetMethodID (class_ref, "encode", "(Lsun/security/util/DerOutputStream;B)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@out);
				__args [1] = new JValue (tag);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Lsun_security_util_DerOutputStream_B, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Lsun/security/util/DerOutputStream;B)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.UniqueIdentity __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.UniqueIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetId ());
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='UniqueIdentity']/method[@name='getId' and count(parameter)=0]"
		[Register ("getId", "()[Z", "GetGetIdHandler")]
		public virtual unsafe bool[] GetId ()
		{
			if (id_getId == IntPtr.Zero)
				id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()[Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef, typeof (bool));
				else
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()[Z")), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

	}
}
