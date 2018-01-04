using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginBLEPeripheralListener']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASProximityLoginBLEPeripheralListener", DoNotGenerateAcw=true)]
	public abstract partial class MASProximityLoginBLEPeripheralListener : global::Java.Lang.Object, global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback {


		public static class InterfaceConsts {

			// The following are fields from: com.ca.mas.core.auth.ble.BluetoothLePeripheralCallback

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/field[@name='BLE_ERROR_ADVERTISE_FAILED']"
			[Register ("BLE_ERROR_ADVERTISE_FAILED")]
			public const int BleErrorAdvertiseFailed = (int) 120;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/field[@name='BLE_ERROR_AUTH_FAILED']"
			[Register ("BLE_ERROR_AUTH_FAILED")]
			public const int BleErrorAuthFailed = (int) 121;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/field[@name='BLE_ERROR_CENTRAL_UNSUBSCRIBED']"
			[Register ("BLE_ERROR_CENTRAL_UNSUBSCRIBED")]
			public const int BleErrorCentralUnsubscribed = (int) 123;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/field[@name='BLE_ERROR_PERIPHERAL_MODE_NOT_SUPPORTED']"
			[Register ("BLE_ERROR_PERIPHERAL_MODE_NOT_SUPPORTED")]
			public const int BleErrorPeripheralModeNotSupported = (int) 122;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/field[@name='BLE_STATE_CONNECTED']"
			[Register ("BLE_STATE_CONNECTED")]
			public const int BleStateConnected = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/field[@name='BLE_STATE_DISCONNECTED']"
			[Register ("BLE_STATE_DISCONNECTED")]
			public const int BleStateDisconnected = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/field[@name='BLE_STATE_SESSION_AUTHORIZED']"
			[Register ("BLE_STATE_SESSION_AUTHORIZED")]
			public const int BleStateSessionAuthorized = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/field[@name='BLE_STATE_SESSION_NOTIFIED']"
			[Register ("BLE_STATE_SESSION_NOTIFIED")]
			public const int BleStateSessionNotified = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/field[@name='BLE_STATE_STARTED']"
			[Register ("BLE_STATE_STARTED")]
			public const int BleStateStarted = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/field[@name='BLE_STATE_STOPPED']"
			[Register ("BLE_STATE_STOPPED")]
			public const int BleStateStopped = (int) 13;

			// The following are fields from: com.ca.mas.core.auth.ble.BluetoothLe

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']/field[@name='BLE_ERROR_DISABLED']"
			[Register ("BLE_ERROR_DISABLED")]
			public const int BleErrorDisabled = (int) 100;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']/field[@name='BLE_ERROR_INVALID_UUID']"
			[Register ("BLE_ERROR_INVALID_UUID")]
			public const int BleErrorInvalidUuid = (int) 102;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']/field[@name='BLE_ERROR_NOT_SUPPORTED']"
			[Register ("BLE_ERROR_NOT_SUPPORTED")]
			public const int BleErrorNotSupported = (int) 101;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']/field[@name='BLE_ERROR_SESSION_SHARING_NOT_SUPPORTED']"
			[Register ("BLE_ERROR_SESSION_SHARING_NOT_SUPPORTED")]
			public const int BleErrorSessionSharingNotSupported = (int) 103;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']/field[@name='DEVICE_NAME']"
			[Register ("DEVICE_NAME")]
			public const string DeviceName = (string) "device_name";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']/field[@name='EOM']"
			[Register ("EOM")]
			public const string Eom = (string) "EOM";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']/field[@name='PROVIDER_URL']"
			[Register ("PROVIDER_URL")]
			public const string ProviderUrl = (string) "provider_url";
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/auth/MASProximityLoginBLEPeripheralListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASProximityLoginBLEPeripheralListener); }
		}

		protected MASProximityLoginBLEPeripheralListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginBLEPeripheralListener']/constructor[@name='MASProximityLoginBLEPeripheralListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASProximityLoginBLEPeripheralListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASProximityLoginBLEPeripheralListener)) {
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

		static Delegate cb_onConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_;
#pragma warning disable 0169
		static Delegate GetOnConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_Handler ()
		{
			if (cb_onConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_ == null)
				cb_onConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_);
			return cb_onConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_;
		}

		static void n_OnConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLEUserConsentHandler p2 = (global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLEUserConsentHandler)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLEUserConsentHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnConsentRequested (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginBLEPeripheralListener']/method[@name='onConsentRequested' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ca.mas.foundation.auth.MASProximityLoginBLEUserConsentHandler']]"
		[Register ("onConsentRequested", "(Landroid/content/Context;Ljava/lang/String;Lcom/ca/mas/foundation/auth/MASProximityLoginBLEUserConsentHandler;)V", "GetOnConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_Handler")]
		public abstract void OnConsentRequested (global::Android.Content.Context p0, string p1, global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLEUserConsentHandler p2);

		static IntPtr id_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginBLEPeripheralListener']/method[@name='onConsentRequested' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.core.auth.ble.BluetoothLeConsentHandler']]"
		[Register ("onConsentRequested", "(Ljava/lang/String;Lcom/ca/mas/core/auth/ble/BluetoothLeConsentHandler;)V", "")]
		public unsafe void OnConsentRequested (string deviceName, global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLeConsentHandler handler)
		{
			if (id_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_ == IntPtr.Zero)
				id_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_ = JNIEnv.GetMethodID (class_ref, "onConsentRequested", "(Ljava/lang/String;Lcom/ca/mas/core/auth/ble/BluetoothLeConsentHandler;)V");
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_deviceName);
				__args [1] = new JValue (handler);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
			}
		}

		static Delegate cb_onError_I;
