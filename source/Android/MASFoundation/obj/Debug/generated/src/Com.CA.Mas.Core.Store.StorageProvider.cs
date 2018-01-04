using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Store {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='StorageProvider']"
	[global::Android.Runtime.Register ("com/ca/mas/core/store/StorageProvider", DoNotGenerateAcw=true)]
	public partial class StorageProvider : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/store/StorageProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StorageProvider); }
		}

		protected StorageProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getClientCredentialContainer;
#pragma warning disable 0169
		static Delegate GetGetClientCredentialContainerHandler ()
		{
			if (cb_getClientCredentialContainer == null)
				cb_getClientCredentialContainer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientCredentialContainer);
			return cb_getClientCredentialContainer;
		}

		static IntPtr n_GetClientCredentialContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.StorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.StorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientCredentialContainer);
		}
#pragma warning restore 0169

		static IntPtr id_getClientCredentialContainer;
		public virtual unsafe global::Com.CA.Mas.Core.Store.IClientCredentialContainer ClientCredentialContainer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='StorageProvider']/method[@name='getClientCredentialContainer' and count(parameter)=0]"
			[Register ("getClientCredentialContainer", "()Lcom/ca/mas/core/store/ClientCredentialContainer;", "GetGetClientCredentialContainerHandler")]
			get {
				if (id_getClientCredentialContainer == IntPtr.Zero)
					id_getClientCredentialContainer = JNIEnv.GetMethodID (class_ref, "getClientCredentialContainer", "()Lcom/ca/mas/core/store/ClientCredentialContainer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IClientCredentialContainer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientCredentialContainer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IClientCredentialContainer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientCredentialContainer", "()Lcom/ca/mas/core/store/ClientCredentialContainer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasValidStore;
#pragma warning disable 0169
		static Delegate GetHasValidStoreHandler ()
		{
			if (cb_hasValidStore == null)
				cb_hasValidStore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasValidStore);
			return cb_hasValidStore;
		}

		static bool n_HasValidStore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.StorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.StorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasValidStore;
		}
#pragma warning restore 0169

		static IntPtr id_hasValidStore;
		public virtual unsafe bool HasValidStore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='StorageProvider']/method[@name='hasValidStore' and count(parameter)=0]"
			[Register ("hasValidStore", "()Z", "GetHasValidStoreHandler")]
			get {
				if (id_hasValidStore == IntPtr.Zero)
					id_hasValidStore = JNIEnv.GetMethodID (class_ref, "hasValidStore", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasValidStore);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasValidStore", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.CA.Mas.Core.Store.StorageProvider Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='StorageProvider']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/ca/mas/core/store/StorageProvider;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/ca/mas/core/store/StorageProvider;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.StorageProvider> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOAuthTokenContainer;
#pragma warning disable 0169
		static Delegate GetGetOAuthTokenContainerHandler ()
		{
			if (cb_getOAuthTokenContainer == null)
				cb_getOAuthTokenContainer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOAuthTokenContainer);
			return cb_getOAuthTokenContainer;
		}

		static IntPtr n_GetOAuthTokenContainer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.StorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.StorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OAuthTokenContainer);
		}
#pragma warning restore 0169

		static IntPtr id_getOAuthTokenContainer;
		public virtual unsafe global::Com.CA.Mas.Core.Store.IOAuthTokenContainer OAuthTokenContainer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='StorageProvider']/method[@name='getOAuthTokenContainer' and count(parameter)=0]"
			[Register ("getOAuthTokenContainer", "()Lcom/ca/mas/core/store/OAuthTokenContainer;", "GetGetOAuthTokenContainerHandler")]
			get {
				if (id_getOAuthTokenContainer == IntPtr.Zero)
					id_getOAuthTokenContainer = JNIEnv.GetMethodID (class_ref, "getOAuthTokenContainer", "()Lcom/ca/mas/core/store/OAuthTokenContainer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IOAuthTokenContainer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOAuthTokenContainer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.IOAuthTokenContainer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOAuthTokenContainer", "()Lcom/ca/mas/core/store/OAuthTokenContainer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenManager;
#pragma warning disable 0169
		static Delegate GetGetTokenManagerHandler ()
		{
			if (cb_getTokenManager == null)
				cb_getTokenManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenManager);
			return cb_getTokenManager;
		}

		static IntPtr n_GetTokenManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.StorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.StorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TokenManager);
		}
#pragma warning restore 0169

		static IntPtr id_getTokenManager;
		public virtual unsafe global::Com.CA.Mas.Core.Store.ITokenManager TokenManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='StorageProvider']/method[@name='getTokenManager' and count(parameter)=0]"
			[Register ("getTokenManager", "()Lcom/ca/mas/core/store/TokenManager;", "GetGetTokenManagerHandler")]
			get {
				if (id_getTokenManager == IntPtr.Zero)
					id_getTokenManager = JNIEnv.GetMethodID (class_ref, "getTokenManager", "()Lcom/ca/mas/core/store/TokenManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenManager", "()Lcom/ca/mas/core/store/TokenManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.StorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.StorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/class[@name='StorageProvider']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

	}
}
