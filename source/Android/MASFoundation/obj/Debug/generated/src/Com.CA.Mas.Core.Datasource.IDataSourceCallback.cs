using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Datasource {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSourceCallback']"
	[Register ("com/ca/mas/core/datasource/DataSourceCallback", "", "Com.CA.Mas.Core.Datasource.IDataSourceCallbackInvoker")]
	public partial interface IDataSourceCallback : IJavaObject {

		global::Android.OS.Handler Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSourceCallback']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Landroid/os/Handler;", "GetGetHandlerHandler:Com.CA.Mas.Core.Datasource.IDataSourceCallbackInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.datasource']/interface[@name='DataSourceCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:Com.CA.Mas.Core.Datasource.IDataSourceCallbackInvoker, MASFoundation")]
		void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/datasource/DataSourceCallback", DoNotGenerateAcw=true)]
	internal class IDataSourceCallbackInvoker : global::Java.Lang.Object, IDataSourceCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/datasource/DataSourceCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDataSourceCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IDataSourceCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataSourceCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.datasource.DataSourceCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataSourceCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getHandler;
#pragma warning disable 0169
		static Delegate GetGetHandlerHandler ()
		{
			if (cb_getHandler == null)
				cb_getHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHandler);
			return cb_getHandler;
		}

		static IntPtr n_GetHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Handler);
		}
#pragma warning restore 0169

		IntPtr id_getHandler;
		public unsafe global::Android.OS.Handler Handler {
			get {
				if (id_getHandler == IntPtr.Zero)
					id_getHandler = JNIEnv.GetMethodID (class_ref, "getHandler", "()Landroid/os/Handler;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHandler), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_Object_);
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Datasource.IDataSourceCallback __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Datasource.IDataSourceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_;
		public unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
		}

	}

}
