using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']"
	[global::Android.Runtime.Register ("com/ca/mas/messaging/MASMessage", DoNotGenerateAcw=true)]
	public partial class MASMessage : global::Java.Lang.Object, global::Android.OS.IParcelable, global::Com.CA.Mas.Messaging.IMASPayload {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/ca/mas/messaging/MASMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASMessage); }
		}

		protected MASMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/constructor[@name='MASMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASMessage)) {
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

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/constructor[@name='MASMessage' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe MASMessage (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (MASMessage)) {
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

		static Delegate cb_getContentEncoding;
#pragma warning disable 0169
		static Delegate GetGetContentEncodingHandler ()
		{
			if (cb_getContentEncoding == null)
				cb_getContentEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentEncoding);
			return cb_getContentEncoding;
		}

		static IntPtr n_GetContentEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentEncoding);
		}
#pragma warning restore 0169

		static Delegate cb_setContentEncoding_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentEncoding_Ljava_lang_String_Handler ()
		{
			if (cb_setContentEncoding_Ljava_lang_String_ == null)
				cb_setContentEncoding_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentEncoding_Ljava_lang_String_);
			return cb_setContentEncoding_Ljava_lang_String_;
		}

		static void n_SetContentEncoding_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encoding)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string encoding = JNIEnv.GetString (native_encoding, JniHandleOwnership.DoNotTransfer);
			__this.ContentEncoding = encoding;
		}
#pragma warning restore 0169

		static IntPtr id_getContentEncoding;
		static IntPtr id_setContentEncoding_Ljava_lang_String_;
		public virtual unsafe string ContentEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='getContentEncoding' and count(parameter)=0]"
			[Register ("getContentEncoding", "()Ljava/lang/String;", "GetGetContentEncodingHandler")]
			get {
				if (id_getContentEncoding == IntPtr.Zero)
					id_getContentEncoding = JNIEnv.GetMethodID (class_ref, "getContentEncoding", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentEncoding), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentEncoding", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setContentEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentEncoding", "(Ljava/lang/String;)V", "GetSetContentEncoding_Ljava_lang_String_Handler")]
			set {
				if (id_setContentEncoding_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentEncoding_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentEncoding", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentEncoding_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentEncoding", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static Delegate cb_setContentType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentType_Ljava_lang_String_Handler ()
		{
			if (cb_setContentType_Ljava_lang_String_ == null)
				cb_setContentType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentType_Ljava_lang_String_);
			return cb_setContentType_Ljava_lang_String_;
		}

		static void n_SetContentType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentType)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string contentType = JNIEnv.GetString (native_contentType, JniHandleOwnership.DoNotTransfer);
			__this.ContentType = contentType;
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		static IntPtr id_setContentType_Ljava_lang_String_;
		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentType", "(Ljava/lang/String;)V", "GetSetContentType_Ljava_lang_String_Handler")]
			set {
				if (id_setContentType_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayName;
		public virtual unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDuplicate;
#pragma warning disable 0169
		static Delegate GetIsDuplicateHandler ()
		{
			if (cb_isDuplicate == null)
				cb_isDuplicate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDuplicate);
			return cb_isDuplicate;
		}

		static bool n_IsDuplicate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duplicate;
		}
#pragma warning restore 0169

		static Delegate cb_setDuplicate_Z;
#pragma warning disable 0169
		static Delegate GetSetDuplicate_ZHandler ()
		{
			if (cb_setDuplicate_Z == null)
				cb_setDuplicate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDuplicate_Z);
			return cb_setDuplicate_Z;
		}

		static void n_SetDuplicate_Z (IntPtr jnienv, IntPtr native__this, bool isDuplicate)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duplicate = isDuplicate;
		}
#pragma warning restore 0169

		static IntPtr id_isDuplicate;
		static IntPtr id_setDuplicate_Z;
		public virtual unsafe bool Duplicate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='isDuplicate' and count(parameter)=0]"
			[Register ("isDuplicate", "()Z", "GetIsDuplicateHandler")]
			get {
				if (id_isDuplicate == IntPtr.Zero)
					id_isDuplicate = JNIEnv.GetMethodID (class_ref, "isDuplicate", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDuplicate);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDuplicate", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setDuplicate' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDuplicate", "(Z)V", "GetSetDuplicate_ZHandler")]
			set {
				if (id_setDuplicate_Z == IntPtr.Zero)
					id_setDuplicate_Z = JNIEnv.GetMethodID (class_ref, "setDuplicate", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDuplicate_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuplicate", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getQos;
#pragma warning disable 0169
		static Delegate GetGetQosHandler ()
		{
			if (cb_getQos == null)
				cb_getQos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetQos);
			return cb_getQos;
		}

		static int n_GetQos (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qos;
		}
#pragma warning restore 0169

		static Delegate cb_setQos_I;
#pragma warning disable 0169
		static Delegate GetSetQos_IHandler ()
		{
			if (cb_setQos_I == null)
				cb_setQos_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetQos_I);
			return cb_setQos_I;
		}

		static void n_SetQos_I (IntPtr jnienv, IntPtr native__this, int qos)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Qos = qos;
		}
