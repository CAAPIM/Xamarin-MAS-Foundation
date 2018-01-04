using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.IO.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='SingleKeyX509KeyManager']"
	[global::Android.Runtime.Register ("com/ca/mas/core/io/http/SingleKeyX509KeyManager", DoNotGenerateAcw=true)]
	public partial class SingleKeyX509KeyManager : global::Javax.Net.Ssl.X509ExtendedKeyManager {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/io/http/SingleKeyX509KeyManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleKeyX509KeyManager); }
		}

		protected SingleKeyX509KeyManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_security_PrivateKey_arrayLjava_security_cert_X509Certificate_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='SingleKeyX509KeyManager']/constructor[@name='SingleKeyX509KeyManager' and count(parameter)=2 and parameter[1][@type='java.security.PrivateKey'] and parameter[2][@type='java.security.cert.X509Certificate[]']]"
		[Register (".ctor", "(Ljava/security/PrivateKey;[Ljava/security/cert/X509Certificate;)V", "")]
		public unsafe SingleKeyX509KeyManager (global::Java.Security.IPrivateKey privateKey, global::Java.Security.Cert.X509Certificate[] certChain)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_certChain = JNIEnv.NewArray (certChain);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (privateKey);
				__args [1] = new JValue (native_certChain);
				if (((object) this).GetType () != typeof (SingleKeyX509KeyManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/security/PrivateKey;[Ljava/security/cert/X509Certificate;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/security/PrivateKey;[Ljava/security/cert/X509Certificate;)V", __args);
					return;
				}

				if (id_ctor_Ljava_security_PrivateKey_arrayLjava_security_cert_X509Certificate_ == IntPtr.Zero)
					id_ctor_Ljava_security_PrivateKey_arrayLjava_security_cert_X509Certificate_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/security/PrivateKey;[Ljava/security/cert/X509Certificate;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_security_PrivateKey_arrayLjava_security_cert_X509Certificate_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_security_PrivateKey_arrayLjava_security_cert_X509Certificate_, __args);
			} finally {
				if (certChain != null) {
					JNIEnv.CopyArray (native_certChain, certChain);
					JNIEnv.DeleteLocalRef (native_certChain);
				}
			}
		}

		static Delegate cb_chooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_;
#pragma warning disable 0169
		static Delegate GetChooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_Handler ()
		{
			if (cb_chooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_ == null)
				cb_chooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ChooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_);
			return cb_chooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_;
		}

		static IntPtr n_ChooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strings, IntPtr native_principals, IntPtr native_socket)
		{
			global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] strings = (string[]) JNIEnv.GetArray (native_strings, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Java.Security.IPrincipal[] principals = (global::Java.Security.IPrincipal[]) JNIEnv.GetArray (native_principals, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.IPrincipal));
			global::Java.Net.Socket socket = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_socket, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ChooseClientAlias (strings, principals, socket));
			if (strings != null)
				JNIEnv.CopyArray (strings, native_strings);
			if (principals != null)
				JNIEnv.CopyArray (principals, native_principals);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_chooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='SingleKeyX509KeyManager']/method[@name='chooseClientAlias' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.security.Principal[]'] and parameter[3][@type='java.net.Socket']]"
		[Register ("chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;", "GetChooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_Handler")]
		public override unsafe string ChooseClientAlias (string[] strings, global::Java.Security.IPrincipal[] principals, global::Java.Net.Socket socket)
		{
			if (id_chooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_ == IntPtr.Zero)
				id_chooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_ = JNIEnv.GetMethodID (class_ref, "chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;");
			IntPtr native_strings = JNIEnv.NewArray (strings);
			IntPtr native_principals = JNIEnv.NewArray (principals);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_strings);
				__args [1] = new JValue (native_principals);
				__args [2] = new JValue (socket);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_chooseClientAlias_arrayLjava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (strings != null) {
					JNIEnv.CopyArray (native_strings, strings);
					JNIEnv.DeleteLocalRef (native_strings);
				}
				if (principals != null) {
					JNIEnv.CopyArray (native_principals, principals);
					JNIEnv.DeleteLocalRef (native_principals);
				}
			}
		}

		static Delegate cb_chooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_;
