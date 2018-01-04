using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Conf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']"
	[global::Android.Runtime.Register ("com/ca/mas/core/conf/ConfigurationManager", DoNotGenerateAcw=true)]
	public partial class ConfigurationManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/conf/ConfigurationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConfigurationManager); }
		}

		protected ConfigurationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCertificateAdvancedRenewTimeframe;
#pragma warning disable 0169
		static Delegate GetGetCertificateAdvancedRenewTimeframeHandler ()
		{
			if (cb_getCertificateAdvancedRenewTimeframe == null)
				cb_getCertificateAdvancedRenewTimeframe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCertificateAdvancedRenewTimeframe);
			return cb_getCertificateAdvancedRenewTimeframe;
		}

		static int n_GetCertificateAdvancedRenewTimeframe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CertificateAdvancedRenewTimeframe;
		}
#pragma warning restore 0169

		static Delegate cb_setCertificateAdvancedRenewTimeframe_I;
#pragma warning disable 0169
		static Delegate GetSetCertificateAdvancedRenewTimeframe_IHandler ()
		{
			if (cb_setCertificateAdvancedRenewTimeframe_I == null)
				cb_setCertificateAdvancedRenewTimeframe_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCertificateAdvancedRenewTimeframe_I);
			return cb_setCertificateAdvancedRenewTimeframe_I;
		}

		static void n_SetCertificateAdvancedRenewTimeframe_I (IntPtr jnienv, IntPtr native__this, int certificateAdvancedRenewTimeframe)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CertificateAdvancedRenewTimeframe = certificateAdvancedRenewTimeframe;
		}
#pragma warning restore 0169

		static IntPtr id_getCertificateAdvancedRenewTimeframe;
		static IntPtr id_setCertificateAdvancedRenewTimeframe_I;
		public virtual unsafe int CertificateAdvancedRenewTimeframe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='getCertificateAdvancedRenewTimeframe' and count(parameter)=0]"
			[Register ("getCertificateAdvancedRenewTimeframe", "()I", "GetGetCertificateAdvancedRenewTimeframeHandler")]
			get {
				if (id_getCertificateAdvancedRenewTimeframe == IntPtr.Zero)
					id_getCertificateAdvancedRenewTimeframe = JNIEnv.GetMethodID (class_ref, "getCertificateAdvancedRenewTimeframe", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCertificateAdvancedRenewTimeframe);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCertificateAdvancedRenewTimeframe", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='setCertificateAdvancedRenewTimeframe' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCertificateAdvancedRenewTimeframe", "(I)V", "GetSetCertificateAdvancedRenewTimeframe_IHandler")]
			set {
				if (id_setCertificateAdvancedRenewTimeframe_I == IntPtr.Zero)
					id_setCertificateAdvancedRenewTimeframe_I = JNIEnv.GetMethodID (class_ref, "setCertificateAdvancedRenewTimeframe", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCertificateAdvancedRenewTimeframe_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCertificateAdvancedRenewTimeframe", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConfigurationFileName;
#pragma warning disable 0169
		static Delegate GetGetConfigurationFileNameHandler ()
		{
			if (cb_getConfigurationFileName == null)
				cb_getConfigurationFileName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfigurationFileName);
			return cb_getConfigurationFileName;
		}

		static IntPtr n_GetConfigurationFileName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConfigurationFileName);
		}
#pragma warning restore 0169

		static Delegate cb_setConfigurationFileName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConfigurationFileName_Ljava_lang_String_Handler ()
		{
			if (cb_setConfigurationFileName_Ljava_lang_String_ == null)
				cb_setConfigurationFileName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfigurationFileName_Ljava_lang_String_);
			return cb_setConfigurationFileName_Ljava_lang_String_;
		}

		static void n_SetConfigurationFileName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configurationFileName)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string configurationFileName = JNIEnv.GetString (native_configurationFileName, JniHandleOwnership.DoNotTransfer);
			__this.ConfigurationFileName = configurationFileName;
		}
