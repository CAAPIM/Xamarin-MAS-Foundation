using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASAuthenticationProvider", DoNotGenerateAcw=true)]
	public partial class MASAuthenticationProvider : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/auth/MASAuthenticationProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASAuthenticationProvider); }
		}

		protected MASAuthenticationProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/constructor[@name='MASAuthenticationProvider' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe MASAuthenticationProvider (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (MASAuthenticationProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_ca_mas_core_service_Provider_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/constructor[@name='MASAuthenticationProvider' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.service.Provider']]"
		[Register (".ctor", "(Lcom/ca/mas/core/service/Provider;)V", "")]
		protected unsafe MASAuthenticationProvider (global::Com.CA.Mas.Core.Service.Provider provider)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (provider);
				if (((object) this).GetType () != typeof (MASAuthenticationProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/core/service/Provider;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/core/service/Provider;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_core_service_Provider_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_core_service_Provider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/core/service/Provider;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_core_service_Provider_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_core_service_Provider_, __args);
			} finally {
			}
		}

		static Delegate cb_getAuthenticationUrl;
#pragma warning disable 0169
		static Delegate GetGetAuthenticationUrlHandler ()
		{
			if (cb_getAuthenticationUrl == null)
				cb_getAuthenticationUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthenticationUrl);
			return cb_getAuthenticationUrl;
		}

		static IntPtr n_GetAuthenticationUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthenticationUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthenticationUrl;
		public virtual unsafe string AuthenticationUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='getAuthenticationUrl' and count(parameter)=0]"
			[Register ("getAuthenticationUrl", "()Ljava/lang/String;", "GetGetAuthenticationUrlHandler")]
			get {
				if (id_getAuthenticationUrl == IntPtr.Zero)
					id_getAuthenticationUrl = JNIEnv.GetMethodID (class_ref, "getAuthenticationUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthenticationUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthenticationUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Identifier);
		}
#pragma warning restore 0169

		static IntPtr id_getIdentifier;
		public virtual unsafe string Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler")]
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEnterprise;
#pragma warning disable 0169
		static Delegate GetIsEnterpriseHandler ()
		{
			if (cb_isEnterprise == null)
				cb_isEnterprise = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnterprise);
			return cb_isEnterprise;
		}

		static bool n_IsEnterprise (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnterprise;
		}
#pragma warning restore 0169

		static IntPtr id_isEnterprise;
		public virtual unsafe bool IsEnterprise {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='isEnterprise' and count(parameter)=0]"
			[Register ("isEnterprise", "()Z", "GetIsEnterpriseHandler")]
			get {
				if (id_isEnterprise == IntPtr.Zero)
					id_isEnterprise = JNIEnv.GetMethodID (class_ref, "isEnterprise", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnterprise);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnterprise", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isFacebook;
#pragma warning disable 0169
		static Delegate GetIsFacebookHandler ()
		{
			if (cb_isFacebook == null)
				cb_isFacebook = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFacebook);
			return cb_isFacebook;
		}

		static bool n_IsFacebook (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFacebook;
		}
#pragma warning restore 0169

		static IntPtr id_isFacebook;
		public virtual unsafe bool IsFacebook {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='isFacebook' and count(parameter)=0]"
			[Register ("isFacebook", "()Z", "GetIsFacebookHandler")]
			get {
				if (id_isFacebook == IntPtr.Zero)
					id_isFacebook = JNIEnv.GetMethodID (class_ref, "isFacebook", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFacebook);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFacebook", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isGoogle;
#pragma warning disable 0169
		static Delegate GetIsGoogleHandler ()
		{
			if (cb_isGoogle == null)
				cb_isGoogle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGoogle);
			return cb_isGoogle;
		}

		static bool n_IsGoogle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGoogle;
		}
