using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/user/MASName", DoNotGenerateAcw=true)]
	public partial class MASName : global::Java.Lang.Object, global::Com.CA.Mas.Foundation.IMASTransformable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/user/MASName", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASName); }
		}

		protected MASName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']/constructor[@name='MASName' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASName ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASName)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']/constructor[@name='MASName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MASName (string givenName, string familyName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_givenName = JNIEnv.NewString (givenName);
			IntPtr native_familyName = JNIEnv.NewString (familyName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_givenName);
				__args [1] = new JValue (native_familyName);
				if (((object) this).GetType () != typeof (MASName)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_givenName);
				JNIEnv.DeleteLocalRef (native_familyName);
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
			global::Com.CA.Mas.Identity.User.MASName __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJSONObject);
		}
#pragma warning restore 0169

		static IntPtr id_getAsJSONObject;
		public virtual unsafe global::Org.Json.JSONObject AsJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']/method[@name='getAsJSONObject' and count(parameter)=0]"
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

		static Delegate cb_getFamilyName;
#pragma warning disable 0169
		static Delegate GetGetFamilyNameHandler ()
		{
			if (cb_getFamilyName == null)
				cb_getFamilyName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFamilyName);
			return cb_getFamilyName;
		}

		static IntPtr n_GetFamilyName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASName __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FamilyName);
		}
#pragma warning restore 0169

		static IntPtr id_getFamilyName;
		public virtual unsafe string FamilyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']/method[@name='getFamilyName' and count(parameter)=0]"
			[Register ("getFamilyName", "()Ljava/lang/String;", "GetGetFamilyNameHandler")]
			get {
				if (id_getFamilyName == IntPtr.Zero)
					id_getFamilyName = JNIEnv.GetMethodID (class_ref, "getFamilyName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFamilyName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFamilyName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormatted;
#pragma warning disable 0169
		static Delegate GetGetFormattedHandler ()
		{
			if (cb_getFormatted == null)
				cb_getFormatted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormatted);
			return cb_getFormatted;
		}

		static IntPtr n_GetFormatted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASName __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Formatted);
		}
#pragma warning restore 0169

		static IntPtr id_getFormatted;
		public virtual unsafe string Formatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']/method[@name='getFormatted' and count(parameter)=0]"
			[Register ("getFormatted", "()Ljava/lang/String;", "GetGetFormattedHandler")]
			get {
				if (id_getFormatted == IntPtr.Zero)
					id_getFormatted = JNIEnv.GetMethodID (class_ref, "getFormatted", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormatted), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormatted", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGivenName;
#pragma warning disable 0169
		static Delegate GetGetGivenNameHandler ()
		{
			if (cb_getGivenName == null)
				cb_getGivenName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGivenName);
			return cb_getGivenName;
		}

		static IntPtr n_GetGivenName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASName __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GivenName);
		}
#pragma warning restore 0169

		static IntPtr id_getGivenName;
		public virtual unsafe string GivenName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']/method[@name='getGivenName' and count(parameter)=0]"
			[Register ("getGivenName", "()Ljava/lang/String;", "GetGetGivenNameHandler")]
			get {
				if (id_getGivenName == IntPtr.Zero)
					id_getGivenName = JNIEnv.GetMethodID (class_ref, "getGivenName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGivenName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGivenName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHonorificPrefix;
#pragma warning disable 0169
		static Delegate GetGetHonorificPrefixHandler ()
		{
			if (cb_getHonorificPrefix == null)
				cb_getHonorificPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHonorificPrefix);
			return cb_getHonorificPrefix;
		}

		static IntPtr n_GetHonorificPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASName __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HonorificPrefix);
		}
#pragma warning restore 0169

		static IntPtr id_getHonorificPrefix;
		public virtual unsafe string HonorificPrefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']/method[@name='getHonorificPrefix' and count(parameter)=0]"
			[Register ("getHonorificPrefix", "()Ljava/lang/String;", "GetGetHonorificPrefixHandler")]
			get {
				if (id_getHonorificPrefix == IntPtr.Zero)
					id_getHonorificPrefix = JNIEnv.GetMethodID (class_ref, "getHonorificPrefix", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHonorificPrefix), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHonorificPrefix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHonorificSuffix;
#pragma warning disable 0169
		static Delegate GetGetHonorificSuffixHandler ()
		{
			if (cb_getHonorificSuffix == null)
				cb_getHonorificSuffix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHonorificSuffix);
			return cb_getHonorificSuffix;
		}

		static IntPtr n_GetHonorificSuffix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASName __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HonorificSuffix);
		}
#pragma warning restore 0169

		static IntPtr id_getHonorificSuffix;
		public virtual unsafe string HonorificSuffix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']/method[@name='getHonorificSuffix' and count(parameter)=0]"
			[Register ("getHonorificSuffix", "()Ljava/lang/String;", "GetGetHonorificSuffixHandler")]
			get {
				if (id_getHonorificSuffix == IntPtr.Zero)
					id_getHonorificSuffix = JNIEnv.GetMethodID (class_ref, "getHonorificSuffix", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHonorificSuffix), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHonorificSuffix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMiddleName;
#pragma warning disable 0169
		static Delegate GetGetMiddleNameHandler ()
		{
			if (cb_getMiddleName == null)
				cb_getMiddleName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMiddleName);
			return cb_getMiddleName;
		}

		static IntPtr n_GetMiddleName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASName __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MiddleName);
		}
#pragma warning restore 0169

		static IntPtr id_getMiddleName;
		public virtual unsafe string MiddleName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']/method[@name='getMiddleName' and count(parameter)=0]"
			[Register ("getMiddleName", "()Ljava/lang/String;", "GetGetMiddleNameHandler")]
			get {
				if (id_getMiddleName == IntPtr.Zero)
					id_getMiddleName = JNIEnv.GetMethodID (class_ref, "getMiddleName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMiddleName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMiddleName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Identity.User.MASName __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jobj = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jobj, JniHandleOwnership.DoNotTransfer);
			__this.Populate (jobj);
		}
#pragma warning restore 0169

		static IntPtr id_populate_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASName']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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
