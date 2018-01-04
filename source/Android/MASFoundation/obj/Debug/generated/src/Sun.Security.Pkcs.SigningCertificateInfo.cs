using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Pkcs {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SigningCertificateInfo']"
	[global::Android.Runtime.Register ("sun/security/pkcs/SigningCertificateInfo", DoNotGenerateAcw=true)]
	public partial class SigningCertificateInfo : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/pkcs/SigningCertificateInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SigningCertificateInfo); }
		}

		protected SigningCertificateInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SigningCertificateInfo']/constructor[@name='SigningCertificateInfo' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe SigningCertificateInfo (byte[] ber)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_ber = JNIEnv.NewArray (ber);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ber);
				if (((object) this).GetType () != typeof (SigningCertificateInfo)) {
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
				if (ber != null) {
					JNIEnv.CopyArray (native_ber, ber);
					JNIEnv.DeleteLocalRef (native_ber);
				}
			}
		}

		static Delegate cb_parse_arrayB;
#pragma warning disable 0169
		static Delegate GetParse_arrayBHandler ()
		{
			if (cb_parse_arrayB == null)
				cb_parse_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parse_arrayB);
			return cb_parse_arrayB;
		}

		static void n_Parse_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::Sun.Security.Pkcs.SigningCertificateInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.SigningCertificateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Parse (bytes);
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
		}
#pragma warning restore 0169

		static IntPtr id_parse_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='SigningCertificateInfo']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parse", "([B)V", "GetParse_arrayBHandler")]
		public virtual unsafe void Parse (byte[] bytes)
		{
			if (id_parse_arrayB == IntPtr.Zero)
				id_parse_arrayB = JNIEnv.GetMethodID (class_ref, "parse", "([B)V");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parse_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "([B)V"), __args);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

	}
}
