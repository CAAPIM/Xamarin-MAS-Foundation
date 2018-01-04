using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Context {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']"
	[global::Android.Runtime.Register ("com/ca/mas/core/context/MssoContext", DoNotGenerateAcw=true)]
	public partial class MssoContext : global::Java.Lang.Object {


		static IntPtr containerDescription_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/field[@name='containerDescription']"
		[Register ("containerDescription")]
		protected string ContainerDescription {
			get {
				if (containerDescription_jfieldId == IntPtr.Zero)
					containerDescription_jfieldId = JNIEnv.GetFieldID (class_ref, "containerDescription", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, containerDescription_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (containerDescription_jfieldId == IntPtr.Zero)
					containerDescription_jfieldId = JNIEnv.GetFieldID (class_ref, "containerDescription", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, containerDescription_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/context/MssoContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MssoContext); }
		}

		protected MssoContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static IntPtr id_getAccessToken;
		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAccessTokenExpiry;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenExpiryHandler ()
		{
			if (cb_getAccessTokenExpiry == null)
				cb_getAccessTokenExpiry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAccessTokenExpiry);
			return cb_getAccessTokenExpiry;
		}

		static long n_GetAccessTokenExpiry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AccessTokenExpiry;
		}
#pragma warning restore 0169

		static IntPtr id_getAccessTokenExpiry;
		public virtual unsafe long AccessTokenExpiry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getAccessTokenExpiry' and count(parameter)=0]"
			[Register ("getAccessTokenExpiry", "()J", "GetGetAccessTokenExpiryHandler")]
			get {
				if (id_getAccessTokenExpiry == IntPtr.Zero)
					id_getAccessTokenExpiry = JNIEnv.GetMethodID (class_ref, "getAccessTokenExpiry", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAccessTokenExpiry);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessTokenExpiry", "()J"));
				} finally {
				}
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
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientExpiration);
		}
#pragma warning restore 0169

		static IntPtr id_getClientExpiration;
		public virtual unsafe global::Java.Lang.Long ClientExpiration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getClientExpiration' and count(parameter)=0]"
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
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getClientId' and count(parameter)=0]"
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
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getClientSecret;
		public virtual unsafe string ClientSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getClientSecret' and count(parameter)=0]"
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

		static Delegate cb_getConfigurationProvider;
#pragma warning disable 0169
		static Delegate GetGetConfigurationProviderHandler ()
		{
			if (cb_getConfigurationProvider == null)
				cb_getConfigurationProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfigurationProvider);
			return cb_getConfigurationProvider;
		}

		static IntPtr n_GetConfigurationProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConfigurationProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getConfigurationProvider;
		public virtual unsafe global::Com.CA.Mas.Core.Conf.IConfigurationProvider ConfigurationProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getConfigurationProvider' and count(parameter)=0]"
			[Register ("getConfigurationProvider", "()Lcom/ca/mas/core/conf/ConfigurationProvider;", "GetGetConfigurationProviderHandler")]
			get {
				if (id_getConfigurationProvider == IntPtr.Zero)
					id_getConfigurationProvider = JNIEnv.GetMethodID (class_ref, "getConfigurationProvider", "()Lcom/ca/mas/core/conf/ConfigurationProvider;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfigurationProvider), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfigurationProvider", "()Lcom/ca/mas/core/conf/ConfigurationProvider;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCredentials;
#pragma warning disable 0169
		static Delegate GetGetCredentialsHandler ()
		{
			if (cb_getCredentials == null)
				cb_getCredentials = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCredentials);
			return cb_getCredentials;
		}

		static IntPtr n_GetCredentials (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Credentials);
		}
#pragma warning restore 0169

		static Delegate cb_setCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_;
#pragma warning disable 0169
		static Delegate GetSetCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_Handler ()
		{
			if (cb_setCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_ == null)
				cb_setCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_);
			return cb_setCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_;
		}

		static void n_SetCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_ (IntPtr jnienv, IntPtr native__this, IntPtr native_credentials)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.IMASAuthCredentials credentials = (global::Com.CA.Mas.Foundation.IMASAuthCredentials)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (native_credentials, JniHandleOwnership.DoNotTransfer);
			__this.Credentials = credentials;
		}
