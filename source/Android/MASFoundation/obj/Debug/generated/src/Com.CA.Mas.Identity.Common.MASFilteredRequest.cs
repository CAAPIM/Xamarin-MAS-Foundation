using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='MASFilteredRequest']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/common/MASFilteredRequest", DoNotGenerateAcw=true)]
	public partial class MASFilteredRequest : global::Java.Lang.Object {


		static IntPtr mAttributes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='MASFilteredRequest']/field[@name='mAttributes']"
		[Register ("mAttributes")]
		protected global::System.Collections.IList MAttributes {
			get {
				if (mAttributes_jfieldId == IntPtr.Zero)
					mAttributes_jfieldId = JNIEnv.GetFieldID (class_ref, "mAttributes", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAttributes_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAttributes_jfieldId == IntPtr.Zero)
					mAttributes_jfieldId = JNIEnv.GetFieldID (class_ref, "mAttributes", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAttributes_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mExcludedAttributes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='MASFilteredRequest']/field[@name='mExcludedAttributes']"
		[Register ("mExcludedAttributes")]
		protected global::System.Collections.IList MExcludedAttributes {
			get {
				if (mExcludedAttributes_jfieldId == IntPtr.Zero)
					mExcludedAttributes_jfieldId = JNIEnv.GetFieldID (class_ref, "mExcludedAttributes", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mExcludedAttributes_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mExcludedAttributes_jfieldId == IntPtr.Zero)
					mExcludedAttributes_jfieldId = JNIEnv.GetFieldID (class_ref, "mExcludedAttributes", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mExcludedAttributes_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.ca.mas.identity.common.MASPagination

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/interface[@name='MASPagination']/field[@name='PAGE_INC_BY']"
			[Register ("PAGE_INC_BY")]
			public const string PageIncBy = (string) "&count=%s";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/interface[@name='MASPagination']/field[@name='PAGE_NO_PAGINATION']"
			[Register ("PAGE_NO_PAGINATION")]
			public const int PageNoPagination = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/interface[@name='MASPagination']/field[@name='PAGE_START']"
			[Register ("PAGE_START")]
			public const string PageStart = (string) "startIndex=%s";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/interface[@name='MASPagination']/field[@name='PAGE_START_EXP']"
			[Register ("PAGE_START_EXP")]
			public const string PageStartExp = (string) "startIndex=";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/interface[@name='MASPagination']/field[@name='PAGE_START_INDEX']"
			[Register ("PAGE_START_INDEX")]
			public const int PageStartIndex = (int) 1;
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/common/MASFilteredRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASFilteredRequest); }
		}

		protected MASFilteredRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='MASFilteredRequest']/constructor[@name='MASFilteredRequest' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe MASFilteredRequest (global::System.Collections.Generic.IList<string> entityAttributes, string filterType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_entityAttributes = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (entityAttributes);
			IntPtr native_filterType = JNIEnv.NewString (filterType);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_entityAttributes);
				__args [1] = new JValue (native_filterType);
				if (((object) this).GetType () != typeof (MASFilteredRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_entityAttributes);
				JNIEnv.DeleteLocalRef (native_filterType);
			}
		}

		static Delegate cb_createUri_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCreateUri_Landroid_content_Context_Handler ()
		{
			if (cb_createUri_Landroid_content_Context_ == null)
				cb_createUri_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateUri_Landroid_content_Context_);
			return cb_createUri_Landroid_content_Context_;
		}

		static IntPtr n_CreateUri_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.CA.Mas.Identity.Common.MASFilteredRequest __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Common.MASFilteredRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateUri (context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createUri_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.common']/class[@name='MASFilteredRequest']/method[@name='createUri' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("createUri", "(Landroid/content/Context;)Landroid/net/Uri;", "GetCreateUri_Landroid_content_Context_Handler")]
		public virtual unsafe global::Android.Net.Uri CreateUri (global::Android.Content.Context context)
		{
			if (id_createUri_Landroid_content_Context_ == IntPtr.Zero)
				id_createUri_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "createUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				global::Android.Net.Uri __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createUri_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createUri", "(Landroid/content/Context;)Landroid/net/Uri;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
