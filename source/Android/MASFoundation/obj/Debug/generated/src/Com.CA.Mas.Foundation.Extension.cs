using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Foundation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.foundation']/class[@name='Extension']"
	[global::Android.Runtime.Register ("com/ca/mas/foundation/Extension", DoNotGenerateAcw=true)]
	public partial class Extension : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/foundation/Extension", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Extension); }
		}

		protected Extension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
