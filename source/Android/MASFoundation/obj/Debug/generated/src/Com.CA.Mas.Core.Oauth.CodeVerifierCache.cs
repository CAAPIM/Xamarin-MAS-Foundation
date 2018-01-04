using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Oauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='CodeVerifierCache']"
	[global::Android.Runtime.Register ("com/ca/mas/core/oauth/CodeVerifierCache", DoNotGenerateAcw=true)]
	public partial class CodeVerifierCache : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/oauth/CodeVerifierCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CodeVerifierCache); }
		}

		protected CodeVerifierCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.CA.Mas.Core.Oauth.CodeVerifierCache Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='CodeVerifierCache']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ca/mas/core/oauth/CodeVerifierCache;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ca/mas/core/oauth/CodeVerifierCache;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.CodeVerifierCache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_store_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStore_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_store_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_store_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Store_Ljava_lang_String_Ljava_lang_String_);
			return cb_store_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Store_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state, IntPtr native_codeVerifier)
		{
			global::Com.CA.Mas.Core.Oauth.CodeVerifierCache __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.CodeVerifierCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string state = JNIEnv.GetString (native_state, JniHandleOwnership.DoNotTransfer);
			string codeVerifier = JNIEnv.GetString (native_codeVerifier, JniHandleOwnership.DoNotTransfer);
			__this.Store (state, codeVerifier);
		}
#pragma warning restore 0169

		static IntPtr id_store_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='CodeVerifierCache']/method[@name='store' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("store", "(Ljava/lang/String;Ljava/lang/String;)V", "GetStore_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Store (string state, string codeVerifier)
		{
			if (id_store_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_store_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "store", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_state = JNIEnv.NewString (state);
			IntPtr native_codeVerifier = JNIEnv.NewString (codeVerifier);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_state);
				__args [1] = new JValue (native_codeVerifier);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_store_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "store", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_state);
				JNIEnv.DeleteLocalRef (native_codeVerifier);
			}
		}

		static Delegate cb_take;
#pragma warning disable 0169
		static Delegate GetTakeHandler ()
		{
			if (cb_take == null)
				cb_take = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Take);
			return cb_take;
		}

		static IntPtr n_Take (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Oauth.CodeVerifierCache __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.CodeVerifierCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Take ());
		}
#pragma warning restore 0169

		static IntPtr id_take;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='CodeVerifierCache']/method[@name='take' and count(parameter)=0]"
		[Register ("take", "()Ljava/lang/String;", "GetTakeHandler")]
		public virtual unsafe string Take ()
		{
			if (id_take == IntPtr.Zero)
				id_take = JNIEnv.GetMethodID (class_ref, "take", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_take), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "take", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_take_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTake_Ljava_lang_String_Handler ()
		{
			if (cb_take_Ljava_lang_String_ == null)
				cb_take_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Take_Ljava_lang_String_);
			return cb_take_Ljava_lang_String_;
		}

		static IntPtr n_Take_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			global::Com.CA.Mas.Core.Oauth.CodeVerifierCache __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.CodeVerifierCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string state = JNIEnv.GetString (native_state, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Take (state));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_take_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='CodeVerifierCache']/method[@name='take' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("take", "(Ljava/lang/String;)Ljava/lang/String;", "GetTake_Ljava_lang_String_Handler")]
		public virtual unsafe string Take (string state)
		{
			if (id_take_Ljava_lang_String_ == IntPtr.Zero)
				id_take_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "take", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_state = JNIEnv.NewString (state);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_state);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_take_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "take", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_state);
			}
		}

	}
}
