using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Oauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='GrantProvider']"
	[global::Android.Runtime.Register ("com/ca/mas/core/oauth/GrantProvider", DoNotGenerateAcw=true)]
	public sealed partial class GrantProvider : global::Java.Lang.Enum {


		static IntPtr CLIENT_CREDENTIALS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='GrantProvider']/field[@name='CLIENT_CREDENTIALS']"
		[Register ("CLIENT_CREDENTIALS")]
		public static global::Com.CA.Mas.Core.Oauth.GrantProvider ClientCredentials {
			get {
				if (CLIENT_CREDENTIALS_jfieldId == IntPtr.Zero)
					CLIENT_CREDENTIALS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT_CREDENTIALS", "Lcom/ca/mas/core/oauth/GrantProvider;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_CREDENTIALS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.GrantProvider> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PASSWORD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='GrantProvider']/field[@name='PASSWORD']"
		[Register ("PASSWORD")]
		public static global::Com.CA.Mas.Core.Oauth.GrantProvider Password {
			get {
				if (PASSWORD_jfieldId == IntPtr.Zero)
					PASSWORD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PASSWORD", "Lcom/ca/mas/core/oauth/GrantProvider;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PASSWORD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.GrantProvider> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/oauth/GrantProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GrantProvider); }
		}

		internal GrantProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isSessionSupported;
		public unsafe bool IsSessionSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='GrantProvider']/method[@name='isSessionSupported' and count(parameter)=0]"
			[Register ("isSessionSupported", "()Z", "GetIsSessionSupportedHandler")]
			get {
				if (id_isSessionSupported == IntPtr.Zero)
					id_isSessionSupported = JNIEnv.GetMethodID (class_ref, "isSessionSupported", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSessionSupported);
				} finally {
				}
			}
		}

		static IntPtr id_getCredentials_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='GrantProvider']/method[@name='getCredentials' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register ("getCredentials", "(Lcom/ca/mas/core/context/MssoContext;)Lcom/ca/mas/foundation/MASAuthCredentials;", "")]
		public unsafe global::Com.CA.Mas.Foundation.IMASAuthCredentials GetCredentials (global::Com.CA.Mas.Core.Context.MssoContext context)
		{
			if (id_getCredentials_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
				id_getCredentials_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "getCredentials", "(Lcom/ca/mas/core/context/MssoContext;)Lcom/ca/mas/foundation/MASAuthCredentials;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				global::Com.CA.Mas.Foundation.IMASAuthCredentials __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCredentials_Lcom_ca_mas_core_context_MssoContext_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRegistrationPath_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='GrantProvider']/method[@name='getRegistrationPath' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register ("getRegistrationPath", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/net/URI;", "")]
		public unsafe global::Java.Net.URI GetRegistrationPath (global::Com.CA.Mas.Core.Context.MssoContext context)
		{
			if (id_getRegistrationPath_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
				id_getRegistrationPath_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "getRegistrationPath", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/net/URI;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				global::Java.Net.URI __ret = global::Java.Lang.Object.GetObject<global::Java.Net.URI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegistrationPath_Lcom_ca_mas_core_context_MssoContext_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='GrantProvider']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/oauth/GrantProvider;", "")]
		public static unsafe global::Com.CA.Mas.Core.Oauth.GrantProvider ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/oauth/GrantProvider;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.CA.Mas.Core.Oauth.GrantProvider __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.GrantProvider> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='GrantProvider']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/ca/mas/core/oauth/GrantProvider;", "")]
		public static unsafe global::Com.CA.Mas.Core.Oauth.GrantProvider[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/core/oauth/GrantProvider;");
			try {
				return (global::Com.CA.Mas.Core.Oauth.GrantProvider[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Core.Oauth.GrantProvider));
			} finally {
			}
		}

	}
}