#pragma warning restore 0169

		static IntPtr id_getCredentials;
		static IntPtr id_setCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_;
		public virtual unsafe global::Com.CA.Mas.Foundation.IMASAuthCredentials Credentials {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getCredentials' and count(parameter)=0]"
			[Register ("getCredentials", "()Lcom/ca/mas/foundation/MASAuthCredentials;", "GetGetCredentialsHandler")]
			get {
				if (id_getCredentials == IntPtr.Zero)
					id_getCredentials = JNIEnv.GetMethodID (class_ref, "getCredentials", "()Lcom/ca/mas/foundation/MASAuthCredentials;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCredentials), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCredentials", "()Lcom/ca/mas/foundation/MASAuthCredentials;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='setCredentials' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASAuthCredentials']]"
			[Register ("setCredentials", "(Lcom/ca/mas/foundation/MASAuthCredentials;)V", "GetSetCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_Handler")]
			set {
				if (id_setCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_ == IntPtr.Zero)
					id_setCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_ = JNIEnv.GetMethodID (class_ref, "setCredentials", "(Lcom/ca/mas/foundation/MASAuthCredentials;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCredentials_Lcom_ca_mas_foundation_MASAuthCredentials_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCredentials", "(Lcom/ca/mas/foundation/MASAuthCredentials;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceId;
		public virtual unsafe string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				if (id_getDeviceId == IntPtr.Zero)
					id_getDeviceId = JNIEnv.GetMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceName;
#pragma warning disable 0169
		static Delegate GetGetDeviceNameHandler ()
		{
			if (cb_getDeviceName == null)
				cb_getDeviceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceName);
			return cb_getDeviceName;
		}

		static IntPtr n_GetDeviceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceName);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceName;
		public virtual unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler")]
			get {
				if (id_getDeviceName == IntPtr.Zero)
					id_getDeviceName = JNIEnv.GetMethodID (class_ref, "getDeviceName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGrantedScope;
#pragma warning disable 0169
		static Delegate GetGetGrantedScopeHandler ()
		{
			if (cb_getGrantedScope == null)
				cb_getGrantedScope = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGrantedScope);
			return cb_getGrantedScope;
		}

		static IntPtr n_GetGrantedScope (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GrantedScope);
		}
#pragma warning restore 0169

		static IntPtr id_getGrantedScope;
		public virtual unsafe string GrantedScope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getGrantedScope' and count(parameter)=0]"
			[Register ("getGrantedScope", "()Ljava/lang/String;", "GetGetGrantedScopeHandler")]
			get {
				if (id_getGrantedScope == IntPtr.Zero)
					id_getGrantedScope = JNIEnv.GetMethodID (class_ref, "getGrantedScope", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGrantedScope), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGrantedScope", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIdToken;
#pragma warning disable 0169
		static Delegate GetGetIdTokenHandler ()
		{
			if (cb_getIdToken == null)
				cb_getIdToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdToken);
			return cb_getIdToken;
		}

		static IntPtr n_GetIdToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IdToken);
		}
#pragma warning restore 0169

		static IntPtr id_getIdToken;
		public virtual unsafe global::Com.CA.Mas.Core.Token.IdToken IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getIdToken' and count(parameter)=0]"
			[Register ("getIdToken", "()Lcom/ca/mas/core/token/IdToken;", "GetGetIdTokenHandler")]
			get {
				if (id_getIdToken == IntPtr.Zero)
					id_getIdToken = JNIEnv.GetMethodID (class_ref, "getIdToken", "()Lcom/ca/mas/core/token/IdToken;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.IdToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdToken), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.IdToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdToken", "()Lcom/ca/mas/core/token/IdToken;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDeviceRegistered;
#pragma warning disable 0169
		static Delegate GetIsDeviceRegisteredHandler ()
		{
			if (cb_isDeviceRegistered == null)
				cb_isDeviceRegistered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeviceRegistered);
			return cb_isDeviceRegistered;
		}

		static bool n_IsDeviceRegistered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeviceRegistered;
		}
#pragma warning restore 0169

		static IntPtr id_isDeviceRegistered;
		public virtual unsafe bool IsDeviceRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='isDeviceRegistered' and count(parameter)=0]"
			[Register ("isDeviceRegistered", "()Z", "GetIsDeviceRegisteredHandler")]
			get {
				if (id_isDeviceRegistered == IntPtr.Zero)
					id_isDeviceRegistered = JNIEnv.GetMethodID (class_ref, "isDeviceRegistered", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDeviceRegistered);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeviceRegistered", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		static IntPtr id_isInitialized;
		public virtual unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInitialized", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLogin;
#pragma warning disable 0169
		static Delegate GetIsLoginHandler ()
		{
			if (cb_isLogin == null)
				cb_isLogin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLogin);
			return cb_isLogin;
		}

		static bool n_IsLogin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLogin;
		}
