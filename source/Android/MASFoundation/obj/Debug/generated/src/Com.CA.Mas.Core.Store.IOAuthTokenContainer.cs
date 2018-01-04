using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Store {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='OAuthTokenContainer']"
	[Register ("com/ca/mas/core/store/OAuthTokenContainer", "", "Com.CA.Mas.Core.Store.IOAuthTokenContainerInvoker")]
	public partial interface IOAuthTokenContainer : IJavaObject {

		string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='OAuthTokenContainer']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler:Com.CA.Mas.Core.Store.IOAuthTokenContainerInvoker, MASFoundation")] get;
		}

		long Expiry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='OAuthTokenContainer']/method[@name='getExpiry' and count(parameter)=0]"
			[Register ("getExpiry", "()J", "GetGetExpiryHandler:Com.CA.Mas.Core.Store.IOAuthTokenContainerInvoker, MASFoundation")] get;
		}

		string GrantedScope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='OAuthTokenContainer']/method[@name='getGrantedScope' and count(parameter)=0]"
			[Register ("getGrantedScope", "()Ljava/lang/String;", "GetGetGrantedScopeHandler:Com.CA.Mas.Core.Store.IOAuthTokenContainerInvoker, MASFoundation")] get;
		}

		string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='OAuthTokenContainer']/method[@name='getRefreshToken' and count(parameter)=0]"
			[Register ("getRefreshToken", "()Ljava/lang/String;", "GetGetRefreshTokenHandler:Com.CA.Mas.Core.Store.IOAuthTokenContainerInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='OAuthTokenContainer']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.CA.Mas.Core.Store.IOAuthTokenContainerInvoker, MASFoundation")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='OAuthTokenContainer']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler:Com.CA.Mas.Core.Store.IOAuthTokenContainerInvoker, MASFoundation")]
		void ClearAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='OAuthTokenContainer']/method[@name='saveAccessToken' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("saveAccessToken", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V", "GetSaveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Handler:Com.CA.Mas.Core.Store.IOAuthTokenContainerInvoker, MASFoundation")]
		void SaveAccessToken (string p0, string p1, long p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='OAuthTokenContainer']/method[@name='takeRefreshToken' and count(parameter)=0]"
		[Register ("takeRefreshToken", "()Ljava/lang/String;", "GetTakeRefreshTokenHandler:Com.CA.Mas.Core.Store.IOAuthTokenContainerInvoker, MASFoundation")]
		string TakeRefreshToken ();

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/store/OAuthTokenContainer", DoNotGenerateAcw=true)]
	internal class IOAuthTokenContainerInvoker : global::Java.Lang.Object, IOAuthTokenContainer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/store/OAuthTokenContainer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOAuthTokenContainerInvoker); }
		}

		IntPtr class_ref;

		public static IOAuthTokenContainer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOAuthTokenContainer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.store.OAuthTokenContainer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOAuthTokenContainerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.CA.Mas.Core.Store.IOAuthTokenContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IOAuthTokenContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		IntPtr id_getAccessToken;
		public unsafe string AccessToken {
			get {
				if (id_getAccessToken == IntPtr.Zero)
					id_getAccessToken = JNIEnv.GetMethodID (class_ref, "getAccessToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getExpiry;
#pragma warning disable 0169
		static Delegate GetGetExpiryHandler ()
		{
			if (cb_getExpiry == null)
				cb_getExpiry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpiry);
			return cb_getExpiry;
		}

		static long n_GetExpiry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.IOAuthTokenContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IOAuthTokenContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Expiry;
		}
#pragma warning restore 0169

		IntPtr id_getExpiry;
		public unsafe long Expiry {
			get {
				if (id_getExpiry == IntPtr.Zero)
					id_getExpiry = JNIEnv.GetMethodID (class_ref, "getExpiry", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getExpiry);
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
			global::Com.CA.Mas.Core.Store.IOAuthTokenContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IOAuthTokenContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GrantedScope);
		}
#pragma warning restore 0169

		IntPtr id_getGrantedScope;
		public unsafe string GrantedScope {
			get {
				if (id_getGrantedScope == IntPtr.Zero)
					id_getGrantedScope = JNIEnv.GetMethodID (class_ref, "getGrantedScope", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGrantedScope), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Store.IOAuthTokenContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IOAuthTokenContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		IntPtr id_getRefreshToken;
		public unsafe string RefreshToken {
			get {
				if (id_getRefreshToken == IntPtr.Zero)
					id_getRefreshToken = JNIEnv.GetMethodID (class_ref, "getRefreshToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRefreshToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.IOAuthTokenContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IOAuthTokenContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_clearAll;
#pragma warning disable 0169
		static Delegate GetClearAllHandler ()
		{
			if (cb_clearAll == null)
				cb_clearAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAll);
			return cb_clearAll;
		}

		static void n_ClearAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.IOAuthTokenContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IOAuthTokenContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAll ();
		}
#pragma warning restore 0169

		IntPtr id_clearAll;
		public unsafe void ClearAll ()
		{
			if (id_clearAll == IntPtr.Zero)
				id_clearAll = JNIEnv.GetMethodID (class_ref, "clearAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAll);
		}

		static Delegate cb_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Handler ()
		{
			if (cb_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ == null)
				cb_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_SaveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_);
			return cb_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
		}

		static void n_SaveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, IntPtr native_p3)
		{
			global::Com.CA.Mas.Core.Store.IOAuthTokenContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IOAuthTokenContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SaveAccessToken (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
		public unsafe void SaveAccessToken (string p0, string p1, long p2, string p3)
		{
			if (id_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ == IntPtr.Zero)
				id_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveAccessToken", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_takeRefreshToken;
#pragma warning disable 0169
		static Delegate GetTakeRefreshTokenHandler ()
		{
			if (cb_takeRefreshToken == null)
				cb_takeRefreshToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TakeRefreshToken);
			return cb_takeRefreshToken;
		}

		static IntPtr n_TakeRefreshToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.IOAuthTokenContainer __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IOAuthTokenContainer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TakeRefreshToken ());
		}
#pragma warning restore 0169

		IntPtr id_takeRefreshToken;
		public unsafe string TakeRefreshToken ()
		{
			if (id_takeRefreshToken == IntPtr.Zero)
				id_takeRefreshToken = JNIEnv.GetMethodID (class_ref, "takeRefreshToken", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeRefreshToken), JniHandleOwnership.TransferLocalRef);
		}

	}

}
