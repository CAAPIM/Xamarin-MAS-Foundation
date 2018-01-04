using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Oauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenResponse']"
	[global::Android.Runtime.Register ("com/ca/mas/core/oauth/OAuthTokenResponse", DoNotGenerateAcw=true)]
	public partial class OAuthTokenResponse : global::Com.CA.Mas.Core.Client.ServerResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/oauth/OAuthTokenResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthTokenResponse); }
		}

		protected OAuthTokenResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_client_ServerResponse_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenResponse']/constructor[@name='OAuthTokenResponse' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.client.ServerResponse']]"
		[Register (".ctor", "(Lcom/ca/mas/core/client/ServerResponse;)V", "")]
		public unsafe OAuthTokenResponse (global::Com.CA.Mas.Core.Client.ServerResponse response)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (response);
				if (((object) this).GetType () != typeof (OAuthTokenResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/core/client/ServerResponse;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/core/client/ServerResponse;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_core_client_ServerResponse_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_core_client_ServerResponse_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/core/client/ServerResponse;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_core_client_ServerResponse_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_core_client_ServerResponse_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenResponse']/constructor[@name='OAuthTokenResponse' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(IILjava/lang/String;)V", "")]
		public unsafe OAuthTokenResponse (int status, int errorCode, string json)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (status);
				__args [1] = new JValue (errorCode);
				__args [2] = new JValue (native_json);
				if (((object) this).GetType () != typeof (OAuthTokenResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_IILjava_lang_String_ == IntPtr.Zero)
					id_ctor_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenResponse']/constructor[@name='OAuthTokenResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe OAuthTokenResponse (int status, string json)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (status);
				__args [1] = new JValue (native_json);
				if (((object) this).GetType () != typeof (OAuthTokenResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

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
			global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static IntPtr id_getAccessToken;
		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenResponse']/method[@name='getAccessToken' and count(parameter)=0]"
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

		static Delegate cb_getExpiresIn;
#pragma warning disable 0169
		static Delegate GetGetExpiresInHandler ()
		{
			if (cb_getExpiresIn == null)
				cb_getExpiresIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpiresIn);
			return cb_getExpiresIn;
		}

		static long n_GetExpiresIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpiresIn;
		}
#pragma warning restore 0169

		static IntPtr id_getExpiresIn;
		public virtual unsafe long ExpiresIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenResponse']/method[@name='getExpiresIn' and count(parameter)=0]"
			[Register ("getExpiresIn", "()J", "GetGetExpiresInHandler")]
			get {
				if (id_getExpiresIn == IntPtr.Zero)
					id_getExpiresIn = JNIEnv.GetMethodID (class_ref, "getExpiresIn", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getExpiresIn);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpiresIn", "()J"));
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
			global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GrantedScope);
		}
#pragma warning restore 0169

		static IntPtr id_getGrantedScope;
		public virtual unsafe string GrantedScope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenResponse']/method[@name='getGrantedScope' and count(parameter)=0]"
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
			global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IdToken);
		}
#pragma warning restore 0169

		static IntPtr id_getIdToken;
		public virtual unsafe global::Com.CA.Mas.Core.Token.IdToken IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenResponse']/method[@name='getIdToken' and count(parameter)=0]"
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

		static Delegate cb_isBearer;
#pragma warning disable 0169
		static Delegate GetIsBearerHandler ()
		{
			if (cb_isBearer == null)
				cb_isBearer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBearer);
			return cb_isBearer;
		}

		static bool n_IsBearer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBearer;
		}
#pragma warning restore 0169

		static IntPtr id_isBearer;
		public virtual unsafe bool IsBearer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenResponse']/method[@name='isBearer' and count(parameter)=0]"
			[Register ("isBearer", "()Z", "GetIsBearerHandler")]
			get {
				if (id_isBearer == IntPtr.Zero)
					id_isBearer = JNIEnv.GetMethodID (class_ref, "isBearer", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBearer);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBearer", "()Z"));
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
			global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.OAuthTokenResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		static IntPtr id_getRefreshToken;
		public virtual unsafe string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthTokenResponse']/method[@name='getRefreshToken' and count(parameter)=0]"
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

	}
}
