using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']"
	[global::Android.Runtime.Register ("sun/security/x509/X509Key", DoNotGenerateAcw=true)]
	public partial class X509Key : global::Java.Lang.Object, global::Java.Security.IPublicKey {


		static IntPtr algid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/field[@name='algid']"
		[Register ("algid")]
		protected global::Sun.Security.X509.AlgorithmId Algid {
			get {
				if (algid_jfieldId == IntPtr.Zero)
					algid_jfieldId = JNIEnv.GetFieldID (class_ref, "algid", "Lsun/security/x509/AlgorithmId;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, algid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (algid_jfieldId == IntPtr.Zero)
					algid_jfieldId = JNIEnv.GetFieldID (class_ref, "algid", "Lsun/security/x509/AlgorithmId;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, algid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr encodedKey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/field[@name='encodedKey']"
		[Register ("encodedKey")]
		protected IList<byte> EncodedKey {
			get {
				if (encodedKey_jfieldId == IntPtr.Zero)
					encodedKey_jfieldId = JNIEnv.GetFieldID (class_ref, "encodedKey", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, encodedKey_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (encodedKey_jfieldId == IntPtr.Zero)
					encodedKey_jfieldId = JNIEnv.GetFieldID (class_ref, "encodedKey", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, encodedKey_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/X509Key", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (X509Key); }
		}

		protected X509Key (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/constructor[@name='X509Key' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe X509Key ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (X509Key)) {
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

		static Delegate cb_getAlgorithm;
#pragma warning disable 0169
		static Delegate GetGetAlgorithmHandler ()
		{
			if (cb_getAlgorithm == null)
				cb_getAlgorithm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlgorithm);
			return cb_getAlgorithm;
		}

		static IntPtr n_GetAlgorithm (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Algorithm);
		}
#pragma warning restore 0169

		static IntPtr id_getAlgorithm;
		public virtual unsafe string Algorithm {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='getAlgorithm' and count(parameter)=0]"
			[Register ("getAlgorithm", "()Ljava/lang/String;", "GetGetAlgorithmHandler")]
			get {
				if (id_getAlgorithm == IntPtr.Zero)
					id_getAlgorithm = JNIEnv.GetMethodID (class_ref, "getAlgorithm", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlgorithm), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlgorithm", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAlgorithmId;
#pragma warning disable 0169
		static Delegate GetGetAlgorithmIdHandler ()
		{
			if (cb_getAlgorithmId == null)
				cb_getAlgorithmId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlgorithmId);
			return cb_getAlgorithmId;
		}

		static IntPtr n_GetAlgorithmId (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AlgorithmId);
		}
#pragma warning restore 0169

		static IntPtr id_getAlgorithmId;
		public virtual unsafe global::Sun.Security.X509.AlgorithmId AlgorithmId {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='getAlgorithmId' and count(parameter)=0]"
			[Register ("getAlgorithmId", "()Lsun/security/x509/AlgorithmId;", "GetGetAlgorithmIdHandler")]
			get {
				if (id_getAlgorithmId == IntPtr.Zero)
					id_getAlgorithmId = JNIEnv.GetMethodID (class_ref, "getAlgorithmId", "()Lsun/security/x509/AlgorithmId;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlgorithmId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.AlgorithmId> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlgorithmId", "()Lsun/security/x509/AlgorithmId;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Format);
		}
#pragma warning restore 0169

		static IntPtr id_getFormat;
		public virtual unsafe string Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Ljava/lang/String;", "GetGetFormatHandler")]
			get {
				if (id_getFormat == IntPtr.Zero)
					id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormat", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Key);
		}
#pragma warning restore 0169

		static Delegate cb_setKey_Lsun_security_util_BitArray_;
#pragma warning disable 0169
		static Delegate GetSetKey_Lsun_security_util_BitArray_Handler ()
		{
			if (cb_setKey_Lsun_security_util_BitArray_ == null)
				cb_setKey_Lsun_security_util_BitArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKey_Lsun_security_util_BitArray_);
			return cb_setKey_Lsun_security_util_BitArray_;
		}

		static void n_SetKey_Lsun_security_util_BitArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.BitArray key = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Key = key;
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		static IntPtr id_setKey_Lsun_security_util_BitArray_;
		protected virtual unsafe global::Sun.Security.Util.BitArray Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Lsun/security/util/BitArray;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Lsun/security/util/BitArray;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Lsun/security/util/BitArray;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='setKey' and count(parameter)=1 and parameter[1][@type='sun.security.util.BitArray']]"
			[Register ("setKey", "(Lsun/security/util/BitArray;)V", "GetSetKey_Lsun_security_util_BitArray_Handler")]
			set {
				if (id_setKey_Lsun_security_util_BitArray_ == IntPtr.Zero)
					id_setKey_Lsun_security_util_BitArray_ = JNIEnv.GetMethodID (class_ref, "setKey", "(Lsun/security/util/BitArray;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKey_Lsun_security_util_BitArray_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKey", "(Lsun/security/util/BitArray;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_decode_arrayB;
#pragma warning disable 0169
		static Delegate GetDecode_arrayBHandler ()
		{
			if (cb_decode_arrayB == null)
				cb_decode_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Decode_arrayB);
			return cb_decode_arrayB;
		}

		static void n_Decode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_encodedKey)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] encodedKey = (byte[]) JNIEnv.GetArray (native_encodedKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Decode (encodedKey);
			if (encodedKey != null)
				JNIEnv.CopyArray (encodedKey, native_encodedKey);
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)V", "GetDecode_arrayBHandler")]
		public virtual unsafe void Decode (byte[] encodedKey)
		{
			if (id_decode_arrayB == IntPtr.Zero)
				id_decode_arrayB = JNIEnv.GetMethodID (class_ref, "decode", "([B)V");
			IntPtr native_encodedKey = JNIEnv.NewArray (encodedKey);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_encodedKey);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decode_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([B)V"), __args);
			} finally {
				if (encodedKey != null) {
					JNIEnv.CopyArray (native_encodedKey, encodedKey);
					JNIEnv.DeleteLocalRef (native_encodedKey);
				}
			}
		}

		static Delegate cb_decode_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_io_InputStream_Handler ()
		{
			if (cb_decode_Ljava_io_InputStream_ == null)
				cb_decode_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_io_InputStream_);
			return cb_decode_Ljava_io_InputStream_;
		}

		static void n_Decode_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @in = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__in, JniHandleOwnership.DoNotTransfer);
			__this.Decode (@in);
		}
#pragma warning restore 0169

		static IntPtr id_decode_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("decode", "(Ljava/io/InputStream;)V", "GetDecode_Ljava_io_InputStream_Handler")]
		public virtual unsafe void Decode (global::System.IO.Stream @in)
		{
			if (id_decode_Ljava_io_InputStream_ == IntPtr.Zero)
				id_decode_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "decode", "(Ljava/io/InputStream;)V");
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__in);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decode_Ljava_io_InputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "(Ljava/io/InputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		static Delegate cb_encode;
#pragma warning disable 0169
		static Delegate GetEncodeHandler ()
		{
			if (cb_encode == null)
				cb_encode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Encode);
			return cb_encode;
		}

		static IntPtr n_Encode (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Encode ());
		}