#pragma warning restore 0169

		static IntPtr id_getQos;
		static IntPtr id_setQos_I;
		public virtual unsafe int Qos {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='getQos' and count(parameter)=0]"
			[Register ("getQos", "()I", "GetGetQosHandler")]
			get {
				if (id_getQos == IntPtr.Zero)
					id_getQos = JNIEnv.GetMethodID (class_ref, "getQos", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getQos);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQos", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setQos' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setQos", "(I)V", "GetSetQos_IHandler")]
			set {
				if (id_setQos_I == IntPtr.Zero)
					id_setQos_I = JNIEnv.GetMethodID (class_ref, "setQos", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQos_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQos", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRetained;
#pragma warning disable 0169
		static Delegate GetIsRetainedHandler ()
		{
			if (cb_isRetained == null)
				cb_isRetained = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRetained);
			return cb_isRetained;
		}

		static bool n_IsRetained (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Retained;
		}
#pragma warning restore 0169

		static Delegate cb_setRetained_Z;
#pragma warning disable 0169
		static Delegate GetSetRetained_ZHandler ()
		{
			if (cb_setRetained_Z == null)
				cb_setRetained_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRetained_Z);
			return cb_setRetained_Z;
		}

		static void n_SetRetained_Z (IntPtr jnienv, IntPtr native__this, bool isRetained)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retained = isRetained;
		}
#pragma warning restore 0169

		static IntPtr id_isRetained;
		static IntPtr id_setRetained_Z;
		public virtual unsafe bool Retained {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='isRetained' and count(parameter)=0]"
			[Register ("isRetained", "()Z", "GetIsRetainedHandler")]
			get {
				if (id_isRetained == IntPtr.Zero)
					id_isRetained = JNIEnv.GetMethodID (class_ref, "isRetained", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRetained);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRetained", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setRetained' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRetained", "(Z)V", "GetSetRetained_ZHandler")]
			set {
				if (id_setRetained_Z == IntPtr.Zero)
					id_setRetained_Z = JNIEnv.GetMethodID (class_ref, "setRetained", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRetained_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRetained", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSenderId;
#pragma warning disable 0169
		static Delegate GetGetSenderIdHandler ()
		{
			if (cb_getSenderId == null)
				cb_getSenderId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSenderId);
			return cb_getSenderId;
		}

		static IntPtr n_GetSenderId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SenderId);
		}
#pragma warning restore 0169

		static Delegate cb_setSenderId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSenderId_Ljava_lang_String_Handler ()
		{
			if (cb_setSenderId_Ljava_lang_String_ == null)
				cb_setSenderId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSenderId_Ljava_lang_String_);
			return cb_setSenderId_Ljava_lang_String_;
		}

		static void n_SetSenderId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_senderId)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string senderId = JNIEnv.GetString (native_senderId, JniHandleOwnership.DoNotTransfer);
			__this.SenderId = senderId;
		}
#pragma warning restore 0169

		static IntPtr id_getSenderId;
		static IntPtr id_setSenderId_Ljava_lang_String_;
		public virtual unsafe string SenderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='getSenderId' and count(parameter)=0]"
			[Register ("getSenderId", "()Ljava/lang/String;", "GetGetSenderIdHandler")]
			get {
				if (id_getSenderId == IntPtr.Zero)
					id_getSenderId = JNIEnv.GetMethodID (class_ref, "getSenderId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSenderId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSenderId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setSenderId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSenderId", "(Ljava/lang/String;)V", "GetSetSenderId_Ljava_lang_String_Handler")]
			set {
				if (id_setSenderId_Ljava_lang_String_ == IntPtr.Zero)
					id_setSenderId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSenderId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSenderId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSenderId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSenderType;
#pragma warning disable 0169
		static Delegate GetGetSenderTypeHandler ()
		{
			if (cb_getSenderType == null)
				cb_getSenderType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSenderType);
			return cb_getSenderType;
		}

		static IntPtr n_GetSenderType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SenderType);
		}
#pragma warning restore 0169

		static Delegate cb_setSenderType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSenderType_Ljava_lang_String_Handler ()
		{
			if (cb_setSenderType_Ljava_lang_String_ == null)
				cb_setSenderType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSenderType_Ljava_lang_String_);
			return cb_setSenderType_Ljava_lang_String_;
		}

		static void n_SetSenderType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_senderType)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string senderType = JNIEnv.GetString (native_senderType, JniHandleOwnership.DoNotTransfer);
			__this.SenderType = senderType;
		}
