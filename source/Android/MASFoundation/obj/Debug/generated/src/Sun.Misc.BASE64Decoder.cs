using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Misc {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.misc']/class[@name='BASE64Decoder']"
	[global::Android.Runtime.Register ("sun/misc/BASE64Decoder", DoNotGenerateAcw=true)]
	public partial class BASE64Decoder : global::Sun.Misc.CharacterDecoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/misc/BASE64Decoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BASE64Decoder); }
		}

		protected BASE64Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.misc']/class[@name='BASE64Decoder']/constructor[@name='BASE64Decoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BASE64Decoder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BASE64Decoder)) {
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

		static Delegate cb_bytesPerAtom;
#pragma warning disable 0169
		static Delegate GetBytesPerAtomHandler ()
		{
			if (cb_bytesPerAtom == null)
				cb_bytesPerAtom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BytesPerAtom);
			return cb_bytesPerAtom;
		}

		static int n_BytesPerAtom (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Misc.BASE64Decoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.BASE64Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesPerAtom ();
		}
#pragma warning restore 0169

		static IntPtr id_bytesPerAtom;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='BASE64Decoder']/method[@name='bytesPerAtom' and count(parameter)=0]"
		[Register ("bytesPerAtom", "()I", "GetBytesPerAtomHandler")]
		protected override unsafe int BytesPerAtom ()
		{
			if (id_bytesPerAtom == IntPtr.Zero)
				id_bytesPerAtom = JNIEnv.GetMethodID (class_ref, "bytesPerAtom", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_bytesPerAtom);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bytesPerAtom", "()I"));
			} finally {
			}
		}

		static Delegate cb_bytesPerLine;
#pragma warning disable 0169
		static Delegate GetBytesPerLineHandler ()
		{
			if (cb_bytesPerLine == null)
				cb_bytesPerLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BytesPerLine);
			return cb_bytesPerLine;
		}

		static int n_BytesPerLine (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Misc.BASE64Decoder __this = global::Java.Lang.Object.GetObject<global::Sun.Misc.BASE64Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BytesPerLine ();
		}
#pragma warning restore 0169

		static IntPtr id_bytesPerLine;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.misc']/class[@name='BASE64Decoder']/method[@name='bytesPerLine' and count(parameter)=0]"
		[Register ("bytesPerLine", "()I", "GetBytesPerLineHandler")]
		protected override unsafe int BytesPerLine ()
		{
			if (id_bytesPerLine == IntPtr.Zero)
				id_bytesPerLine = JNIEnv.GetMethodID (class_ref, "bytesPerLine", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_bytesPerLine);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bytesPerLine", "()I"));
			} finally {
			}
		}

	}
}
