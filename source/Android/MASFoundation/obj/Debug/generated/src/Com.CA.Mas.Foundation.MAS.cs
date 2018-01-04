using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MAS", DoNotGenerateAcw=true)]
	public partial class MAS : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, TAG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS.RequestCancelledException']"
		[global::Android.Runtime.Register ("com/ca/mas/foundation/MAS$RequestCancelledException", DoNotGenerateAcw=true)]
		public partial class RequestCancelledException : global::Java.Lang.Exception {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/foundation/MAS$RequestCancelledException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RequestCancelledException); }
			}

			protected RequestCancelledException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_os_Bundle_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS.RequestCancelledException']/constructor[@name='MAS.RequestCancelledException' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
			public unsafe RequestCancelledException (global::Android.OS.Bundle data)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (data);
					if (((object) this).GetType () != typeof (RequestCancelledException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Bundle;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Landroid/os/Bundle;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Bundle_ == IntPtr.Zero)
						id_ctor_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Bundle;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Bundle_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Landroid_os_Bundle_, __args);
				} finally {
				}
			}

			static Delegate cb_getData;
#pragma warning disable 0169
			static Delegate GetGetDataHandler ()
			{
				if (cb_getData == null)
					cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
				return cb_getData;
			}

			static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Foundation.MAS.RequestCancelledException __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MAS.RequestCancelledException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Data);
			}
