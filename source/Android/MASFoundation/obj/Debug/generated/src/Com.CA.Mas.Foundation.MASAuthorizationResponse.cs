using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationResponse']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASAuthorizationResponse", DoNotGenerateAcw=true)]
	public partial class MASAuthorizationResponse : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASAuthorizationResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASAuthorizationResponse); }
		}

		protected MASAuthorizationResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationResponse']/constructor[@name='MASAuthorizationResponse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MASAuthorizationResponse (string authorizationCode, string state)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_authorizationCode = JNIEnv.NewString (authorizationCode);
			IntPtr native_state = JNIEnv.NewString (state);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_authorizationCode);
				__args [1] = new JValue (native_state);
				if (((object) this).GetType () != typeof (MASAuthorizationResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_authorizationCode);
				JNIEnv.DeleteLocalRef (native_state);
			}
		}

		static Delegate cb_getAuthorizationCode;
#pragma warning disable 0169
		static Delegate GetGetAuthorizationCodeHandler ()
		{
			if (cb_getAuthorizationCode == null)
				cb_getAuthorizationCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthorizationCode);
			return cb_getAuthorizationCode;
		}

		static IntPtr n_GetAuthorizationCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthorizationResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthorizationCode);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthorizationCode;
		public virtual unsafe string AuthorizationCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationResponse']/method[@name='getAuthorizationCode' and count(parameter)=0]"
			[Register ("getAuthorizationCode", "()Ljava/lang/String;", "GetGetAuthorizationCodeHandler")]
			get {
				if (id_getAuthorizationCode == IntPtr.Zero)
					id_getAuthorizationCode = JNIEnv.GetMethodID (class_ref, "getAuthorizationCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthorizationCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthorizationCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthorizationResponse __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual unsafe string State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationResponse']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Ljava/lang/String;", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_fromUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationResponse']/method[@name='fromUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("fromUri", "(Landroid/net/Uri;)Lcom/ca/mas/foundation/MASAuthorizationResponse;", "")]
		public static unsafe global::Com.CA.Mas.Foundation.MASAuthorizationResponse FromUri (global::Android.Net.Uri uri)
		{
			if (id_fromUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_fromUri_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "fromUri", "(Landroid/net/Uri;)Lcom/ca/mas/foundation/MASAuthorizationResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (uri);
				global::Com.CA.Mas.Foundation.MASAuthorizationResponse __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromUri_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
