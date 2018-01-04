using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.request']/class[@name='MAGInternalRequest']"
	[global::Android.Runtime.Register ("com/ca/mas/core/request/MAGInternalRequest", DoNotGenerateAcw=true)]
	public partial class MAGInternalRequest : global::Com.CA.Mas.Core.Request.Internal.MAGRequestProxy {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/request/MAGInternalRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MAGInternalRequest); }
		}

		protected MAGInternalRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isLocalRequest;
#pragma warning disable 0169
		static Delegate GetIsLocalRequestHandler ()
		{
			if (cb_isLocalRequest == null)
				cb_isLocalRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocalRequest);
			return cb_isLocalRequest;
		}

		static bool n_IsLocalRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Request.MAGInternalRequest __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.MAGInternalRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocalRequest;
		}
#pragma warning restore 0169

		static IntPtr id_isLocalRequest;
		public virtual unsafe bool IsLocalRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.request']/class[@name='MAGInternalRequest']/method[@name='isLocalRequest' and count(parameter)=0]"
			[Register ("isLocalRequest", "()Z", "GetIsLocalRequestHandler")]
			get {
				if (id_isLocalRequest == IntPtr.Zero)
					id_isLocalRequest = JNIEnv.GetMethodID (class_ref, "isLocalRequest", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLocalRequest);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLocalRequest", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
		{
			global::Com.CA.Mas.Core.Request.MAGInternalRequest __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Request.MAGInternalRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AddHeader (name, value);
		}
#pragma warning restore 0169

		static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.request']/class[@name='MAGInternalRequest']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddHeader (string name, string value)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
