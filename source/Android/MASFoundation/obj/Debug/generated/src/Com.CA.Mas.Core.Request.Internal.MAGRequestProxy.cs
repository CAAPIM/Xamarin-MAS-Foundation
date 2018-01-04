using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Request.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='MAGRequestProxy']"
	[global::Android.Runtime.Register ("com/ca/mas/core/request/internal/MAGRequestProxy", DoNotGenerateAcw=true)]
	public abstract partial class MAGRequestProxy : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/request/internal/MAGRequestProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGRequestProxy); }
		}

		protected MAGRequestProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='MAGRequestProxy']/constructor[@name='MAGRequestProxy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MAGRequestProxy ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MAGRequestProxy)) {
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

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Body);
		}
#pragma warning restore 0169

		static IntPtr id_getBody;
		public virtual unsafe global::Com.CA.Mas.Core.Http.MAGRequestBody Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='MAGRequestProxy']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Lcom/ca/mas/core/http/MAGRequestBody;", "GetGetBodyHandler")]
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/ca/mas/core/http/MAGRequestBody;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGRequestBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGRequestBody> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Lcom/ca/mas/core/http/MAGRequestBody;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGrantProvider;
#pragma warning disable 0169
		static Delegate GetGetGrantProviderHandler ()
		{
			if (cb_getGrantProvider == null)
				cb_getGrantProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGrantProvider);
			return cb_getGrantProvider;
		}

		static IntPtr n_GetGrantProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GrantProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getGrantProvider;
		public virtual unsafe global::Com.CA.Mas.Core.Oauth.GrantProvider GrantProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='MAGRequestProxy']/method[@name='getGrantProvider' and count(parameter)=0]"
			[Register ("getGrantProvider", "()Lcom/ca/mas/core/oauth/GrantProvider;", "GetGetGrantProviderHandler")]
			get {
				if (id_getGrantProvider == IntPtr.Zero)
					id_getGrantProvider = JNIEnv.GetMethodID (class_ref, "getGrantProvider", "()Lcom/ca/mas/core/oauth/GrantProvider;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.GrantProvider> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGrantProvider), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.GrantProvider> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGrantProvider", "()Lcom/ca/mas/core/oauth/GrantProvider;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='MAGRequestProxy']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isPublic;
#pragma warning disable 0169
		static Delegate GetIsPublicHandler ()
		{
			if (cb_isPublic == null)
				cb_isPublic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPublic);
			return cb_isPublic;
		}

		static bool n_IsPublic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPublic;
		}
#pragma warning restore 0169

		static IntPtr id_isPublic;
		public virtual unsafe bool IsPublic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='MAGRequestProxy']/method[@name='isPublic' and count(parameter)=0]"
			[Register ("isPublic", "()Z", "GetIsPublicHandler")]
			get {
				if (id_isPublic == IntPtr.Zero)
					id_isPublic = JNIEnv.GetMethodID (class_ref, "isPublic", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPublic);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPublic", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethod);
			return cb_getMethod;
		}

		static IntPtr n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Method);
		}
#pragma warning restore 0169

		static IntPtr id_getMethod;
		public virtual unsafe string Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='MAGRequestProxy']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Ljava/lang/String;", "GetGetMethodHandler")]
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMethod", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScope;
#pragma warning disable 0169
		static Delegate GetGetScopeHandler ()
		{
			if (cb_getScope == null)
				cb_getScope = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScope);
			return cb_getScope;
		}

		static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scope);
		}
#pragma warning restore 0169

		static IntPtr id_getScope;
		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='MAGRequestProxy']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				if (id_getScope == IntPtr.Zero)
					id_getScope = JNIEnv.GetMethodID (class_ref, "getScope", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScope), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScope", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getURL;
#pragma warning disable 0169
		static Delegate GetGetURLHandler ()
		{
			if (cb_getURL == null)
				cb_getURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetURL);
			return cb_getURL;
		}

		static IntPtr n_GetURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.URL);
		}
#pragma warning restore 0169

		static IntPtr id_getURL;
		public virtual unsafe global::Java.Net.URL URL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.request.internal']/class[@name='MAGRequestProxy']/method[@name='getURL' and count(parameter)=0]"
			[Register ("getURL", "()Ljava/net/URL;", "GetGetURLHandler")]
			get {
				if (id_getURL == IntPtr.Zero)
					id_getURL = JNIEnv.GetMethodID (class_ref, "getURL", "()Ljava/net/URL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getURL), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getURL", "()Ljava/net/URL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/request/internal/MAGRequestProxy", DoNotGenerateAcw=true)]
	internal partial class MAGRequestProxyInvoker : MAGRequestProxy {

		public MAGRequestProxyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGRequestProxyInvoker); }
		}

	}

}
