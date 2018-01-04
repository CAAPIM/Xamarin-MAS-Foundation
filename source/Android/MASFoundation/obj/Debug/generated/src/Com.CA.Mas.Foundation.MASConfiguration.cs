using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASConfiguration", DoNotGenerateAcw=true)]
	public partial class MASConfiguration : global::Java.Lang.Object {


		static IntPtr SECURITY_CONFIGURATION_CHANGED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/field[@name='SECURITY_CONFIGURATION_CHANGED']"
		[Register ("SECURITY_CONFIGURATION_CHANGED")]
		public static global::Com.CA.Mas.Core.EventDispatcher SecurityConfigurationChanged {
			get {
				if (SECURITY_CONFIGURATION_CHANGED_jfieldId == IntPtr.Zero)
					SECURITY_CONFIGURATION_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURITY_CONFIGURATION_CHANGED", "Lcom/ca/mas/core/EventDispatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SECURITY_CONFIGURATION_CHANGED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.EventDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SECURITY_CONFIGURATION_RESET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/field[@name='SECURITY_CONFIGURATION_RESET']"
		[Register ("SECURITY_CONFIGURATION_RESET")]
		public static global::Com.CA.Mas.Core.EventDispatcher SecurityConfigurationReset {
			get {
				if (SECURITY_CONFIGURATION_RESET_jfieldId == IntPtr.Zero)
					SECURITY_CONFIGURATION_RESET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURITY_CONFIGURATION_RESET", "Lcom/ca/mas/core/EventDispatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SECURITY_CONFIGURATION_RESET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.EventDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASConfiguration); }
		}

		protected MASConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/constructor[@name='MASConfiguration' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		protected unsafe MASConfiguration (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (MASConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getApplicationDescription;
#pragma warning disable 0169
		static Delegate GetGetApplicationDescriptionHandler ()
		{
			if (cb_getApplicationDescription == null)
				cb_getApplicationDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationDescription);
			return cb_getApplicationDescription;
		}

		static IntPtr n_GetApplicationDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationDescription);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationDescription;
		public virtual unsafe string ApplicationDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getApplicationDescription' and count(parameter)=0]"
			[Register ("getApplicationDescription", "()Ljava/lang/String;", "GetGetApplicationDescriptionHandler")]
			get {
				if (id_getApplicationDescription == IntPtr.Zero)
					id_getApplicationDescription = JNIEnv.GetMethodID (class_ref, "getApplicationDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApplicationName;
#pragma warning disable 0169
		static Delegate GetGetApplicationNameHandler ()
		{
			if (cb_getApplicationName == null)
				cb_getApplicationName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationName);
			return cb_getApplicationName;
		}

		static IntPtr n_GetApplicationName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationName);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationName;
		public virtual unsafe string ApplicationName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getApplicationName' and count(parameter)=0]"
			[Register ("getApplicationName", "()Ljava/lang/String;", "GetGetApplicationNameHandler")]
			get {
				if (id_getApplicationName == IntPtr.Zero)
					id_getApplicationName = JNIEnv.GetMethodID (class_ref, "getApplicationName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApplicationOrganization;
#pragma warning disable 0169
		static Delegate GetGetApplicationOrganizationHandler ()
		{
			if (cb_getApplicationOrganization == null)
				cb_getApplicationOrganization = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationOrganization);
			return cb_getApplicationOrganization;
		}

		static IntPtr n_GetApplicationOrganization (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationOrganization);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationOrganization;
		public virtual unsafe string ApplicationOrganization {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getApplicationOrganization' and count(parameter)=0]"
			[Register ("getApplicationOrganization", "()Ljava/lang/String;", "GetGetApplicationOrganizationHandler")]
			get {
				if (id_getApplicationOrganization == IntPtr.Zero)
					id_getApplicationOrganization = JNIEnv.GetMethodID (class_ref, "getApplicationOrganization", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationOrganization), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationOrganization", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApplicationRegisteredBy;
#pragma warning disable 0169
		static Delegate GetGetApplicationRegisteredByHandler ()
		{
			if (cb_getApplicationRegisteredBy == null)
				cb_getApplicationRegisteredBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationRegisteredBy);
			return cb_getApplicationRegisteredBy;
		}

		static IntPtr n_GetApplicationRegisteredBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationRegisteredBy);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationRegisteredBy;
		public virtual unsafe string ApplicationRegisteredBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getApplicationRegisteredBy' and count(parameter)=0]"
			[Register ("getApplicationRegisteredBy", "()Ljava/lang/String;", "GetGetApplicationRegisteredByHandler")]
			get {
				if (id_getApplicationRegisteredBy == IntPtr.Zero)
					id_getApplicationRegisteredBy = JNIEnv.GetMethodID (class_ref, "getApplicationRegisteredBy", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationRegisteredBy), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationRegisteredBy", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApplicationType;
#pragma warning disable 0169
		static Delegate GetGetApplicationTypeHandler ()
		{
			if (cb_getApplicationType == null)
				cb_getApplicationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationType);
			return cb_getApplicationType;
		}

		static IntPtr n_GetApplicationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationType);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationType;
		public virtual unsafe string ApplicationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getApplicationType' and count(parameter)=0]"
			[Register ("getApplicationType", "()Ljava/lang/String;", "GetGetApplicationTypeHandler")]
			get {
				if (id_getApplicationType == IntPtr.Zero)
					id_getApplicationType = JNIEnv.GetMethodID (class_ref, "getApplicationType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCertificateAdvancedRenewTimeframe;
#pragma warning disable 0169
		static Delegate GetGetCertificateAdvancedRenewTimeframeHandler ()
		{
			if (cb_getCertificateAdvancedRenewTimeframe == null)
				cb_getCertificateAdvancedRenewTimeframe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCertificateAdvancedRenewTimeframe);
			return cb_getCertificateAdvancedRenewTimeframe;
		}

		static int n_GetCertificateAdvancedRenewTimeframe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CertificateAdvancedRenewTimeframe;
		}
#pragma warning restore 0169

		static Delegate cb_setCertificateAdvancedRenewTimeframe_I;
#pragma warning disable 0169
		static Delegate GetSetCertificateAdvancedRenewTimeframe_IHandler ()
		{
			if (cb_setCertificateAdvancedRenewTimeframe_I == null)
				cb_setCertificateAdvancedRenewTimeframe_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCertificateAdvancedRenewTimeframe_I);
			return cb_setCertificateAdvancedRenewTimeframe_I;
		}

		static void n_SetCertificateAdvancedRenewTimeframe_I (IntPtr jnienv, IntPtr native__this, int numDays)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CertificateAdvancedRenewTimeframe = numDays;
		}
#pragma warning restore 0169

		static IntPtr id_getCertificateAdvancedRenewTimeframe;
		static IntPtr id_setCertificateAdvancedRenewTimeframe_I;
		public virtual unsafe int CertificateAdvancedRenewTimeframe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getCertificateAdvancedRenewTimeframe' and count(parameter)=0]"
			[Register ("getCertificateAdvancedRenewTimeframe", "()I", "GetGetCertificateAdvancedRenewTimeframeHandler")]
			get {
				if (id_getCertificateAdvancedRenewTimeframe == IntPtr.Zero)
					id_getCertificateAdvancedRenewTimeframe = JNIEnv.GetMethodID (class_ref, "getCertificateAdvancedRenewTimeframe", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCertificateAdvancedRenewTimeframe);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCertificateAdvancedRenewTimeframe", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='setCertificateAdvancedRenewTimeframe' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCertificateAdvancedRenewTimeframe", "(I)V", "GetSetCertificateAdvancedRenewTimeframe_IHandler")]
			set {
				if (id_setCertificateAdvancedRenewTimeframe_I == IntPtr.Zero)
					id_setCertificateAdvancedRenewTimeframe_I = JNIEnv.GetMethodID (class_ref, "setCertificateAdvancedRenewTimeframe", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCertificateAdvancedRenewTimeframe_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCertificateAdvancedRenewTimeframe", "(I)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getCurrentConfiguration;
		public static unsafe global::Com.CA.Mas.Foundation.MASConfiguration CurrentConfiguration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getCurrentConfiguration' and count(parameter)=0]"
			[Register ("getCurrentConfiguration", "()Lcom/ca/mas/foundation/MASConfiguration;", "GetGetCurrentConfigurationHandler")]
			get {
				if (id_getCurrentConfiguration == IntPtr.Zero)
					id_getCurrentConfiguration = JNIEnv.GetStaticMethodID (class_ref, "getCurrentConfiguration", "()Lcom/ca/mas/foundation/MASConfiguration;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentConfiguration), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGatewayCertificates;
#pragma warning disable 0169
		static Delegate GetGetGatewayCertificatesHandler ()
		{
			if (cb_getGatewayCertificates == null)
				cb_getGatewayCertificates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGatewayCertificates);
			return cb_getGatewayCertificates;
		}

		static IntPtr n_GetGatewayCertificates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Java.Security.Cert.X509Certificate>.ToLocalJniHandle (__this.GatewayCertificates);
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayCertificates;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Security.Cert.X509Certificate> GatewayCertificates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getGatewayCertificates' and count(parameter)=0]"
			[Register ("getGatewayCertificates", "()Ljava/util/Collection;", "GetGetGatewayCertificatesHandler")]
			get {
				if (id_getGatewayCertificates == IntPtr.Zero)
					id_getGatewayCertificates = JNIEnv.GetMethodID (class_ref, "getGatewayCertificates", "()Ljava/util/Collection;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<global::Java.Security.Cert.X509Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGatewayCertificates), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<global::Java.Security.Cert.X509Certificate>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGatewayCertificates", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGatewayHostName;
#pragma warning disable 0169
		static Delegate GetGetGatewayHostNameHandler ()
		{
			if (cb_getGatewayHostName == null)
				cb_getGatewayHostName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGatewayHostName);
			return cb_getGatewayHostName;
		}

		static IntPtr n_GetGatewayHostName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GatewayHostName);
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayHostName;
		public virtual unsafe string GatewayHostName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getGatewayHostName' and count(parameter)=0]"
			[Register ("getGatewayHostName", "()Ljava/lang/String;", "GetGetGatewayHostNameHandler")]
			get {
				if (id_getGatewayHostName == IntPtr.Zero)
					id_getGatewayHostName = JNIEnv.GetMethodID (class_ref, "getGatewayHostName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGatewayHostName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGatewayHostName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGatewayPort;
#pragma warning disable 0169
		static Delegate GetGetGatewayPortHandler ()
		{
			if (cb_getGatewayPort == null)
				cb_getGatewayPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGatewayPort);
			return cb_getGatewayPort;
		}

		static int n_GetGatewayPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GatewayPort;
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayPort;
		public virtual unsafe int GatewayPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getGatewayPort' and count(parameter)=0]"
			[Register ("getGatewayPort", "()I", "GetGetGatewayPortHandler")]
			get {
				if (id_getGatewayPort == IntPtr.Zero)
					id_getGatewayPort = JNIEnv.GetMethodID (class_ref, "getGatewayPort", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGatewayPort);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGatewayPort", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getGatewayPrefix;
#pragma warning disable 0169
		static Delegate GetGetGatewayPrefixHandler ()
		{
			if (cb_getGatewayPrefix == null)
				cb_getGatewayPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGatewayPrefix);
			return cb_getGatewayPrefix;
		}

		static IntPtr n_GetGatewayPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GatewayPrefix);
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayPrefix;
		public virtual unsafe string GatewayPrefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getGatewayPrefix' and count(parameter)=0]"
			[Register ("getGatewayPrefix", "()Ljava/lang/String;", "GetGetGatewayPrefixHandler")]
			get {
				if (id_getGatewayPrefix == IntPtr.Zero)
					id_getGatewayPrefix = JNIEnv.GetMethodID (class_ref, "getGatewayPrefix", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGatewayPrefix), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGatewayPrefix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGatewayUrl;
#pragma warning disable 0169
		static Delegate GetGetGatewayUrlHandler ()
		{
			if (cb_getGatewayUrl == null)
				cb_getGatewayUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGatewayUrl);
			return cb_getGatewayUrl;
		}

		static IntPtr n_GetGatewayUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GatewayUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getGatewayUrl;
		public virtual unsafe global::Java.Net.URL GatewayUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getGatewayUrl' and count(parameter)=0]"
			[Register ("getGatewayUrl", "()Ljava/net/URL;", "GetGetGatewayUrlHandler")]
			get {
				if (id_getGatewayUrl == IntPtr.Zero)
					id_getGatewayUrl = JNIEnv.GetMethodID (class_ref, "getGatewayUrl", "()Ljava/net/URL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGatewayUrl), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGatewayUrl", "()Ljava/net/URL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEnabledPublicKeyPinning;
#pragma warning disable 0169
		static Delegate GetIsEnabledPublicKeyPinningHandler ()
		{
			if (cb_isEnabledPublicKeyPinning == null)
				cb_isEnabledPublicKeyPinning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabledPublicKeyPinning);
			return cb_isEnabledPublicKeyPinning;
		}

		static bool n_IsEnabledPublicKeyPinning (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabledPublicKeyPinning;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabledPublicKeyPinning;
		public virtual unsafe bool IsEnabledPublicKeyPinning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='isEnabledPublicKeyPinning' and count(parameter)=0]"
			[Register ("isEnabledPublicKeyPinning", "()Z", "GetIsEnabledPublicKeyPinningHandler")]
			get {
				if (id_isEnabledPublicKeyPinning == IntPtr.Zero)
					id_isEnabledPublicKeyPinning = JNIEnv.GetMethodID (class_ref, "isEnabledPublicKeyPinning", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabledPublicKeyPinning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabledPublicKeyPinning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isEnabledTrustedPublicPKI;
#pragma warning disable 0169
		static Delegate GetIsEnabledTrustedPublicPKIHandler ()
		{
			if (cb_isEnabledTrustedPublicPKI == null)
				cb_isEnabledTrustedPublicPKI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabledTrustedPublicPKI);
			return cb_isEnabledTrustedPublicPKI;
		}

		static bool n_IsEnabledTrustedPublicPKI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabledTrustedPublicPKI;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabledTrustedPublicPKI;
		public virtual unsafe bool IsEnabledTrustedPublicPKI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='isEnabledTrustedPublicPKI' and count(parameter)=0]"
			[Register ("isEnabledTrustedPublicPKI", "()Z", "GetIsEnabledTrustedPublicPKIHandler")]
			get {
				if (id_isEnabledTrustedPublicPKI == IntPtr.Zero)
					id_isEnabledTrustedPublicPKI = JNIEnv.GetMethodID (class_ref, "isEnabledTrustedPublicPKI", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabledTrustedPublicPKI);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabledTrustedPublicPKI", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLoaded;
#pragma warning disable 0169
		static Delegate GetIsLoadedHandler ()
		{
			if (cb_isLoaded == null)
				cb_isLoaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoaded);
			return cb_isLoaded;
		}

		static bool n_IsLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoaded;
		}
#pragma warning restore 0169

		static IntPtr id_isLoaded;
		public virtual unsafe bool IsLoaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='isLoaded' and count(parameter)=0]"
			[Register ("isLoaded", "()Z", "GetIsLoadedHandler")]
			get {
				if (id_isLoaded == IntPtr.Zero)
					id_isLoaded = JNIEnv.GetMethodID (class_ref, "isLoaded", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoaded);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLoaded", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSsoEnabled;
#pragma warning disable 0169
		static Delegate GetIsSsoEnabledHandler ()
		{
			if (cb_isSsoEnabled == null)
				cb_isSsoEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSsoEnabled);
			return cb_isSsoEnabled;
		}

		static bool n_IsSsoEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSsoEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isSsoEnabled;
		public virtual unsafe bool IsSsoEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='isSsoEnabled' and count(parameter)=0]"
			[Register ("isSsoEnabled", "()Z", "GetIsSsoEnabledHandler")]
			get {
				if (id_isSsoEnabled == IntPtr.Zero)
					id_isSsoEnabled = JNIEnv.GetMethodID (class_ref, "isSsoEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSsoEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSsoEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLocationIsRequired;
#pragma warning disable 0169
		static Delegate GetGetLocationIsRequiredHandler ()
		{
			if (cb_getLocationIsRequired == null)
				cb_getLocationIsRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetLocationIsRequired);
			return cb_getLocationIsRequired;
		}

		static bool n_GetLocationIsRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationIsRequired;
		}
#pragma warning restore 0169

		static IntPtr id_getLocationIsRequired;
		public virtual unsafe bool LocationIsRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getLocationIsRequired' and count(parameter)=0]"
			[Register ("getLocationIsRequired", "()Z", "GetGetLocationIsRequiredHandler")]
			get {
				if (id_getLocationIsRequired == IntPtr.Zero)
					id_getLocationIsRequired = JNIEnv.GetMethodID (class_ref, "getLocationIsRequired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getLocationIsRequired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocationIsRequired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_;
#pragma warning disable 0169
		static Delegate GetAddSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_Handler ()
		{
			if (cb_addSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_ == null)
				cb_addSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_);
			return cb_addSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_;
		}

		static void n_AddSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_securityConfiguration)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.IMASSecurityConfiguration securityConfiguration = (global::Com.CA.Mas.Foundation.IMASSecurityConfiguration)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (native_securityConfiguration, JniHandleOwnership.DoNotTransfer);
			__this.AddSecurityConfiguration (securityConfiguration);
		}
