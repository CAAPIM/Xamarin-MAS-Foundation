using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASClaims']"
	[Register ("com/ca/mas/foundation/MASClaims", "", "Com.CA.Mas.Foundation.IMASClaimsInvoker")]
	public partial interface IMASClaims : IJavaObject {

		global::System.Collections.Generic.IList<string> Audience {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASClaims']/method[@name='getAudience' and count(parameter)=0]"
			[Register ("getAudience", "()Ljava/util/List;", "GetGetAudienceHandler:Com.CA.Mas.Foundation.IMASClaimsInvoker, MASFoundation")] get;
		}

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Claims {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASClaims']/method[@name='getClaims' and count(parameter)=0]"
			[Register ("getClaims", "()Ljava/util/Map;", "GetGetClaimsHandler:Com.CA.Mas.Foundation.IMASClaimsInvoker, MASFoundation")] get;
		}

		global::Java.Util.Date ExpirationTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASClaims']/method[@name='getExpirationTime' and count(parameter)=0]"
			[Register ("getExpirationTime", "()Ljava/util/Date;", "GetGetExpirationTimeHandler:Com.CA.Mas.Foundation.IMASClaimsInvoker, MASFoundation")] get;
		}

		global::Java.Util.Date IssuedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASClaims']/method[@name='getIssuedAt' and count(parameter)=0]"
			[Register ("getIssuedAt", "()Ljava/util/Date;", "GetGetIssuedAtHandler:Com.CA.Mas.Foundation.IMASClaimsInvoker, MASFoundation")] get;
		}

		string Issuer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASClaims']/method[@name='getIssuer' and count(parameter)=0]"
			[Register ("getIssuer", "()Ljava/lang/String;", "GetGetIssuerHandler:Com.CA.Mas.Foundation.IMASClaimsInvoker, MASFoundation")] get;
		}

		string JwtId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASClaims']/method[@name='getJwtId' and count(parameter)=0]"
			[Register ("getJwtId", "()Ljava/lang/String;", "GetGetJwtIdHandler:Com.CA.Mas.Foundation.IMASClaimsInvoker, MASFoundation")] get;
		}

		global::Java.Util.Date NotBefore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASClaims']/method[@name='getNotBefore' and count(parameter)=0]"
			[Register ("getNotBefore", "()Ljava/util/Date;", "GetGetNotBeforeHandler:Com.CA.Mas.Foundation.IMASClaimsInvoker, MASFoundation")] get;
		}

		string Subject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASClaims']/method[@name='getSubject' and count(parameter)=0]"
			[Register ("getSubject", "()Ljava/lang/String;", "GetGetSubjectHandler:Com.CA.Mas.Foundation.IMASClaimsInvoker, MASFoundation")] get;
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASClaims", DoNotGenerateAcw=true)]
	internal class IMASClaimsInvoker : global::Java.Lang.Object, IMASClaims {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/MASClaims");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASClaimsInvoker); }
		}

		IntPtr class_ref;

		public static IMASClaims GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASClaims> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.MASClaims"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASClaimsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAudience;
#pragma warning disable 0169
		static Delegate GetGetAudienceHandler ()
		{
			if (cb_getAudience == null)
				cb_getAudience = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudience);
			return cb_getAudience;
		}

		static IntPtr n_GetAudience (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASClaims __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASClaims> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Audience);
		}
#pragma warning restore 0169

		IntPtr id_getAudience;
		public unsafe global::System.Collections.Generic.IList<string> Audience {
			get {
				if (id_getAudience == IntPtr.Zero)
					id_getAudience = JNIEnv.GetMethodID (class_ref, "getAudience", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudience), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getClaims;
#pragma warning disable 0169
		static Delegate GetGetClaimsHandler ()
		{
			if (cb_getClaims == null)
				cb_getClaims = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClaims);
			return cb_getClaims;
		}

		static IntPtr n_GetClaims (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASClaims __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASClaims> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Claims);
		}
