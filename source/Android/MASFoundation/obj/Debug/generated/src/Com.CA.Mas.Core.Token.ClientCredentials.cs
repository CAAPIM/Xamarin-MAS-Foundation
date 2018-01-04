using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Token {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='ClientCredentials']"
	[global::Android.Runtime.Register ("com/ca/mas/core/token/ClientCredentials", DoNotGenerateAcw=true)]
	public partial class ClientCredentials : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/token/ClientCredentials", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientCredentials); }
		}

		protected ClientCredentials (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='ClientCredentials']/constructor[@name='ClientCredentials' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;)V", "")]
		public unsafe ClientCredentials (string masterClientId, string clientId, string clientSecret, global::Java.Lang.Long clientExpiration)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_masterClientId = JNIEnv.NewString (masterClientId);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_clientSecret = JNIEnv.NewString (clientSecret);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_masterClientId);
				__args [1] = new JValue (native_clientId);
				__args [2] = new JValue (native_clientSecret);
				__args [3] = new JValue (clientExpiration);
				if (((object) this).GetType () != typeof (ClientCredentials)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_masterClientId);
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		static Delegate cb_getClientExpiration;
#pragma warning disable 0169
		static Delegate GetGetClientExpirationHandler ()
		{
			if (cb_getClientExpiration == null)
				cb_getClientExpiration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientExpiration);
			return cb_getClientExpiration;
		}

		static IntPtr n_GetClientExpiration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Token.ClientCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.ClientCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientExpiration);
		}
#pragma warning restore 0169

		static IntPtr id_getClientExpiration;
		public virtual unsafe global::Java.Lang.Long ClientExpiration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='ClientCredentials']/method[@name='getClientExpiration' and count(parameter)=0]"
			[Register ("getClientExpiration", "()Ljava/lang/Long;", "GetGetClientExpirationHandler")]
			get {
				if (id_getClientExpiration == IntPtr.Zero)
					id_getClientExpiration = JNIEnv.GetMethodID (class_ref, "getClientExpiration", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientExpiration), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientExpiration", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Token.ClientCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.ClientCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='ClientCredentials']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientSecret;
#pragma warning disable 0169
		static Delegate GetGetClientSecretHandler ()
		{
			if (cb_getClientSecret == null)
				cb_getClientSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientSecret);
			return cb_getClientSecret;
		}

		static IntPtr n_GetClientSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Token.ClientCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.ClientCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getClientSecret;
		public virtual unsafe string ClientSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='ClientCredentials']/method[@name='getClientSecret' and count(parameter)=0]"
			[Register ("getClientSecret", "()Ljava/lang/String;", "GetGetClientSecretHandler")]
			get {
				if (id_getClientSecret == IntPtr.Zero)
					id_getClientSecret = JNIEnv.GetMethodID (class_ref, "getClientSecret", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientSecret), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMasterClientId;
#pragma warning disable 0169
		static Delegate GetGetMasterClientIdHandler ()
		{
			if (cb_getMasterClientId == null)
				cb_getMasterClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMasterClientId);
			return cb_getMasterClientId;
		}

		static IntPtr n_GetMasterClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Token.ClientCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.ClientCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MasterClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getMasterClientId;
		public virtual unsafe string MasterClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='ClientCredentials']/method[@name='getMasterClientId' and count(parameter)=0]"
			[Register ("getMasterClientId", "()Ljava/lang/String;", "GetGetMasterClientIdHandler")]
			get {
				if (id_getMasterClientId == IntPtr.Zero)
					id_getMasterClientId = JNIEnv.GetMethodID (class_ref, "getMasterClientId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMasterClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMasterClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
