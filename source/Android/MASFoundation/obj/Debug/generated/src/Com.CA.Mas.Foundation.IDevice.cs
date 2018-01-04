using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']"
	[Register ("com/ca/mas/foundation/Device", "", "Com.CA.Mas.Foundation.IDeviceInvoker")]
	public partial interface IDevice : IJavaObject {

		string Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler:Com.CA.Mas.Foundation.IDeviceInvoker, MASFoundation")] get;
		}

		bool IsRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='isRegistered' and count(parameter)=0]"
			[Register ("isRegistered", "()Z", "GetIsRegisteredHandler:Com.CA.Mas.Foundation.IDeviceInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='deregister' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("deregister", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetDeregister_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Foundation.IDeviceInvoker, MASFoundation")]
		void Deregister (global::Com.CA.Mas.Foundation.MASCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='resetLocally' and count(parameter)=0]"
		[Register ("resetLocally", "()V", "GetResetLocallyHandler:Com.CA.Mas.Foundation.IDeviceInvoker, MASFoundation")]
		void ResetLocally ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='startAsBluetoothPeripheral' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.auth.MASProximityLoginBLEPeripheralListener']]"
		[Register ("startAsBluetoothPeripheral", "(Lcom/ca/mas/foundation/auth/MASProximityLoginBLEPeripheralListener;)V", "GetStartAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_Handler:Com.CA.Mas.Foundation.IDeviceInvoker, MASFoundation")]
		void StartAsBluetoothPeripheral (global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='stopAsBluetoothPeripheral' and count(parameter)=0]"
		[Register ("stopAsBluetoothPeripheral", "()V", "GetStopAsBluetoothPeripheralHandler:Com.CA.Mas.Foundation.IDeviceInvoker, MASFoundation")]
		void StopAsBluetoothPeripheral ();

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/Device", DoNotGenerateAcw=true)]
	internal class IDeviceInvoker : global::Java.Lang.Object, IDevice {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/Device");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDeviceInvoker); }
		}

		IntPtr class_ref;

		public static IDevice GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDevice> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.Device"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIdentifierHandler ()
		{
			if (cb_getIdentifier == null)
				cb_getIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentifier);
			return cb_getIdentifier;
		}

		static IntPtr n_GetIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Identifier);
		}
#pragma warning restore 0169

		IntPtr id_getIdentifier;
		public unsafe string Identifier {
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isRegistered;
#pragma warning disable 0169
		static Delegate GetIsRegisteredHandler ()
		{
			if (cb_isRegistered == null)
				cb_isRegistered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRegistered);
			return cb_isRegistered;
		}

		static bool n_IsRegistered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRegistered;
		}
#pragma warning restore 0169

		IntPtr id_isRegistered;
		public unsafe bool IsRegistered {
			get {
				if (id_isRegistered == IntPtr.Zero)
					id_isRegistered = JNIEnv.GetMethodID (class_ref, "isRegistered", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRegistered);
			}
		}

		static Delegate cb_deregister_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetDeregister_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_deregister_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_deregister_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Deregister_Lcom_ca_mas_foundation_MASCallback_);
			return cb_deregister_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_Deregister_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.IDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Deregister (p0);
		}
#pragma warning restore 0169

		IntPtr id_deregister_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void Deregister (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_deregister_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_deregister_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "deregister", "(Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deregister_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

		static Delegate cb_resetLocally;
#pragma warning disable 0169
		static Delegate GetResetLocallyHandler ()
		{
			if (cb_resetLocally == null)
				cb_resetLocally = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetLocally);
			return cb_resetLocally;
		}

		static void n_ResetLocally (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetLocally ();
		}
#pragma warning restore 0169

		IntPtr id_resetLocally;
		public unsafe void ResetLocally ()
		{
			if (id_resetLocally == IntPtr.Zero)
				id_resetLocally = JNIEnv.GetMethodID (class_ref, "resetLocally", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetLocally);
		}

		static Delegate cb_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_;
#pragma warning disable 0169
		static Delegate GetStartAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_Handler ()
		{
			if (cb_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_ == null)
				cb_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_);
			return cb_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_;
		}

		static void n_StartAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.IDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartAsBluetoothPeripheral (p0);
		}
#pragma warning restore 0169

		IntPtr id_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_;
		public unsafe void StartAsBluetoothPeripheral (global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener p0)
		{
			if (id_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_ == IntPtr.Zero)
				id_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_ = JNIEnv.GetMethodID (class_ref, "startAsBluetoothPeripheral", "(Lcom/ca/mas/foundation/auth/MASProximityLoginBLEPeripheralListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_, __args);
		}

		static Delegate cb_stopAsBluetoothPeripheral;
#pragma warning disable 0169
		static Delegate GetStopAsBluetoothPeripheralHandler ()
		{
			if (cb_stopAsBluetoothPeripheral == null)
				cb_stopAsBluetoothPeripheral = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAsBluetoothPeripheral);
			return cb_stopAsBluetoothPeripheral;
		}

		static void n_StopAsBluetoothPeripheral (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAsBluetoothPeripheral ();
		}
#pragma warning restore 0169

		IntPtr id_stopAsBluetoothPeripheral;
		public unsafe void StopAsBluetoothPeripheral ()
		{
			if (id_stopAsBluetoothPeripheral == IntPtr.Zero)
				id_stopAsBluetoothPeripheral = JNIEnv.GetMethodID (class_ref, "stopAsBluetoothPeripheral", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopAsBluetoothPeripheral);
		}

	}

}
