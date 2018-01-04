using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASGroup", DoNotGenerateAcw=true)]
	public abstract partial class MASGroup : global::Java.Lang.Object, global::Com.CA.Mas.Foundation.IMASTransformable, global::Com.CA.Mas.Identity.Group.IMASGroupIdentity {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup.PatchOp']"
		[global::Android.Runtime.Register ("com/ca/mas/foundation/MASGroup$PatchOp", DoNotGenerateAcw=true)]
		public sealed partial class PatchOp : global::Java.Lang.Enum {


			static IntPtr ADD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup.PatchOp']/field[@name='ADD']"
			[Register ("ADD")]
			public static global::Com.CA.Mas.Foundation.MASGroup.PatchOp Add {
				get {
					if (ADD_jfieldId == IntPtr.Zero)
						ADD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADD", "Lcom/ca/mas/foundation/MASGroup$PatchOp;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup.PatchOp> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REMOVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup.PatchOp']/field[@name='REMOVE']"
			[Register ("REMOVE")]
			public static global::Com.CA.Mas.Foundation.MASGroup.PatchOp Remove {
				get {
					if (REMOVE_jfieldId == IntPtr.Zero)
						REMOVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REMOVE", "Lcom/ca/mas/foundation/MASGroup$PatchOp;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REMOVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup.PatchOp> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REPLACE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup.PatchOp']/field[@name='REPLACE']"
			[Register ("REPLACE")]
			public static global::Com.CA.Mas.Foundation.MASGroup.PatchOp Replace {
				get {
					if (REPLACE_jfieldId == IntPtr.Zero)
						REPLACE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPLACE", "Lcom/ca/mas/foundation/MASGroup$PatchOp;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPLACE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup.PatchOp> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ca/mas/foundation/MASGroup$PatchOp", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PatchOp); }
			}

			internal PatchOp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup.PatchOp']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Java.Lang.Enum __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup.PatchOp']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/ca/mas/foundation/MASGroup$PatchOp;", "")]
			public static unsafe global::Com.CA.Mas.Foundation.MASGroup.PatchOp[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/foundation/MASGroup$PatchOp;");
				try {
					return (global::Com.CA.Mas.Foundation.MASGroup.PatchOp[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Foundation.MASGroup.PatchOp));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASGroup", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASGroup); }
		}

		protected MASGroup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/constructor[@name='MASGroup' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASGroup ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASGroup)) {
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

		static Delegate cb_getGroupName;
#pragma warning disable 0169
		static Delegate GetGetGroupNameHandler ()
		{
			if (cb_getGroupName == null)
				cb_getGroupName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupName);
			return cb_getGroupName;
		}

		static IntPtr n_GetGroupName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupName);
		}
#pragma warning restore 0169

		static Delegate cb_setGroupName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGroupName_Ljava_lang_String_Handler ()
		{
			if (cb_setGroupName_Ljava_lang_String_ == null)
				cb_setGroupName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGroupName_Ljava_lang_String_);
			return cb_setGroupName_Ljava_lang_String_;
		}

		static void n_SetGroupName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupName = p0;
		}
#pragma warning restore 0169

		public abstract string GroupName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupName' and count(parameter)=0]"
			[Register ("getGroupName", "()Ljava/lang/String;", "GetGetGroupNameHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='setGroupName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGroupName", "(Ljava/lang/String;)V", "GetSetGroupName_Ljava_lang_String_Handler")] set;
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public abstract string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")] get;
		}

		static Delegate cb_getMembers;
#pragma warning disable 0169
		static Delegate GetGetMembersHandler ()
		{
			if (cb_getMembers == null)
				cb_getMembers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMembers);
			return cb_getMembers;
		}

		static IntPtr n_GetMembers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.Group.MASMember>.ToLocalJniHandle (__this.Members);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.Group.MASMember> Members {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getMembers' and count(parameter)=0]"
			[Register ("getMembers", "()Ljava/util/List;", "GetGetMembersHandler")] get;
		}

		static Delegate cb_getMeta;
#pragma warning disable 0169
		static Delegate GetGetMetaHandler ()
		{
			if (cb_getMeta == null)
				cb_getMeta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeta);
			return cb_getMeta;
		}

		static IntPtr n_GetMeta (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Meta);
		}
#pragma warning restore 0169

		public abstract global::Com.CA.Mas.Identity.User.MASMeta Meta {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getMeta' and count(parameter)=0]"
			[Register ("getMeta", "()Lcom/ca/mas/identity/user/MASMeta;", "GetGetMetaHandler")] get;
		}

		static Delegate cb_getOwner;
#pragma warning disable 0169
		static Delegate GetGetOwnerHandler ()
		{
			if (cb_getOwner == null)
				cb_getOwner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwner);
			return cb_getOwner;
		}

		static IntPtr n_GetOwner (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Owner);
		}
