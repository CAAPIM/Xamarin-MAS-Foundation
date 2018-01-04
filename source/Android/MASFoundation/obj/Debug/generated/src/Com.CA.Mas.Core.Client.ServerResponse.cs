using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.client']/class[@name='ServerResponse']"
	[global::Android.Runtime.Register ("com/ca/mas/core/client/ServerResponse", DoNotGenerateAcw=true)]
	public partial class ServerResponse : global::Java.Lang.Object {


		static IntPtr parsed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.client']/class[@name='ServerResponse']/field[@name='parsed']"
		[Register ("parsed")]
		protected global::Org.Json.JSONObject Parsed {
			get {
				if (parsed_jfieldId == IntPtr.Zero)
					parsed_jfieldId = JNIEnv.GetFieldID (class_ref, "parsed", "Lorg/json/JSONObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, parsed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (parsed_jfieldId == IntPtr.Zero)
					parsed_jfieldId = JNIEnv.GetFieldID (class_ref, "parsed", "Lorg/json/JSONObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, parsed_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/client/ServerResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServerResponse); }
		}

		protected ServerResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.client']/class[@name='ServerResponse']/constructor[@name='ServerResponse' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(IILjava/lang/String;)V", "")]
		public unsafe ServerResponse (int status, int errorCode, string json)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (status);
				__args [1] = new JValue (errorCode);
				__args [2] = new JValue (native_json);
				if (((object) this).GetType () != typeof (ServerResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_IILjava_lang_String_ == IntPtr.Zero)
					id_ctor_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.client']/class[@name='ServerResponse']/constructor[@name='ServerResponse' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe ServerResponse (int status, string json)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_json = JNIEnv.NewString (json);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (status);
				__args [1] = new JValue (native_json);
				if (((object) this).GetType () != typeof (ServerResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_json);
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Client.ServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Client.ServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCode;
		public virtual unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.client']/class[@name='ServerResponse']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getErrorCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isError;
#pragma warning disable 0169
		static Delegate GetIsErrorHandler ()
		{
			if (cb_isError == null)
				cb_isError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsError);
			return cb_isError;
		}

		static bool n_IsError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Client.ServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Client.ServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsError;
		}
#pragma warning restore 0169

		static IntPtr id_isError;
		public virtual unsafe bool IsError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.client']/class[@name='ServerResponse']/method[@name='isError' and count(parameter)=0]"
			[Register ("isError", "()Z", "GetIsErrorHandler")]
			get {
				if (id_isError == IntPtr.Zero)
					id_isError = JNIEnv.GetMethodID (class_ref, "isError", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isError);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isError", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getJson;
#pragma warning disable 0169
		static Delegate GetGetJsonHandler ()
		{
			if (cb_getJson == null)
				cb_getJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJson);
			return cb_getJson;
		}

		static IntPtr n_GetJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Client.ServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Client.ServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Json);
		}
#pragma warning restore 0169

		static IntPtr id_getJson;
		public virtual unsafe string Json {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.client']/class[@name='ServerResponse']/method[@name='getJson' and count(parameter)=0]"
			[Register ("getJson", "()Ljava/lang/String;", "GetGetJsonHandler")]
			get {
				if (id_getJson == IntPtr.Zero)
					id_getJson = JNIEnv.GetMethodID (class_ref, "getJson", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJson), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJson", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatus);
			return cb_getStatus;
		}

		static int n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Client.ServerResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Client.ServerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		public virtual unsafe int Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.client']/class[@name='ServerResponse']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()I", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStatus);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()I"));
				} finally {
				}
			}
		}

	}
}