#pragma warning restore 0169

		static IntPtr id_getSenderType;
		static IntPtr id_setSenderType_Ljava_lang_String_;
		public virtual unsafe string SenderType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='getSenderType' and count(parameter)=0]"
			[Register ("getSenderType", "()Ljava/lang/String;", "GetGetSenderTypeHandler")]
			get {
				if (id_getSenderType == IntPtr.Zero)
					id_getSenderType = JNIEnv.GetMethodID (class_ref, "getSenderType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSenderType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSenderType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setSenderType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSenderType", "(Ljava/lang/String;)V", "GetSetSenderType_Ljava_lang_String_Handler")]
			set {
				if (id_setSenderType_Ljava_lang_String_ == IntPtr.Zero)
					id_setSenderType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSenderType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSenderType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSenderType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSentTime;
#pragma warning disable 0169
		static Delegate GetGetSentTimeHandler ()
		{
			if (cb_getSentTime == null)
				cb_getSentTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSentTime);
			return cb_getSentTime;
		}

		static long n_GetSentTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SentTime;
		}
#pragma warning restore 0169

		static Delegate cb_setSentTime_J;
#pragma warning disable 0169
		static Delegate GetSetSentTime_JHandler ()
		{
			if (cb_setSentTime_J == null)
				cb_setSentTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSentTime_J);
			return cb_setSentTime_J;
		}

		static void n_SetSentTime_J (IntPtr jnienv, IntPtr native__this, long sentTime)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SentTime = sentTime;
		}
#pragma warning restore 0169

		static IntPtr id_getSentTime;
		static IntPtr id_setSentTime_J;
		public virtual unsafe long SentTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='getSentTime' and count(parameter)=0]"
			[Register ("getSentTime", "()J", "GetGetSentTimeHandler")]
			get {
				if (id_getSentTime == IntPtr.Zero)
					id_getSentTime = JNIEnv.GetMethodID (class_ref, "getSentTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSentTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setSentTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSentTime", "(J)V", "GetSetSentTime_JHandler")]
			set {
				if (id_setSentTime_J == IntPtr.Zero)
					id_setSentTime_J = JNIEnv.GetMethodID (class_ref, "setSentTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSentTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSentTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTopic;
#pragma warning disable 0169
		static Delegate GetGetTopicHandler ()
		{
			if (cb_getTopic == null)
				cb_getTopic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopic);
			return cb_getTopic;
		}

		static IntPtr n_GetTopic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Topic);
		}
#pragma warning restore 0169

		static Delegate cb_setTopic_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTopic_Ljava_lang_String_Handler ()
		{
			if (cb_setTopic_Ljava_lang_String_ == null)
				cb_setTopic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTopic_Ljava_lang_String_);
			return cb_setTopic_Ljava_lang_String_;
		}

		static void n_SetTopic_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			__this.Topic = topic;
		}
