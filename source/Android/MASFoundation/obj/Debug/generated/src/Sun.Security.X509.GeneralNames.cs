using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralNames']"
	[global::Android.Runtime.Register ("sun/security/x509/GeneralNames", DoNotGenerateAcw=true)]
	public partial class GeneralNames : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/GeneralNames", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneralNames); }
		}

		protected GeneralNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralNames']/constructor[@name='GeneralNames' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeneralNames ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GeneralNames)) {
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

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.GeneralNames __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralNames']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_add_Lsun_security_x509_GeneralName_;
#pragma warning disable 0169
		static Delegate GetAdd_Lsun_security_x509_GeneralName_Handler ()
		{
			if (cb_add_Lsun_security_x509_GeneralName_ == null)
				cb_add_Lsun_security_x509_GeneralName_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Lsun_security_x509_GeneralName_);
			return cb_add_Lsun_security_x509_GeneralName_;
		}

		static IntPtr n_Add_Lsun_security_x509_GeneralName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Sun.Security.X509.GeneralNames __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.GeneralName name = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralName> (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (name));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Lsun_security_x509_GeneralName_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralNames']/method[@name='add' and count(parameter)=1 and parameter[1][@type='sun.security.x509.GeneralName']]"
		[Register ("add", "(Lsun/security/x509/GeneralName;)Lsun/security/x509/GeneralNames;", "GetAdd_Lsun_security_x509_GeneralName_Handler")]
		public virtual unsafe global::Sun.Security.X509.GeneralNames Add (global::Sun.Security.X509.GeneralName name)
		{
			if (id_add_Lsun_security_x509_GeneralName_ == IntPtr.Zero)
				id_add_Lsun_security_x509_GeneralName_ = JNIEnv.GetMethodID (class_ref, "add", "(Lsun/security/x509/GeneralName;)Lsun/security/x509/GeneralNames;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (name);

				global::Sun.Security.X509.GeneralNames __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_add_Lsun_security_x509_GeneralName_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lsun/security/x509/GeneralName;)Lsun/security/x509/GeneralNames;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_encode_Lsun_security_util_DerOutputStream_;
#pragma warning disable 0169
		static Delegate GetEncode_Lsun_security_util_DerOutputStream_Handler ()
		{
			if (cb_encode_Lsun_security_util_DerOutputStream_ == null)
				cb_encode_Lsun_security_util_DerOutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Encode_Lsun_security_util_DerOutputStream_);
			return cb_encode_Lsun_security_util_DerOutputStream_;
		}

		static void n_Encode_Lsun_security_util_DerOutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Sun.Security.X509.GeneralNames __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralNames']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
		[Register ("encode", "(Lsun/security/util/DerOutputStream;)V", "GetEncode_Lsun_security_util_DerOutputStream_Handler")]
		public virtual unsafe void Encode (global::Sun.Security.Util.DerOutputStream @out)
		{
			if (id_encode_Lsun_security_util_DerOutputStream_ == IntPtr.Zero)
				id_encode_Lsun_security_util_DerOutputStream_ = JNIEnv.GetMethodID (class_ref, "encode", "(Lsun/security/util/DerOutputStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encode_Lsun_security_util_DerOutputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Lsun/security/util/DerOutputStream;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Sun.Security.X509.GeneralNames __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralNames']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lsun/security/x509/GeneralName;", "GetGet_IHandler")]
		public virtual unsafe global::Sun.Security.X509.GeneralName Get (int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lsun/security/x509/GeneralName;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralName> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralName> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)Lsun/security/x509/GeneralName;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.GeneralNames __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralNames']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iterator", "()Ljava/util/Iterator;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_names;
#pragma warning disable 0169
		static Delegate GetNamesHandler ()
		{
			if (cb_names == null)
				cb_names = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Names);
			return cb_names;
		}

		static IntPtr n_Names (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.GeneralNames __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Sun.Security.X509.GeneralName>.ToLocalJniHandle (__this.Names ());
		}
#pragma warning restore 0169

		static IntPtr id_names;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralNames']/method[@name='names' and count(parameter)=0]"
		[Register ("names", "()Ljava/util/List;", "GetNamesHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Sun.Security.X509.GeneralName> Names ()
		{
			if (id_names == IntPtr.Zero)
				id_names = JNIEnv.GetMethodID (class_ref, "names", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Sun.Security.X509.GeneralName>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_names), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Sun.Security.X509.GeneralName>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "names", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.GeneralNames __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralNames> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralNames']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

	}
}
