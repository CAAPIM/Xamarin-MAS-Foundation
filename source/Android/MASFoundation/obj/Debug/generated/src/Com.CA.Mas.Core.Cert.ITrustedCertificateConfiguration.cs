using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Cert {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.cert']/interface[@name='TrustedCertificateConfiguration']"
	[Register ("com/ca/mas/core/cert/TrustedCertificateConfiguration", "", "Com.CA.Mas.Core.Cert.ITrustedCertificateConfigurationInvoker")]
	public partial interface ITrustedCertificateConfiguration : IJavaObject {

		bool IsAlsoTrustPublicPki {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/interface[@name='TrustedCertificateConfiguration']/method[@name='isAlsoTrustPublicPki' and count(parameter)=0]"
			[Register ("isAlsoTrustPublicPki", "()Z", "GetIsAlsoTrustPublicPkiHandler:Com.CA.Mas.Core.Cert.ITrustedCertificateConfigurationInvoker, MASFoundation")] get;
		}

		global::System.Collections.Generic.ICollection<global::Java.Security.Cert.X509Certificate> TrustedCertificateAnchors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/interface[@name='TrustedCertificateConfiguration']/method[@name='getTrustedCertificateAnchors' and count(parameter)=0]"
			[Register ("getTrustedCertificateAnchors", "()Ljava/util/Collection;", "GetGetTrustedCertificateAnchorsHandler:Com.CA.Mas.Core.Cert.ITrustedCertificateConfigurationInvoker, MASFoundation")] get;
		}

		global::System.Collections.Generic.ICollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash> TrustedCertificatePinnedPublicKeyHashes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.cert']/interface[@name='TrustedCertificateConfiguration']/method[@name='getTrustedCertificatePinnedPublicKeyHashes' and count(parameter)=0]"
			[Register ("getTrustedCertificatePinnedPublicKeyHashes", "()Ljava/util/Collection;", "GetGetTrustedCertificatePinnedPublicKeyHashesHandler:Com.CA.Mas.Core.Cert.ITrustedCertificateConfigurationInvoker, MASFoundation")] get;
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/core/cert/TrustedCertificateConfiguration", DoNotGenerateAcw=true)]
	internal class ITrustedCertificateConfigurationInvoker : global::Java.Lang.Object, ITrustedCertificateConfiguration {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/cert/TrustedCertificateConfiguration");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITrustedCertificateConfigurationInvoker); }
		}

		IntPtr class_ref;

		public static ITrustedCertificateConfiguration GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrustedCertificateConfiguration> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.cert.TrustedCertificateConfiguration"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrustedCertificateConfigurationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isAlsoTrustPublicPki;
#pragma warning disable 0169
		static Delegate GetIsAlsoTrustPublicPkiHandler ()
		{
			if (cb_isAlsoTrustPublicPki == null)
				cb_isAlsoTrustPublicPki = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAlsoTrustPublicPki);
			return cb_isAlsoTrustPublicPki;
		}

		static bool n_IsAlsoTrustPublicPki (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Cert.ITrustedCertificateConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Cert.ITrustedCertificateConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAlsoTrustPublicPki;
		}
#pragma warning restore 0169

		IntPtr id_isAlsoTrustPublicPki;
		public unsafe bool IsAlsoTrustPublicPki {
			get {
				if (id_isAlsoTrustPublicPki == IntPtr.Zero)
					id_isAlsoTrustPublicPki = JNIEnv.GetMethodID (class_ref, "isAlsoTrustPublicPki", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAlsoTrustPublicPki);
			}
		}

		static Delegate cb_getTrustedCertificateAnchors;
#pragma warning disable 0169
		static Delegate GetGetTrustedCertificateAnchorsHandler ()
		{
			if (cb_getTrustedCertificateAnchors == null)
				cb_getTrustedCertificateAnchors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrustedCertificateAnchors);
			return cb_getTrustedCertificateAnchors;
		}

		static IntPtr n_GetTrustedCertificateAnchors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Cert.ITrustedCertificateConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Cert.ITrustedCertificateConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Java.Security.Cert.X509Certificate>.ToLocalJniHandle (__this.TrustedCertificateAnchors);
		}
#pragma warning restore 0169

		IntPtr id_getTrustedCertificateAnchors;
		public unsafe global::System.Collections.Generic.ICollection<global::Java.Security.Cert.X509Certificate> TrustedCertificateAnchors {
			get {
				if (id_getTrustedCertificateAnchors == IntPtr.Zero)
					id_getTrustedCertificateAnchors = JNIEnv.GetMethodID (class_ref, "getTrustedCertificateAnchors", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Java.Security.Cert.X509Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrustedCertificateAnchors), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTrustedCertificatePinnedPublicKeyHashes;
#pragma warning disable 0169
		static Delegate GetGetTrustedCertificatePinnedPublicKeyHashesHandler ()
		{
			if (cb_getTrustedCertificatePinnedPublicKeyHashes == null)
				cb_getTrustedCertificatePinnedPublicKeyHashes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrustedCertificatePinnedPublicKeyHashes);
			return cb_getTrustedCertificatePinnedPublicKeyHashes;
		}

		static IntPtr n_GetTrustedCertificatePinnedPublicKeyHashes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Cert.ITrustedCertificateConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Cert.ITrustedCertificateConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash>.ToLocalJniHandle (__this.TrustedCertificatePinnedPublicKeyHashes);
		}
#pragma warning restore 0169

		IntPtr id_getTrustedCertificatePinnedPublicKeyHashes;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash> TrustedCertificatePinnedPublicKeyHashes {
			get {
				if (id_getTrustedCertificatePinnedPublicKeyHashes == IntPtr.Zero)
					id_getTrustedCertificatePinnedPublicKeyHashes = JNIEnv.GetMethodID (class_ref, "getTrustedCertificatePinnedPublicKeyHashes", "()Ljava/util/Collection;");
				return global::Android.Runtime.JavaCollection<global::Com.CA.Mas.Core.Cert.PublicKeyHash>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrustedCertificatePinnedPublicKeyHashes), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
