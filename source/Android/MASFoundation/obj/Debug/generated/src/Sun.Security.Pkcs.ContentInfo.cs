using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Pkcs {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']"
	[global::Android.Runtime.Register ("sun/security/pkcs/ContentInfo", DoNotGenerateAcw=true)]
	public partial class ContentInfo : global::Java.Lang.Object {


		static IntPtr DATA_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/field[@name='DATA_OID']"
		[Register ("DATA_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier DataOid {
			get {
				if (DATA_OID_jfieldId == IntPtr.Zero)
					DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DATA_OID_jfieldId == IntPtr.Zero)
					DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, DATA_OID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DIGESTED_DATA_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/field[@name='DIGESTED_DATA_OID']"
		[Register ("DIGESTED_DATA_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier DigestedDataOid {
			get {
				if (DIGESTED_DATA_OID_jfieldId == IntPtr.Zero)
					DIGESTED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIGESTED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DIGESTED_DATA_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DIGESTED_DATA_OID_jfieldId == IntPtr.Zero)
					DIGESTED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DIGESTED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, DIGESTED_DATA_OID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ENCRYPTED_DATA_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/field[@name='ENCRYPTED_DATA_OID']"
		[Register ("ENCRYPTED_DATA_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier EncryptedDataOid {
			get {
				if (ENCRYPTED_DATA_OID_jfieldId == IntPtr.Zero)
					ENCRYPTED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENCRYPTED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENCRYPTED_DATA_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ENCRYPTED_DATA_OID_jfieldId == IntPtr.Zero)
					ENCRYPTED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENCRYPTED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, ENCRYPTED_DATA_OID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ENVELOPED_DATA_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/field[@name='ENVELOPED_DATA_OID']"
		[Register ("ENVELOPED_DATA_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier EnvelopedDataOid {
			get {
				if (ENVELOPED_DATA_OID_jfieldId == IntPtr.Zero)
					ENVELOPED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENVELOPED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENVELOPED_DATA_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ENVELOPED_DATA_OID_jfieldId == IntPtr.Zero)
					ENVELOPED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENVELOPED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, ENVELOPED_DATA_OID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr NETSCAPE_CERT_SEQUENCE_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/field[@name='NETSCAPE_CERT_SEQUENCE_OID']"
		[Register ("NETSCAPE_CERT_SEQUENCE_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier NetscapeCertSequenceOid {
			get {
				if (NETSCAPE_CERT_SEQUENCE_OID_jfieldId == IntPtr.Zero)
					NETSCAPE_CERT_SEQUENCE_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETSCAPE_CERT_SEQUENCE_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETSCAPE_CERT_SEQUENCE_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NETSCAPE_CERT_SEQUENCE_OID_jfieldId == IntPtr.Zero)
					NETSCAPE_CERT_SEQUENCE_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETSCAPE_CERT_SEQUENCE_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, NETSCAPE_CERT_SEQUENCE_OID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr OLD_DATA_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/field[@name='OLD_DATA_OID']"
		[Register ("OLD_DATA_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier OldDataOid {
			get {
				if (OLD_DATA_OID_jfieldId == IntPtr.Zero)
					OLD_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OLD_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OLD_DATA_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (OLD_DATA_OID_jfieldId == IntPtr.Zero)
					OLD_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OLD_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, OLD_DATA_OID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr OLD_SIGNED_DATA_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/field[@name='OLD_SIGNED_DATA_OID']"
		[Register ("OLD_SIGNED_DATA_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier OldSignedDataOid {
			get {
				if (OLD_SIGNED_DATA_OID_jfieldId == IntPtr.Zero)
					OLD_SIGNED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OLD_SIGNED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OLD_SIGNED_DATA_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (OLD_SIGNED_DATA_OID_jfieldId == IntPtr.Zero)
					OLD_SIGNED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OLD_SIGNED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, OLD_SIGNED_DATA_OID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SIGNED_AND_ENVELOPED_DATA_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/field[@name='SIGNED_AND_ENVELOPED_DATA_OID']"
		[Register ("SIGNED_AND_ENVELOPED_DATA_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier SignedAndEnvelopedDataOid {
			get {
				if (SIGNED_AND_ENVELOPED_DATA_OID_jfieldId == IntPtr.Zero)
					SIGNED_AND_ENVELOPED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGNED_AND_ENVELOPED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIGNED_AND_ENVELOPED_DATA_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SIGNED_AND_ENVELOPED_DATA_OID_jfieldId == IntPtr.Zero)
					SIGNED_AND_ENVELOPED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGNED_AND_ENVELOPED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, SIGNED_AND_ENVELOPED_DATA_OID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SIGNED_DATA_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/field[@name='SIGNED_DATA_OID']"
		[Register ("SIGNED_DATA_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier SignedDataOid {
			get {
				if (SIGNED_DATA_OID_jfieldId == IntPtr.Zero)
					SIGNED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGNED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIGNED_DATA_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SIGNED_DATA_OID_jfieldId == IntPtr.Zero)
					SIGNED_DATA_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGNED_DATA_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, SIGNED_DATA_OID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr TIMESTAMP_TOKEN_INFO_OID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/field[@name='TIMESTAMP_TOKEN_INFO_OID']"
		[Register ("TIMESTAMP_TOKEN_INFO_OID")]
		public static global::Sun.Security.Util.ObjectIdentifier TimestampTokenInfoOid {
			get {
				if (TIMESTAMP_TOKEN_INFO_OID_jfieldId == IntPtr.Zero)
					TIMESTAMP_TOKEN_INFO_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMESTAMP_TOKEN_INFO_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIMESTAMP_TOKEN_INFO_OID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TIMESTAMP_TOKEN_INFO_OID_jfieldId == IntPtr.Zero)
					TIMESTAMP_TOKEN_INFO_OID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMESTAMP_TOKEN_INFO_OID", "Lsun/security/util/ObjectIdentifier;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, TIMESTAMP_TOKEN_INFO_OID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/pkcs/ContentInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentInfo); }
		}

		protected ContentInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/constructor[@name='ContentInfo' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe ContentInfo (byte[] bytes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);
				if (((object) this).GetType () != typeof (ContentInfo)) {
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
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/constructor[@name='ContentInfo' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerInputStream']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;)V", "")]
		public unsafe ContentInfo (global::Sun.Security.Util.DerInputStream derin)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (derin);
				if (((object) this).GetType () != typeof (ContentInfo)) {
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

		static IntPtr id_ctor_Lsun_security_util_DerInputStream_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/constructor[@name='ContentInfo' and count(parameter)=2 and parameter[1][@type='sun.security.util.DerInputStream'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lsun/security/util/DerInputStream;Z)V", "")]
		public unsafe ContentInfo (global::Sun.Security.Util.DerInputStream derin, bool oldStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (derin);
				__args [1] = new JValue (oldStyle);
				if (((object) this).GetType () != typeof (ContentInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/DerInputStream;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/DerInputStream;Z)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_DerInputStream_Z == IntPtr.Zero)
					id_ctor_Lsun_security_util_DerInputStream_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/DerInputStream;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_DerInputStream_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_DerInputStream_Z, __args);
			} finally {
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.ContentInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.ContentInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		public virtual unsafe global::Sun.Security.Util.ObjectIdentifier ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lsun/security/util/ObjectIdentifier;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Lsun/security/util/ObjectIdentifier;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Lsun/security/util/ObjectIdentifier;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_encode_Lsun_security_util_DerOutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Lsun_security_util_DerOutputStream_Handler ()
		{
			if (cb_encode_Lsun_security_util_DerOutputStream_ == null)
				cb_encode_Lsun_security_util_DerOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Encode_Lsun_security_util_DerOutputStream_);
			return cb_encode_Lsun_security_util_DerOutputStream_;
		}

		static void n_Encode_Lsun_security_util_DerOutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.Pkcs.ContentInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.ContentInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
		[Register ("encode", "(Lsun/security/util/DerOutputStream;)V", "GetEncode_Lsun_security_util_DerOutputStream_Handler")]
		public virtual unsafe void Encode (global::Sun.Security.Util.DerOutputStream @out)
		{
			if (id_encode_Lsun_security_util_DerOutputStream_ == IntPtr.Zero)
				id_encode_Lsun_security_util_DerOutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lsun/security/util/DerOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Lsun_security_util_DerOutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Lsun/security/util/DerOutputStream;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getContentBytes;
#pragma warning disable 0169
		static Delegate GetGetContentBytesHandler ()
		{
			if (cb_getContentBytes == null)
				cb_getContentBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentBytes);
			return cb_getContentBytes;
		}

		static IntPtr n_GetContentBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.ContentInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.ContentInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetContentBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getContentBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/method[@name='getContentBytes' and count(parameter)=0]"
		[Register ("getContentBytes", "()[B", "GetGetContentBytesHandler")]
		public virtual unsafe byte[] GetContentBytes ()
		{
			if (id_getContentBytes == IntPtr.Zero)
				id_getContentBytes = JNIEnv.GetMethodID (class_ref, "getContentBytes", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.ContentInfo __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.ContentInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='ContentInfo']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public virtual unsafe byte[] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
