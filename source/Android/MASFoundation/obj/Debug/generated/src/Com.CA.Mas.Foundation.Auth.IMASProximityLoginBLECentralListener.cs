using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation.Auth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation.auth']/interface[@name='MASProximityLoginBLECentralListener']"
	[Register ("com/ca/mas/foundation/auth/MASProximityLoginBLECentralListener", "", "Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLECentralListenerInvoker")]
	public partial interface IMASProximityLoginBLECentralListener : global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLeCentralCallback {

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASProximityLoginBLECentralListener", DoNotGenerateAcw=true)]
	internal class IMASProximityLoginBLECentralListenerInvoker : global::Java.Lang.Object, IMASProximityLoginBLECentralListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/auth/MASProximityLoginBLECentralListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASProximityLoginBLECentralListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMASProximityLoginBLECentralListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASProximityLoginBLECentralListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.auth.MASProximityLoginBLECentralListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASProximityLoginBLECentralListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLECentralListener __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLECentralListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
