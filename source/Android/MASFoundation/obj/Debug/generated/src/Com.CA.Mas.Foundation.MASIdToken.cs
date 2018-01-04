using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASIdToken']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASIdToken", DoNotGenerateAcw=true)]
	public partial class MASIdToken : global::Com.CA.Mas.Core.Token.IdToken {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASIdToken.Builder']"
		[global::Android.Runtime.Register ("com/ca/mas/foundation/MASIdToken$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/foundation/MASIdToken$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASIdToken.Builder']/constructor[@name='MASIdToken.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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
				global::Com.CA.Mas.Foundation.MASIdToken.Builder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASIdToken.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASIdToken.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/ca/mas/foundation/MASIdToken;", "GetBuildHandler")]
			public virtual unsafe global::Com.CA.Mas.Foundation.MASIdToken Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/ca/mas/foundation/MASIdToken;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASIdToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASIdToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/ca/mas/foundation/MASIdToken;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_type_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetType_Ljava_lang_String_Handler ()
			{
				if (cb_type_Ljava_lang_String_ == null)
					cb_type_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Type_Ljava_lang_String_);
				return cb_type_Ljava_lang_String_;
			}

			static IntPtr n_Type_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
			{
				global::Com.CA.Mas.Foundation.MASIdToken.Builder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASIdToken.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Type (type));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_type_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASIdToken.Builder']/method[@name='type' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("type", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASIdToken$Builder;", "GetType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.CA.Mas.Foundation.MASIdToken.Builder Type (string type)
			{
				if (id_type_Ljava_lang_String_ == IntPtr.Zero)
					id_type_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "type", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASIdToken$Builder;");
				IntPtr native_type = JNIEnv.NewString (type);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_type);

					global::Com.CA.Mas.Foundation.MASIdToken.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASIdToken.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_type_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASIdToken.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "type", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASIdToken$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_type);
				}
			}

			static Delegate cb_value_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetValue_Ljava_lang_String_Handler ()
			{
				if (cb_value_Ljava_lang_String_ == null)
					cb_value_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Value_Ljava_lang_String_);
				return cb_value_Ljava_lang_String_;
			}

			static IntPtr n_Value_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
			{
				global::Com.CA.Mas.Foundation.MASIdToken.Builder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASIdToken.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Value (value));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_value_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASIdToken.Builder']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("value", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASIdToken$Builder;", "GetValue_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.CA.Mas.Foundation.MASIdToken.Builder Value (string value)
			{
				if (id_value_Ljava_lang_String_ == IntPtr.Zero)
					id_value_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "value", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASIdToken$Builder;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					global::Com.CA.Mas.Foundation.MASIdToken.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASIdToken.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASIdToken.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "value", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASIdToken$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASIdToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASIdToken); }
		}

		protected MASIdToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
