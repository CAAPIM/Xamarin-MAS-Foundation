using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Store {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage']"
	[global::Android.Runtime.Register ("com/ca/mas/core/store/PrivateTokenStorage", DoNotGenerateAcw=true)]
	public partial class PrivateTokenStorage : global::Java.Lang.Object, global::Com.CA.Mas.Core.Store.IOAuthTokenContainer {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage.KEY']"
		[global::Android.Runtime.Register ("com/ca/mas/core/store/PrivateTokenStorage$KEY", DoNotGenerateAcw=true)]
		public sealed partial class KEY : global::Java.Lang.Enum {


			static IntPtr PREF_ACCESS_TOKEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage.KEY']/field[@name='PREF_ACCESS_TOKEN']"
			[Register ("PREF_ACCESS_TOKEN")]
			public static global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY PrefAccessToken {
				get {
					if (PREF_ACCESS_TOKEN_jfieldId == IntPtr.Zero)
						PREF_ACCESS_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREF_ACCESS_TOKEN", "Lcom/ca/mas/core/store/PrivateTokenStorage$KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREF_ACCESS_TOKEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREF_EXPIRY_UNIXTIME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage.KEY']/field[@name='PREF_EXPIRY_UNIXTIME']"
			[Register ("PREF_EXPIRY_UNIXTIME")]
			public static global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY PrefExpiryUnixtime {
				get {
					if (PREF_EXPIRY_UNIXTIME_jfieldId == IntPtr.Zero)
						PREF_EXPIRY_UNIXTIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREF_EXPIRY_UNIXTIME", "Lcom/ca/mas/core/store/PrivateTokenStorage$KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREF_EXPIRY_UNIXTIME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREF_GRANTED_SCOPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage.KEY']/field[@name='PREF_GRANTED_SCOPE']"
			[Register ("PREF_GRANTED_SCOPE")]
			public static global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY PrefGrantedScope {
				get {
					if (PREF_GRANTED_SCOPE_jfieldId == IntPtr.Zero)
						PREF_GRANTED_SCOPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREF_GRANTED_SCOPE", "Lcom/ca/mas/core/store/PrivateTokenStorage$KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREF_GRANTED_SCOPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREF_ID_TOKEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage.KEY']/field[@name='PREF_ID_TOKEN']"
			[Register ("PREF_ID_TOKEN")]
			public static global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY PrefIdToken {
				get {
					if (PREF_ID_TOKEN_jfieldId == IntPtr.Zero)
						PREF_ID_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREF_ID_TOKEN", "Lcom/ca/mas/core/store/PrivateTokenStorage$KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREF_ID_TOKEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREF_ID_TOKEN_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage.KEY']/field[@name='PREF_ID_TOKEN_TYPE']"
			[Register ("PREF_ID_TOKEN_TYPE")]
			public static global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY PrefIdTokenType {
				get {
					if (PREF_ID_TOKEN_TYPE_jfieldId == IntPtr.Zero)
						PREF_ID_TOKEN_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREF_ID_TOKEN_TYPE", "Lcom/ca/mas/core/store/PrivateTokenStorage$KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREF_ID_TOKEN_TYPE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREF_REFRESH_TOKEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage.KEY']/field[@name='PREF_REFRESH_TOKEN']"
			[Register ("PREF_REFRESH_TOKEN")]
			public static global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY PrefRefreshToken {
				get {
					if (PREF_REFRESH_TOKEN_jfieldId == IntPtr.Zero)
						PREF_REFRESH_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREF_REFRESH_TOKEN", "Lcom/ca/mas/core/store/PrivateTokenStorage$KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREF_REFRESH_TOKEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/core/store/PrivateTokenStorage$KEY", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KEY); }
			}

			internal KEY (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage.KEY']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/store/PrivateTokenStorage$KEY;", "")]
			public static unsafe global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/store/PrivateTokenStorage$KEY;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage.KEY']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ca/mas/core/store/PrivateTokenStorage$KEY;", "")]
			public static unsafe global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/core/store/PrivateTokenStorage$KEY;");
				try {
					return (global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Core.Store.PrivateTokenStorage.KEY));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/store/PrivateTokenStorage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PrivateTokenStorage); }
		}

		protected PrivateTokenStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_datasource_DataSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage']/constructor[@name='PrivateTokenStorage' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.datasource.DataSource']]"
		[Register (".ctor", "(Lcom/ca/mas/core/datasource/DataSource;)V", "")]
		public unsafe PrivateTokenStorage (global::Com.CA.Mas.Core.Datasource.IDataSource storage)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (storage);
				if (((object) this).GetType () != typeof (PrivateTokenStorage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/core/datasource/DataSource;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/core/datasource/DataSource;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_core_datasource_DataSource_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_core_datasource_DataSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/core/datasource/DataSource;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_core_datasource_DataSource_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_core_datasource_DataSource_, __args);
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
			global::Com.CA.Mas.Core.Store.PrivateTokenStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static IntPtr id_getAccessToken;
		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage']/method[@name='getAccessToken' and count(parameter)=0]"
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
			global::Com.CA.Mas.Core.Store.PrivateTokenStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Expiry;
		}
#pragma warning restore 0169

		static IntPtr id_getExpiry;
		public virtual unsafe long Expiry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage']/method[@name='getExpiry' and count(parameter)=0]"
			[Register ("getExpiry", "()J", "GetGetExpiryHandler")]
			get {
				if (id_getExpiry == IntPtr.Zero)
					id_getExpiry = JNIEnv.GetMethodID (class_ref, "getExpiry", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getExpiry);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpiry", "()J"));
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
			global::Com.CA.Mas.Core.Store.PrivateTokenStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GrantedScope);
		}
#pragma warning restore 0169

		static IntPtr id_getGrantedScope;
		public virtual unsafe string GrantedScope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage']/method[@name='getGrantedScope' and count(parameter)=0]"
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
			global::Com.CA.Mas.Core.Store.PrivateTokenStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RefreshToken);
		}
#pragma warning restore 0169

		static IntPtr id_getRefreshToken;
		public virtual unsafe string RefreshToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage']/method[@name='getRefreshToken' and count(parameter)=0]"
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
			global::Com.CA.Mas.Core.Store.PrivateTokenStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
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
			global::Com.CA.Mas.Core.Store.PrivateTokenStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAll ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "GetClearAllHandler")]
		public virtual unsafe void ClearAll ()
		{
			if (id_clearAll == IntPtr.Zero)
				id_clearAll = JNIEnv.GetMethodID (class_ref, "clearAll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAll", "()V"));
			} finally {
			}
		}

		static Delegate cb_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Handler ()
		{
			if (cb_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ == null)
				cb_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_SaveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_);
			return cb_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
		}

		static void n_SaveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessToken, IntPtr native_refreshToken, long expiresInSec, IntPtr native_grantedScope)
		{
			global::Com.CA.Mas.Core.Store.PrivateTokenStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string accessToken = JNIEnv.GetString (native_accessToken, JniHandleOwnership.DoNotTransfer);
			string refreshToken = JNIEnv.GetString (native_refreshToken, JniHandleOwnership.DoNotTransfer);
			string grantedScope = JNIEnv.GetString (native_grantedScope, JniHandleOwnership.DoNotTransfer);
			__this.SaveAccessToken (accessToken, refreshToken, expiresInSec, grantedScope);
		}
#pragma warning restore 0169

		static IntPtr id_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage']/method[@name='saveAccessToken' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("saveAccessToken", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V", "GetSaveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Handler")]
		public virtual unsafe void SaveAccessToken (string accessToken, string refreshToken, long expiresInSec, string grantedScope)
		{
			if (id_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ == IntPtr.Zero)
				id_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveAccessToken", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V");
			IntPtr native_accessToken = JNIEnv.NewString (accessToken);
			IntPtr native_refreshToken = JNIEnv.NewString (refreshToken);
			IntPtr native_grantedScope = JNIEnv.NewString (grantedScope);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_accessToken);
				__args [1] = new JValue (native_refreshToken);
				__args [2] = new JValue (expiresInSec);
				__args [3] = new JValue (native_grantedScope);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveAccessToken_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveAccessToken", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accessToken);
				JNIEnv.DeleteLocalRef (native_refreshToken);
				JNIEnv.DeleteLocalRef (native_grantedScope);
			}
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
			global::Com.CA.Mas.Core.Store.PrivateTokenStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.PrivateTokenStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TakeRefreshToken ());
		}
#pragma warning restore 0169

		static IntPtr id_takeRefreshToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='PrivateTokenStorage']/method[@name='takeRefreshToken' and count(parameter)=0]"
		[Register ("takeRefreshToken", "()Ljava/lang/String;", "GetTakeRefreshTokenHandler")]
		public virtual unsafe string TakeRefreshToken ()
		{
			if (id_takeRefreshToken == IntPtr.Zero)
				id_takeRefreshToken = JNIEnv.GetMethodID (class_ref, "takeRefreshToken", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_takeRefreshToken), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "takeRefreshToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
