using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSecurityConfiguration.Builder']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASSecurityConfiguration$Builder", DoNotGenerateAcw=true)]
	public partial class MASSecurityConfigurationBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASSecurityConfiguration$Builder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASSecurityConfigurationBuilder); }
		}

		protected MASSecurityConfigurationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSecurityConfiguration.Builder']/constructor[@name='MASSecurityConfiguration.Builder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASSecurityConfigurationBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASSecurityConfigurationBuilder)) {
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

		static Delegate cb_add_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Handler ()
		{
			if (cb_add_Ljava_lang_String_ == null)
				cb_add_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_String_);
			return cb_add_Ljava_lang_String_;
		}

		static IntPtr n_Add_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_publicKeyHash)
		{
			global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string publicKeyHash = JNIEnv.GetString (native_publicKeyHash, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (publicKeyHash));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSecurityConfiguration.Builder']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;", "GetAdd_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder Add (string publicKeyHash)
		{
			if (id_add_Ljava_lang_String_ == IntPtr.Zero)
				id_add_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;");
			IntPtr native_publicKeyHash = JNIEnv.NewString (publicKeyHash);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_publicKeyHash);

				global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_publicKeyHash);
			}
		}

		static Delegate cb_add_Ljava_security_cert_Certificate_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_security_cert_Certificate_Handler ()
		{
			if (cb_add_Ljava_security_cert_Certificate_ == null)
				cb_add_Ljava_security_cert_Certificate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_security_cert_Certificate_);
			return cb_add_Ljava_security_cert_Certificate_;
		}

		static IntPtr n_Add_Ljava_security_cert_Certificate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_certificate)
		{
			global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.Cert.Certificate certificate = global::Java.Lang.Object.GetObject<global::Java.Security.Cert.Certificate> (native_certificate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (certificate));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_security_cert_Certificate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSecurityConfiguration.Builder']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.security.cert.Certificate']]"
		[Register ("add", "(Ljava/security/cert/Certificate;)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;", "GetAdd_Ljava_security_cert_Certificate_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder Add (global::Java.Security.Cert.Certificate certificate)
		{
			if (id_add_Ljava_security_cert_Certificate_ == IntPtr.Zero)
				id_add_Ljava_security_cert_Certificate_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/security/cert/Certificate;)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (certificate);

				global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_security_cert_Certificate_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/security/cert/Certificate;)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSecurityConfiguration.Builder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/ca/mas/foundation/MASSecurityConfiguration;", "GetBuildHandler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.IMASSecurityConfiguration Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/ca/mas/foundation/MASSecurityConfiguration;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/ca/mas/foundation/MASSecurityConfiguration;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_host_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetHost_Landroid_net_Uri_Handler ()
		{
			if (cb_host_Landroid_net_Uri_ == null)
				cb_host_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Host_Landroid_net_Uri_);
			return cb_host_Landroid_net_Uri_;
		}

		static IntPtr n_Host_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_host)
		{
			global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri host = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_host, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Host (host));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_host_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSecurityConfiguration.Builder']/method[@name='host' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("host", "(Landroid/net/Uri;)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;", "GetHost_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder Host (global::Android.Net.Uri host)
		{
			if (id_host_Landroid_net_Uri_ == IntPtr.Zero)
				id_host_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "host", "(Landroid/net/Uri;)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (host);

				global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_host_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "host", "(Landroid/net/Uri;)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isPublic_Z;
#pragma warning disable 0169
		static Delegate GetIsPublic_ZHandler ()
		{
			if (cb_isPublic_Z == null)
				cb_isPublic_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_IsPublic_Z);
			return cb_isPublic_Z;
		}

		static IntPtr n_IsPublic_Z (IntPtr jnienv, IntPtr native__this, bool p)
		{
			global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsPublic (p));
		}
#pragma warning restore 0169

		static IntPtr id_isPublic_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSecurityConfiguration.Builder']/method[@name='isPublic' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isPublic", "(Z)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;", "GetIsPublic_ZHandler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder IsPublic (bool p)
		{
			if (id_isPublic_Z == IntPtr.Zero)
				id_isPublic_Z = JNIEnv.GetMethodID (class_ref, "isPublic", "(Z)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isPublic_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPublic", "(Z)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_trustPublicPKI_Z;
#pragma warning disable 0169
		static Delegate GetTrustPublicPKI_ZHandler ()
		{
			if (cb_trustPublicPKI_Z == null)
				cb_trustPublicPKI_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_TrustPublicPKI_Z);
			return cb_trustPublicPKI_Z;
		}

		static IntPtr n_TrustPublicPKI_Z (IntPtr jnienv, IntPtr native__this, bool trust)
		{
			global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrustPublicPKI (trust));
		}
