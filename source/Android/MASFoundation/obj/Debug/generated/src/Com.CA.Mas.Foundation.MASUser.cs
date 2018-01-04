using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASUser", DoNotGenerateAcw=true)]
	public abstract partial class MASUser : global::Java.Lang.Object, global::Com.CA.Mas.Identity.User.IMASUserIdentity, global::Com.CA.Mas.Identity.User.IScimUser, global::Com.CA.Mas.Messaging.IMASMessenger {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASUser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASUser); }
		}

		protected MASUser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/constructor[@name='MASUser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASUser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASUser)) {
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
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		public abstract string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")] get;
		}

		static IntPtr id_getAuthCredentialsType;
		public static unsafe string AuthCredentialsType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getAuthCredentialsType' and count(parameter)=0]"
			[Register ("getAuthCredentialsType", "()Ljava/lang/String;", "GetGetAuthCredentialsTypeHandler")]
			get {
				if (id_getAuthCredentialsType == IntPtr.Zero)
					id_getAuthCredentialsType = JNIEnv.GetStaticMethodID (class_ref, "getAuthCredentialsType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAuthCredentialsType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCurrentUser;
		public static unsafe global::Com.CA.Mas.Foundation.MASUser CurrentUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getCurrentUser' and count(parameter)=0]"
			[Register ("getCurrentUser", "()Lcom/ca/mas/foundation/MASUser;", "GetGetCurrentUserHandler")]
			get {
				if (id_getCurrentUser == IntPtr.Zero)
					id_getCurrentUser = JNIEnv.GetStaticMethodID (class_ref, "getCurrentUser", "()Lcom/ca/mas/foundation/MASUser;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentUser), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAuthenticated;
#pragma warning disable 0169
		static Delegate GetIsAuthenticatedHandler ()
		{
			if (cb_isAuthenticated == null)
				cb_isAuthenticated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthenticated);
			return cb_isAuthenticated;
		}

		static bool n_IsAuthenticated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthenticated;
		}
#pragma warning restore 0169

		public abstract bool IsAuthenticated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='isAuthenticated' and count(parameter)=0]"
			[Register ("isAuthenticated", "()Z", "GetIsAuthenticatedHandler")] get;
		}

		static Delegate cb_isCurrentUser;
#pragma warning disable 0169
		static Delegate GetIsCurrentUserHandler ()
		{
			if (cb_isCurrentUser == null)
				cb_isCurrentUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCurrentUser);
			return cb_isCurrentUser;
		}

		static bool n_IsCurrentUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrentUser;
		}
#pragma warning restore 0169

		public abstract bool IsCurrentUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='isCurrentUser' and count(parameter)=0]"
			[Register ("isCurrentUser", "()Z", "GetIsCurrentUserHandler")] get;
		}

		static Delegate cb_isSessionLocked;
#pragma warning disable 0169
		static Delegate GetIsSessionLockedHandler ()
		{
			if (cb_isSessionLocked == null)
				cb_isSessionLocked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSessionLocked);
			return cb_isSessionLocked;
		}

		static bool n_IsSessionLocked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSessionLocked;
		}
#pragma warning restore 0169

		public abstract bool IsSessionLocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='isSessionLocked' and count(parameter)=0]"
			[Register ("isSessionLocked", "()Z", "GetIsSessionLockedHandler")] get;
		}

		static Delegate cb_getThumbnailImage;
#pragma warning disable 0169
		static Delegate GetGetThumbnailImageHandler ()
		{
			if (cb_getThumbnailImage == null)
				cb_getThumbnailImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThumbnailImage);
			return cb_getThumbnailImage;
		}

		static IntPtr n_GetThumbnailImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThumbnailImage);
		}