#pragma warning restore 0169

		static IntPtr id_isLogin;
		public virtual unsafe bool IsLogin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='isLogin' and count(parameter)=0]"
			[Register ("isLogin", "()Z", "GetIsLoginHandler")]
			get {
				if (id_isLogin == IntPtr.Zero)
					id_isLogin = JNIEnv.GetMethodID (class_ref, "isLogin", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLogin);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLogin", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSsoEnabled;
#pragma warning disable 0169
		static Delegate GetIsSsoEnabledHandler ()
		{
			if (cb_isSsoEnabled == null)
				cb_isSsoEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSsoEnabled);
			return cb_isSsoEnabled;
		}

		static bool n_IsSsoEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSsoEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isSsoEnabled;
		public virtual unsafe bool IsSsoEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='isSsoEnabled' and count(parameter)=0]"
			[Register ("isSsoEnabled", "()Z", "GetIsSsoEnabledHandler")]
			get {
				if (id_isSsoEnabled == IntPtr.Zero)
					id_isSsoEnabled = JNIEnv.GetMethodID (class_ref, "isSsoEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSsoEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSsoEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMAGHttpClient;
#pragma warning disable 0169
		static Delegate GetGetMAGHttpClientHandler ()
		{
			if (cb_getMAGHttpClient == null)
				cb_getMAGHttpClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMAGHttpClient);
			return cb_getMAGHttpClient;
		}

		static IntPtr n_GetMAGHttpClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MAGHttpClient);
		}
#pragma warning restore 0169

		static IntPtr id_getMAGHttpClient;
		public virtual unsafe global::Com.CA.Mas.Core.Http.MAGHttpClient MAGHttpClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getMAGHttpClient' and count(parameter)=0]"
			[Register ("getMAGHttpClient", "()Lcom/ca/mas/core/http/MAGHttpClient;", "GetGetMAGHttpClientHandler")]
			get {
				if (id_getMAGHttpClient == IntPtr.Zero)
					id_getMAGHttpClient = JNIEnv.GetMethodID (class_ref, "getMAGHttpClient", "()Lcom/ca/mas/core/http/MAGHttpClient;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGHttpClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMAGHttpClient), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGHttpClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMAGHttpClient", "()Lcom/ca/mas/core/http/MAGHttpClient;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRefreshToken;
#pragma warning disable 0169
		static Delegate GetGetRefreshTokenHandler ()
		{
			if (cb_getRefreshToken == null)
				cb_getRefreshToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRefreshToken);
			return cb_getRefreshToken;
		}

		static IntPtr n_GetRefreshToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		static IntPtr id_getRefreshToken;
		public virtual unsafe string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler")]
			get {
				if (id_getRefreshToken == IntPtr.Zero)
					id_getRefreshToken = JNIEnv.GetMethodID (class_ref, "getRefreshToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefreshToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRefreshToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStoredClientId;
#pragma warning disable 0169
		static Delegate GetGetStoredClientIdHandler ()
		{
			if (cb_getStoredClientId == null)
				cb_getStoredClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStoredClientId);
			return cb_getStoredClientId;
		}

		static IntPtr n_GetStoredClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StoredClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getStoredClientId;
		public virtual unsafe string StoredClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getStoredClientId' and count(parameter)=0]"
			[Register ("getStoredClientId", "()Ljava/lang/String;", "GetGetStoredClientIdHandler")]
			get {
				if (id_getStoredClientId == IntPtr.Zero)
					id_getStoredClientId = JNIEnv.GetMethodID (class_ref, "getStoredClientId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStoredClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStoredClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenManager;
#pragma warning disable 0169
		static Delegate GetGetTokenManagerHandler ()
		{
			if (cb_getTokenManager == null)
				cb_getTokenManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenManager);
			return cb_getTokenManager;
		}

		static IntPtr n_GetTokenManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TokenManager);
		}
#pragma warning restore 0169

		static IntPtr id_getTokenManager;
		public virtual unsafe global::Com.CA.Mas.Core.Store.ITokenManager TokenManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='getTokenManager' and count(parameter)=0]"
			[Register ("getTokenManager", "()Lcom/ca/mas/core/store/TokenManager;", "GetGetTokenManagerHandler")]
			get {
				if (id_getTokenManager == IntPtr.Zero)
					id_getTokenManager = JNIEnv.GetMethodID (class_ref, "getTokenManager", "()Lcom/ca/mas/core/store/TokenManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenManager", "()Lcom/ca/mas/core/store/TokenManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearAccessToken;
#pragma warning disable 0169
		static Delegate GetClearAccessTokenHandler ()
		{
			if (cb_clearAccessToken == null)
				cb_clearAccessToken = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAccessToken);
			return cb_clearAccessToken;
		}

		static void n_ClearAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAccessToken ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAccessToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='clearAccessToken' and count(parameter)=0]"
		[Register ("clearAccessToken", "()V", "GetClearAccessTokenHandler")]
		public virtual unsafe void ClearAccessToken ()
		{
			if (id_clearAccessToken == IntPtr.Zero)
				id_clearAccessToken = JNIEnv.GetMethodID (class_ref, "clearAccessToken", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAccessToken);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAccessToken", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearClientCredentials;
#pragma warning disable 0169
		static Delegate GetClearClientCredentialsHandler ()
		{
			if (cb_clearClientCredentials == null)
				cb_clearClientCredentials = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearClientCredentials);
			return cb_clearClientCredentials;
		}

		static void n_ClearClientCredentials (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearClientCredentials ();
		}
