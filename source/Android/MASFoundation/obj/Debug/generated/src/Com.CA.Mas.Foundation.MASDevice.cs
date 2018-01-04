using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASDevice']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASDevice", DoNotGenerateAcw=true)]
	public abstract partial class MASDevice : global::Java.Lang.Object, global::Com.CA.Mas.Foundation.IDevice {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASDevice", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASDevice); }
		}

		protected MASDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCurrentDevice;
		public static unsafe global::Com.CA.Mas.Foundation.MASDevice CurrentDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASDevice']/method[@name='getCurrentDevice' and count(parameter)=0]"
			[Register ("getCurrentDevice", "()Lcom/ca/mas/foundation/MASDevice;", "GetGetCurrentDeviceHandler")]
			get {
				if (id_getCurrentDevice == IntPtr.Zero)
					id_getCurrentDevice = JNIEnv.GetStaticMethodID (class_ref, "getCurrentDevice", "()Lcom/ca/mas/foundation/MASDevice;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASDevice> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentDevice), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.CA.Mas.Foundation.MASDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Deregister (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASDevice']/method[@name='deregister' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("deregister", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetDeregister_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void Deregister (global::Com.CA.Mas.Foundation.MASCallback p0);

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
			global::Com.CA.Mas.Foundation.MASDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetLocally ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='resetLocally' and count(parameter)=0]"
		[Register ("resetLocally", "()V", "GetResetLocallyHandler")]
		public abstract void ResetLocally ();

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
			global::Com.CA.Mas.Foundation.MASDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartAsBluetoothPeripheral (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='startAsBluetoothPeripheral' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.auth.MASProximityLoginBLEPeripheralListener']]"
		[Register ("startAsBluetoothPeripheral", "(Lcom/ca/mas/foundation/auth/MASProximityLoginBLEPeripheralListener;)V", "GetStartAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_Handler")]
		public abstract void StartAsBluetoothPeripheral (global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener p0);

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
			global::Com.CA.Mas.Foundation.MASDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAsBluetoothPeripheral ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='stopAsBluetoothPeripheral' and count(parameter)=0]"
		[Register ("stopAsBluetoothPeripheral", "()V", "GetStopAsBluetoothPeripheralHandler")]
		public abstract void StopAsBluetoothPeripheral ();

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
			global::Com.CA.Mas.Foundation.MASDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Identifier);
		}
#pragma warning restore 0169

		public abstract string Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASDevice']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler")] get;
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
			global::Com.CA.Mas.Foundation.MASDevice __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRegistered;
		}
#pragma warning restore 0169

		public abstract bool IsRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASDevice']/method[@name='isRegistered' and count(parameter)=0]"
			[Register ("isRegistered", "()Z", "GetIsRegisteredHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASDevice", DoNotGenerateAcw=true)]
	internal partial class MASDeviceInvoker : MASDevice {

		public MASDeviceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASDeviceInvoker); }
		}

		static IntPtr id_deregister_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASDevice']/method[@name='deregister' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("deregister", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetDeregister_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void Deregister (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_deregister_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_deregister_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "deregister", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deregister_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_getIdentifier;
		public override unsafe string Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASDevice']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler")]
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isRegistered;
		public override unsafe bool IsRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASDevice']/method[@name='isRegistered' and count(parameter)=0]"
			[Register ("isRegistered", "()Z", "GetIsRegisteredHandler")]
			get {
				if (id_isRegistered == IntPtr.Zero)
					id_isRegistered = JNIEnv.GetMethodID (class_ref, "isRegistered", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRegistered);
				} finally {
				}
			}
		}

		static IntPtr id_resetLocally;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='resetLocally' and count(parameter)=0]"
		[Register ("resetLocally", "()V", "GetResetLocallyHandler")]
		public override unsafe void ResetLocally ()
		{
			if (id_resetLocally == IntPtr.Zero)
				id_resetLocally = JNIEnv.GetMethodID (class_ref, "resetLocally", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetLocally);
			} finally {
			}
		}

		static IntPtr id_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='startAsBluetoothPeripheral' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.auth.MASProximityLoginBLEPeripheralListener']]"
		[Register ("startAsBluetoothPeripheral", "(Lcom/ca/mas/foundation/auth/MASProximityLoginBLEPeripheralListener;)V", "GetStartAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_Handler")]
		public override unsafe void StartAsBluetoothPeripheral (global::Com.CA.Mas.Foundation.Auth.MASProximityLoginBLEPeripheralListener p0)
		{
			if (id_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_ == IntPtr.Zero)
				id_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_ = JNIEnv.GetMethodID (class_ref, "startAsBluetoothPeripheral", "(Lcom/ca/mas/foundation/auth/MASProximityLoginBLEPeripheralListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startAsBluetoothPeripheral_Lcom_ca_mas_foundation_auth_MASProximityLoginBLEPeripheralListener_, __args);
			} finally {
			}
		}

		static IntPtr id_stopAsBluetoothPeripheral;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='Device']/method[@name='stopAsBluetoothPeripheral' and count(parameter)=0]"
		[Register ("stopAsBluetoothPeripheral", "()V", "GetStopAsBluetoothPeripheralHandler")]
		public override unsafe void StopAsBluetoothPeripheral ()
		{
			if (id_stopAsBluetoothPeripheral == IntPtr.Zero)
				id_stopAsBluetoothPeripheral = JNIEnv.GetMethodID (class_ref, "stopAsBluetoothPeripheral", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopAsBluetoothPeripheral);
			} finally {
			}
		}

	}

}
