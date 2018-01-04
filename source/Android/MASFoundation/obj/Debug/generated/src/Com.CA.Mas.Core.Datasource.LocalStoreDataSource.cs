using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Datasource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']"
	[global::Android.Runtime.Register ("com/ca/mas/core/datasource/LocalStoreDataSource", DoNotGenerateAcw=true)]
	public partial class LocalStoreDataSource : global::Java.Lang.Object, global::Com.CA.Mas.Core.Datasource.IDataSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/datasource/LocalStoreDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalStoreDataSource); }
		}

		protected LocalStoreDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/constructor[@name='LocalStoreDataSource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ca.mas.core.datasource.DataConverter']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/ca/mas/core/datasource/DataConverter;)V", "")]
		public unsafe LocalStoreDataSource (global::Android.Content.Context context, global::Org.Json.JSONObject param, global::Com.CA.Mas.Core.Datasource.IDataConverter converter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (param);
				__args [2] = new JValue (converter);
				if (((object) this).GetType () != typeof (LocalStoreDataSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/ca/mas/core/datasource/DataConverter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/ca/mas/core/datasource/DataConverter;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/ca/mas/core/datasource/DataConverter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_, __args);
			} finally {
			}
		}

		static Delegate cb_isReady;
#pragma warning disable 0169
		static Delegate GetIsReadyHandler ()
		{
			if (cb_isReady == null)
				cb_isReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReady);
			return cb_isReady;
		}

		static bool n_IsReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		static IntPtr id_isReady;
		public virtual unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler")]
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReady);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReady", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_get_Lcom_ca_mas_core_datasource_LocalStoreKey_;
#pragma warning disable 0169
		static Delegate GetGet_Lcom_ca_mas_core_datasource_LocalStoreKey_Handler ()
		{
			if (cb_get_Lcom_ca_mas_core_datasource_LocalStoreKey_ == null)
				cb_get_Lcom_ca_mas_core_datasource_LocalStoreKey_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Lcom_ca_mas_core_datasource_LocalStoreKey_);
			return cb_get_Lcom_ca_mas_core_datasource_LocalStoreKey_;
		}

		static IntPtr n_Get_Lcom_ca_mas_core_datasource_LocalStoreKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.LocalStoreKey key = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreKey> (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Lcom_ca_mas_core_datasource_LocalStoreKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.datasource.LocalStoreKey']]"
		[Register ("get", "(Lcom/ca/mas/core/datasource/LocalStoreKey;)Lcom/ca/mas/core/datasource/LocalStoreEntity;", "GetGet_Lcom_ca_mas_core_datasource_LocalStoreKey_Handler")]
		public virtual unsafe global::Com.CA.Mas.Core.Datasource.LocalStoreEntity Get (global::Com.CA.Mas.Core.Datasource.LocalStoreKey key)
		{
			if (id_get_Lcom_ca_mas_core_datasource_LocalStoreKey_ == IntPtr.Zero)
				id_get_Lcom_ca_mas_core_datasource_LocalStoreKey_ = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/ca/mas/core/datasource/LocalStoreKey;)Lcom/ca/mas/core/datasource/LocalStoreEntity;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (key);

				global::Com.CA.Mas.Core.Datasource.LocalStoreEntity __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreEntity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Lcom_ca_mas_core_datasource_LocalStoreKey_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreEntity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Lcom/ca/mas/core/datasource/LocalStoreKey;)Lcom/ca/mas/core/datasource/LocalStoreEntity;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_get_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetGet_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_get_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_get_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_get_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_Get_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_dataSourceCallback)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.LocalStoreKey s = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreKey> (native_s, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback dataSourceCallback = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native_dataSourceCallback, JniHandleOwnership.DoNotTransfer);
			__this.Get (s, dataSourceCallback);
		}
