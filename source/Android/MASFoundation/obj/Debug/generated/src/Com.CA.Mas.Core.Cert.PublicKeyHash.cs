using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Cert {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='PublicKeyHash']"
	[global::Android.Runtime.Register ("com/ca/mas/core/cert/PublicKeyHash", DoNotGenerateAcw=true)]
	public partial class PublicKeyHash : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/cert/PublicKeyHash", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PublicKeyHash); }
		}

		protected PublicKeyHash (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getHashString;
#pragma warning disable 0169
		static Delegate GetGetHashStringHandler ()
		{
			if (cb_getHashString == null)
				cb_getHashString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHashString);
			return cb_getHashString;
		}

		static IntPtr n_GetHashString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Cert.PublicKeyHash __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Cert.PublicKeyHash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HashString);
		}
#pragma warning restore 0169

		static IntPtr id_getHashString;
		public virtual unsafe string HashString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='PublicKeyHash']/method[@name='getHashString' and count(parameter)=0]"
			[Register ("getHashString", "()Ljava/lang/String;", "GetGetHashStringHandler")]
			get {
				if (id_getHashString == IntPtr.Zero)
					id_getHashString = JNIEnv.GetMethodID (class_ref, "getHashString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHashString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHashString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_fromCertificate_Ljava_security_cert_Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='PublicKeyHash']/method[@name='fromCertificate' and count(parameter)=1 and parameter[1][@type='java.security.cert.Certificate']]"
		[Register ("fromCertificate", "(Ljava/security/cert/Certificate;)Lcom/ca/mas/core/cert/PublicKeyHash;", "")]
		public static unsafe global::Com.CA.Mas.Core.Cert.PublicKeyHash FromCertificate (global::Java.Security.Cert.Certificate certificate)
		{
			if (id_fromCertificate_Ljava_security_cert_Certificate_ == IntPtr.Zero)
				id_fromCertificate_Ljava_security_cert_Certificate_ = JNIEnv.GetStaticMethodID (class_ref, "fromCertificate", "(Ljava/security/cert/Certificate;)Lcom/ca/mas/core/cert/PublicKeyHash;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (certificate);
				global::Com.CA.Mas.Core.Cert.PublicKeyHash __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Cert.PublicKeyHash> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCertificate_Ljava_security_cert_Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromHashString_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='PublicKeyHash']/method[@name='fromHashString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("fromHashString", "(Ljava/lang/String;I)Lcom/ca/mas/core/cert/PublicKeyHash;", "")]
		public static unsafe global::Com.CA.Mas.Core.Cert.PublicKeyHash FromHashString (string hashString, int flags)
		{
			if (id_fromHashString_Ljava_lang_String_I == IntPtr.Zero)
				id_fromHashString_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "fromHashString", "(Ljava/lang/String;I)Lcom/ca/mas/core/cert/PublicKeyHash;");
			IntPtr native_hashString = JNIEnv.NewString (hashString);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_hashString);
				__args [1] = new JValue (flags);
				global::Com.CA.Mas.Core.Cert.PublicKeyHash __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Cert.PublicKeyHash> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromHashString_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_hashString);
			}
		}

		static IntPtr id_fromPublicKey_Ljava_security_PublicKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='PublicKeyHash']/method[@name='fromPublicKey' and count(parameter)=1 and parameter[1][@type='java.security.PublicKey']]"
		[Register ("fromPublicKey", "(Ljava/security/PublicKey;)Lcom/ca/mas/core/cert/PublicKeyHash;", "")]
		public static unsafe global::Com.CA.Mas.Core.Cert.PublicKeyHash FromPublicKey (global::Java.Security.IPublicKey publicKey)
		{
			if (id_fromPublicKey_Ljava_security_PublicKey_ == IntPtr.Zero)
				id_fromPublicKey_Ljava_security_PublicKey_ = JNIEnv.GetStaticMethodID (class_ref, "fromPublicKey", "(Ljava/security/PublicKey;)Lcom/ca/mas/core/cert/PublicKeyHash;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (publicKey);
				global::Com.CA.Mas.Core.Cert.PublicKeyHash __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Cert.PublicKeyHash> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromPublicKey_Ljava_security_PublicKey_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_matches_arrayB;
#pragma warning disable 0169
		static Delegate GetMatches_arrayBHandler ()
		{
			if (cb_matches_arrayB == null)
				cb_matches_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Matches_arrayB);
			return cb_matches_arrayB;
		}

		static bool n_Matches_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_otherHash)
		{
			global::Com.CA.Mas.Core.Cert.PublicKeyHash __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Cert.PublicKeyHash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] otherHash = (byte[]) JNIEnv.GetArray (native_otherHash, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Matches (otherHash);
			if (otherHash != null)
				JNIEnv.CopyArray (otherHash, native_otherHash);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_matches_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='PublicKeyHash']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("matches", "([B)Z", "GetMatches_arrayBHandler")]
		public virtual unsafe bool Matches (byte[] otherHash)
		{
			if (id_matches_arrayB == IntPtr.Zero)
				id_matches_arrayB = JNIEnv.GetMethodID (class_ref, "matches", "([B)Z");
			IntPtr native_otherHash = JNIEnv.NewArray (otherHash);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_otherHash);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "matches", "([B)Z"), __args);
				return __ret;
			} finally {
				if (otherHash != null) {
					JNIEnv.CopyArray (native_otherHash, otherHash);
					JNIEnv.DeleteLocalRef (native_otherHash);
				}
			}
		}

		static Delegate cb_matches_Ljava_security_cert_X509Certificate_;
