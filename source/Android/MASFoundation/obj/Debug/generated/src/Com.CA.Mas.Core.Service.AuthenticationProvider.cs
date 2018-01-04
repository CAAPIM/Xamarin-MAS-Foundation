using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']"
	[global::Android.Runtime.Register ("com/ca/mas/core/service/AuthenticationProvider", DoNotGenerateAcw=true)]
	public partial class AuthenticationProvider : global::Java.Lang.Object, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']/field[@name='ALL']"
		[Register ("ALL")]
		public const string All = (string) "all";

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']/field[@name='ENTERPRISE']"
		[Register ("ENTERPRISE")]
		public const string Enterprise = (string) "enterprise";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/service/AuthenticationProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthenticationProvider); }
		}

		protected AuthenticationProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']/constructor[@name='AuthenticationProvider' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe AuthenticationProvider (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (AuthenticationProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']/constructor[@name='AuthenticationProvider' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.ca.mas.core.service.Provider&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe AuthenticationProvider (string idp, global::System.Collections.Generic.IList<global::Com.CA.Mas.Core.Service.Provider> providers)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_idp = JNIEnv.NewString (idp);
			IntPtr native_providers = global::Android.Runtime.JavaList<global::Com.CA.Mas.Core.Service.Provider>.ToLocalJniHandle (providers);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_idp);
				__args [1] = new JValue (native_providers);
				if (((object) this).GetType () != typeof (AuthenticationProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_idp);
				JNIEnv.DeleteLocalRef (native_providers);
			}
		}

		static Delegate cb_getIdp;
#pragma warning disable 0169
		static Delegate GetGetIdpHandler ()
		{
			if (cb_getIdp == null)
				cb_getIdp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdp);
			return cb_getIdp;
		}

		static IntPtr n_GetIdp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Service.AuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.AuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Idp);
		}
#pragma warning restore 0169

		static IntPtr id_getIdp;
		public virtual unsafe string Idp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']/method[@name='getIdp' and count(parameter)=0]"
			[Register ("getIdp", "()Ljava/lang/String;", "GetGetIdpHandler")]
			get {
				if (id_getIdp == IntPtr.Zero)
					id_getIdp = JNIEnv.GetMethodID (class_ref, "getIdp", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdp), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdp", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEnterpriseEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnterpriseEnabledHandler ()
		{
			if (cb_isEnterpriseEnabled == null)
				cb_isEnterpriseEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnterpriseEnabled);
			return cb_isEnterpriseEnabled;
		}

		static bool n_IsEnterpriseEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Service.AuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.AuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnterpriseEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isEnterpriseEnabled;
		public virtual unsafe bool IsEnterpriseEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']/method[@name='isEnterpriseEnabled' and count(parameter)=0]"
			[Register ("isEnterpriseEnabled", "()Z", "GetIsEnterpriseEnabledHandler")]
			get {
				if (id_isEnterpriseEnabled == IntPtr.Zero)
					id_isEnterpriseEnabled = JNIEnv.GetMethodID (class_ref, "isEnterpriseEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnterpriseEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnterpriseEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getProviders;
#pragma warning disable 0169
		static Delegate GetGetProvidersHandler ()
		{
			if (cb_getProviders == null)
				cb_getProviders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProviders);
			return cb_getProviders;
		}

		static IntPtr n_GetProviders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Service.AuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.AuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Core.Service.Provider>.ToLocalJniHandle (__this.Providers);
		}
#pragma warning restore 0169

		static IntPtr id_getProviders;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Core.Service.Provider> Providers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']/method[@name='getProviders' and count(parameter)=0]"
			[Register ("getProviders", "()Ljava/util/List;", "GetGetProvidersHandler")]
			get {
				if (id_getProviders == IntPtr.Zero)
					id_getProviders = JNIEnv.GetMethodID (class_ref, "getProviders", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.CA.Mas.Core.Service.Provider>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProviders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.CA.Mas.Core.Service.Provider>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProviders", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.CA.Mas.Core.Service.AuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.AuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.CA.Mas.Core.Service.AuthenticationProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Service.AuthenticationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.service']/class[@name='AuthenticationProvider']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
