using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='KeyIdentifier']"
	[global::Android.Runtime.Register ("sun/security/x509/KeyIdentifier", DoNotGenerateAcw=true)]
	public partial class KeyIdentifier : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/KeyIdentifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeyIdentifier); }
		}

		protected KeyIdentifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='KeyIdentifier']/constructor[@name='KeyIdentifier' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe KeyIdentifier (byte[] octetString)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_octetString = JNIEnv.NewArray (octetString);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_octetString);
				if (((object) this).GetType () != typeof (KeyIdentifier)) {
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
				if (octetString != null) {
					JNIEnv.CopyArray (native_octetString, octetString);
					JNIEnv.DeleteLocalRef (native_octetString);
				}
			}
		}

		static IntPtr id_ctor_Ljava_security_PublicKey_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='KeyIdentifier']/constructor[@name='KeyIdentifier' and count(parameter)=1 and parameter[1][@type='java.security.PublicKey']]"
		[Register (".ctor", "(Ljava/security/PublicKey;)V", "")]
		public unsafe KeyIdentifier (global::Java.Security.IPublicKey pubKey)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pubKey);
				if (((object) this).GetType () != typeof (KeyIdentifier)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/security/PublicKey;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/security/PublicKey;)V", __args);
					return;
				}

				if (id_ctor_Ljava_security_PublicKey_ == IntPtr.Zero)
					id_ctor_Ljava_security_PublicKey_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/security/PublicKey;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_security_PublicKey_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_security_PublicKey_, __args);
			} finally {
			}
		}

		static Delegate cb_getIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIdentifierHandler ()
		{
			if (cb_getIdentifier == null)
				cb_getIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentifier);
			return cb_getIdentifier;
		}

		static IntPtr n_GetIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.KeyIdentifier __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.KeyIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetIdentifier ());
		}
#pragma warning restore 0169

		static IntPtr id_getIdentifier;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='KeyIdentifier']/method[@name='getIdentifier' and count(parameter)=0]"
		[Register ("getIdentifier", "()[B", "GetGetIdentifierHandler")]
		public virtual unsafe byte[] GetIdentifier ()
		{
			if (id_getIdentifier == IntPtr.Zero)
				id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentifier", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
