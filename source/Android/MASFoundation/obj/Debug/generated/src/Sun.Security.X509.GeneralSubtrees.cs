using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.X509 {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']"
	[global::Android.Runtime.Register ("sun/security/x509/GeneralSubtrees", DoNotGenerateAcw=true)]
	public partial class GeneralSubtrees : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/x509/GeneralSubtrees", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneralSubtrees); }
		}

		protected GeneralSubtrees (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/constructor[@name='GeneralSubtrees' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeneralSubtrees ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GeneralSubtrees)) {
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

		static Delegate cb_add_Lsun_security_x509_GeneralSubtree_;
#pragma warning disable 0169
		static Delegate GetAdd_Lsun_security_x509_GeneralSubtree_Handler ()
		{
			if (cb_add_Lsun_security_x509_GeneralSubtree_ == null)
				cb_add_Lsun_security_x509_GeneralSubtree_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lsun_security_x509_GeneralSubtree_);
			return cb_add_Lsun_security_x509_GeneralSubtree_;
		}

		static void n_Add_Lsun_security_x509_GeneralSubtree_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tree)
		{
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.GeneralSubtree tree = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtree> (native_tree, JniHandleOwnership.DoNotTransfer);
			__this.Add (tree);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lsun_security_x509_GeneralSubtree_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='add' and count(parameter)=1 and parameter[1][@type='sun.security.x509.GeneralSubtree']]"
		[Register ("add", "(Lsun/security/x509/GeneralSubtree;)V", "GetAdd_Lsun_security_x509_GeneralSubtree_Handler")]
		public virtual unsafe void Add (global::Sun.Security.X509.GeneralSubtree tree)
		{
			if (id_add_Lsun_security_x509_GeneralSubtree_ == IntPtr.Zero)
				id_add_Lsun_security_x509_GeneralSubtree_ = JNIEnv.GetMethodID (class_ref, "add", "(Lsun/security/x509/GeneralSubtree;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (tree);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lsun_security_x509_GeneralSubtree_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lsun/security/x509/GeneralSubtree;)V"), __args);
			} finally {
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
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='clone' and count(parameter)=0]"
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

		static Delegate cb_contains_Lsun_security_x509_GeneralSubtree_;
#pragma warning disable 0169
		static Delegate GetContains_Lsun_security_x509_GeneralSubtree_Handler ()
		{
			if (cb_contains_Lsun_security_x509_GeneralSubtree_ == null)
				cb_contains_Lsun_security_x509_GeneralSubtree_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lsun_security_x509_GeneralSubtree_);
			return cb_contains_Lsun_security_x509_GeneralSubtree_;
		}

		static bool n_Contains_Lsun_security_x509_GeneralSubtree_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tree)
		{
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.GeneralSubtree tree = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtree> (native_tree, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (tree);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Lsun_security_x509_GeneralSubtree_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='sun.security.x509.GeneralSubtree']]"
		[Register ("contains", "(Lsun/security/x509/GeneralSubtree;)Z", "GetContains_Lsun_security_x509_GeneralSubtree_Handler")]
		public virtual unsafe bool Contains (global::Sun.Security.X509.GeneralSubtree tree)
		{
			if (id_contains_Lsun_security_x509_GeneralSubtree_ == IntPtr.Zero)
				id_contains_Lsun_security_x509_GeneralSubtree_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lsun/security/x509/GeneralSubtree;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (tree);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lsun_security_x509_GeneralSubtree_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Lsun/security/x509/GeneralSubtree;)Z"), __args);
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
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.Util.DerOutputStream @out = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerOutputStream> (native__out, JniHandleOwnership.DoNotTransfer);
			__this.Encode (@out);
		}
#pragma warning restore 0169

		static IntPtr id_encode_Lsun_security_util_DerOutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='sun.security.util.DerOutputStream']]"
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
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (index));
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lsun/security/x509/GeneralSubtree;", "GetGet_IHandler")]
		public virtual unsafe global::Sun.Security.X509.GeneralSubtree Get (int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lsun/security/x509/GeneralSubtree;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtree> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtree> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)Lsun/security/x509/GeneralSubtree;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_intersect_Lsun_security_x509_GeneralSubtrees_;