#pragma warning restore 0169

		public abstract global::Android.Graphics.Bitmap ThumbnailImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getThumbnailImage' and count(parameter)=0]"
			[Register ("getThumbnailImage", "()Landroid/graphics/Bitmap;", "GetGetThumbnailImageHandler")] get;
		}

		static Delegate cb_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetUserById (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getUserById' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASUser&gt;']]"
		[Register ("getUserById", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void GetUserById (string p0, global::Com.CA.Mas.Foundation.MASCallback p1);

		static Delegate cb_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetUserMetaData_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetUserMetaData_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetUserMetaData_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetUserMetaData (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getUserMetaData' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.identity.user.UserAttributes&gt;']]"
		[Register ("getUserMetaData", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetGetUserMetaData_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void GetUserMetaData (global::Com.CA.Mas.Foundation.MASCallback p0);

		static Delegate cb_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.MASFilteredRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetUsersByFilter (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getUsersByFilter' and count(parameter)=2 and parameter[1][@type='com.ca.mas.identity.common.MASFilteredRequest'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASUser&gt;&gt;']]"
		[Register ("getUsersByFilter", "(Lcom/ca/mas/identity/common/MASFilteredRequest;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void GetUsersByFilter (global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0, global::Com.CA.Mas.Foundation.MASCallback p1);

		static Delegate cb_lockSession_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetLockSession_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_lockSession_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_lockSession_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LockSession_Lcom_ca_mas_foundation_MASCallback_);
			return cb_lockSession_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_LockSession_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LockSession (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='lockSession' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("lockSession", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetLockSession_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void LockSession (global::Com.CA.Mas.Foundation.MASCallback p0);

		static IntPtr id_login_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='login' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASAuthCredentials'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASUser&gt;']]"
		[Register ("login", "(Lcom/ca/mas/foundation/MASAuthCredentials;Lcom/ca/mas/foundation/MASCallback;)V", "")]
		public static unsafe void Login (global::Com.CA.Mas.Foundation.IMASAuthCredentials credentials, global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_login_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_login_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "login", "(Lcom/ca/mas/foundation/MASAuthCredentials;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (credentials);
				__args [1] = new JValue (@callback);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_login_Lcom_ca_mas_foundation_MASAuthCredentials_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_login_Lcom_ca_mas_foundation_MASAuthorizationRequest_Lcom_ca_mas_foundation_MASAuthorizationRequestHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='login' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASAuthorizationRequest'] and parameter[2][@type='com.ca.mas.foundation.MASAuthorizationRequestHandler']]"
		[Register ("login", "(Lcom/ca/mas/foundation/MASAuthorizationRequest;Lcom/ca/mas/foundation/MASAuthorizationRequestHandler;)V", "")]
		public static unsafe void Login (global::Com.CA.Mas.Foundation.MASAuthorizationRequest request, global::Com.CA.Mas.Foundation.IMASAuthorizationRequestHandler handler)
		{
			if (id_login_Lcom_ca_mas_foundation_MASAuthorizationRequest_Lcom_ca_mas_foundation_MASAuthorizationRequestHandler_ == IntPtr.Zero)
				id_login_Lcom_ca_mas_foundation_MASAuthorizationRequest_Lcom_ca_mas_foundation_MASAuthorizationRequestHandler_ = JNIEnv.GetStaticMethodID (class_ref, "login", "(Lcom/ca/mas/foundation/MASAuthorizationRequest;Lcom/ca/mas/foundation/MASAuthorizationRequestHandler;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (request);
				__args [1] = new JValue (handler);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_login_Lcom_ca_mas_foundation_MASAuthorizationRequest_Lcom_ca_mas_foundation_MASAuthorizationRequestHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_login_Lcom_ca_mas_foundation_MASAuthorizationResponse_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='login' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASAuthorizationResponse'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASUser&gt;']]"
		[Register ("login", "(Lcom/ca/mas/foundation/MASAuthorizationResponse;Lcom/ca/mas/foundation/MASCallback;)V", "")]
		public static unsafe void Login (global::Com.CA.Mas.Foundation.MASAuthorizationResponse authorizationResponse, global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_login_Lcom_ca_mas_foundation_MASAuthorizationResponse_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_login_Lcom_ca_mas_foundation_MASAuthorizationResponse_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "login", "(Lcom/ca/mas/foundation/MASAuthorizationResponse;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (authorizationResponse);
				__args [1] = new JValue (@callback);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_login_Lcom_ca_mas_foundation_MASAuthorizationResponse_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_login_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='login' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASUser&gt;']]"
		[Register ("login", "(Lcom/ca/mas/foundation/MASCallback;)V", "")]
		public static unsafe void Login (global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_login_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_login_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "login", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_login_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_login_Lcom_ca_mas_foundation_MASIdToken_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='login' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASIdToken'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASUser&gt;']]"
		[Register ("login", "(Lcom/ca/mas/foundation/MASIdToken;Lcom/ca/mas/foundation/MASCallback;)V", "")]
		public static unsafe void Login (global::Com.CA.Mas.Foundation.MASIdToken idToken, global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_login_Lcom_ca_mas_foundation_MASIdToken_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_login_Lcom_ca_mas_foundation_MASIdToken_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "login", "(Lcom/ca/mas/foundation/MASIdToken;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (idToken);
				__args [1] = new JValue (@callback);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_login_Lcom_ca_mas_foundation_MASIdToken_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_login_Ljava_lang_String_arrayCLcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='login' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char[]'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASUser&gt;']]"
		[Register ("login", "(Ljava/lang/String;[CLcom/ca/mas/foundation/MASCallback;)V", "")]
		public static unsafe void Login (string userName, char[] cPassword, global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_login_Ljava_lang_String_arrayCLcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_login_Ljava_lang_String_arrayCLcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "login", "(Ljava/lang/String;[CLcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_userName = JNIEnv.NewString (userName);
			IntPtr native_cPassword = JNIEnv.NewArray (cPassword);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_userName);
				__args [1] = new JValue (native_cPassword);
				__args [2] = new JValue (@callback);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_login_Ljava_lang_String_arrayCLcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userName);
				if (cPassword != null) {
					JNIEnv.CopyArray (native_cPassword, cPassword);
					JNIEnv.DeleteLocalRef (native_cPassword);
				}
			}
		}

		static IntPtr id_login_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='login' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASUser&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("login", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "")]
		public static unsafe void Login (string userName, string password, global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_login_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_login_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetStaticMethodID (class_ref, "login", "(Ljava/lang/String;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_userName = JNIEnv.NewString (userName);
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_userName);
				__args [1] = new JValue (native_password);
				__args [2] = new JValue (@callback);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_login_Ljava_lang_String_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userName);
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

		static Delegate cb_logout_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetLogout_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_logout_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_logout_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Logout_Lcom_ca_mas_foundation_MASCallback_);
			return cb_logout_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_Logout_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='logout' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("logout", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetLogout_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void Logout (global::Com.CA.Mas.Foundation.MASCallback p0);

		static Delegate cb_removeSessionLock_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveSessionLock_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_removeSessionLock_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_removeSessionLock_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSessionLock_Lcom_ca_mas_foundation_MASCallback_);
			return cb_removeSessionLock_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_RemoveSessionLock_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSessionLock (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='removeSessionLock' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("removeSessionLock", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetRemoveSessionLock_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void RemoveSessionLock (global::Com.CA.Mas.Foundation.MASCallback p0);

		static Delegate cb_requestUserInfo_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetRequestUserInfo_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_requestUserInfo_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_requestUserInfo_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestUserInfo_Lcom_ca_mas_foundation_MASCallback_);
			return cb_requestUserInfo_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_RequestUserInfo_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestUserInfo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='requestUserInfo' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("requestUserInfo", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetRequestUserInfo_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void RequestUserInfo (global::Com.CA.Mas.Foundation.MASCallback p0);

		static Delegate cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_);
			return cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.MASMessage p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASGroup p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p2 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASGroup'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASGroup;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASGroup p1, global::Com.CA.Mas.Foundation.MASCallback p2);

		static Delegate cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_);
			return cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.MASMessage p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASGroup p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p3 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='sendMessage' and count(parameter)=4 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASGroup'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASGroup;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASGroup p1, string p2, global::Com.CA.Mas.Foundation.MASCallback p3);

		static Delegate cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_);
			return cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.MASMessage p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASUser p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p2 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASUser'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASUser;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASUser p1, global::Com.CA.Mas.Foundation.MASCallback p2);

		static Delegate cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_);
			return cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.MASMessage p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASUser p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p3 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='sendMessage' and count(parameter)=4 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASUser'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASUser;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASUser p1, string p2, global::Com.CA.Mas.Foundation.MASCallback p3);

		static Delegate cb_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_);
			return cb_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_SendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.Topic.IMASTopic p0 = (global::Com.CA.Mas.Messaging.Topic.IMASTopic)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.Topic.IMASTopic> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.MASMessage p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p2 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.ca.mas.messaging.topic.MASTopic'] and parameter[2][@type='com.ca.mas.messaging.MASMessage'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/topic/MASTopic;Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void SendMessage (global::Com.CA.Mas.Messaging.Topic.IMASTopic p0, global::Com.CA.Mas.Messaging.MASMessage p1, global::Com.CA.Mas.Foundation.MASCallback p2);

		static Delegate cb_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetStartListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_);
			return cb_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_StartListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartListeningToMyMessages (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='startListeningToMyMessages' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("startListeningToMyMessages", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetStartListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void StartListeningToMyMessages (global::Com.CA.Mas.Foundation.MASCallback p0);

		static Delegate cb_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetStopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_);
			return cb_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_StopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopListeningToMyMessages (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='stopListeningToMyMessages' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("stopListeningToMyMessages", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetStopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void StopListeningToMyMessages (global::Com.CA.Mas.Foundation.MASCallback p0);

		static Delegate cb_unlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_;
#pragma warning disable 0169
		static Delegate GetUnlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_Handler ()
		{
			if (cb_unlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_ == null)
				cb_unlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_);
			return cb_unlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_;
		}

		static void n_UnlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASSessionUnlockCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSessionUnlockCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnlockSession (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='unlockSession' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASSessionUnlockCallback&lt;java.lang.Void&gt;']]"
		[Register ("unlockSession", "(Lcom/ca/mas/foundation/MASSessionUnlockCallback;)V", "GetUnlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_Handler")]
		public abstract void UnlockSession (global::Com.CA.Mas.Foundation.MASSessionUnlockCallback p0);

		static Delegate cb_getAddressList;
#pragma warning disable 0169
		static Delegate GetGetAddressListHandler ()
		{
			if (cb_getAddressList == null)
				cb_getAddressList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddressList);
			return cb_getAddressList;
		}

		static IntPtr n_GetAddressList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASAddress>.ToLocalJniHandle (__this.AddressList);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASAddress> AddressList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getAddressList' and count(parameter)=0]"
			[Register ("getAddressList", "()Ljava/util/List;", "GetGetAddressListHandler")] get;
		}

		static Delegate cb_getEmailList;
#pragma warning disable 0169
		static Delegate GetGetEmailListHandler ()
		{
			if (cb_getEmailList == null)
				cb_getEmailList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmailList);
			return cb_getEmailList;
		}

		static IntPtr n_GetEmailList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASEmail>.ToLocalJniHandle (__this.EmailList);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASEmail> EmailList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getEmailList' and count(parameter)=0]"
			[Register ("getEmailList", "()Ljava/util/List;", "GetGetEmailListHandler")] get;
		}

		static Delegate cb_getGroupList;
