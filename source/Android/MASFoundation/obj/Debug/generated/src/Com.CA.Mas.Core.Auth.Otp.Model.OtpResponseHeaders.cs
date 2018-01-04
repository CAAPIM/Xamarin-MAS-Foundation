using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Auth.Otp.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']"
	[global::Android.Runtime.Register ("com/ca/mas/core/auth/otp/model/OtpResponseHeaders", DoNotGenerateAcw=true)]
	public partial class OtpResponseHeaders : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']"
		[global::Android.Runtime.Register ("com/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR", DoNotGenerateAcw=true)]
		public sealed partial class X_CA_ERROR : global::Java.Lang.Enum {


			static IntPtr EXPIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/field[@name='EXPIRED']"
			[Register ("EXPIRED")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR Expired {
				get {
					if (EXPIRED_jfieldId == IntPtr.Zero)
						EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRED", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GENERATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/field[@name='GENERATED']"
			[Register ("GENERATED")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR Generated {
				get {
					if (GENERATED_jfieldId == IntPtr.Zero)
						GENERATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERATED", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GENERATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INTERNAL_SERVER_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/field[@name='INTERNAL_SERVER_ERROR']"
			[Register ("INTERNAL_SERVER_ERROR")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR InternalServerError {
				get {
					if (INTERNAL_SERVER_ERROR_jfieldId == IntPtr.Zero)
						INTERNAL_SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_SERVER_ERROR", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_SERVER_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVALID_USER_INPUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/field[@name='INVALID_USER_INPUT']"
			[Register ("INVALID_USER_INPUT")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR InvalidUserInput {
				get {
					if (INVALID_USER_INPUT_jfieldId == IntPtr.Zero)
						INVALID_USER_INPUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_USER_INPUT", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_USER_INPUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTP_INVALID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/field[@name='OTP_INVALID']"
			[Register ("OTP_INVALID")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR OtpInvalid {
				get {
					if (OTP_INVALID_jfieldId == IntPtr.Zero)
						OTP_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTP_INVALID", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTP_INVALID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTP_MAX_RETRY_EXCEEDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/field[@name='OTP_MAX_RETRY_EXCEEDED']"
			[Register ("OTP_MAX_RETRY_EXCEEDED")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR OtpMaxRetryExceeded {
				get {
					if (OTP_MAX_RETRY_EXCEEDED_jfieldId == IntPtr.Zero)
						OTP_MAX_RETRY_EXCEEDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTP_MAX_RETRY_EXCEEDED", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTP_MAX_RETRY_EXCEEDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/field[@name='REQUIRED']"
			[Register ("REQUIRED")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR Required {
				get {
					if (REQUIRED_jfieldId == IntPtr.Zero)
						REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUIRED", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUSPENDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/field[@name='SUSPENDED']"
			[Register ("SUSPENDED")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR Suspended {
				get {
					if (SUSPENDED_jfieldId == IntPtr.Zero)
						SUSPENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUSPENDED", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUSPENDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (X_CA_ERROR); }
			}

			internal X_CA_ERROR (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;", "")]
			public static unsafe global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_CA_ERROR']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;", "")]
			public static unsafe global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
				try {
					return (global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_OTP_VALUE']"
		[global::Android.Runtime.Register ("com/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE", DoNotGenerateAcw=true)]
		public sealed partial class X_OTP_VALUE : global::Java.Lang.Enum {


			static IntPtr EXPIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_OTP_VALUE']/field[@name='EXPIRED']"
			[Register ("EXPIRED")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE Expired {
				get {
					if (EXPIRED_jfieldId == IntPtr.Zero)
						EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRED", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GENERATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_OTP_VALUE']/field[@name='GENERATED']"
			[Register ("GENERATED")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE Generated {
				get {
					if (GENERATED_jfieldId == IntPtr.Zero)
						GENERATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERATED", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GENERATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INVALID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_OTP_VALUE']/field[@name='INVALID']"
			[Register ("INVALID")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE Invalid {
				get {
					if (INVALID_jfieldId == IntPtr.Zero)
						INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_OTP_VALUE']/field[@name='REQUIRED']"
			[Register ("REQUIRED")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE Required {
				get {
					if (REQUIRED_jfieldId == IntPtr.Zero)
						REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUIRED", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUSPENDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_OTP_VALUE']/field[@name='SUSPENDED']"
			[Register ("SUSPENDED")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE Suspended {
				get {
					if (SUSPENDED_jfieldId == IntPtr.Zero)
						SUSPENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUSPENDED", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUSPENDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_OTP_VALUE']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr xOtpValue_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_OTP_VALUE']/field[@name='xOtpValue']"
			[Register ("xOtpValue")]
			public static global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE XOtpValue {
				get {
					if (xOtpValue_jfieldId == IntPtr.Zero)
						xOtpValue_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "xOtpValue", "Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, xOtpValue_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (X_OTP_VALUE); }
			}

			internal X_OTP_VALUE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_OTP_VALUE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;", "")]
			public static unsafe global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders.X_OTP_VALUE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;", "")]
			public static unsafe global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;");
				try {
					return (global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/auth/otp/model/OtpResponseHeaders", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OtpResponseHeaders); }
		}

		protected OtpResponseHeaders (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/constructor[@name='OtpResponseHeaders' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OtpResponseHeaders ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OtpResponseHeaders)) {
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

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/constructor[@name='OtpResponseHeaders' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe OtpResponseHeaders (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (OtpResponseHeaders)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_getChannels;
#pragma warning disable 0169
		static Delegate GetGetChannelsHandler ()
		{
			if (cb_getChannels == null)
				cb_getChannels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannels);
			return cb_getChannels;
		}

		static IntPtr n_GetChannels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Channels);
		}
#pragma warning restore 0169

		static Delegate cb_setChannels_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetChannels_Ljava_util_List_Handler ()
		{
			if (cb_setChannels_Ljava_util_List_ == null)
				cb_setChannels_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChannels_Ljava_util_List_);
			return cb_setChannels_Ljava_util_List_;
		}

		static void n_SetChannels_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channels)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var channels = global::Android.Runtime.JavaList<string>.FromJniHandle (native_channels, JniHandleOwnership.DoNotTransfer);
			__this.Channels = channels;
		}
#pragma warning restore 0169

		static IntPtr id_getChannels;
		static IntPtr id_setChannels_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> Channels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='getChannels' and count(parameter)=0]"
			[Register ("getChannels", "()Ljava/util/List;", "GetGetChannelsHandler")]
			get {
				if (id_getChannels == IntPtr.Zero)
					id_getChannels = JNIEnv.GetMethodID (class_ref, "getChannels", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannels), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannels", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='setChannels' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setChannels", "(Ljava/util/List;)V", "GetSetChannels_Ljava_util_List_Handler")]
			set {
				if (id_setChannels_Ljava_util_List_ == IntPtr.Zero)
					id_setChannels_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setChannels", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChannels_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannels", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static IntPtr n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorCode);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_;
#pragma warning disable 0169
		static Delegate GetSetErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_Handler ()
		{
			if (cb_setErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_ == null)
				cb_setErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_);
			return cb_setErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_;
		}

		static void n_SetErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_ (IntPtr jnienv, IntPtr native__this, IntPtr native_errorCode)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR errorCode = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (native_errorCode, JniHandleOwnership.DoNotTransfer);
			__this.ErrorCode = errorCode;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCode;
		static IntPtr id_setErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_;
		public virtual unsafe global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_CA_ERROR> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCode", "()Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='setErrorCode' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.auth.otp.model.OtpResponseHeaders.X_CA_ERROR']]"
			[Register ("setErrorCode", "(Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;)V", "GetSetErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_Handler")]
			set {
				if (id_setErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_ == IntPtr.Zero)
					id_setErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_ = JNIEnv.GetMethodID (class_ref, "setErrorCode", "(Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setErrorCode_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_CA_ERROR_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrorCode", "(Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_CA_ERROR;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHttpStatusCode;
#pragma warning disable 0169
		static Delegate GetGetHttpStatusCodeHandler ()
		{
			if (cb_getHttpStatusCode == null)
				cb_getHttpStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHttpStatusCode);
			return cb_getHttpStatusCode;
		}

		static int n_GetHttpStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HttpStatusCode;
		}
#pragma warning restore 0169

		static Delegate cb_setHttpStatusCode_I;
#pragma warning disable 0169
		static Delegate GetSetHttpStatusCode_IHandler ()
		{
			if (cb_setHttpStatusCode_I == null)
				cb_setHttpStatusCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHttpStatusCode_I);
			return cb_setHttpStatusCode_I;
		}

		static void n_SetHttpStatusCode_I (IntPtr jnienv, IntPtr native__this, int httpStatusCode)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HttpStatusCode = httpStatusCode;
		}
#pragma warning restore 0169

		static IntPtr id_getHttpStatusCode;
		static IntPtr id_setHttpStatusCode_I;
		public virtual unsafe int HttpStatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='getHttpStatusCode' and count(parameter)=0]"
			[Register ("getHttpStatusCode", "()I", "GetGetHttpStatusCodeHandler")]
			get {
				if (id_getHttpStatusCode == IntPtr.Zero)
					id_getHttpStatusCode = JNIEnv.GetMethodID (class_ref, "getHttpStatusCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHttpStatusCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHttpStatusCode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='setHttpStatusCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHttpStatusCode", "(I)V", "GetSetHttpStatusCode_IHandler")]
			set {
				if (id_setHttpStatusCode_I == IntPtr.Zero)
					id_setHttpStatusCode_I = JNIEnv.GetMethodID (class_ref, "setHttpStatusCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHttpStatusCode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHttpStatusCode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRetry;
#pragma warning disable 0169
		static Delegate GetGetRetryHandler ()
		{
			if (cb_getRetry == null)
				cb_getRetry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetry);
			return cb_getRetry;
		}

		static int n_GetRetry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Retry;
		}
#pragma warning restore 0169

		static Delegate cb_setRetry_I;
#pragma warning disable 0169
		static Delegate GetSetRetry_IHandler ()
		{
			if (cb_setRetry_I == null)
				cb_setRetry_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRetry_I);
			return cb_setRetry_I;
		}

		static void n_SetRetry_I (IntPtr jnienv, IntPtr native__this, int retry)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retry = retry;
		}
#pragma warning restore 0169

		static IntPtr id_getRetry;
		static IntPtr id_setRetry_I;
		public virtual unsafe int Retry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='getRetry' and count(parameter)=0]"
			[Register ("getRetry", "()I", "GetGetRetryHandler")]
			get {
				if (id_getRetry == IntPtr.Zero)
					id_getRetry = JNIEnv.GetMethodID (class_ref, "getRetry", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRetry);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetry", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='setRetry' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRetry", "(I)V", "GetSetRetry_IHandler")]
			set {
				if (id_setRetry_I == IntPtr.Zero)
					id_setRetry_I = JNIEnv.GetMethodID (class_ref, "setRetry", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRetry_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRetry", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryInterval;
#pragma warning disable 0169
		static Delegate GetGetRetryIntervalHandler ()
		{
			if (cb_getRetryInterval == null)
				cb_getRetryInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetryInterval);
			return cb_getRetryInterval;
		}

		static int n_GetRetryInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryInterval;
		}
#pragma warning restore 0169

		static Delegate cb_setRetryInterval_I;
#pragma warning disable 0169
		static Delegate GetSetRetryInterval_IHandler ()
		{
			if (cb_setRetryInterval_I == null)
				cb_setRetryInterval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRetryInterval_I);
			return cb_setRetryInterval_I;
		}

		static void n_SetRetryInterval_I (IntPtr jnienv, IntPtr native__this, int retryInterval)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetryInterval = retryInterval;
		}
#pragma warning restore 0169

		static IntPtr id_getRetryInterval;
		static IntPtr id_setRetryInterval_I;
		public virtual unsafe int RetryInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='getRetryInterval' and count(parameter)=0]"
			[Register ("getRetryInterval", "()I", "GetGetRetryIntervalHandler")]
			get {
				if (id_getRetryInterval == IntPtr.Zero)
					id_getRetryInterval = JNIEnv.GetMethodID (class_ref, "getRetryInterval", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRetryInterval);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetryInterval", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='setRetryInterval' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRetryInterval", "(I)V", "GetSetRetryInterval_IHandler")]
			set {
				if (id_setRetryInterval_I == IntPtr.Zero)
					id_setRetryInterval_I = JNIEnv.GetMethodID (class_ref, "setRetryInterval", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRetryInterval_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRetryInterval", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getxOtpValue;
#pragma warning disable 0169
		static Delegate GetGetxOtpValueHandler ()
		{
			if (cb_getxOtpValue == null)
				cb_getxOtpValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetxOtpValue);
			return cb_getxOtpValue;
		}

		static IntPtr n_GetxOtpValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetxOtpValue ());
		}
#pragma warning restore 0169

		static IntPtr id_getxOtpValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='getxOtpValue' and count(parameter)=0]"
		[Register ("getxOtpValue", "()Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;", "GetGetxOtpValueHandler")]
		public virtual unsafe global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE GetxOtpValue ()
		{
			if (id_getxOtpValue == IntPtr.Zero)
				id_getxOtpValue = JNIEnv.GetMethodID (class_ref, "getxOtpValue", "()Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getxOtpValue), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getxOtpValue", "()Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_;
#pragma warning disable 0169
		static Delegate GetSetxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_Handler ()
		{
			if (cb_setxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_ == null)
				cb_setxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_);
			return cb_setxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_;
		}

		static void n_SetxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_ (IntPtr jnienv, IntPtr native__this, IntPtr native_xOtpValue)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE xOtpValue = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE> (native_xOtpValue, JniHandleOwnership.DoNotTransfer);
			__this.SetxOtpValue (xOtpValue);
		}
#pragma warning restore 0169

		static IntPtr id_setxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='setxOtpValue' and count(parameter)=1 and parameter[1][@type='com.ca.mas.core.auth.otp.model.OtpResponseHeaders.X_OTP_VALUE']]"
		[Register ("setxOtpValue", "(Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;)V", "GetSetxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_Handler")]
		public virtual unsafe void SetxOtpValue (global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders.X_OTP_VALUE xOtpValue)
		{
			if (id_setxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_ == IntPtr.Zero)
				id_setxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_ = JNIEnv.GetMethodID (class_ref, "setxOtpValue", "(Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (xOtpValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setxOtpValue_Lcom_ca_mas_core_auth_otp_model_OtpResponseHeaders_X_OTP_VALUE_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setxOtpValue", "(Lcom/ca/mas/core/auth/otp/model/OtpResponseHeaders$X_OTP_VALUE;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Auth.Otp.Model.OtpResponseHeaders> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.auth.otp.model']/class[@name='OtpResponseHeaders']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
