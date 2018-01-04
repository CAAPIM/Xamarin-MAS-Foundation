using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASAuthCredentialsPassword", DoNotGenerateAcw=true)]
	public partial class MASAuthCredentialsPassword : global::Java.Lang.Object, global::Com.CA.Mas.Foundation.IMASAuthCredentials {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.ca.mas.foundation.MASAuthCredentials

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']/field[@name='REGISTRATION_TYPE']"
			[Register ("REGISTRATION_TYPE")]
			public const string RegistrationType = (string) "registration_type";
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASAuthCredentialsPassword", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASAuthCredentialsPassword); }
		}

		protected MASAuthCredentialsPassword (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_arrayC;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/constructor[@name='MASAuthCredentialsPassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char[]']]"
		[Register (".ctor", "(Ljava/lang/String;[C)V", "")]
		public unsafe MASAuthCredentialsPassword (string username, char[] password)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_username = JNIEnv.NewString (username);
			IntPtr native_password = JNIEnv.NewArray (password);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_username);
				__args [1] = new JValue (native_password);
				if (((object) this).GetType () != typeof (MASAuthCredentialsPassword)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;[C)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;[C)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_arrayC == IntPtr.Zero)
					id_ctor_Ljava_lang_String_arrayC = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[C)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayC, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_arrayC, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_username);
				if (password != null) {
					JNIEnv.CopyArray (native_password, password);
					JNIEnv.DeleteLocalRef (native_password);
				}
			}
		}

		static Delegate cb_getGrantType;
#pragma warning disable 0169
		static Delegate GetGetGrantTypeHandler ()
		{
			if (cb_getGrantType == null)
				cb_getGrantType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGrantType);
			return cb_getGrantType;
		}

		static IntPtr n_GetGrantType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GrantType);
		}
#pragma warning restore 0169

		static IntPtr id_getGrantType;
		public virtual unsafe string GrantType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/method[@name='getGrantType' and count(parameter)=0]"
			[Register ("getGrantType", "()Ljava/lang/String;", "GetGetGrantTypeHandler")]
			get {
				if (id_getGrantType == IntPtr.Zero)
					id_getGrantType = JNIEnv.GetMethodID (class_ref, "getGrantType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGrantType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGrantType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isReusable;
#pragma warning disable 0169
		static Delegate GetIsReusableHandler ()
		{
			if (cb_isReusable == null)
				cb_isReusable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReusable);
			return cb_isReusable;
		}

		static bool n_IsReusable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReusable;
		}
#pragma warning restore 0169

		static IntPtr id_isReusable;
		public virtual unsafe bool IsReusable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/method[@name='isReusable' and count(parameter)=0]"
			[Register ("isReusable", "()Z", "GetIsReusableHandler")]
			get {
				if (id_isReusable == IntPtr.Zero)
					id_isReusable = JNIEnv.GetMethodID (class_ref, "isReusable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReusable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReusable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getUsername;
#pragma warning disable 0169
		static Delegate GetGetUsernameHandler ()
		{
			if (cb_getUsername == null)
				cb_getUsername = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsername);
			return cb_getUsername;
		}

		static IntPtr n_GetUsername (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		static IntPtr id_getUsername;
		public virtual unsafe string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler")]
			get {
				if (id_getUsername == IntPtr.Zero)
					id_getUsername = JNIEnv.GetMethodID (class_ref, "getUsername", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsername), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsername", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_canRegisterDevice;
#pragma warning disable 0169
		static Delegate GetCanRegisterDeviceHandler ()
		{
			if (cb_canRegisterDevice == null)
				cb_canRegisterDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanRegisterDevice);
			return cb_canRegisterDevice;
		}

		static bool n_CanRegisterDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanRegisterDevice ();
		}
#pragma warning restore 0169

		static IntPtr id_canRegisterDevice;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/method[@name='canRegisterDevice' and count(parameter)=0]"
		[Register ("canRegisterDevice", "()Z", "GetCanRegisterDeviceHandler")]
		public virtual unsafe bool CanRegisterDevice ()
		{
			if (id_canRegisterDevice == IntPtr.Zero)
				id_canRegisterDevice = JNIEnv.GetMethodID (class_ref, "canRegisterDevice", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canRegisterDevice);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canRegisterDevice", "()Z"));
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getHeaders_Lcom_ca_mas_core_context_MssoContext_;
#pragma warning disable 0169
		static Delegate GetGetHeaders_Lcom_ca_mas_core_context_MssoContext_Handler ()
		{
			if (cb_getHeaders_Lcom_ca_mas_core_context_MssoContext_ == null)
				cb_getHeaders_Lcom_ca_mas_core_context_MssoContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHeaders_Lcom_ca_mas_core_context_MssoContext_);
			return cb_getHeaders_Lcom_ca_mas_core_context_MssoContext_;
		}

		static IntPtr n_GetHeaders_Lcom_ca_mas_core_context_MssoContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Context.MssoContext context = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.GetHeaders (context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/method[@name='getHeaders' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register ("getHeaders", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/util/Map;", "GetGetHeaders_Lcom_ca_mas_core_context_MssoContext_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> GetHeaders (global::Com.CA.Mas.Core.Context.MssoContext context)
		{
			if (id_getHeaders_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
				id_getHeaders_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "getHeaders", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders_Lcom_ca_mas_core_context_MssoContext_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getParams_Lcom_ca_mas_core_context_MssoContext_;
#pragma warning disable 0169
		static Delegate GetGetParams_Lcom_ca_mas_core_context_MssoContext_Handler ()
		{
			if (cb_getParams_Lcom_ca_mas_core_context_MssoContext_ == null)
				cb_getParams_Lcom_ca_mas_core_context_MssoContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParams_Lcom_ca_mas_core_context_MssoContext_);
			return cb_getParams_Lcom_ca_mas_core_context_MssoContext_;
		}

		static IntPtr n_GetParams_Lcom_ca_mas_core_context_MssoContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Context.MssoContext config = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (native_config, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.GetParams (config));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getParams_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/method[@name='getParams' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register ("getParams", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/util/List;", "GetGetParams_Lcom_ca_mas_core_context_MssoContext_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> GetParams (global::Com.CA.Mas.Core.Context.MssoContext config)
		{
			if (id_getParams_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
				id_getParams_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "getParams", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (config);

				global::System.Collections.Generic.IList<global::Android.Util.Pair> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParams_Lcom_ca_mas_core_context_MssoContext_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParams", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthCredentialsPassword> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthCredentialsPassword']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
