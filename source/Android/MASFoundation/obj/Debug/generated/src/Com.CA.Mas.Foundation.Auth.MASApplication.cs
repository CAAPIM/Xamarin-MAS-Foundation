using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASApplication", DoNotGenerateAcw=true)]
	public abstract partial class MASApplication : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication.MASApplicationLauncher']"
		[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASApplication$MASApplicationLauncher", DoNotGenerateAcw=true)]
		public abstract partial class MASApplicationLauncher : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/foundation/auth/MASApplication$MASApplicationLauncher", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MASApplicationLauncher); }
			}

			protected MASApplicationLauncher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication.MASApplicationLauncher']/constructor[@name='MASApplication.MASApplicationLauncher' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MASApplicationLauncher ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (MASApplicationLauncher)) {
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

			static Delegate cb_onNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_;
#pragma warning disable 0169
			static Delegate GetOnNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_Handler ()
			{
				if (cb_onNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_ == null)
					cb_onNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_);
				return cb_onNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_;
			}

			static void n_OnNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_application)
			{
				global::Com.CA.Mas.Foundation.Auth.MASApplication.MASApplicationLauncher __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication.MASApplicationLauncher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.CA.Mas.Foundation.Auth.MASApplication application = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication> (native_application, JniHandleOwnership.DoNotTransfer);
				__this.OnNativeAppLaunch (application);
			}
#pragma warning restore 0169

			static IntPtr id_onNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication.MASApplicationLauncher']/method[@name='onNativeAppLaunch' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.auth.MASApplication']]"
			[Register ("onNativeAppLaunch", "(Lcom/ca/mas/foundation/auth/MASApplication;)V", "GetOnNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_Handler")]
			public virtual unsafe void OnNativeAppLaunch (global::Com.CA.Mas.Foundation.Auth.MASApplication application)
			{
				if (id_onNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_ == IntPtr.Zero)
					id_onNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_ = JNIEnv.GetMethodID (class_ref, "onNativeAppLaunch", "(Lcom/ca/mas/foundation/auth/MASApplication;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (application);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNativeAppLaunch", "(Lcom/ca/mas/foundation/auth/MASApplication;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_;
#pragma warning disable 0169
			static Delegate GetOnWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_Handler ()
			{
				if (cb_onWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_ == null)
					cb_onWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_);
				return cb_onWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_;
			}

			static void n_OnWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.CA.Mas.Foundation.Auth.MASApplication.MASApplicationLauncher __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication.MASApplicationLauncher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.CA.Mas.Foundation.Auth.MASApplication p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnWebAppLaunch (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication.MASApplicationLauncher']/method[@name='onWebAppLaunch' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.auth.MASApplication']]"
			[Register ("onWebAppLaunch", "(Lcom/ca/mas/foundation/auth/MASApplication;)V", "GetOnWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_Handler")]
			public abstract void OnWebAppLaunch (global::Com.CA.Mas.Foundation.Auth.MASApplication p0);

		}

		[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASApplication$MASApplicationLauncher", DoNotGenerateAcw=true)]
		internal partial class MASApplicationLauncherInvoker : MASApplicationLauncher {

			public MASApplicationLauncherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (MASApplicationLauncherInvoker); }
			}

			static IntPtr id_onWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication.MASApplicationLauncher']/method[@name='onWebAppLaunch' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.auth.MASApplication']]"
			[Register ("onWebAppLaunch", "(Lcom/ca/mas/foundation/auth/MASApplication;)V", "GetOnWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_Handler")]
			public override unsafe void OnWebAppLaunch (global::Com.CA.Mas.Foundation.Auth.MASApplication p0)
			{
				if (id_onWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_ == IntPtr.Zero)
					id_onWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_ = JNIEnv.GetMethodID (class_ref, "onWebAppLaunch", "(Lcom/ca/mas/foundation/auth/MASApplication;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebAppLaunch_Lcom_ca_mas_foundation_auth_MASApplication_, __args);
				} finally {
				}
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/auth/MASApplication", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASApplication); }
		}

		protected MASApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAuthUrl;
#pragma warning disable 0169
		static Delegate GetGetAuthUrlHandler ()
		{
			if (cb_getAuthUrl == null)
				cb_getAuthUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthUrl);
			return cb_getAuthUrl;
		}

		static IntPtr n_GetAuthUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASApplication __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthUrl);
		}
#pragma warning restore 0169

		public abstract string AuthUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getAuthUrl' and count(parameter)=0]"
			[Register ("getAuthUrl", "()Ljava/lang/String;", "GetGetAuthUrlHandler")] get;
		}

		static Delegate cb_getCustom;
#pragma warning disable 0169
		static Delegate GetGetCustomHandler ()
		{
			if (cb_getCustom == null)
				cb_getCustom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustom);
			return cb_getCustom;
		}

		static IntPtr n_GetCustom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASApplication __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Custom);
		}
#pragma warning restore 0169

		public abstract global::Org.Json.JSONObject Custom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getCustom' and count(parameter)=0]"
			[Register ("getCustom", "()Lorg/json/JSONObject;", "GetGetCustomHandler")] get;
		}

		static Delegate cb_getIconUrl;
#pragma warning disable 0169
		static Delegate GetGetIconUrlHandler ()
		{
			if (cb_getIconUrl == null)
				cb_getIconUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconUrl);
			return cb_getIconUrl;
		}

		static IntPtr n_GetIconUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASApplication __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IconUrl);
		}
#pragma warning restore 0169

		public abstract string IconUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getIconUrl' and count(parameter)=0]"
			[Register ("getIconUrl", "()Ljava/lang/String;", "GetGetIconUrlHandler")] get;
		}

		static Delegate cb_getIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIdentifierHandler ()
		{
			if (cb_getIdentifier == null)
				cb_getIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentifier);
			return cb_getIdentifier;
		}

		static IntPtr n_GetIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASApplication __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Identifier);
		}