#pragma warning restore 0169

		static IntPtr id_getTopic;
		static IntPtr id_setTopic_Ljava_lang_String_;
		public virtual unsafe string Topic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='getTopic' and count(parameter)=0]"
			[Register ("getTopic", "()Ljava/lang/String;", "GetGetTopicHandler")]
			get {
				if (id_getTopic == IntPtr.Zero)
					id_getTopic = JNIEnv.GetMethodID (class_ref, "getTopic", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopic), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopic", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setTopic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTopic", "(Ljava/lang/String;)V", "GetSetTopic_Ljava_lang_String_Handler")]
			set {
				if (id_setTopic_Ljava_lang_String_ == IntPtr.Zero)
					id_setTopic_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTopic", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTopic_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopic", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setVersion_Ljava_lang_String_ == null)
				cb_setVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVersion_Ljava_lang_String_);
			return cb_setVersion_Ljava_lang_String_;
		}

		static void n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_version)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string version = JNIEnv.GetString (native_version, JniHandleOwnership.DoNotTransfer);
			__this.Version = version;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		static IntPtr id_setVersion_Ljava_lang_String_;
		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='getVersion' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersion", "(Ljava/lang/String;)V", "GetSetVersion_Ljava_lang_String_Handler")]
			set {
				if (id_setVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVersion_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVersion", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_createJSONStringFromMASMessage_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCreateJSONStringFromMASMessage_Landroid_content_Context_Handler ()
		{
			if (cb_createJSONStringFromMASMessage_Landroid_content_Context_ == null)
				cb_createJSONStringFromMASMessage_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateJSONStringFromMASMessage_Landroid_content_Context_);
			return cb_createJSONStringFromMASMessage_Landroid_content_Context_;
		}

		static IntPtr n_CreateJSONStringFromMASMessage_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.CreateJSONStringFromMASMessage (context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createJSONStringFromMASMessage_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='createJSONStringFromMASMessage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createJSONStringFromMASMessage", "(Landroid/content/Context;)Ljava/lang/String;", "GetCreateJSONStringFromMASMessage_Landroid_content_Context_Handler")]
		public virtual unsafe string CreateJSONStringFromMASMessage (global::Android.Content.Context context)
		{
			if (id_createJSONStringFromMASMessage_Landroid_content_Context_ == IntPtr.Zero)
				id_createJSONStringFromMASMessage_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "createJSONStringFromMASMessage", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createJSONStringFromMASMessage_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createJSONStringFromMASMessage", "(Landroid/content/Context;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createMASMessageFromJSONString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateMASMessageFromJSONString_Ljava_lang_String_Handler ()
		{
			if (cb_createMASMessageFromJSONString_Ljava_lang_String_ == null)
				cb_createMASMessageFromJSONString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateMASMessageFromJSONString_Ljava_lang_String_);
			return cb_createMASMessageFromJSONString_Ljava_lang_String_;
		}

		static void n_CreateMASMessageFromJSONString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonStr)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string jsonStr = JNIEnv.GetString (native_jsonStr, JniHandleOwnership.DoNotTransfer);
			__this.CreateMASMessageFromJSONString (jsonStr);
		}
#pragma warning restore 0169

		static IntPtr id_createMASMessageFromJSONString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='createMASMessageFromJSONString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createMASMessageFromJSONString", "(Ljava/lang/String;)V", "GetCreateMASMessageFromJSONString_Ljava_lang_String_Handler")]
		public virtual unsafe void CreateMASMessageFromJSONString (string jsonStr)
		{
			if (id_createMASMessageFromJSONString_Ljava_lang_String_ == IntPtr.Zero)
				id_createMASMessageFromJSONString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createMASMessageFromJSONString", "(Ljava/lang/String;)V");
			IntPtr native_jsonStr = JNIEnv.NewString (jsonStr);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_jsonStr);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createMASMessageFromJSONString_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createMASMessageFromJSONString", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonStr);
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
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getPayload;
#pragma warning disable 0169
		static Delegate GetGetPayloadHandler ()
		{
			if (cb_getPayload == null)
				cb_getPayload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayload);
			return cb_getPayload;
		}

		static IntPtr n_GetPayload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayload ());
		}
#pragma warning restore 0169

		static IntPtr id_getPayload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='getPayload' and count(parameter)=0]"
		[Register ("getPayload", "()[B", "GetGetPayloadHandler")]
		public virtual unsafe byte[] GetPayload ()
		{
			if (id_getPayload == IntPtr.Zero)
				id_getPayload = JNIEnv.GetMethodID (class_ref, "getPayload", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPayload), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPayload", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/ca/mas/messaging/MASMessage;", "")]
		public static unsafe global::Com.CA.Mas.Messaging.MASMessage NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/ca/mas/messaging/MASMessage;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newInstance_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("newInstance", "(Landroid/content/Intent;)Lcom/ca/mas/messaging/MASMessage;", "")]
		public static unsafe global::Com.CA.Mas.Messaging.MASMessage NewInstance (global::Android.Content.Intent intent)
		{
			if (id_newInstance_Landroid_content_Intent_ == IntPtr.Zero)
				id_newInstance_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Landroid/content/Intent;)Lcom/ca/mas/messaging/MASMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (intent);
				global::Com.CA.Mas.Messaging.MASMessage __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setPayload_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPayload_arrayBHandler ()
		{
			if (cb_setPayload_arrayB == null)
				cb_setPayload_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPayload_arrayB);
			return cb_setPayload_arrayB;
		}

		static void n_SetPayload_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_payload)
		{
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] payload = (byte[]) JNIEnv.GetArray (native_payload, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPayload (payload);
			if (payload != null)
				JNIEnv.CopyArray (payload, native_payload);
		}
#pragma warning restore 0169

		static IntPtr id_setPayload_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPayload", "([B)V", "GetSetPayload_arrayBHandler")]
		public virtual unsafe void SetPayload (byte[] payload)
		{
			if (id_setPayload_arrayB == IntPtr.Zero)
				id_setPayload_arrayB = JNIEnv.GetMethodID (class_ref, "setPayload", "([B)V");
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_payload);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPayload_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPayload", "([B)V"), __args);
			} finally {
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
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
			global::Com.CA.Mas.Messaging.MASMessage __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MASMessage']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