#pragma warning restore 0169

		static IntPtr id_clearClientCredentials;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='clearClientCredentials' and count(parameter)=0]"
		[Register ("clearClientCredentials", "()V", "GetClearClientCredentialsHandler")]
		public virtual unsafe void ClearClientCredentials ()
		{
			if (id_clearClientCredentials == IntPtr.Zero)
				id_clearClientCredentials = JNIEnv.GetMethodID (class_ref, "clearClientCredentials", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearClientCredentials);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearClientCredentials", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearCredentials;
#pragma warning disable 0169
		static Delegate GetClearCredentialsHandler ()
		{
			if (cb_clearCredentials == null)
				cb_clearCredentials = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearCredentials);
			return cb_clearCredentials;
		}

		static void n_ClearCredentials (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCredentials ();
		}
#pragma warning restore 0169

		static IntPtr id_clearCredentials;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='clearCredentials' and count(parameter)=0]"
		[Register ("clearCredentials", "()V", "GetClearCredentialsHandler")]
		public virtual unsafe void ClearCredentials ()
		{
			if (id_clearCredentials == IntPtr.Zero)
				id_clearCredentials = JNIEnv.GetMethodID (class_ref, "clearCredentials", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearCredentials);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearCredentials", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearIdToken;
#pragma warning disable 0169
		static Delegate GetClearIdTokenHandler ()
		{
			if (cb_clearIdToken == null)
				cb_clearIdToken = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearIdToken);
			return cb_clearIdToken;
		}

		static void n_ClearIdToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearIdToken ();
		}
#pragma warning restore 0169

		static IntPtr id_clearIdToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='clearIdToken' and count(parameter)=0]"
		[Register ("clearIdToken", "()V", "GetClearIdTokenHandler")]
		public virtual unsafe void ClearIdToken ()
		{
			if (id_clearIdToken == IntPtr.Zero)
				id_clearIdToken = JNIEnv.GetMethodID (class_ref, "clearIdToken", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearIdToken);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearIdToken", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearUserProfile;
#pragma warning disable 0169
		static Delegate GetClearUserProfileHandler ()
		{
			if (cb_clearUserProfile == null)
				cb_clearUserProfile = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearUserProfile);
			return cb_clearUserProfile;
		}

		static void n_ClearUserProfile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearUserProfile ();
		}
#pragma warning restore 0169

		static IntPtr id_clearUserProfile;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='clearUserProfile' and count(parameter)=0]"
		[Register ("clearUserProfile", "()V", "GetClearUserProfileHandler")]
		public virtual unsafe void ClearUserProfile ()
		{
			if (id_clearUserProfile == IntPtr.Zero)
				id_clearUserProfile = JNIEnv.GetMethodID (class_ref, "clearUserProfile", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearUserProfile);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearUserProfile", "()V"));
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_destroyAllPersistentTokens;
#pragma warning disable 0169
		static Delegate GetDestroyAllPersistentTokensHandler ()
		{
			if (cb_destroyAllPersistentTokens == null)
				cb_destroyAllPersistentTokens = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DestroyAllPersistentTokens);
			return cb_destroyAllPersistentTokens;
		}

		static void n_DestroyAllPersistentTokens (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DestroyAllPersistentTokens ();
		}