#pragma warning disable 0169
		static Delegate GetMatches_Ljava_security_cert_X509Certificate_Handler ()
		{
			if (cb_matches_Ljava_security_cert_X509Certificate_ == null)
				cb_matches_Ljava_security_cert_X509Certificate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Matches_Ljava_security_cert_X509Certificate_);
			return cb_matches_Ljava_security_cert_X509Certificate_;
		}

		static bool n_Matches_Ljava_security_cert_X509Certificate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_certificate)
		{
			global::Com.CA.Mas.Core.Cert.PublicKeyHash __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Cert.PublicKeyHash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.X509Certificate certificate = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.X509Certificate> (native_certificate, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Matches (certificate);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_matches_Ljava_security_cert_X509Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='PublicKeyHash']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='java.security.cert.X509Certificate']]"
		[Register ("matches", "(Ljava/security/cert/X509Certificate;)Z", "GetMatches_Ljava_security_cert_X509Certificate_Handler")]
		public virtual unsafe bool Matches (global::Java.Security.Cert.X509Certificate certificate)
		{
			if (id_matches_Ljava_security_cert_X509Certificate_ == IntPtr.Zero)
				id_matches_Ljava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "matches", "(Ljava/security/cert/X509Certificate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (certificate);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_Ljava_security_cert_X509Certificate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "matches", "(Ljava/security/cert/X509Certificate;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_matches_Ljava_security_PublicKey_;
#pragma warning disable 0169
		static Delegate GetMatches_Ljava_security_PublicKey_Handler ()
		{
			if (cb_matches_Ljava_security_PublicKey_ == null)
				cb_matches_Ljava_security_PublicKey_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Matches_Ljava_security_PublicKey_);
			return cb_matches_Ljava_security_PublicKey_;
		}

		static bool n_Matches_Ljava_security_PublicKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_publicKey)
		{
			global::Com.CA.Mas.Core.Cert.PublicKeyHash __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Cert.PublicKeyHash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPublicKey publicKey = (global::Java.Security.IPublicKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (native_publicKey, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Matches (publicKey);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_matches_Ljava_security_PublicKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/class[@name='PublicKeyHash']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='java.security.PublicKey']]"
		[Register ("matches", "(Ljava/security/PublicKey;)Z", "GetMatches_Ljava_security_PublicKey_Handler")]
		public virtual unsafe bool Matches (global::Java.Security.IPublicKey publicKey)
		{
			if (id_matches_Ljava_security_PublicKey_ == IntPtr.Zero)
				id_matches_Ljava_security_PublicKey_ = JNIEnv.GetMethodID (class_ref, "matches", "(Ljava/security/PublicKey;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (publicKey);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_Ljava_security_PublicKey_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "matches", "(Ljava/security/PublicKey;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
