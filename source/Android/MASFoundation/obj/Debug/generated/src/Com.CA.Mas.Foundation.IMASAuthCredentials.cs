using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	[Register ("com/ca/mas/foundation/MASAuthCredentials", DoNotGenerateAcw=true)]
	public abstract class MASAuthCredentials : Java.Lang.Object {

		internal MASAuthCredentials ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']/field[@name='REGISTRATION_TYPE']"
		[Register ("REGISTRATION_TYPE")]
		public const string RegistrationType = (string) "registration_type";

		// The following are fields from: android.os.Parcelable

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable
	}

	[Register ("com/ca/mas/foundation/MASAuthCredentials", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MASAuthCredentials' type. This type will be removed in a future release.")]
	public abstract class MASAuthCredentialsConsts : MASAuthCredentials {

		private MASAuthCredentialsConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']"
	[Register ("com/ca/mas/foundation/MASAuthCredentials", "", "Com.CA.Mas.Foundation.IMASAuthCredentialsInvoker")]
	public partial interface IMASAuthCredentials : global::Android.OS.IParcelable {

		string GrantType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']/method[@name='getGrantType' and count(parameter)=0]"
			[Register ("getGrantType", "()Ljava/lang/String;", "GetGetGrantTypeHandler:Com.CA.Mas.Foundation.IMASAuthCredentialsInvoker, MASFoundation")] get;
		}

		bool IsReusable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']/method[@name='isReusable' and count(parameter)=0]"
			[Register ("isReusable", "()Z", "GetIsReusableHandler:Com.CA.Mas.Foundation.IMASAuthCredentialsInvoker, MASFoundation")] get;
		}

		bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler:Com.CA.Mas.Foundation.IMASAuthCredentialsInvoker, MASFoundation")] get;
		}

		string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler:Com.CA.Mas.Foundation.IMASAuthCredentialsInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']/method[@name='canRegisterDevice' and count(parameter)=0]"
		[Register ("canRegisterDevice", "()Z", "GetCanRegisterDeviceHandler:Com.CA.Mas.Foundation.IMASAuthCredentialsInvoker, MASFoundation")]
		bool CanRegisterDevice ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.CA.Mas.Foundation.IMASAuthCredentialsInvoker, MASFoundation")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']/method[@name='getHeaders' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register ("getHeaders", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/util/Map;", "GetGetHeaders_Lcom_ca_mas_core_context_MssoContext_Handler:Com.CA.Mas.Foundation.IMASAuthCredentialsInvoker, MASFoundation")]
		global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> GetHeaders (global::Com.CA.Mas.Core.Context.MssoContext p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASAuthCredentials']/method[@name='getParams' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register ("getParams", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/util/List;", "GetGetParams_Lcom_ca_mas_core_context_MssoContext_Handler:Com.CA.Mas.Foundation.IMASAuthCredentialsInvoker, MASFoundation")]
		global::System.Collections.Generic.IList<global::Android.Util.Pair> GetParams (global::Com.CA.Mas.Core.Context.MssoContext p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASAuthCredentials", DoNotGenerateAcw=true)]
	internal class IMASAuthCredentialsInvoker : global::Java.Lang.Object, IMASAuthCredentials {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/MASAuthCredentials");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASAuthCredentialsInvoker); }
		}

		IntPtr class_ref;

		public static IMASAuthCredentials GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASAuthCredentials> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.MASAuthCredentials"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASAuthCredentialsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.CA.Mas.Foundation.IMASAuthCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GrantType);
		}
#pragma warning restore 0169

		IntPtr id_getGrantType;
		public unsafe string GrantType {
			get {
				if (id_getGrantType == IntPtr.Zero)
					id_getGrantType = JNIEnv.GetMethodID (class_ref, "getGrantType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGrantType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Foundation.IMASAuthCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReusable;
		}
#pragma warning restore 0169

		IntPtr id_isReusable;
		public unsafe bool IsReusable {
			get {
				if (id_isReusable == IntPtr.Zero)
					id_isReusable = JNIEnv.GetMethodID (class_ref, "isReusable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReusable);
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
			global::Com.CA.Mas.Foundation.IMASAuthCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		IntPtr id_isValid;
		public unsafe bool IsValid {
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid);
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
			global::Com.CA.Mas.Foundation.IMASAuthCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Username);
		}
#pragma warning restore 0169

		IntPtr id_getUsername;
		public unsafe string Username {
			get {
				if (id_getUsername == IntPtr.Zero)
					id_getUsername = JNIEnv.GetMethodID (class_ref, "getUsername", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsername), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Foundation.IMASAuthCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanRegisterDevice ();
		}
#pragma warning restore 0169

		IntPtr id_canRegisterDevice;
		public unsafe bool CanRegisterDevice ()
		{
			if (id_canRegisterDevice == IntPtr.Zero)
				id_canRegisterDevice = JNIEnv.GetMethodID (class_ref, "canRegisterDevice", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canRegisterDevice);
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
			global::Com.CA.Mas.Foundation.IMASAuthCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_getHeaders_Lcom_ca_mas_core_context_MssoContext_;
#pragma warning disable 0169
		static Delegate GetGetHeaders_Lcom_ca_mas_core_context_MssoContext_Handler ()
		{
			if (cb_getHeaders_Lcom_ca_mas_core_context_MssoContext_ == null)
				cb_getHeaders_Lcom_ca_mas_core_context_MssoContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHeaders_Lcom_ca_mas_core_context_MssoContext_);
			return cb_getHeaders_Lcom_ca_mas_core_context_MssoContext_;
		}

		static IntPtr n_GetHeaders_Lcom_ca_mas_core_context_MssoContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.IMASAuthCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Context.MssoContext p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.GetHeaders (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHeaders_Lcom_ca_mas_core_context_MssoContext_;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> GetHeaders (global::Com.CA.Mas.Core.Context.MssoContext p0)
		{
			if (id_getHeaders_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
				id_getHeaders_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "getHeaders", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/util/Map;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> __ret = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders_Lcom_ca_mas_core_context_MssoContext_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getParams_Lcom_ca_mas_core_context_MssoContext_;
#pragma warning disable 0169
		static Delegate GetGetParams_Lcom_ca_mas_core_context_MssoContext_Handler ()
		{
			if (cb_getParams_Lcom_ca_mas_core_context_MssoContext_ == null)
				cb_getParams_Lcom_ca_mas_core_context_MssoContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetParams_Lcom_ca_mas_core_context_MssoContext_);
			return cb_getParams_Lcom_ca_mas_core_context_MssoContext_;
		}

		static IntPtr n_GetParams_Lcom_ca_mas_core_context_MssoContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.IMASAuthCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Context.MssoContext p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.MssoContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.GetParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getParams_Lcom_ca_mas_core_context_MssoContext_;
		public unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> GetParams (global::Com.CA.Mas.Core.Context.MssoContext p0)
		{
			if (id_getParams_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
				id_getParams_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "getParams", "(Lcom/ca/mas/core/context/MssoContext;)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::System.Collections.Generic.IList<global::Android.Util.Pair> __ret = global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParams_Lcom_ca_mas_core_context_MssoContext_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.CA.Mas.Foundation.IMASAuthCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		IntPtr id_describeContents;
		public unsafe global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
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
			global::Com.CA.Mas.Foundation.IMASAuthCredentials __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASAuthCredentials> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (dest);
			__args [1] = new JValue ((int) flags);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
		}

	}

}
