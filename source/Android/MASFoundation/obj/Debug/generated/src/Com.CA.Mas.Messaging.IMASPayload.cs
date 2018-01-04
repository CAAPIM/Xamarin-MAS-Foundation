using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Messaging {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']"
	[Register ("com/ca/mas/messaging/MASPayload", "", "Com.CA.Mas.Messaging.IMASPayloadInvoker")]
	public partial interface IMASPayload : IJavaObject {

		string ContentEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='getContentEncoding' and count(parameter)=0]"
			[Register ("getContentEncoding", "()Ljava/lang/String;", "GetGetContentEncodingHandler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='setContentEncoding' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentEncoding", "(Ljava/lang/String;)V", "GetSetContentEncoding_Ljava_lang_String_Handler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] set;
		}

		string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentType", "(Ljava/lang/String;)V", "GetSetContentType_Ljava_lang_String_Handler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] set;
		}

		string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] get;
		}

		string SenderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='getSenderId' and count(parameter)=0]"
			[Register ("getSenderId", "()Ljava/lang/String;", "GetGetSenderIdHandler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='setSenderId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSenderId", "(Ljava/lang/String;)V", "GetSetSenderId_Ljava_lang_String_Handler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] set;
		}

		string SenderType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='getSenderType' and count(parameter)=0]"
			[Register ("getSenderType", "()Ljava/lang/String;", "GetGetSenderTypeHandler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='setSenderType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSenderType", "(Ljava/lang/String;)V", "GetSetSenderType_Ljava_lang_String_Handler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] set;
		}

		long SentTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='getSentTime' and count(parameter)=0]"
			[Register ("getSentTime", "()J", "GetGetSentTimeHandler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='setSentTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSentTime", "(J)V", "GetSetSentTime_JHandler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] set;
		}

		string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersion", "(Ljava/lang/String;)V", "GetSetVersion_Ljava_lang_String_Handler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='createJSONStringFromMASMessage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createJSONStringFromMASMessage", "(Landroid/content/Context;)Ljava/lang/String;", "GetCreateJSONStringFromMASMessage_Landroid_content_Context_Handler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")]
		string CreateJSONStringFromMASMessage (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='createMASMessageFromJSONString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createMASMessageFromJSONString", "(Ljava/lang/String;)V", "GetCreateMASMessageFromJSONString_Ljava_lang_String_Handler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")]
		void CreateMASMessageFromJSONString (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='getPayload' and count(parameter)=0]"
		[Register ("getPayload", "()[B", "GetGetPayloadHandler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")]
		byte[] GetPayload ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASPayload']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPayload", "([B)V", "GetSetPayload_arrayBHandler:Com.CA.Mas.Messaging.IMASPayloadInvoker, MASFoundation")]
		void SetPayload (byte[] p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/messaging/MASPayload", DoNotGenerateAcw=true)]
	internal class IMASPayloadInvoker : global::Java.Lang.Object, IMASPayload {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/messaging/MASPayload");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASPayloadInvoker); }
		}

		IntPtr class_ref;

		public static IMASPayload GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASPayload> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.messaging.MASPayload"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASPayloadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetContentEncoding_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentEncoding = p0;
		}
#pragma warning restore 0169

		IntPtr id_getContentEncoding;
		IntPtr id_setContentEncoding_Ljava_lang_String_;
		public unsafe string ContentEncoding {
			get {
				if (id_getContentEncoding == IntPtr.Zero)
					id_getContentEncoding = JNIEnv.GetMethodID (class_ref, "getContentEncoding", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentEncoding), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setContentEncoding_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentEncoding_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentEncoding", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentEncoding_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetContentType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentType = p0;
		}
#pragma warning restore 0169

		IntPtr id_getContentType;
		IntPtr id_setContentType_Ljava_lang_String_;
		public unsafe string ContentType {
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setContentType_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentType_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayName;
		public unsafe string DisplayName {
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetSenderId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SenderId = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSenderId;
		IntPtr id_setSenderId_Ljava_lang_String_;
		public unsafe string SenderId {
			get {
				if (id_getSenderId == IntPtr.Zero)
					id_getSenderId = JNIEnv.GetMethodID (class_ref, "getSenderId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSenderId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setSenderId_Ljava_lang_String_ == IntPtr.Zero)
					id_setSenderId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSenderId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSenderId_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetSenderType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SenderType = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSenderType;
		IntPtr id_setSenderType_Ljava_lang_String_;
		public unsafe string SenderType {
			get {
				if (id_getSenderType == IntPtr.Zero)
					id_getSenderType = JNIEnv.GetMethodID (class_ref, "getSenderType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSenderType), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setSenderType_Ljava_lang_String_ == IntPtr.Zero)
					id_setSenderType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSenderType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSenderType_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetSentTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SentTime = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSentTime;
		IntPtr id_setSentTime_J;
		public unsafe long SentTime {
			get {
				if (id_getSentTime == IntPtr.Zero)
					id_getSentTime = JNIEnv.GetMethodID (class_ref, "getSentTime", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSentTime);
			}
			set {
				if (id_setSentTime_J == IntPtr.Zero)
					id_setSentTime_J = JNIEnv.GetMethodID (class_ref, "setSentTime", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSentTime_J, __args);
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
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Version = p0;
		}
#pragma warning restore 0169

		IntPtr id_getVersion;
		IntPtr id_setVersion_Ljava_lang_String_;
		public unsafe string Version {
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVersion_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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

		static IntPtr n_CreateJSONStringFromMASMessage_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.CreateJSONStringFromMASMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createJSONStringFromMASMessage_Landroid_content_Context_;
		public unsafe string CreateJSONStringFromMASMessage (global::Android.Content.Context p0)
		{
			if (id_createJSONStringFromMASMessage_Landroid_content_Context_ == IntPtr.Zero)
				id_createJSONStringFromMASMessage_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "createJSONStringFromMASMessage", "(Landroid/content/Context;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createJSONStringFromMASMessage_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_createMASMessageFromJSONString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateMASMessageFromJSONString_Ljava_lang_String_Handler ()
		{
			if (cb_createMASMessageFromJSONString_Ljava_lang_String_ == null)
				cb_createMASMessageFromJSONString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateMASMessageFromJSONString_Ljava_lang_String_);
			return cb_createMASMessageFromJSONString_Ljava_lang_String_;
		}

		static void n_CreateMASMessageFromJSONString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateMASMessageFromJSONString (p0);
		}
#pragma warning restore 0169

		IntPtr id_createMASMessageFromJSONString_Ljava_lang_String_;
		public unsafe void CreateMASMessageFromJSONString (string p0)
		{
			if (id_createMASMessageFromJSONString_Ljava_lang_String_ == IntPtr.Zero)
				id_createMASMessageFromJSONString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createMASMessageFromJSONString", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createMASMessageFromJSONString_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayload ());
		}
#pragma warning restore 0169

		IntPtr id_getPayload;
		public unsafe byte[] GetPayload ()
		{
			if (id_getPayload == IntPtr.Zero)
				id_getPayload = JNIEnv.GetMethodID (class_ref, "getPayload", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPayload), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_setPayload_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPayload_arrayBHandler ()
		{
			if (cb_setPayload_arrayB == null)
				cb_setPayload_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPayload_arrayB);
			return cb_setPayload_arrayB;
		}

		static void n_SetPayload_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Messaging.IMASPayload __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASPayload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPayload (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setPayload_arrayB;
		public unsafe void SetPayload (byte[] p0)
		{
			if (id_setPayload_arrayB == IntPtr.Zero)
				id_setPayload_arrayB = JNIEnv.GetMethodID (class_ref, "setPayload", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPayload_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
