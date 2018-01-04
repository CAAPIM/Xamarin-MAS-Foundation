using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='ContentType']"
	[global::Android.Runtime.Register ("com/ca/mas/core/http/ContentType", DoNotGenerateAcw=true)]
	public partial class ContentType : global::Java.Lang.Object {


		static IntPtr APPLICATION_FORM_URLENCODED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='ContentType']/field[@name='APPLICATION_FORM_URLENCODED']"
		[Register ("APPLICATION_FORM_URLENCODED")]
		public static global::Com.CA.Mas.Core.Http.ContentType ApplicationFormUrlencoded {
			get {
				if (APPLICATION_FORM_URLENCODED_jfieldId == IntPtr.Zero)
					APPLICATION_FORM_URLENCODED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_FORM_URLENCODED", "Lcom/ca/mas/core/http/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_FORM_URLENCODED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr APPLICATION_JSON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='ContentType']/field[@name='APPLICATION_JSON']"
		[Register ("APPLICATION_JSON")]
		public static global::Com.CA.Mas.Core.Http.ContentType ApplicationJson {
			get {
				if (APPLICATION_JSON_jfieldId == IntPtr.Zero)
					APPLICATION_JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_JSON", "Lcom/ca/mas/core/http/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_JSON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr APPLICATION_OCTET_STREAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='ContentType']/field[@name='APPLICATION_OCTET_STREAM']"
		[Register ("APPLICATION_OCTET_STREAM")]
		public static global::Com.CA.Mas.Core.Http.ContentType ApplicationOctetStream {
			get {
				if (APPLICATION_OCTET_STREAM_jfieldId == IntPtr.Zero)
					APPLICATION_OCTET_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_OCTET_STREAM", "Lcom/ca/mas/core/http/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_OCTET_STREAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_PLAIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='ContentType']/field[@name='TEXT_PLAIN']"
		[Register ("TEXT_PLAIN")]
		public static global::Com.CA.Mas.Core.Http.ContentType TextPlain {
			get {
				if (TEXT_PLAIN_jfieldId == IntPtr.Zero)
					TEXT_PLAIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_PLAIN", "Lcom/ca/mas/core/http/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_PLAIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/http/ContentType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentType); }
		}

		protected ContentType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='ContentType']/constructor[@name='ContentType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/nio/charset/Charset;)V", "")]
		public unsafe ContentType (string mimeType, global::Java.Nio.Charset.Charset charset)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_mimeType = JNIEnv.NewString (mimeType);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_mimeType);
				__args [1] = new JValue (charset);
				if (((object) this).GetType () != typeof (ContentType)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/nio/charset/Charset;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/nio/charset/Charset;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/nio/charset/Charset;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_nio_charset_Charset_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mimeType);
			}
		}

		static Delegate cb_getCharset;
#pragma warning disable 0169
		static Delegate GetGetCharsetHandler ()
		{
			if (cb_getCharset == null)
				cb_getCharset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCharset);
			return cb_getCharset;
		}

		static IntPtr n_GetCharset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Http.ContentType __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.ContentType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Charset);
		}
#pragma warning restore 0169

		static IntPtr id_getCharset;
		public virtual unsafe global::Java.Nio.Charset.Charset Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='ContentType']/method[@name='getCharset' and count(parameter)=0]"
			[Register ("getCharset", "()Ljava/nio/charset/Charset;", "GetGetCharsetHandler")]
			get {
				if (id_getCharset == IntPtr.Zero)
					id_getCharset = JNIEnv.GetMethodID (class_ref, "getCharset", "()Ljava/nio/charset/Charset;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCharset), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCharset", "()Ljava/nio/charset/Charset;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMimeType;
#pragma warning disable 0169
		static Delegate GetGetMimeTypeHandler ()
		{
			if (cb_getMimeType == null)
				cb_getMimeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMimeType);
			return cb_getMimeType;
		}

		static IntPtr n_GetMimeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Http.ContentType __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Http.ContentType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MimeType);
		}
#pragma warning restore 0169

		static IntPtr id_getMimeType;
		public virtual unsafe string MimeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.http']/class[@name='ContentType']/method[@name='getMimeType' and count(parameter)=0]"
			[Register ("getMimeType", "()Ljava/lang/String;", "GetGetMimeTypeHandler")]
			get {
				if (id_getMimeType == IntPtr.Zero)
					id_getMimeType = JNIEnv.GetMethodID (class_ref, "getMimeType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMimeType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMimeType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
