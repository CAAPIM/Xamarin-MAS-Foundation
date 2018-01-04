using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Pkcs {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attribute']"
	[global::Android.Runtime.Register ("sun/security/pkcs/PKCS10Attribute", DoNotGenerateAcw=true)]
	public partial class PKCS10Attribute : global::Java.Lang.Object, global::Sun.Security.Util.IDerEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/pkcs/PKCS10Attribute", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKCS10Attribute); }
		}

		protected PKCS10Attribute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lsun_security_pkcs_PKCS9Attribute_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attribute']/constructor[@name='PKCS10Attribute' and count(parameter)=1 and parameter[1][@type='sun.security.pkcs.PKCS9Attribute']]"
		[Register (".ctor", "(Lsun/security/pkcs/PKCS9Attribute;)V", "")]
		public unsafe PKCS10Attribute (global::Sun.Security.Pkcs.PKCS9Attribute attr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (attr);
				if (((object) this).GetType () != typeof (PKCS10Attribute)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/pkcs/PKCS9Attribute;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/pkcs/PKCS9Attribute;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_pkcs_PKCS9Attribute_ == IntPtr.Zero)
					id_ctor_Lsun_security_pkcs_PKCS9Attribute_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/pkcs/PKCS9Attribute;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_pkcs_PKCS9Attribute_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_pkcs_PKCS9Attribute_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attribute']/constructor[@name='PKCS10Attribute' and count(parameter)=2 and parameter[1][@type='sun.security.util.ObjectIdentifier'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Lsun/security/util/ObjectIdentifier;Ljava/lang/Object;)V", "")]
		public unsafe PKCS10Attribute (global::Sun.Security.Util.ObjectIdentifier attributeId, global::Java.Lang.Object attributeValue)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (attributeId);
				__args [1] = new JValue (attributeValue);
				if (((object) this).GetType () != typeof (PKCS10Attribute)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lsun/security/util/ObjectIdentifier;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lsun/security/util/ObjectIdentifier;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lsun/security/util/ObjectIdentifier;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lsun_security_util_ObjectIdentifier_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static Delegate cb_getAttributeId;
#pragma warning disable 0169
		static Delegate GetGetAttributeIdHandler ()
		{
			if (cb_getAttributeId == null)
				cb_getAttributeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributeId);
			return cb_getAttributeId;
		}

		static IntPtr n_GetAttributeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.PKCS10Attribute __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AttributeId);
		}
#pragma warning restore 0169

		static IntPtr id_getAttributeId;
		public virtual unsafe global::Sun.Security.Util.ObjectIdentifier AttributeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attribute']/method[@name='getAttributeId' and count(parameter)=0]"
			[Register ("getAttributeId", "()Lsun/security/util/ObjectIdentifier;", "GetGetAttributeIdHandler")]
			get {
				if (id_getAttributeId == IntPtr.Zero)
					id_getAttributeId = JNIEnv.GetMethodID (class_ref, "getAttributeId", "()Lsun/security/util/ObjectIdentifier;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttributeId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttributeId", "()Lsun/security/util/ObjectIdentifier;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAttributeValue;
#pragma warning disable 0169
		static Delegate GetGetAttributeValueHandler ()
		{
			if (cb_getAttributeValue == null)
				cb_getAttributeValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributeValue);
			return cb_getAttributeValue;
		}

		static IntPtr n_GetAttributeValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Pkcs.PKCS10Attribute __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AttributeValue);
		}
#pragma warning restore 0169

		static IntPtr id_getAttributeValue;
		public virtual unsafe global::Java.Lang.Object AttributeValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attribute']/method[@name='getAttributeValue' and count(parameter)=0]"
			[Register ("getAttributeValue", "()Ljava/lang/Object;", "GetGetAttributeValueHandler")]
			get {
				if (id_getAttributeValue == IntPtr.Zero)
					id_getAttributeValue = JNIEnv.GetMethodID (class_ref, "getAttributeValue", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttributeValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttributeValue", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_derEncode_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetDerEncode_Ljava_io_OutputStream_Handler ()
		{
			if (cb_derEncode_Ljava_io_OutputStream_ == null)
				cb_derEncode_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DerEncode_Ljava_io_OutputStream_);
			return cb_derEncode_Ljava_io_OutputStream_;
		}

		static void n_DerEncode_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.Pkcs.PKCS10Attribute __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Pkcs.PKCS10Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.DerEncode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_derEncode_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.pkcs']/class[@name='PKCS10Attribute']/method[@name='derEncode' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("derEncode", "(Ljava/io/OutputStream;)V", "GetDerEncode_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void DerEncode (global::System.IO.Stream @out)
		{
			if (id_derEncode_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_derEncode_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "derEncode", "(Ljava/io/OutputStream;)V");
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_derEncode_Ljava_io_OutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "derEncode", "(Ljava/io/OutputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

	}
}
