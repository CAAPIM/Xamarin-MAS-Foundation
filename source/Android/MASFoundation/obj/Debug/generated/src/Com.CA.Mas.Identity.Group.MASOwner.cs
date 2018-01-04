using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.Group {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASOwner']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/group/MASOwner", DoNotGenerateAcw=true)]
	public partial class MASOwner : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/group/MASOwner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASOwner); }
		}

		protected MASOwner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_foundation_MASUser_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASOwner']/constructor[@name='MASOwner' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASUser']]"
		[Register (".ctor", "(Lcom/ca/mas/foundation/MASUser;)V", "")]
		public unsafe MASOwner (global::Com.CA.Mas.Foundation.MASUser user)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (user);
				if (((object) this).GetType () != typeof (MASOwner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/ca/mas/foundation/MASUser;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/ca/mas/foundation/MASUser;)V", __args);
					return;
				}

				if (id_ctor_Lcom_ca_mas_foundation_MASUser_ == IntPtr.Zero)
					id_ctor_Lcom_ca_mas_foundation_MASUser_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/ca/mas/foundation/MASUser;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_ca_mas_foundation_MASUser_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_ca_mas_foundation_MASUser_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASOwner']/constructor[@name='MASOwner' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MASOwner (string value, string @ref, string display)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.NewString (value);
			IntPtr native__ref = JNIEnv.NewString (@ref);
			IntPtr native_display = JNIEnv.NewString (display);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_value);
				__args [1] = new JValue (native__ref);
				__args [2] = new JValue (native_display);
				if (((object) this).GetType () != typeof (MASOwner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				JNIEnv.DeleteLocalRef (native__ref);
				JNIEnv.DeleteLocalRef (native_display);
			}
		}

		static Delegate cb_getDisplay;
#pragma warning disable 0169
		static Delegate GetGetDisplayHandler ()
		{
			if (cb_getDisplay == null)
				cb_getDisplay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplay);
			return cb_getDisplay;
		}

		static IntPtr n_GetDisplay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Group.MASOwner __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASOwner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Display);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplay;
		public virtual unsafe string Display {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASOwner']/method[@name='getDisplay' and count(parameter)=0]"
			[Register ("getDisplay", "()Ljava/lang/String;", "GetGetDisplayHandler")]
			get {
				if (id_getDisplay == IntPtr.Zero)
					id_getDisplay = JNIEnv.GetMethodID (class_ref, "getDisplay", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplay), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplay", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRef;
#pragma warning disable 0169
		static Delegate GetGetRefHandler ()
		{
			if (cb_getRef == null)
				cb_getRef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRef);
			return cb_getRef;
		}

		static IntPtr n_GetRef (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Group.MASOwner __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASOwner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ref);
		}
#pragma warning restore 0169

		static IntPtr id_getRef;
		public virtual unsafe string Ref {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASOwner']/method[@name='getRef' and count(parameter)=0]"
			[Register ("getRef", "()Ljava/lang/String;", "GetGetRefHandler")]
			get {
				if (id_getRef == IntPtr.Zero)
					id_getRef = JNIEnv.GetMethodID (class_ref, "getRef", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRef), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRef", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			global::Com.CA.Mas.Identity.Group.MASOwner __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASOwner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASOwner']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
