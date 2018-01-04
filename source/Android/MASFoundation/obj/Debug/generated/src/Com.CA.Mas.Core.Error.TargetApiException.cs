using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Error {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.error']/class[@name='TargetApiException']"
	[global::Android.Runtime.Register ("com/ca/mas/core/error/TargetApiException", DoNotGenerateAcw=true)]
	public partial class TargetApiException : global::Java.Lang.Exception {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/error/TargetApiException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TargetApiException); }
		}

		protected TargetApiException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
