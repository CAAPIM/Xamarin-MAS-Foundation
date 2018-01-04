using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.Group {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/group/MASMember", DoNotGenerateAcw=true)]
	public partial class MASMember : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/group/MASMember", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASMember); }
		}

		protected MASMember (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_ca_mas_foundation_MASUser_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']/constructor[@name='MASMember' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASUser']]"
		[Register (".ctor", "(Lcom/ca/mas/foundation/MASUser;)V", "")]
		public unsafe MASMember (global::Com.CA.Mas.Foundation.MASUser user)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (user);
				if (((object) this).GetType () != typeof (MASMember)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']/constructor[@name='MASMember' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MASMember (string type, string value, string @ref, string display)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_type = JNIEnv.NewString (type);
			IntPtr native_value = JNIEnv.NewString (value);
			IntPtr native__ref = JNIEnv.NewString (@ref);
			IntPtr native_display = JNIEnv.NewString (display);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_type);
				__args [1] = new JValue (native_value);
				__args [2] = new JValue (native__ref);
				__args [3] = new JValue (native_display);
				if (((object) this).GetType () != typeof (MASMember)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
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
			global::Com.CA.Mas.Identity.Group.MASMember __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Display);
		}
#pragma warning restore 0169

		static Delegate cb_setDisplay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDisplay_Ljava_lang_String_Handler ()
		{
			if (cb_setDisplay_Ljava_lang_String_ == null)
				cb_setDisplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisplay_Ljava_lang_String_);
			return cb_setDisplay_Ljava_lang_String_;
		}

		static void n_SetDisplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_display)
		{
			global::Com.CA.Mas.Identity.Group.MASMember __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string display = JNIEnv.GetString (native_display, JniHandleOwnership.DoNotTransfer);
			__this.Display = display;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplay;
		static IntPtr id_setDisplay_Ljava_lang_String_;
		public virtual unsafe string Display {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']/method[@name='getDisplay' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']/method[@name='setDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDisplay", "(Ljava/lang/String;)V", "GetSetDisplay_Ljava_lang_String_Handler")]
			set {
				if (id_setDisplay_Ljava_lang_String_ == IntPtr.Zero)
					id_setDisplay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDisplay", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplay_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplay", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.CA.Mas.Identity.Group.MASMember __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ref);
		}
#pragma warning restore 0169

		static Delegate cb_setRef_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRef_Ljava_lang_String_Handler ()
		{
			if (cb_setRef_Ljava_lang_String_ == null)
				cb_setRef_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRef_Ljava_lang_String_);
			return cb_setRef_Ljava_lang_String_;
		}

		static void n_SetRef_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__ref)
		{
			global::Com.CA.Mas.Identity.Group.MASMember __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @ref = JNIEnv.GetString (native__ref, JniHandleOwnership.DoNotTransfer);
			__this.Ref = @ref;
		}
#pragma warning restore 0169

		static IntPtr id_getRef;
		static IntPtr id_setRef_Ljava_lang_String_;
		public virtual unsafe string Ref {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']/method[@name='getRef' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']/method[@name='setRef' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRef", "(Ljava/lang/String;)V", "GetSetRef_Ljava_lang_String_Handler")]
			set {
				if (id_setRef_Ljava_lang_String_ == IntPtr.Zero)
					id_setRef_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRef", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRef_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRef", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.Group.MASMember __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.CA.Mas.Identity.Group.MASMember __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
			__this.Type = type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_String_;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
					id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.CA.Mas.Identity.Group.MASMember __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static Delegate cb_setValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue_Ljava_lang_String_Handler ()
		{
			if (cb_setValue_Ljava_lang_String_ == null)
				cb_setValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue_Ljava_lang_String_);
			return cb_setValue_Ljava_lang_String_;
		}

		static void n_SetValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.CA.Mas.Identity.Group.MASMember __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.Group.MASMember> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Value = value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		static IntPtr id_setValue_Ljava_lang_String_;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']/method[@name='getValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.group']/class[@name='MASMember']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue", "(Ljava/lang/String;)V", "GetSetValue_Ljava_lang_String_Handler")]
			set {
				if (id_setValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