#pragma warning restore 0169

		static IntPtr id_get_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='get' and count(parameter)=2 and parameter[1][@type='com.ca.mas.core.datasource.LocalStoreKey'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("get", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetGet_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler")]
		public virtual unsafe void Get (global::Com.CA.Mas.Core.Datasource.LocalStoreKey s, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback dataSourceCallback)
		{
			if (id_get_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_get_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (s);
				__args [1] = new JValue (dataSourceCallback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_get_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/DataSourceCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getKeys_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetKeys_Ljava_lang_Object_Handler ()
		{
			if (cb_getKeys_Ljava_lang_Object_ == null)
				cb_getKeys_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeys_Ljava_lang_Object_);
			return cb_getKeys_Ljava_lang_Object_;
		}

		static IntPtr n_GetKeys_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object filter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetKeys (filter));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getKeys_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='getKeys' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getKeys", "(Ljava/lang/Object;)Ljava/util/List;", "GetGetKeys_Ljava_lang_Object_Handler")]
		public virtual unsafe global::System.Collections.IList GetKeys (global::Java.Lang.Object filter)
		{
			if (id_getKeys_Ljava_lang_Object_ == IntPtr.Zero)
				id_getKeys_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getKeys", "(Ljava/lang/Object;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (filter);

				global::System.Collections.IList __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeys_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeys", "(Ljava/lang/Object;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetGetKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_GetKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter, IntPtr native_dataSourceCallback)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object filter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_filter, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback dataSourceCallback = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native_dataSourceCallback, JniHandleOwnership.DoNotTransfer);
			__this.GetKeys (filter, dataSourceCallback);
		}
#pragma warning restore 0169

		static IntPtr id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='getKeys' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("getKeys", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetGetKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler")]
		public virtual unsafe void GetKeys (global::Java.Lang.Object filter, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback dataSourceCallback)
		{
			if (id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "getKeys", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (filter);
				__args [1] = new JValue (dataSourceCallback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeys", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_;
#pragma warning disable 0169
		static Delegate GetPut_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Handler ()
		{
			if (cb_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_ == null)
				cb_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_);
			return cb_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_;
		}

		static void n_Put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_localStoreItem)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.LocalStoreKey key = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreKey> (native_key, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.LocalStoreEntity localStoreItem = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreEntity> (native_localStoreItem, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, localStoreItem);
		}
#pragma warning restore 0169

		static IntPtr id_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='put' and count(parameter)=2 and parameter[1][@type='com.ca.mas.core.datasource.LocalStoreKey'] and parameter[2][@type='com.ca.mas.core.datasource.LocalStoreEntity']]"
		[Register ("put", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/LocalStoreEntity;)V", "GetPut_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Handler")]
		public virtual unsafe void Put (global::Com.CA.Mas.Core.Datasource.LocalStoreKey key, global::Com.CA.Mas.Core.Datasource.LocalStoreEntity localStoreItem)
		{
			if (id_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_ == IntPtr.Zero)
				id_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_ = JNIEnv.GetMethodID (class_ref, "put", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/LocalStoreEntity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (key);
				__args [1] = new JValue (localStoreItem);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/LocalStoreEntity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetPut_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_Put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_localStoreItem, IntPtr native_dataSourceCallback)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.LocalStoreKey key = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreKey> (native_key, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.LocalStoreEntity localStoreItem = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreEntity> (native_localStoreItem, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback dataSourceCallback = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native_dataSourceCallback, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, localStoreItem, dataSourceCallback);
		}
#pragma warning restore 0169

		static IntPtr id_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='put' and count(parameter)=3 and parameter[1][@type='com.ca.mas.core.datasource.LocalStoreKey'] and parameter[2][@type='com.ca.mas.core.datasource.LocalStoreEntity'] and parameter[3][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("put", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/LocalStoreEntity;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetPut_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler")]
		public virtual unsafe void Put (global::Com.CA.Mas.Core.Datasource.LocalStoreKey key, global::Com.CA.Mas.Core.Datasource.LocalStoreEntity localStoreItem, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback dataSourceCallback)
		{
			if (id_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "put", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/LocalStoreEntity;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (key);
				__args [1] = new JValue (localStoreItem);
				__args [2] = new JValue (dataSourceCallback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_LocalStoreEntity_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/LocalStoreEntity;Lcom/ca/mas/core/datasource/DataSourceCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_;
#pragma warning disable 0169
		static Delegate GetRemove_Lcom_ca_mas_core_datasource_LocalStoreKey_Handler ()
		{
			if (cb_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_ == null)
				cb_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Lcom_ca_mas_core_datasource_LocalStoreKey_);
			return cb_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_;
		}

		static void n_Remove_Lcom_ca_mas_core_datasource_LocalStoreKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.LocalStoreKey key = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreKey> (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Remove (key);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.datasource.LocalStoreKey']]"
		[Register ("remove", "(Lcom/ca/mas/core/datasource/LocalStoreKey;)V", "GetRemove_Lcom_ca_mas_core_datasource_LocalStoreKey_Handler")]
		public virtual unsafe void Remove (global::Com.CA.Mas.Core.Datasource.LocalStoreKey key)
		{
			if (id_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_ == IntPtr.Zero)
				id_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/ca/mas/core/datasource/LocalStoreKey;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (key);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Lcom/ca/mas/core/datasource/LocalStoreKey;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetRemove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_Remove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_dataSourceCallback)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.LocalStoreKey s = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreKey> (native_s, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback dataSourceCallback = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native_dataSourceCallback, JniHandleOwnership.DoNotTransfer);
			__this.Remove (s, dataSourceCallback);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='com.ca.mas.core.datasource.LocalStoreKey'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("remove", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetRemove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler")]
		public virtual unsafe void Remove (global::Com.CA.Mas.Core.Datasource.LocalStoreKey s, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback dataSourceCallback)
		{
			if (id_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (s);
				__args [1] = new JValue (dataSourceCallback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lcom_ca_mas_core_datasource_LocalStoreKey_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Lcom/ca/mas/core/datasource/LocalStoreKey;Lcom/ca/mas/core/datasource/DataSourceCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeAll_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_Ljava_lang_Object_Handler ()
		{
			if (cb_removeAll_Ljava_lang_Object_ == null)
				cb_removeAll_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveAll_Ljava_lang_Object_);
			return cb_removeAll_Ljava_lang_Object_;
		}

		static void n_RemoveAll_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object filter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll (filter);
		}
#pragma warning restore 0169

		static IntPtr id_removeAll_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeAll", "(Ljava/lang/Object;)V", "GetRemoveAll_Ljava_lang_Object_Handler")]
		public virtual unsafe void RemoveAll (global::Java.Lang.Object filter)
		{
			if (id_removeAll_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (filter);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAll_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_RemoveAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter, IntPtr native_dataSourceCallback)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object filter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_filter, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback dataSourceCallback = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native_dataSourceCallback, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll (filter, dataSourceCallback);
		}
#pragma warning restore 0169

		static IntPtr id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("removeAll", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetRemoveAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler")]
		public virtual unsafe void RemoveAll (global::Java.Lang.Object filter, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback dataSourceCallback)
		{
			if (id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (filter);
				__args [1] = new JValue (dataSourceCallback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unlock;
#pragma warning disable 0169
		static Delegate GetUnlockHandler ()
		{
			if (cb_unlock == null)
				cb_unlock = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unlock);
			return cb_unlock;
		}

		static void n_Unlock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.LocalStoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlock ();
		}
#pragma warning restore 0169

		static IntPtr id_unlock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='LocalStoreDataSource']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "GetUnlockHandler")]
		public virtual unsafe void Unlock ()
		{
			if (id_unlock == IntPtr.Zero)
				id_unlock = JNIEnv.GetMethodID (class_ref, "unlock", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unlock);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unlock", "()V"));
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.CA.Mas.Core.Datasource.IDataSource
		global::Java.Lang.Object global::Com.CA.Mas.Core.Datasource.IDataSource.Get (global::Java.Lang.Object p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Get (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.CA.Mas.Core.Datasource.LocalStoreKey>(p0)));
		}

		// This method is explicitly implemented as a member of an instantiated Com.CA.Mas.Core.Datasource.IDataSource
		void global::Com.CA.Mas.Core.Datasource.IDataSource.Get (global::Java.Lang.Object p0, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1)
		{
			Get (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.CA.Mas.Core.Datasource.LocalStoreKey>(p0), p1);
		}

		// This method is explicitly implemented as a member of an instantiated Com.CA.Mas.Core.Datasource.IDataSource
		void global::Com.CA.Mas.Core.Datasource.IDataSource.Put (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			Put (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.CA.Mas.Core.Datasource.LocalStoreKey>(p0), global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.CA.Mas.Core.Datasource.LocalStoreEntity>(p1));
		}

		// This method is explicitly implemented as a member of an instantiated Com.CA.Mas.Core.Datasource.IDataSource
		void global::Com.CA.Mas.Core.Datasource.IDataSource.Put (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p2)
		{
			Put (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.CA.Mas.Core.Datasource.LocalStoreKey>(p0), global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.CA.Mas.Core.Datasource.LocalStoreEntity>(p1), p2);
		}

		// This method is explicitly implemented as a member of an instantiated Com.CA.Mas.Core.Datasource.IDataSource
		void global::Com.CA.Mas.Core.Datasource.IDataSource.Remove (global::Java.Lang.Object p0)
		{
			Remove (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.CA.Mas.Core.Datasource.LocalStoreKey>(p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.CA.Mas.Core.Datasource.IDataSource
		void global::Com.CA.Mas.Core.Datasource.IDataSource.Remove (global::Java.Lang.Object p0, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1)
		{
			Remove (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.CA.Mas.Core.Datasource.LocalStoreKey>(p0), p1);
		}

	}
}
