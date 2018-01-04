using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Datasource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']"
	[global::Android.Runtime.Register ("com/ca/mas/core/datasource/KeystoreDataSource", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial class KeystoreDataSource : global::Java.Lang.Object, global::Com.CA.Mas.Core.Datasource.IDataSource {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/field[@name='SHARE']"
		[Register ("SHARE")]
		public const string Share = (string) "share";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/datasource/KeystoreDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KeystoreDataSource); }
		}

		protected KeystoreDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/constructor[@name='KeystoreDataSource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ca.mas.core.datasource.DataConverter']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/ca/mas/core/datasource/DataConverter;)V", "")]
		public unsafe KeystoreDataSource (global::Android.Content.Context context, global::Org.Json.JSONObject param, global::Com.CA.Mas.Core.Datasource.IDataConverter converter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (param);
				__args [2] = new JValue (converter);
				if (((object) this).GetType () != typeof (KeystoreDataSource)) {
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
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		static IntPtr id_isReady;
		public virtual unsafe bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='isReady' and count(parameter)=0]"
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

		static Delegate cb_get_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_Handler ()
		{
			if (cb_get_Ljava_lang_Object_ == null)
				cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_Object_);
			return cb_get_Ljava_lang_Object_;
		}

		static IntPtr n_Get_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='get' and count(parameter)=1 and parameter[1][@type='K']]"
		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (global::Java.Lang.Object key)
		{
			if (id_get_Ljava_lang_Object_ == IntPtr.Zero)
				id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_Get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback @callback = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Get (key, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='get' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("get", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetGet_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler")]
		public virtual unsafe void Get (global::Java.Lang.Object key, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback @callback)
		{
			if (id_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
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
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object filter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetKeys (filter));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getKeys_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='getKeys' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static void n_GetKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object filter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_filter, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback @callback = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetKeys (filter, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='getKeys' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("getKeys", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetGetKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler")]
		public virtual unsafe void GetKeys (global::Java.Lang.Object filter, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback @callback)
		{
			if (id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "getKeys", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (filter);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeys", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Put_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, value);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='put' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='V']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe void Put (global::Java.Lang.Object key, global::Java.Lang.Object value)
		{
			if (id_put_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_Object_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_Put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback @callback = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Put (key, value, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='put' and count(parameter)=3 and parameter[1][@type='K'] and parameter[2][@type='V'] and parameter[3][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler")]
		public virtual unsafe void Put (global::Java.Lang.Object key, global::Java.Lang.Object value, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback @callback)
		{
			if (id_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static void n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Remove (key);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='K']]"
		[Register ("remove", "(Ljava/lang/Object;)V", "GetRemove_Ljava_lang_Object_Handler")]
		public virtual unsafe void Remove (global::Java.Lang.Object key)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)V");
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_Remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback @callback = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Remove (key, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("remove", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetRemove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler")]
		public virtual unsafe void Remove (global::Java.Lang.Object key, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback @callback)
		{
			if (id_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			IntPtr native_key = JNIEnv.ToLocalJniHandle (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
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
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object filter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll (filter);
		}
#pragma warning restore 0169

		static IntPtr id_removeAll_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static void n_RemoveAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object filter = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_filter, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback @callback = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll (filter, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("removeAll", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetRemoveAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler")]
		public virtual unsafe void RemoveAll (global::Java.Lang.Object filter, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback @callback)
		{
			if (id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (filter);
				__args [1] = new JValue (@callback);

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
			global::Com.CA.Mas.Core.Datasource.KeystoreDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.KeystoreDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlock ();
		}
#pragma warning restore 0169

		static IntPtr id_unlock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='KeystoreDataSource']/method[@name='unlock' and count(parameter)=0]"
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

	}
}
