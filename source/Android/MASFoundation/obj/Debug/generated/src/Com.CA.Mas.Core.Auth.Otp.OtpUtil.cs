using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth.Otp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpUtil']"
	[global::Android.Runtime.Register ("com/ca/mas/core/auth/otp/OtpUtil", DoNotGenerateAcw=true)]
	public partial class OtpUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/auth/otp/OtpUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OtpUtil); }
		}

		protected OtpUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpUtil']/constructor[@name='OtpUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OtpUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OtpUtil)) {
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

		static IntPtr id_convertCommaSeparatedStringToList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpUtil']/method[@name='convertCommaSeparatedStringToList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertCommaSeparatedStringToList", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> ConvertCommaSeparatedStringToList (string str)
		{
			if (id_convertCommaSeparatedStringToList_Ljava_lang_String_ == IntPtr.Zero)
				id_convertCommaSeparatedStringToList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "convertCommaSeparatedStringToList", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_str);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertCommaSeparatedStringToList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static IntPtr id_convertListToCommaSeparatedString_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpUtil']/method[@name='convertListToCommaSeparatedString' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("convertListToCommaSeparatedString", "(Ljava/util/List;)Ljava/lang/String;", "")]
		public static unsafe string ConvertListToCommaSeparatedString (global::System.Collections.Generic.IList<string> list)
		{
			if (id_convertListToCommaSeparatedString_Ljava_util_List_ == IntPtr.Zero)
				id_convertListToCommaSeparatedString_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "convertListToCommaSeparatedString", "(Ljava/util/List;)Ljava/lang/String;");
			IntPtr native_list = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (list);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_list);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertListToCommaSeparatedString_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
			}
		}

		static IntPtr id_convertOtpErrorCodeToEnum_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpUtil']/method[@name='convertOtpErrorCodeToEnum' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("convertOtpErrorCodeToEnum", "(Ljava/lang/String;)Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;", "")]
		public static unsafe global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR ConvertOtpErrorCodeToEnum (string errorCode)
		{
			if (id_convertOtpErrorCodeToEnum_Ljava_lang_String_ == IntPtr.Zero)
				id_convertOtpErrorCodeToEnum_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "convertOtpErrorCodeToEnum", "(Ljava/lang/String;)Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_errorCode);
				global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertOtpErrorCodeToEnum_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
			}
		}

		static IntPtr id_getXotpValueFromHeaders_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpUtil']/method[@name='getXotpValueFromHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
		[Register ("getXotpValueFromHeaders", "(Ljava/util/Map;)Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;", "")]
		public static unsafe global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders GetXotpValueFromHeaders (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> headers)
		{
			if (id_getXotpValueFromHeaders_Ljava_util_Map_ == IntPtr.Zero)
				id_getXotpValueFromHeaders_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "getXotpValueFromHeaders", "(Ljava/util/Map;)Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders;");
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (headers);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_headers);
				global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getXotpValueFromHeaders_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		static IntPtr id_isOtpErrorCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpUtil']/method[@name='isOtpErrorCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isOtpErrorCode", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsOtpErrorCode (string errorCode)
		{
			if (id_isOtpErrorCode_Ljava_lang_String_ == IntPtr.Zero)
				id_isOtpErrorCode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isOtpErrorCode", "(Ljava/lang/String;)Z");
			IntPtr native_errorCode = JNIEnv.NewString (errorCode);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_errorCode);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isOtpErrorCode_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_errorCode);
			}
		}

		static IntPtr id_parseOtpResponseBody_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpUtil']/method[@name='parseOtpResponseBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseOtpResponseBody", "(Ljava/lang/String;)Lcom/ca/mas/core/auth/otp/model/OtpResponseBody;", "")]
		public static unsafe global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseBody ParseOtpResponseBody (string body)
		{
			if (id_parseOtpResponseBody_Ljava_lang_String_ == IntPtr.Zero)
				id_parseOtpResponseBody_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseOtpResponseBody", "(Ljava/lang/String;)Lcom/ca/mas/core/auth/otp/model/OtpResponseBody;");
			IntPtr native_body = JNIEnv.NewString (body);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_body);
				global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseBody __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseOtpResponseBody_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_body);
			}
		}

		static IntPtr id_toPrettyFormat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp']/class[@name='OtpUtil']/method[@name='toPrettyFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("toPrettyFormat", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToPrettyFormat (string jsonString)
		{
			if (id_toPrettyFormat_Ljava_lang_String_ == IntPtr.Zero)
				id_toPrettyFormat_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toPrettyFormat", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_jsonString = JNIEnv.NewString (jsonString);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_jsonString);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPrettyFormat_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonString);
			}
		}

	}
}