#pragma warning restore 0169

		static IntPtr id_isGoogle;
		public virtual unsafe bool IsGoogle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='isGoogle' and count(parameter)=0]"
			[Register ("isGoogle", "()Z", "GetIsGoogleHandler")]
			get {
				if (id_isGoogle == IntPtr.Zero)
					id_isGoogle = JNIEnv.GetMethodID (class_ref, "isGoogle", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isGoogle);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGoogle", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLinkedIn;
#pragma warning disable 0169
		static Delegate GetIsLinkedInHandler ()
		{
			if (cb_isLinkedIn == null)
				cb_isLinkedIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLinkedIn);
			return cb_isLinkedIn;
		}

		static bool n_IsLinkedIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLinkedIn;
		}
#pragma warning restore 0169

		static IntPtr id_isLinkedIn;
		public virtual unsafe bool IsLinkedIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='isLinkedIn' and count(parameter)=0]"
			[Register ("isLinkedIn", "()Z", "GetIsLinkedInHandler")]
			get {
				if (id_isLinkedIn == IntPtr.Zero)
					id_isLinkedIn = JNIEnv.GetMethodID (class_ref, "isLinkedIn", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLinkedIn);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLinkedIn", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isProximityLogin;
#pragma warning disable 0169
		static Delegate GetIsProximityLoginHandler ()
		{
			if (cb_isProximityLogin == null)
				cb_isProximityLogin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsProximityLogin);
			return cb_isProximityLogin;
		}

		static bool n_IsProximityLogin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsProximityLogin;
		}
#pragma warning restore 0169

		static IntPtr id_isProximityLogin;
		public virtual unsafe bool IsProximityLogin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='isProximityLogin' and count(parameter)=0]"
			[Register ("isProximityLogin", "()Z", "GetIsProximityLoginHandler")]
			get {
				if (id_isProximityLogin == IntPtr.Zero)
					id_isProximityLogin = JNIEnv.GetMethodID (class_ref, "isProximityLogin", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isProximityLogin);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isProximityLogin", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSalesForce;
#pragma warning disable 0169
		static Delegate GetIsSalesForceHandler ()
		{
			if (cb_isSalesForce == null)
				cb_isSalesForce = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSalesForce);
			return cb_isSalesForce;
		}

		static bool n_IsSalesForce (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSalesForce;
		}
#pragma warning restore 0169

		static IntPtr id_isSalesForce;
		public virtual unsafe bool IsSalesForce {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='isSalesForce' and count(parameter)=0]"
			[Register ("isSalesForce", "()Z", "GetIsSalesForceHandler")]
			get {
				if (id_isSalesForce == IntPtr.Zero)
					id_isSalesForce = JNIEnv.GetMethodID (class_ref, "isSalesForce", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSalesForce);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSalesForce", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getPollUrl;
#pragma warning disable 0169
		static Delegate GetGetPollUrlHandler ()
		{
			if (cb_getPollUrl == null)
				cb_getPollUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPollUrl);
			return cb_getPollUrl;
		}

		static IntPtr n_GetPollUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PollUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getPollUrl;
		public virtual unsafe string PollUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='getPollUrl' and count(parameter)=0]"
			[Register ("getPollUrl", "()Ljava/lang/String;", "GetGetPollUrlHandler")]
			get {
				if (id_getPollUrl == IntPtr.Zero)
					id_getPollUrl = JNIEnv.GetMethodID (class_ref, "getPollUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPollUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPollUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_provider, IntPtr native__callback)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider provider = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (native_provider, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetAuthConfiguration (context, provider, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='getAuthConfiguration' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.ca.mas.foundation.auth.MASAuthenticationProvider'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;android.net.Uri&gt;']]"
		[Register ("getAuthConfiguration", "(Landroid/content/Context;Lcom/ca/mas/foundation/auth/MASAuthenticationProvider;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public virtual unsafe void GetAuthConfiguration (global::Android.Content.Context context, global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider provider, global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_getAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getAuthConfiguration", "(Landroid/content/Context;Lcom/ca/mas/foundation/auth/MASAuthenticationProvider;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (provider);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAuthConfiguration_Landroid_content_Context_Lcom_ca_mas_foundation_auth_MASAuthenticationProvider_Lcom_ca_mas_foundation_MASCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthConfiguration", "(Landroid/content/Context;Lcom/ca/mas/foundation/auth/MASAuthenticationProvider;Lcom/ca/mas/foundation/MASCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASAuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASAuthenticationProvider']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
