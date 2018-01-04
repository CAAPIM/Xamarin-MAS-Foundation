using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Store {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage']"
	[global::Android.Runtime.Register ("com/ca/mas/core/store/ClientCredentialStorage", DoNotGenerateAcw=true)]
	public partial class ClientCredentialStorage : global::Java.Lang.Object, global::Com.CA.Mas.Core.Store.IClientCredentialContainer {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage.KEY']"
		[global::Android.Runtime.Register ("com/ca/mas/core/store/ClientCredentialStorage$KEY", DoNotGenerateAcw=true)]
		public sealed partial class KEY : global::Java.Lang.Enum {


			static IntPtr PREF_CLIENT_EXPIRE_TIME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage.KEY']/field[@name='PREF_CLIENT_EXPIRE_TIME']"
			[Register ("PREF_CLIENT_EXPIRE_TIME")]
			public static global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY PrefClientExpireTime {
				get {
					if (PREF_CLIENT_EXPIRE_TIME_jfieldId == IntPtr.Zero)
						PREF_CLIENT_EXPIRE_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREF_CLIENT_EXPIRE_TIME", "Lcom/ca/mas/core/store/ClientCredentialStorage$KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREF_CLIENT_EXPIRE_TIME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREF_CLIENT_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage.KEY']/field[@name='PREF_CLIENT_ID']"
			[Register ("PREF_CLIENT_ID")]
			public static global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY PrefClientId {
				get {
					if (PREF_CLIENT_ID_jfieldId == IntPtr.Zero)
						PREF_CLIENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREF_CLIENT_ID", "Lcom/ca/mas/core/store/ClientCredentialStorage$KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREF_CLIENT_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREF_CLIENT_SECRET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage.KEY']/field[@name='PREF_CLIENT_SECRET']"
			[Register ("PREF_CLIENT_SECRET")]
			public static global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY PrefClientSecret {
				get {
					if (PREF_CLIENT_SECRET_jfieldId == IntPtr.Zero)
						PREF_CLIENT_SECRET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREF_CLIENT_SECRET", "Lcom/ca/mas/core/store/ClientCredentialStorage$KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREF_CLIENT_SECRET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREF_MASTER_CLIENT_ID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage.KEY']/field[@name='PREF_MASTER_CLIENT_ID']"
			[Register ("PREF_MASTER_CLIENT_ID")]
			public static global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY PrefMasterClientId {
				get {
					if (PREF_MASTER_CLIENT_ID_jfieldId == IntPtr.Zero)
						PREF_MASTER_CLIENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREF_MASTER_CLIENT_ID", "Lcom/ca/mas/core/store/ClientCredentialStorage$KEY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREF_MASTER_CLIENT_ID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/core/store/ClientCredentialStorage$KEY", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage.KEY']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Java.Lang.Enum __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage.KEY']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ca/mas/core/store/ClientCredentialStorage$KEY;", "")]
			public static unsafe global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/core/store/ClientCredentialStorage$KEY;");
				try {
					return (global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Core.Store.ClientCredentialStorage.KEY));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/store/ClientCredentialStorage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientCredentialStorage); }
		}

		protected ClientCredentialStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_datasource_DataSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage']/constructor[@name='ClientCredentialStorage' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.datasource.DataSource']]"
		[Register (".ctor", "(Lcom/ca/mas/core/datasource/DataSource;)V", "")]
		public unsafe ClientCredentialStorage (global::Com.CA.Mas.Core.Datasource.IDataSource storage)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (storage);
				if (((object) this).GetType () != typeof (ClientCredentialStorage)) {
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

		static Delegate cb_getClientExpiration;
#pragma warning disable 0169
		static Delegate GetGetClientExpirationHandler ()
		{
			if (cb_getClientExpiration == null)
				cb_getClientExpiration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientExpiration);
			return cb_getClientExpiration;
		}

		static IntPtr n_GetClientExpiration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ClientCredentialStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientExpiration);
		}
#pragma warning restore 0169

		static IntPtr id_getClientExpiration;
		public virtual unsafe global::Java.Lang.Long ClientExpiration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage']/method[@name='getClientExpiration' and count(parameter)=0]"
			[Register ("getClientExpiration", "()Ljava/lang/Long;", "GetGetClientExpirationHandler")]
			get {
				if (id_getClientExpiration == IntPtr.Zero)
					id_getClientExpiration = JNIEnv.GetMethodID (class_ref, "getClientExpiration", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientExpiration), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientExpiration", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ClientCredentialStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientSecret;
#pragma warning disable 0169
		static Delegate GetGetClientSecretHandler ()
		{
			if (cb_getClientSecret == null)
				cb_getClientSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientSecret);
			return cb_getClientSecret;
		}

		static IntPtr n_GetClientSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ClientCredentialStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientSecret);
		}
#pragma warning restore 0169

		static IntPtr id_getClientSecret;
		public virtual unsafe string ClientSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage']/method[@name='getClientSecret' and count(parameter)=0]"
			[Register ("getClientSecret", "()Ljava/lang/String;", "GetGetClientSecretHandler")]
			get {
				if (id_getClientSecret == IntPtr.Zero)
					id_getClientSecret = JNIEnv.GetMethodID (class_ref, "getClientSecret", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientSecret), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMasterClientId;
#pragma warning disable 0169
		static Delegate GetGetMasterClientIdHandler ()
		{
			if (cb_getMasterClientId == null)
				cb_getMasterClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMasterClientId);
			return cb_getMasterClientId;
		}

		static IntPtr n_GetMasterClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ClientCredentialStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MasterClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getMasterClientId;
		public virtual unsafe string MasterClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage']/method[@name='getMasterClientId' and count(parameter)=0]"
			[Register ("getMasterClientId", "()Ljava/lang/String;", "GetGetMasterClientIdHandler")]
			get {
				if (id_getMasterClientId == IntPtr.Zero)
					id_getMasterClientId = JNIEnv.GetMethodID (class_ref, "getMasterClientId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMasterClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMasterClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Core.Store.ClientCredentialStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage']/method[@name='clear' and count(parameter)=0]"
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
			global::Com.CA.Mas.Core.Store.ClientCredentialStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAll ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage']/method[@name='clearAll' and count(parameter)=0]"
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

		static Delegate cb_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_;
#pragma warning disable 0169
		static Delegate GetSaveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_Handler ()
		{
			if (cb_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ == null)
				cb_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_);
			return cb_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_;
		}

		static void n_SaveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientCredentials)
		{
			global::Com.CA.Mas.Core.Store.ClientCredentialStorage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ClientCredentialStorage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Token.ClientCredentials clientCredentials = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.ClientCredentials> (native_clientCredentials, JniHandleOwnership.DoNotTransfer);
			__this.SaveClientCredentials (clientCredentials);
		}
#pragma warning restore 0169

		static IntPtr id_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='ClientCredentialStorage']/method[@name='saveClientCredentials' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.token.ClientCredentials']]"
		[Register ("saveClientCredentials", "(Lcom/ca/mas/core/token/ClientCredentials;)V", "GetSaveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_Handler")]
		public virtual unsafe void SaveClientCredentials (global::Com.CA.Mas.Core.Token.ClientCredentials clientCredentials)
		{
			if (id_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ == IntPtr.Zero)
				id_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_ = JNIEnv.GetMethodID (class_ref, "saveClientCredentials", "(Lcom/ca/mas/core/token/ClientCredentials;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clientCredentials);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveClientCredentials_Lcom_ca_mas_core_token_ClientCredentials_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveClientCredentials", "(Lcom/ca/mas/core/token/ClientCredentials;)V"), __args);
			} finally {
			}
		}

	}
}
