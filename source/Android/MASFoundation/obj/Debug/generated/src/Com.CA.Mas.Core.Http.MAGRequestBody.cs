using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']"
	[global::Android.Runtime.Register ("com/ca/mas/core/http/MAGRequestBody", DoNotGenerateAcw=true)]
	public abstract partial class MAGRequestBody : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/http/MAGRequestBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGRequestBody); }
		}

		protected MAGRequestBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/constructor[@name='MAGRequestBody' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MAGRequestBody ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MAGRequestBody)) {
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

		static Delegate cb_getContentAsJsonValue;
#pragma warning disable 0169
		static Delegate GetGetContentAsJsonValueHandler ()
		{
			if (cb_getContentAsJsonValue == null)
				cb_getContentAsJsonValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentAsJsonValue);
			return cb_getContentAsJsonValue;
		}

		static IntPtr n_GetContentAsJsonValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Http.MAGRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentAsJsonValue);
		}
#pragma warning restore 0169

		static IntPtr id_getContentAsJsonValue;
		public virtual unsafe global::Java.Lang.Object ContentAsJsonValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='getContentAsJsonValue' and count(parameter)=0]"
			[Register ("getContentAsJsonValue", "()Ljava/lang/Object;", "GetGetContentAsJsonValueHandler")]
			get {
				if (id_getContentAsJsonValue == IntPtr.Zero)
					id_getContentAsJsonValue = JNIEnv.GetMethodID (class_ref, "getContentAsJsonValue", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentAsJsonValue), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentAsJsonValue", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentLength;
#pragma warning disable 0169
		static Delegate GetGetContentLengthHandler ()
		{
			if (cb_getContentLength == null)
				cb_getContentLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContentLength);
			return cb_getContentLength;
		}

		static long n_GetContentLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Http.MAGRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLength;
		}
#pragma warning restore 0169

		public abstract long ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()J", "GetGetContentLengthHandler")] get;
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
			global::Com.CA.Mas.Core.Http.MAGRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentType);
		}
#pragma warning restore 0169

		public abstract global::Com.CA.Mas.Core.Http.ContentType ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Lcom/ca/mas/core/http/ContentType;", "GetGetContentTypeHandler")] get;
		}

		static IntPtr id_byteArrayBody_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='byteArrayBody' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("byteArrayBody", "([B)Lcom/ca/mas/core/http/MAGRequestBody;", "")]
		public static unsafe global::Com.CA.Mas.Core.Http.MAGRequestBody ByteArrayBody (byte[] body)
		{
			if (id_byteArrayBody_arrayB == IntPtr.Zero)
				id_byteArrayBody_arrayB = JNIEnv.GetStaticMethodID (class_ref, "byteArrayBody", "([B)Lcom/ca/mas/core/http/MAGRequestBody;");
			IntPtr native_body = JNIEnv.NewArray (body);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_body);
				global::Com.CA.Mas.Core.Http.MAGRequestBody __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGRequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_byteArrayBody_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (body != null) {
					JNIEnv.CopyArray (native_body, body);
					JNIEnv.DeleteLocalRef (native_body);
				}
			}
		}

		static IntPtr id_jsonBody_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='jsonBody' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("jsonBody", "(Lorg/json/JSONObject;)Lcom/ca/mas/core/http/MAGRequestBody;", "")]
		public static unsafe global::Com.CA.Mas.Core.Http.MAGRequestBody JsonBody (global::Org.Json.JSONObject jsonObject)
		{
			if (id_jsonBody_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_jsonBody_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "jsonBody", "(Lorg/json/JSONObject;)Lcom/ca/mas/core/http/MAGRequestBody;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (jsonObject);
				global::Com.CA.Mas.Core.Http.MAGRequestBody __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGRequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_jsonBody_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_stringBody_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='stringBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringBody", "(Ljava/lang/String;)Lcom/ca/mas/core/http/MAGRequestBody;", "")]
		public static unsafe global::Com.CA.Mas.Core.Http.MAGRequestBody StringBody (string body)
		{
			if (id_stringBody_Ljava_lang_String_ == IntPtr.Zero)
				id_stringBody_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stringBody", "(Ljava/lang/String;)Lcom/ca/mas/core/http/MAGRequestBody;");
			IntPtr native_body = JNIEnv.NewString (body);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_body);
				global::Com.CA.Mas.Core.Http.MAGRequestBody __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGRequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringBody_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_body);
			}
		}

		static IntPtr id_urlEncodedFormBody_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='urlEncodedFormBody' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends android.util.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
		[Register ("urlEncodedFormBody", "(Ljava/util/List;)Lcom/ca/mas/core/http/MAGRequestBody;", "")]
		public static unsafe global::Com.CA.Mas.Core.Http.MAGRequestBody UrlEncodedFormBody (global::System.Collections.Generic.IList<global::Android.Util.Pair> form)
		{
			if (id_urlEncodedFormBody_Ljava_util_List_ == IntPtr.Zero)
				id_urlEncodedFormBody_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "urlEncodedFormBody", "(Ljava/util/List;)Lcom/ca/mas/core/http/MAGRequestBody;");
			IntPtr native_form = global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (form);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_form);
				global::Com.CA.Mas.Core.Http.MAGRequestBody __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGRequestBody> (JNIEnv.CallStaticObjectMethod  (class_ref, id_urlEncodedFormBody_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_form);
			}
		}

		static Delegate cb_write_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_io_OutputStream_Handler ()
		{
			if (cb_write_Ljava_io_OutputStream_ == null)
				cb_write_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_io_OutputStream_);
			return cb_write_Ljava_io_OutputStream_;
		}

		static void n_Write_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Core.Http.MAGRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.MAGRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='MAGRequestBody']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("write", "(Ljava/io/OutputStream;)V", "GetWrite_Ljava_io_OutputStream_Handler")]
		public abstract void Write (global::System.IO.Stream p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/http/MAGRequestBody", DoNotGenerateAcw=true)]
	internal partial class MAGRequestBodyInvoker : MAGRequestBody {

		public MAGRequestBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGRequestBodyInvoker); }
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