#pragma warning restore 0169

		static IntPtr id_addSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='addSecurityConfiguration' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASSecurityConfiguration']]"
		[Register ("addSecurityConfiguration", "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V", "GetAddSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_Handler")]
		public virtual unsafe void AddSecurityConfiguration (global::Com.CA.Mas.Foundation.IMASSecurityConfiguration securityConfiguration)
		{
			if (id_addSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_ == IntPtr.Zero)
				id_addSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_ = JNIEnv.GetMethodID (class_ref, "addSecurityConfiguration", "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (securityConfiguration);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSecurityConfiguration_Lcom_ca_mas_foundation_MASSecurityConfiguration_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSecurityConfiguration", "(Lcom/ca/mas/foundation/MASSecurityConfiguration;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getEndpointPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEndpointPath_Ljava_lang_String_Handler ()
		{
			if (cb_getEndpointPath_Ljava_lang_String_ == null)
				cb_getEndpointPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEndpointPath_Ljava_lang_String_);
			return cb_getEndpointPath_Ljava_lang_String_;
		}

		static IntPtr n_GetEndpointPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetEndpointPath (key));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getEndpointPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getEndpointPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEndpointPath", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetEndpointPath_Ljava_lang_String_Handler")]
		public virtual unsafe string GetEndpointPath (string key)
		{
			if (id_getEndpointPath_Ljava_lang_String_ == IntPtr.Zero)
				id_getEndpointPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getEndpointPath", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_key);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEndpointPath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndpointPath", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getSecurityConfiguration_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetGetSecurityConfiguration_Landroid_net_Uri_Handler ()
		{
			if (cb_getSecurityConfiguration_Landroid_net_Uri_ == null)
				cb_getSecurityConfiguration_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSecurityConfiguration_Landroid_net_Uri_);
			return cb_getSecurityConfiguration_Landroid_net_Uri_;
		}

		static IntPtr n_GetSecurityConfiguration_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSecurityConfiguration (uri));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSecurityConfiguration_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='getSecurityConfiguration' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getSecurityConfiguration", "(Landroid/net/Uri;)Lcom/ca/mas/foundation/MASSecurityConfiguration;", "GetGetSecurityConfiguration_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.IMASSecurityConfiguration GetSecurityConfiguration (global::Android.Net.Uri uri)
		{
			if (id_getSecurityConfiguration_Landroid_net_Uri_ == IntPtr.Zero)
				id_getSecurityConfiguration_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "getSecurityConfiguration", "(Landroid/net/Uri;)Lcom/ca/mas/foundation/MASSecurityConfiguration;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (uri);

				global::Com.CA.Mas.Foundation.IMASSecurityConfiguration __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecurityConfiguration_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASSecurityConfiguration> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecurityConfiguration", "(Landroid/net/Uri;)Lcom/ca/mas/foundation/MASSecurityConfiguration;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeSecurityConfiguration_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetRemoveSecurityConfiguration_Landroid_net_Uri_Handler ()
		{
			if (cb_removeSecurityConfiguration_Landroid_net_Uri_ == null)
				cb_removeSecurityConfiguration_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSecurityConfiguration_Landroid_net_Uri_);
			return cb_removeSecurityConfiguration_Landroid_net_Uri_;
		}

		static void n_RemoveSecurityConfiguration_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.CA.Mas.Foundation.MASConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSecurityConfiguration (uri);
		}
#pragma warning restore 0169

		static IntPtr id_removeSecurityConfiguration_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConfiguration']/method[@name='removeSecurityConfiguration' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("removeSecurityConfiguration", "(Landroid/net/Uri;)V", "GetRemoveSecurityConfiguration_Landroid_net_Uri_Handler")]
		public virtual unsafe void RemoveSecurityConfiguration (global::Android.Net.Uri uri)
		{
			if (id_removeSecurityConfiguration_Landroid_net_Uri_ == IntPtr.Zero)
				id_removeSecurityConfiguration_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "removeSecurityConfiguration", "(Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (uri);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSecurityConfiguration_Landroid_net_Uri_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSecurityConfiguration", "(Landroid/net/Uri;)V"), __args);
			} finally {
			}
		}

	}
}