#pragma warning restore 0169

		static IntPtr id_getConfigurationFileName;
		static IntPtr id_setConfigurationFileName_Ljava_lang_String_;
		public virtual unsafe string ConfigurationFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='getConfigurationFileName' and count(parameter)=0]"
			[Register ("getConfigurationFileName", "()Ljava/lang/String;", "GetGetConfigurationFileNameHandler")]
			get {
				if (id_getConfigurationFileName == IntPtr.Zero)
					id_getConfigurationFileName = JNIEnv.GetMethodID (class_ref, "getConfigurationFileName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfigurationFileName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfigurationFileName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='setConfigurationFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConfigurationFileName", "(Ljava/lang/String;)V", "GetSetConfigurationFileName_Ljava_lang_String_Handler")]
			set {
				if (id_setConfigurationFileName_Ljava_lang_String_ == IntPtr.Zero)
					id_setConfigurationFileName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConfigurationFileName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConfigurationFileName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfigurationFileName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getConnectedGateway;
#pragma warning disable 0169
		static Delegate GetGetConnectedGatewayHandler ()
		{
			if (cb_getConnectedGateway == null)
				cb_getConnectedGateway = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedGateway);
			return cb_getConnectedGateway;
		}

		static IntPtr n_GetConnectedGateway (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectedGateway);
		}
#pragma warning restore 0169

		static IntPtr id_getConnectedGateway;
		public virtual unsafe global::Com.CA.Mas.Core.Conf.Server ConnectedGateway {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='getConnectedGateway' and count(parameter)=0]"
			[Register ("getConnectedGateway", "()Lcom/ca/mas/core/conf/Server;", "GetGetConnectedGatewayHandler")]
			get {
				if (id_getConnectedGateway == IntPtr.Zero)
					id_getConnectedGateway = JNIEnv.GetMethodID (class_ref, "getConnectedGateway", "()Lcom/ca/mas/core/conf/Server;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectedGateway), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectedGateway", "()Lcom/ca/mas/core/conf/Server;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectedGatewayConfig;
#pragma warning disable 0169
		static Delegate GetGetConnectedGatewayConfigHandler ()
		{
			if (cb_getConnectedGatewayConfig == null)
				cb_getConnectedGatewayConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedGatewayConfig);
			return cb_getConnectedGatewayConfig;
		}

		static IntPtr n_GetConnectedGatewayConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectedGatewayConfig);
		}
