using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']"
	[global::Android.Runtime.Register ("sun/security/util/Cache", DoNotGenerateAcw=true)]
	public abstract partial class Cache : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.util']/class[@name='Cache.EqualByteArray']"
		[global::Android.Runtime.Register ("sun/security/util/Cache$EqualByteArray", DoNotGenerateAcw=true)]
		public partial class EqualByteArray : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("sun/security/util/Cache$EqualByteArray", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EqualByteArray); }
			}

			protected EqualByteArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_arrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='Cache.EqualByteArray']/constructor[@name='Cache.EqualByteArray' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register (".ctor", "([B)V", "")]
			public unsafe EqualByteArray (byte[] b)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_b = JNIEnv.NewArray (b);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_b);
					if (((object) this).GetType () != typeof (EqualByteArray)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
						return;
					}

					if (id_ctor_arrayB == IntPtr.Zero)
						id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
				} finally {
					if (b != null) {
						JNIEnv.CopyArray (native_b, b);
						JNIEnv.DeleteLocalRef (native_b);
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/util/Cache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Cache); }
		}

		protected Cache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/constructor[@name='Cache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Cache ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Cache)) {
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

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.Cache __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public abstract void Clear ();

		static Delegate cb_get_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_Handler ()
		{
			if (cb_get_Ljava_lang_Object_ == null)
				cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_Object_);
			return cb_get_Ljava_lang_Object_;
		}

		static IntPtr n_Get_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Security.Util.Cache __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public abstract global::Java.Lang.Object Get (global::Java.Lang.Object p0);

		static IntPtr id_newHardMemoryCache_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='newHardMemoryCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("newHardMemoryCache", "(I)Lsun/security/util/Cache;", "")]
		public static unsafe global::Sun.Security.Util.Cache NewHardMemoryCache (int size)
		{
			if (id_newHardMemoryCache_I == IntPtr.Zero)
				id_newHardMemoryCache_I = JNIEnv.GetStaticMethodID (class_ref, "newHardMemoryCache", "(I)Lsun/security/util/Cache;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (size);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Cache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newHardMemoryCache_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newHardMemoryCache_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='newHardMemoryCache' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("newHardMemoryCache", "(II)Lsun/security/util/Cache;", "")]
		public static unsafe global::Sun.Security.Util.Cache NewHardMemoryCache (int size, int timeout)
		{
			if (id_newHardMemoryCache_II == IntPtr.Zero)
				id_newHardMemoryCache_II = JNIEnv.GetStaticMethodID (class_ref, "newHardMemoryCache", "(II)Lsun/security/util/Cache;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (size);
				__args [1] = new JValue (timeout);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Cache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newHardMemoryCache_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newNullCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='newNullCache' and count(parameter)=0]"
		[Register ("newNullCache", "()Lsun/security/util/Cache;", "")]
		public static unsafe global::Sun.Security.Util.Cache NewNullCache ()
		{
			if (id_newNullCache == IntPtr.Zero)
				id_newNullCache = JNIEnv.GetStaticMethodID (class_ref, "newNullCache", "()Lsun/security/util/Cache;");
			try {
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Cache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newNullCache), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newSoftMemoryCache_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='newSoftMemoryCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("newSoftMemoryCache", "(I)Lsun/security/util/Cache;", "")]
		public static unsafe global::Sun.Security.Util.Cache NewSoftMemoryCache (int size)
		{
			if (id_newSoftMemoryCache_I == IntPtr.Zero)
				id_newSoftMemoryCache_I = JNIEnv.GetStaticMethodID (class_ref, "newSoftMemoryCache", "(I)Lsun/security/util/Cache;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (size);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Cache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newSoftMemoryCache_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newSoftMemoryCache_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='newSoftMemoryCache' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("newSoftMemoryCache", "(II)Lsun/security/util/Cache;", "")]
		public static unsafe global::Sun.Security.Util.Cache NewSoftMemoryCache (int size, int timeout)
		{
			if (id_newSoftMemoryCache_II == IntPtr.Zero)
				id_newSoftMemoryCache_II = JNIEnv.GetStaticMethodID (class_ref, "newSoftMemoryCache", "(II)Lsun/security/util/Cache;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (size);
				__args [1] = new JValue (timeout);
				return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Cache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newSoftMemoryCache_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_put_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_put_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_put_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_put_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Put_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Sun.Security.Util.Cache __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public abstract void Put (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static void n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Security.Util.Cache __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("remove", "(Ljava/lang/Object;)V", "GetRemove_Ljava_lang_Object_Handler")]
		public abstract void Remove (global::Java.Lang.Object p0);

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
			global::Sun.Security.Util.Cache __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.Cache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public abstract int Size ();

	}

	[global::Android.Runtime.Register ("sun/security/util/Cache", DoNotGenerateAcw=true)]
	internal partial class CacheInvoker : Cache {

		public CacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CacheInvoker); }
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public override unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_get_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("get", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGet_Ljava_lang_Object_Handler")]
		public override unsafe global::Java.Lang.Object Get (global::Java.Lang.Object p0)
		{
			if (id_get_Ljava_lang_Object_ == IntPtr.Zero)
				id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_put_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("put", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetPut_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public override unsafe void Put (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_put_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_put_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_Object_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_remove_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("remove", "(Ljava/lang/Object;)V", "GetRemove_Ljava_lang_Object_Handler")]
		public override unsafe void Remove (global::Java.Lang.Object p0)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='Cache']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
			} finally {
			}
		}

	}

}