#pragma warning disable 0169
		static Delegate GetChooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_Handler ()
		{
			if (cb_chooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_ == null)
				cb_chooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ChooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_);
			return cb_chooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_;
		}

		static IntPtr n_ChooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_principals, IntPtr native_socket)
		{
			global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPrincipal[] principals = (global::Java.Security.IPrincipal[]) JNIEnv.GetArray (native_principals, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.IPrincipal));
			global::Java.Net.Socket socket = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_socket, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ChooseServerAlias (s, principals, socket));
			if (principals != null)
				JNIEnv.CopyArray (principals, native_principals);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_chooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='SingleKeyX509KeyManager']/method[@name='chooseServerAlias' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.security.Principal[]'] and parameter[3][@type='java.net.Socket']]"
		[Register ("chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;", "GetChooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_Handler")]
		public override unsafe string ChooseServerAlias (string s, global::Java.Security.IPrincipal[] principals, global::Java.Net.Socket socket)
		{
			if (id_chooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_ == IntPtr.Zero)
				id_chooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_ = JNIEnv.GetMethodID (class_ref, "chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;");
			IntPtr native_s = JNIEnv.NewString (s);
			IntPtr native_principals = JNIEnv.NewArray (principals);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_s);
				__args [1] = new JValue (native_principals);
				__args [2] = new JValue (socket);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_chooseServerAlias_Ljava_lang_String_arrayLjava_security_Principal_Ljava_net_Socket_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				if (principals != null) {
					JNIEnv.CopyArray (native_principals, principals);
					JNIEnv.DeleteLocalRef (native_principals);
				}
			}
		}

		static Delegate cb_getCertificateChain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCertificateChain_Ljava_lang_String_Handler ()
		{
			if (cb_getCertificateChain_Ljava_lang_String_ == null)
				cb_getCertificateChain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCertificateChain_Ljava_lang_String_);
			return cb_getCertificateChain_Ljava_lang_String_;
		}

		static IntPtr n_GetCertificateChain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetCertificateChain (s));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCertificateChain_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='SingleKeyX509KeyManager']/method[@name='getCertificateChain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;", "GetGetCertificateChain_Ljava_lang_String_Handler")]
		public override unsafe global::Java.Security.Cert.X509Certificate[] GetCertificateChain (string s)
		{
			if (id_getCertificateChain_Ljava_lang_String_ == IntPtr.Zero)
				id_getCertificateChain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);

				global::Java.Security.Cert.X509Certificate[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCertificateChain_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
				else
					__ret = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_getClientAliases_Ljava_lang_String_arrayLjava_security_Principal_;
#pragma warning disable 0169
		static Delegate GetGetClientAliases_Ljava_lang_String_arrayLjava_security_Principal_Handler ()
		{
			if (cb_getClientAliases_Ljava_lang_String_arrayLjava_security_Principal_ == null)
				cb_getClientAliases_Ljava_lang_String_arrayLjava_security_Principal_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetClientAliases_Ljava_lang_String_arrayLjava_security_Principal_);
			return cb_getClientAliases_Ljava_lang_String_arrayLjava_security_Principal_;
		}

		static IntPtr n_GetClientAliases_Ljava_lang_String_arrayLjava_security_Principal_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_principals)
		{
			global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPrincipal[] principals = (global::Java.Security.IPrincipal[]) JNIEnv.GetArray (native_principals, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.IPrincipal));
			IntPtr __ret = JNIEnv.NewArray (__this.GetClientAliases (s, principals));
			if (principals != null)
				JNIEnv.CopyArray (principals, native_principals);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getClientAliases_Ljava_lang_String_arrayLjava_security_Principal_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='SingleKeyX509KeyManager']/method[@name='getClientAliases' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.security.Principal[]']]"
		[Register ("getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", "GetGetClientAliases_Ljava_lang_String_arrayLjava_security_Principal_Handler")]
		public override unsafe string[] GetClientAliases (string s, global::Java.Security.IPrincipal[] principals)
		{
			if (id_getClientAliases_Ljava_lang_String_arrayLjava_security_Principal_ == IntPtr.Zero)
				id_getClientAliases_Ljava_lang_String_arrayLjava_security_Principal_ = JNIEnv.GetMethodID (class_ref, "getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;");
			IntPtr native_s = JNIEnv.NewString (s);
			IntPtr native_principals = JNIEnv.NewArray (principals);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_s);
				__args [1] = new JValue (native_principals);

				string[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientAliases_Ljava_lang_String_arrayLjava_security_Principal_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				if (principals != null) {
					JNIEnv.CopyArray (native_principals, principals);
					JNIEnv.DeleteLocalRef (native_principals);
				}
			}
		}

		static Delegate cb_getPrivateKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPrivateKey_Ljava_lang_String_Handler ()
		{
			if (cb_getPrivateKey_Ljava_lang_String_ == null)
				cb_getPrivateKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPrivateKey_Ljava_lang_String_);
			return cb_getPrivateKey_Ljava_lang_String_;
		}

		static IntPtr n_GetPrivateKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPrivateKey (s));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPrivateKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='SingleKeyX509KeyManager']/method[@name='getPrivateKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;", "GetGetPrivateKey_Ljava_lang_String_Handler")]
		public override unsafe global::Java.Security.IPrivateKey GetPrivateKey (string s)
		{
			if (id_getPrivateKey_Ljava_lang_String_ == IntPtr.Zero)
				id_getPrivateKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);

				global::Java.Security.IPrivateKey __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrivateKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Security.IPrivateKey> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_getServerAliases_Ljava_lang_String_arrayLjava_security_Principal_;
#pragma warning disable 0169
		static Delegate GetGetServerAliases_Ljava_lang_String_arrayLjava_security_Principal_Handler ()
		{
			if (cb_getServerAliases_Ljava_lang_String_arrayLjava_security_Principal_ == null)
				cb_getServerAliases_Ljava_lang_String_arrayLjava_security_Principal_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetServerAliases_Ljava_lang_String_arrayLjava_security_Principal_);
			return cb_getServerAliases_Ljava_lang_String_arrayLjava_security_Principal_;
		}

		static IntPtr n_GetServerAliases_Ljava_lang_String_arrayLjava_security_Principal_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s, IntPtr native_principals)
		{
			global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.IO.Http.SingleKeyX509KeyManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPrincipal[] principals = (global::Java.Security.IPrincipal[]) JNIEnv.GetArray (native_principals, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.IPrincipal));
			IntPtr __ret = JNIEnv.NewArray (__this.GetServerAliases (s, principals));
			if (principals != null)
				JNIEnv.CopyArray (principals, native_principals);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getServerAliases_Ljava_lang_String_arrayLjava_security_Principal_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.io.http']/class[@name='SingleKeyX509KeyManager']/method[@name='getServerAliases' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.security.Principal[]']]"
		[Register ("getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", "GetGetServerAliases_Ljava_lang_String_arrayLjava_security_Principal_Handler")]
		public override unsafe string[] GetServerAliases (string s, global::Java.Security.IPrincipal[] principals)
		{
			if (id_getServerAliases_Ljava_lang_String_arrayLjava_security_Principal_ == IntPtr.Zero)
				id_getServerAliases_Ljava_lang_String_arrayLjava_security_Principal_ = JNIEnv.GetMethodID (class_ref, "getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;");
			IntPtr native_s = JNIEnv.NewString (s);
			IntPtr native_principals = JNIEnv.NewArray (principals);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_s);
				__args [1] = new JValue (native_principals);

				string[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServerAliases_Ljava_lang_String_arrayLjava_security_Principal_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				if (principals != null) {
					JNIEnv.CopyArray (native_principals, principals);
					JNIEnv.DeleteLocalRef (native_principals);
				}
			}
		}

	}
}
