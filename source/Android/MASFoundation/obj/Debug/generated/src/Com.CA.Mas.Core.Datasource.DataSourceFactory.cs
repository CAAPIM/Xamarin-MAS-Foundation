using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Datasource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='DataSourceFactory']"
	[global::Android.Runtime.Register ("com/ca/mas/core/datasource/DataSourceFactory", DoNotGenerateAcw=true)]
	public partial class DataSourceFactory : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/datasource/DataSourceFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataSourceFactory); }
		}

		protected DataSourceFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='DataSourceFactory']/constructor[@name='DataSourceFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataSourceFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DataSourceFactory)) {
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

		static IntPtr id_getStorage_Landroid_content_Context_Ljava_lang_Class_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='DataSourceFactory']/method[@name='getStorage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class&lt;? extends com.ca.mas.core.datasource.DataSource&gt;'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("getStorage", "(Landroid/content/Context;Ljava/lang/Class;Lorg/json/JSONObject;)Lcom/ca/mas/core/datasource/DataSource;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe global::Com.CA.Mas.Core.Datasource.IDataSource GetStorage (global::Android.Content.Context context, global::Java.Lang.Class c, global::Org.Json.JSONObject param)
		{
			if (id_getStorage_Landroid_content_Context_Ljava_lang_Class_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_getStorage_Landroid_content_Context_Ljava_lang_Class_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "getStorage", "(Landroid/content/Context;Ljava/lang/Class;Lorg/json/JSONObject;)Lcom/ca/mas/core/datasource/DataSource;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (c);
				__args [2] = new JValue (param);
				global::Com.CA.Mas.Core.Datasource.IDataSource __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStorage_Landroid_content_Context_Ljava_lang_Class_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getStorage_Landroid_content_Context_Ljava_lang_Class_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='DataSourceFactory']/method[@name='getStorage' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class&lt;? extends com.ca.mas.core.datasource.DataSource&gt;'] and parameter[3][@type='org.json.JSONObject'] and parameter[4][@type='com.ca.mas.core.datasource.DataConverter']]"
		[Register ("getStorage", "(Landroid/content/Context;Ljava/lang/Class;Lorg/json/JSONObject;Lcom/ca/mas/core/datasource/DataConverter;)Lcom/ca/mas/core/datasource/DataSource;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe global::Com.CA.Mas.Core.Datasource.IDataSource GetStorage (global::Android.Content.Context context, global::Java.Lang.Class c, global::Org.Json.JSONObject param, global::Com.CA.Mas.Core.Datasource.IDataConverter converter)
		{
			if (id_getStorage_Landroid_content_Context_Ljava_lang_Class_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_ == IntPtr.Zero)
				id_getStorage_Landroid_content_Context_Ljava_lang_Class_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_ = JNIEnv.GetStaticMethodID (class_ref, "getStorage", "(Landroid/content/Context;Ljava/lang/Class;Lorg/json/JSONObject;Lcom/ca/mas/core/datasource/DataConverter;)Lcom/ca/mas/core/datasource/DataSource;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (context);
				__args [1] = new JValue (c);
				__args [2] = new JValue (param);
				__args [3] = new JValue (converter);
				global::Com.CA.Mas.Core.Datasource.IDataSource __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStorage_Landroid_content_Context_Ljava_lang_Class_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
