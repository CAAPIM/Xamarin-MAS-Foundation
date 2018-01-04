using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.User {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']"
	[Register ("com/ca/mas/identity/user/ScimUser", "", "Com.CA.Mas.Identity.User.IScimUserInvoker")]
	public partial interface IScimUser : global::Com.CA.Mas.Foundation.IMASTransformable, global::Com.CA.Mas.Identity.IScimIdentifiable {

		global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASAddress> AddressList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getAddressList' and count(parameter)=0]"
			[Register ("getAddressList", "()Ljava/util/List;", "GetGetAddressListHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASEmail> EmailList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getEmailList' and count(parameter)=0]"
			[Register ("getEmailList", "()Ljava/util/List;", "GetGetEmailListHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		global::System.Collections.Generic.IList<global::Com.CA.Mas.Foundation.MASGroup> GroupList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getGroupList' and count(parameter)=0]"
			[Register ("getGroupList", "()Ljava/util/List;", "GetGetGroupListHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASIms> ImsList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getImsList' and count(parameter)=0]"
			[Register ("getImsList", "()Ljava/util/List;", "GetGetImsListHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "GetIsActiveHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		string Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/lang/String;", "GetGetLocaleHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		global::Com.CA.Mas.Identity.User.MASMeta Meta {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getMeta' and count(parameter)=0]"
			[Register ("getMeta", "()Lcom/ca/mas/identity/user/MASMeta;", "GetGetMetaHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		global::Com.CA.Mas.Identity.User.MASName Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Lcom/ca/mas/identity/user/MASName;", "GetGetNameHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		string NickName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getNickName' and count(parameter)=0]"
			[Register ("getNickName", "()Ljava/lang/String;", "GetGetNickNameHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASPhone> PhoneList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getPhoneList' and count(parameter)=0]"
			[Register ("getPhoneList", "()Ljava/util/List;", "GetGetPhoneListHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASPhoto> PhotoList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getPhotoList' and count(parameter)=0]"
			[Register ("getPhotoList", "()Ljava/util/List;", "GetGetPhotoListHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		string PreferredLanguage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getPreferredLanguage' and count(parameter)=0]"
			[Register ("getPreferredLanguage", "()Ljava/lang/String;", "GetGetPreferredLanguageHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		string ProfileUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getProfileUrl' and count(parameter)=0]"
			[Register ("getProfileUrl", "()Ljava/lang/String;", "GetGetProfileUrlHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		global::Org.Json.JSONObject Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Lorg/json/JSONObject;", "GetGetSourceHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		string TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()Ljava/lang/String;", "GetGetTimeZoneHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		string UserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getUserName' and count(parameter)=0]"
			[Register ("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

		string UserType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/interface[@name='ScimUser']/method[@name='getUserType' and count(parameter)=0]"
			[Register ("getUserType", "()Ljava/lang/String;", "GetGetUserTypeHandler:Com.CA.Mas.Identity.User.IScimUserInvoker, MASFoundation")] get;
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/identity/user/ScimUser", DoNotGenerateAcw=true)]
	internal class IScimUserInvoker : global::Java.Lang.Object, IScimUser {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/identity/user/ScimUser");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IScimUserInvoker); }
		}

		IntPtr class_ref;

		public static IScimUser GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScimUser> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.identity.user.ScimUser"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScimUserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAddressList;
#pragma warning disable 0169
		static Delegate GetGetAddressListHandler ()
		{
			if (cb_getAddressList == null)
				cb_getAddressList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddressList);
			return cb_getAddressList;
		}

		static IntPtr n_GetAddressList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASAddress>.ToLocalJniHandle (__this.AddressList);
		}
#pragma warning restore 0169

		IntPtr id_getAddressList;
		public unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASAddress> AddressList {
			get {
				if (id_getAddressList == IntPtr.Zero)
					id_getAddressList = JNIEnv.GetMethodID (class_ref, "getAddressList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASAddress>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddressList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEmailList;
#pragma warning disable 0169
		static Delegate GetGetEmailListHandler ()
		{
			if (cb_getEmailList == null)
				cb_getEmailList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmailList);
			return cb_getEmailList;
		}

		static IntPtr n_GetEmailList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASEmail>.ToLocalJniHandle (__this.EmailList);
		}
#pragma warning restore 0169

		IntPtr id_getEmailList;
		public unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASEmail> EmailList {
			get {
				if (id_getEmailList == IntPtr.Zero)
					id_getEmailList = JNIEnv.GetMethodID (class_ref, "getEmailList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASEmail>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmailList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGroupList;
#pragma warning disable 0169
		static Delegate GetGetGroupListHandler ()
		{
			if (cb_getGroupList == null)
				cb_getGroupList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupList);
			return cb_getGroupList;
		}

		static IntPtr n_GetGroupList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Foundation.MASGroup>.ToLocalJniHandle (__this.GroupList);
		}
#pragma warning restore 0169

		IntPtr id_getGroupList;
		public unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Foundation.MASGroup> GroupList {
			get {
				if (id_getGroupList == IntPtr.Zero)
					id_getGroupList = JNIEnv.GetMethodID (class_ref, "getGroupList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.CA.Mas.Foundation.MASGroup>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getImsList;
#pragma warning disable 0169
		static Delegate GetGetImsListHandler ()
		{
			if (cb_getImsList == null)
				cb_getImsList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImsList);
			return cb_getImsList;
		}

		static IntPtr n_GetImsList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASIms>.ToLocalJniHandle (__this.ImsList);
		}
#pragma warning restore 0169

		IntPtr id_getImsList;
		public unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASIms> ImsList {
			get {
				if (id_getImsList == IntPtr.Zero)
					id_getImsList = JNIEnv.GetMethodID (class_ref, "getImsList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASIms>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImsList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isActive;
#pragma warning disable 0169
		static Delegate GetIsActiveHandler ()
		{
			if (cb_isActive == null)
				cb_isActive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsActive);
			return cb_isActive;
		}

		static bool n_IsActive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActive;
		}
#pragma warning restore 0169

		IntPtr id_isActive;
		public unsafe bool IsActive {
			get {
				if (id_isActive == IntPtr.Zero)
					id_isActive = JNIEnv.GetMethodID (class_ref, "isActive", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isActive);
			}
		}

		static Delegate cb_getLocale;
#pragma warning disable 0169
		static Delegate GetGetLocaleHandler ()
		{
			if (cb_getLocale == null)
				cb_getLocale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocale);
			return cb_getLocale;
		}

		static IntPtr n_GetLocale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Locale);
		}
#pragma warning restore 0169

		IntPtr id_getLocale;
		public unsafe string Locale {
			get {
				if (id_getLocale == IntPtr.Zero)
					id_getLocale = JNIEnv.GetMethodID (class_ref, "getLocale", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocale), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Meta);
		}
#pragma warning restore 0169

		IntPtr id_getMeta;
		public unsafe global::Com.CA.Mas.Identity.User.MASMeta Meta {
			get {
				if (id_getMeta == IntPtr.Zero)
					id_getMeta = JNIEnv.GetMethodID (class_ref, "getMeta", "()Lcom/ca/mas/identity/user/MASMeta;");
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASMeta> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMeta), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe global::Com.CA.Mas.Identity.User.MASName Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Lcom/ca/mas/identity/user/MASName;");
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASName> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNickName;
#pragma warning disable 0169
		static Delegate GetGetNickNameHandler ()
		{
			if (cb_getNickName == null)
				cb_getNickName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNickName);
			return cb_getNickName;
		}

		static IntPtr n_GetNickName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NickName);
		}
#pragma warning restore 0169

		IntPtr id_getNickName;
		public unsafe string NickName {
			get {
				if (id_getNickName == IntPtr.Zero)
					id_getNickName = JNIEnv.GetMethodID (class_ref, "getNickName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNickName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		IntPtr id_getPassword;
		public unsafe string Password {
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPhoneList;
#pragma warning disable 0169
		static Delegate GetGetPhoneListHandler ()
		{
			if (cb_getPhoneList == null)
				cb_getPhoneList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneList);
			return cb_getPhoneList;
		}

		static IntPtr n_GetPhoneList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASPhone>.ToLocalJniHandle (__this.PhoneList);
		}
#pragma warning restore 0169

		IntPtr id_getPhoneList;
		public unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASPhone> PhoneList {
			get {
				if (id_getPhoneList == IntPtr.Zero)
					id_getPhoneList = JNIEnv.GetMethodID (class_ref, "getPhoneList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASPhone>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhoneList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPhotoList;
#pragma warning disable 0169
		static Delegate GetGetPhotoListHandler ()
		{
			if (cb_getPhotoList == null)
				cb_getPhotoList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhotoList);
			return cb_getPhotoList;
		}

		static IntPtr n_GetPhotoList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASPhoto>.ToLocalJniHandle (__this.PhotoList);
		}
#pragma warning restore 0169

		IntPtr id_getPhotoList;
		public unsafe global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASPhoto> PhotoList {
			get {
				if (id_getPhotoList == IntPtr.Zero)
					id_getPhotoList = JNIEnv.GetMethodID (class_ref, "getPhotoList", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASPhoto>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhotoList), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPreferredLanguage;
#pragma warning disable 0169
		static Delegate GetGetPreferredLanguageHandler ()
		{
			if (cb_getPreferredLanguage == null)
				cb_getPreferredLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreferredLanguage);
			return cb_getPreferredLanguage;
		}

		static IntPtr n_GetPreferredLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PreferredLanguage);
		}
#pragma warning restore 0169

		IntPtr id_getPreferredLanguage;
		public unsafe string PreferredLanguage {
			get {
				if (id_getPreferredLanguage == IntPtr.Zero)
					id_getPreferredLanguage = JNIEnv.GetMethodID (class_ref, "getPreferredLanguage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreferredLanguage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProfileUrl;
#pragma warning disable 0169
		static Delegate GetGetProfileUrlHandler ()
		{
			if (cb_getProfileUrl == null)
				cb_getProfileUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProfileUrl);
			return cb_getProfileUrl;
		}

		static IntPtr n_GetProfileUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfileUrl);
		}
#pragma warning restore 0169

		IntPtr id_getProfileUrl;
		public unsafe string ProfileUrl {
			get {
				if (id_getProfileUrl == IntPtr.Zero)
					id_getProfileUrl = JNIEnv.GetMethodID (class_ref, "getProfileUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProfileUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSource;
#pragma warning disable 0169
		static Delegate GetGetSourceHandler ()
		{
			if (cb_getSource == null)
				cb_getSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSource);
			return cb_getSource;
		}

		static IntPtr n_GetSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Source);
		}
#pragma warning restore 0169

		IntPtr id_getSource;
		public unsafe global::Org.Json.JSONObject Source {
			get {
				if (id_getSource == IntPtr.Zero)
					id_getSource = JNIEnv.GetMethodID (class_ref, "getSource", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSource), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTimeZone;
#pragma warning disable 0169
		static Delegate GetGetTimeZoneHandler ()
		{
			if (cb_getTimeZone == null)
				cb_getTimeZone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeZone);
			return cb_getTimeZone;
		}

		static IntPtr n_GetTimeZone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TimeZone);
		}
#pragma warning restore 0169

		IntPtr id_getTimeZone;
		public unsafe string TimeZone {
			get {
				if (id_getTimeZone == IntPtr.Zero)
					id_getTimeZone = JNIEnv.GetMethodID (class_ref, "getTimeZone", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeZone), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		IntPtr id_getTitle;
		public unsafe string Title {
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserName;
#pragma warning disable 0169
		static Delegate GetGetUserNameHandler ()
		{
			if (cb_getUserName == null)
				cb_getUserName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserName);
			return cb_getUserName;
		}

		static IntPtr n_GetUserName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserName);
		}
#pragma warning restore 0169

		IntPtr id_getUserName;
		public unsafe string UserName {
			get {
				if (id_getUserName == IntPtr.Zero)
					id_getUserName = JNIEnv.GetMethodID (class_ref, "getUserName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserType;
#pragma warning disable 0169
		static Delegate GetGetUserTypeHandler ()
		{
			if (cb_getUserType == null)
				cb_getUserType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserType);
			return cb_getUserType;
		}

		static IntPtr n_GetUserType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserType);
		}
#pragma warning restore 0169

		IntPtr id_getUserType;
		public unsafe string UserType {
			get {
				if (id_getUserType == IntPtr.Zero)
					id_getUserType = JNIEnv.GetMethodID (class_ref, "getUserType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserType), JniHandleOwnership.TransferLocalRef);
			}
		}

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
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJSONObject);
		}
#pragma warning restore 0169

		IntPtr id_getAsJSONObject;
		public unsafe global::Org.Json.JSONObject AsJSONObject {
			get {
				if (id_getAsJSONObject == IntPtr.Zero)
					id_getAsJSONObject = JNIEnv.GetMethodID (class_ref, "getAsJSONObject", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJSONObject), JniHandleOwnership.TransferLocalRef);
			}
		}

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
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Populate (p0);
		}
#pragma warning restore 0169

		IntPtr id_populate_Lorg_json_JSONObject_;
		public unsafe void Populate (global::Org.Json.JSONObject p0)
		{
			if (id_populate_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_populate_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "populate", "(Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_populate_Lorg_json_JSONObject_, __args);
		}

		static Delegate cb_getCardinality;
#pragma warning disable 0169
		static Delegate GetGetCardinalityHandler ()
		{
			if (cb_getCardinality == null)
				cb_getCardinality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCardinality);
			return cb_getCardinality;
		}

		static long n_GetCardinality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cardinality;
		}
#pragma warning restore 0169

		IntPtr id_getCardinality;
		public unsafe long Cardinality {
			get {
				if (id_getCardinality == IntPtr.Zero)
					id_getCardinality = JNIEnv.GetMethodID (class_ref, "getCardinality", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCardinality);
			}
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		IntPtr id_getDisplayName;
		public unsafe string DisplayName {
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getExternalId;
#pragma warning disable 0169
		static Delegate GetGetExternalIdHandler ()
		{
			if (cb_getExternalId == null)
				cb_getExternalId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExternalId);
			return cb_getExternalId;
		}

		static IntPtr n_GetExternalId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExternalId);
		}
#pragma warning restore 0169

		IntPtr id_getExternalId;
		public unsafe string ExternalId {
			get {
				if (id_getExternalId == IntPtr.Zero)
					id_getExternalId = JNIEnv.GetMethodID (class_ref, "getExternalId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExternalId), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Com.CA.Mas.Identity.User.IScimUser __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.IScimUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