#pragma warning disable 0169
		static Delegate GetIntersect_Lsun_security_x509_GeneralSubtrees_Handler ()
		{
			if (cb_intersect_Lsun_security_x509_GeneralSubtrees_ == null)
				cb_intersect_Lsun_security_x509_GeneralSubtrees_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Intersect_Lsun_security_x509_GeneralSubtrees_);
			return cb_intersect_Lsun_security_x509_GeneralSubtrees_;
		}

		static IntPtr n_Intersect_Lsun_security_x509_GeneralSubtrees_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.GeneralSubtrees other = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Intersect (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_intersect_Lsun_security_x509_GeneralSubtrees_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='intersect' and count(parameter)=1 and parameter[1][@type='sun.security.x509.GeneralSubtrees']]"
		[Register ("intersect", "(Lsun/security/x509/GeneralSubtrees;)Lsun/security/x509/GeneralSubtrees;", "GetIntersect_Lsun_security_x509_GeneralSubtrees_Handler")]
		public virtual unsafe global::Sun.Security.X509.GeneralSubtrees Intersect (global::Sun.Security.X509.GeneralSubtrees other)
		{
			if (id_intersect_Lsun_security_x509_GeneralSubtrees_ == IntPtr.Zero)
				id_intersect_Lsun_security_x509_GeneralSubtrees_ = JNIEnv.GetMethodID (class_ref, "intersect", "(Lsun/security/x509/GeneralSubtrees;)Lsun/security/x509/GeneralSubtrees;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Sun.Security.X509.GeneralSubtrees __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_intersect_Lsun_security_x509_GeneralSubtrees_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "intersect", "(Lsun/security/x509/GeneralSubtrees;)Lsun/security/x509/GeneralSubtrees;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='iterator' and count(parameter)=0]"
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

		static Delegate cb_reduce_Lsun_security_x509_GeneralSubtrees_;
#pragma warning disable 0169
		static Delegate GetReduce_Lsun_security_x509_GeneralSubtrees_Handler ()
		{
			if (cb_reduce_Lsun_security_x509_GeneralSubtrees_ == null)
				cb_reduce_Lsun_security_x509_GeneralSubtrees_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Reduce_Lsun_security_x509_GeneralSubtrees_);
			return cb_reduce_Lsun_security_x509_GeneralSubtrees_;
		}

		static void n_Reduce_Lsun_security_x509_GeneralSubtrees_ (IntPtr jnienv, IntPtr native__this, IntPtr native_excluded)
		{
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.GeneralSubtrees excluded = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (native_excluded, JniHandleOwnership.DoNotTransfer);
			__this.Reduce (excluded);
		}
#pragma warning restore 0169

		static IntPtr id_reduce_Lsun_security_x509_GeneralSubtrees_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='reduce' and count(parameter)=1 and parameter[1][@type='sun.security.x509.GeneralSubtrees']]"
		[Register ("reduce", "(Lsun/security/x509/GeneralSubtrees;)V", "GetReduce_Lsun_security_x509_GeneralSubtrees_Handler")]
		public virtual unsafe void Reduce (global::Sun.Security.X509.GeneralSubtrees excluded)
		{
			if (id_reduce_Lsun_security_x509_GeneralSubtrees_ == IntPtr.Zero)
				id_reduce_Lsun_security_x509_GeneralSubtrees_ = JNIEnv.GetMethodID (class_ref, "reduce", "(Lsun/security/x509/GeneralSubtrees;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (excluded);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reduce_Lsun_security_x509_GeneralSubtrees_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reduce", "(Lsun/security/x509/GeneralSubtrees;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Remove_I);
			return cb_remove_I;
		}

		static void n_Remove_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove (index);
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)V", "GetRemove_IHandler")]
		public virtual unsafe void Remove (int index)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(I)V"), __args);
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
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='size' and count(parameter)=0]"
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

		static Delegate cb_trees;
#pragma warning disable 0169
		static Delegate GetTreesHandler ()
		{
			if (cb_trees == null)
				cb_trees = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Trees);
			return cb_trees;
		}

		static IntPtr n_Trees (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Sun.Security.X509.GeneralSubtree>.ToLocalJniHandle (__this.Trees ());
		}
#pragma warning restore 0169

		static IntPtr id_trees;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='trees' and count(parameter)=0]"
		[Register ("trees", "()Ljava/util/List;", "GetTreesHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Sun.Security.X509.GeneralSubtree> Trees ()
		{
			if (id_trees == IntPtr.Zero)
				id_trees = JNIEnv.GetMethodID (class_ref, "trees", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Sun.Security.X509.GeneralSubtree>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trees), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Sun.Security.X509.GeneralSubtree>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trees", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_union_Lsun_security_x509_GeneralSubtrees_;
#pragma warning disable 0169
		static Delegate GetUnion_Lsun_security_x509_GeneralSubtrees_Handler ()
		{
			if (cb_union_Lsun_security_x509_GeneralSubtrees_ == null)
				cb_union_Lsun_security_x509_GeneralSubtrees_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Union_Lsun_security_x509_GeneralSubtrees_);
			return cb_union_Lsun_security_x509_GeneralSubtrees_;
		}

		static void n_Union_Lsun_security_x509_GeneralSubtrees_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Sun.Security.X509.GeneralSubtrees __this = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Security.X509.GeneralSubtrees other = global::Java.Lang.Object.GetObject<global::Sun.Security.X509.GeneralSubtrees> (native_other, JniHandleOwnership.DoNotTransfer);
			__this.Union (other);
		}
#pragma warning restore 0169

		static IntPtr id_union_Lsun_security_x509_GeneralSubtrees_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.x509']/class[@name='GeneralSubtrees']/method[@name='union' and count(parameter)=1 and parameter[1][@type='sun.security.x509.GeneralSubtrees']]"
		[Register ("union", "(Lsun/security/x509/GeneralSubtrees;)V", "GetUnion_Lsun_security_x509_GeneralSubtrees_Handler")]
		public virtual unsafe void Union (global::Sun.Security.X509.GeneralSubtrees other)
		{
			if (id_union_Lsun_security_x509_GeneralSubtrees_ == IntPtr.Zero)
				id_union_Lsun_security_x509_GeneralSubtrees_ = JNIEnv.GetMethodID (class_ref, "union", "(Lsun/security/x509/GeneralSubtrees;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_union_Lsun_security_x509_GeneralSubtrees_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "union", "(Lsun/security/x509/GeneralSubtrees;)V"), __args);
			} finally {
			}
		}

	}
}