#pragma warning disable 0169
		static Delegate GetGetGroupListHandler ()
		{
			if (cb_getGroupList == null)
				cb_getGroupList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupList);
			return cb_getGroupList;
		}

		static IntPtr n_GetGroupList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Foundation.MASGroup>.ToLocalJniHandle (__this.GroupList);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.CA.Mas.Foundation.MASGroup> GroupList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getGroupList' and count(parameter)=0]"
			[Register ("getGroupList", "()Ljava/util/List;", "GetGetGroupListHandler")] get;
		}

		static Delegate cb_getImsList;
#pragma warning disable 0169
		static Delegate GetGetImsListHandler ()
		{
			if (cb_getImsList == null)
				cb_getImsList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImsList);
			return cb_getImsList;
		}

		static IntPtr n_GetImsList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASIms>.ToLocalJniHandle (__this.ImsList);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASIms> ImsList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getImsList' and count(parameter)=0]"
			[Register ("getImsList", "()Ljava/util/List;", "GetGetImsListHandler")] get;
		}

		static Delegate cb_isActive;
#pragma warning disable 0169
		static Delegate GetIsActiveHandler ()
		{
			if (cb_isActive == null)
				cb_isActive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsActive);
			return cb_isActive;
		}

		static bool n_IsActive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActive;
		}