#pragma warning restore 0169

		static IntPtr id_destroyAllPersistentTokens;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='destroyAllPersistentTokens' and count(parameter)=0]"
		[Register ("destroyAllPersistentTokens", "()V", "GetDestroyAllPersistentTokensHandler")]
		public virtual unsafe void DestroyAllPersistentTokens ()
		{
			if (id_destroyAllPersistentTokens == IntPtr.Zero)
				id_destroyAllPersistentTokens = JNIEnv.GetMethodID (class_ref, "destroyAllPersistentTokens", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyAllPersistentTokens);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroyAllPersistentTokens", "()V"));
			} finally {
			}
		}

		static Delegate cb_destroyPersistentTokens;
#pragma warning disable 0169
		static Delegate GetDestroyPersistentTokensHandler ()
		{
			if (cb_destroyPersistentTokens == null)
				cb_destroyPersistentTokens = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DestroyPersistentTokens);
			return cb_destroyPersistentTokens;
		}

		static void n_DestroyPersistentTokens (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DestroyPersistentTokens ();
		}
#pragma warning restore 0169

		static IntPtr id_destroyPersistentTokens;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='destroyPersistentTokens' and count(parameter)=0]"
		[Register ("destroyPersistentTokens", "()V", "GetDestroyPersistentTokensHandler")]
		public virtual unsafe void DestroyPersistentTokens ()
		{
			if (id_destroyPersistentTokens == IntPtr.Zero)
				id_destroyPersistentTokens = JNIEnv.GetMethodID (class_ref, "destroyPersistentTokens", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroyPersistentTokens);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroyPersistentTokens", "()V"));
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Init (context);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context context)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_initPolicyManager;
#pragma warning disable 0169
		static Delegate GetInitPolicyManagerHandler ()
		{
			if (cb_initPolicyManager == null)
				cb_initPolicyManager = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitPolicyManager);
			return cb_initPolicyManager;
		}

		static void n_InitPolicyManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitPolicyManager ();
		}
#pragma warning restore 0169

		static IntPtr id_initPolicyManager;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='initPolicyManager' and count(parameter)=0]"
		[Register ("initPolicyManager", "()V", "GetInitPolicyManagerHandler")]
		public virtual unsafe void InitPolicyManager ()
		{
			if (id_initPolicyManager == IntPtr.Zero)
				id_initPolicyManager = JNIEnv.GetMethodID (class_ref, "initPolicyManager", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initPolicyManager);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initPolicyManager", "()V"));
			} finally {
			}
		}

		static Delegate cb_isClientCredentialExpired_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetIsClientCredentialExpired_Ljava_lang_Long_Handler ()
		{
			if (cb_isClientCredentialExpired_Ljava_lang_Long_ == null)
				cb_isClientCredentialExpired_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsClientCredentialExpired_Ljava_lang_Long_);
			return cb_isClientCredentialExpired_Ljava_lang_Long_;
		}

		static bool n_IsClientCredentialExpired_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientExpiration)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long clientExpiration = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_clientExpiration, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsClientCredentialExpired (clientExpiration);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isClientCredentialExpired_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='isClientCredentialExpired' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("isClientCredentialExpired", "(Ljava/lang/Long;)Z", "GetIsClientCredentialExpired_Ljava_lang_Long_Handler")]
		public virtual unsafe bool IsClientCredentialExpired (global::Java.Lang.Long clientExpiration)
		{
			if (id_isClientCredentialExpired_Ljava_lang_Long_ == IntPtr.Zero)
				id_isClientCredentialExpired_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "isClientCredentialExpired", "(Ljava/lang/Long;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clientExpiration);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClientCredentialExpired_Ljava_lang_Long_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isClientCredentialExpired", "(Ljava/lang/Long;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_logout_Z;
#pragma warning disable 0169
		static Delegate GetLogout_ZHandler ()
		{
			if (cb_logout_Z == null)
				cb_logout_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Logout_Z);
			return cb_logout_Z;
		}

		static void n_Logout_Z (IntPtr jnienv, IntPtr native__this, bool contactServer)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Logout (contactServer);
		}
