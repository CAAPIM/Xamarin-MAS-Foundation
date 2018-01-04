using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthorizationRequestHandler']"
	[Register ("com/ca/mas/foundation/MASAuthorizationRequestHandler", "", "Com.CA.Mas.Foundation.IMASAuthorizationRequestHandlerInvoker")]
	public partial interface IMASAuthorizationRequestHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthorizationRequestHandler']/method[@name='authorize' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASAuthorizationRequest']]"
		[Register ("authorize", "(Lcom/ca/mas/foundation/MASAuthorizationRequest;)V", "GetAuthorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_Handler:Com.CA.Mas.Foundation.IMASAuthorizationRequestHandlerInvoker, MASFoundation")]
		void Authorize (global::Com.CA.Mas.Foundation.MASAuthorizationRequest p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASAuthorizationRequestHandler", DoNotGenerateAcw=true)]
	internal class IMASAuthorizationRequestHandlerInvoker : global::Java.Lang.Object, IMASAuthorizationRequestHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/MASAuthorizationRequestHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASAuthorizationRequestHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IMASAuthorizationRequestHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASAuthorizationRequestHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.MASAuthorizationRequestHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASAuthorizationRequestHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_authorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_;
#pragma warning disable 0169
		static Delegate GetAuthorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_Handler ()
		{
			if (cb_authorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_ == null)
				cb_authorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Authorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_);
			return cb_authorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_;
		}

		static void n_Authorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.IMASAuthorizationRequestHandler __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthorizationRequestHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASAuthorizationRequest p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Authorize (p0);
		}
#pragma warning restore 0169

		IntPtr id_authorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_;
		public unsafe void Authorize (global::Com.CA.Mas.Foundation.MASAuthorizationRequest p0)
		{
			if (id_authorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_ == IntPtr.Zero)
				id_authorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Lcom/ca/mas/foundation/MASAuthorizationRequest;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_authorize_Lcom_ca_mas_foundation_MASAuthorizationRequest_, __args);
		}

	}

}
