using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Store {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenProvider']"
	[Register ("com/ca/mas/core/store/TokenProvider", "", "Com.CA.Mas.Core.Store.ITokenProviderInvoker")]
	public partial interface ITokenProvider : IJavaObject {

		global::Java.Security.IPrivateKey ClientPrivateKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenProvider']/method[@name='getClientPrivateKey' and count(parameter)=0]"
			[Register ("getClientPrivateKey", "()Ljava/security/PrivateKey;", "GetGetClientPrivateKeyHandler:Com.CA.Mas.Core.Store.ITokenProviderInvoker, MASFoundation")] get;
		}

		global::Java.Security.IPublicKey ClientPublicKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenProvider']/method[@name='getClientPublicKey' and count(parameter)=0]"
			[Register ("getClientPublicKey", "()Ljava/security/PublicKey;", "GetGetClientPublicKeyHandler:Com.CA.Mas.Core.Store.ITokenProviderInvoker, MASFoundation")] get;
		}

		global::Com.CA.Mas.Core.Token.IdToken IdToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenProvider']/method[@name='getIdToken' and count(parameter)=0]"
			[Register ("getIdToken", "()Lcom/ca/mas/core/token/IdToken;", "GetGetIdTokenHandler:Com.CA.Mas.Core.Store.ITokenProviderInvoker, MASFoundation")] get;
		}

		bool IsClientCertificateChainAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenProvider']/method[@name='isClientCertificateChainAvailable' and count(parameter)=0]"
			[Register ("isClientCertificateChainAvailable", "()Z", "GetIsClientCertificateChainAvailableHandler:Com.CA.Mas.Core.Store.ITokenProviderInvoker, MASFoundation")] get;
		}

		string MagIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenProvider']/method[@name='getMagIdentifier' and count(parameter)=0]"
			[Register ("getMagIdentifier", "()Ljava/lang/String;", "GetGetMagIdentifierHandler:Com.CA.Mas.Core.Store.ITokenProviderInvoker, MASFoundation")] get;
		}

		string UserProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenProvider']/method[@name='getUserProfile' and count(parameter)=0]"
			[Register ("getUserProfile", "()Ljava/lang/String;", "GetGetUserProfileHandler:Com.CA.Mas.Core.Store.ITokenProviderInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenProvider']/method[@name='createPrivateKey' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("createPrivateKey", "(Landroid/content/Context;I)Ljava/security/PrivateKey;", "GetCreatePrivateKey_Landroid_content_Context_IHandler:Com.CA.Mas.Core.Store.ITokenProviderInvoker, MASFoundation")]
		global::Java.Security.IPrivateKey CreatePrivateKey (global::Android.Content.Context p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenProvider']/method[@name='getClientCertificateChain' and count(parameter)=0]"
		[Register ("getClientCertificateChain", "()[Ljava/security/cert/X509Certificate;", "GetGetClientCertificateChainHandler:Com.CA.Mas.Core.Store.ITokenProviderInvoker, MASFoundation")]
		global::Java.Security.Cert.X509Certificate[] GetClientCertificateChain ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.store']/interface[@name='TokenProvider']/method[@name='getSecureIdToken' and count(parameter)=0]"
		[Register ("getSecureIdToken", "()[B", "GetGetSecureIdTokenHandler:Com.CA.Mas.Core.Store.ITokenProviderInvoker, MASFoundation")]
		byte[] GetSecureIdToken ();

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/store/TokenProvider", DoNotGenerateAcw=true)]
	internal class ITokenProviderInvoker : global::Java.Lang.Object, ITokenProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/store/TokenProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITokenProviderInvoker); }
		}

		IntPtr class_ref;

		public static ITokenProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITokenProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.store.TokenProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITokenProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getClientPrivateKey;
#pragma warning disable 0169
		static Delegate GetGetClientPrivateKeyHandler ()
		{
			if (cb_getClientPrivateKey == null)
				cb_getClientPrivateKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientPrivateKey);
			return cb_getClientPrivateKey;
		}

		static IntPtr n_GetClientPrivateKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientPrivateKey);
		}
#pragma warning restore 0169

		IntPtr id_getClientPrivateKey;
		public unsafe global::Java.Security.IPrivateKey ClientPrivateKey {
			get {
				if (id_getClientPrivateKey == IntPtr.Zero)
					id_getClientPrivateKey = JNIEnv.GetMethodID (class_ref, "getClientPrivateKey", "()Ljava/security/PrivateKey;");
				return global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientPrivateKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getClientPublicKey;
#pragma warning disable 0169
		static Delegate GetGetClientPublicKeyHandler ()
		{
			if (cb_getClientPublicKey == null)
				cb_getClientPublicKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientPublicKey);
			return cb_getClientPublicKey;
		}

		static IntPtr n_GetClientPublicKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientPublicKey);
		}
#pragma warning restore 0169

		IntPtr id_getClientPublicKey;
		public unsafe global::Java.Security.IPublicKey ClientPublicKey {
			get {
				if (id_getClientPublicKey == IntPtr.Zero)
					id_getClientPublicKey = JNIEnv.GetMethodID (class_ref, "getClientPublicKey", "()Ljava/security/PublicKey;");
				return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientPublicKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIdToken;
#pragma warning disable 0169
		static Delegate GetGetIdTokenHandler ()
		{
			if (cb_getIdToken == null)
				cb_getIdToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdToken);
			return cb_getIdToken;
		}

		static IntPtr n_GetIdToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IdToken);
		}