#pragma warning restore 0169

		public abstract bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "GetIsActiveHandler")] get;
		}

		static Delegate cb_getLocale;
#pragma warning disable 0169
		static Delegate GetGetLocaleHandler ()
		{
			if (cb_getLocale == null)
				cb_getLocale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocale);
			return cb_getLocale;
		}

		static IntPtr n_GetLocale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Locale);
		}
#pragma warning restore 0169

		public abstract string Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/lang/String;", "GetGetLocaleHandler")] get;
		}

		static Delegate cb_getMeta;
#pragma warning disable 0169
		static Delegate GetGetMetaHandler ()
		{
			if (cb_getMeta == null)
				cb_getMeta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeta);
			return cb_getMeta;
		}

		static IntPtr n_GetMeta (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Meta);
		}
#pragma warning restore 0169

		public abstract global::Com.CA.Mas.Identity.User.MASMeta Meta {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getMeta' and count(parameter)=0]"
			[Register ("getMeta", "()Lcom/ca/mas/identity/user/MASMeta;", "GetGetMetaHandler")] get;
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
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Name);
		}
#pragma warning restore 0169

		public abstract global::Com.CA.Mas.Identity.User.MASName Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Lcom/ca/mas/identity/user/MASName;", "GetGetNameHandler")] get;
		}

		static Delegate cb_getNickName;
#pragma warning disable 0169
		static Delegate GetGetNickNameHandler ()
		{
			if (cb_getNickName == null)
				cb_getNickName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNickName);
			return cb_getNickName;
		}

		static IntPtr n_GetNickName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NickName);
		}
#pragma warning restore 0169

		public abstract string NickName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getNickName' and count(parameter)=0]"
			[Register ("getNickName", "()Ljava/lang/String;", "GetGetNickNameHandler")] get;
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		public abstract string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")] get;
		}

		static Delegate cb_getPhoneList;
#pragma warning disable 0169
		static Delegate GetGetPhoneListHandler ()
		{
			if (cb_getPhoneList == null)
				cb_getPhoneList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneList);
			return cb_getPhoneList;
		}

		static IntPtr n_GetPhoneList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASPhone>.ToLocalJniHandle (__this.PhoneList);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASPhone> PhoneList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getPhoneList' and count(parameter)=0]"
			[Register ("getPhoneList", "()Ljava/util/List;", "GetGetPhoneListHandler")] get;
		}

		static Delegate cb_getPhotoList;
