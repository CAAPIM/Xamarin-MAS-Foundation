using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASTransformable']"
	[Register ("com/ca/mas/foundation/MASTransformable", "", "Com.CA.Mas.Foundation.IMASTransformableInvoker")]
	public partial interface IMASTransformable : IJavaObject {

		global::Org.Json.JSONObject AsJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASTransformable']/method[@name='getAsJSONObject' and count(parameter)=0]"
			[Register ("getAsJSONObject", "()Lorg/json/JSONObject;", "GetGetAsJSONObjectHandler:Com.CA.Mas.Foundation.IMASTransformableInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASTransformable']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("populate", "(Lorg/json/JSONObject;)V", "GetPopulate_Lorg_json_JSONObject_Handler:Com.CA.Mas.Foundation.IMASTransformableInvoker, MASFoundation")]
		void Populate (global::Org.Json.JSONObject p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASTransformable", DoNotGenerateAcw=true)]
	internal class IMASTransformableInvoker : global::Java.Lang.Object, IMASTransformable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/MASTransformable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASTransformableInvoker); }
		}

		IntPtr class_ref;

		public static IMASTransformable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASTransformable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.MASTransformable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASTransformableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAsJSONObject;
#pragma warning disable 0169
		static Delegate GetGetAsJSONObjectHandler ()
		{
			if (cb_getAsJSONObject == null)
				cb_getAsJSONObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJSONObject);
			return cb_getAsJSONObject;
		}

		static IntPtr n_GetAsJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASTransformable __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASTransformable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJSONObject);
		}
#pragma warning restore 0169

		IntPtr id_getAsJSONObject;
		public unsafe global::Org.Json.JSONObject AsJSONObject {
			get {
				if (id_getAsJSONObject == IntPtr.Zero)
					id_getAsJSONObject = JNIEnv.GetMethodID (class_ref, "getAsJSONObject", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJSONObject), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_populate_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetPopulate_Lorg_json_JSONObject_Handler ()
		{
			if (cb_populate_Lorg_json_JSONObject_ == null)
				cb_populate_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Populate_Lorg_json_JSONObject_);
			return cb_populate_Lorg_json_JSONObject_;
		}

		static void n_Populate_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.IMASTransformable __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASTransformable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Populate (p0);
		}
#pragma warning restore 0169

		IntPtr id_populate_Lorg_json_JSONObject_;
		public unsafe void Populate (global::Org.Json.JSONObject p0)
		{
			if (id_populate_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_populate_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "populate", "(Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_populate_Lorg_json_JSONObject_, __args);
		}

	}

}
