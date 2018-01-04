using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASAuthorizationRequest", DoNotGenerateAcw=true)]
	public partial class MASAuthorizationRequest : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']"
		[global::Android.Runtime.Register ("com/ca/mas/foundation/MASAuthorizationRequest$MASAuthorizationRequestBuilder", DoNotGenerateAcw=true)]
		public partial class MASAuthorizationRequestBuilder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/foundation/MASAuthorizationRequest$MASAuthorizationRequestBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MASAuthorizationRequestBuilder); }
			}

			protected MASAuthorizationRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/constructor[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MASAuthorizationRequestBuilder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (MASAuthorizationRequestBuilder)) {
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

			static Delegate cb_getClientId;
#pragma warning disable 0169
			static Delegate GetGetClientIdHandler ()
			{
				if (cb_getClientId == null)
					cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
				return cb_getClientId;
			}

			static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ClientId);
			}
#pragma warning restore 0169

			static Delegate cb_setClientId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetClientId_Ljava_lang_String_Handler ()
			{
				if (cb_setClientId_Ljava_lang_String_ == null)
					cb_setClientId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientId_Ljava_lang_String_);
				return cb_setClientId_Ljava_lang_String_;
			}

			static void n_SetClientId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientId)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string clientId = JNIEnv.GetString (native_clientId, JniHandleOwnership.DoNotTransfer);
				__this.ClientId = clientId;
			}
#pragma warning restore 0169

			static IntPtr id_getClientId;
			static IntPtr id_setClientId_Ljava_lang_String_;
			public virtual unsafe string ClientId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='getClientId' and count(parameter)=0]"
				[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
				get {
					if (id_getClientId == IntPtr.Zero)
						id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='setClientId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setClientId", "(Ljava/lang/String;)V", "GetSetClientId_Ljava_lang_String_Handler")]
				set {
					if (id_setClientId_Ljava_lang_String_ == IntPtr.Zero)
						id_setClientId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientId", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClientId_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientId", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getDisplay;
#pragma warning disable 0169
			static Delegate GetGetDisplayHandler ()
			{
				if (cb_getDisplay == null)
					cb_getDisplay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplay);
				return cb_getDisplay;
			}

			static IntPtr n_GetDisplay (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Display);
			}
#pragma warning restore 0169

			static Delegate cb_setDisplay_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDisplay_Ljava_lang_String_Handler ()
			{
				if (cb_setDisplay_Ljava_lang_String_ == null)
					cb_setDisplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisplay_Ljava_lang_String_);
				return cb_setDisplay_Ljava_lang_String_;
			}

			static void n_SetDisplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_display)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string display = JNIEnv.GetString (native_display, JniHandleOwnership.DoNotTransfer);
				__this.Display = display;
			}
#pragma warning restore 0169

			static IntPtr id_getDisplay;
			static IntPtr id_setDisplay_Ljava_lang_String_;
			public virtual unsafe string Display {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='getDisplay' and count(parameter)=0]"
				[Register ("getDisplay", "()Ljava/lang/String;", "GetGetDisplayHandler")]
				get {
					if (id_getDisplay == IntPtr.Zero)
						id_getDisplay = JNIEnv.GetMethodID (class_ref, "getDisplay", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplay), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplay", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='setDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setDisplay", "(Ljava/lang/String;)V", "GetSetDisplay_Ljava_lang_String_Handler")]
				set {
					if (id_setDisplay_Ljava_lang_String_ == IntPtr.Zero)
						id_setDisplay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDisplay", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplay_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplay", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getRedirectUri;
#pragma warning disable 0169
			static Delegate GetGetRedirectUriHandler ()
			{
				if (cb_getRedirectUri == null)
					cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUri);
				return cb_getRedirectUri;
			}

			static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.RedirectUri);
			}
#pragma warning restore 0169

			static Delegate cb_setRedirectUri_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetSetRedirectUri_Landroid_net_Uri_Handler ()
			{
				if (cb_setRedirectUri_Landroid_net_Uri_ == null)
					cb_setRedirectUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRedirectUri_Landroid_net_Uri_);
				return cb_setRedirectUri_Landroid_net_Uri_;
			}

			static void n_SetRedirectUri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_redirectUri)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri redirectUri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_redirectUri, JniHandleOwnership.DoNotTransfer);
				__this.RedirectUri = redirectUri;
			}
