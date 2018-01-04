using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Clientcredentials {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.clientcredentials']/class[@name='ClientCredentialsClient']"
	[global::Android.Runtime.Register ("com/ca/mas/core/clientcredentials/ClientCredentialsClient", DoNotGenerateAcw=true)]
	public partial class ClientCredentialsClient : global::Com.CA.Mas.Core.Client.ServerClient {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/clientcredentials/ClientCredentialsClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientCredentialsClient); }
		}

		protected ClientCredentialsClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.clientcredentials']/class[@name='ClientCredentialsClient']/constructor[@name='ClientCredentialsClient' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register (".ctor", "(Lcom/ca/mas/core/context/MssoContext;)V", "")]
		public unsafe ClientCredentialsClient (global::Com.CA.Mas.Core.Context.MssoContext mssoContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mssoContext);
				if (((object) this).GetType () != typeof (ClientCredentialsClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/core/context/MssoContext;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/core/context/MssoContext;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/core/context/MssoContext;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_core_context_MssoContext_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_core_context_MssoContext_, __args);
			} finally {
			}
		}

		static Delegate cb_getClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_masterClientId, IntPtr native_nonce, IntPtr native_deviceId)
		{
			global::Com.CA.Mas.Core.Clientcredentials.ClientCredentialsClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Clientcredentials.ClientCredentialsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string masterClientId = JNIEnv.GetString (native_masterClientId, JniHandleOwnership.DoNotTransfer);
			string nonce = JNIEnv.GetString (native_nonce, JniHandleOwnership.DoNotTransfer);
			string deviceId = JNIEnv.GetString (native_deviceId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetClientCredentials (masterClientId, nonce, deviceId));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.clientcredentials']/class[@name='ClientCredentialsClient']/method[@name='getClientCredentials' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getClientCredentials", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/token/ClientCredentials;", "GetGetClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.CA.Mas.Core.Token.ClientCredentials GetClientCredentials (string masterClientId, string nonce, string deviceId)
		{
			if (id_getClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getClientCredentials", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/token/ClientCredentials;");
			IntPtr native_masterClientId = JNIEnv.NewString (masterClientId);
			IntPtr native_nonce = JNIEnv.NewString (nonce);
			IntPtr native_deviceId = JNIEnv.NewString (deviceId);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_masterClientId);
				__args [1] = new JValue (native_nonce);
				__args [2] = new JValue (native_deviceId);

				global::Com.CA.Mas.Core.Token.ClientCredentials __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.ClientCredentials> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientCredentials_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.ClientCredentials> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientCredentials", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/ca/mas/core/token/ClientCredentials;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_masterClientId);
				JNIEnv.DeleteLocalRef (native_nonce);
				JNIEnv.DeleteLocalRef (native_deviceId);
			}
		}

	}
}
