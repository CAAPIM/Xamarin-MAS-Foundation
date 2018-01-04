using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.EC {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.ec']/class[@name='ECKeyFactory']"
	[global::Android.Runtime.Register ("sun/security/ec/ECKeyFactory", DoNotGenerateAcw=true)]
	public sealed partial class ECKeyFactory : global::Java.Security.KeyFactorySpi {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.ec']/class[@name='ECKeyFactory']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Java.Security.KeyFactory Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Ljava/security/KeyFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Security.KeyFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ecInternalProvider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.ec']/class[@name='ECKeyFactory']/field[@name='ecInternalProvider']"
		[Register ("ecInternalProvider")]
		public static global::Java.Security.Provider EcInternalProvider {
			get {
				if (ecInternalProvider_jfieldId == IntPtr.Zero)
					ecInternalProvider_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ecInternalProvider", "Ljava/security/Provider;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ecInternalProvider_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Security.Provider> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/ec/ECKeyFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ECKeyFactory); }
		}

		internal ECKeyFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.ec']/class[@name='ECKeyFactory']/constructor[@name='ECKeyFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ECKeyFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ECKeyFactory)) {
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

		static IntPtr id_engineGeneratePrivate_Ljava_security_spec_KeySpec_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECKeyFactory']/method[@name='engineGeneratePrivate' and count(parameter)=1 and parameter[1][@type='java.security.spec.KeySpec']]"
		[Register ("engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", "")]
		protected override unsafe global::Java.Security.IPrivateKey EngineGeneratePrivate (global::Java.Security.Spec.IKeySpec keySpec)
		{
			if (id_engineGeneratePrivate_Ljava_security_spec_KeySpec_ == IntPtr.Zero)
				id_engineGeneratePrivate_Ljava_security_spec_KeySpec_ = JNIEnv.GetMethodID (class_ref, "engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (keySpec);
				global::Java.Security.IPrivateKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGeneratePrivate_Ljava_security_spec_KeySpec_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_engineGeneratePublic_Ljava_security_spec_KeySpec_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECKeyFactory']/method[@name='engineGeneratePublic' and count(parameter)=1 and parameter[1][@type='java.security.spec.KeySpec']]"
		[Register ("engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", "")]
		protected override unsafe global::Java.Security.IPublicKey EngineGeneratePublic (global::Java.Security.Spec.IKeySpec keySpec)
		{
			if (id_engineGeneratePublic_Ljava_security_spec_KeySpec_ == IntPtr.Zero)
				id_engineGeneratePublic_Ljava_security_spec_KeySpec_ = JNIEnv.GetMethodID (class_ref, "engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (keySpec);
				global::Java.Security.IPublicKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGeneratePublic_Ljava_security_spec_KeySpec_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_engineGetKeySpec_Ljava_security_Key_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECKeyFactory']/method[@name='engineGetKeySpec' and count(parameter)=2 and parameter[1][@type='java.security.Key'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.security.spec.KeySpec"})]
		protected override unsafe global::Java.Lang.Object EngineGetKeySpec (global::Java.Security.IKey key, global::Java.Lang.Class keySpec)
		{
			if (id_engineGetKeySpec_Ljava_security_Key_Ljava_lang_Class_ == IntPtr.Zero)
				id_engineGetKeySpec_Ljava_security_Key_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (key);
				__args [1] = new JValue (keySpec);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineGetKeySpec_Ljava_security_Key_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_engineTranslateKey_Ljava_security_Key_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECKeyFactory']/method[@name='engineTranslateKey' and count(parameter)=1 and parameter[1][@type='java.security.Key']]"
		[Register ("engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;", "")]
		protected override unsafe global::Java.Security.IKey EngineTranslateKey (global::Java.Security.IKey key)
		{
			if (id_engineTranslateKey_Ljava_security_Key_ == IntPtr.Zero)
				id_engineTranslateKey_Ljava_security_Key_ = JNIEnv.GetMethodID (class_ref, "engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (key);
				global::Java.Security.IKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.IKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_engineTranslateKey_Ljava_security_Key_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toECKey_Ljava_security_Key_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.ec']/class[@name='ECKeyFactory']/method[@name='toECKey' and count(parameter)=1 and parameter[1][@type='java.security.Key']]"
		[Register ("toECKey", "(Ljava/security/Key;)Ljava/security/interfaces/ECKey;", "")]
		public static unsafe global::Java.Security.Interfaces.IECKey ToECKey (global::Java.Security.IKey key)
		{
			if (id_toECKey_Ljava_security_Key_ == IntPtr.Zero)
				id_toECKey_Ljava_security_Key_ = JNIEnv.GetStaticMethodID (class_ref, "toECKey", "(Ljava/security/Key;)Ljava/security/interfaces/ECKey;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (key);
				global::Java.Security.Interfaces.IECKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.Interfaces.IECKey> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toECKey_Ljava_security_Key_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