#pragma warning disable 0169
		static Delegate GetGetPhotoListHandler ()
		{
			if (cb_getPhotoList == null)
				cb_getPhotoList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhotoList);
			return cb_getPhotoList;
		}

		static IntPtr n_GetPhotoList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASPhoto>.ToLocalJniHandle (__this.PhotoList);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASPhoto> PhotoList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getPhotoList' and count(parameter)=0]"
			[Register ("getPhotoList", "()Ljava/util/List;", "GetGetPhotoListHandler")] get;
		}

		static Delegate cb_getPreferredLanguage;
#pragma warning disable 0169
		static Delegate GetGetPreferredLanguageHandler ()
		{
			if (cb_getPreferredLanguage == null)
				cb_getPreferredLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreferredLanguage);
			return cb_getPreferredLanguage;
		}

		static IntPtr n_GetPreferredLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PreferredLanguage);
		}
#pragma warning restore 0169

		public abstract string PreferredLanguage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getPreferredLanguage' and count(parameter)=0]"
			[Register ("getPreferredLanguage", "()Ljava/lang/String;", "GetGetPreferredLanguageHandler")] get;
		}

		static Delegate cb_getProfileUrl;
#pragma warning disable 0169
		static Delegate GetGetProfileUrlHandler ()
		{
			if (cb_getProfileUrl == null)
				cb_getProfileUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProfileUrl);
			return cb_getProfileUrl;
		}

		static IntPtr n_GetProfileUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfileUrl);
		}
#pragma warning restore 0169

		public abstract string ProfileUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getProfileUrl' and count(parameter)=0]"
			[Register ("getProfileUrl", "()Ljava/lang/String;", "GetGetProfileUrlHandler")] get;
		}

		static Delegate cb_getSource;
#pragma warning disable 0169
		static Delegate GetGetSourceHandler ()
		{
			if (cb_getSource == null)
				cb_getSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSource);
			return cb_getSource;
		}

		static IntPtr n_GetSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Source);
		}
#pragma warning restore 0169

		public abstract global::Org.Json.JSONObject Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Lorg/json/JSONObject;", "GetGetSourceHandler")] get;
		}

		static Delegate cb_getTimeZone;
#pragma warning disable 0169
		static Delegate GetGetTimeZoneHandler ()
		{
			if (cb_getTimeZone == null)
				cb_getTimeZone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeZone);
			return cb_getTimeZone;
		}

		static IntPtr n_GetTimeZone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TimeZone);
		}
#pragma warning restore 0169

		public abstract string TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()Ljava/lang/String;", "GetGetTimeZoneHandler")] get;
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public abstract string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")] get;
		}

		static Delegate cb_getUserName;
#pragma warning disable 0169
		static Delegate GetGetUserNameHandler ()
		{
			if (cb_getUserName == null)
				cb_getUserName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserName);
			return cb_getUserName;
		}

		static IntPtr n_GetUserName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserName);
		}
#pragma warning restore 0169

		public abstract string UserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getUserName' and count(parameter)=0]"
			[Register ("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler")] get;
		}

		static Delegate cb_getUserType;
#pragma warning disable 0169
		static Delegate GetGetUserTypeHandler ()
		{
			if (cb_getUserType == null)
				cb_getUserType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserType);
			return cb_getUserType;
		}

		static IntPtr n_GetUserType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserType);
		}
#pragma warning restore 0169

		public abstract string UserType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getUserType' and count(parameter)=0]"
			[Register ("getUserType", "()Ljava/lang/String;", "GetGetUserTypeHandler")] get;
		}

		static Delegate cb_populate_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetPopulate_Lorg_json_JSONObject_Handler ()
		{
			if (cb_populate_Lorg_json_JSONObject_ == null)
				cb_populate_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Populate_Lorg_json_JSONObject_);
			return cb_populate_Lorg_json_JSONObject_;
		}

		static void n_Populate_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Populate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASTransformable']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("populate", "(Lorg/json/JSONObject;)V", "GetPopulate_Lorg_json_JSONObject_Handler")]
		public abstract void Populate (global::Org.Json.JSONObject p0);

		static Delegate cb_getAsJSONObject;
#pragma warning disable 0169
		static Delegate GetGetAsJSONObjectHandler ()
		{
			if (cb_getAsJSONObject == null)
				cb_getAsJSONObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJSONObject);
			return cb_getAsJSONObject;
		}

		static IntPtr n_GetAsJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJSONObject);
		}
#pragma warning restore 0169

		public abstract global::Org.Json.JSONObject AsJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getAsJSONObject' and count(parameter)=0]"
			[Register ("getAsJSONObject", "()Lorg/json/JSONObject;", "GetGetAsJSONObjectHandler")] get;
		}

		static Delegate cb_getCardinality;
