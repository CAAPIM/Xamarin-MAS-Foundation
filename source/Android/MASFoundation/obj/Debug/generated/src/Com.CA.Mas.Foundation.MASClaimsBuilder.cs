using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASClaimsBuilder", DoNotGenerateAcw=true)]
	public partial class MASClaimsBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASClaimsBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASClaimsBuilder); }
		}

		protected MASClaimsBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/constructor[@name='MASClaimsBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASClaimsBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASClaimsBuilder)) {
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

		static IntPtr id_ctor_Lcom_ca_mas_foundation_MASClaims_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/constructor[@name='MASClaimsBuilder' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASClaims']]"
		[Register (".ctor", "(Lcom/ca/mas/foundation/MASClaims;)V", "")]
		public unsafe MASClaimsBuilder (global::Com.CA.Mas.Foundation.IMASClaims masClaims)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (masClaims);
				if (((object) this).GetType () != typeof (MASClaimsBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/foundation/MASClaims;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/foundation/MASClaims;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_foundation_MASClaims_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_foundation_MASClaims_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/foundation/MASClaims;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_foundation_MASClaims_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_foundation_MASClaims_, __args);
			} finally {
			}
		}

		static Delegate cb_audience_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAudience_Ljava_lang_String_Handler ()
		{
			if (cb_audience_Ljava_lang_String_ == null)
				cb_audience_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Audience_Ljava_lang_String_);
			return cb_audience_Ljava_lang_String_;
		}

		static IntPtr n_Audience_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aud)
		{
			global::Com.CA.Mas.Foundation.MASClaimsBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aud = JNIEnv.GetString (native_aud, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Audience (aud));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_audience_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/method[@name='audience' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("audience", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;", "GetAudience_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASClaimsBuilder Audience (string aud)
		{
			if (id_audience_Ljava_lang_String_ == IntPtr.Zero)
				id_audience_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "audience", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;");
			IntPtr native_aud = JNIEnv.NewString (aud);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_aud);

				global::Com.CA.Mas.Foundation.MASClaimsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_audience_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "audience", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_aud);
			}
		}

		static Delegate cb_audience_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAudience_Ljava_util_List_Handler ()
		{
			if (cb_audience_Ljava_util_List_ == null)
				cb_audience_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Audience_Ljava_util_List_);
			return cb_audience_Ljava_util_List_;
		}

		static IntPtr n_Audience_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audList)
		{
			global::Com.CA.Mas.Foundation.MASClaimsBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var audList = global::Android.Runtime.JavaList<string>.FromJniHandle (native_audList, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Audience (audList));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_audience_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/method[@name='audience' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("audience", "(Ljava/util/List;)Lcom/ca/mas/foundation/MASClaimsBuilder;", "GetAudience_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASClaimsBuilder Audience (global::System.Collections.Generic.IList<string> audList)
		{
			if (id_audience_Ljava_util_List_ == IntPtr.Zero)
				id_audience_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "audience", "(Ljava/util/List;)Lcom/ca/mas/foundation/MASClaimsBuilder;");
			IntPtr native_audList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (audList);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_audList);

				global::Com.CA.Mas.Foundation.MASClaimsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_audience_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "audience", "(Ljava/util/List;)Lcom/ca/mas/foundation/MASClaimsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_audList);
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
			global::Com.CA.Mas.Foundation.MASClaimsBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/ca/mas/foundation/MASClaims;", "GetBuildHandler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.IMASClaims Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/ca/mas/foundation/MASClaims;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASClaims> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASClaims> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/ca/mas/foundation/MASClaims;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_claim_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetClaim_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_claim_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_claim_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Claim_Ljava_lang_String_Ljava_lang_Object_);
			return cb_claim_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_Claim_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
		{
			global::Com.CA.Mas.Foundation.MASClaimsBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Claim (name, value));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_claim_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/method[@name='claim' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("claim", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/ca/mas/foundation/MASClaimsBuilder;", "GetClaim_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASClaimsBuilder Claim (string name, global::Java.Lang.Object value)
		{
			if (id_claim_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_claim_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "claim", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/ca/mas/foundation/MASClaimsBuilder;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (value);

				global::Com.CA.Mas.Foundation.MASClaimsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_claim_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "claim", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/ca/mas/foundation/MASClaimsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_expirationTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetExpirationTime_Ljava_util_Date_Handler ()
		{
			if (cb_expirationTime_Ljava_util_Date_ == null)
				cb_expirationTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExpirationTime_Ljava_util_Date_);
			return cb_expirationTime_Ljava_util_Date_;
		}

		static IntPtr n_ExpirationTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exp)
		{
			global::Com.CA.Mas.Foundation.MASClaimsBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date exp = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_exp, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExpirationTime (exp));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_expirationTime_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/method[@name='expirationTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("expirationTime", "(Ljava/util/Date;)Lcom/ca/mas/foundation/MASClaimsBuilder;", "GetExpirationTime_Ljava_util_Date_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASClaimsBuilder ExpirationTime (global::Java.Util.Date exp)
		{
			if (id_expirationTime_Ljava_util_Date_ == IntPtr.Zero)
				id_expirationTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "expirationTime", "(Ljava/util/Date;)Lcom/ca/mas/foundation/MASClaimsBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (exp);

				global::Com.CA.Mas.Foundation.MASClaimsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_expirationTime_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "expirationTime", "(Ljava/util/Date;)Lcom/ca/mas/foundation/MASClaimsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_issueTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetIssueTime_Ljava_util_Date_Handler ()
		{
			if (cb_issueTime_Ljava_util_Date_ == null)
				cb_issueTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_IssueTime_Ljava_util_Date_);
			return cb_issueTime_Ljava_util_Date_;
		}

		static IntPtr n_IssueTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_iat)
		{
			global::Com.CA.Mas.Foundation.MASClaimsBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date iat = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_iat, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IssueTime (iat));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_issueTime_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/method[@name='issueTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("issueTime", "(Ljava/util/Date;)Lcom/ca/mas/foundation/MASClaimsBuilder;", "GetIssueTime_Ljava_util_Date_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASClaimsBuilder IssueTime (global::Java.Util.Date iat)
		{
			if (id_issueTime_Ljava_util_Date_ == IntPtr.Zero)
				id_issueTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "issueTime", "(Ljava/util/Date;)Lcom/ca/mas/foundation/MASClaimsBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (iat);

				global::Com.CA.Mas.Foundation.MASClaimsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_issueTime_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "issueTime", "(Ljava/util/Date;)Lcom/ca/mas/foundation/MASClaimsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_issuer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIssuer_Ljava_lang_String_Handler ()
		{
			if (cb_issuer_Ljava_lang_String_ == null)
				cb_issuer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Issuer_Ljava_lang_String_);
			return cb_issuer_Ljava_lang_String_;
		}

		static IntPtr n_Issuer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_issuer)
		{
			global::Com.CA.Mas.Foundation.MASClaimsBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string issuer = JNIEnv.GetString (native_issuer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Issuer (issuer));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_issuer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/method[@name='issuer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("issuer", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;", "GetIssuer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASClaimsBuilder Issuer (string issuer)
		{
			if (id_issuer_Ljava_lang_String_ == IntPtr.Zero)
				id_issuer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "issuer", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;");
			IntPtr native_issuer = JNIEnv.NewString (issuer);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_issuer);

				global::Com.CA.Mas.Foundation.MASClaimsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_issuer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "issuer", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_issuer);
			}
		}

		static Delegate cb_jwtId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetJwtId_Ljava_lang_String_Handler ()
		{
			if (cb_jwtId_Ljava_lang_String_ == null)
				cb_jwtId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_JwtId_Ljava_lang_String_);
			return cb_jwtId_Ljava_lang_String_;
		}

		static IntPtr n_JwtId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jti)
		{
			global::Com.CA.Mas.Foundation.MASClaimsBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string jti = JNIEnv.GetString (native_jti, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.JwtId (jti));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_jwtId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/method[@name='jwtId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("jwtId", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;", "GetJwtId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASClaimsBuilder JwtId (string jti)
		{
			if (id_jwtId_Ljava_lang_String_ == IntPtr.Zero)
				id_jwtId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "jwtId", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;");
			IntPtr native_jti = JNIEnv.NewString (jti);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_jti);

				global::Com.CA.Mas.Foundation.MASClaimsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_jwtId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "jwtId", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_jti);
			}
		}

		static Delegate cb_notBeforeTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetNotBeforeTime_Ljava_util_Date_Handler ()
		{
			if (cb_notBeforeTime_Ljava_util_Date_ == null)
				cb_notBeforeTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NotBeforeTime_Ljava_util_Date_);
			return cb_notBeforeTime_Ljava_util_Date_;
		}

		static IntPtr n_NotBeforeTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbf)
		{
			global::Com.CA.Mas.Foundation.MASClaimsBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date nbf = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_nbf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NotBeforeTime (nbf));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_notBeforeTime_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/method[@name='notBeforeTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("notBeforeTime", "(Ljava/util/Date;)Lcom/ca/mas/foundation/MASClaimsBuilder;", "GetNotBeforeTime_Ljava_util_Date_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASClaimsBuilder NotBeforeTime (global::Java.Util.Date nbf)
		{
			if (id_notBeforeTime_Ljava_util_Date_ == IntPtr.Zero)
				id_notBeforeTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "notBeforeTime", "(Ljava/util/Date;)Lcom/ca/mas/foundation/MASClaimsBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (nbf);

				global::Com.CA.Mas.Foundation.MASClaimsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_notBeforeTime_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notBeforeTime", "(Ljava/util/Date;)Lcom/ca/mas/foundation/MASClaimsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_subject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSubject_Ljava_lang_String_Handler ()
		{
			if (cb_subject_Ljava_lang_String_ == null)
				cb_subject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Subject_Ljava_lang_String_);
			return cb_subject_Ljava_lang_String_;
		}

		static IntPtr n_Subject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subject)
		{
			global::Com.CA.Mas.Foundation.MASClaimsBuilder __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string subject = JNIEnv.GetString (native_subject, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subject (subject));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASClaimsBuilder']/method[@name='subject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("subject", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;", "GetSubject_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.CA.Mas.Foundation.MASClaimsBuilder Subject (string subject)
		{
			if (id_subject_Ljava_lang_String_ == IntPtr.Zero)
				id_subject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "subject", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;");
			IntPtr native_subject = JNIEnv.NewString (subject);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_subject);

				global::Com.CA.Mas.Foundation.MASClaimsBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASClaimsBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subject", "(Ljava/lang/String;)Lcom/ca/mas/foundation/MASClaimsBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_subject);
			}
		}

	}
}
