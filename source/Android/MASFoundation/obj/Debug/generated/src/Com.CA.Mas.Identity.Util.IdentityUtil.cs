using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity.util']/class[@name='IdentityUtil']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/util/IdentityUtil", DoNotGenerateAcw=true)]
	public partial class IdentityUtil : global::Java.Lang.Object {


		static IntPtr SCHEMA_MAP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.util']/class[@name='IdentityUtil']/field[@name='SCHEMA_MAP']"
		[Register ("SCHEMA_MAP")]
		public static global::System.Collections.IDictionary SchemaMap {
			get {
				if (SCHEMA_MAP_jfieldId == IntPtr.Zero)
					SCHEMA_MAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCHEMA_MAP", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCHEMA_MAP_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/util/IdentityUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IdentityUtil); }
		}

		protected IdentityUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.util']/class[@name='IdentityUtil']/constructor[@name='IdentityUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IdentityUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IdentityUtil)) {
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

		static IntPtr id_getGroupPath;
		public static unsafe string GroupPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.util']/class[@name='IdentityUtil']/method[@name='getGroupPath' and count(parameter)=0]"
			[Register ("getGroupPath", "()Ljava/lang/String;", "GetGetGroupPathHandler")]
			get {
				if (id_getGroupPath == IntPtr.Zero)
					id_getGroupPath = JNIEnv.GetStaticMethodID (class_ref, "getGroupPath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGroupPath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSchemasPath;
		public static unsafe string SchemasPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.util']/class[@name='IdentityUtil']/method[@name='getSchemasPath' and count(parameter)=0]"
			[Register ("getSchemasPath", "()Ljava/lang/String;", "GetGetSchemasPathHandler")]
			get {
				if (id_getSchemasPath == IntPtr.Zero)
					id_getSchemasPath = JNIEnv.GetStaticMethodID (class_ref, "getSchemasPath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSchemasPath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUserPath;
		public static unsafe string UserPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.util']/class[@name='IdentityUtil']/method[@name='getUserPath' and count(parameter)=0]"
			[Register ("getUserPath", "()Ljava/lang/String;", "GetGetUserPathHandler")]
			get {
				if (id_getUserPath == IntPtr.Zero)
					id_getUserPath = JNIEnv.GetStaticMethodID (class_ref, "getUserPath", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserPath), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPhoto_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.util']/class[@name='IdentityUtil']/method[@name='getPhoto' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.ca.mas.identity.user.MASPhoto&gt;']]"
		[Register ("getPhoto", "(Ljava/util/List;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetPhoto (global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASPhoto> photoList)
		{
			if (id_getPhoto_Ljava_util_List_ == IntPtr.Zero)
				id_getPhoto_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "getPhoto", "(Ljava/util/List;)Landroid/graphics/Bitmap;");
			IntPtr native_photoList = global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASPhoto>.ToLocalJniHandle (photoList);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_photoList);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPhoto_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_photoList);
			}
		}

		static IntPtr id_getThumbnail_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.util']/class[@name='IdentityUtil']/method[@name='getThumbnail' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.ca.mas.identity.user.MASPhoto&gt;']]"
		[Register ("getThumbnail", "(Ljava/util/List;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetThumbnail (global::System.Collections.Generic.IList<global::Com.CA.Mas.Identity.User.MASPhoto> photoList)
		{
			if (id_getThumbnail_Ljava_util_List_ == IntPtr.Zero)
				id_getThumbnail_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "getThumbnail", "(Ljava/util/List;)Landroid/graphics/Bitmap;");
			IntPtr native_photoList = global::Android.Runtime.JavaList<global::Com.CA.Mas.Identity.User.MASPhoto>.ToLocalJniHandle (photoList);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_photoList);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getThumbnail_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_photoList);
			}
		}

		static IntPtr id_normalizeAttributes_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.util']/class[@name='IdentityUtil']/method[@name='normalizeAttributes' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("normalizeAttributes", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> NormalizeAttributes (global::System.Collections.Generic.IList<string> providedAttributes, global::System.Collections.Generic.IList<string> allowedAttributes)
		{
			if (id_normalizeAttributes_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_normalizeAttributes_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "normalizeAttributes", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;");
			IntPtr native_providedAttributes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (providedAttributes);
			IntPtr native_allowedAttributes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (allowedAttributes);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_providedAttributes);
				__args [1] = new JValue (native_allowedAttributes);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_normalizeAttributes_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_providedAttributes);
				JNIEnv.DeleteLocalRef (native_allowedAttributes);
			}
		}

	}
}
