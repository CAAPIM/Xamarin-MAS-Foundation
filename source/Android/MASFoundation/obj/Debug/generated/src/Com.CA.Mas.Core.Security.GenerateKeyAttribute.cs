using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']"
	[global::Android.Runtime.Register ("com/ca/mas/core/security/GenerateKeyAttribute", DoNotGenerateAcw=true)]
	public partial class GenerateKeyAttribute : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/security/GenerateKeyAttribute", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenerateKeyAttribute); }
		}

		protected GenerateKeyAttribute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/constructor[@name='GenerateKeyAttribute' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GenerateKeyAttribute ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GenerateKeyAttribute)) {
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

		static Delegate cb_getDn;
#pragma warning disable 0169
		static Delegate GetGetDnHandler ()
		{
			if (cb_getDn == null)
				cb_getDn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDn);
			return cb_getDn;
		}

		static IntPtr n_GetDn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Dn);
		}
#pragma warning restore 0169

		static Delegate cb_setDn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDn_Ljava_lang_String_Handler ()
		{
			if (cb_setDn_Ljava_lang_String_ == null)
				cb_setDn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDn_Ljava_lang_String_);
			return cb_setDn_Ljava_lang_String_;
		}

		static void n_SetDn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dn)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string dn = JNIEnv.GetString (native_dn, JniHandleOwnership.DoNotTransfer);
			__this.Dn = dn;
		}
#pragma warning restore 0169

		static IntPtr id_getDn;
		static IntPtr id_setDn_Ljava_lang_String_;
		public virtual unsafe string Dn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='getDn' and count(parameter)=0]"
			[Register ("getDn", "()Ljava/lang/String;", "GetGetDnHandler")]
			get {
				if (id_getDn == IntPtr.Zero)
					id_getDn = JNIEnv.GetMethodID (class_ref, "getDn", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDn), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDn", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='setDn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDn", "(Ljava/lang/String;)V", "GetSetDn_Ljava_lang_String_Handler")]
			set {
				if (id_setDn_Ljava_lang_String_ == IntPtr.Zero)
					id_setDn_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDn", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDn_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDn", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isEncryptionRequired;
#pragma warning disable 0169
		static Delegate GetIsEncryptionRequiredHandler ()
		{
			if (cb_isEncryptionRequired == null)
				cb_isEncryptionRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEncryptionRequired);
			return cb_isEncryptionRequired;
		}

		static bool n_IsEncryptionRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EncryptionRequired;
		}
#pragma warning restore 0169

		static Delegate cb_setEncryptionRequired_Z;
#pragma warning disable 0169
		static Delegate GetSetEncryptionRequired_ZHandler ()
		{
			if (cb_setEncryptionRequired_Z == null)
				cb_setEncryptionRequired_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEncryptionRequired_Z);
			return cb_setEncryptionRequired_Z;
		}

		static void n_SetEncryptionRequired_Z (IntPtr jnienv, IntPtr native__this, bool encryptionRequired)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EncryptionRequired = encryptionRequired;
		}
#pragma warning restore 0169

		static IntPtr id_isEncryptionRequired;
		static IntPtr id_setEncryptionRequired_Z;
		public virtual unsafe bool EncryptionRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='isEncryptionRequired' and count(parameter)=0]"
			[Register ("isEncryptionRequired", "()Z", "GetIsEncryptionRequiredHandler")]
			get {
				if (id_isEncryptionRequired == IntPtr.Zero)
					id_isEncryptionRequired = JNIEnv.GetMethodID (class_ref, "isEncryptionRequired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEncryptionRequired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEncryptionRequired", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='setEncryptionRequired' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEncryptionRequired", "(Z)V", "GetSetEncryptionRequired_ZHandler")]
			set {
				if (id_setEncryptionRequired_Z == IntPtr.Zero)
					id_setEncryptionRequired_Z = JNIEnv.GetMethodID (class_ref, "setEncryptionRequired", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEncryptionRequired_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEncryptionRequired", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isInvalidatedByBiometricEnrollment;
#pragma warning disable 0169
		static Delegate GetIsInvalidatedByBiometricEnrollmentHandler ()
		{
			if (cb_isInvalidatedByBiometricEnrollment == null)
				cb_isInvalidatedByBiometricEnrollment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInvalidatedByBiometricEnrollment);
			return cb_isInvalidatedByBiometricEnrollment;
		}

		static bool n_IsInvalidatedByBiometricEnrollment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvalidatedByBiometricEnrollment;
		}
#pragma warning restore 0169

		static Delegate cb_setInvalidatedByBiometricEnrollment_Z;
#pragma warning disable 0169
		static Delegate GetSetInvalidatedByBiometricEnrollment_ZHandler ()
		{
			if (cb_setInvalidatedByBiometricEnrollment_Z == null)
				cb_setInvalidatedByBiometricEnrollment_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInvalidatedByBiometricEnrollment_Z);
			return cb_setInvalidatedByBiometricEnrollment_Z;
		}

		static void n_SetInvalidatedByBiometricEnrollment_Z (IntPtr jnienv, IntPtr native__this, bool invalidatedByBiometricEnrollment)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvalidatedByBiometricEnrollment = invalidatedByBiometricEnrollment;
		}
