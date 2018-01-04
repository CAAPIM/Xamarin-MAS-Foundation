using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity']/class[@name='ScimIdentifiable.ResourceType']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/ScimIdentifiable$ResourceType", DoNotGenerateAcw=true)]
	public sealed partial class ScimIdentifiableResourceType : global::Java.Lang.Enum {


		static IntPtr Application_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity']/class[@name='ScimIdentifiable.ResourceType']/field[@name='Application']"
		[Register ("Application")]
		public static global::Com.CA.Mas.Identity.ScimIdentifiableResourceType Application {
			get {
				if (Application_jfieldId == IntPtr.Zero)
					Application_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Application", "Lcom/ca/mas/identity/ScimIdentifiable$ResourceType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Application_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.ScimIdentifiableResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Device_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity']/class[@name='ScimIdentifiable.ResourceType']/field[@name='Device']"
		[Register ("Device")]
		public static global::Com.CA.Mas.Identity.ScimIdentifiableResourceType Device {
			get {
				if (Device_jfieldId == IntPtr.Zero)
					Device_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Device", "Lcom/ca/mas/identity/ScimIdentifiable$ResourceType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Device_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.ScimIdentifiableResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr None_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity']/class[@name='ScimIdentifiable.ResourceType']/field[@name='None']"
		[Register ("None")]
		public static global::Com.CA.Mas.Identity.ScimIdentifiableResourceType None {
			get {
				if (None_jfieldId == IntPtr.Zero)
					None_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "None", "Lcom/ca/mas/identity/ScimIdentifiable$ResourceType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, None_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.ScimIdentifiableResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr User_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity']/class[@name='ScimIdentifiable.ResourceType']/field[@name='User']"
		[Register ("User")]
		public static global::Com.CA.Mas.Identity.ScimIdentifiableResourceType User {
			get {
				if (User_jfieldId == IntPtr.Zero)
					User_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "User", "Lcom/ca/mas/identity/ScimIdentifiable$ResourceType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, User_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.ScimIdentifiableResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/ScimIdentifiable$ResourceType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScimIdentifiableResourceType); }
		}

		internal ScimIdentifiableResourceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity']/class[@name='ScimIdentifiable.ResourceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/ca/mas/identity/ScimIdentifiable$ResourceType;", "")]
		public static unsafe global::Com.CA.Mas.Identity.ScimIdentifiableResourceType ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/ca/mas/identity/ScimIdentifiable$ResourceType;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.CA.Mas.Identity.ScimIdentifiableResourceType __ret = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.ScimIdentifiableResourceType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity']/class[@name='ScimIdentifiable.ResourceType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/ca/mas/identity/ScimIdentifiable$ResourceType;", "")]
		public static unsafe global::Com.CA.Mas.Identity.ScimIdentifiableResourceType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/ca/mas/identity/ScimIdentifiable$ResourceType;");
			try {
				return (global::Com.CA.Mas.Identity.ScimIdentifiableResourceType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.CA.Mas.Identity.ScimIdentifiableResourceType));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.identity']/interface[@name='ScimIdentifiable']"
	[Register ("com/ca/mas/identity/ScimIdentifiable", "", "Com.CA.Mas.Identity.IScimIdentifiableInvoker")]
	public partial interface IScimIdentifiable : IJavaObject {

		long Cardinality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity']/interface[@name='ScimIdentifiable']/method[@name='getCardinality' and count(parameter)=0]"
			[Register ("getCardinality", "()J", "GetGetCardinalityHandler:Com.CA.Mas.Identity.IScimIdentifiableInvoker, MASFoundation")] get;
		}

		string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity']/interface[@name='ScimIdentifiable']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler:Com.CA.Mas.Identity.IScimIdentifiableInvoker, MASFoundation")] get;
		}

		string ExternalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity']/interface[@name='ScimIdentifiable']/method[@name='getExternalId' and count(parameter)=0]"
			[Register ("getExternalId", "()Ljava/lang/String;", "GetGetExternalIdHandler:Com.CA.Mas.Identity.IScimIdentifiableInvoker, MASFoundation")] get;
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity']/interface[@name='ScimIdentifiable']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.CA.Mas.Identity.IScimIdentifiableInvoker, MASFoundation")] get;
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/identity/ScimIdentifiable", DoNotGenerateAcw=true)]
	internal class IScimIdentifiableInvoker : global::Java.Lang.Object, IScimIdentifiable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/identity/ScimIdentifiable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IScimIdentifiableInvoker); }
		}

		IntPtr class_ref;

		public static IScimIdentifiable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScimIdentifiable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.identity.ScimIdentifiable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScimIdentifiableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.CA.Mas.Identity.IScimIdentifiable __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.IScimIdentifiable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.CA.Mas.Identity.IScimIdentifiable __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.IScimIdentifiable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.CA.Mas.Identity.IScimIdentifiable __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.IScimIdentifiable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.CA.Mas.Identity.IScimIdentifiable __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.IScimIdentifiable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