#pragma warning restore 0169

		static IntPtr id_logout_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='logout' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("logout", "(Z)V", "GetLogout_ZHandler")]
		public virtual unsafe void Logout (bool contactServer)
		{
			if (id_logout_Z == IntPtr.Zero)
				id_logout_Z = JNIEnv.GetMethodID (class_ref, "logout", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (contactServer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Z)V"), __args);
			} finally {
			}
		}

		static IntPtr id_newContext;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='newContext' and count(parameter)=0]"
		[Register ("newContext", "()Lcom/ca/mas/core/context/MssoContext;", "")]
		public static unsafe global::Com.CA.Mas.Core.Context.MssoContext NewContext ()
		{
			if (id_newContext == IntPtr.Zero)
				id_newContext = JNIEnv.GetStaticMethodID (class_ref, "newContext", "()Lcom/ca/mas/core/context/MssoContext;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newContext), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Handler ()
		{
			if (cb_onAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ == null)
				cb_onAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_);
			return cb_onAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
		}

		static void n_OnAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessToken, IntPtr native_refreshToken, long expiresInSec, IntPtr native_grantedScope)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string accessToken = JNIEnv.GetString (native_accessToken, JniHandleOwnership.DoNotTransfer);
			string refreshToken = JNIEnv.GetString (native_refreshToken, JniHandleOwnership.DoNotTransfer);
			string grantedScope = JNIEnv.GetString (native_grantedScope, JniHandleOwnership.DoNotTransfer);
			__this.OnAccessTokenAvailable (accessToken, refreshToken, expiresInSec, grantedScope);
		}
#pragma warning restore 0169

		static IntPtr id_onAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='onAccessTokenAvailable' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("onAccessTokenAvailable", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V", "GetOnAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Handler")]
		public virtual unsafe void OnAccessTokenAvailable (string accessToken, string refreshToken, long expiresInSec, string grantedScope)
		{
			if (id_onAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ == IntPtr.Zero)
				id_onAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAccessTokenAvailable", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V");
			IntPtr native_accessToken = JNIEnv.NewString (accessToken);
			IntPtr native_refreshToken = JNIEnv.NewString (refreshToken);
			IntPtr native_grantedScope = JNIEnv.NewString (grantedScope);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_accessToken);
				__args [1] = new JValue (native_refreshToken);
				__args [2] = new JValue (expiresInSec);
				__args [3] = new JValue (native_grantedScope);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccessTokenAvailable_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAccessTokenAvailable", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accessToken);
				JNIEnv.DeleteLocalRef (native_refreshToken);
				JNIEnv.DeleteLocalRef (native_grantedScope);
			}
		}

		static Delegate cb_onDeviceRegistrationCompleted;
#pragma warning disable 0169
		static Delegate GetOnDeviceRegistrationCompletedHandler ()
		{
			if (cb_onDeviceRegistrationCompleted == null)
				cb_onDeviceRegistrationCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDeviceRegistrationCompleted);
			return cb_onDeviceRegistrationCompleted;
		}

		static void n_OnDeviceRegistrationCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDeviceRegistrationCompleted ();
		}
#pragma warning restore 0169

		static IntPtr id_onDeviceRegistrationCompleted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='onDeviceRegistrationCompleted' and count(parameter)=0]"
		[Register ("onDeviceRegistrationCompleted", "()V", "GetOnDeviceRegistrationCompletedHandler")]
		public virtual unsafe void OnDeviceRegistrationCompleted ()
		{
			if (id_onDeviceRegistrationCompleted == IntPtr.Zero)
				id_onDeviceRegistrationCompleted = JNIEnv.GetMethodID (class_ref, "onDeviceRegistrationCompleted", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDeviceRegistrationCompleted);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDeviceRegistrationCompleted", "()V"));
			} finally {
			}
		}

		static Delegate cb_onIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_;
#pragma warning disable 0169
		static Delegate GetOnIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_Handler ()
		{
			if (cb_onIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_ == null)
				cb_onIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_);
			return cb_onIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_;
		}

		static void n_OnIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_idToken)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Token.IdToken idToken = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.IdToken> (native_idToken, JniHandleOwnership.DoNotTransfer);
			__this.OnIdTokenAvailable (idToken);
		}
