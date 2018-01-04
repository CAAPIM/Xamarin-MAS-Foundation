using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='SSLSocketFactoryProvider']"
	[global::Android.Runtime.Register ("com/ca/mas/core/http/SSLSocketFactoryProvider", DoNotGenerateAcw=true)]
	public partial class SSLSocketFactoryProvider : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/http/SSLSocketFactoryProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SSLSocketFactoryProvider); }
		}

		protected SSLSocketFactoryProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.CA.Mas.Core.Http.SSLSocketFactoryProvider Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='SSLSocketFactoryProvider']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ca/mas/core/http/SSLSocketFactoryProvider;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ca/mas/core/http/SSLSocketFactoryProvider;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.SSLSocketFactoryProvider> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrimaryGatewaySocketFactory;
#pragma warning disable 0169
		static Delegate GetGetPrimaryGatewaySocketFactoryHandler ()
		{
			if (cb_getPrimaryGatewaySocketFactory == null)
				cb_getPrimaryGatewaySocketFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrimaryGatewaySocketFactory);
			return cb_getPrimaryGatewaySocketFactory;
		}

		static IntPtr n_GetPrimaryGatewaySocketFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Http.SSLSocketFactoryProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.SSLSocketFactoryProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrimaryGatewaySocketFactory);
		}
#pragma warning restore 0169

		static IntPtr id_getPrimaryGatewaySocketFactory;
		public virtual unsafe global::Javax.Net.Ssl.SSLSocketFactory PrimaryGatewaySocketFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='SSLSocketFactoryProvider']/method[@name='getPrimaryGatewaySocketFactory' and count(parameter)=0]"
			[Register ("getPrimaryGatewaySocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", "GetGetPrimaryGatewaySocketFactoryHandler")]
			get {
				if (id_getPrimaryGatewaySocketFactory == IntPtr.Zero)
					id_getPrimaryGatewaySocketFactory = JNIEnv.GetMethodID (class_ref, "getPrimaryGatewaySocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrimaryGatewaySocketFactory), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrimaryGatewaySocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_;
#pragma warning disable 0169
		static Delegate GetCreateSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_Handler ()
		{
			if (cb_createSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_ == null)
				cb_createSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_);
			return cb_createSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_;
		}

		static IntPtr n_CreateSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			global::Com.CA.Mas.Core.Http.SSLSocketFactoryProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.SSLSocketFactoryProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.IMASSecurityConfiguration configuration = (global::Com.CA.Mas.Foundation.IMASSecurityConfiguration)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (native_configuration, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSSLSocketFactory (configuration));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='SSLSocketFactoryProvider']/method[@name='createSSLSocketFactory' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASSecurityConfiguration']]"
		[Register ("createSSLSocketFactory", "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)Ljavax/net/ssl/SSLSocketFactory;", "GetCreateSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_Handler")]
		public virtual unsafe global::Javax.Net.Ssl.SSLSocketFactory CreateSSLSocketFactory (global::Com.CA.Mas.Foundation.IMASSecurityConfiguration configuration)
		{
			if (id_createSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_ == IntPtr.Zero)
				id_createSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_ = JNIEnv.GetMethodID (class_ref, "createSSLSocketFactory", "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)Ljavax/net/ssl/SSLSocketFactory;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (configuration);

				global::Javax.Net.Ssl.SSLSocketFactory __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSSLSocketFactory_Lcom_ca_mas_foundation_MASSecurityConfiguration_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSSLSocketFactory", "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)Ljavax/net/ssl/SSLSocketFactory;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_get_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_net_URL_Handler ()
		{
			if (cb_get_Ljava_net_URL_ == null)
				cb_get_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_net_URL_);
			return cb_get_Ljava_net_URL_;
		}

		static IntPtr n_Get_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::Com.CA.Mas.Core.Http.SSLSocketFactoryProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.SSLSocketFactoryProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (url));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='SSLSocketFactoryProvider']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("get", "(Ljava/net/URL;)Ljavax/net/ssl/SSLSocketFactory;", "GetGet_Ljava_net_URL_Handler")]
		public virtual unsafe global::Javax.Net.Ssl.SSLSocketFactory Get (global::Java.Net.URL url)
		{
			if (id_get_Ljava_net_URL_ == IntPtr.Zero)
				id_get_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/net/URL;)Ljavax/net/ssl/SSLSocketFactory;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (url);

				global::Javax.Net.Ssl.SSLSocketFactory __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_net_URL_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/net/URL;)Ljavax/net/ssl/SSLSocketFactory;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSSLSocketFactory_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetSSLSocketFactory_Landroid_net_Uri_Handler ()
		{
			if (cb_getSSLSocketFactory_Landroid_net_Uri_ == null)
				cb_getSSLSocketFactory_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSSLSocketFactory_Landroid_net_Uri_);
			return cb_getSSLSocketFactory_Landroid_net_Uri_;
		}

		static IntPtr n_GetSSLSocketFactory_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hostname)
		{
			global::Com.CA.Mas.Core.Http.SSLSocketFactoryProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.SSLSocketFactoryProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri hostname = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_hostname, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSSLSocketFactory (hostname));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSSLSocketFactory_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='SSLSocketFactoryProvider']/method[@name='getSSLSocketFactory' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getSSLSocketFactory", "(Landroid/net/Uri;)Ljavax/net/ssl/SSLSocketFactory;", "GetGetSSLSocketFactory_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Javax.Net.Ssl.SSLSocketFactory GetSSLSocketFactory (global::Android.Net.Uri hostname)
		{
			if (id_getSSLSocketFactory_Landroid_net_Uri_ == IntPtr.Zero)
				id_getSSLSocketFactory_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getSSLSocketFactory", "(Landroid/net/Uri;)Ljavax/net/ssl/SSLSocketFactory;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (hostname);

				global::Javax.Net.Ssl.SSLSocketFactory __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSSLSocketFactory_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSSLSocketFactory", "(Landroid/net/Uri;)Ljavax/net/ssl/SSLSocketFactory;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
