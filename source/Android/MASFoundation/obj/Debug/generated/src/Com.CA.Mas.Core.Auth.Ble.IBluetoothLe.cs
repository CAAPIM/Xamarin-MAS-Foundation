using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth.Ble {

	[Register ("com/ca/mas/core/auth/ble/BluetoothLe", DoNotGenerateAcw=true)]
	public abstract class BluetoothLe : Java.Lang.Object {

		internal BluetoothLe ()
		{
		}

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

	[Register ("com/ca/mas/core/auth/ble/BluetoothLe", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BluetoothLe' type. This type will be removed in a future release.")]
	public abstract class BluetoothLeConsts : BluetoothLe {

		private BluetoothLeConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']"
	[Register ("com/ca/mas/core/auth/ble/BluetoothLe", "", "Com.CA.Mas.Core.Auth.Ble.IBluetoothLeInvoker")]
	public partial interface IBluetoothLe : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.ble']/interface[@name='BluetoothLe']/method[@name='onStatusUpdate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onStatusUpdate", "(I)V", "GetOnStatusUpdate_IHandler:Com.CA.Mas.Core.Auth.Ble.IBluetoothLeInvoker, MASFoundation")]
		void OnStatusUpdate (int p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/auth/ble/BluetoothLe", DoNotGenerateAcw=true)]
	internal class IBluetoothLeInvoker : global::Java.Lang.Object, IBluetoothLe {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/auth/ble/BluetoothLe");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBluetoothLeInvoker); }
		}

		IntPtr class_ref;

		public static IBluetoothLe GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBluetoothLe> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.auth.ble.BluetoothLe"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBluetoothLeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLe __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
