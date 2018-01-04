using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Messaging.Topic {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.messaging.topic']/interface[@name='MASTopic']"
	[Register ("com/ca/mas/messaging/topic/MASTopic", "", "Com.CA.Mas.Messaging.Topic.IMASTopicInvoker")]
	public partial interface IMASTopic : IJavaObject {

		int Qos {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging.topic']/interface[@name='MASTopic']/method[@name='getQos' and count(parameter)=0]"
			[Register ("getQos", "()I", "GetGetQosHandler:Com.CA.Mas.Messaging.Topic.IMASTopicInvoker, MASFoundation")] get;
		}

	}

	[global::Android.Runtime.Register ("com/ca/mas/messaging/topic/MASTopic", DoNotGenerateAcw=true)]
	internal class IMASTopicInvoker : global::Java.Lang.Object, IMASTopic {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/messaging/topic/MASTopic");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASTopicInvoker); }
		}

		IntPtr class_ref;

		public static IMASTopic GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASTopic> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.messaging.topic.MASTopic"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASTopicInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getQos;
#pragma warning disable 0169
		static Delegate GetGetQosHandler ()
		{
			if (cb_getQos == null)
				cb_getQos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetQos);
			return cb_getQos;
		}

		static int n_GetQos (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.CA.Mas.Messaging.Topic.IMASTopic __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.Topic.IMASTopic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qos;
		}
#pragma warning restore 0169

		IntPtr id_getQos;
		public unsafe int Qos {
			get {
				if (id_getQos == IntPtr.Zero)
					id_getQos = JNIEnv.GetMethodID (class_ref, "getQos", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getQos);
			}
		}

	}

}