#pragma warning restore 0169

			static IntPtr id_getRedirectUri;
			static IntPtr id_setRedirectUri_Landroid_net_Uri_;
			public virtual unsafe global::Android.Net.Uri RedirectUri {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='getRedirectUri' and count(parameter)=0]"
				[Register ("getRedirectUri", "()Landroid/net/Uri;", "GetGetRedirectUriHandler")]
				get {
					if (id_getRedirectUri == IntPtr.Zero)
						id_getRedirectUri = JNIEnv.GetMethodID (class_ref, "getRedirectUri", "()Landroid/net/Uri;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRedirectUri), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedirectUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='setRedirectUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
				[Register ("setRedirectUri", "(Landroid/net/Uri;)V", "GetSetRedirectUri_Landroid_net_Uri_Handler")]
				set {
					if (id_setRedirectUri_Landroid_net_Uri_ == IntPtr.Zero)
						id_setRedirectUri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setRedirectUri", "(Landroid/net/Uri;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRedirectUri_Landroid_net_Uri_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRedirectUri", "(Landroid/net/Uri;)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getResponseType;
#pragma warning disable 0169
			static Delegate GetGetResponseTypeHandler ()
			{
				if (cb_getResponseType == null)
					cb_getResponseType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseType);
				return cb_getResponseType;
			}

			static IntPtr n_GetResponseType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ResponseType);
			}
#pragma warning restore 0169

			static Delegate cb_setResponseType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetResponseType_Ljava_lang_String_Handler ()
			{
				if (cb_setResponseType_Ljava_lang_String_ == null)
					cb_setResponseType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseType_Ljava_lang_String_);
				return cb_setResponseType_Ljava_lang_String_;
			}

			static void n_SetResponseType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_responseType)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string responseType = JNIEnv.GetString (native_responseType, JniHandleOwnership.DoNotTransfer);
				__this.ResponseType = responseType;
			}
#pragma warning restore 0169

			static IntPtr id_getResponseType;
			static IntPtr id_setResponseType_Ljava_lang_String_;
			public virtual unsafe string ResponseType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='getResponseType' and count(parameter)=0]"
				[Register ("getResponseType", "()Ljava/lang/String;", "GetGetResponseTypeHandler")]
				get {
					if (id_getResponseType == IntPtr.Zero)
						id_getResponseType = JNIEnv.GetMethodID (class_ref, "getResponseType", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseType), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='setResponseType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setResponseType", "(Ljava/lang/String;)V", "GetSetResponseType_Ljava_lang_String_Handler")]
				set {
					if (id_setResponseType_Ljava_lang_String_ == IntPtr.Zero)
						id_setResponseType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponseType", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseType_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseType", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getScope;
#pragma warning disable 0169
			static Delegate GetGetScopeHandler ()
			{
				if (cb_getScope == null)
					cb_getScope = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScope);
				return cb_getScope;
			}

			static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Scope);
			}
#pragma warning restore 0169

			static Delegate cb_setScope_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetScope_Ljava_lang_String_Handler ()
			{
				if (cb_setScope_Ljava_lang_String_ == null)
					cb_setScope_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScope_Ljava_lang_String_);
				return cb_setScope_Ljava_lang_String_;
			}

			static void n_SetScope_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scope)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string scope = JNIEnv.GetString (native_scope, JniHandleOwnership.DoNotTransfer);
				__this.Scope = scope;
			}
#pragma warning restore 0169

			static IntPtr id_getScope;
			static IntPtr id_setScope_Ljava_lang_String_;
			public virtual unsafe string Scope {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='getScope' and count(parameter)=0]"
				[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
				get {
					if (id_getScope == IntPtr.Zero)
						id_getScope = JNIEnv.GetMethodID (class_ref, "getScope", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScope), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScope", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='setScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setScope", "(Ljava/lang/String;)V", "GetSetScope_Ljava_lang_String_Handler")]
				set {
					if (id_setScope_Ljava_lang_String_ == IntPtr.Zero)
						id_setScope_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setScope", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScope_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScope", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
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
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.State);
			}
#pragma warning restore 0169

			static Delegate cb_setState_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetState_Ljava_lang_String_Handler ()
			{
				if (cb_setState_Ljava_lang_String_ == null)
					cb_setState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetState_Ljava_lang_String_);
				return cb_setState_Ljava_lang_String_;
			}

			static void n_SetState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string state = JNIEnv.GetString (native_state, JniHandleOwnership.DoNotTransfer);
				__this.State = state;
			}
