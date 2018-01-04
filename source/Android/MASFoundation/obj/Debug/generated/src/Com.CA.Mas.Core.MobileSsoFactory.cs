using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core']/class[@name='MobileSsoFactory']"
	[global::Android.Runtime.Register ("com/ca/mas/core/MobileSsoFactory", DoNotGenerateAcw=true)]
	public sealed partial class MobileSsoFactory : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/MobileSsoFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobileSsoFactory); }
		}

		internal MobileSsoFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core']/class[@name='MobileSsoFactory']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public static unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetStaticMethodID (class_ref, "reset", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reset);
			} finally {
			}
		}

	}
}
