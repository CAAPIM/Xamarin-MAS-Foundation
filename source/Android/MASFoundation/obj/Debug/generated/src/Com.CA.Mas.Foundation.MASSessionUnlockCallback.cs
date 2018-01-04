using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSessionUnlockCallback']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASSessionUnlockCallback", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class MASSessionUnlockCallback : global::Com.CA.Mas.Foundation.MASCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASSessionUnlockCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASSessionUnlockCallback); }
		}

		protected MASSessionUnlockCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSessionUnlockCallback']/constructor[@name='MASSessionUnlockCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MASSessionUnlockCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MASSessionUnlockCallback)) {
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

		static Delegate cb_onUserAuthenticationRequired;
#pragma warning disable 0169
		static Delegate GetOnUserAuthenticationRequiredHandler ()
		{
			if (cb_onUserAuthenticationRequired == null)
				cb_onUserAuthenticationRequired = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUserAuthenticationRequired);
			return cb_onUserAuthenticationRequired;
		}

		static void n_OnUserAuthenticationRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Foundation.MASSessionUnlockCallback __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASSessionUnlockCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUserAuthenticationRequired ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSessionUnlockCallback']/method[@name='onUserAuthenticationRequired' and count(parameter)=0]"
		[Register ("onUserAuthenticationRequired", "()V", "GetOnUserAuthenticationRequiredHandler")]
		public abstract void OnUserAuthenticationRequired ();

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASSessionUnlockCallback", DoNotGenerateAcw=true)]
	internal partial class MASSessionUnlockCallbackInvoker : MASSessionUnlockCallback {

		public MASSessionUnlockCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASSessionUnlockCallbackInvoker); }
		}

		static IntPtr id_onUserAuthenticationRequired;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASSessionUnlockCallback']/method[@name='onUserAuthenticationRequired' and count(parameter)=0]"
		[Register ("onUserAuthenticationRequired", "()V", "GetOnUserAuthenticationRequiredHandler")]
		public override unsafe void OnUserAuthenticationRequired ()
		{
			if (id_onUserAuthenticationRequired == IntPtr.Zero)
				id_onUserAuthenticationRequired = JNIEnv.GetMethodID (class_ref, "onUserAuthenticationRequired", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserAuthenticationRequired);
			} finally {
			}
		}

		static IntPtr id_onError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler")]
		public override unsafe void OnError (global::Java.Lang.Throwable p0)
		{
			if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_onSuccess_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler")]
		public override unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
