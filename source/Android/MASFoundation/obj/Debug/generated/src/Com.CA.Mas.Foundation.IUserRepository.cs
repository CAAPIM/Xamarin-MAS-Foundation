using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='UserRepository']"
	[Register ("com/ca/mas/foundation/UserRepository", "", "Com.CA.Mas.Foundation.IUserRepositoryInvoker")]
	public partial interface IUserRepository : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.foundation']/interface[@name='UserRepository']/method[@name='getCurrentUser' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;com.ca.mas.foundation.MASUser&gt;']]"
		[Register ("getCurrentUser", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetGetCurrentUser_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Foundation.IUserRepositoryInvoker, MASFoundation")]
		void GetCurrentUser (global::Com.CA.Mas.Foundation.MASCallback p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/foundation/UserRepository", DoNotGenerateAcw=true)]
	internal class IUserRepositoryInvoker : global::Java.Lang.Object, IUserRepository {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/foundation/UserRepository");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUserRepositoryInvoker); }
		}

		IntPtr class_ref;

		public static IUserRepository GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUserRepository> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.foundation.UserRepository"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUserRepositoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCurrentUser_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetGetCurrentUser_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_getCurrentUser_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_getCurrentUser_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetCurrentUser_Lcom_ca_mas_foundation_MASCallback_);
			return cb_getCurrentUser_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_GetCurrentUser_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Foundation.IUserRepository __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.IUserRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetCurrentUser (p0);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentUser_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void GetCurrentUser (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_getCurrentUser_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_getCurrentUser_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "getCurrentUser", "(Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentUser_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

	}

}
