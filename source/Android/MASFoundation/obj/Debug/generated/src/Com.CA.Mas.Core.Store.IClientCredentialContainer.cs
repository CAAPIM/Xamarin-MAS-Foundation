using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Store {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='ClientCredentialContainer']"
	[Register ("com/ca/mas/core/store/ClientCredentialContainer", "", "Com.CA.Mas.Core.Store.IClientCredentialContainerInvoker")]
	public partial interface IClientCredentialContainer : IJavaObject {

		global::Java.Lang.Long ClientExpiration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='ClientCredentialContainer']/method[@name='getClientExpiration' and count(parameter)=0]"
			[Register ("getClientExpiration", "()Ljava/lang/Long;", "GetGetClientExpirationHandler:Com.CA.Mas.Core.Store.IClientCredentialContainerInvoker, MASFoundation")] get;
		}

		string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='ClientCredentialContainer']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler:Com.CA.Mas.Core.Store.IClientCredentialContainerInvoker, MASFoundation")] get;
		}

		string ClientSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='ClientCredentialContainer']/method[@name='getClientSecret' and count(parameter)=0]"
			[Register ("getClientSecret", "()Ljava/lang/String;", "GetGetClientSecretHandler:Com.CA.Mas.Core.Store.IClientCredentialContainerInvoker, MASFoundation")] get;
		}

		string MasterClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='ClientCredentialContainer']/method[@name='getMasterClientId' and count(parameter)=0]"
			[Register ("getMasterClientId", "()Ljava/lang/String;", "GetGetMasterClientIdHandler:Com.CA.Mas.Core.Store.IClientCredentialContainerInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='ClientCredentialContainer']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.CA.Mas.Core.Store.IClientCredentialContainerInvoker, MASFoundation")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='ClientCredentialContainer']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler:Com.CA.Mas.Core.Store.IClientCredentialContainerInvoker, MASFoundation")]
		void ClearAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='ClientCredentialContainer']/method[@name='saveClientCredentials' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.token.ClientCredentials']]"
		[Register ("saveClientCredentials", "(Lcom/ca/mas/core/token/ClientCredentials;)V", "GetSaveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_Handler:Com.CA.Mas.Core.Store.IClientCredentialContainerInvoker, MASFoundation")]
		void SaveClientCredentials (global::Com.CA.Mas.Core.Token.ClientCredentials p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/store/ClientCredentialContainer", DoNotGenerateAcw=true)]
	internal class IClientCredentialContainerInvoker : global::Java.Lang.Object, IClientCredentialContainer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/store/ClientCredentialContainer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IClientCredentialContainerInvoker); }
		}

		IntPtr class_ref;

		public static IClientCredentialContainer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClientCredentialContainer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.store.ClientCredentialContainer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClientCredentialContainerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.CA.Mas.Core.Store.IClientCredentialContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IClientCredentialContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientExpiration);
		}
#pragma warning restore 0169

		IntPtr id_getClientExpiration;
		public unsafe global::Java.Lang.Long ClientExpiration {
			get {
				if (id_getClientExpiration == IntPtr.Zero)
					id_getClientExpiration = JNIEnv.GetMethodID (class_ref, "getClientExpiration", "()Ljava/lang/Long;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientExpiration), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Store.IClientCredentialContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IClientCredentialContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		IntPtr id_getClientId;
		public unsafe string ClientId {
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Store.IClientCredentialContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IClientCredentialContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientSecret);
		}
#pragma warning restore 0169

		IntPtr id_getClientSecret;
		public unsafe string ClientSecret {
			get {
				if (id_getClientSecret == IntPtr.Zero)
					id_getClientSecret = JNIEnv.GetMethodID (class_ref, "getClientSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientSecret), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Store.IClientCredentialContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IClientCredentialContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MasterClientId);
		}
#pragma warning restore 0169

		IntPtr id_getMasterClientId;
		public unsafe string MasterClientId {
			get {
				if (id_getMasterClientId == IntPtr.Zero)
					id_getMasterClientId = JNIEnv.GetMethodID (class_ref, "getMasterClientId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMasterClientId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.IClientCredentialContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IClientCredentialContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_clearAll;
#pragma warning disable 0169
		static Delegate GetClearAllHandler ()
		{
			if (cb_clearAll == null)
				cb_clearAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAll);
			return cb_clearAll;
		}

		static void n_ClearAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.IClientCredentialContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IClientCredentialContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAll ();
		}
#pragma warning restore 0169

		IntPtr id_clearAll;
		public unsafe void ClearAll ()
		{
			if (id_clearAll == IntPtr.Zero)
				id_clearAll = JNIEnv.GetMethodID (class_ref, "clearAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAll);
		}

		static Delegate cb_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_;
#pragma warning disable 0169
		static Delegate GetSaveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_Handler ()
		{
			if (cb_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ == null)
				cb_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_);
			return cb_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_;
		}

		static void n_SaveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Store.IClientCredentialContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IClientCredentialContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Token.ClientCredentials p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.ClientCredentials> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveClientCredentials (p0);
		}
#pragma warning restore 0169

		IntPtr id_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_;
		public unsafe void SaveClientCredentials (global::Com.CA.Mas.Core.Token.ClientCredentials p0)
		{
			if (id_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ == IntPtr.Zero)
				id_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ = JNIEnv.GetMethodID (class_ref, "saveClientCredentials", "(Lcom/ca/mas/core/token/ClientCredentials;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_, __args);
		}

	}

}
