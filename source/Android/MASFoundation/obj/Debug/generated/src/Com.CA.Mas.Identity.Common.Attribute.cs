using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/common/Attribute", DoNotGenerateAcw=true)]
	public partial class Attribute : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/common/Attribute", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Attribute); }
		}

		protected Attribute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/constructor[@name='Attribute' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Attribute ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Attribute)) {
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

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCaseExact;
#pragma warning disable 0169
		static Delegate GetIsCaseExactHandler ()
		{
			if (cb_isCaseExact == null)
				cb_isCaseExact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCaseExact);
			return cb_isCaseExact;
		}

		static bool n_IsCaseExact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCaseExact;
		}
#pragma warning restore 0169

		static IntPtr id_isCaseExact;
		public virtual unsafe bool IsCaseExact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/method[@name='isCaseExact' and count(parameter)=0]"
			[Register ("isCaseExact", "()Z", "GetIsCaseExactHandler")]
			get {
				if (id_isCaseExact == IntPtr.Zero)
					id_isCaseExact = JNIEnv.GetMethodID (class_ref, "isCaseExact", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCaseExact);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCaseExact", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isMultiValued;
#pragma warning disable 0169
		static Delegate GetIsMultiValuedHandler ()
		{
			if (cb_isMultiValued == null)
				cb_isMultiValued = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMultiValued);
			return cb_isMultiValued;
		}

		static bool n_IsMultiValued (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMultiValued;
		}
#pragma warning restore 0169

		static IntPtr id_isMultiValued;
		public virtual unsafe bool IsMultiValued {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/method[@name='isMultiValued' and count(parameter)=0]"
			[Register ("isMultiValued", "()Z", "GetIsMultiValuedHandler")]
			get {
				if (id_isMultiValued == IntPtr.Zero)
					id_isMultiValued = JNIEnv.GetMethodID (class_ref, "isMultiValued", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMultiValued);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMultiValued", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRequired;
#pragma warning disable 0169
		static Delegate GetIsRequiredHandler ()
		{
			if (cb_isRequired == null)
				cb_isRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRequired);
			return cb_isRequired;
		}

		static bool n_IsRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRequired;
		}
#pragma warning restore 0169

		static IntPtr id_isRequired;
		public virtual unsafe bool IsRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/method[@name='isRequired' and count(parameter)=0]"
			[Register ("isRequired", "()Z", "GetIsRequiredHandler")]
			get {
				if (id_isRequired == IntPtr.Zero)
					id_isRequired = JNIEnv.GetMethodID (class_ref, "isRequired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRequired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRequired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMutability;
#pragma warning disable 0169
		static Delegate GetGetMutabilityHandler ()
		{
			if (cb_getMutability == null)
				cb_getMutability = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMutability);
			return cb_getMutability;
		}

		static IntPtr n_GetMutability (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Mutability);
		}
#pragma warning restore 0169

		static IntPtr id_getMutability;
		public virtual unsafe string Mutability {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/method[@name='getMutability' and count(parameter)=0]"
			[Register ("getMutability", "()Ljava/lang/String;", "GetGetMutabilityHandler")]
			get {
				if (id_getMutability == IntPtr.Zero)
					id_getMutability = JNIEnv.GetMethodID (class_ref, "getMutability", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMutability), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMutability", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReturned;
#pragma warning disable 0169
		static Delegate GetGetReturnedHandler ()
		{
			if (cb_getReturned == null)
				cb_getReturned = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReturned);
			return cb_getReturned;
		}

		static IntPtr n_GetReturned (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Returned);
		}
#pragma warning restore 0169

		static IntPtr id_getReturned;
		public virtual unsafe string Returned {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/method[@name='getReturned' and count(parameter)=0]"
			[Register ("getReturned", "()Ljava/lang/String;", "GetGetReturnedHandler")]
			get {
				if (id_getReturned == IntPtr.Zero)
					id_getReturned = JNIEnv.GetMethodID (class_ref, "getReturned", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReturned), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReturned", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUniqueness;
#pragma warning disable 0169
		static Delegate GetGetUniquenessHandler ()
		{
			if (cb_getUniqueness == null)
				cb_getUniqueness = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUniqueness);
			return cb_getUniqueness;
		}

		static IntPtr n_GetUniqueness (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Common.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uniqueness);
		}
#pragma warning restore 0169

		static IntPtr id_getUniqueness;
		public virtual unsafe string Uniqueness {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/method[@name='getUniqueness' and count(parameter)=0]"
			[Register ("getUniqueness", "()Ljava/lang/String;", "GetGetUniquenessHandler")]
			get {
				if (id_getUniqueness == IntPtr.Zero)
					id_getUniqueness = JNIEnv.GetMethodID (class_ref, "getUniqueness", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUniqueness), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUniqueness", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Identity.Common.Attribute __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.Attribute> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jobj = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jobj, JniHandleOwnership.DoNotTransfer);
			__this.Populate (jobj);
		}
#pragma warning restore 0169

		static IntPtr id_populate_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='Attribute']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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
