using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth.Ble {

	[Register ("com/ca/mas/core/auth/ble/BluetoothLePeripheralCallback", DoNotGenerateAcw=true)]
	public abstract class BluetoothLePeripheralCallback : Java.Lang.Object {

		internal BluetoothLePeripheralCallback ()
		{
		}

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

	[Register ("com/ca/mas/core/auth/ble/BluetoothLePeripheralCallback", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BluetoothLePeripheralCallback' type. This type will be removed in a future release.")]
	public abstract class BluetoothLePeripheralCallbackConsts : BluetoothLePeripheralCallback {

		private BluetoothLePeripheralCallbackConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']"
	[Register ("com/ca/mas/core/auth/ble/BluetoothLePeripheralCallback", "", "Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallbackInvoker")]
	public partial interface IBluetoothLePeripheralCallback : global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLe {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/method[@name='onConsentRequested' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.core.auth.ble.BluetoothLeConsentHandler']]"
		[Register ("onConsentRequested", "(Ljava/lang/String;Lcom/ca/mas/core/auth/ble/BluetoothLeConsentHandler;)V", "GetOnConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_Handler:Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallbackInvoker, MASFoundation")]
		void OnConsentRequested (string p0, global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLeConsentHandler p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLePeripheralCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler:Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallbackInvoker, MASFoundation")]
		void OnError (int p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/auth/ble/BluetoothLePeripheralCallback", DoNotGenerateAcw=true)]
	internal class IBluetoothLePeripheralCallbackInvoker : global::Java.Lang.Object, IBluetoothLePeripheralCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/auth/ble/BluetoothLePeripheralCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBluetoothLePeripheralCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBluetoothLePeripheralCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBluetoothLePeripheralCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.auth.ble.BluetoothLePeripheralCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBluetoothLePeripheralCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_;
#pragma warning disable 0169
		static Delegate GetOnConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_Handler ()
		{
			if (cb_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_ == null)
				cb_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_);
			return cb_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_;
		}

		static void n_OnConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLeConsentHandler p1 = (global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLeConsentHandler)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLeConsentHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnConsentRequested (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_;
		public unsafe void OnConsentRequested (string p0, global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLeConsentHandler p1)
		{
			if (id_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_ == IntPtr.Zero)
				id_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_ = JNIEnv.GetMethodID (class_ref, "onConsentRequested", "(Ljava/lang/String;Lcom/ca/mas/core/auth/ble/BluetoothLeConsentHandler;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConsentRequested_Ljava_lang_String_Lcom_ca_mas_core_auth_ble_BluetoothLeConsentHandler_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_I;
		public unsafe void OnError (int p0)
		{
			if (id_onError_I == IntPtr.Zero)
				id_onError_I = JNIEnv.GetMethodID (class_ref, "onError", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_I, __args);
		}

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
			global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLePeripheralCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStatusUpdate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStatusUpdate_I;
		public unsafe void OnStatusUpdate (int p0)
		{
			if (id_onStatusUpdate_I == IntPtr.Zero)
				id_onStatusUpdate_I = JNIEnv.GetMethodID (class_ref, "onStatusUpdate", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStatusUpdate_I, __args);
		}

	}

}
