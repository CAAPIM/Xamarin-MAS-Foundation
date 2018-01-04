using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/user/MASAddress", DoNotGenerateAcw=true)]
	public partial class MASAddress : global::Java.Lang.Object, global::Com.CA.Mas.Foundation.IMASTransformable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/user/MASAddress", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASAddress); }
		}

		protected MASAddress (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/constructor[@name='MASAddress' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASAddress ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASAddress)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/constructor[@name='MASAddress' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MASAddress (string streetAddr, string locality, string region, string country, string postalCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_streetAddr = JNIEnv.NewString (streetAddr);
			IntPtr native_locality = JNIEnv.NewString (locality);
			IntPtr native_region = JNIEnv.NewString (region);
			IntPtr native_country = JNIEnv.NewString (country);
			IntPtr native_postalCode = JNIEnv.NewString (postalCode);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_streetAddr);
				__args [1] = new JValue (native_locality);
				__args [2] = new JValue (native_region);
				__args [3] = new JValue (native_country);
				__args [4] = new JValue (native_postalCode);
				if (((object) this).GetType () != typeof (MASAddress)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_streetAddr);
				JNIEnv.DeleteLocalRef (native_locality);
				JNIEnv.DeleteLocalRef (native_region);
				JNIEnv.DeleteLocalRef (native_country);
				JNIEnv.DeleteLocalRef (native_postalCode);
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
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJSONObject);
		}
#pragma warning restore 0169

		static IntPtr id_getAsJSONObject;
		public virtual unsafe global::Org.Json.JSONObject AsJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='getAsJSONObject' and count(parameter)=0]"
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

		static Delegate cb_getCountry;
#pragma warning disable 0169
		static Delegate GetGetCountryHandler ()
		{
			if (cb_getCountry == null)
				cb_getCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountry);
			return cb_getCountry;
		}

		static IntPtr n_GetCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Country);
		}
#pragma warning restore 0169

		static Delegate cb_setCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setCountry_Ljava_lang_String_ == null)
				cb_setCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountry_Ljava_lang_String_);
			return cb_setCountry_Ljava_lang_String_;
		}

		static void n_SetCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_country)
		{
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string country = JNIEnv.GetString (native_country, JniHandleOwnership.DoNotTransfer);
			__this.Country = country;
		}
#pragma warning restore 0169

		static IntPtr id_getCountry;
		static IntPtr id_setCountry_Ljava_lang_String_;
		public virtual unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				if (id_getCountry == IntPtr.Zero)
					id_getCountry = JNIEnv.GetMethodID (class_ref, "getCountry", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCountry), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCountry", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='setCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountry", "(Ljava/lang/String;)V", "GetSetCountry_Ljava_lang_String_Handler")]
			set {
				if (id_setCountry_Ljava_lang_String_ == IntPtr.Zero)
					id_setCountry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCountry", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCountry_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCountry", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Formatted);
		}
#pragma warning restore 0169

		static IntPtr id_getFormatted;
		public virtual unsafe string Formatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='getFormatted' and count(parameter)=0]"
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

		static Delegate cb_isPrimary;
#pragma warning disable 0169
		static Delegate GetIsPrimaryHandler ()
		{
			if (cb_isPrimary == null)
				cb_isPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPrimary);
			return cb_isPrimary;
		}

		static bool n_IsPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrimary;
		}
#pragma warning restore 0169

		static IntPtr id_isPrimary;
		public virtual unsafe bool IsPrimary {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='isPrimary' and count(parameter)=0]"
			[Register ("isPrimary", "()Z", "GetIsPrimaryHandler")]
			get {
				if (id_isPrimary == IntPtr.Zero)
					id_isPrimary = JNIEnv.GetMethodID (class_ref, "isPrimary", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPrimary);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPrimary", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLocality;
#pragma warning disable 0169
		static Delegate GetGetLocalityHandler ()
		{
			if (cb_getLocality == null)
				cb_getLocality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocality);
			return cb_getLocality;
		}

		static IntPtr n_GetLocality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Locality);
		}
#pragma warning restore 0169

		static IntPtr id_getLocality;
		public virtual unsafe string Locality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='getLocality' and count(parameter)=0]"
			[Register ("getLocality", "()Ljava/lang/String;", "GetGetLocalityHandler")]
			get {
				if (id_getLocality == IntPtr.Zero)
					id_getLocality = JNIEnv.GetMethodID (class_ref, "getLocality", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocality), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocality", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPostalCode;
#pragma warning disable 0169
		static Delegate GetGetPostalCodeHandler ()
		{
			if (cb_getPostalCode == null)
				cb_getPostalCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostalCode);
			return cb_getPostalCode;
		}

		static IntPtr n_GetPostalCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PostalCode);
		}
#pragma warning restore 0169

		static IntPtr id_getPostalCode;
		public virtual unsafe string PostalCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='getPostalCode' and count(parameter)=0]"
			[Register ("getPostalCode", "()Ljava/lang/String;", "GetGetPostalCodeHandler")]
			get {
				if (id_getPostalCode == IntPtr.Zero)
					id_getPostalCode = JNIEnv.GetMethodID (class_ref, "getPostalCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPostalCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPostalCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRegion;
#pragma warning disable 0169
		static Delegate GetGetRegionHandler ()
		{
			if (cb_getRegion == null)
				cb_getRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegion);
			return cb_getRegion;
		}

		static IntPtr n_GetRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Region);
		}
#pragma warning restore 0169

		static IntPtr id_getRegion;
		public virtual unsafe string Region {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='getRegion' and count(parameter)=0]"
			[Register ("getRegion", "()Ljava/lang/String;", "GetGetRegionHandler")]
			get {
				if (id_getRegion == IntPtr.Zero)
					id_getRegion = JNIEnv.GetMethodID (class_ref, "getRegion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStreetAddress;
#pragma warning disable 0169
		static Delegate GetGetStreetAddressHandler ()
		{
			if (cb_getStreetAddress == null)
				cb_getStreetAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreetAddress);
			return cb_getStreetAddress;
		}

		static IntPtr n_GetStreetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StreetAddress);
		}
#pragma warning restore 0169

		static IntPtr id_getStreetAddress;
		public virtual unsafe string StreetAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='getStreetAddress' and count(parameter)=0]"
			[Register ("getStreetAddress", "()Ljava/lang/String;", "GetGetStreetAddressHandler")]
			get {
				if (id_getStreetAddress == IntPtr.Zero)
					id_getStreetAddress = JNIEnv.GetMethodID (class_ref, "getStreetAddress", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreetAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreetAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='getType' and count(parameter)=0]"
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

		static Delegate cb_populate_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetPopulate_Lorg_json_JSONObject_Handler ()
		{
			if (cb_populate_Lorg_json_JSONObject_ == null)
				cb_populate_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Populate_Lorg_json_JSONObject_);
			return cb_populate_Lorg_json_JSONObject_;
		}

		static void n_Populate_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_addrObj)
		{
			global::Com.CA.Mas.Identity.User.MASAddress __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject addrObj = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_addrObj, JniHandleOwnership.DoNotTransfer);
			__this.Populate (addrObj);
		}
#pragma warning restore 0169

		static IntPtr id_populate_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASAddress']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("populate", "(Lorg/json/JSONObject;)V", "GetPopulate_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Populate (global::Org.Json.JSONObject addrObj)
		{
			if (id_populate_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_populate_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "populate", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (addrObj);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_populate_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "populate", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}
}