#pragma warning restore 0169

		public abstract global::Com.CA.Mas.Identity.Group.MASOwner Owner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getOwner' and count(parameter)=0]"
			[Register ("getOwner", "()Lcom/ca/mas/identity/group/MASOwner;", "GetGetOwnerHandler")] get;
		}

		static Delegate cb_getReference;
#pragma warning disable 0169
		static Delegate GetGetReferenceHandler ()
		{
			if (cb_getReference == null)
				cb_getReference = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReference);
			return cb_getReference;
		}

		static IntPtr n_GetReference (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Reference);
		}
#pragma warning restore 0169

		public abstract string Reference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getReference' and count(parameter)=0]"
			[Register ("getReference", "()Ljava/lang/String;", "GetGetReferenceHandler")] get;
		}

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		public abstract string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")] get;
		}

		static Delegate cb_addMember_Lcom_ca_mas_identity_group_MASMember_;
#pragma warning disable 0169
		static Delegate GetAddMember_Lcom_ca_mas_identity_group_MASMember_Handler ()
		{
			if (cb_addMember_Lcom_ca_mas_identity_group_MASMember_ == null)
				cb_addMember_Lcom_ca_mas_identity_group_MASMember_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddMember_Lcom_ca_mas_identity_group_MASMember_);
			return cb_addMember_Lcom_ca_mas_identity_group_MASMember_;
		}

		static void n_AddMember_Lcom_ca_mas_identity_group_MASMember_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Identity.Group.MASMember p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASMember> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddMember (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='addMember' and count(parameter)=1 and parameter[1][@type='com.ca.mas.identity.group.MASMember']]"
		[Register ("addMember", "(Lcom/ca/mas/identity/group/MASMember;)V", "GetAddMember_Lcom_ca_mas_identity_group_MASMember_Handler")]
		public abstract void AddMember (global::Com.CA.Mas.Identity.Group.MASMember p0);

		static Delegate cb_delete_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetDelete_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_delete_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_delete_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Delete_Lcom_ca_mas_foundation_MASCallback_);
			return cb_delete_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_Delete_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("delete", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetDelete_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void Delete (global::Com.CA.Mas.Foundation.MASCallback p0);

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
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetAllGroups (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getAllGroups' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
		[Register ("getAllGroups", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void GetAllGroups (string p0, global::Com.CA.Mas.Foundation.MASCallback p1);

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
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetGroupByGroupName (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupByGroupName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
		[Register ("getGroupByGroupName", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void GetGroupByGroupName (string p0, global::Com.CA.Mas.Foundation.MASCallback p1);

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
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetGroupById (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupById' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASGroup&gt;']]"
		[Register ("getGroupById", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void GetGroupById (string p0, global::Com.CA.Mas.Foundation.MASCallback p1);

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
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASUser p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetGroupByMember (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupByMember' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASUser'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
		[Register ("getGroupByMember", "(Lcom/ca/mas/foundation/MASUser;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void GetGroupByMember (global::Com.CA.Mas.Foundation.MASUser p0, global::Com.CA.Mas.Foundation.MASCallback p1);

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
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetGroupMetaData (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupMetaData' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.identity.group.GroupAttributes&gt;']]"
		[Register ("getGroupMetaData", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupMetaData_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void GetGroupMetaData (global::Com.CA.Mas.Foundation.MASCallback p0);

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
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.MASFilteredRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetGroupsByFilter (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupsByFilter' and count(parameter)=2 and parameter[1][@type='com.ca.mas.identity.common.MASFilteredRequest'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
		[Register ("getGroupsByFilter", "(Lcom/ca/mas/identity/common/MASFilteredRequest;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void GetGroupsByFilter (global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0, global::Com.CA.Mas.Foundation.MASCallback p1);

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/ca/mas/foundation/MASGroup;", "")]
		public static unsafe global::Com.CA.Mas.Foundation.MASGroup NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/ca/mas/foundation/MASGroup;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeMember_Lcom_ca_mas_identity_group_MASMember_;
#pragma warning disable 0169
		static Delegate GetRemoveMember_Lcom_ca_mas_identity_group_MASMember_Handler ()
		{
			if (cb_removeMember_Lcom_ca_mas_identity_group_MASMember_ == null)
				cb_removeMember_Lcom_ca_mas_identity_group_MASMember_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveMember_Lcom_ca_mas_identity_group_MASMember_);
			return cb_removeMember_Lcom_ca_mas_identity_group_MASMember_;
		}

		static void n_RemoveMember_Lcom_ca_mas_identity_group_MASMember_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Identity.Group.MASMember p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASMember> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMember (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='removeMember' and count(parameter)=1 and parameter[1][@type='com.ca.mas.identity.group.MASMember']]"
		[Register ("removeMember", "(Lcom/ca/mas/identity/group/MASMember;)V", "GetRemoveMember_Lcom_ca_mas_identity_group_MASMember_Handler")]
		public abstract void RemoveMember (global::Com.CA.Mas.Identity.Group.MASMember p0);

		static Delegate cb_save_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSave_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_save_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_save_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Save_Lcom_ca_mas_foundation_MASCallback_);
			return cb_save_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_Save_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Save (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='save' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASGroup&gt;']]"
		[Register ("save", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetSave_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public abstract void Save (global::Com.CA.Mas.Foundation.MASCallback p0);

		static Delegate cb_populate_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetPopulate_Lorg_json_JSONObject_Handler ()
		{
			if (cb_populate_Lorg_json_JSONObject_ == null)
				cb_populate_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Populate_Lorg_json_JSONObject_);
			return cb_populate_Lorg_json_JSONObject_;
		}

		static void n_Populate_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Populate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASTransformable']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("populate", "(Lorg/json/JSONObject;)V", "GetPopulate_Lorg_json_JSONObject_Handler")]
		public abstract void Populate (global::Org.Json.JSONObject p0);

		static Delegate cb_getAsJSONObject;
#pragma warning disable 0169
		static Delegate GetGetAsJSONObjectHandler ()
		{
			if (cb_getAsJSONObject == null)
				cb_getAsJSONObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJSONObject);
			return cb_getAsJSONObject;
		}

		static IntPtr n_GetAsJSONObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASGroup __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJSONObject);
		}
#pragma warning restore 0169

		public abstract global::Org.Json.JSONObject AsJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getAsJSONObject' and count(parameter)=0]"
			[Register ("getAsJSONObject", "()Lorg/json/JSONObject;", "GetGetAsJSONObjectHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASGroup", DoNotGenerateAcw=true)]
	internal partial class MASGroupInvoker : MASGroup {

		public MASGroupInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASGroupInvoker); }
		}

		static IntPtr id_getGroupName;
		static IntPtr id_setGroupName_Ljava_lang_String_;
		public override unsafe string GroupName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupName' and count(parameter)=0]"
			[Register ("getGroupName", "()Ljava/lang/String;", "GetGetGroupNameHandler")]
			get {
				if (id_getGroupName == IntPtr.Zero)
					id_getGroupName = JNIEnv.GetMethodID (class_ref, "getGroupName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='setGroupName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGroupName", "(Ljava/lang/String;)V", "GetSetGroupName_Ljava_lang_String_Handler")]
			set {
				if (id_setGroupName_Ljava_lang_String_ == IntPtr.Zero)
					id_setGroupName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGroupName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGroupName_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getId;
		public override unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMembers;
		public override unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.Group.MASMember> Members {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getMembers' and count(parameter)=0]"
			[Register ("getMembers", "()Ljava/util/List;", "GetGetMembersHandler")]
			get {
				if (id_getMembers == IntPtr.Zero)
					id_getMembers = JNIEnv.GetMethodID (class_ref, "getMembers", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.Group.MASMember>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMembers), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMeta;
		public override unsafe global::Com.CA.Mas.Identity.User.MASMeta Meta {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getMeta' and count(parameter)=0]"
			[Register ("getMeta", "()Lcom/ca/mas/identity/user/MASMeta;", "GetGetMetaHandler")]
			get {
				if (id_getMeta == IntPtr.Zero)
					id_getMeta = JNIEnv.GetMethodID (class_ref, "getMeta", "()Lcom/ca/mas/identity/user/MASMeta;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASMeta> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMeta), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getOwner;
		public override unsafe global::Com.CA.Mas.Identity.Group.MASOwner Owner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getOwner' and count(parameter)=0]"
			[Register ("getOwner", "()Lcom/ca/mas/identity/group/MASOwner;", "GetGetOwnerHandler")]
			get {
				if (id_getOwner == IntPtr.Zero)
					id_getOwner = JNIEnv.GetMethodID (class_ref, "getOwner", "()Lcom/ca/mas/identity/group/MASOwner;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASOwner> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOwner), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getReference;
		public override unsafe string Reference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getReference' and count(parameter)=0]"
			[Register ("getReference", "()Ljava/lang/String;", "GetGetReferenceHandler")]
			get {
				if (id_getReference == IntPtr.Zero)
					id_getReference = JNIEnv.GetMethodID (class_ref, "getReference", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReference), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getValue;
		public override unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_addMember_Lcom_ca_mas_identity_group_MASMember_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='addMember' and count(parameter)=1 and parameter[1][@type='com.ca.mas.identity.group.MASMember']]"
		[Register ("addMember", "(Lcom/ca/mas/identity/group/MASMember;)V", "GetAddMember_Lcom_ca_mas_identity_group_MASMember_Handler")]
		public override unsafe void AddMember (global::Com.CA.Mas.Identity.Group.MASMember p0)
		{
			if (id_addMember_Lcom_ca_mas_identity_group_MASMember_ == IntPtr.Zero)
				id_addMember_Lcom_ca_mas_identity_group_MASMember_ = JNIEnv.GetMethodID (class_ref, "addMember", "(Lcom/ca/mas/identity/group/MASMember;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addMember_Lcom_ca_mas_identity_group_MASMember_, __args);
			} finally {
			}
		}

		static IntPtr id_delete_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("delete", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetDelete_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void Delete (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_delete_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_delete_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "delete", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getAllGroups' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
		[Register ("getAllGroups", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void GetAllGroups (string p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getAllGroups", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAllGroups_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupByGroupName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
		[Register ("getGroupByGroupName", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void GetGroupByGroupName (string p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getGroupByGroupName", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGroupByGroupName_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupById' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASGroup&gt;']]"
		[Register ("getGroupById", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void GetGroupById (string p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getGroupById", "(Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGroupById_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupByMember' and count(parameter)=2 and parameter[1][@type='com.ca.mas.foundation.MASUser'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
		[Register ("getGroupByMember", "(Lcom/ca/mas/foundation/MASUser;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void GetGroupByMember (global::Com.CA.Mas.Foundation.MASUser p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getGroupByMember", "(Lcom/ca/mas/foundation/MASUser;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGroupByMember_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupMetaData' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.identity.group.GroupAttributes&gt;']]"
		[Register ("getGroupMetaData", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupMetaData_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void GetGroupMetaData (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getGroupMetaData", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGroupMetaData_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getGroupsByFilter' and count(parameter)=2 and parameter[1][@type='com.ca.mas.identity.common.MASFilteredRequest'] and parameter[2][@type='com.ca.mas.foundation.MASCallback&lt;java.util.List&lt;com.ca.mas.foundation.MASGroup&gt;&gt;']]"
		[Register ("getGroupsByFilter", "(Lcom/ca/mas/identity/common/MASFilteredRequest;Lcom/ca/mas/foundation/MASCallback;)V", "GetGetGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void GetGroupsByFilter (global::Com.CA.Mas.Identity.Common.MASFilteredRequest p0, global::Com.CA.Mas.Foundation.MASCallback p1)
		{
			if (id_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getGroupsByFilter", "(Lcom/ca/mas/identity/common/MASFilteredRequest;Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getGroupsByFilter_Lcom_ca_mas_identity_common_MASFilteredRequest_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_removeMember_Lcom_ca_mas_identity_group_MASMember_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='removeMember' and count(parameter)=1 and parameter[1][@type='com.ca.mas.identity.group.MASMember']]"
		[Register ("removeMember", "(Lcom/ca/mas/identity/group/MASMember;)V", "GetRemoveMember_Lcom_ca_mas_identity_group_MASMember_Handler")]
		public override unsafe void RemoveMember (global::Com.CA.Mas.Identity.Group.MASMember p0)
		{
			if (id_removeMember_Lcom_ca_mas_identity_group_MASMember_ == IntPtr.Zero)
				id_removeMember_Lcom_ca_mas_identity_group_MASMember_ = JNIEnv.GetMethodID (class_ref, "removeMember", "(Lcom/ca/mas/identity/group/MASMember;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMember_Lcom_ca_mas_identity_group_MASMember_, __args);
			} finally {
			}
		}

		static IntPtr id_save_Lcom_ca_mas_foundation_MASCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='save' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASGroup&gt;']]"
		[Register ("save", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetSave_Lcom_ca_mas_foundation_MASCallback_Handler")]
		public override unsafe void Save (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_save_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_save_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "save", "(Lcom/ca/mas/foundation/MASCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Lcom_ca_mas_foundation_MASCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_getAsJSONObject;
		public override unsafe global::Org.Json.JSONObject AsJSONObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASGroup']/method[@name='getAsJSONObject' and count(parameter)=0]"
			[Register ("getAsJSONObject", "()Lorg/json/JSONObject;", "GetGetAsJSONObjectHandler")]
			get {
				if (id_getAsJSONObject == IntPtr.Zero)
					id_getAsJSONObject = JNIEnv.GetMethodID (class_ref, "getAsJSONObject", "()Lorg/json/JSONObject;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJSONObject), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_populate_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='MASTransformable']/method[@name='populate' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("populate", "(Lorg/json/JSONObject;)V", "GetPopulate_Lorg_json_JSONObject_Handler")]
		public override unsafe void Populate (global::Org.Json.JSONObject p0)
		{
			if (id_populate_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_populate_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "populate", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_populate_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

	}

}