#pragma warning restore 0169

		static IntPtr id_getConnectedGatewayConfig;
		public virtual unsafe global::Org.Json.JSONObject ConnectedGatewayConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='getConnectedGatewayConfig' and count(parameter)=0]"
			[Register ("getConnectedGatewayConfig", "()Lorg/json/JSONObject;", "GetGetConnectedGatewayConfigHandler")]
			get {
				if (id_getConnectedGatewayConfig == IntPtr.Zero)
					id_getConnectedGatewayConfig = JNIEnv.GetMethodID (class_ref, "getConnectedGatewayConfig", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectedGatewayConfig), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectedGatewayConfig", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectedGatewayConfigurationProvider;
#pragma warning disable 0169
		static Delegate GetGetConnectedGatewayConfigurationProviderHandler ()
		{
			if (cb_getConnectedGatewayConfigurationProvider == null)
				cb_getConnectedGatewayConfigurationProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedGatewayConfigurationProvider);
			return cb_getConnectedGatewayConfigurationProvider;
		}

		static IntPtr n_GetConnectedGatewayConfigurationProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectedGatewayConfigurationProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getConnectedGatewayConfigurationProvider;
		public virtual unsafe global::Com.CA.Mas.Core.Conf.IConfigurationProvider ConnectedGatewayConfigurationProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='getConnectedGatewayConfigurationProvider' and count(parameter)=0]"
			[Register ("getConnectedGatewayConfigurationProvider", "()Lcom/ca/mas/core/conf/ConfigurationProvider;", "GetGetConnectedGatewayConfigurationProviderHandler")]
			get {
				if (id_getConnectedGatewayConfigurationProvider == IntPtr.Zero)
					id_getConnectedGatewayConfigurationProvider = JNIEnv.GetMethodID (class_ref, "getConnectedGatewayConfigurationProvider", "()Lcom/ca/mas/core/conf/ConfigurationProvider;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectedGatewayConfigurationProvider), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectedGatewayConfigurationProvider", "()Lcom/ca/mas/core/conf/ConfigurationProvider;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultGrantProvider;
#pragma warning disable 0169
		static Delegate GetGetDefaultGrantProviderHandler ()
		{
			if (cb_getDefaultGrantProvider == null)
				cb_getDefaultGrantProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultGrantProvider);
			return cb_getDefaultGrantProvider;
		}

		static IntPtr n_GetDefaultGrantProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultGrantProvider);
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_;
#pragma warning disable 0169
		static Delegate GetSetDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_Handler ()
		{
			if (cb_setDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_ == null)
				cb_setDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_);
			return cb_setDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_;
		}

		static void n_SetDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_defaultGrantProvider)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Oauth.GrantProvider defaultGrantProvider = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.GrantProvider> (native_defaultGrantProvider, JniHandleOwnership.DoNotTransfer);
			__this.DefaultGrantProvider = defaultGrantProvider;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultGrantProvider;
		static IntPtr id_setDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_;
		public virtual unsafe global::Com.CA.Mas.Core.Oauth.GrantProvider DefaultGrantProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='getDefaultGrantProvider' and count(parameter)=0]"
			[Register ("getDefaultGrantProvider", "()Lcom/ca/mas/core/oauth/GrantProvider;", "GetGetDefaultGrantProviderHandler")]
			get {
				if (id_getDefaultGrantProvider == IntPtr.Zero)
					id_getDefaultGrantProvider = JNIEnv.GetMethodID (class_ref, "getDefaultGrantProvider", "()Lcom/ca/mas/core/oauth/GrantProvider;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.GrantProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultGrantProvider), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.GrantProvider> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultGrantProvider", "()Lcom/ca/mas/core/oauth/GrantProvider;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='setDefaultGrantProvider' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.oauth.GrantProvider']]"
			[Register ("setDefaultGrantProvider", "(Lcom/ca/mas/core/oauth/GrantProvider;)V", "GetSetDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_Handler")]
			set {
				if (id_setDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_ == IntPtr.Zero)
					id_setDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_ = JNIEnv.GetMethodID (class_ref, "setDefaultGrantProvider", "(Lcom/ca/mas/core/oauth/GrantProvider;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultGrantProvider_Lcom_ca_mas_core_oauth_GrantProvider_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultGrantProvider", "(Lcom/ca/mas/core/oauth/GrantProvider;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.CA.Mas.Core.Conf.ConfigurationManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ca/mas/core/conf/ConfigurationManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ca/mas/core/conf/ConfigurationManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isPKCEEnabled;
#pragma warning disable 0169
		static Delegate GetIsPKCEEnabledHandler ()
		{
			if (cb_isPKCEEnabled == null)
				cb_isPKCEEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPKCEEnabled);
			return cb_isPKCEEnabled;
		}

		static bool n_IsPKCEEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPKCEEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isPKCEEnabled;
		public virtual unsafe bool IsPKCEEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='isPKCEEnabled' and count(parameter)=0]"
			[Register ("isPKCEEnabled", "()Z", "GetIsPKCEEnabledHandler")]
			get {
				if (id_isPKCEEnabled == IntPtr.Zero)
					id_isPKCEEnabled = JNIEnv.GetMethodID (class_ref, "isPKCEEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPKCEEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPKCEEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMobileSsoListener;
#pragma warning disable 0169
		static Delegate GetGetMobileSsoListenerHandler ()
		{
			if (cb_getMobileSsoListener == null)
				cb_getMobileSsoListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMobileSsoListener);
			return cb_getMobileSsoListener;
		}

		static IntPtr n_GetMobileSsoListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MobileSsoListener);
		}
#pragma warning restore 0169

		static Delegate cb_setMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_;
#pragma warning disable 0169
		static Delegate GetSetMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_Handler ()
		{
			if (cb_setMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_ == null)
				cb_setMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_);
			return cb_setMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_;
		}

		static void n_SetMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mobileSsoListener)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.IMobileSsoListener mobileSsoListener = (global::Com.CA.Mas.Core.IMobileSsoListener)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IMobileSsoListener> (native_mobileSsoListener, JniHandleOwnership.DoNotTransfer);
			__this.MobileSsoListener = mobileSsoListener;
		}
