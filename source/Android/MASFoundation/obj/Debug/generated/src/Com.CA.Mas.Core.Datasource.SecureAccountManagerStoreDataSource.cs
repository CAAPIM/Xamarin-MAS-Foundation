using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Datasource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='SecureAccountManagerStoreDataSource']"
	[global::Android.Runtime.Register ("com/ca/mas/core/datasource/SecureAccountManagerStoreDataSource", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
	public partial class SecureAccountManagerStoreDataSource : global::Com.CA.Mas.Core.Datasource.AccountManagerStoreDataSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/datasource/SecureAccountManagerStoreDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SecureAccountManagerStoreDataSource); }
		}

		protected SecureAccountManagerStoreDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_json_JSONObject_Lcom_ca_mas_core_datasource_DataConverter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.datasource']/class[@name='SecureAccountManagerStoreDataSource']/constructor[@name='SecureAccountManagerStoreDataSource' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.ca.mas.core.datasource.DataConverter']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/json/JSONObject;Lcom/ca/mas/core/datasource/DataConverter;)V", "")]
		public unsafe SecureAccountManagerStoreDataSource (global::Android.Content.Context context, global::Org.Json.JSONObject param, global::Com.CA.Mas.Core.Datasource.IDataConverter converter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (param);
				__args [2] = new JValue (converter);
				if (((object) this).GetType () != typeof (SecureAccountManagerStoreDataSource)) {
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

	}
}
