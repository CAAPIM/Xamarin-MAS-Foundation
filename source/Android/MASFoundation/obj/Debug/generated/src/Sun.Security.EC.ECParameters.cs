using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.EC {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']"
	[global::Android.Runtime.Register ("sun/security/ec/ECParameters", DoNotGenerateAcw=true)]
	public sealed partial class ECParameters : global::Java.Security.AlgorithmParametersSpi {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/ec/ECParameters", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ECParameters); }
		}

		internal ECParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/constructor[@name='ECParameters' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ECParameters ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ECParameters)) {
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

		static IntPtr id_decodeParameters_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='decodeParameters' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeParameters", "([B)Ljava/security/spec/ECParameterSpec;", "")]
		public static unsafe global::Java.Security.Spec.ECParameterSpec DecodeParameters (byte[] @params)
		{
			if (id_decodeParameters_arrayB == IntPtr.Zero)
				id_decodeParameters_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decodeParameters", "([B)Ljava/security/spec/ECParameterSpec;");
			IntPtr native__params = JNIEnv.NewArray (@params);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__params);
				global::Java.Security.Spec.ECParameterSpec __ret = global::Java.Lang.Object.GetObject<global::Java.Security.Spec.ECParameterSpec> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeParameters_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
			}
		}

		static IntPtr id_decodePoint_arrayBLjava_security_spec_EllipticCurve_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='decodePoint' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.security.spec.EllipticCurve']]"
		[Register ("decodePoint", "([BLjava/security/spec/EllipticCurve;)Ljava/security/spec/ECPoint;", "")]
		public static unsafe global::Java.Security.Spec.ECPoint DecodePoint (byte[] data, global::Java.Security.Spec.EllipticCurve curve)
		{
			if (id_decodePoint_arrayBLjava_security_spec_EllipticCurve_ == IntPtr.Zero)
				id_decodePoint_arrayBLjava_security_spec_EllipticCurve_ = JNIEnv.GetStaticMethodID (class_ref, "decodePoint", "([BLjava/security/spec/EllipticCurve;)Ljava/security/spec/ECPoint;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_data);
				__args [1] = new JValue (curve);
				global::Java.Security.Spec.ECPoint __ret = global::Java.Lang.Object.GetObject<global::Java.Security.Spec.ECPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodePoint_arrayBLjava_security_spec_EllipticCurve_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_encodeParameters_Ljava_security_spec_ECParameterSpec_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='encodeParameters' and count(parameter)=1 and parameter[1][@type='java.security.spec.ECParameterSpec']]"
		[Register ("encodeParameters", "(Ljava/security/spec/ECParameterSpec;)[B", "")]
		public static unsafe byte[] EncodeParameters (global::Java.Security.Spec.ECParameterSpec @params)
		{
			if (id_encodeParameters_Ljava_security_spec_ECParameterSpec_ == IntPtr.Zero)
				id_encodeParameters_Ljava_security_spec_ECParameterSpec_ = JNIEnv.GetStaticMethodID (class_ref, "encodeParameters", "(Ljava/security/spec/ECParameterSpec;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@params);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeParameters_Ljava_security_spec_ECParameterSpec_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_encodePoint_Ljava_security_spec_ECPoint_Ljava_security_spec_EllipticCurve_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='encodePoint' and count(parameter)=2 and parameter[1][@type='java.security.spec.ECPoint'] and parameter[2][@type='java.security.spec.EllipticCurve']]"
		[Register ("encodePoint", "(Ljava/security/spec/ECPoint;Ljava/security/spec/EllipticCurve;)[B", "")]
		public static unsafe byte[] EncodePoint (global::Java.Security.Spec.ECPoint point, global::Java.Security.Spec.EllipticCurve curve)
		{
			if (id_encodePoint_Ljava_security_spec_ECPoint_Ljava_security_spec_EllipticCurve_ == IntPtr.Zero)
				id_encodePoint_Ljava_security_spec_ECPoint_Ljava_security_spec_EllipticCurve_ = JNIEnv.GetStaticMethodID (class_ref, "encodePoint", "(Ljava/security/spec/ECPoint;Ljava/security/spec/EllipticCurve;)[B");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (point);
				__args [1] = new JValue (curve);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodePoint_Ljava_security_spec_ECPoint_Ljava_security_spec_EllipticCurve_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_engineGetEncoded;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='engineGetEncoded' and count(parameter)=0]"
		[Register ("engineGetEncoded", "()[B", "")]
		protected override unsafe byte[] EngineGetEncoded ()
		{
			if (id_engineGetEncoded == IntPtr.Zero)
				id_engineGetEncoded = JNIEnv.GetMethodID (class_ref, "engineGetEncoded", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGetEncoded), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_engineGetEncoded_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='engineGetEncoded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("engineGetEncoded", "(Ljava/lang/String;)[B", "")]
		protected override unsafe byte[] EngineGetEncoded (string encodingMethod)
		{
			if (id_engineGetEncoded_Ljava_lang_String_ == IntPtr.Zero)
				id_engineGetEncoded_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "engineGetEncoded", "(Ljava/lang/String;)[B");
			IntPtr native_encodingMethod = JNIEnv.NewString (encodingMethod);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_encodingMethod);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGetEncoded_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_encodingMethod);
			}
		}

		static IntPtr id_engineGetParameterSpec_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='engineGetParameterSpec' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.security.spec.AlgorithmParameterSpec"})]
		protected override unsafe global::Java.Lang.Object EngineGetParameterSpec (global::Java.Lang.Class spec)
		{
			if (id_engineGetParameterSpec_Ljava_lang_Class_ == IntPtr.Zero)
				id_engineGetParameterSpec_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (spec);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGetParameterSpec_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_engineInit_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='engineInit' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("engineInit", "([B)V", "")]
		protected override unsafe void EngineInit (byte[] @params)
		{
			if (id_engineInit_arrayB == IntPtr.Zero)
				id_engineInit_arrayB = JNIEnv.GetMethodID (class_ref, "engineInit", "([B)V");
			IntPtr native__params = JNIEnv.NewArray (@params);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__params);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_engineInit_arrayB, __args);
			} finally {
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
			}
		}

		static IntPtr id_engineInit_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='engineInit' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("engineInit", "([BLjava/lang/String;)V", "")]
		protected override unsafe void EngineInit (byte[] @params, string decodingMethod)
		{
			if (id_engineInit_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_engineInit_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "engineInit", "([BLjava/lang/String;)V");
			IntPtr native__params = JNIEnv.NewArray (@params);
			IntPtr native_decodingMethod = JNIEnv.NewString (decodingMethod);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__params);
				__args [1] = new JValue (native_decodingMethod);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_engineInit_arrayBLjava_lang_String_, __args);
			} finally {
				if (@params != null) {
					JNIEnv.CopyArray (native__params, @params);
					JNIEnv.DeleteLocalRef (native__params);
				}
				JNIEnv.DeleteLocalRef (native_decodingMethod);
			}
		}

		static IntPtr id_engineInit_Ljava_security_spec_AlgorithmParameterSpec_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='engineInit' and count(parameter)=1 and parameter[1][@type='java.security.spec.AlgorithmParameterSpec']]"
		[Register ("engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V", "")]
		protected override unsafe void EngineInit (global::Java.Security.Spec.IAlgorithmParameterSpec paramSpec)
		{
			if (id_engineInit_Ljava_security_spec_AlgorithmParameterSpec_ == IntPtr.Zero)
				id_engineInit_Ljava_security_spec_AlgorithmParameterSpec_ = JNIEnv.GetMethodID (class_ref, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (paramSpec);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_engineInit_Ljava_security_spec_AlgorithmParameterSpec_, __args);
			} finally {
			}
		}

		static IntPtr id_engineToString;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='engineToString' and count(parameter)=0]"
		[Register ("engineToString", "()Ljava/lang/String;", "")]
		protected override unsafe string EngineToString ()
		{
			if (id_engineToString == IntPtr.Zero)
				id_engineToString = JNIEnv.GetMethodID (class_ref, "engineToString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineToString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getCurveName_Ljava_security_spec_ECParameterSpec_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='getCurveName' and count(parameter)=1 and parameter[1][@type='java.security.spec.ECParameterSpec']]"
		[Register ("getCurveName", "(Ljava/security/spec/ECParameterSpec;)Ljava/lang/String;", "")]
		public static unsafe string GetCurveName (global::Java.Security.Spec.ECParameterSpec @params)
		{
			if (id_getCurveName_Ljava_security_spec_ECParameterSpec_ == IntPtr.Zero)
				id_getCurveName_Ljava_security_spec_ECParameterSpec_ = JNIEnv.GetStaticMethodID (class_ref, "getCurveName", "(Ljava/security/spec/ECParameterSpec;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@params);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurveName_Ljava_security_spec_ECParameterSpec_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNamedCurve_Ljava_security_spec_ECParameterSpec_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECParameters']/method[@name='getNamedCurve' and count(parameter)=1 and parameter[1][@type='java.security.spec.ECParameterSpec']]"
		[Register ("getNamedCurve", "(Ljava/security/spec/ECParameterSpec;)Lsun/security/ec/NamedCurve;", "")]
		public static unsafe global::Sun.Security.EC.NamedCurve GetNamedCurve (global::Java.Security.Spec.ECParameterSpec @params)
		{
			if (id_getNamedCurve_Ljava_security_spec_ECParameterSpec_ == IntPtr.Zero)
				id_getNamedCurve_Ljava_security_spec_ECParameterSpec_ = JNIEnv.GetStaticMethodID (class_ref, "getNamedCurve", "(Ljava/security/spec/ECParameterSpec;)Lsun/security/ec/NamedCurve;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@params);
				global::Sun.Security.EC.NamedCurve __ret = global::Java.Lang.Object.GetObject<global::Sun.Security.EC.NamedCurve> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNamedCurve_Ljava_security_spec_ECParameterSpec_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
