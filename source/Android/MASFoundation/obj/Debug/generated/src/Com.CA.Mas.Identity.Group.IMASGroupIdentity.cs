using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.Group {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.identity.group']/interface[@name='MASGroupIdentity']"
	[Register ("com/ca/mas/identity/group/MASGroupIdentity", "", "Com.CA.Mas.Identity.Group.IMASGroupIdentityInvoker")]
	public partial interface IMASGroupIdentity : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/interface[@name='MASGroupIdentity']/method[@name='getAllGroups' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
[Obsolete (@"deprecated")]
		[Register ("getAllGroups", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Identity.Group.IMASGroupIdentityInvoker, MASFoundation")]
		void GetAllGroups (string p0, global::Com.CA.Mas.Foundation.MASCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/interface[@name='MASGroupIdentity']/method[@name='getGroupByGroupName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
[Obsolete (@"deprecated")]
		[Register ("getGroupByGroupName", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Identity.Group.IMASGroupIdentityInvoker, MASFoundation")]
		void GetGroupByGroupName (string p0, global::Com.CA.Mas.Foundation.MASCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/interface[@name='MASGroupIdentity']/method[@name='getGroupById' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASGroup&gt;']]"
		[Register ("getGroupById", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Identity.Group.IMASGroupIdentityInvoker, MASFoundation")]
		void GetGroupById (string p0, global::Com.CA.Mas.Foundation.MASCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/interface[@name='MASGroupIdentity']/method[@name='getGroupByMember' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASUser'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
[Obsolete (@"deprecated")]
		[Register ("getGroupByMember", "(Lcom/ca/mas/foundation/MASUser;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Identity.Group.IMASGroupIdentityInvoker, MASFoundation")]
		void GetGroupByMember (global::Com.CA.Mas.Foundation.MASUser p0, global::Com.CA.Mas.Foundation.MASCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/interface[@name='MASGroupIdentity']/method[@name='getGroupMetaData' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.identity.group.GroupAttributes&gt;']]"
		[Register ("getGroupMetaData", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupMetaData_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Identity.Group.IMASGroupIdentityInvoker, MASFoundation")]
		void GetGroupMetaData (global::Com.CA.Mas.Foundation.MASCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/interface[@name='MASGroupIdentity']/method[@name='getGroupsByFilter' and count(parameter)=2 and parameter[1][@type='com.ca.mas.identity.common.MASFilteredRequest'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
		[Register ("getGroupsByFilter", "(Lcom/ca/mas/identity/common/MASFilteredRequest;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Identity.Group.IMASGroupIdentityInvoker, MASFoundation")]
		void GetGroupsByFilter (global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0, global::Com.CA.Mas.Foundation.MASCallback p1);

	}

	[global::Android.Runtime.Register ("com/ca/mas/identity/group/MASGroupIdentity", DoNotGenerateAcw=true)]
	internal class IMASGroupIdentityInvoker : global::Java.Lang.Object, IMASGroupIdentity {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/identity/group/MASGroupIdentity");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASGroupIdentityInvoker); }
		}

		IntPtr class_ref;

		public static IMASGroupIdentity GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASGroupIdentity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.identity.group.MASGroupIdentity"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASGroupIdentityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Identity.Group.IMASGroupIdentity __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.IMASGroupIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetAllGroups (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void GetAllGroups (string p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getAllGroups", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Identity.Group.IMASGroupIdentity __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.IMASGroupIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetGroupByGroupName (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void GetGroupByGroupName (string p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getGroupByGroupName", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Identity.Group.IMASGroupIdentity __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.IMASGroupIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetGroupById (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void GetGroupById (string p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getGroupById", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Identity.Group.IMASGroupIdentity __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.IMASGroupIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASUser p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetGroupByMember (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void GetGroupByMember (global::Com.CA.Mas.Foundation.MASUser p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getGroupByMember", "(Lcom/ca/mas/foundation/MASUser;Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

		static Delegate cb_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetGroupMetaData_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetGroupMetaData_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetGroupMetaData_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Identity.Group.IMASGroupIdentity __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.IMASGroupIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetGroupMetaData (p0);
		}
#pragma warning restore 0169

		IntPtr id_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void GetGroupMetaData (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getGroupMetaData", "(Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

		static Delegate cb_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.CA.Mas.Identity.Group.IMASGroupIdentity __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.IMASGroupIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.MASFilteredRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetGroupsByFilter (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void GetGroupsByFilter (global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getGroupsByFilter", "(Lcom/ca/mas/identity/common/MASFilteredRequest;Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

	}

}
