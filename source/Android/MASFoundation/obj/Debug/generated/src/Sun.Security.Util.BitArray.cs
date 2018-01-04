using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']"
	[global::Android.Runtime.Register ("sun/security/util/BitArray", DoNotGenerateAcw=true)]
	public partial class BitArray : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/util/BitArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitArray); }
		}

		protected BitArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']/constructor[@name='BitArray' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register (".ctor", "([Z)V", "")]
		public unsafe BitArray (bool[] bits)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bits = JNIEnv.NewArray (bits);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bits);
				if (((object) this).GetType () != typeof (BitArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Z)V", __args);
					return;
				}

				if (id_ctor_arrayZ == IntPtr.Zero)
					id_ctor_arrayZ = JNIEnv.GetMethodID (class_ref, "<init>", "([Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayZ, __args);
			} finally {
				if (bits != null) {
					JNIEnv.CopyArray (native_bits, bits);
					JNIEnv.DeleteLocalRef (native_bits);
				}
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']/constructor[@name='BitArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BitArray (int length)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (length);
				if (((object) this).GetType () != typeof (BitArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']/constructor[@name='BitArray' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(I[B)V", "")]
		public unsafe BitArray (int length, byte[] a)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_a = JNIEnv.NewArray (a);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (length);
				__args [1] = new JValue (native_a);
				if (((object) this).GetType () != typeof (BitArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I[B)V", __args);
					return;
				}

				if (id_ctor_IarrayB == IntPtr.Zero)
					id_ctor_IarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(I[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IarrayB, __args);
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.BitArray __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Ljava/lang/Object;", "GetCloneHandler")]
		public virtual unsafe global::Java.Lang.Object Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clone), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Get_I);
			return cb_get_I;
		}

		static bool n_Get_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Sun.Security.Util.BitArray __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get (index);
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Z", "GetGet_IHandler")]
		public virtual unsafe bool Get (int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Length);
			return cb_length;
		}

		static int n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.BitArray __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "GetLengthHandler")]
		public virtual unsafe int Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_length);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()I"));
			} finally {
			}
		}

		static Delegate cb_set_IZ;
#pragma warning disable 0169
		static Delegate GetSet_IZHandler ()
		{
			if (cb_set_IZ == null)
				cb_set_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_Set_IZ);
			return cb_set_IZ;
		}

		static void n_Set_IZ (IntPtr jnienv, IntPtr native__this, int index, bool value)
		{
			global::Sun.Security.Util.BitArray __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (index, value);
		}
#pragma warning restore 0169

		static IntPtr id_set_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("set", "(IZ)V", "GetSet_IZHandler")]
		public virtual unsafe void Set (int index, bool value)
		{
			if (id_set_IZ == IntPtr.Zero)
				id_set_IZ = JNIEnv.GetMethodID (class_ref, "set", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toBooleanArray;
#pragma warning disable 0169
		static Delegate GetToBooleanArrayHandler ()
		{
			if (cb_toBooleanArray == null)
				cb_toBooleanArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBooleanArray);
			return cb_toBooleanArray;
		}

		static IntPtr n_ToBooleanArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.BitArray __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToBooleanArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toBooleanArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']/method[@name='toBooleanArray' and count(parameter)=0]"
		[Register ("toBooleanArray", "()[Z", "GetToBooleanArrayHandler")]
		public virtual unsafe bool[] ToBooleanArray ()
		{
			if (id_toBooleanArray == IntPtr.Zero)
				id_toBooleanArray = JNIEnv.GetMethodID (class_ref, "toBooleanArray", "()[Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toBooleanArray), JniHandleOwnership.TransferLocalRef, typeof (bool));
				else
					return (bool[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toBooleanArray", "()[Z")), JniHandleOwnership.TransferLocalRef, typeof (bool));
			} finally {
			}
		}

		static Delegate cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.BitArray __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual unsafe byte[] ToByteArray ()
		{
			if (id_toByteArray == IntPtr.Zero)
				id_toByteArray = JNIEnv.GetMethodID (class_ref, "toByteArray", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByteArray", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_truncate;
#pragma warning disable 0169
		static Delegate GetTruncateHandler ()
		{
			if (cb_truncate == null)
				cb_truncate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Truncate);
			return cb_truncate;
		}

		static IntPtr n_Truncate (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.BitArray __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Truncate ());
		}
#pragma warning restore 0169

		static IntPtr id_truncate;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='BitArray']/method[@name='truncate' and count(parameter)=0]"
		[Register ("truncate", "()Lsun/security/util/BitArray;", "GetTruncateHandler")]
		public virtual unsafe global::Sun.Security.Util.BitArray Truncate ()
		{
			if (id_truncate == IntPtr.Zero)
				id_truncate = JNIEnv.GetMethodID (class_ref, "truncate", "()Lsun/security/util/BitArray;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_truncate), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "truncate", "()Lsun/security/util/BitArray;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
