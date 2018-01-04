using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASWebApplication']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASWebApplication", DoNotGenerateAcw=true)]
	public partial class MASWebApplication : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/auth/MASWebApplication", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASWebApplication); }
		}

		protected MASWebApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_webkit_WebView_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASWebApplication']/constructor[@name='MASWebApplication' and count(parameter)=2 and parameter[1][@type='android.webkit.WebView'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/webkit/WebView;Ljava/lang/String;)V", "")]
		public unsafe MASWebApplication (global::Android.Webkit.WebView webView, string authUrl)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_authUrl = JNIEnv.NewString (authUrl);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (webView);
				__args [1] = new JValue (native_authUrl);
				if (((object) this).GetType () != typeof (MASWebApplication)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/webkit/WebView;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/webkit/WebView;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_webkit_WebView_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_webkit_WebView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/webkit/WebView;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_webkit_WebView_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_webkit_WebView_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authUrl);
			}
		}

		static Delegate cb_getRequestTimeout;
#pragma warning disable 0169
		static Delegate GetGetRequestTimeoutHandler ()
		{
			if (cb_getRequestTimeout == null)
				cb_getRequestTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRequestTimeout);
			return cb_getRequestTimeout;
		}

		static int n_GetRequestTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASWebApplication __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASWebApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestTimeout;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestTimeout;
		protected virtual unsafe int RequestTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASWebApplication']/method[@name='getRequestTimeout' and count(parameter)=0]"
			[Register ("getRequestTimeout", "()I", "GetGetRequestTimeoutHandler")]
			get {
				if (id_getRequestTimeout == IntPtr.Zero)
					id_getRequestTimeout = JNIEnv.GetMethodID (class_ref, "getRequestTimeout", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRequestTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestTimeout", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWebViewClient;
#pragma warning disable 0169
		static Delegate GetGetWebViewClientHandler ()
		{
			if (cb_getWebViewClient == null)
				cb_getWebViewClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWebViewClient);
			return cb_getWebViewClient;
		}

		static IntPtr n_GetWebViewClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASWebApplication __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASWebApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WebViewClient);
		}
#pragma warning restore 0169

		static IntPtr id_getWebViewClient;
		protected virtual unsafe global::Android.Webkit.WebViewClient WebViewClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASWebApplication']/method[@name='getWebViewClient' and count(parameter)=0]"
			[Register ("getWebViewClient", "()Landroid/webkit/WebViewClient;", "GetGetWebViewClientHandler")]
			get {
				if (id_getWebViewClient == IntPtr.Zero)
					id_getWebViewClient = JNIEnv.GetMethodID (class_ref, "getWebViewClient", "()Landroid/webkit/WebViewClient;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebViewClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWebViewClient), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebViewClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWebViewClient", "()Landroid/webkit/WebViewClient;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
