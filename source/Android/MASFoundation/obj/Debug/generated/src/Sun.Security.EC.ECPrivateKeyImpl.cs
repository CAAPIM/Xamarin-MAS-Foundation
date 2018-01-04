using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.EC {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPrivateKeyImpl']"
	[global::Android.Runtime.Register ("sun/security/ec/ECPrivateKeyImpl", DoNotGenerateAcw=true)]
	public sealed partial class ECPrivateKeyImpl : global::Sun.Security.Pkcs.PKCS8Key, global::Java.Security.Interfaces.IECPrivateKey {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/ec/ECPrivateKeyImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ECPrivateKeyImpl); }
		}

		internal ECPrivateKeyImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPrivateKeyImpl']/constructor[@name='ECPrivateKeyImpl' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe ECPrivateKeyImpl (byte[] encoded)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_encoded = JNIEnv.NewArray (encoded);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_encoded);
				if (((object) this).GetType () != typeof (ECPrivateKeyImpl)) {
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
				if (encoded != null) {
					JNIEnv.CopyArray (native_encoded, encoded);
					JNIEnv.DeleteLocalRef (native_encoded);
				}
			}
		}

		static IntPtr id_ctor_Ljava_math_BigInteger_Ljava_security_spec_ECParameterSpec_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPrivateKeyImpl']/constructor[@name='ECPrivateKeyImpl' and count(parameter)=2 and parameter[1][@type='java.math.BigInteger'] and parameter[2][@type='java.security.spec.ECParameterSpec']]"
		[Register (".ctor", "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)V", "")]
		public unsafe ECPrivateKeyImpl (global::Java.Math.BigInteger s, global::Java.Security.Spec.ECParameterSpec @params)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (s);
				__args [1] = new JValue (@params);
				if (((object) this).GetType () != typeof (ECPrivateKeyImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)V", __args);
					return;
				}

				if (id_ctor_Ljava_math_BigInteger_Ljava_security_spec_ECParameterSpec_ == IntPtr.Zero)
					id_ctor_Ljava_math_BigInteger_Ljava_security_spec_ECParameterSpec_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/math/BigInteger;Ljava/security/spec/ECParameterSpec;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_math_BigInteger_Ljava_security_spec_ECParameterSpec_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_math_BigInteger_Ljava_security_spec_ECParameterSpec_, __args);
			} finally {
			}
		}

		static IntPtr id_getParams;
		public unsafe global::Java.Security.Spec.ECParameterSpec Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPrivateKeyImpl']/method[@name='getParams' and count(parameter)=0]"
			[Register ("getParams", "()Ljava/security/spec/ECParameterSpec;", "GetGetParamsHandler")]
			get {
				if (id_getParams == IntPtr.Zero)
					id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()Ljava/security/spec/ECParameterSpec;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Security.Spec.ECParameterSpec> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParams), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getS;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPrivateKeyImpl']/method[@name='getS' and count(parameter)=0]"
		[Register ("getS", "()Ljava/math/BigInteger;", "")]
		public unsafe global::Java.Math.BigInteger GetS ()
		{
			if (id_getS == IntPtr.Zero)
				id_getS = JNIEnv.GetMethodID (class_ref, "getS", "()Ljava/math/BigInteger;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getS), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
