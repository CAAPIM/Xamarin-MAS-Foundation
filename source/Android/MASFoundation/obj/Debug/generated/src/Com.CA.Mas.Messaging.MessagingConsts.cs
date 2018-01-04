using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MessagingConsts']"
	[global::Android.Runtime.Register ("com/ca/mas/messaging/MessagingConsts", DoNotGenerateAcw=true)]
	public partial class MessagingConsts : global::Com.CA.Mas.Foundation.FoundationConsts {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MessagingConsts']/field[@name='AT_LEAST_ONCE']"
		[Register ("AT_LEAST_ONCE")]
		public const int AtLeastOnce = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MessagingConsts']/field[@name='AT_MOST_ONCE']"
		[Register ("AT_MOST_ONCE")]
		public const int AtMostOnce = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MessagingConsts']/field[@name='DEFAULT_TEXT_PLAIN_CONTENT_TYPE']"
		[Register ("DEFAULT_TEXT_PLAIN_CONTENT_TYPE")]
		public const string DefaultTextPlainContentType = (string) "text/plain";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MessagingConsts']/field[@name='EXACTLY_ONCE']"
		[Register ("EXACTLY_ONCE")]
		public const int ExactlyOnce = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MessagingConsts']/field[@name='MAS_CONNECTA_BROADCAST_MESSAGE_ARRIVED']"
		[Register ("MAS_CONNECTA_BROADCAST_MESSAGE_ARRIVED")]
		public const string MasConnectaBroadcastMessageArrived = (string) "com.ca.mas.connecta.MESSAGE_ARRIVED";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/messaging/MessagingConsts", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingConsts); }
		}

		protected MessagingConsts (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.messaging']/class[@name='MessagingConsts']/constructor[@name='MessagingConsts' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessagingConsts ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessagingConsts)) {
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

	}
}
