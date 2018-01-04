using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConstants']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/MASConstants", DoNotGenerateAcw=true)]
	public partial class MASConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConstants']/field[@name='MAS_APPLICATION']"
		[Register ("MAS_APPLICATION")]
		public const int MasApplication = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConstants']/field[@name='MAS_GRANT_FLOW_CLIENT_CREDENTIALS']"
		[Register ("MAS_GRANT_FLOW_CLIENT_CREDENTIALS")]
		public const int MasGrantFlowClientCredentials = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConstants']/field[@name='MAS_GRANT_FLOW_PASSWORD']"
		[Register ("MAS_GRANT_FLOW_PASSWORD")]
		public const int MasGrantFlowPassword = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConstants']/field[@name='MAS_STATE_NOT_CONFIGURED']"
		[Register ("MAS_STATE_NOT_CONFIGURED")]
		public const int MasStateNotConfigured = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConstants']/field[@name='MAS_STATE_NOT_INITIALIZED']"
		[Register ("MAS_STATE_NOT_INITIALIZED")]
		public const int MasStateNotInitialized = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConstants']/field[@name='MAS_STATE_STARTED']"
		[Register ("MAS_STATE_STARTED")]
		public const int MasStateStarted = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConstants']/field[@name='MAS_STATE_STOPPED']"
		[Register ("MAS_STATE_STOPPED")]
		public const int MasStateStopped = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='MASConstants']/field[@name='MAS_USER']"
		[Register ("MAS_USER")]
		public const int MasUser = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/MASConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MASConstants); }
		}

		protected MASConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
