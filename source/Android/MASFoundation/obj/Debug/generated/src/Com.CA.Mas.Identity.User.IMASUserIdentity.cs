using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.User {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='MASUserIdentity']"
	[Register ("com/ca/mas/identity/user/MASUserIdentity", "", "Com.CA.Mas.Identity.User.IMASUserIdentityInvoker")]
	public partial interface IMASUserIdentity : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='MASUserIdentity']/method[@name='getUserById' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASUser&gt;']]"
		[Register ("getUserById", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Identity.User.IMASUserIdentityInvoker, MASFoundation")]
		void GetUserById (string p0, global::Com.CA.Mas.Foundation.MASCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='MASUserIdentity']/method[@name='getUserMetaData' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.identity.user.UserAttributes&gt;']]"
		[Register ("getUserMetaData", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetGetUserMetaData_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Identity.User.IMASUserIdentityInvoker, MASFoundation")]
		void GetUserMetaData (global::Com.CA.Mas.Foundation.MASCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='MASUserIdentity']/method[@name='getUsersByFilter' and count(parameter)=2 and parameter[1][@type='com.ca.mas.identity.common.MASFilteredRequest'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASUser&gt;&gt;']]"
		[Register ("getUsersByFilter", "(Lcom/ca/mas/identity/common/MASFilteredRequest;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Identity.User.IMASUserIdentityInvoker, MASFoundation")]
		void GetUsersByFilter (global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0, global::Com.CA.Mas.Foundation.MASCallback p1);

	}

	[global::Android.Runtime.Register ("com/ca/mas/identity/user/MASUserIdentity", DoNotGenerateAcw=true)]
	internal class IMASUserIdentityInvoker : global::Java.Lang.Object, IMASUserIdentity {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/identity/user/MASUserIdentity");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASUserIdentityInvoker); }
		}

		IntPtr class_ref;

		public static IMASUserIdentity GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASUserIdentity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.identity.user.MASUserIdentity"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASUserIdentityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Identity.User.IMASUserIdentity __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IMASUserIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetUserById (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void GetUserById (string p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getUserById", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getUserById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetUserMetaData_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetUserMetaData_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetUserMetaData_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Identity.User.IMASUserIdentity __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IMASUserIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetUserMetaData (p0);
		}
#pragma warning restore 0169

		IntPtr id_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void GetUserMetaData (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getUserMetaData", "(Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getUserMetaData_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

		static Delegate cb_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Identity.User.IMASUserIdentity __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IMASUserIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.MASFilteredRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetUsersByFilter (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void GetUsersByFilter (global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getUsersByFilter", "(Lcom/ca/mas/identity/common/MASFilteredRequest;Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getUsersByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

	}

}
