using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Util.Calendar {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']"
	[global::Android.Runtime.Register ("sun/util/calendar/CalendarUtils", DoNotGenerateAcw=true)]
	public partial class CalendarUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/util/calendar/CalendarUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalendarUtils); }
		}

		protected CalendarUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/constructor[@name='CalendarUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CalendarUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CalendarUtils)) {
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

		static IntPtr id_amod_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='amod' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("amod", "(II)I", "")]
		public static unsafe int Amod (int x, int y)
		{
			if (id_amod_II == IntPtr.Zero)
				id_amod_II = JNIEnv.GetStaticMethodID (class_ref, "amod", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_amod_II, __args);
			} finally {
			}
		}

		static IntPtr id_amod_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='amod' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("amod", "(JJ)J", "")]
		public static unsafe long Amod (long x, long y)
		{
			if (id_amod_JJ == IntPtr.Zero)
				id_amod_JJ = JNIEnv.GetStaticMethodID (class_ref, "amod", "(JJ)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_amod_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_floorDivide_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='floorDivide' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("floorDivide", "(II)I", "")]
		public static unsafe int FloorDivide (int n, int d)
		{
			if (id_floorDivide_II == IntPtr.Zero)
				id_floorDivide_II = JNIEnv.GetStaticMethodID (class_ref, "floorDivide", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (n);
				__args [1] = new JValue (d);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_floorDivide_II, __args);
			} finally {
			}
		}

		static IntPtr id_floorDivide_IIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='floorDivide' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("floorDivide", "(II[I)I", "")]
		public static unsafe int FloorDivide (int n, int d, int[] r)
		{
			if (id_floorDivide_IIarrayI == IntPtr.Zero)
				id_floorDivide_IIarrayI = JNIEnv.GetStaticMethodID (class_ref, "floorDivide", "(II[I)I");
			IntPtr native_r = JNIEnv.NewArray (r);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (n);
				__args [1] = new JValue (d);
				__args [2] = new JValue (native_r);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_floorDivide_IIarrayI, __args);
				return __ret;
			} finally {
				if (r != null) {
					JNIEnv.CopyArray (native_r, r);
					JNIEnv.DeleteLocalRef (native_r);
				}
			}
		}

		static IntPtr id_floorDivide_JIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='floorDivide' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("floorDivide", "(JI[I)I", "")]
		public static unsafe int FloorDivide (long n, int d, int[] r)
		{
			if (id_floorDivide_JIarrayI == IntPtr.Zero)
				id_floorDivide_JIarrayI = JNIEnv.GetStaticMethodID (class_ref, "floorDivide", "(JI[I)I");
			IntPtr native_r = JNIEnv.NewArray (r);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (n);
				__args [1] = new JValue (d);
				__args [2] = new JValue (native_r);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_floorDivide_JIarrayI, __args);
				return __ret;
			} finally {
				if (r != null) {
					JNIEnv.CopyArray (native_r, r);
					JNIEnv.DeleteLocalRef (native_r);
				}
			}
		}

		static IntPtr id_floorDivide_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='floorDivide' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("floorDivide", "(JJ)J", "")]
		public static unsafe long FloorDivide (long n, long d)
		{
			if (id_floorDivide_JJ == IntPtr.Zero)
				id_floorDivide_JJ = JNIEnv.GetStaticMethodID (class_ref, "floorDivide", "(JJ)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (n);
				__args [1] = new JValue (d);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_floorDivide_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_isGregorianLeapYear_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='isGregorianLeapYear' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isGregorianLeapYear", "(I)Z", "")]
		public static unsafe bool IsGregorianLeapYear (int gregorianYear)
		{
			if (id_isGregorianLeapYear_I == IntPtr.Zero)
				id_isGregorianLeapYear_I = JNIEnv.GetStaticMethodID (class_ref, "isGregorianLeapYear", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (gregorianYear);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isGregorianLeapYear_I, __args);
			} finally {
			}
		}

		static IntPtr id_isJulianLeapYear_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='isJulianLeapYear' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isJulianLeapYear", "(I)Z", "")]
		public static unsafe bool IsJulianLeapYear (int normalizedJulianYear)
		{
			if (id_isJulianLeapYear_I == IntPtr.Zero)
				id_isJulianLeapYear_I = JNIEnv.GetStaticMethodID (class_ref, "isJulianLeapYear", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (normalizedJulianYear);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isJulianLeapYear_I, __args);
			} finally {
			}
		}

		static IntPtr id_mod_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='mod' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("mod", "(II)I", "")]
		public static unsafe int Mod (int x, int y)
		{
			if (id_mod_II == IntPtr.Zero)
				id_mod_II = JNIEnv.GetStaticMethodID (class_ref, "mod", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_mod_II, __args);
			} finally {
			}
		}

		static IntPtr id_mod_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='mod' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("mod", "(JJ)J", "")]
		public static unsafe long Mod (long x, long y)
		{
			if (id_mod_JJ == IntPtr.Zero)
				id_mod_JJ = JNIEnv.GetStaticMethodID (class_ref, "mod", "(JJ)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_mod_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_sprintf0d_Ljava_lang_StringBuffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='sprintf0d' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("sprintf0d", "(Ljava/lang/StringBuffer;II)Ljava/lang/StringBuffer;", "")]
		public static unsafe global::Java.Lang.StringBuffer Sprintf0d (global::Java.Lang.StringBuffer sb, int value, int width)
		{
			if (id_sprintf0d_Ljava_lang_StringBuffer_II == IntPtr.Zero)
				id_sprintf0d_Ljava_lang_StringBuffer_II = JNIEnv.GetStaticMethodID (class_ref, "sprintf0d", "(Ljava/lang/StringBuffer;II)Ljava/lang/StringBuffer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sb);
				__args [1] = new JValue (value);
				__args [2] = new JValue (width);
				global::Java.Lang.StringBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sprintf0d_Ljava_lang_StringBuffer_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sprintf0d_Ljava_lang_StringBuilder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarUtils']/method[@name='sprintf0d' and count(parameter)=3 and parameter[1][@type='java.lang.StringBuilder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("sprintf0d", "(Ljava/lang/StringBuilder;II)Ljava/lang/StringBuilder;", "")]
		public static unsafe global::Java.Lang.StringBuilder Sprintf0d (global::Java.Lang.StringBuilder sb, int value, int width)
		{
			if (id_sprintf0d_Ljava_lang_StringBuilder_II == IntPtr.Zero)
				id_sprintf0d_Ljava_lang_StringBuilder_II = JNIEnv.GetStaticMethodID (class_ref, "sprintf0d", "(Ljava/lang/StringBuilder;II)Ljava/lang/StringBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (sb);
				__args [1] = new JValue (value);
				__args [2] = new JValue (width);
				global::Java.Lang.StringBuilder __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_sprintf0d_Ljava_lang_StringBuilder_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
