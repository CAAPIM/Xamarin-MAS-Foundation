using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Token {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation']"
	[global::Android.Runtime.Register ("com/ca/mas/core/token/JWTValidation", DoNotGenerateAcw=true)]
	public partial class JWTValidation : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation']/field[@name='ALG']"
		[Register ("ALG")]
		public const string Alg = (string) "alg";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation']/field[@name='AUD']"
		[Register ("AUD")]
		public const string Aud = (string) "aud";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation']/field[@name='AZP']"
		[Register ("AZP")]
		public const string Azp = (string) "azp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation']/field[@name='EXP']"
		[Register ("EXP")]
		public const string Exp = (string) "exp";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation.Algorithm']"
		[global::Android.Runtime.Register ("com/ca/mas/core/token/JWTValidation$Algorithm", DoNotGenerateAcw=true)]
		public sealed partial class Algorithm : global::Java.Lang.Enum {


			static IntPtr HS256_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation.Algorithm']/field[@name='HS256']"
			[Register ("HS256")]
			public static global::Com.CA.Mas.Core.Token.JWTValidation.Algorithm Hs256 {
				get {
					if (HS256_jfieldId == IntPtr.Zero)
						HS256_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HS256", "Lcom/ca/mas/core/token/JWTValidation$Algorithm;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HS256_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.JWTValidation.Algorithm> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RSA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation.Algorithm']/field[@name='RSA']"
			[Register ("RSA")]
			public static global::Com.CA.Mas.Core.Token.JWTValidation.Algorithm Rsa {
				get {
					if (RSA_jfieldId == IntPtr.Zero)
						RSA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RSA", "Lcom/ca/mas/core/token/JWTValidation$Algorithm;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RSA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.JWTValidation.Algorithm> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/core/token/JWTValidation$Algorithm", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Algorithm); }
			}

			internal Algorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation.Algorithm']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/token/JWTValidation$Algorithm;", "")]
			public static unsafe global::Com.CA.Mas.Core.Token.JWTValidation.Algorithm ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/token/JWTValidation$Algorithm;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.CA.Mas.Core.Token.JWTValidation.Algorithm __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Token.JWTValidation.Algorithm> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation.Algorithm']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ca/mas/core/token/JWTValidation$Algorithm;", "")]
			public static unsafe global::Com.CA.Mas.Core.Token.JWTValidation.Algorithm[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/core/token/JWTValidation$Algorithm;");
				try {
					return (global::Com.CA.Mas.Core.Token.JWTValidation.Algorithm[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Core.Token.JWTValidation.Algorithm));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/token/JWTValidation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JWTValidation); }
		}

		protected JWTValidation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation']/constructor[@name='JWTValidation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JWTValidation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JWTValidation)) {
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

		static IntPtr id_isIdTokenExpired_Lcom_ca_mas_core_token_IdToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation']/method[@name='isIdTokenExpired' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.token.IdToken']]"
		[Register ("isIdTokenExpired", "(Lcom/ca/mas/core/token/IdToken;)Z", "")]
		public static unsafe bool IsIdTokenExpired (global::Com.CA.Mas.Core.Token.IdToken idToken)
		{
			if (id_isIdTokenExpired_Lcom_ca_mas_core_token_IdToken_ == IntPtr.Zero)
				id_isIdTokenExpired_Lcom_ca_mas_core_token_IdToken_ = JNIEnv.GetStaticMethodID (class_ref, "isIdTokenExpired", "(Lcom/ca/mas/core/token/IdToken;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (idToken);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isIdTokenExpired_Lcom_ca_mas_core_token_IdToken_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_validateIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.token']/class[@name='JWTValidation']/method[@name='validateIdToken' and count(parameter)=4 and parameter[1][@type='com.ca.mas.core.token.IdToken'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("validateIdToken", "(Lcom/ca/mas/core/token/IdToken;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool ValidateIdToken (global::Com.CA.Mas.Core.Token.IdToken idToken, string deviceIdentifier, string clientId, string clientSecret)
		{
			if (id_validateIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_validateIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "validateIdToken", "(Lcom/ca/mas/core/token/IdToken;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_deviceIdentifier = JNIEnv.NewString (deviceIdentifier);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			IntPtr native_clientSecret = JNIEnv.NewString (clientSecret);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (idToken);
				__args [1] = new JValue (native_deviceIdentifier);
				__args [2] = new JValue (native_clientId);
				__args [3] = new JValue (native_clientSecret);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validateIdToken_Lcom_ca_mas_core_token_IdToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceIdentifier);
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

	}
}
