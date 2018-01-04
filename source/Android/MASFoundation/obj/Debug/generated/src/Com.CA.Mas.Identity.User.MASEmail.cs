using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASEmail']"
	[global::Android.Runtime.Register ("com/ca/mas/identity/user/MASEmail", DoNotGenerateAcw=true)]
	public partial class MASEmail : global::Com.CA.Mas.Identity.User.IdentityBase {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/identity/user/MASEmail", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASEmail); }
		}

		protected MASEmail (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASEmail']/constructor[@name='MASEmail' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASEmail ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASEmail)) {
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

		static Delegate cb_isPrimary;
#pragma warning disable 0169
		static Delegate GetIsPrimaryHandler ()
		{
			if (cb_isPrimary == null)
				cb_isPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPrimary);
			return cb_isPrimary;
		}

		static bool n_IsPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Identity.User.MASEmail __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Identity.User.MASEmail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrimary;
		}
#pragma warning restore 0169

		static IntPtr id_isPrimary;
		public virtual unsafe bool IsPrimary {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.identity.user']/class[@name='MASEmail']/method[@name='isPrimary' and count(parameter)=0]"
			[Register ("isPrimary", "()Z", "GetIsPrimaryHandler")]
			get {
				if (id_isPrimary == IntPtr.Zero)
					id_isPrimary = JNIEnv.GetMethodID (class_ref, "isPrimary", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPrimary);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPrimary", "()Z"));
				} finally {
				}
			}
		}

	}
}
