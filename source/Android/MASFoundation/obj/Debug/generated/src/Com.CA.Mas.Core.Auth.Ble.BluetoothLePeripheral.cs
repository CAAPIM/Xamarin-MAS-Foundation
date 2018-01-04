using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/class[@name='BluetoothLePeripheral']"
	[global::Android.Runtime.Register ("com/ca/mas/core/auth/ble/BluetoothLePeripheral", DoNotGenerateAcw=true)]
	public partial class BluetoothLePeripheral : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/auth/ble/BluetoothLePeripheral", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BluetoothLePeripheral); }
		}

		protected BluetoothLePeripheral (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.CA.Mas.Core.Auth.Ble.BluetoothLePeripheral Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/class[@name='BluetoothLePeripheral']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ca/mas/core/auth/ble/BluetoothLePeripheral;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ca/mas/core/auth/ble/BluetoothLePeripheral;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.BluetoothLePeripheral> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAuthenticating;
#pragma warning disable 0169
		static Delegate GetIsAuthenticatingHandler ()
		{
			if (cb_isAuthenticating == null)
				cb_isAuthenticating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthenticating);
			return cb_isAuthenticating;
		}

		static bool n_IsAuthenticating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.Ble.BluetoothLePeripheral __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.BluetoothLePeripheral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthenticating;
		}
#pragma warning restore 0169

		static IntPtr id_isAuthenticating;
		public virtual unsafe bool IsAuthenticating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/class[@name='BluetoothLePeripheral']/method[@name='isAuthenticating' and count(parameter)=0]"
			[Register ("isAuthenticating", "()Z", "GetIsAuthenticatingHandler")]
			get {
				if (id_isAuthenticating == IntPtr.Zero)
					id_isAuthenticating = JNIEnv.GetMethodID (class_ref, "isAuthenticating", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthenticating);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAuthenticating", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_init_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_Handler ()
		{
			if (cb_init_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_ == null)
				cb_init_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_);
			return cb_init_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_;
		}

		static void n_Init_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configurationProvider, IntPtr native_context)
		{
			global::Com.CA.Mas.Core.Auth.Ble.BluetoothLePeripheral __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.BluetoothLePeripheral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Conf.IConfigurationProvider configurationProvider = (global::Com.CA.Mas.Core.Conf.IConfigurationProvider)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.IConfigurationProvider> (native_configurationProvider, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Init (configurationProvider, context);
		}
#pragma warning restore 0169

		static IntPtr id_init_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/class[@name='BluetoothLePeripheral']/method[@name='init' and count(parameter)=2 and parameter[1][@type='com.ca.mas.core.conf.ConfigurationProvider'] and parameter[2][@type='android.content.Context']]"
		[Register ("init", "(Lcom/ca/mas/core/conf/ConfigurationProvider;Landroid/content/Context;)V", "GetInit_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Com.CA.Mas.Core.Conf.IConfigurationProvider configurationProvider, global::Android.Content.Context context)
		{
			if (id_init_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/ca/mas/core/conf/ConfigurationProvider;Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (configurationProvider);
				__args [1] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_ca_mas_core_conf_ConfigurationProvider_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lcom/ca/mas/core/conf/ConfigurationProvider;Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_;
#pragma warning disable 0169
		static Delegate GetStart_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_Handler ()
		{
			if (cb_start_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_ == null)
				cb_start_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Start_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_);
			return cb_start_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_;
		}

		static void n_Start_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.CA.Mas.Core.Auth.Ble.BluetoothLePeripheral __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.BluetoothLePeripheral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback @callback = (global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Start (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_start_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/class[@name='BluetoothLePeripheral']/method[@name='start' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.auth.ble.BluetoothLePeripheralCallback']]"
		[Register ("start", "(Lcom/ca/mas/core/auth/ble/BluetoothLePeripheralCallback;)V", "GetStart_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_Handler")]
		public virtual unsafe void Start (global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback @callback)
		{
			if (id_start_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_ == IntPtr.Zero)
				id_start_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_ = JNIEnv.GetMethodID (class_ref, "start", "(Lcom/ca/mas/core/auth/ble/BluetoothLePeripheralCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start_Lcom_ca_mas_core_auth_ble_BluetoothLePeripheralCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(Lcom/ca/mas/core/auth/ble/BluetoothLePeripheralCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.Ble.BluetoothLePeripheral __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.BluetoothLePeripheral> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/class[@name='BluetoothLePeripheral']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
