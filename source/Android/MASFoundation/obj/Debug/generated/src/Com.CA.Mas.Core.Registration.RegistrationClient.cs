using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Registration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.registration']/class[@name='RegistrationClient']"
	[global::Android.Runtime.Register ("com/ca/mas/core/registration/RegistrationClient", DoNotGenerateAcw=true)]
	public partial class RegistrationClient : global::Com.CA.Mas.Core.Client.ServerClient {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.registration']/interface[@name='RegistrationClient.DeviceRegistrationResult']"
		[Register ("com/ca/mas/core/registration/RegistrationClient$DeviceRegistrationResult", "", "Com.CA.Mas.Core.Registration.RegistrationClient/IDeviceRegistrationResultInvoker")]
		public partial interface IDeviceRegistrationResult : IJavaObject {

			global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus DeviceStatus {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.registration']/interface[@name='RegistrationClient.DeviceRegistrationResult']/method[@name='getDeviceStatus' and count(parameter)=0]"
				[Register ("getDeviceStatus", "()Lcom/ca/mas/core/registration/RegistrationClient$DeviceStatus;", "GetGetDeviceStatusHandler:Com.CA.Mas.Core.Registration.RegistrationClient/IDeviceRegistrationResultInvoker, MASFoundation")] get;
			}

			global::Com.CA.Mas.Core.Token.IdToken IdToken {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.registration']/interface[@name='RegistrationClient.DeviceRegistrationResult']/method[@name='getIdToken' and count(parameter)=0]"
				[Register ("getIdToken", "()Lcom/ca/mas/core/token/IdToken;", "GetGetIdTokenHandler:Com.CA.Mas.Core.Registration.RegistrationClient/IDeviceRegistrationResultInvoker, MASFoundation")] get;
			}

			string MagIdentifier {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.registration']/interface[@name='RegistrationClient.DeviceRegistrationResult']/method[@name='getMagIdentifier' and count(parameter)=0]"
				[Register ("getMagIdentifier", "()Ljava/lang/String;", "GetGetMagIdentifierHandler:Com.CA.Mas.Core.Registration.RegistrationClient/IDeviceRegistrationResultInvoker, MASFoundation")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.registration']/interface[@name='RegistrationClient.DeviceRegistrationResult']/method[@name='getClientCertificateChain' and count(parameter)=0]"
			[Register ("getClientCertificateChain", "()[Ljava/security/cert/X509Certificate;", "GetGetClientCertificateChainHandler:Com.CA.Mas.Core.Registration.RegistrationClient/IDeviceRegistrationResultInvoker, MASFoundation")]
			global::Java.Security.Cert.X509Certificate[] GetClientCertificateChain ();

		}

		[global::Android.Runtime.Register ("com/ca/mas/core/registration/RegistrationClient$DeviceRegistrationResult", DoNotGenerateAcw=true)]
		internal class IDeviceRegistrationResultInvoker : global::Java.Lang.Object, IDeviceRegistrationResult {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/registration/RegistrationClient$DeviceRegistrationResult");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDeviceRegistrationResultInvoker); }
			}

			IntPtr class_ref;

			public static IDeviceRegistrationResult GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDeviceRegistrationResult> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.registration.RegistrationClient.DeviceRegistrationResult"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDeviceRegistrationResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getDeviceStatus;
#pragma warning disable 0169
			static Delegate GetGetDeviceStatusHandler ()
			{
				if (cb_getDeviceStatus == null)
					cb_getDeviceStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceStatus);
				return cb_getDeviceStatus;
			}

			static IntPtr n_GetDeviceStatus (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Core.Registration.RegistrationClient.IDeviceRegistrationResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Registration.RegistrationClient.IDeviceRegistrationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DeviceStatus);
			}
#pragma warning restore 0169

			IntPtr id_getDeviceStatus;
			public unsafe global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus DeviceStatus {
				get {
					if (id_getDeviceStatus == IntPtr.Zero)
						id_getDeviceStatus = JNIEnv.GetMethodID (class_ref, "getDeviceStatus", "()Lcom/ca/mas/core/registration/RegistrationClient$DeviceStatus;");
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceStatus), JniHandleOwnership.TransferLocalRef);
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
				global::Com.CA.Mas.Core.Registration.RegistrationClient.IDeviceRegistrationResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Registration.RegistrationClient.IDeviceRegistrationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.CA.Mas.Core.Registration.RegistrationClient.IDeviceRegistrationResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Registration.RegistrationClient.IDeviceRegistrationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.CA.Mas.Core.Registration.RegistrationClient.IDeviceRegistrationResult __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Registration.RegistrationClient.IDeviceRegistrationResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.registration']/class[@name='RegistrationClient.DeviceStatus']"
		[global::Android.Runtime.Register ("com/ca/mas/core/registration/RegistrationClient$DeviceStatus", DoNotGenerateAcw=true)]
		public sealed partial class DeviceStatus : global::Java.Lang.Enum {


			static IntPtr ACTIVATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.registration']/class[@name='RegistrationClient.DeviceStatus']/field[@name='ACTIVATED']"
			[Register ("ACTIVATED")]
			public static global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus Activated {
				get {
					if (ACTIVATED_jfieldId == IntPtr.Zero)
						ACTIVATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTIVATED", "Lcom/ca/mas/core/registration/RegistrationClient$DeviceStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTIVATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REGISTERED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.registration']/class[@name='RegistrationClient.DeviceStatus']/field[@name='REGISTERED']"
			[Register ("REGISTERED")]
			public static global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus Registered {
				get {
					if (REGISTERED_jfieldId == IntPtr.Zero)
						REGISTERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGISTERED", "Lcom/ca/mas/core/registration/RegistrationClient$DeviceStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REGISTERED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/core/registration/RegistrationClient$DeviceStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DeviceStatus); }
			}

			internal DeviceStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.registration']/class[@name='RegistrationClient.DeviceStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/registration/RegistrationClient$DeviceStatus;", "")]
			public static unsafe global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/registration/RegistrationClient$DeviceStatus;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.registration']/class[@name='RegistrationClient.DeviceStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ca/mas/core/registration/RegistrationClient$DeviceStatus;", "")]
			public static unsafe global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/core/registration/RegistrationClient$DeviceStatus;");
				try {
					return (global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Core.Registration.RegistrationClient.DeviceStatus));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/registration/RegistrationClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegistrationClient); }
		}

		protected RegistrationClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_core_context_MssoContext_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.registration']/class[@name='RegistrationClient']/constructor[@name='RegistrationClient' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.context.MssoContext']]"
		[Register (".ctor", "(Lcom/ca/mas/core/context/MssoContext;)V", "")]
		public unsafe RegistrationClient (global::Com.CA.Mas.Core.Context.MssoContext mssoContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mssoContext);
				if (((object) this).GetType () != typeof (RegistrationClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/core/context/MssoContext;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/core/context/MssoContext;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_core_context_MssoContext_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_core_context_MssoContext_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/core/context/MssoContext;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_core_context_MssoContext_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_core_context_MssoContext_, __args);
			} finally {
			}
		}

		static Delegate cb_removeDeviceRegistration;
#pragma warning disable 0169
		static Delegate GetRemoveDeviceRegistrationHandler ()
		{
			if (cb_removeDeviceRegistration == null)
				cb_removeDeviceRegistration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveDeviceRegistration);
			return cb_removeDeviceRegistration;
		}

		static void n_RemoveDeviceRegistration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Registration.RegistrationClient __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Registration.RegistrationClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDeviceRegistration ();
		}
#pragma warning restore 0169

		static IntPtr id_removeDeviceRegistration;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.registration']/class[@name='RegistrationClient']/method[@name='removeDeviceRegistration' and count(parameter)=0]"
		[Register ("removeDeviceRegistration", "()V", "GetRemoveDeviceRegistrationHandler")]
		public virtual unsafe void RemoveDeviceRegistration ()
		{
			if (id_removeDeviceRegistration == IntPtr.Zero)
				id_removeDeviceRegistration = JNIEnv.GetMethodID (class_ref, "removeDeviceRegistration", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeDeviceRegistration);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeDeviceRegistration", "()V"));
			} finally {
			}
		}

	}
}
