using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.auth']/interface[@name='AuthResultReceiver']"
	[Register ("com/ca/mas/core/auth/AuthResultReceiver", "", "Com.CA.Mas.Core.Auth.IAuthResultReceiverInvoker")]
	public partial interface IAuthResultReceiver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth']/interface[@name='AuthResultReceiver']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("setData", "(Lorg/json/JSONObject;)V", "GetSetData_Lorg_json_JSONObject_Handler:Com.CA.Mas.Core.Auth.IAuthResultReceiverInvoker, MASFoundation")]
		void SetData (global::Org.Json.JSONObject p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/auth/AuthResultReceiver", DoNotGenerateAcw=true)]
	internal class IAuthResultReceiverInvoker : global::Java.Lang.Object, IAuthResultReceiver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/auth/AuthResultReceiver");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAuthResultReceiverInvoker); }
		}

		IntPtr class_ref;

		public static IAuthResultReceiver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthResultReceiver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.auth.AuthResultReceiver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthResultReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setData_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetData_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setData_Lorg_json_JSONObject_ == null)
				cb_setData_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lorg_json_JSONObject_);
			return cb_setData_Lorg_json_JSONObject_;
		}

		static void n_SetData_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Auth.IAuthResultReceiver __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.IAuthResultReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetData (p0);
		}
#pragma warning restore 0169

		IntPtr id_setData_Lorg_json_JSONObject_;
		public unsafe void SetData (global::Org.Json.JSONObject p0)
		{
			if (id_setData_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_setData_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setData", "(Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Lorg_json_JSONObject_, __args);
		}

	}

}
