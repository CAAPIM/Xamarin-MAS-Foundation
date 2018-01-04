using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Conf {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Server']"
	[global::Android.Runtime.Register ("com/ca/mas/core/conf/Server", DoNotGenerateAcw=true)]
	public partial class Server : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/conf/Server", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Server); }
		}

		protected Server (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Server']/constructor[@name='Server' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe Server (string host, int port, string prefix)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_host = JNIEnv.NewString (host);
			IntPtr native_prefix = JNIEnv.NewString (prefix);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_host);
				__args [1] = new JValue (port);
				__args [2] = new JValue (native_prefix);
				if (((object) this).GetType () != typeof (Server)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
				JNIEnv.DeleteLocalRef (native_prefix);
			}
		}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Server']/constructor[@name='Server' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe Server (global::Org.Json.JSONObject config)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (config);
				if (((object) this).GetType () != typeof (Server)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONObject_, __args);
			} finally {
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
			global::Com.CA.Mas.Core.Conf.Server __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Host);
		}
#pragma warning restore 0169

		static Delegate cb_setHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHost_Ljava_lang_String_Handler ()
		{
			if (cb_setHost_Ljava_lang_String_ == null)
				cb_setHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHost_Ljava_lang_String_);
			return cb_setHost_Ljava_lang_String_;
		}

		static void n_SetHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_host)
		{
			global::Com.CA.Mas.Core.Conf.Server __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
			__this.Host = host;
		}
#pragma warning restore 0169

		static IntPtr id_getHost;
		static IntPtr id_setHost_Ljava_lang_String_;
		public virtual unsafe string Host {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Server']/method[@name='getHost' and count(parameter)=0]"
			[Register ("getHost", "()Ljava/lang/String;", "GetGetHostHandler")]
			get {
				if (id_getHost == IntPtr.Zero)
					id_getHost = JNIEnv.GetMethodID (class_ref, "getHost", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHost), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHost", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Server']/method[@name='setHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHost", "(Ljava/lang/String;)V", "GetSetHost_Ljava_lang_String_Handler")]
			set {
				if (id_setHost_Ljava_lang_String_ == IntPtr.Zero)
					id_setHost_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHost", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHost_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHost", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.Server __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		static Delegate cb_setPort_I;
#pragma warning disable 0169
		static Delegate GetSetPort_IHandler ()
		{
			if (cb_setPort_I == null)
				cb_setPort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPort_I);
			return cb_setPort_I;
		}

		static void n_SetPort_I (IntPtr jnienv, IntPtr native__this, int port)
		{
			global::Com.CA.Mas.Core.Conf.Server __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Port = port;
		}
#pragma warning restore 0169

		static IntPtr id_getPort;
		static IntPtr id_setPort_I;
		public virtual unsafe int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Server']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				if (id_getPort == IntPtr.Zero)
					id_getPort = JNIEnv.GetMethodID (class_ref, "getPort", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPort);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPort", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Server']/method[@name='setPort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPort", "(I)V", "GetSetPort_IHandler")]
			set {
				if (id_setPort_I == IntPtr.Zero)
					id_setPort_I = JNIEnv.GetMethodID (class_ref, "setPort", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPort_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPort", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPrefix;
#pragma warning disable 0169
		static Delegate GetGetPrefixHandler ()
		{
			if (cb_getPrefix == null)
				cb_getPrefix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrefix);
			return cb_getPrefix;
		}

		static IntPtr n_GetPrefix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Conf.Server __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Prefix);
		}
#pragma warning restore 0169

		static Delegate cb_setPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setPrefix_Ljava_lang_String_ == null)
				cb_setPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrefix_Ljava_lang_String_);
			return cb_setPrefix_Ljava_lang_String_;
		}

		static void n_SetPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefix)
		{
			global::Com.CA.Mas.Core.Conf.Server __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Conf.Server> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string prefix = JNIEnv.GetString (native_prefix, JniHandleOwnership.DoNotTransfer);
			__this.Prefix = prefix;
		}
#pragma warning restore 0169

		static IntPtr id_getPrefix;
		static IntPtr id_setPrefix_Ljava_lang_String_;
		public virtual unsafe string Prefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Server']/method[@name='getPrefix' and count(parameter)=0]"
			[Register ("getPrefix", "()Ljava/lang/String;", "GetGetPrefixHandler")]
			get {
				if (id_getPrefix == IntPtr.Zero)
					id_getPrefix = JNIEnv.GetMethodID (class_ref, "getPrefix", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrefix), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrefix", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.conf']/class[@name='Server']/method[@name='setPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPrefix", "(Ljava/lang/String;)V", "GetSetPrefix_Ljava_lang_String_Handler")]
			set {
				if (id_setPrefix_Ljava_lang_String_ == IntPtr.Zero)
					id_setPrefix_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPrefix", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrefix_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrefix", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