#pragma warning restore 0169

		IntPtr id_getClaims;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Claims {
			get {
				if (id_getClaims == IntPtr.Zero)
					id_getClaims = JNIEnv.GetMethodID (class_ref, "getClaims", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClaims), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getExpirationTime;
#pragma warning disable 0169
		static Delegate GetGetExpirationTimeHandler ()
		{
			if (cb_getExpirationTime == null)
				cb_getExpirationTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpirationTime);
			return cb_getExpirationTime;
		}

		static IntPtr n_GetExpirationTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASClaims __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASClaims> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpirationTime);
		}
#pragma warning restore 0169

		IntPtr id_getExpirationTime;
		public unsafe global::Java.Util.Date ExpirationTime {
			get {
				if (id_getExpirationTime == IntPtr.Zero)
					id_getExpirationTime = JNIEnv.GetMethodID (class_ref, "getExpirationTime", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpirationTime), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIssuedAt;
#pragma warning disable 0169
		static Delegate GetGetIssuedAtHandler ()
		{
			if (cb_getIssuedAt == null)
				cb_getIssuedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIssuedAt);
			return cb_getIssuedAt;
		}

		static IntPtr n_GetIssuedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASClaims __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASClaims> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IssuedAt);
		}
#pragma warning restore 0169

		IntPtr id_getIssuedAt;
		public unsafe global::Java.Util.Date IssuedAt {
			get {
				if (id_getIssuedAt == IntPtr.Zero)
					id_getIssuedAt = JNIEnv.GetMethodID (class_ref, "getIssuedAt", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIssuedAt), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIssuer;
#pragma warning disable 0169
		static Delegate GetGetIssuerHandler ()
		{
			if (cb_getIssuer == null)
				cb_getIssuer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIssuer);
			return cb_getIssuer;
		}

		static IntPtr n_GetIssuer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASClaims __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASClaims> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Issuer);
		}
#pragma warning restore 0169

		IntPtr id_getIssuer;
		public unsafe string Issuer {
			get {
				if (id_getIssuer == IntPtr.Zero)
					id_getIssuer = JNIEnv.GetMethodID (class_ref, "getIssuer", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIssuer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getJwtId;
#pragma warning disable 0169
		static Delegate GetGetJwtIdHandler ()
		{
			if (cb_getJwtId == null)
				cb_getJwtId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJwtId);
			return cb_getJwtId;
		}

		static IntPtr n_GetJwtId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASClaims __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASClaims> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JwtId);
		}
#pragma warning restore 0169

		IntPtr id_getJwtId;
		public unsafe string JwtId {
			get {
				if (id_getJwtId == IntPtr.Zero)
					id_getJwtId = JNIEnv.GetMethodID (class_ref, "getJwtId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJwtId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNotBefore;
#pragma warning disable 0169
		static Delegate GetGetNotBeforeHandler ()
		{
			if (cb_getNotBefore == null)
				cb_getNotBefore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotBefore);
			return cb_getNotBefore;
		}

		static IntPtr n_GetNotBefore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASClaims __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASClaims> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotBefore);
		}
#pragma warning restore 0169

		IntPtr id_getNotBefore;
		public unsafe global::Java.Util.Date NotBefore {
			get {
				if (id_getNotBefore == IntPtr.Zero)
					id_getNotBefore = JNIEnv.GetMethodID (class_ref, "getNotBefore", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotBefore), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSubject;
#pragma warning disable 0169
		static Delegate GetGetSubjectHandler ()
		{
			if (cb_getSubject == null)
				cb_getSubject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubject);
			return cb_getSubject;
		}

		static IntPtr n_GetSubject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.IMASClaims __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IMASClaims> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Subject);
		}
#pragma warning restore 0169

		IntPtr id_getSubject;
		public unsafe string Subject {
			get {
				if (id_getSubject == IntPtr.Zero)
					id_getSubject = JNIEnv.GetMethodID (class_ref, "getSubject", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubject), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
