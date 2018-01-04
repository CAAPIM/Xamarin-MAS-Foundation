using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.EC {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPublicKeyImpl']"
	[global::Android.Runtime.Register ("sun/security/ec/ECPublicKeyImpl", DoNotGenerateAcw=true)]
	public sealed partial class ECPublicKeyImpl : global::Sun.Security.X509.X509Key, global::Java.Security.Interfaces.IECPublicKey {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/ec/ECPublicKeyImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ECPublicKeyImpl); }
		}

		internal ECPublicKeyImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPublicKeyImpl']/constructor[@name='ECPublicKeyImpl' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe ECPublicKeyImpl (byte[] encoded)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_encoded = JNIEnv.NewArray (encoded);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_encoded);
				if (((object) this).GetType () != typeof (ECPublicKeyImpl)) {
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

		static IntPtr id_ctor_Ljava_security_spec_ECPoint_Ljava_security_spec_ECParameterSpec_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPublicKeyImpl']/constructor[@name='ECPublicKeyImpl' and count(parameter)=2 and parameter[1][@type='java.security.spec.ECPoint'] and parameter[2][@type='java.security.spec.ECParameterSpec']]"
		[Register (".ctor", "(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)V", "")]
		public unsafe ECPublicKeyImpl (global::Java.Security.Spec.ECPoint w, global::Java.Security.Spec.ECParameterSpec @params)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (w);
				__args [1] = new JValue (@params);
				if (((object) this).GetType () != typeof (ECPublicKeyImpl)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)V", __args);
					return;
				}

				if (id_ctor_Ljava_security_spec_ECPoint_Ljava_security_spec_ECParameterSpec_ == IntPtr.Zero)
					id_ctor_Ljava_security_spec_ECPoint_Ljava_security_spec_ECParameterSpec_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/security/spec/ECPoint;Ljava/security/spec/ECParameterSpec;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_security_spec_ECPoint_Ljava_security_spec_ECParameterSpec_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_security_spec_ECPoint_Ljava_security_spec_ECParameterSpec_, __args);
			} finally {
			}
		}

		static IntPtr id_getParams;
		public unsafe global::Java.Security.Spec.ECParameterSpec Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPublicKeyImpl']/method[@name='getParams' and count(parameter)=0]"
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

		static IntPtr id_getEncodedPublicValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPublicKeyImpl']/method[@name='getEncodedPublicValue' and count(parameter)=0]"
		[Register ("getEncodedPublicValue", "()[B", "")]
		public unsafe byte[] GetEncodedPublicValue ()
		{
			if (id_getEncodedPublicValue == IntPtr.Zero)
				id_getEncodedPublicValue = JNIEnv.GetMethodID (class_ref, "getEncodedPublicValue", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncodedPublicValue), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getW;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPublicKeyImpl']/method[@name='getW' and count(parameter)=0]"
		[Register ("getW", "()Ljava/security/spec/ECPoint;", "")]
		public unsafe global::Java.Security.Spec.ECPoint GetW ()
		{
			if (id_getW == IntPtr.Zero)
				id_getW = JNIEnv.GetMethodID (class_ref, "getW", "()Ljava/security/spec/ECPoint;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Security.Spec.ECPoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getW), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeReplace;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECPublicKeyImpl']/method[@name='writeReplace' and count(parameter)=0]"
		[Register ("writeReplace", "()Ljava/lang/Object;", "")]
		protected unsafe global::Java.Lang.Object WriteReplace ()
		{
			if (id_writeReplace == IntPtr.Zero)
				id_writeReplace = JNIEnv.GetMethodID (class_ref, "writeReplace", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_writeReplace), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