#pragma warning restore 0169

		static IntPtr id_getMobileSsoListener;
		static IntPtr id_setMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_;
		public virtual unsafe global::Com.CA.Mas.Core.IMobileSsoListener MobileSsoListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='getMobileSsoListener' and count(parameter)=0]"
			[Register ("getMobileSsoListener", "()Lcom/ca/mas/core/MobileSsoListener;", "GetGetMobileSsoListenerHandler")]
			get {
				if (id_getMobileSsoListener == IntPtr.Zero)
					id_getMobileSsoListener = JNIEnv.GetMethodID (class_ref, "getMobileSsoListener", "()Lcom/ca/mas/core/MobileSsoListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IMobileSsoListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMobileSsoListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IMobileSsoListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMobileSsoListener", "()Lcom/ca/mas/core/MobileSsoListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='setMobileSsoListener' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.MobileSsoListener']]"
			[Register ("setMobileSsoListener", "(Lcom/ca/mas/core/MobileSsoListener;)V", "GetSetMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_Handler")]
			set {
				if (id_setMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_ == IntPtr.Zero)
					id_setMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_ = JNIEnv.GetMethodID (class_ref, "setMobileSsoListener", "(Lcom/ca/mas/core/MobileSsoListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMobileSsoListener_Lcom_ca_mas_core_MobileSsoListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMobileSsoListener", "(Lcom/ca/mas/core/MobileSsoListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_activate_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetActivate_Lorg_json_JSONObject_Handler ()
		{
			if (cb_activate_Lorg_json_JSONObject_ == null)
				cb_activate_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Activate_Lorg_json_JSONObject_);
			return cb_activate_Lorg_json_JSONObject_;
		}

		static void n_Activate_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			__this.Activate (jsonObject);
		}
#pragma warning restore 0169

		static IntPtr id_activate_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='activate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("activate", "(Lorg/json/JSONObject;)V", "GetActivate_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Activate (global::Org.Json.JSONObject jsonObject)
		{
			if (id_activate_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_activate_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "activate", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (jsonObject);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_activate_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "activate", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_activateDefault;
#pragma warning disable 0169
		static Delegate GetActivateDefaultHandler ()
		{
			if (cb_activateDefault == null)
				cb_activateDefault = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ActivateDefault);
			return cb_activateDefault;
		}

		static void n_ActivateDefault (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActivateDefault ();
		}
#pragma warning restore 0169

		static IntPtr id_activateDefault;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='activateDefault' and count(parameter)=0]"
		[Register ("activateDefault", "()V", "GetActivateDefaultHandler")]
		public virtual unsafe void ActivateDefault ()
		{
			if (id_activateDefault == IntPtr.Zero)
				id_activateDefault = JNIEnv.GetMethodID (class_ref, "activateDefault", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_activateDefault);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "activateDefault", "()V"));
			} finally {
			}
		}

		static Delegate cb_create_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetCreate_Lorg_json_JSONObject_Handler ()
		{
			if (cb_create_Lorg_json_JSONObject_ == null)
				cb_create_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Lorg_json_JSONObject_);
			return cb_create_Lorg_json_JSONObject_;
		}

		static IntPtr n_Create_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (jsonObject));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_create_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("create", "(Lorg/json/JSONObject;)Lcom/ca/mas/core/conf/ConfigurationProvider;", "GetCreate_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::Com.CA.Mas.Core.Conf.IConfigurationProvider Create (global::Org.Json.JSONObject jsonObject)
		{
			if (id_create_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_create_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "create", "(Lorg/json/JSONObject;)Lcom/ca/mas/core/conf/ConfigurationProvider;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (jsonObject);

				global::Com.CA.Mas.Core.Conf.IConfigurationProvider __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Lorg/json/JSONObject;)Lcom/ca/mas/core/conf/ConfigurationProvider;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_enablePKCE_Z;
#pragma warning disable 0169
		static Delegate GetEnablePKCE_ZHandler ()
		{
			if (cb_enablePKCE_Z == null)
				cb_enablePKCE_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnablePKCE_Z);
			return cb_enablePKCE_Z;
		}

		static void n_EnablePKCE_Z (IntPtr jnienv, IntPtr native__this, bool enablePKCE)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnablePKCE (enablePKCE);
		}