#pragma warning restore 0169

		public abstract string Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler")] get;
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASApplication __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")] get;
		}

		static Delegate cb_getNativeUri;
#pragma warning disable 0169
		static Delegate GetGetNativeUriHandler ()
		{
			if (cb_getNativeUri == null)
				cb_getNativeUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNativeUri);
			return cb_getNativeUri;
		}

		static IntPtr n_GetNativeUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASApplication __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NativeUri);
		}
#pragma warning restore 0169

		public abstract string NativeUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getNativeUri' and count(parameter)=0]"
			[Register ("getNativeUri", "()Ljava/lang/String;", "GetGetNativeUriHandler")] get;
		}

		static Delegate cb_renderEnterpriseIcon_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetRenderEnterpriseIcon_Landroid_widget_ImageView_Handler ()
		{
			if (cb_renderEnterpriseIcon_Landroid_widget_ImageView_ == null)
				cb_renderEnterpriseIcon_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderEnterpriseIcon_Landroid_widget_ImageView_);
			return cb_renderEnterpriseIcon_Landroid_widget_ImageView_;
		}

		static void n_RenderEnterpriseIcon_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.Auth.MASApplication __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenderEnterpriseIcon (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='renderEnterpriseIcon' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("renderEnterpriseIcon", "(Landroid/widget/ImageView;)V", "GetRenderEnterpriseIcon_Landroid_widget_ImageView_Handler")]
		public abstract void RenderEnterpriseIcon (global::Android.Widget.ImageView p0);

		static IntPtr id_retrieveEnterpriseApps_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='retrieveEnterpriseApps' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.auth.MASApplication&gt;&gt;']]"
		[Register ("retrieveEnterpriseApps", "(Lcom/ca/mas/foundation/MASCallback;)V", "")]
		public static unsafe void RetrieveEnterpriseApps (global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_retrieveEnterpriseApps_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_retrieveEnterpriseApps_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "retrieveEnterpriseApps", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_retrieveEnterpriseApps_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_setApplicationLauncher_Lcom_ca_mas_foundation_auth_MASApplication_MASApplicationLauncher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='setApplicationLauncher' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.auth.MASApplication.MASApplicationLauncher']]"
		[Register ("setApplicationLauncher", "(Lcom/ca/mas/foundation/auth/MASApplication$MASApplicationLauncher;)V", "")]
		public static unsafe void SetApplicationLauncher (global::Com.CA.Mas.Foundation.Auth.MASApplication.MASApplicationLauncher launcher)
		{
			if (id_setApplicationLauncher_Lcom_ca_mas_foundation_auth_MASApplication_MASApplicationLauncher_ == IntPtr.Zero)
				id_setApplicationLauncher_Lcom_ca_mas_foundation_auth_MASApplication_MASApplicationLauncher_ = JNIEnv.GetStaticMethodID (class_ref, "setApplicationLauncher", "(Lcom/ca/mas/foundation/auth/MASApplication$MASApplicationLauncher;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (launcher);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setApplicationLauncher_Lcom_ca_mas_foundation_auth_MASApplication_MASApplicationLauncher_, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASApplication", DoNotGenerateAcw=true)]
	internal partial class MASApplicationInvoker : MASApplication {

		public MASApplicationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASApplicationInvoker); }
		}

		static IntPtr id_getAuthUrl;
		public override unsafe string AuthUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getAuthUrl' and count(parameter)=0]"
			[Register ("getAuthUrl", "()Ljava/lang/String;", "GetGetAuthUrlHandler")]
			get {
				if (id_getAuthUrl == IntPtr.Zero)
					id_getAuthUrl = JNIEnv.GetMethodID (class_ref, "getAuthUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCustom;
		public override unsafe global::Org.Json.JSONObject Custom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getCustom' and count(parameter)=0]"
			[Register ("getCustom", "()Lorg/json/JSONObject;", "GetGetCustomHandler")]
			get {
				if (id_getCustom == IntPtr.Zero)
					id_getCustom = JNIEnv.GetMethodID (class_ref, "getCustom", "()Lorg/json/JSONObject;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustom), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getIconUrl;
		public override unsafe string IconUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getIconUrl' and count(parameter)=0]"
			[Register ("getIconUrl", "()Ljava/lang/String;", "GetGetIconUrlHandler")]
			get {
				if (id_getIconUrl == IntPtr.Zero)
					id_getIconUrl = JNIEnv.GetMethodID (class_ref, "getIconUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIconUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getIdentifier;
		public override unsafe string Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler")]
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getName;
		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getNativeUri;
		public override unsafe string NativeUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='getNativeUri' and count(parameter)=0]"
			[Register ("getNativeUri", "()Ljava/lang/String;", "GetGetNativeUriHandler")]
			get {
				if (id_getNativeUri == IntPtr.Zero)
					id_getNativeUri = JNIEnv.GetMethodID (class_ref, "getNativeUri", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNativeUri), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_renderEnterpriseIcon_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASApplication']/method[@name='renderEnterpriseIcon' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("renderEnterpriseIcon", "(Landroid/widget/ImageView;)V", "GetRenderEnterpriseIcon_Landroid_widget_ImageView_Handler")]
		public override unsafe void RenderEnterpriseIcon (global::Android.Widget.ImageView p0)
		{
			if (id_renderEnterpriseIcon_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_renderEnterpriseIcon_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "renderEnterpriseIcon", "(Landroid/widget/ImageView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_renderEnterpriseIcon_Landroid_widget_ImageView_, __args);
			} finally {
			}
		}

	}

}
