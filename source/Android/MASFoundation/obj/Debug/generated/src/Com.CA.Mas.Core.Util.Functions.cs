using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ca.mas.core.util']/class[@name='Functions']"
	[global::Android.Runtime.Register ("com/ca/mas/core/util/Functions", DoNotGenerateAcw=true)]
	public partial class Functions : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.Binary']"
		[Register ("com/ca/mas/core/util/Functions$Binary", "", "Com.CA.Mas.Core.Util.Functions/IBinaryInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R", "A", "B"})]
		public partial interface IBinary : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.Binary']/method[@name='call' and count(parameter)=2 and parameter[1][@type='A'] and parameter[2][@type='B']]"
			[Register ("call", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetCall_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.CA.Mas.Core.Util.Functions/IBinaryInvoker, MASFoundation")]
			global::Java.Lang.Object Call (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

		}

		[global::Android.Runtime.Register ("com/ca/mas/core/util/Functions$Binary", DoNotGenerateAcw=true)]
		internal class IBinaryInvoker : global::Java.Lang.Object, IBinary {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/util/Functions$Binary");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IBinaryInvoker); }
			}

			IntPtr class_ref;

			public static IBinary GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBinary> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.util.Functions.Binary"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBinaryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCall_Ljava_lang_Object_Ljava_lang_Object_Handler ()
			{
				if (cb_call_Ljava_lang_Object_Ljava_lang_Object_ == null)
					cb_call_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_Object_Ljava_lang_Object_);
				return cb_call_Ljava_lang_Object_Ljava_lang_Object_;
			}

			static IntPtr n_Call_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.CA.Mas.Core.Util.Functions.IBinary __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Util.Functions.IBinary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_call_Ljava_lang_Object_Ljava_lang_Object_;
			public unsafe global::Java.Lang.Object Call (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				if (id_call_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_call_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "call", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.BinaryVoid']"
		[Register ("com/ca/mas/core/util/Functions$BinaryVoid", "", "Com.CA.Mas.Core.Util.Functions/IBinaryVoidInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"A", "B"})]
		public partial interface IBinaryVoid : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.BinaryVoid']/method[@name='call' and count(parameter)=2 and parameter[1][@type='A'] and parameter[2][@type='B']]"
			[Register ("call", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetCall_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.CA.Mas.Core.Util.Functions/IBinaryVoidInvoker, MASFoundation")]
			void Call (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

		}

		[global::Android.Runtime.Register ("com/ca/mas/core/util/Functions$BinaryVoid", DoNotGenerateAcw=true)]
		internal class IBinaryVoidInvoker : global::Java.Lang.Object, IBinaryVoid {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/util/Functions$BinaryVoid");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IBinaryVoidInvoker); }
			}

			IntPtr class_ref;

			public static IBinaryVoid GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBinaryVoid> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.util.Functions.BinaryVoid"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBinaryVoidInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCall_Ljava_lang_Object_Ljava_lang_Object_Handler ()
			{
				if (cb_call_Ljava_lang_Object_Ljava_lang_Object_ == null)
					cb_call_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_Object_Ljava_lang_Object_);
				return cb_call_Ljava_lang_Object_Ljava_lang_Object_;
			}

			static void n_Call_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.CA.Mas.Core.Util.Functions.IBinaryVoid __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Util.Functions.IBinaryVoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Call (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_call_Ljava_lang_Object_Ljava_lang_Object_;
			public unsafe void Call (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				if (id_call_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_call_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "call", "(Ljava/lang/Object;Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_call_Ljava_lang_Object_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.Nullary']"
		[Register ("com/ca/mas/core/util/Functions$Nullary", "", "Com.CA.Mas.Core.Util.Functions/INullaryInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public partial interface INullary : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.Nullary']/method[@name='call' and count(parameter)=0]"
			[Register ("call", "()Ljava/lang/Object;", "GetCallHandler:Com.CA.Mas.Core.Util.Functions/INullaryInvoker, MASFoundation")]
			global::Java.Lang.Object Call ();

		}

		[global::Android.Runtime.Register ("com/ca/mas/core/util/Functions$Nullary", DoNotGenerateAcw=true)]
		internal class INullaryInvoker : global::Java.Lang.Object, INullary {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/util/Functions$Nullary");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INullaryInvoker); }
			}

			IntPtr class_ref;

			public static INullary GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INullary> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.util.Functions.Nullary"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INullaryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call;
#pragma warning disable 0169
			static Delegate GetCallHandler ()
			{
				if (cb_call == null)
					cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
				return cb_call;
			}

			static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Core.Util.Functions.INullary __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Util.Functions.INullary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Call ());
			}
#pragma warning restore 0169

			IntPtr id_call;
			public unsafe global::Java.Lang.Object Call ()
			{
				if (id_call == IntPtr.Zero)
					id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.NullaryVoid']"
		[Register ("com/ca/mas/core/util/Functions$NullaryVoid", "", "Com.CA.Mas.Core.Util.Functions/INullaryVoidInvoker")]
		public partial interface INullaryVoid : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.NullaryVoid']/method[@name='call' and count(parameter)=0]"
			[Register ("call", "()V", "GetCallHandler:Com.CA.Mas.Core.Util.Functions/INullaryVoidInvoker, MASFoundation")]
			void Call ();

		}

		[global::Android.Runtime.Register ("com/ca/mas/core/util/Functions$NullaryVoid", DoNotGenerateAcw=true)]
		internal class INullaryVoidInvoker : global::Java.Lang.Object, INullaryVoid {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/util/Functions$NullaryVoid");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INullaryVoidInvoker); }
			}

			IntPtr class_ref;

			public static INullaryVoid GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INullaryVoid> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.util.Functions.NullaryVoid"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INullaryVoidInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call;
#pragma warning disable 0169
			static Delegate GetCallHandler ()
			{
				if (cb_call == null)
					cb_call = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Call);
				return cb_call;
			}

			static void n_Call (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.CA.Mas.Core.Util.Functions.INullaryVoid __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Util.Functions.INullaryVoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Call ();
			}
#pragma warning restore 0169

			IntPtr id_call;
			public unsafe void Call ()
			{
				if (id_call == IntPtr.Zero)
					id_call = JNIEnv.GetMethodID (class_ref, "call", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_call);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.Unary']"
		[Register ("com/ca/mas/core/util/Functions$Unary", "", "Com.CA.Mas.Core.Util.Functions/IUnaryInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R", "A"})]
		public partial interface IUnary : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.Unary']/method[@name='call' and count(parameter)=1 and parameter[1][@type='A']]"
			[Register ("call", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetCall_Ljava_lang_Object_Handler:Com.CA.Mas.Core.Util.Functions/IUnaryInvoker, MASFoundation")]
			global::Java.Lang.Object Call (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/ca/mas/core/util/Functions$Unary", DoNotGenerateAcw=true)]
		internal class IUnaryInvoker : global::Java.Lang.Object, IUnary {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/util/Functions$Unary");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IUnaryInvoker); }
			}

			IntPtr class_ref;

			public static IUnary GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUnary> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.util.Functions.Unary"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUnaryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCall_Ljava_lang_Object_Handler ()
			{
				if (cb_call_Ljava_lang_Object_ == null)
					cb_call_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_Object_);
				return cb_call_Ljava_lang_Object_;
			}

			static IntPtr n_Call_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.CA.Mas.Core.Util.Functions.IUnary __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Util.Functions.IUnary> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_call_Ljava_lang_Object_;
			public unsafe global::Java.Lang.Object Call (global::Java.Lang.Object p0)
			{
				if (id_call_Ljava_lang_Object_ == IntPtr.Zero)
					id_call_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "call", "(Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.UnaryVoid']"
		[Register ("com/ca/mas/core/util/Functions$UnaryVoid", "", "Com.CA.Mas.Core.Util.Functions/IUnaryVoidInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"A"})]
		public partial interface IUnaryVoid : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ca.mas.core.util']/interface[@name='Functions.UnaryVoid']/method[@name='call' and count(parameter)=1 and parameter[1][@type='A']]"
			[Register ("call", "(Ljava/lang/Object;)V", "GetCall_Ljava_lang_Object_Handler:Com.CA.Mas.Core.Util.Functions/IUnaryVoidInvoker, MASFoundation")]
			void Call (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/ca/mas/core/util/Functions$UnaryVoid", DoNotGenerateAcw=true)]
		internal class IUnaryVoidInvoker : global::Java.Lang.Object, IUnaryVoid {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/ca/mas/core/util/Functions$UnaryVoid");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IUnaryVoidInvoker); }
			}

			IntPtr class_ref;

			public static IUnaryVoid GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUnaryVoid> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.ca.mas.core.util.Functions.UnaryVoid"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUnaryVoidInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCall_Ljava_lang_Object_Handler ()
			{
				if (cb_call_Ljava_lang_Object_ == null)
					cb_call_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_Object_);
				return cb_call_Ljava_lang_Object_;
			}

			static void n_Call_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.CA.Mas.Core.Util.Functions.IUnaryVoid __this = global::Java.Lang.Object.GetObject<global::Com.CA.Mas.Core.Util.Functions.IUnaryVoid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Call (p0);
			}
#pragma warning restore 0169

			IntPtr id_call_Ljava_lang_Object_;
			public unsafe void Call (global::Java.Lang.Object p0)
			{
				if (id_call_Ljava_lang_Object_ == IntPtr.Zero)
					id_call_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "call", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_call_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ca/mas/core/util/Functions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Functions); }
		}

		protected Functions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