#pragma warning restore 0169

		static IntPtr id_isInvalidatedByBiometricEnrollment;
		static IntPtr id_setInvalidatedByBiometricEnrollment_Z;
		public virtual unsafe bool InvalidatedByBiometricEnrollment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='isInvalidatedByBiometricEnrollment' and count(parameter)=0]"
			[Register ("isInvalidatedByBiometricEnrollment", "()Z", "GetIsInvalidatedByBiometricEnrollmentHandler")]
			get {
				if (id_isInvalidatedByBiometricEnrollment == IntPtr.Zero)
					id_isInvalidatedByBiometricEnrollment = JNIEnv.GetMethodID (class_ref, "isInvalidatedByBiometricEnrollment", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInvalidatedByBiometricEnrollment);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInvalidatedByBiometricEnrollment", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='setInvalidatedByBiometricEnrollment' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setInvalidatedByBiometricEnrollment", "(Z)V", "GetSetInvalidatedByBiometricEnrollment_ZHandler")]
			set {
				if (id_setInvalidatedByBiometricEnrollment_Z == IntPtr.Zero)
					id_setInvalidatedByBiometricEnrollment_Z = JNIEnv.GetMethodID (class_ref, "setInvalidatedByBiometricEnrollment", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInvalidatedByBiometricEnrollment_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInvalidatedByBiometricEnrollment", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getKeySize;
#pragma warning disable 0169
		static Delegate GetGetKeySizeHandler ()
		{
			if (cb_getKeySize == null)
				cb_getKeySize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKeySize);
			return cb_getKeySize;
		}

		static int n_GetKeySize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeySize;
		}
#pragma warning restore 0169

		static Delegate cb_setKeySize_I;
#pragma warning disable 0169
		static Delegate GetSetKeySize_IHandler ()
		{
			if (cb_setKeySize_I == null)
				cb_setKeySize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetKeySize_I);
			return cb_setKeySize_I;
		}

		static void n_SetKeySize_I (IntPtr jnienv, IntPtr native__this, int keySize)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.KeySize = keySize;
		}
#pragma warning restore 0169

		static IntPtr id_getKeySize;
		static IntPtr id_setKeySize_I;
		public virtual unsafe int KeySize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='getKeySize' and count(parameter)=0]"
			[Register ("getKeySize", "()I", "GetGetKeySizeHandler")]
			get {
				if (id_getKeySize == IntPtr.Zero)
					id_getKeySize = JNIEnv.GetMethodID (class_ref, "getKeySize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKeySize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeySize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='setKeySize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setKeySize", "(I)V", "GetSetKeySize_IHandler")]
			set {
				if (id_setKeySize_I == IntPtr.Zero)
					id_setKeySize_I = JNIEnv.GetMethodID (class_ref, "setKeySize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeySize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeySize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUserAuthenticationRequired;
#pragma warning disable 0169
		static Delegate GetIsUserAuthenticationRequiredHandler ()
		{
			if (cb_isUserAuthenticationRequired == null)
				cb_isUserAuthenticationRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUserAuthenticationRequired);
			return cb_isUserAuthenticationRequired;
		}

		static bool n_IsUserAuthenticationRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserAuthenticationRequired;
		}
#pragma warning restore 0169

		static Delegate cb_setUserAuthenticationRequired_Z;
