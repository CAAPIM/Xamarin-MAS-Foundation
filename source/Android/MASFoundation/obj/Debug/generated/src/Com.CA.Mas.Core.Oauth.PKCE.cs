using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Oauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='PKCE']"
	[global::Android.Runtime.Register ("com/ca/mas/core/oauth/PKCE", DoNotGenerateAcw=true)]
	public partial class PKCE : global::Java.Lang.Object {


		static IntPtr codeChallenge_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='PKCE']/field[@name='codeChallenge']"
		[Register ("codeChallenge")]
		public string CodeChallenge {
			get {
				if (codeChallenge_jfieldId == IntPtr.Zero)
					codeChallenge_jfieldId = JNIEnv.GetFieldID (class_ref, "codeChallenge", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, codeChallenge_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (codeChallenge_jfieldId == IntPtr.Zero)
					codeChallenge_jfieldId = JNIEnv.GetFieldID (class_ref, "codeChallenge", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codeChallenge_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr codeChallengeMethod_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='PKCE']/field[@name='codeChallengeMethod']"
		[Register ("codeChallengeMethod")]
		public string CodeChallengeMethod {
			get {
				if (codeChallengeMethod_jfieldId == IntPtr.Zero)
					codeChallengeMethod_jfieldId = JNIEnv.GetFieldID (class_ref, "codeChallengeMethod", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, codeChallengeMethod_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (codeChallengeMethod_jfieldId == IntPtr.Zero)
					codeChallengeMethod_jfieldId = JNIEnv.GetFieldID (class_ref, "codeChallengeMethod", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codeChallengeMethod_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr codeVerifier_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='PKCE']/field[@name='codeVerifier']"
		[Register ("codeVerifier")]
		public string CodeVerifier {
			get {
				if (codeVerifier_jfieldId == IntPtr.Zero)
					codeVerifier_jfieldId = JNIEnv.GetFieldID (class_ref, "codeVerifier", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, codeVerifier_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (codeVerifier_jfieldId == IntPtr.Zero)
					codeVerifier_jfieldId = JNIEnv.GetFieldID (class_ref, "codeVerifier", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codeVerifier_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/oauth/PKCE", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKCE); }
		}

		protected PKCE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='PKCE']/constructor[@name='PKCE' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PKCE (string codeChallengeMethod, string codeChallenge, string codeVerifier)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_codeChallengeMethod = JNIEnv.NewString (codeChallengeMethod);
			IntPtr native_codeChallenge = JNIEnv.NewString (codeChallenge);
			IntPtr native_codeVerifier = JNIEnv.NewString (codeVerifier);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_codeChallengeMethod);
				__args [1] = new JValue (native_codeChallenge);
				__args [2] = new JValue (native_codeVerifier);
				if (((object) this).GetType () != typeof (PKCE)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_codeChallengeMethod);
				JNIEnv.DeleteLocalRef (native_codeChallenge);
				JNIEnv.DeleteLocalRef (native_codeVerifier);
			}
		}

	}
}