#pragma warning restore 0169

		static IntPtr id_onIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='onIdTokenAvailable' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.token.IdToken']]"
		[Register ("onIdTokenAvailable", "(Lcom/ca/mas/core/token/IdToken;)V", "GetOnIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_Handler")]
		public virtual unsafe void OnIdTokenAvailable (global::Com.CA.Mas.Core.Token.IdToken idToken)
		{
			if (id_onIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_ == IntPtr.Zero)
				id_onIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_ = JNIEnv.GetMethodID (class_ref, "onIdTokenAvailable", "(Lcom/ca/mas/core/token/IdToken;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (idToken);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIdTokenAvailable_Lcom_ca_mas_core_token_IdToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onIdTokenAvailable", "(Lcom/ca/mas/core/token/IdToken;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeDeviceRegistration;
#pragma warning disable 0169
		static Delegate GetRemoveDeviceRegistrationHandler ()
		{
			if (cb_removeDeviceRegistration == null)
				cb_removeDeviceRegistration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveDeviceRegistration);
			return cb_removeDeviceRegistration;
		}

		static void n_RemoveDeviceRegistration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDeviceRegistration ();
		}
#pragma warning restore 0169

		static IntPtr id_removeDeviceRegistration;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='removeDeviceRegistration' and count(parameter)=0]"
		[Register ("removeDeviceRegistration", "()V", "GetRemoveDeviceRegistrationHandler")]
		public virtual unsafe void RemoveDeviceRegistration ()
		{
			if (id_removeDeviceRegistration == IntPtr.Zero)
				id_removeDeviceRegistration = JNIEnv.GetMethodID (class_ref, "removeDeviceRegistration", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeDeviceRegistration);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeDeviceRegistration", "()V"));
			} finally {
			}
		}

		static Delegate cb_resetHttpClient;
#pragma warning disable 0169
		static Delegate GetResetHttpClientHandler ()
		{
			if (cb_resetHttpClient == null)
				cb_resetHttpClient = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetHttpClient);
			return cb_resetHttpClient;
		}

		static void n_ResetHttpClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetHttpClient ();
		}
#pragma warning restore 0169

		static IntPtr id_resetHttpClient;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='resetHttpClient' and count(parameter)=0]"
		[Register ("resetHttpClient", "()V", "GetResetHttpClientHandler")]
		public virtual unsafe void ResetHttpClient ()
		{
			if (id_resetHttpClient == IntPtr.Zero)
				id_resetHttpClient = JNIEnv.GetMethodID (class_ref, "resetHttpClient", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetHttpClient);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetHttpClient", "()V"));
			} finally {
			}
		}

		static Delegate cb_setClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_;
#pragma warning disable 0169
		static Delegate GetSetClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_Handler ()
		{
			if (cb_setClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ == null)
				cb_setClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_);
			return cb_setClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_;
		}

		static void n_SetClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientCredentials)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Token.ClientCredentials clientCredentials = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.ClientCredentials> (native_clientCredentials, JniHandleOwnership.DoNotTransfer);
			__this.SetClientCredentials (clientCredentials);
		}
#pragma warning restore 0169

		static IntPtr id_setClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='setClientCredentials' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.token.ClientCredentials']]"
		[Register ("setClientCredentials", "(Lcom/ca/mas/core/token/ClientCredentials;)V", "GetSetClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_Handler")]
		public virtual unsafe void SetClientCredentials (global::Com.CA.Mas.Core.Token.ClientCredentials clientCredentials)
		{
			if (id_setClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ == IntPtr.Zero)
				id_setClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ = JNIEnv.GetMethodID (class_ref, "setClientCredentials", "(Lcom/ca/mas/core/token/ClientCredentials;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clientCredentials);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientCredentials", "(Lcom/ca/mas/core/token/ClientCredentials;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_takeRefreshToken;
#pragma warning disable 0169
		static Delegate GetTakeRefreshTokenHandler ()
		{
			if (cb_takeRefreshToken == null)
				cb_takeRefreshToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TakeRefreshToken);
			return cb_takeRefreshToken;
		}

		static IntPtr n_TakeRefreshToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.MssoContext __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TakeRefreshToken ());
		}
#pragma warning restore 0169

		static IntPtr id_takeRefreshToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='MssoContext']/method[@name='takeRefreshToken' and count(parameter)=0]"
		[Register ("takeRefreshToken", "()Ljava/lang/String;", "GetTakeRefreshTokenHandler")]
		public virtual unsafe string TakeRefreshToken ()
		{
			if (id_takeRefreshToken == IntPtr.Zero)
				id_takeRefreshToken = JNIEnv.GetMethodID (class_ref, "takeRefreshToken", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeRefreshToken), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "takeRefreshToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