#pragma warning restore 0169

		static IntPtr id_enablePKCE_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='enablePKCE' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enablePKCE", "(Z)V", "GetEnablePKCE_ZHandler")]
		public virtual unsafe void EnablePKCE (bool enablePKCE)
		{
			if (id_enablePKCE_Z == IntPtr.Zero)
				id_enablePKCE_Z = JNIEnv.GetMethodID (class_ref, "enablePKCE", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (enablePKCE);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enablePKCE_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enablePKCE", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getConfig_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetGetConfig_Ljava_io_InputStream_Handler ()
		{
			if (cb_getConfig_Ljava_io_InputStream_ == null)
				cb_getConfig_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConfig_Ljava_io_InputStream_);
			return cb_getConfig_Ljava_io_InputStream_;
		}

		static IntPtr n_GetConfig_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__is)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @is = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__is, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConfig (@is));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConfig_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='getConfig' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("getConfig", "(Ljava/io/InputStream;)Lorg/json/JSONObject;", "GetGetConfig_Ljava_io_InputStream_Handler")]
		public virtual unsafe global::Org.Json.JSONObject GetConfig (global::System.IO.Stream @is)
		{
			if (id_getConfig_Ljava_io_InputStream_ == IntPtr.Zero)
				id_getConfig_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "getConfig", "(Ljava/io/InputStream;)Lorg/json/JSONObject;");
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__is);

				global::Org.Json.JSONObject __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfig_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfig", "(Ljava/io/InputStream;)Lorg/json/JSONObject;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
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
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Init (context);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAppConfigs_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAppConfigs_Ljava_util_List_Handler ()
		{
			if (cb_setAppConfigs_Ljava_util_List_ == null)
				cb_setAppConfigs_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppConfigs_Ljava_util_List_);
			return cb_setAppConfigs_Ljava_util_List_;
		}

		static void n_SetAppConfigs_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appConfigs)
		{
			global::Com.CA.Mas.Core.Conf.ConfigurationManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.ConfigurationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var appConfigs = global::Android.Runtime.JavaList<global::Com.CA.Mas.Core.Conf.Config>.FromJniHandle (native_appConfigs, JniHandleOwnership.DoNotTransfer);
			__this.SetAppConfigs (appConfigs);
		}
#pragma warning restore 0169

		static IntPtr id_setAppConfigs_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='ConfigurationManager']/method[@name='setAppConfigs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.ca.mas.core.conf.Config&gt;']]"
		[Register ("setAppConfigs", "(Ljava/util/List;)V", "GetSetAppConfigs_Ljava_util_List_Handler")]
		public virtual unsafe void SetAppConfigs (global::System.Collections.Generic.IList<global::Com.CA.Mas.Core.Conf.Config> appConfigs)
		{
			if (id_setAppConfigs_Ljava_util_List_ == IntPtr.Zero)
				id_setAppConfigs_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAppConfigs", "(Ljava/util/List;)V");
			IntPtr native_appConfigs = global::Android.Runtime.JavaList<global::Com.CA.Mas.Core.Conf.Config>.ToLocalJniHandle (appConfigs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_appConfigs);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppConfigs_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppConfigs", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appConfigs);
			}
		}

#region "Event implementation for Com.CA.Mas.Core.IMobileSsoListener"
		public event EventHandler<global::Com.CA.Mas.Core.AuthenticateRequestEventArgs> AuthenticateRequest {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.CA.Mas.Core.IMobileSsoListener, global::Com.CA.Mas.Core.IMobileSsoListenerImplementor>(
						ref weak_implementor___SetMobileSsoListener,
						__CreateIMobileSsoListenerImplementor,
						__v => MobileSsoListener = __v,
						__h => __h.OnAuthenticateRequestHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.CA.Mas.Core.IMobileSsoListener, global::Com.CA.Mas.Core.IMobileSsoListenerImplementor>(
						ref weak_implementor___SetMobileSsoListener,
						global::Com.CA.Mas.Core.IMobileSsoListenerImplementor.__IsEmpty,
						__v => MobileSsoListener = null,
						__h => __h.OnAuthenticateRequestHandler -= value);
			}
		}

		public event EventHandler<global::Com.CA.Mas.Core.OtpAuthenticationRequestEventArgs> OtpAuthenticationRequest {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.CA.Mas.Core.IMobileSsoListener, global::Com.CA.Mas.Core.IMobileSsoListenerImplementor>(
						ref weak_implementor___SetMobileSsoListener,
						__CreateIMobileSsoListenerImplementor,
						__v => MobileSsoListener = __v,
						__h => __h.OnOtpAuthenticationRequestHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.CA.Mas.Core.IMobileSsoListener, global::Com.CA.Mas.Core.IMobileSsoListenerImplementor>(
						ref weak_implementor___SetMobileSsoListener,
						global::Com.CA.Mas.Core.IMobileSsoListenerImplementor.__IsEmpty,
						__v => MobileSsoListener = null,
						__h => __h.OnOtpAuthenticationRequestHandler -= value);
			}
		}

		WeakReference weak_implementor___SetMobileSsoListener;

		global::Com.CA.Mas.Core.IMobileSsoListenerImplementor __CreateIMobileSsoListenerImplementor ()
		{
			return new global::Com.CA.Mas.Core.IMobileSsoListenerImplementor (this);
		}
#endregion
	}
}
