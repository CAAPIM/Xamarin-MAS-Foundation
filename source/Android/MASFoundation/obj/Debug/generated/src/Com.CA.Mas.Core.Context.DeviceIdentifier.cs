using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Context {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='DeviceIdentifier']"
	[global::Android.Runtime.Register ("com/ca/mas/core/context/DeviceIdentifier", DoNotGenerateAcw=true)]
	public partial class DeviceIdentifier : global::Com.CA.Mas.Core.Context.UniqueIdentifier {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/context/DeviceIdentifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceIdentifier); }
		}

		protected DeviceIdentifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='DeviceIdentifier']/constructor[@name='DeviceIdentifier' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DeviceIdentifier (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (DeviceIdentifier)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getIdentifierKey;
#pragma warning disable 0169
		static Delegate GetGetIdentifierKeyHandler ()
		{
			if (cb_getIdentifierKey == null)
				cb_getIdentifierKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentifierKey);
			return cb_getIdentifierKey;
		}

		static IntPtr n_GetIdentifierKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Core.Context.DeviceIdentifier __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Context.DeviceIdentifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IdentifierKey);
		}
#pragma warning restore 0169

		static IntPtr id_getIdentifierKey;
		protected override unsafe string IdentifierKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.context']/class[@name='DeviceIdentifier']/method[@name='getIdentifierKey' and count(parameter)=0]"
			[Register ("getIdentifierKey", "()Ljava/lang/String;", "GetGetIdentifierKeyHandler")]
			get {
				if (id_getIdentifierKey == IntPtr.Zero)
					id_getIdentifierKey = JNIEnv.GetMethodID (class_ref, "getIdentifierKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifierKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentifierKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