#pragma warning restore 0169

			static IntPtr id_getState;
			static IntPtr id_setState_Ljava_lang_String_;
			public virtual unsafe string State {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='getState' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setState", "(Ljava/lang/String;)V", "GetSetState_Ljava_lang_String_Handler")]
				set {
					if (id_setState_Ljava_lang_String_ == IntPtr.Zero)
						id_setState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setState", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setState_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setState", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/ca/mas/foundation/MASAuthorizationRequest;", "GetBuildHandler")]
			public virtual unsafe global::Com.CA.Mas.Foundation.MASAuthorizationRequest Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/ca/mas/foundation/MASAuthorizationRequest;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/ca/mas/foundation/MASAuthorizationRequest;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_buildDefault;
#pragma warning disable 0169
			static Delegate GetBuildDefaultHandler ()
			{
				if (cb_buildDefault == null)
					cb_buildDefault = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildDefault);
				return cb_buildDefault;
			}

			static IntPtr n_BuildDefault (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest.MASAuthorizationRequestBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BuildDefault ());
			}
#pragma warning restore 0169

			static IntPtr id_buildDefault;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest.MASAuthorizationRequestBuilder']/method[@name='buildDefault' and count(parameter)=0]"
			[Register ("buildDefault", "()Lcom/ca/mas/foundation/MASAuthorizationRequest;", "GetBuildDefaultHandler")]
			public virtual unsafe global::Com.CA.Mas.Foundation.MASAuthorizationRequest BuildDefault ()
			{
				if (id_buildDefault == IntPtr.Zero)
					id_buildDefault = JNIEnv.GetMethodID (class_ref, "buildDefault", "()Lcom/ca/mas/foundation/MASAuthorizationRequest;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildDefault), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildDefault", "()Lcom/ca/mas/foundation/MASAuthorizationRequest;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASAuthorizationRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASAuthorizationRequest); }
		}

		protected MASAuthorizationRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthorizationRequest __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplay;
#pragma warning disable 0169
		static Delegate GetGetDisplayHandler ()
		{
			if (cb_getDisplay == null)
				cb_getDisplay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplay);
			return cb_getDisplay;
		}

		static IntPtr n_GetDisplay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthorizationRequest __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Display);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplay;
		public virtual unsafe string Display {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest']/method[@name='getDisplay' and count(parameter)=0]"
			[Register ("getDisplay", "()Ljava/lang/String;", "GetGetDisplayHandler")]
			get {
				if (id_getDisplay == IntPtr.Zero)
					id_getDisplay = JNIEnv.GetMethodID (class_ref, "getDisplay", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplay), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplay", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetRedirectUriHandler ()
		{
			if (cb_getRedirectUri == null)
				cb_getRedirectUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedirectUri);
			return cb_getRedirectUri;
		}

		static IntPtr n_GetRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthorizationRequest __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RedirectUri);
		}
#pragma warning restore 0169

		static IntPtr id_getRedirectUri;
		public virtual unsafe global::Android.Net.Uri RedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest']/method[@name='getRedirectUri' and count(parameter)=0]"
			[Register ("getRedirectUri", "()Landroid/net/Uri;", "GetGetRedirectUriHandler")]
			get {
				if (id_getRedirectUri == IntPtr.Zero)
					id_getRedirectUri = JNIEnv.GetMethodID (class_ref, "getRedirectUri", "()Landroid/net/Uri;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRedirectUri), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedirectUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseType;
#pragma warning disable 0169
		static Delegate GetGetResponseTypeHandler ()
		{
			if (cb_getResponseType == null)
				cb_getResponseType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseType);
			return cb_getResponseType;
		}

		static IntPtr n_GetResponseType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthorizationRequest __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseType);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseType;
		public virtual unsafe string ResponseType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest']/method[@name='getResponseType' and count(parameter)=0]"
			[Register ("getResponseType", "()Ljava/lang/String;", "GetGetResponseTypeHandler")]
			get {
				if (id_getResponseType == IntPtr.Zero)
					id_getResponseType = JNIEnv.GetMethodID (class_ref, "getResponseType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScope;
#pragma warning disable 0169
		static Delegate GetGetScopeHandler ()
		{
			if (cb_getScope == null)
				cb_getScope = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScope);
			return cb_getScope;
		}

		static IntPtr n_GetScope (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASAuthorizationRequest __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Scope);
		}
#pragma warning restore 0169

		static IntPtr id_getScope;
		public virtual unsafe string Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Ljava/lang/String;", "GetGetScopeHandler")]
			get {
				if (id_getScope == IntPtr.Zero)
					id_getScope = JNIEnv.GetMethodID (class_ref, "getScope", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScope), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScope", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.CA.Mas.Foundation.MASAuthorizationRequest __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASAuthorizationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual unsafe string State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASAuthorizationRequest']/method[@name='getState' and count(parameter)=0]"
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

	}
}
