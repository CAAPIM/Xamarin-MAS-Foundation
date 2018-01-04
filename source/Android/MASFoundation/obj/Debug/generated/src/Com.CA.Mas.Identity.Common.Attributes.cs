using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/common/Attributes", DoNotGenerateAcw=true)]
	public abstract partial class Attributes : global::Java.Lang.Object, global::Com.CA.Mas.Foundation.IMASTransformable {


		static IntPtr mAttributes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/field[@name='mAttributes']"
		[Register ("mAttributes")]
		protected global::System.Collections.IList MAttributes {
			get {
				if (mAttributes_jfieldId == IntPtr.Zero)
					mAttributes_jfieldId = JNIEnv.GetFieldID (class_ref, "mAttributes", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAttributes_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAttributes_jfieldId == IntPtr.Zero)
					mAttributes_jfieldId = JNIEnv.GetFieldID (class_ref, "mAttributes", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAttributes_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/common/Attributes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Attributes); }
		}

		protected Attributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/constructor[@name='Attributes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Attributes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Attributes)) {
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

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/constructor[@name='Attributes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe Attributes (global::System.Collections.Generic.IList<string> attributes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_attributes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (attributes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_attributes);
				if (((object) this).GetType () != typeof (Attributes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_attributes);
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
			global::Com.CA.Mas.Identity.Common.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJSONObject);
		}
#pragma warning restore 0169

		static IntPtr id_getAsJSONObject;
		public virtual unsafe global::Org.Json.JSONObject AsJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/method[@name='getAsJSONObject' and count(parameter)=0]"
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

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		protected abstract string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")] get;
		}

		static Delegate cb_clear_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetClear_Landroid_content_Context_Handler ()
		{
			if (cb_clear_Landroid_content_Context_ == null)
				cb_clear_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Clear_Landroid_content_Context_);
			return cb_clear_Landroid_content_Context_;
		}

		static void n_Clear_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.CA.Mas.Identity.Common.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Clear (context);
		}
#pragma warning restore 0169

		static IntPtr id_clear_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clear", "(Landroid/content/Context;)V", "GetClear_Landroid_content_Context_Handler")]
		public virtual unsafe void Clear (global::Android.Content.Context context)
		{
			if (id_clear_Landroid_content_Context_ == IntPtr.Zero)
				id_clear_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "clear", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getAttributes;
#pragma warning disable 0169
		static Delegate GetGetAttributesHandler ()
		{
			if (cb_getAttributes == null)
				cb_getAttributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributes);
			return cb_getAttributes;
		}

		static IntPtr n_GetAttributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GetAttributes ());
		}
#pragma warning restore 0169

		static IntPtr id_getAttributes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/method[@name='getAttributes' and count(parameter)=0]"
		[Register ("getAttributes", "()Ljava/util/List;", "GetGetAttributesHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> GetAttributes ()
		{
			if (id_getAttributes == IntPtr.Zero)
				id_getAttributes = JNIEnv.GetMethodID (class_ref, "getAttributes", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttributes), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttributes", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.CA.Mas.Identity.Common.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Populate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("populate", "(Lorg/json/JSONObject;)V", "GetPopulate_Lorg_json_JSONObject_Handler")]
		public abstract void Populate (global::Org.Json.JSONObject p0);

		static Delegate cb_save_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSave_Landroid_content_Context_Handler ()
		{
			if (cb_save_Landroid_content_Context_ == null)
				cb_save_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Save_Landroid_content_Context_);
			return cb_save_Landroid_content_Context_;
		}

		static void n_Save_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.CA.Mas.Identity.Common.Attributes __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Save (context);
		}
#pragma warning restore 0169

		static IntPtr id_save_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/method[@name='save' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("save", "(Landroid/content/Context;)V", "GetSave_Landroid_content_Context_Handler")]
		public virtual unsafe void Save (global::Android.Content.Context context)
		{
			if (id_save_Landroid_content_Context_ == IntPtr.Zero)
				id_save_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "save", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/identity/common/Attributes", DoNotGenerateAcw=true)]
	internal partial class AttributesInvoker : Attributes {

		public AttributesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttributesInvoker); }
		}

		static IntPtr id_getKey;
		protected override unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_populate_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attributes']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("populate", "(Lorg/json/JSONObject;)V", "GetPopulate_Lorg_json_JSONObject_Handler")]
		public override unsafe void Populate (global::Org.Json.JSONObject p0)
		{
			if (id_populate_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_populate_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "populate", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_populate_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

	}

}