#pragma warning restore 0169

			static IntPtr id_getData;
			public virtual unsafe global::Android.OS.Bundle Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS.RequestCancelledException']/method[@name='getData' and count(parameter)=0]"
				[Register ("getData", "()Landroid/os/Bundle;", "GetGetDataHandler")]
				get {
					if (id_getData == IntPtr.Zero)
						id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Landroid/os/Bundle;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MAS", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAS); }
		}

		protected MAS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/constructor[@name='MAS' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MAS ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MAS)) {
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

		static IntPtr id_getContext;
		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetStaticMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCurrentActivity;
		public static unsafe global::Android.App.Activity CurrentActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='getCurrentActivity' and count(parameter)=0]"
			[Register ("getCurrentActivity", "()Landroid/app/Activity;", "GetGetCurrentActivityHandler")]
			get {
				if (id_getCurrentActivity == IntPtr.Zero)
					id_getCurrentActivity = JNIEnv.GetStaticMethodID (class_ref, "getCurrentActivity", "()Landroid/app/Activity;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentActivity), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isAuthenticationListenerRegistered;
		public static unsafe bool IsAuthenticationListenerRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='isAuthenticationListenerRegistered' and count(parameter)=0]"
			[Register ("isAuthenticationListenerRegistered", "()Z", "GetIsAuthenticationListenerRegisteredHandler")]
			get {
				if (id_isAuthenticationListenerRegistered == IntPtr.Zero)
					id_isAuthenticationListenerRegistered = JNIEnv.GetStaticMethodID (class_ref, "isAuthenticationListenerRegistered", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAuthenticationListenerRegistered);
				} finally {
				}
			}
		}

		static IntPtr id_isBrowserBasedAuthenticationEnabled;
		public static unsafe bool IsBrowserBasedAuthenticationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='isBrowserBasedAuthenticationEnabled' and count(parameter)=0]"
			[Register ("isBrowserBasedAuthenticationEnabled", "()Z", "GetIsBrowserBasedAuthenticationEnabledHandler")]
			get {
				if (id_isBrowserBasedAuthenticationEnabled == IntPtr.Zero)
					id_isBrowserBasedAuthenticationEnabled = JNIEnv.GetStaticMethodID (class_ref, "isBrowserBasedAuthenticationEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBrowserBasedAuthenticationEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_isPKCEEnabled;
		public static unsafe bool IsPKCEEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='isPKCEEnabled' and count(parameter)=0]"
			[Register ("isPKCEEnabled", "()Z", "GetIsPKCEEnabledHandler")]
			get {
				if (id_isPKCEEnabled == IntPtr.Zero)
					id_isPKCEEnabled = JNIEnv.GetStaticMethodID (class_ref, "isPKCEEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPKCEEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_cancelAllRequest_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='cancelAllRequest' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("cancelAllRequest", "(Landroid/os/Bundle;)V", "")]
		public static unsafe void CancelAllRequest (global::Android.OS.Bundle data)
		{
			if (id_cancelAllRequest_Landroid_os_Bundle_ == IntPtr.Zero)
				id_cancelAllRequest_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "cancelAllRequest", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cancelAllRequest_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_cancelAllRequests;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='cancelAllRequests' and count(parameter)=0]"
		[Register ("cancelAllRequests", "()V", "")]
		public static unsafe void CancelAllRequests ()
		{
			if (id_cancelAllRequests == IntPtr.Zero)
				id_cancelAllRequests = JNIEnv.GetStaticMethodID (class_ref, "cancelAllRequests", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cancelAllRequests);
			} finally {
			}
		}

		static IntPtr id_cancelRequest_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='cancelRequest' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("cancelRequest", "(J)V", "")]
		public static unsafe void CancelRequest (long requestId)
		{
			if (id_cancelRequest_J == IntPtr.Zero)
				id_cancelRequest_J = JNIEnv.GetStaticMethodID (class_ref, "cancelRequest", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (requestId);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cancelRequest_J, __args);
			} finally {
			}
		}

		static IntPtr id_cancelRequest_JLandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='cancelRequest' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("cancelRequest", "(JLandroid/os/Bundle;)V", "")]
		public static unsafe void CancelRequest (long requestId, global::Android.OS.Bundle data)
		{
			if (id_cancelRequest_JLandroid_os_Bundle_ == IntPtr.Zero)
				id_cancelRequest_JLandroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "cancelRequest", "(JLandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (requestId);
				__args [1] = new JValue (data);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cancelRequest_JLandroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_debug;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='debug' and count(parameter)=0]"
		[Register ("debug", "()V", "")]
		public static unsafe void Debug ()
		{
			if (id_debug == IntPtr.Zero)
				id_debug = JNIEnv.GetStaticMethodID (class_ref, "debug", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_debug);
			} finally {
			}
		}

		static IntPtr id_enableBrowserBasedAuthentication;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='enableBrowserBasedAuthentication' and count(parameter)=0]"
		[Register ("enableBrowserBasedAuthentication", "()V", "")]
		public static unsafe void EnableBrowserBasedAuthentication ()
		{
			if (id_enableBrowserBasedAuthentication == IntPtr.Zero)
				id_enableBrowserBasedAuthentication = JNIEnv.GetStaticMethodID (class_ref, "enableBrowserBasedAuthentication", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableBrowserBasedAuthentication);
			} finally {
			}
		}

		static IntPtr id_enablePKCE_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='enablePKCE' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enablePKCE", "(Z)V", "")]
		public static unsafe void EnablePKCE (bool enablePKCE)
		{
			if (id_enablePKCE_Z == IntPtr.Zero)
				id_enablePKCE_Z = JNIEnv.GetStaticMethodID (class_ref, "enablePKCE", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (enablePKCE);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enablePKCE_Z, __args);
			} finally {
			}
		}

		static IntPtr id_gatewayIsReachable_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='gatewayIsReachable' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Boolean&gt;']]"
		[Register ("gatewayIsReachable", "(Lcom/ca/mas/foundation/MASCallback;)V", "")]
		public static unsafe void GatewayIsReachable (global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_gatewayIsReachable_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_gatewayIsReachable_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "gatewayIsReachable", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_gatewayIsReachable_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_getState_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='getState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getState", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetState (global::Android.Content.Context context)
		{
			if (id_getState_Landroid_content_Context_ == IntPtr.Zero)
				id_getState_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getState", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getState_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_processPendingRequests;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='processPendingRequests' and count(parameter)=0]"
		[Register ("processPendingRequests", "()V", "")]
		public static unsafe void ProcessPendingRequests ()
		{
			if (id_processPendingRequests == IntPtr.Zero)
				id_processPendingRequests = JNIEnv.GetStaticMethodID (class_ref, "processPendingRequests", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_processPendingRequests);
			} finally {
			}
		}

		static IntPtr id_setAuthenticationListener_Lcom_ca_mas_foundation_MASAuthenticationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='setAuthenticationListener' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASAuthenticationListener']]"
		[Register ("setAuthenticationListener", "(Lcom/ca/mas/foundation/MASAuthenticationListener;)V", "")]
		public static unsafe void SetAuthenticationListener (global::Com.CA.Mas.Foundation.IMASAuthenticationListener listener)
		{
			if (id_setAuthenticationListener_Lcom_ca_mas_foundation_MASAuthenticationListener_ == IntPtr.Zero)
				id_setAuthenticationListener_Lcom_ca_mas_foundation_MASAuthenticationListener_ = JNIEnv.GetStaticMethodID (class_ref, "setAuthenticationListener", "(Lcom/ca/mas/foundation/MASAuthenticationListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAuthenticationListener_Lcom_ca_mas_foundation_MASAuthenticationListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setConfigurationFileName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='setConfigurationFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setConfigurationFileName", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetConfigurationFileName (string filename)
		{
			if (id_setConfigurationFileName_Ljava_lang_String_ == IntPtr.Zero)
				id_setConfigurationFileName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setConfigurationFileName", "(Ljava/lang/String;)V");
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_filename);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setConfigurationFileName_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static IntPtr id_setGrantFlow_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='setGrantFlow' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setGrantFlow", "(I)V", "")]
		public static unsafe void SetGrantFlow ([global::Android.Runtime.IntDef (Type = "Com.CA.Mas.Foundation.MASConstants", Fields = new string [] {"MasGrantFlowClientCredentials", "MasGrantFlowPassword"})]int type)
		{
			if (id_setGrantFlow_I == IntPtr.Zero)
				id_setGrantFlow_I = JNIEnv.GetStaticMethodID (class_ref, "setGrantFlow", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (type);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setGrantFlow_I, __args);
			} finally {
			}
		}

		static IntPtr id_sign_Lcom_ca_mas_foundation_MASClaims_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASClaims']]"
		[Register ("sign", "(Lcom/ca/mas/foundation/MASClaims;)Ljava/lang/String;", "")]
		public static unsafe string Sign (global::Com.CA.Mas.Foundation.IMASClaims masClaims)
		{
			if (id_sign_Lcom_ca_mas_foundation_MASClaims_ == IntPtr.Zero)
				id_sign_Lcom_ca_mas_foundation_MASClaims_ = JNIEnv.GetStaticMethodID (class_ref, "sign", "(Lcom/ca/mas/foundation/MASClaims;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (masClaims);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sign_Lcom_ca_mas_foundation_MASClaims_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sign_Lcom_ca_mas_foundation_MASClaims_Ljava_security_PrivateKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='sign' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASClaims'] and parameter[2][@type='java.security.PrivateKey']]"
		[Register ("sign", "(Lcom/ca/mas/foundation/MASClaims;Ljava/security/PrivateKey;)Ljava/lang/String;", "")]
		public static unsafe string Sign (global::Com.CA.Mas.Foundation.IMASClaims masClaims, global::Java.Security.IPrivateKey privateKey)
		{
			if (id_sign_Lcom_ca_mas_foundation_MASClaims_Ljava_security_PrivateKey_ == IntPtr.Zero)
				id_sign_Lcom_ca_mas_foundation_MASClaims_Ljava_security_PrivateKey_ = JNIEnv.GetStaticMethodID (class_ref, "sign", "(Lcom/ca/mas/foundation/MASClaims;Ljava/security/PrivateKey;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (masClaims);
				__args [1] = new JValue (privateKey);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sign_Lcom_ca_mas_foundation_MASClaims_Ljava_security_PrivateKey_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_start_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='start' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("start", "(Landroid/content/Context;)V", "")]
		public static unsafe void Start (global::Android.Content.Context context)
		{
			if (id_start_Landroid_content_Context_ == IntPtr.Zero)
				id_start_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_start_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='start' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("start", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void Start (global::Android.Content.Context context, bool shouldUseDefault)
		{
			if (id_start_Landroid_content_Context_Z == IntPtr.Zero)
				id_start_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (shouldUseDefault);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_start_Landroid_content_Context_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='start' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.net.URL']]"
		[Register ("start", "(Landroid/content/Context;Ljava/net/URL;)V", "")]
		public static unsafe void Start (global::Android.Content.Context context, global::Java.Net.URL url)
		{
			if (id_start_Landroid_content_Context_Ljava_net_URL_ == IntPtr.Zero)
				id_start_Landroid_content_Context_Ljava_net_URL_ = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;Ljava/net/URL;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (url);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_Ljava_net_URL_, __args);
			} finally {
			}
		}

		static IntPtr id_start_Landroid_content_Context_Ljava_net_URL_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='start' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.net.URL'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("start", "(Landroid/content/Context;Ljava/net/URL;Lcom/ca/mas/foundation/MASCallback;)V", "")]
		public static unsafe void Start (global::Android.Content.Context context, global::Java.Net.URL url, global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_start_Landroid_content_Context_Ljava_net_URL_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_start_Landroid_content_Context_Ljava_net_URL_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;Ljava/net/URL;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (url);
				__args [2] = new JValue (@callback);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_Ljava_net_URL_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_start_Landroid_content_Context_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='start' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject']]"
		[Register ("start", "(Landroid/content/Context;Lorg/json/JSONObject;)V", "")]
		public static unsafe void Start (global::Android.Content.Context context, global::Org.Json.JSONObject jsonConfiguration)
		{
			if (id_start_Landroid_content_Context_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_start_Landroid_content_Context_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "start", "(Landroid/content/Context;Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (jsonConfiguration);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_start_Landroid_content_Context_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MAS']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "")]
		public static unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetStaticMethodID (class_ref, "stop", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stop);
			} finally {
			}
		}

#region "Event implementation for Com.CA.Mas.Foundation.IMASAuthenticationListener"
		public event EventHandler<global::Com.CA.Mas.Foundation.AuthenticateRequestEventArgs> AuthenticateRequest {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.CA.Mas.Foundation.IMASAuthenticationListener, global::Com.CA.Mas.Foundation.IMASAuthenticationListenerImplementor>(
						ref weak_implementor_SetAuthenticationListener,
						__CreateIMASAuthenticationListenerImplementor,
						SetAuthenticationListener,
						__h => __h.OnAuthenticateRequestHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.CA.Mas.Foundation.IMASAuthenticationListener, global::Com.CA.Mas.Foundation.IMASAuthenticationListenerImplementor>(
						ref weak_implementor_SetAuthenticationListener,
						global::Com.CA.Mas.Foundation.IMASAuthenticationListenerImplementor.__IsEmpty,
						__v => SetAuthenticationListener (null),
						__h => __h.OnAuthenticateRequestHandler -= value);
			}
		}

		public event EventHandler<global::Com.CA.Mas.Foundation.OtpAuthenticateRequestEventArgs> OtpAuthenticateRequest {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.CA.Mas.Foundation.IMASAuthenticationListener, global::Com.CA.Mas.Foundation.IMASAuthenticationListenerImplementor>(
						ref weak_implementor_SetAuthenticationListener,
						__CreateIMASAuthenticationListenerImplementor,
						SetAuthenticationListener,
						__h => __h.OnOtpAuthenticateRequestHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.CA.Mas.Foundation.IMASAuthenticationListener, global::Com.CA.Mas.Foundation.IMASAuthenticationListenerImplementor>(
						ref weak_implementor_SetAuthenticationListener,
						global::Com.CA.Mas.Foundation.IMASAuthenticationListenerImplementor.__IsEmpty,
						__v => SetAuthenticationListener (null),
						__h => __h.OnOtpAuthenticateRequestHandler -= value);
			}
		}

		WeakReference weak_implementor_SetAuthenticationListener;

		global::Com.CA.Mas.Foundation.IMASAuthenticationListenerImplementor __CreateIMASAuthenticationListenerImplementor ()
		{
			return new global::Com.CA.Mas.Foundation.IMASAuthenticationListenerImplementor (this);
		}
#endregion
	}
}
