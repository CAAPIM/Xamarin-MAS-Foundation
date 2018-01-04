using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Oauth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClientUtil']"
	[global::Android.Runtime.Register ("com/ca/mas/core/oauth/OAuthClientUtil", DoNotGenerateAcw=true)]
	public partial class OAuthClientUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/oauth/OAuthClientUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthClientUtil); }
		}

		protected OAuthClientUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_generateCodeChallenge;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.oauth']/class[@name='OAuthClientUtil']/method[@name='generateCodeChallenge' and count(parameter)=0]"
		[Register ("generateCodeChallenge", "()Lcom/ca/mas/core/oauth/PKCE;", "")]
		public static unsafe global::Com.CA.Mas.Core.Oauth.PKCE GenerateCodeChallenge ()
		{
			if (id_generateCodeChallenge == IntPtr.Zero)
				id_generateCodeChallenge = JNIEnv.GetStaticMethodID (class_ref, "generateCodeChallenge", "()Lcom/ca/mas/core/oauth/PKCE;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Oauth.PKCE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateCodeChallenge), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