#pragma warning restore 0169

		static IntPtr id_trustPublicPKI_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSecurityConfiguration.Builder']/method[@name='trustPublicPKI' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("trustPublicPKI", "(Z)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;", "GetTrustPublicPKI_ZHandler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder TrustPublicPKI (bool trust)
		{
			if (id_trustPublicPKI_Z == IntPtr.Zero)
				id_trustPublicPKI_Z = JNIEnv.GetMethodID (class_ref, "trustPublicPKI", "(Z)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (trust);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trustPublicPKI_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trustPublicPKI", "(Z)Lcom/ca/mas/foundation/MASSecurityConfiguration$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASSecurityConfiguration']"
	[Register ("com/ca/mas/foundation/MASSecurityConfiguration", "", "Com.CA.Mas.Foundation.IMASSecurityConfigurationInvoker")]
	public partial interface IMASSecurityConfiguration : IJavaObject {

		global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> Certificates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASSecurityConfiguration']/method[@name='getCertificates' and count(parameter)=0]"
			[Register ("getCertificates", "()Ljava/util/List;", "GetGetCertificatesHandler:Com.CA.Mas.Foundation.IMASSecurityConfigurationInvoker, MASFoundation")] get;
		}

		global::Android.Net.Uri Host {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASSecurityConfiguration']/method[@name='getHost' and count(parameter)=0]"
			[Register ("getHost", "()Landroid/net/Uri;", "GetGetHostHandler:Com.CA.Mas.Foundation.IMASSecurityConfigurationInvoker, MASFoundation")] get;
		}

		bool IsPublic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASSecurityConfiguration']/method[@name='isPublic' and count(parameter)=0]"
			[Register ("isPublic", "()Z", "GetIsPublicHandler:Com.CA.Mas.Foundation.IMASSecurityConfigurationInvoker, MASFoundation")] get;
		}

		global::System.Collections.Generic.IList<string> PublicKeyHashes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASSecurityConfiguration']/method[@name='getPublicKeyHashes' and count(parameter)=0]"
			[Register ("getPublicKeyHashes", "()Ljava/util/List;", "GetGetPublicKeyHashesHandler:Com.CA.Mas.Foundation.IMASSecurityConfigurationInvoker, MASFoundation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASSecurityConfiguration']/method[@name='trustPublicPki' and count(parameter)=0]"
		[Register ("trustPublicPki", "()Z", "GetTrustPublicPkiHandler:Com.CA.Mas.Foundation.IMASSecurityConfigurationInvoker, MASFoundation")]
		bool TrustPublicPki ();

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASSecurityConfiguration", DoNotGenerateAcw=true)]
	internal class IMASSecurityConfigurationInvoker : global::Java.Lang.Object, IMASSecurityConfiguration {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/MASSecurityConfiguration");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASSecurityConfigurationInvoker); }
		}

		IntPtr class_ref;

		public static IMASSecurityConfiguration GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASSecurityConfiguration> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.MASSecurityConfiguration"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASSecurityConfigurationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCertificates;
#pragma warning disable 0169
		static Delegate GetGetCertificatesHandler ()
		{
			if (cb_getCertificates == null)
				cb_getCertificates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCertificates);
			return cb_getCertificates;
		}

		static IntPtr n_GetCertificates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASSecurityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.ToLocalJniHandle (__this.Certificates);
		}
#pragma warning restore 0169

		IntPtr id_getCertificates;
		public unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.Certificate> Certificates {
			get {
				if (id_getCertificates == IntPtr.Zero)
					id_getCertificates = JNIEnv.GetMethodID (class_ref, "getCertificates", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Java.Security.Cert.Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCertificates), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHost;
#pragma warning disable 0169
		static Delegate GetGetHostHandler ()
		{
			if (cb_getHost == null)
				cb_getHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHost);
			return cb_getHost;
		}

		static IntPtr n_GetHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASSecurityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Host);
		}
#pragma warning restore 0169

		IntPtr id_getHost;
		public unsafe global::Android.Net.Uri Host {
			get {
				if (id_getHost == IntPtr.Zero)
					id_getHost = JNIEnv.GetMethodID (class_ref, "getHost", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHost), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isPublic;
#pragma warning disable 0169
		static Delegate GetIsPublicHandler ()
		{
			if (cb_isPublic == null)
				cb_isPublic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPublic);
			return cb_isPublic;
		}

		static bool n_IsPublic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASSecurityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPublic;
		}
#pragma warning restore 0169

		IntPtr id_isPublic;
		public unsafe bool IsPublic {
			get {
				if (id_isPublic == IntPtr.Zero)
					id_isPublic = JNIEnv.GetMethodID (class_ref, "isPublic", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPublic);
			}
		}

		static Delegate cb_getPublicKeyHashes;
#pragma warning disable 0169
		static Delegate GetGetPublicKeyHashesHandler ()
		{
			if (cb_getPublicKeyHashes == null)
				cb_getPublicKeyHashes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPublicKeyHashes);
			return cb_getPublicKeyHashes;
		}

		static IntPtr n_GetPublicKeyHashes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASSecurityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.PublicKeyHashes);
		}
#pragma warning restore 0169

		IntPtr id_getPublicKeyHashes;
		public unsafe global::System.Collections.Generic.IList<string> PublicKeyHashes {
			get {
				if (id_getPublicKeyHashes == IntPtr.Zero)
					id_getPublicKeyHashes = JNIEnv.GetMethodID (class_ref, "getPublicKeyHashes", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublicKeyHashes), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_trustPublicPki;
#pragma warning disable 0169
		static Delegate GetTrustPublicPkiHandler ()
		{
			if (cb_trustPublicPki == null)
				cb_trustPublicPki = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_TrustPublicPki);
			return cb_trustPublicPki;
		}

		static bool n_TrustPublicPki (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASSecurityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrustPublicPki ();
		}
#pragma warning restore 0169

		IntPtr id_trustPublicPki;
		public unsafe bool TrustPublicPki ()
		{
			if (id_trustPublicPki == IntPtr.Zero)
				id_trustPublicPki = JNIEnv.GetMethodID (class_ref, "trustPublicPki", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_trustPublicPki);
		}

	}

}
