using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation.Auth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation.auth']/interface[@name='MASProximityLoginBLEUserConsentHandler']"
	[Register ("com/ca/mas/foundation/auth/MASProximityLoginBLEUserConsentHandler", "", "Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLEUserConsentHandlerInvoker")]
	public partial interface IMASProximityLoginBLEUserConsentHandler : global::Com.CA.Mas.Core.Auth.Ble.IBluetoothLeConsentHandler {

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/auth/MASProximityLoginBLEUserConsentHandler", DoNotGenerateAcw=true)]
	internal class IMASProximityLoginBLEUserConsentHandlerInvoker : global::Java.Lang.Object, IMASProximityLoginBLEUserConsentHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/auth/MASProximityLoginBLEUserConsentHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASProximityLoginBLEUserConsentHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IMASProximityLoginBLEUserConsentHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASProximityLoginBLEUserConsentHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.auth.MASProximityLoginBLEUserConsentHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASProximityLoginBLEUserConsentHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLEUserConsentHandler __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLEUserConsentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_proceed;
#pragma warning disable 0169
		static Delegate GetProceedHandler ()
		{
			if (cb_proceed == null)
				cb_proceed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Proceed);
			return cb_proceed;
		}

		static void n_Proceed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLEUserConsentHandler __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.Auth.IMASProximityLoginBLEUserConsentHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Proceed ();
		}
#pragma warning restore 0169

		IntPtr id_proceed;
		public unsafe void Proceed ()
		{
			if (id_proceed == IntPtr.Zero)
				id_proceed = JNIEnv.GetMethodID (class_ref, "proceed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_proceed);
		}

	}

}
