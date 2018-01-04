using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASMeta']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/user/MASMeta", DoNotGenerateAcw=true)]
	public partial class MASMeta : global::Java.Lang.Object, global::Com.CA.Mas.Foundation.IMASTransformable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/user/MASMeta", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASMeta); }
		}

		protected MASMeta (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASMeta']/constructor[@name='MASMeta' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASMeta ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASMeta)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
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
			global::Com.CA.Mas.Identity.User.MASMeta __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASMeta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJSONObject);
		}
#pragma warning restore 0169

		static IntPtr id_getAsJSONObject;
		public virtual unsafe global::Org.Json.JSONObject AsJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASMeta']/method[@name='getAsJSONObject' and count(parameter)=0]"
			[Register ("getAsJSONObject", "()Lorg/json/JSONObject;", "GetGetAsJSONObjectHandler")]
			get {
				if (id_getAsJSONObject == IntPtr.Zero)
					id_getAsJSONObject = JNIEnv.GetMethodID (class_ref, "getAsJSONObject", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJSONObject), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsJSONObject", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCreated;
#pragma warning disable 0169
		static Delegate GetGetCreatedHandler ()
		{
			if (cb_getCreated == null)
				cb_getCreated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreated);
			return cb_getCreated;
		}

		static IntPtr n_GetCreated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASMeta __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASMeta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Created);
		}
#pragma warning restore 0169

		static IntPtr id_getCreated;
		public virtual unsafe string Created {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASMeta']/method[@name='getCreated' and count(parameter)=0]"
			[Register ("getCreated", "()Ljava/lang/String;", "GetGetCreatedHandler")]
			get {
				if (id_getCreated == IntPtr.Zero)
					id_getCreated = JNIEnv.GetMethodID (class_ref, "getCreated", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreated), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreated", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLastModified;
#pragma warning disable 0169
		static Delegate GetGetLastModifiedHandler ()
		{
			if (cb_getLastModified == null)
				cb_getLastModified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastModified);
			return cb_getLastModified;
		}

		static IntPtr n_GetLastModified (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASMeta __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASMeta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastModified);
		}
#pragma warning restore 0169

		static IntPtr id_getLastModified;
		public virtual unsafe string LastModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASMeta']/method[@name='getLastModified' and count(parameter)=0]"
			[Register ("getLastModified", "()Ljava/lang/String;", "GetGetLastModifiedHandler")]
			get {
				if (id_getLastModified == IntPtr.Zero)
					id_getLastModified = JNIEnv.GetMethodID (class_ref, "getLastModified", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastModified), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastModified", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASMeta __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASMeta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Location);
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		public virtual unsafe string Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASMeta']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Ljava/lang/String;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResourceType;
#pragma warning disable 0169
		static Delegate GetGetResourceTypeHandler ()
		{
			if (cb_getResourceType == null)
				cb_getResourceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceType);
			return cb_getResourceType;
		}

		static IntPtr n_GetResourceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASMeta __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASMeta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResourceType);
		}
#pragma warning restore 0169

		static IntPtr id_getResourceType;
		public virtual unsafe string ResourceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASMeta']/method[@name='getResourceType' and count(parameter)=0]"
			[Register ("getResourceType", "()Ljava/lang/String;", "GetGetResourceTypeHandler")]
			get {
				if (id_getResourceType == IntPtr.Zero)
					id_getResourceType = JNIEnv.GetMethodID (class_ref, "getResourceType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASMeta __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASMeta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASMeta']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static void n_Populate_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jobj)
		{
			global::Com.CA.Mas.Identity.User.MASMeta __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASMeta> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jobj = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jobj, JniHandleOwnership.DoNotTransfer);
			__this.Populate (jobj);
		}
#pragma warning restore 0169

		static IntPtr id_populate_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASMeta']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("populate", "(Lorg/json/JSONObject;)V", "GetPopulate_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Populate (global::Org.Json.JSONObject jobj)
		{
			if (id_populate_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_populate_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "populate", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (jobj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_populate_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "populate", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}
}