#pragma warning restore 0169

		static IntPtr id_encode;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='encode' and count(parameter)=0]"
		[Register ("encode", "()[B", "GetEncodeHandler")]
		public virtual unsafe byte[] Encode ()
		{
			if (id_encode == IntPtr.Zero)
				id_encode = JNIEnv.GetMethodID (class_ref, "encode", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
		[Register ("encode", "(Lsun/security/util/DerOutputStream;)V", "")]
		public unsafe void Encode (global::Sun.Security.Util.DerOutputStream @out)
		{
			if (id_encode_Lsun_security_util_DerOutputStream_ == IntPtr.Zero)
				id_encode_Lsun_security_util_DerOutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lsun/security/util/DerOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@out);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Lsun_security_util_DerOutputStream_, __args);
			} finally {
			}
		}

		static Delegate cb_getEncoded;
#pragma warning disable 0169
		static Delegate GetGetEncodedHandler ()
		{
			if (cb_getEncoded == null)
				cb_getEncoded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncoded);
			return cb_getEncoded;
		}

		static IntPtr n_GetEncoded (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncoded ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncoded;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='getEncoded' and count(parameter)=0]"
		[Register ("getEncoded", "()[B", "GetGetEncodedHandler")]
		public virtual unsafe byte[] GetEncoded ()
		{
			if (id_getEncoded == IntPtr.Zero)
				id_getEncoded = JNIEnv.GetMethodID (class_ref, "getEncoded", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncoded), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncoded", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getEncodedInternal;
#pragma warning disable 0169
		static Delegate GetGetEncodedInternalHandler ()
		{
			if (cb_getEncodedInternal == null)
				cb_getEncodedInternal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncodedInternal);
			return cb_getEncodedInternal;
		}

		static IntPtr n_GetEncodedInternal (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEncodedInternal ());
		}
#pragma warning restore 0169

		static IntPtr id_getEncodedInternal;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='getEncodedInternal' and count(parameter)=0]"
		[Register ("getEncodedInternal", "()[B", "GetGetEncodedInternalHandler")]
		public virtual unsafe byte[] GetEncodedInternal ()
		{
			if (id_getEncodedInternal == IntPtr.Zero)
				id_getEncodedInternal = JNIEnv.GetMethodID (class_ref, "getEncodedInternal", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncodedInternal), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncodedInternal", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_parseKeyBits;
#pragma warning disable 0169
		static Delegate GetParseKeyBitsHandler ()
		{
			if (cb_parseKeyBits == null)
				cb_parseKeyBits = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ParseKeyBits);
			return cb_parseKeyBits;
		}

		static void n_ParseKeyBits (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.X509Key __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.X509Key> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseKeyBits ();
		}
#pragma warning restore 0169

		static IntPtr id_parseKeyBits;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='X509Key']/method[@name='parseKeyBits' and count(parameter)=0]"
		[Register ("parseKeyBits", "()V", "GetParseKeyBitsHandler")]
		protected virtual unsafe void ParseKeyBits ()
		{
			if (id_parseKeyBits == IntPtr.Zero)
				id_parseKeyBits = JNIEnv.GetMethodID (class_ref, "parseKeyBits", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parseKeyBits);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseKeyBits", "()V"));
			} finally {
			}
		}

	}
}