#pragma warning disable 0169
		static Delegate GetGetCardinalityHandler ()
		{
			if (cb_getCardinality == null)
				cb_getCardinality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCardinality);
			return cb_getCardinality;
		}

		static long n_GetCardinality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cardinality;
		}
#pragma warning restore 0169

		public abstract long Cardinality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getCardinality' and count(parameter)=0]"
			[Register ("getCardinality", "()J", "GetGetCardinalityHandler")] get;
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		public abstract string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")] get;
		}

		static Delegate cb_getExternalId;
#pragma warning disable 0169
		static Delegate GetGetExternalIdHandler ()
		{
			if (cb_getExternalId == null)
				cb_getExternalId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExternalId);
			return cb_getExternalId;
		}

		static IntPtr n_GetExternalId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExternalId);
		}
#pragma warning restore 0169

		public abstract string ExternalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getExternalId' and count(parameter)=0]"
			[Register ("getExternalId", "()Ljava/lang/String;", "GetGetExternalIdHandler")] get;
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public abstract string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASUser", DoNotGenerateAcw=true)]
	internal partial class MASUserInvoker : MASUser {

		public MASUserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASUserInvoker); }
		}

		static IntPtr id_getAccessToken;
		public override unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isAuthenticated;
		public override unsafe bool IsAuthenticated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='isAuthenticated' and count(parameter)=0]"
			[Register ("isAuthenticated", "()Z", "GetIsAuthenticatedHandler")]
			get {
				if (id_isAuthenticated == IntPtr.Zero)
					id_isAuthenticated = JNIEnv.GetMethodID (class_ref, "isAuthenticated", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthenticated);
				} finally {
				}
			}
		}

		static IntPtr id_isCurrentUser;
		public override unsafe bool IsCurrentUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='isCurrentUser' and count(parameter)=0]"
			[Register ("isCurrentUser", "()Z", "GetIsCurrentUserHandler")]
			get {
				if (id_isCurrentUser == IntPtr.Zero)
					id_isCurrentUser = JNIEnv.GetMethodID (class_ref, "isCurrentUser", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentUser);
				} finally {
				}
			}
		}

		static IntPtr id_isSessionLocked;
		public override unsafe bool IsSessionLocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='isSessionLocked' and count(parameter)=0]"
			[Register ("isSessionLocked", "()Z", "GetIsSessionLockedHandler")]
			get {
				if (id_isSessionLocked == IntPtr.Zero)
					id_isSessionLocked = JNIEnv.GetMethodID (class_ref, "isSessionLocked", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSessionLocked);
				} finally {
				}
			}
		}

		static IntPtr id_getThumbnailImage;
		public override unsafe global::Android.Graphics.Bitmap ThumbnailImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getThumbnailImage' and count(parameter)=0]"
			[Register ("getThumbnailImage", "()Landroid/graphics/Bitmap;", "GetGetThumbnailImageHandler")]
			get {
				if (id_getThumbnailImage == IntPtr.Zero)
					id_getThumbnailImage = JNIEnv.GetMethodID (class_ref, "getThumbnailImage", "()Landroid/graphics/Bitmap;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThumbnailImage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getUserById' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASUser&gt;']]"
		[Register ("getUserById", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void GetUserById (string p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getUserById", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getUserMetaData' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.identity.user.UserAttributes&gt;']]"
		[Register ("getUserMetaData", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetGetUserMetaData_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void GetUserMetaData (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getUserMetaData", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getUsersByFilter' and count(parameter)=2 and parameter[1][@type='com.ca.mas.identity.common.MASFilteredRequest'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASUser&gt;&gt;']]"
		[Register ("getUsersByFilter", "(Lcom/ca/mas/identity/common/MASFilteredRequest;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void GetUsersByFilter (global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getUsersByFilter", "(Lcom/ca/mas/identity/common/MASFilteredRequest;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_lockSession_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='lockSession' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("lockSession", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetLockSession_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void LockSession (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_lockSession_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_lockSession_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "lockSession", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_lockSession_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_logout_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='logout' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("logout", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetLogout_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void Logout (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_logout_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_logout_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "logout", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_removeSessionLock_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='removeSessionLock' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("removeSessionLock", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetRemoveSessionLock_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void RemoveSessionLock (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_removeSessionLock_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_removeSessionLock_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "removeSessionLock", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSessionLock_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_requestUserInfo_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='requestUserInfo' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("requestUserInfo", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetRequestUserInfo_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void RequestUserInfo (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_requestUserInfo_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_requestUserInfo_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "requestUserInfo", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestUserInfo_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASGroup'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASGroup;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASGroup p1, global::Com.CA.Mas.Foundation.MASCallback p2)
		{
			if (id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASGroup;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='sendMessage' and count(parameter)=4 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASGroup'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASGroup;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASGroup p1, string p2, global::Com.CA.Mas.Foundation.MASCallback p3)
		{
			if (id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASGroup;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASUser'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASUser;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASUser p1, global::Com.CA.Mas.Foundation.MASCallback p2)
		{
			if (id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASUser;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='sendMessage' and count(parameter)=4 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASUser'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASUser;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASUser p1, string p2, global::Com.CA.Mas.Foundation.MASCallback p3)
		{
			if (id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASUser;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.ca.mas.messaging.topic.MASTopic'] and parameter[2][@type='com.ca.mas.messaging.MASMessage'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/topic/MASTopic;Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void SendMessage (global::Com.CA.Mas.Messaging.Topic.IMASTopic p0, global::Com.CA.Mas.Messaging.MASMessage p1, global::Com.CA.Mas.Foundation.MASCallback p2)
		{
			if (id_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/ca/mas/messaging/topic/MASTopic;Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='startListeningToMyMessages' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("startListeningToMyMessages", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetStartListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void StartListeningToMyMessages (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "startListeningToMyMessages", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='stopListeningToMyMessages' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("stopListeningToMyMessages", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetStopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void StopListeningToMyMessages (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "stopListeningToMyMessages", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_unlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='unlockSession' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASSessionUnlockCallback&lt;java.lang.Void&gt;']]"
		[Register ("unlockSession", "(Lcom/ca/mas/foundation/MASSessionUnlockCallback;)V", "GetUnlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_Handler")]
		public override unsafe void UnlockSession (global::Com.CA.Mas.Foundation.MASSessionUnlockCallback p0)
		{
			if (id_unlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_ == IntPtr.Zero)
				id_unlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_ = JNIEnv.GetMethodID (class_ref, "unlockSession", "(Lcom/ca/mas/foundation/MASSessionUnlockCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unlockSession_Lcom_ca_mas_foundation_MASSessionUnlockCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_getAddressList;
		public override unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASAddress> AddressList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getAddressList' and count(parameter)=0]"
			[Register ("getAddressList", "()Ljava/util/List;", "GetGetAddressListHandler")]
			get {
				if (id_getAddressList == IntPtr.Zero)
					id_getAddressList = JNIEnv.GetMethodID (class_ref, "getAddressList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASAddress>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddressList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getEmailList;
		public override unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASEmail> EmailList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getEmailList' and count(parameter)=0]"
			[Register ("getEmailList", "()Ljava/util/List;", "GetGetEmailListHandler")]
			get {
				if (id_getEmailList == IntPtr.Zero)
					id_getEmailList = JNIEnv.GetMethodID (class_ref, "getEmailList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASEmail>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmailList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getGroupList;
		public override unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Foundation.MASGroup> GroupList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getGroupList' and count(parameter)=0]"
			[Register ("getGroupList", "()Ljava/util/List;", "GetGetGroupListHandler")]
			get {
				if (id_getGroupList == IntPtr.Zero)
					id_getGroupList = JNIEnv.GetMethodID (class_ref, "getGroupList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.CA.Mas.Foundation.MASGroup>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getImsList;
		public override unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASIms> ImsList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getImsList' and count(parameter)=0]"
			[Register ("getImsList", "()Ljava/util/List;", "GetGetImsListHandler")]
			get {
				if (id_getImsList == IntPtr.Zero)
					id_getImsList = JNIEnv.GetMethodID (class_ref, "getImsList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASIms>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImsList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isActive;
		public override unsafe bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "GetIsActiveHandler")]
			get {
				if (id_isActive == IntPtr.Zero)
					id_isActive = JNIEnv.GetMethodID (class_ref, "isActive", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isActive);
				} finally {
				}
			}
		}

		static IntPtr id_getLocale;
		public override unsafe string Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/lang/String;", "GetGetLocaleHandler")]
			get {
				if (id_getLocale == IntPtr.Zero)
					id_getLocale = JNIEnv.GetMethodID (class_ref, "getLocale", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocale), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMeta;
		public override unsafe global::Com.CA.Mas.Identity.User.MASMeta Meta {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getMeta' and count(parameter)=0]"
			[Register ("getMeta", "()Lcom/ca/mas/identity/user/MASMeta;", "GetGetMetaHandler")]
			get {
				if (id_getMeta == IntPtr.Zero)
					id_getMeta = JNIEnv.GetMethodID (class_ref, "getMeta", "()Lcom/ca/mas/identity/user/MASMeta;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASMeta> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMeta), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getName;
		public override unsafe global::Com.CA.Mas.Identity.User.MASName Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Lcom/ca/mas/identity/user/MASName;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Lcom/ca/mas/identity/user/MASName;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASName> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getNickName;
		public override unsafe string NickName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getNickName' and count(parameter)=0]"
			[Register ("getNickName", "()Ljava/lang/String;", "GetGetNickNameHandler")]
			get {
				if (id_getNickName == IntPtr.Zero)
					id_getNickName = JNIEnv.GetMethodID (class_ref, "getNickName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNickName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPassword;
		public override unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPhoneList;
		public override unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASPhone> PhoneList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getPhoneList' and count(parameter)=0]"
			[Register ("getPhoneList", "()Ljava/util/List;", "GetGetPhoneListHandler")]
			get {
				if (id_getPhoneList == IntPtr.Zero)
					id_getPhoneList = JNIEnv.GetMethodID (class_ref, "getPhoneList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASPhone>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhoneList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPhotoList;
		public override unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASPhoto> PhotoList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getPhotoList' and count(parameter)=0]"
			[Register ("getPhotoList", "()Ljava/util/List;", "GetGetPhotoListHandler")]
			get {
				if (id_getPhotoList == IntPtr.Zero)
					id_getPhotoList = JNIEnv.GetMethodID (class_ref, "getPhotoList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASPhoto>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhotoList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPreferredLanguage;
		public override unsafe string PreferredLanguage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getPreferredLanguage' and count(parameter)=0]"
			[Register ("getPreferredLanguage", "()Ljava/lang/String;", "GetGetPreferredLanguageHandler")]
			get {
				if (id_getPreferredLanguage == IntPtr.Zero)
					id_getPreferredLanguage = JNIEnv.GetMethodID (class_ref, "getPreferredLanguage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreferredLanguage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getProfileUrl;
		public override unsafe string ProfileUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getProfileUrl' and count(parameter)=0]"
			[Register ("getProfileUrl", "()Ljava/lang/String;", "GetGetProfileUrlHandler")]
			get {
				if (id_getProfileUrl == IntPtr.Zero)
					id_getProfileUrl = JNIEnv.GetMethodID (class_ref, "getProfileUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProfileUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSource;
		public override unsafe global::Org.Json.JSONObject Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Lorg/json/JSONObject;", "GetGetSourceHandler")]
			get {
				if (id_getSource == IntPtr.Zero)
					id_getSource = JNIEnv.GetMethodID (class_ref, "getSource", "()Lorg/json/JSONObject;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSource), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTimeZone;
		public override unsafe string TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()Ljava/lang/String;", "GetGetTimeZoneHandler")]
			get {
				if (id_getTimeZone == IntPtr.Zero)
					id_getTimeZone = JNIEnv.GetMethodID (class_ref, "getTimeZone", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeZone), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTitle;
		public override unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUserName;
		public override unsafe string UserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getUserName' and count(parameter)=0]"
			[Register ("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler")]
			get {
				if (id_getUserName == IntPtr.Zero)
					id_getUserName = JNIEnv.GetMethodID (class_ref, "getUserName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUserType;
		public override unsafe string UserType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getUserType' and count(parameter)=0]"
			[Register ("getUserType", "()Ljava/lang/String;", "GetGetUserTypeHandler")]
			get {
				if (id_getUserType == IntPtr.Zero)
					id_getUserType = JNIEnv.GetMethodID (class_ref, "getUserType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAsJSONObject;
		public override unsafe global::Org.Json.JSONObject AsJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getAsJSONObject' and count(parameter)=0]"
			[Register ("getAsJSONObject", "()Lorg/json/JSONObject;", "GetGetAsJSONObjectHandler")]
			get {
				if (id_getAsJSONObject == IntPtr.Zero)
					id_getAsJSONObject = JNIEnv.GetMethodID (class_ref, "getAsJSONObject", "()Lorg/json/JSONObject;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJSONObject), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_populate_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASTransformable']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("populate", "(Lorg/json/JSONObject;)V", "GetPopulate_Lorg_json_JSONObject_Handler")]
		public override unsafe void Populate (global::Org.Json.JSONObject p0)
		{
			if (id_populate_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_populate_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "populate", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_populate_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static IntPtr id_getCardinality;
		public override unsafe long Cardinality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getCardinality' and count(parameter)=0]"
			[Register ("getCardinality", "()J", "GetGetCardinalityHandler")]
			get {
				if (id_getCardinality == IntPtr.Zero)
					id_getCardinality = JNIEnv.GetMethodID (class_ref, "getCardinality", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCardinality);
				} finally {
				}
			}
		}

		static IntPtr id_getDisplayName;
		public override unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getExternalId;
		public override unsafe string ExternalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getExternalId' and count(parameter)=0]"
			[Register ("getExternalId", "()Ljava/lang/String;", "GetGetExternalIdHandler")]
			get {
				if (id_getExternalId == IntPtr.Zero)
					id_getExternalId = JNIEnv.GetMethodID (class_ref, "getExternalId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExternalId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getId;
		public override unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASUser']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