#pragma warning restore 0169

		IntPtr id_getIdToken;
		public unsafe global::Com.CA.Mas.Core.Token.IdToken IdToken {
			get {
				if (id_getIdToken == IntPtr.Zero)
					id_getIdToken = JNIEnv.GetMethodID (class_ref, "getIdToken", "()Lcom/ca/mas/core/token/IdToken;");
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.IdToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isClientCertificateChainAvailable;
#pragma warning disable 0169
		static Delegate GetIsClientCertificateChainAvailableHandler ()
		{
			if (cb_isClientCertificateChainAvailable == null)
				cb_isClientCertificateChainAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClientCertificateChainAvailable);
			return cb_isClientCertificateChainAvailable;
		}

		static bool n_IsClientCertificateChainAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClientCertificateChainAvailable;
		}
#pragma warning restore 0169

		IntPtr id_isClientCertificateChainAvailable;
		public unsafe bool IsClientCertificateChainAvailable {
			get {
				if (id_isClientCertificateChainAvailable == IntPtr.Zero)
					id_isClientCertificateChainAvailable = JNIEnv.GetMethodID (class_ref, "isClientCertificateChainAvailable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClientCertificateChainAvailable);
			}
		}

		static Delegate cb_getMagIdentifier;
#pragma warning disable 0169
		static Delegate GetGetMagIdentifierHandler ()
		{
			if (cb_getMagIdentifier == null)
				cb_getMagIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagIdentifier);
			return cb_getMagIdentifier;
		}

		static IntPtr n_GetMagIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MagIdentifier);
		}
#pragma warning restore 0169

		IntPtr id_getMagIdentifier;
		public unsafe string MagIdentifier {
			get {
				if (id_getMagIdentifier == IntPtr.Zero)
					id_getMagIdentifier = JNIEnv.GetMethodID (class_ref, "getMagIdentifier", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMagIdentifier), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserProfile;
#pragma warning disable 0169
		static Delegate GetGetUserProfileHandler ()
		{
			if (cb_getUserProfile == null)
				cb_getUserProfile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserProfile);
			return cb_getUserProfile;
		}

		static IntPtr n_GetUserProfile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserProfile);
		}
#pragma warning restore 0169

		IntPtr id_getUserProfile;
		public unsafe string UserProfile {
			get {
				if (id_getUserProfile == IntPtr.Zero)
					id_getUserProfile = JNIEnv.GetMethodID (class_ref, "getUserProfile", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserProfile), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_createPrivateKey_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetCreatePrivateKey_Landroid_content_Context_IHandler ()
		{
			if (cb_createPrivateKey_Landroid_content_Context_I == null)
				cb_createPrivateKey_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CreatePrivateKey_Landroid_content_Context_I);
			return cb_createPrivateKey_Landroid_content_Context_I;
		}

		static IntPtr n_CreatePrivateKey_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.CA.Mas.Core.Store.ITokenProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePrivateKey (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createPrivateKey_Landroid_content_Context_I;
		public unsafe global::Java.Security.IPrivateKey CreatePrivateKey (global::Android.Content.Context p0, int p1)
		{
			if (id_createPrivateKey_Landroid_content_Context_I == IntPtr.Zero)
				id_createPrivateKey_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "createPrivateKey", "(Landroid/content/Context;I)Ljava/security/PrivateKey;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Java.Security.IPrivateKey __ret = global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createPrivateKey_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getClientCertificateChain;
#pragma warning disable 0169
		static Delegate GetGetClientCertificateChainHandler ()
		{
			if (cb_getClientCertificateChain == null)
				cb_getClientCertificateChain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientCertificateChain);
			return cb_getClientCertificateChain;
		}

		static IntPtr n_GetClientCertificateChain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetClientCertificateChain ());
		}
#pragma warning restore 0169

		IntPtr id_getClientCertificateChain;
		public unsafe global::Java.Security.Cert.X509Certificate[] GetClientCertificateChain ()
		{
			if (id_getClientCertificateChain == IntPtr.Zero)
				id_getClientCertificateChain = JNIEnv.GetMethodID (class_ref, "getClientCertificateChain", "()[Ljava/security/cert/X509Certificate;");
			return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientCertificateChain), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
		}

		static Delegate cb_getSecureIdToken;
#pragma warning disable 0169
		static Delegate GetGetSecureIdTokenHandler ()
		{
			if (cb_getSecureIdToken == null)
				cb_getSecureIdToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecureIdToken);
			return cb_getSecureIdToken;
		}

		static IntPtr n_GetSecureIdToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Store.ITokenProvider __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Store.ITokenProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSecureIdToken ());
		}
#pragma warning restore 0169

		IntPtr id_getSecureIdToken;
		public unsafe byte[] GetSecureIdToken ()
		{
			if (id_getSecureIdToken == IntPtr.Zero)
				id_getSecureIdToken = JNIEnv.GetMethodID (class_ref, "getSecureIdToken", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecureIdToken), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}

}