#pragma warning disable 0169
		static Delegate GetOnError_IHandler ()
		{
			if (cb_onError_I == null)
				cb_onError_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnError_I);
			return cb_onError_I;
		}

		static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public abstract void OnError (int p0);

		static Delegate cb_onStatusUpdate_I;
#pragma warning disable 0169
		static Delegate GetOnStatusUpdate_IHandler ()
		{
			if (cb_onStatusUpdate_I == null)
				cb_onStatusUpdate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnStatusUpdate_I);
			return cb_onStatusUpdate_I;
		}

		static void n_OnStatusUpdate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStatusUpdate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']/method[@name='onStatusUpdate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onStatusUpdate", "(I)V", "GetOnStatusUpdate_IHandler")]
		public abstract void OnStatusUpdate (int p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASProximityLoginBLEPeripheralListener", DoNotGenerateAcw=true)]
	internal partial class MASProximityLoginBLEPeripheralListenerInvoker : MASProximityLoginBLEPeripheralListener {

		public MASProximityLoginBLEPeripheralListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASProximityLoginBLEPeripheralListenerInvoker); }
		}

		static IntPtr id_onConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation.auth']/class[@name='MASProximityLoginBLEPeripheralListener']/method[@name='onConsentRequested' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.ca.mas.foundation.auth.MASProximityLoginBLEUserConsentHandler']]"
		[Register ("onConsentRequested", "(Landroid/content/Context;Ljava/lang/String;Lcom/ca/mas/foundation/auth/MASProximityLoginBLEUserConsentHandler;)V", "GetOnConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_Handler")]
		public override unsafe void OnConsentRequested (global::Android.Content.Context p0, string p1, global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLEUserConsentHandler p2)
		{
			if (id_onConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_ == IntPtr.Zero)
				id_onConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_ = JNIEnv.GetMethodID (class_ref, "onConsentRequested", "(Landroid/content/Context;Ljava/lang/String;Lcom/ca/mas/foundation/auth/MASProximityLoginBLEUserConsentHandler;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConsentRequested_Landroid_content_Context_Ljava_lang_String_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEUserConsentHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onError_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public override unsafe void OnError (int p0)
		{
			if (id_onError_I == IntPtr.Zero)
				id_onError_I = JNIEnv.GetMethodID (class_ref, "onError", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_I, __args);
			} finally {
			}
		}

		static IntPtr id_onStatusUpdate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']/method[@name='onStatusUpdate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onStatusUpdate", "(I)V", "GetOnStatusUpdate_IHandler")]
		public override unsafe void OnStatusUpdate (int p0)
		{
			if (id_onStatusUpdate_I == IntPtr.Zero)
				id_onStatusUpdate_I = JNIEnv.GetMethodID (class_ref, "onStatusUpdate", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStatusUpdate_I, __args);
			} finally {
			}
		}

	}

}
