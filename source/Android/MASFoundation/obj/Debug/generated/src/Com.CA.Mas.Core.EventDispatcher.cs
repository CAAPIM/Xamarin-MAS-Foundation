using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core']/class[@name='EventDispatcher']"
	[global::Android.Runtime.Register ("com/ca/mas/core/EventDispatcher", DoNotGenerateAcw=true)]
	public partial class EventDispatcher : global::Java.Util.Observable {


		static IntPtr AFTER_DEREGISTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/class[@name='EventDispatcher']/field[@name='AFTER_DEREGISTER']"
		[Register ("AFTER_DEREGISTER")]
		public static global::Com.CA.Mas.Core.EventDispatcher AfterDeregister {
			get {
				if (AFTER_DEREGISTER_jfieldId == IntPtr.Zero)
					AFTER_DEREGISTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AFTER_DEREGISTER", "Lcom/ca/mas/core/EventDispatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AFTER_DEREGISTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.EventDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AFTER_GATEWAY_SWITCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/class[@name='EventDispatcher']/field[@name='AFTER_GATEWAY_SWITCH']"
		[Register ("AFTER_GATEWAY_SWITCH")]
		public static global::Com.CA.Mas.Core.EventDispatcher AfterGatewaySwitch {
			get {
				if (AFTER_GATEWAY_SWITCH_jfieldId == IntPtr.Zero)
					AFTER_GATEWAY_SWITCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AFTER_GATEWAY_SWITCH", "Lcom/ca/mas/core/EventDispatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AFTER_GATEWAY_SWITCH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.EventDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BEFORE_DEREGISTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/class[@name='EventDispatcher']/field[@name='BEFORE_DEREGISTER']"
		[Register ("BEFORE_DEREGISTER")]
		public static global::Com.CA.Mas.Core.EventDispatcher BeforeDeregister {
			get {
				if (BEFORE_DEREGISTER_jfieldId == IntPtr.Zero)
					BEFORE_DEREGISTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BEFORE_DEREGISTER", "Lcom/ca/mas/core/EventDispatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BEFORE_DEREGISTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.EventDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BEFORE_GATEWAY_SWITCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/class[@name='EventDispatcher']/field[@name='BEFORE_GATEWAY_SWITCH']"
		[Register ("BEFORE_GATEWAY_SWITCH")]
		public static global::Com.CA.Mas.Core.EventDispatcher BeforeGatewaySwitch {
			get {
				if (BEFORE_GATEWAY_SWITCH_jfieldId == IntPtr.Zero)
					BEFORE_GATEWAY_SWITCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BEFORE_GATEWAY_SWITCH", "Lcom/ca/mas/core/EventDispatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BEFORE_GATEWAY_SWITCH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.EventDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOGOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/class[@name='EventDispatcher']/field[@name='LOGOUT']"
		[Register ("LOGOUT")]
		public static global::Com.CA.Mas.Core.EventDispatcher Logout {
			get {
				if (LOGOUT_jfieldId == IntPtr.Zero)
					LOGOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOGOUT", "Lcom/ca/mas/core/EventDispatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOGOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.EventDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RESET_LOCALLY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/class[@name='EventDispatcher']/field[@name='RESET_LOCALLY']"
		[Register ("RESET_LOCALLY")]
		public static global::Com.CA.Mas.Core.EventDispatcher ResetLocally {
			get {
				if (RESET_LOCALLY_jfieldId == IntPtr.Zero)
					RESET_LOCALLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESET_LOCALLY", "Lcom/ca/mas/core/EventDispatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESET_LOCALLY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.EventDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STARTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/class[@name='EventDispatcher']/field[@name='STARTED']"
		[Register ("STARTED")]
		public static global::Com.CA.Mas.Core.EventDispatcher Started {
			get {
				if (STARTED_jfieldId == IntPtr.Zero)
					STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTED", "Lcom/ca/mas/core/EventDispatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STARTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.EventDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STOP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.core']/class[@name='EventDispatcher']/field[@name='STOP']"
		[Register ("STOP")]
		public static global::Com.CA.Mas.Core.EventDispatcher Stop {
			get {
				if (STOP_jfieldId == IntPtr.Zero)
					STOP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOP", "Lcom/ca/mas/core/EventDispatcher;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.EventDispatcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/EventDispatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventDispatcher); }
		}

		protected EventDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ca.mas.core']/class[@name='EventDispatcher']/constructor[@name='EventDispatcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventDispatcher ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EventDispatcher)) {
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
