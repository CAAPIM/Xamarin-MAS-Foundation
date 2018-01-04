using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Messaging {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASMessenger']"
	[Register ("com/ca/mas/messaging/MASMessenger", "", "Com.CA.Mas.Messaging.IMASMessengerInvoker")]
	public partial interface IMASMessenger : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASMessenger']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASGroup'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASGroup;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Messaging.IMASMessengerInvoker, MASFoundation")]
		void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASGroup p1, global::Com.CA.Mas.Foundation.MASCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASMessenger']/method[@name='sendMessage' and count(parameter)=4 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASGroup'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASGroup;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Messaging.IMASMessengerInvoker, MASFoundation")]
		void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASGroup p1, string p2, global::Com.CA.Mas.Foundation.MASCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASMessenger']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASUser'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASUser;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Messaging.IMASMessengerInvoker, MASFoundation")]
		void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASUser p1, global::Com.CA.Mas.Foundation.MASCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASMessenger']/method[@name='sendMessage' and count(parameter)=4 and parameter[1][@type='com.ca.mas.messaging.MASMessage'] and parameter[2][@type='com.ca.mas.foundation.MASUser'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASUser;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Messaging.IMASMessengerInvoker, MASFoundation")]
		void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASUser p1, string p2, global::Com.CA.Mas.Foundation.MASCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASMessenger']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.ca.mas.messaging.topic.MASTopic'] and parameter[2][@type='com.ca.mas.messaging.MASMessage'] and parameter[3][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("sendMessage", "(Lcom/ca/mas/messaging/topic/MASTopic;Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASCallback;)V", "GetSendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Messaging.IMASMessengerInvoker, MASFoundation")]
		void SendMessage (global::Com.CA.Mas.Messaging.Topic.IMASTopic p0, global::Com.CA.Mas.Messaging.MASMessage p1, global::Com.CA.Mas.Foundation.MASCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASMessenger']/method[@name='startListeningToMyMessages' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("startListeningToMyMessages", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetStartListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Messaging.IMASMessengerInvoker, MASFoundation")]
		void StartListeningToMyMessages (global::Com.CA.Mas.Foundation.MASCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.messaging']/interface[@name='MASMessenger']/method[@name='stopListeningToMyMessages' and count(parameter)=1 and parameter[1][@type='com.ca.mas.foundation.MASCallback&lt;java.lang.Void&gt;']]"
		[Register ("stopListeningToMyMessages", "(Lcom/ca/mas/foundation/MASCallback;)V", "GetStopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_Handler:Com.CA.Mas.Messaging.IMASMessengerInvoker, MASFoundation")]
		void StopListeningToMyMessages (global::Com.CA.Mas.Foundation.MASCallback p0);

	}

	[global::Android.Runtime.Register ("com/ca/mas/messaging/MASMessenger", DoNotGenerateAcw=true)]
	internal class IMASMessengerInvoker : global::Java.Lang.Object, IMASMessenger {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/messaging/MASMessenger");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMASMessengerInvoker); }
		}

		IntPtr class_ref;

		public static IMASMessenger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMASMessenger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.messaging.MASMessenger"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMASMessengerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_);
			return cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Messaging.IMASMessenger __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.MASMessage p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASGroup p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p2 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASGroup p1, global::Com.CA.Mas.Foundation.MASCallback p2)
		{
			if (id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASGroup;Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

		static Delegate cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_);
			return cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.CA.Mas.Messaging.IMASMessenger __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.MASMessage p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASGroup p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p3 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASGroup p1, string p2, global::Com.CA.Mas.Foundation.MASCallback p3)
		{
			if (id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASGroup;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASGroup_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_);
			return cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Messaging.IMASMessenger __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.MASMessage p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASUser p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p2 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASUser p1, global::Com.CA.Mas.Foundation.MASCallback p2)
		{
			if (id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASUser;Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

		static Delegate cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_);
			return cb_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_SendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.CA.Mas.Messaging.IMASMessenger __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.MASMessage p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASUser p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASUser> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p3 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void SendMessage (global::Com.CA.Mas.Messaging.MASMessage p0, global::Com.CA.Mas.Foundation.MASUser p1, string p2, global::Com.CA.Mas.Foundation.MASCallback p3)
		{
			if (id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASUser;Ljava/lang/String;Lcom/ca/mas/foundation/MASCallback;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASUser_Ljava_lang_String_Lcom_ca_mas_foundation_MASCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_);
			return cb_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_SendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.CA.Mas.Messaging.IMASMessenger __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.Topic.IMASTopic p0 = (global::Com.CA.Mas.Messaging.Topic.IMASTopic)global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.Topic.IMASTopic> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Messaging.MASMessage p1 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.MASMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p2 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void SendMessage (global::Com.CA.Mas.Messaging.Topic.IMASTopic p0, global::Com.CA.Mas.Messaging.MASMessage p1, global::Com.CA.Mas.Foundation.MASCallback p2)
		{
			if (id_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/ca/mas/messaging/topic/MASTopic;Lcom/ca/mas/messaging/MASMessage;Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_ca_mas_messaging_topic_MASTopic_Lcom_ca_mas_messaging_MASMessage_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

		static Delegate cb_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetStartListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_);
			return cb_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_StartListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Messaging.IMASMessenger __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartListeningToMyMessages (p0);
		}
#pragma warning restore 0169

		IntPtr id_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void StartListeningToMyMessages (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "startListeningToMyMessages", "(Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

		static Delegate cb_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
#pragma warning disable 0169
		static Delegate GetStopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_Handler ()
		{
			if (cb_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ == null)
				cb_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_);
			return cb_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
		}

		static void n_StopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.CA.Mas.Messaging.IMASMessenger __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Messaging.IMASMessenger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.CA.Mas.Foundation.MASCallback p0 = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Foundation.MASCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopListeningToMyMessages (p0);
		}
#pragma warning restore 0169

		IntPtr id_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_;
		public unsafe void StopListeningToMyMessages (global::Com.CA.Mas.Foundation.MASCallback p0)
		{
			if (id_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ == IntPtr.Zero)
				id_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_ = JNIEnv.GetMethodID (class_ref, "stopListeningToMyMessages", "(Lcom/ca/mas/foundation/MASCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopListeningToMyMessages_Lcom_ca_mas_foundation_MASCallback_, __args);
		}

	}

}
