using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth.Ble {

	[Register ("com/ca/mas/core/auth/ble/BluetoothLeCentralCallback", DoNotGenerateAcw=true)]
	public abstract class BluetoothLeCentralCallback : Java.Lang.Object {

		internal BluetoothLeCentralCallback ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']/field[@name='BLE_STATE_AUTH_FAILED']"
		[Register ("BLE_STATE_AUTH_FAILED")]
		public const int BleStateAuthFailed = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']/field[@name='BLE_STATE_AUTH_SUCCEEDED']"
		[Register ("BLE_STATE_AUTH_SUCCEEDED")]
		public const int BleStateAuthSucceeded = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']/field[@name='BLE_STATE_CHARACTERISTIC_FOUND']"
		[Register ("BLE_STATE_CHARACTERISTIC_FOUND")]
		public const int BleStateCharacteristicFound = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']/field[@name='BLE_STATE_CHARACTERISTIC_WRITTEN']"
		[Register ("BLE_STATE_CHARACTERISTIC_WRITTEN")]
		public const int BleStateCharacteristicWritten = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']/field[@name='BLE_STATE_CONNECTED']"
		[Register ("BLE_STATE_CONNECTED")]
		public const int BleStateConnected = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']/field[@name='BLE_STATE_DEVICE_DETECTED']"
		[Register ("BLE_STATE_DEVICE_DETECTED")]
		public const int BleStateDeviceDetected = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']/field[@name='BLE_STATE_DISCONNECTED']"
		[Register ("BLE_STATE_DISCONNECTED")]
		public const int BleStateDisconnected = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']/field[@name='BLE_STATE_SCAN_STARTED']"
		[Register ("BLE_STATE_SCAN_STARTED")]
		public const int BleStateScanStarted = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']/field[@name='BLE_STATE_SCAN_STOPPED']"
		[Register ("BLE_STATE_SCAN_STOPPED")]
		public const int BleStateScanStopped = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']/field[@name='BLE_STATE_SERVICE_DISCOVERED']"
		[Register ("BLE_STATE_SERVICE_DISCOVERED")]
		public const int BleStateServiceDiscovered = (int) 5;

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

	[Register ("com/ca/mas/core/auth/ble/BluetoothLeCentralCallback", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BluetoothLeCentralCallback' type. This type will be removed in a future release.")]
	public abstract class BluetoothLeCentralCallbackConsts : BluetoothLeCentralCallback {

		private BluetoothLeCentralCallbackConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLeCentralCallback']"
	[Register ("com/ca/mas/core/auth/ble/BluetoothLeCentralCallback", "", "Com.CA.Mas.Core.Auth.Ble.IBluetoothLeCentralCallbackInvoker")]
	public partial interface IBluetoothLeCentralCallback : global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLe {

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/auth/ble/BluetoothLeCentralCallback", DoNotGenerateAcw=true)]
	internal class IBluetoothLeCentralCallbackInvoker : global::Java.Lang.Object, IBluetoothLeCentralCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/auth/ble/BluetoothLeCentralCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBluetoothLeCentralCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBluetoothLeCentralCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBluetoothLeCentralCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.auth.ble.BluetoothLeCentralCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBluetoothLeCentralCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLeCentralCallback __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLeCentralCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
