using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Datasource {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']"
	[Register ("com/ca/mas/core/datasource/DataSource", "", "Com.CA.Mas.Core.Datasource.IDataSourceInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"K", "T"})]
	public partial interface IDataSource : IJavaObject {

		bool IsReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='isReady' and count(parameter)=0]"
			[Register ("isReady", "()Z", "GetIsReadyHandler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='get' and count(parameter)=1 and parameter[1][@type='K']]"
		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		global::Java.Lang.Object Get (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='get' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("get", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetGet_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		void Get (global::Java.Lang.Object p0, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='getKeys' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getKeys", "(Ljava/lang/Object;)Ljava/util/List;", "GetGetKeys_Ljava_lang_Object_Handler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		global::System.Collections.IList GetKeys (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='getKeys' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("getKeys", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetGetKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		void GetKeys (global::Java.Lang.Object p0, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='put' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='T']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		void Put (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='put' and count(parameter)=3 and parameter[1][@type='K'] and parameter[2][@type='T'] and parameter[3][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		void Put (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='K']]"
		[Register ("remove", "(Ljava/lang/Object;)V", "GetRemove_Ljava_lang_Object_Handler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		void Remove (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='K'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("remove", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetRemove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		void Remove (global::Java.Lang.Object p0, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("removeAll", "(Ljava/lang/Object;)V", "GetRemoveAll_Ljava_lang_Object_Handler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		void RemoveAll (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.ca.mas.core.datasource.DataSourceCallback']]"
		[Register ("removeAll", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V", "GetRemoveAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		void RemoveAll (global::Java.Lang.Object p0, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSource']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "GetUnlockHandler:Com.CA.Mas.Core.Datasource.IDataSourceInvoker, MASFoundation")]
		void Unlock ();

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/datasource/DataSource", DoNotGenerateAcw=true)]
	internal class IDataSourceInvoker : global::Java.Lang.Object, IDataSource {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/datasource/DataSource");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDataSourceInvoker); }
		}

		IntPtr class_ref;

		public static IDataSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.datasource.DataSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReady;
		}
#pragma warning restore 0169

		IntPtr id_isReady;
		public unsafe bool IsReady {
			get {
				if (id_isReady == IntPtr.Zero)
					id_isReady = JNIEnv.GetMethodID (class_ref, "isReady", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReady);
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

		static IntPtr n_Get_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Get (global::Java.Lang.Object p0)
		{
			if (id_get_Ljava_lang_Object_ == IntPtr.Zero)
				id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_Get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1 = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		public unsafe void Get (global::Java.Lang.Object p0, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1)
		{
			if (id_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getKeys_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetKeys_Ljava_lang_Object_Handler ()
		{
			if (cb_getKeys_Ljava_lang_Object_ == null)
				cb_getKeys_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeys_Ljava_lang_Object_);
			return cb_getKeys_Ljava_lang_Object_;
		}

		static IntPtr n_GetKeys_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetKeys (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getKeys_Ljava_lang_Object_;
		public unsafe global::System.Collections.IList GetKeys (global::Java.Lang.Object p0)
		{
			if (id_getKeys_Ljava_lang_Object_ == IntPtr.Zero)
				id_getKeys_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getKeys", "(Ljava/lang/Object;)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeys_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetGetKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_GetKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1 = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetKeys (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		public unsafe void GetKeys (global::Java.Lang.Object p0, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1)
		{
			if (id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "getKeys", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getKeys_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
		}

		static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Put_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Put (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_put_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_Put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p2 = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		public unsafe void Put (global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p2)
		{
			if (id_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_Object_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static void n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_Object_;
		public unsafe void Remove (global::Java.Lang.Object p0)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_Remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1 = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		public unsafe void Remove (global::Java.Lang.Object p0, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1)
		{
			if (id_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeAll_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_Ljava_lang_Object_Handler ()
		{
			if (cb_removeAll_Ljava_lang_Object_ == null)
				cb_removeAll_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveAll_Ljava_lang_Object_);
			return cb_removeAll_Ljava_lang_Object_;
		}

		static void n_RemoveAll_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeAll_Ljava_lang_Object_;
		public unsafe void RemoveAll (global::Java.Lang.Object p0)
		{
			if (id_removeAll_Ljava_lang_Object_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAll_Ljava_lang_Object_, __args);
		}

		static Delegate cb_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_Handler ()
		{
			if (cb_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == null)
				cb_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_);
			return cb_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		}

		static void n_RemoveAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1 = (global::Com.CA.Mas.Core.Datasource.IDataSourceCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_;
		public unsafe void RemoveAll (global::Java.Lang.Object p0, global::Com.CA.Mas.Core.Datasource.IDataSourceCallback p1)
		{
			if (id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/Object;Lcom/ca/mas/core/datasource/DataSourceCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAll_Ljava_lang_Object_Lcom_ca_mas_core_datasource_DataSourceCallback_, __args);
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
			global::Com.CA.Mas.Core.Datasource.IDataSource __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlock ();
		}
#pragma warning restore 0169

		IntPtr id_unlock;
		public unsafe void Unlock ()
		{
			if (id_unlock == IntPtr.Zero)
				id_unlock = JNIEnv.GetMethodID (class_ref, "unlock", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unlock);
		}

	}

}
