using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASOtpAuthenticationHandler", DoNotGenerateAcw=true)]
	public partial class MASOtpAuthenticationHandler : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASOtpAuthenticationHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASOtpAuthenticationHandler); }
		}

		protected MASOtpAuthenticationHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']/constructor[@name='MASOtpAuthenticationHandler' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe MASOtpAuthenticationHandler (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (MASOtpAuthenticationHandler)) {
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

		static IntPtr id_ctor_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']/constructor[@name='MASOtpAuthenticationHandler' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.auth.otp.OtpAuthenticationHandler']]"
		[Register (".ctor", "(Lcom/ca/mas/core/auth/otp/OtpAuthenticationHandler;)V", "")]
		public unsafe MASOtpAuthenticationHandler (global::Com.CA.Mas.Core.Auth.Otp.OtpAuthenticationHandler handler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (handler);
				if (((object) this).GetType () != typeof (MASOtpAuthenticationHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/core/auth/otp/OtpAuthenticationHandler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/core/auth/otp/OtpAuthenticationHandler;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/core/auth/otp/OtpAuthenticationHandler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_core_auth_otp_OtpAuthenticationHandler_, __args);
			} finally {
			}
		}

		static Delegate cb_getChannels;
#pragma warning disable 0169
		static Delegate GetGetChannelsHandler ()
		{
			if (cb_getChannels == null)
				cb_getChannels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannels);
			return cb_getChannels;
		}

		static IntPtr n_GetChannels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Channels);
		}
#pragma warning restore 0169

		static IntPtr id_getChannels;
		public virtual unsafe global::System.Collections.Generic.IList<string> Channels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']/method[@name='getChannels' and count(parameter)=0]"
			[Register ("getChannels", "()Ljava/util/List;", "GetGetChannelsHandler")]
			get {
				if (id_getChannels == IntPtr.Zero)
					id_getChannels = JNIEnv.GetMethodID (class_ref, "getChannels", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannels), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannels", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isInvalidOtp;
#pragma warning disable 0169
		static Delegate GetIsInvalidOtpHandler ()
		{
			if (cb_isInvalidOtp == null)
				cb_isInvalidOtp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInvalidOtp);
			return cb_isInvalidOtp;
		}

		static bool n_IsInvalidOtp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInvalidOtp;
		}
#pragma warning restore 0169

		static IntPtr id_isInvalidOtp;
		public virtual unsafe bool IsInvalidOtp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']/method[@name='isInvalidOtp' and count(parameter)=0]"
			[Register ("isInvalidOtp", "()Z", "GetIsInvalidOtpHandler")]
			get {
				if (id_isInvalidOtp == IntPtr.Zero)
					id_isInvalidOtp = JNIEnv.GetMethodID (class_ref, "isInvalidOtp", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInvalidOtp);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInvalidOtp", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_deliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetDeliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_deliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_deliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Deliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_);
			return cb_deliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_Deliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channel, IntPtr native__callback)
		{
			global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string channel = JNIEnv.GetString (native_channel, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback @callback = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Deliver (channel, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_deliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']/method[@name='deliver' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("deliver", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetDeliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public virtual unsafe void Deliver (string channel, global::Com.CA.Mas.Foundation.MASCallback @callback)
		{
			if (id_deliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_deliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "deliver", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_channel = JNIEnv.NewString (channel);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_channel);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deliver_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliver", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_channel);
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
			global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_proceed_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProceed_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_proceed_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_proceed_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Proceed_Landroid_content_Context_Ljava_lang_String_);
			return cb_proceed_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_Proceed_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_otp)
		{
			global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string otp = JNIEnv.GetString (native_otp, JniHandleOwnership.DoNotTransfer);
			__this.Proceed (context, otp);
		}
#pragma warning restore 0169

		static IntPtr id_proceed_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']/method[@name='proceed' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("proceed", "(Landroid/content/Context;Ljava/lang/String;)V", "GetProceed_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void Proceed (global::Android.Content.Context context, string otp)
		{
			if (id_proceed_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_proceed_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "proceed", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_otp = JNIEnv.NewString (otp);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_otp);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_proceed_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "proceed", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_otp);
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
			global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASOtpAuthenticationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASOtpAuthenticationHandler']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
