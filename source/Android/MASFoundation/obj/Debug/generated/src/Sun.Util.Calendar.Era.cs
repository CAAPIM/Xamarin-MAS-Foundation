using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Util.Calendar {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.util.calendar']/class[@name='Era']"
	[global::Android.Runtime.Register ("sun/util/calendar/Era", DoNotGenerateAcw=true)]
	public sealed partial class Era : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/util/calendar/Era", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Era); }
		}

		internal Era (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.util.calendar']/class[@name='Era']/constructor[@name='Era' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;JZ)V", "")]
		public unsafe Era (string name, string abbr, long since, bool localTime)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_abbr = JNIEnv.NewString (abbr);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (native_abbr);
				__args [2] = new JValue (since);
				__args [3] = new JValue (localTime);
				if (((object) this).GetType () != typeof (Era)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;JZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;JZ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_JZ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_JZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;JZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_abbr);
			}
		}

		static IntPtr id_getAbbreviation;
		public unsafe string Abbreviation {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='Era']/method[@name='getAbbreviation' and count(parameter)=0]"
			[Register ("getAbbreviation", "()Ljava/lang/String;", "GetGetAbbreviationHandler")]
			get {
				if (id_getAbbreviation == IntPtr.Zero)
					id_getAbbreviation = JNIEnv.GetMethodID (class_ref, "getAbbreviation", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAbbreviation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isLocalTime;
		public unsafe bool IsLocalTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='Era']/method[@name='isLocalTime' and count(parameter)=0]"
			[Register ("isLocalTime", "()Z", "GetIsLocalTimeHandler")]
			get {
				if (id_isLocalTime == IntPtr.Zero)
					id_isLocalTime = JNIEnv.GetMethodID (class_ref, "isLocalTime", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLocalTime);
				} finally {
				}
			}
		}

		static IntPtr id_getName;
		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='Era']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSinceDate;
		public unsafe global::Sun.Util.Calendar.CalendarDate SinceDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='Era']/method[@name='getSinceDate' and count(parameter)=0]"
			[Register ("getSinceDate", "()Lsun/util/calendar/CalendarDate;", "GetGetSinceDateHandler")]
			get {
				if (id_getSinceDate == IntPtr.Zero)
					id_getSinceDate = JNIEnv.GetMethodID (class_ref, "getSinceDate", "()Lsun/util/calendar/CalendarDate;");
				try {
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSinceDate), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDiaplayAbbreviation_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='Era']/method[@name='getDiaplayAbbreviation' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("getDiaplayAbbreviation", "(Ljava/util/Locale;)Ljava/lang/String;", "")]
		public unsafe string GetDiaplayAbbreviation (global::Java.Util.Locale locale)
		{
			if (id_getDiaplayAbbreviation_Ljava_util_Locale_ == IntPtr.Zero)
				id_getDiaplayAbbreviation_Ljava_util_Locale_ = JNIEnv.GetMethodID (class_ref, "getDiaplayAbbreviation", "(Ljava/util/Locale;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDiaplayAbbreviation_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDisplayName_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='Era']/method[@name='getDisplayName' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", "")]
		public unsafe string GetDisplayName (global::Java.Util.Locale locale)
		{
			if (id_getDisplayName_Ljava_util_Locale_ == IntPtr.Zero)
				id_getDisplayName_Ljava_util_Locale_ = JNIEnv.GetMethodID (class_ref, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (locale);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getSince_Ljava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='Era']/method[@name='getSince' and count(parameter)=1 and parameter[1][@type='java.util.TimeZone']]"
		[Register ("getSince", "(Ljava/util/TimeZone;)J", "")]
		public unsafe long GetSince (global::Java.Util.TimeZone zone)
		{
			if (id_getSince_Ljava_util_TimeZone_ == IntPtr.Zero)
				id_getSince_Ljava_util_TimeZone_ = JNIEnv.GetMethodID (class_ref, "getSince", "(Ljava/util/TimeZone;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (zone);
				long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSince_Ljava_util_TimeZone_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
