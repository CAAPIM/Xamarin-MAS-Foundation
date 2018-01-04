using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASRequestBody']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASRequestBody", DoNotGenerateAcw=true)]
	public abstract partial class MASRequestBody : global::Com.CA.Mas.Core.Http.MAGRequestBody {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASRequestBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASRequestBody); }
		}

		protected MASRequestBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASRequestBody']/constructor[@name='MASRequestBody' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASRequestBody ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASRequestBody)) {
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

		static IntPtr id_byteArrayBody_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASRequestBody']/method[@name='byteArrayBody' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteArrayBody", "([B)Lcom/ca/mas/foundation/MASRequestBody;", "")]
		public static unsafe global::Com.CA.Mas.Foundation.MASRequestBody ByteArrayBody (byte[] body)
		{
			if (id_byteArrayBody_arrayB == IntPtr.Zero)
				id_byteArrayBody_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byteArrayBody", "([B)Lcom/ca/mas/foundation/MASRequestBody;");
			IntPtr native_body = JNIEnv.NewArray (body);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_body);
				global::Com.CA.Mas.Foundation.MASRequestBody __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASRequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteArrayBody_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (body != null) {
					JNIEnv.CopyArray (native_body, body);
					JNIEnv.DeleteLocalRef (native_body);
				}
			}
		}

		static IntPtr id_jsonBody_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASRequestBody']/method[@name='jsonBody' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("jsonBody", "(Lorg/json/JSONObject;)Lcom/ca/mas/foundation/MASRequestBody;", "")]
		public static unsafe global::Com.CA.Mas.Foundation.MASRequestBody JsonBody (global::Org.Json.JSONObject jsonObject)
		{
			if (id_jsonBody_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_jsonBody_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "jsonBody", "(Lorg/json/JSONObject;)Lcom/ca/mas/foundation/MASRequestBody;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (jsonObject);
				global::Com.CA.Mas.Foundation.MASRequestBody __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASRequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_jsonBody_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_stringBody_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASRequestBody']/method[@name='stringBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringBody", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASRequestBody;", "")]
		public static unsafe global::Com.CA.Mas.Foundation.MASRequestBody StringBody (string body)
		{
			if (id_stringBody_Ljava_lang_String_ == IntPtr.Zero)
				id_stringBody_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stringBody", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASRequestBody;");
			IntPtr native_body = JNIEnv.NewString (body);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_body);
				global::Com.CA.Mas.Foundation.MASRequestBody __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASRequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringBody_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_body);
			}
		}

		static IntPtr id_urlEncodedFormBody_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASRequestBody']/method[@name='urlEncodedFormBody' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends android.util.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
		[Register ("urlEncodedFormBody", "(Ljava/util/List;)Lcom/ca/mas/foundation/MASRequestBody;", "")]
		public static unsafe global::Com.CA.Mas.Foundation.MASRequestBody UrlEncodedFormBody (global::System.Collections.Generic.IList<global::Android.Util.Pair> form)
		{
			if (id_urlEncodedFormBody_Ljava_util_List_ == IntPtr.Zero)
				id_urlEncodedFormBody_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "urlEncodedFormBody", "(Ljava/util/List;)Lcom/ca/mas/foundation/MASRequestBody;");
			IntPtr native_form = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (form);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_form);
				global::Com.CA.Mas.Foundation.MASRequestBody __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASRequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_urlEncodedFormBody_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_form);
			}
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASRequestBody", DoNotGenerateAcw=true)]
	internal partial class MASRequestBodyInvoker : MASRequestBody {

		public MASRequestBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASRequestBodyInvoker); }
		}

		static IntPtr id_getContentLength;
		public override unsafe long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")]
			get {
				if (id_getContentLength == IntPtr.Zero)
					id_getContentLength = JNIEnv.GetMethodID (class_ref, "getContentLength", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getContentLength);
				} finally {
				}
			}
		}

		static IntPtr id_getContentType;
		public override unsafe global::Com.CA.Mas.Core.Http.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/ca/mas/core/http/ContentType;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Lcom/ca/mas/core/http/ContentType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.ContentType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_write_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("write", "(Ljava/io/OutputStream;)V", "GetWrite_Ljava_io_OutputStream_Handler")]
		public override unsafe void Write (global::System.IO.Stream p0)
		{
			if (id_write_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_write_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