#pragma warning disable 0169
		static Delegate GetSetUserAuthenticationRequired_ZHandler ()
		{
			if (cb_setUserAuthenticationRequired_Z == null)
				cb_setUserAuthenticationRequired_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUserAuthenticationRequired_Z);
			return cb_setUserAuthenticationRequired_Z;
		}

		static void n_SetUserAuthenticationRequired_Z (IntPtr jnienv, IntPtr native__this, bool userAuthenticationRequired)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UserAuthenticationRequired = userAuthenticationRequired;
		}
#pragma warning restore 0169

		static IntPtr id_isUserAuthenticationRequired;
		static IntPtr id_setUserAuthenticationRequired_Z;
		public virtual unsafe bool UserAuthenticationRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='isUserAuthenticationRequired' and count(parameter)=0]"
			[Register ("isUserAuthenticationRequired", "()Z", "GetIsUserAuthenticationRequiredHandler")]
			get {
				if (id_isUserAuthenticationRequired == IntPtr.Zero)
					id_isUserAuthenticationRequired = JNIEnv.GetMethodID (class_ref, "isUserAuthenticationRequired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUserAuthenticationRequired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUserAuthenticationRequired", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='setUserAuthenticationRequired' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUserAuthenticationRequired", "(Z)V", "GetSetUserAuthenticationRequired_ZHandler")]
			set {
				if (id_setUserAuthenticationRequired_Z == IntPtr.Zero)
					id_setUserAuthenticationRequired_Z = JNIEnv.GetMethodID (class_ref, "setUserAuthenticationRequired", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserAuthenticationRequired_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserAuthenticationRequired", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUserAuthenticationValidityDurationSeconds;
#pragma warning disable 0169
		static Delegate GetGetUserAuthenticationValidityDurationSecondsHandler ()
		{
			if (cb_getUserAuthenticationValidityDurationSeconds == null)
				cb_getUserAuthenticationValidityDurationSeconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserAuthenticationValidityDurationSeconds);
			return cb_getUserAuthenticationValidityDurationSeconds;
		}

		static int n_GetUserAuthenticationValidityDurationSeconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserAuthenticationValidityDurationSeconds;
		}
#pragma warning restore 0169

		static Delegate cb_setUserAuthenticationValidityDurationSeconds_I;
#pragma warning disable 0169
		static Delegate GetSetUserAuthenticationValidityDurationSeconds_IHandler ()
		{
			if (cb_setUserAuthenticationValidityDurationSeconds_I == null)
				cb_setUserAuthenticationValidityDurationSeconds_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUserAuthenticationValidityDurationSeconds_I);
			return cb_setUserAuthenticationValidityDurationSeconds_I;
		}

		static void n_SetUserAuthenticationValidityDurationSeconds_I (IntPtr jnienv, IntPtr native__this, int userAuthenticationValidityDurationSeconds)
		{
			global::Com.CA.Mas.Core.Security.GenerateKeyAttribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Security.GenerateKeyAttribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UserAuthenticationValidityDurationSeconds = userAuthenticationValidityDurationSeconds;
		}
#pragma warning restore 0169

		static IntPtr id_getUserAuthenticationValidityDurationSeconds;
		static IntPtr id_setUserAuthenticationValidityDurationSeconds_I;
		public virtual unsafe int UserAuthenticationValidityDurationSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='getUserAuthenticationValidityDurationSeconds' and count(parameter)=0]"
			[Register ("getUserAuthenticationValidityDurationSeconds", "()I", "GetGetUserAuthenticationValidityDurationSecondsHandler")]
			get {
				if (id_getUserAuthenticationValidityDurationSeconds == IntPtr.Zero)
					id_getUserAuthenticationValidityDurationSeconds = JNIEnv.GetMethodID (class_ref, "getUserAuthenticationValidityDurationSeconds", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUserAuthenticationValidityDurationSeconds);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserAuthenticationValidityDurationSeconds", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.security']/class[@name='GenerateKeyAttribute']/method[@name='setUserAuthenticationValidityDurationSeconds' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUserAuthenticationValidityDurationSeconds", "(I)V", "GetSetUserAuthenticationValidityDurationSeconds_IHandler")]
			set {
				if (id_setUserAuthenticationValidityDurationSeconds_I == IntPtr.Zero)
					id_setUserAuthenticationValidityDurationSeconds_I = JNIEnv.GetMethodID (class_ref, "setUserAuthenticationValidityDurationSeconds", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserAuthenticationValidityDurationSeconds_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserAuthenticationValidityDurationSeconds", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
