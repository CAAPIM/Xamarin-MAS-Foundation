using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Util.Calendar {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']"
	[global::Android.Runtime.Register ("sun/util/calendar/CalendarSystem", DoNotGenerateAcw=true)]
	public abstract partial class CalendarSystem : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/util/calendar/CalendarSystem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalendarSystem); }
		}

		protected CalendarSystem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/constructor[@name='CalendarSystem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CalendarSystem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CalendarSystem)) {
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

		static Delegate cb_getCalendarDate;
#pragma warning disable 0169
		static Delegate GetGetCalendarDateHandler ()
		{
			if (cb_getCalendarDate == null)
				cb_getCalendarDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCalendarDate);
			return cb_getCalendarDate;
		}

		static IntPtr n_GetCalendarDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CalendarDate);
		}
#pragma warning restore 0169

		public abstract global::Sun.Util.Calendar.CalendarDate CalendarDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getCalendarDate' and count(parameter)=0]"
			[Register ("getCalendarDate", "()Lsun/util/calendar/CalendarDate;", "GetGetCalendarDateHandler")] get;
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")] get;
		}

		static Delegate cb_getWeekLength;
#pragma warning disable 0169
		static Delegate GetGetWeekLengthHandler ()
		{
			if (cb_getWeekLength == null)
				cb_getWeekLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWeekLength);
			return cb_getWeekLength;
		}

		static int n_GetWeekLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WeekLength;
		}
#pragma warning restore 0169

		public abstract int WeekLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getWeekLength' and count(parameter)=0]"
			[Register ("getWeekLength", "()I", "GetGetWeekLengthHandler")] get;
		}

		static IntPtr id_forName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='forName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("forName", "(Ljava/lang/String;)Lsun/util/calendar/CalendarSystem;", "")]
		public static unsafe global::Sun.Util.Calendar.CalendarSystem ForName (string calendarName)
		{
			if (id_forName_Ljava_lang_String_ == IntPtr.Zero)
				id_forName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "forName", "(Ljava/lang/String;)Lsun/util/calendar/CalendarSystem;");
			IntPtr native_calendarName = JNIEnv.NewString (calendarName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_calendarName);
				global::Sun.Util.Calendar.CalendarSystem __ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (JNIEnv.CallStaticObjectMethod  (class_ref, id_forName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_calendarName);
			}
		}

		static Delegate cb_getCalendarDate_J;
#pragma warning disable 0169
		static Delegate GetGetCalendarDate_JHandler ()
		{
			if (cb_getCalendarDate_J == null)
				cb_getCalendarDate_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetCalendarDate_J);
			return cb_getCalendarDate_J;
		}

		static IntPtr n_GetCalendarDate_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCalendarDate (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getCalendarDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getCalendarDate", "(J)Lsun/util/calendar/CalendarDate;", "GetGetCalendarDate_JHandler")]
		public abstract global::Sun.Util.Calendar.CalendarDate GetCalendarDate (long p0);

		static Delegate cb_getCalendarDate_JLjava_util_TimeZone_;
#pragma warning disable 0169
		static Delegate GetGetCalendarDate_JLjava_util_TimeZone_Handler ()
		{
			if (cb_getCalendarDate_JLjava_util_TimeZone_ == null)
				cb_getCalendarDate_JLjava_util_TimeZone_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_GetCalendarDate_JLjava_util_TimeZone_);
			return cb_getCalendarDate_JLjava_util_TimeZone_;
		}

		static IntPtr n_GetCalendarDate_JLjava_util_TimeZone_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.TimeZone p1 = global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCalendarDate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getCalendarDate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.TimeZone']]"
		[Register ("getCalendarDate", "(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "GetGetCalendarDate_JLjava_util_TimeZone_Handler")]
		public abstract global::Sun.Util.Calendar.CalendarDate GetCalendarDate (long p0, global::Java.Util.TimeZone p1);

		static Delegate cb_getCalendarDate_JLsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetCalendarDate_JLsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getCalendarDate_JLsun_util_calendar_CalendarDate_ == null)
				cb_getCalendarDate_JLsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_GetCalendarDate_JLsun_util_calendar_CalendarDate_);
			return cb_getCalendarDate_JLsun_util_calendar_CalendarDate_;
		}

		static IntPtr n_GetCalendarDate_JLsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p1 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCalendarDate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getCalendarDate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getCalendarDate", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "GetGetCalendarDate_JLsun_util_calendar_CalendarDate_Handler")]
		public abstract global::Sun.Util.Calendar.CalendarDate GetCalendarDate (long p0, global::Sun.Util.Calendar.CalendarDate p1);

		static Delegate cb_getEra_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEra_Ljava_lang_String_Handler ()
		{
			if (cb_getEra_Ljava_lang_String_ == null)
				cb_getEra_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEra_Ljava_lang_String_);
			return cb_getEra_Ljava_lang_String_;
		}

		static IntPtr n_GetEra_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEra (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getEra' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEra", "(Ljava/lang/String;)Lsun/util/calendar/Era;", "GetGetEra_Ljava_lang_String_Handler")]
		public abstract global::Sun.Util.Calendar.Era GetEra (string p0);

		static Delegate cb_getEras;
#pragma warning disable 0169
		static Delegate GetGetErasHandler ()
		{
			if (cb_getEras == null)
				cb_getEras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEras);
			return cb_getEras;
		}

		static IntPtr n_GetEras (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEras ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getEras' and count(parameter)=0]"
		[Register ("getEras", "()[Lsun/util/calendar/Era;", "GetGetErasHandler")]
		public abstract global::Sun.Util.Calendar.Era[] GetEras ();

		static Delegate cb_getMonthLength_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetMonthLength_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getMonthLength_Lsun_util_calendar_CalendarDate_ == null)
				cb_getMonthLength_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetMonthLength_Lsun_util_calendar_CalendarDate_);
			return cb_getMonthLength_Lsun_util_calendar_CalendarDate_;
		}

		static int n_GetMonthLength_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetMonthLength (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getMonthLength' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getMonthLength", "(Lsun/util/calendar/CalendarDate;)I", "GetGetMonthLength_Lsun_util_calendar_CalendarDate_Handler")]
		public abstract int GetMonthLength (global::Sun.Util.Calendar.CalendarDate p0);

		static Delegate cb_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetNthDayOfWeek_IILsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_ == null)
				cb_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetNthDayOfWeek_IILsun_util_calendar_CalendarDate_);
			return cb_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_;
		}

		static IntPtr n_GetNthDayOfWeek_IILsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p2 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNthDayOfWeek (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getNthDayOfWeek' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getNthDayOfWeek", "(IILsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "GetGetNthDayOfWeek_IILsun_util_calendar_CalendarDate_Handler")]
		public abstract global::Sun.Util.Calendar.CalendarDate GetNthDayOfWeek (int p0, int p1, global::Sun.Util.Calendar.CalendarDate p2);

		static Delegate cb_getTime_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetTime_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getTime_Lsun_util_calendar_CalendarDate_ == null)
				cb_getTime_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetTime_Lsun_util_calendar_CalendarDate_);
			return cb_getTime_Lsun_util_calendar_CalendarDate_;
		}

		static long n_GetTime_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetTime (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getTime' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getTime", "(Lsun/util/calendar/CalendarDate;)J", "GetGetTime_Lsun_util_calendar_CalendarDate_Handler")]
		public abstract long GetTime (global::Sun.Util.Calendar.CalendarDate p0);

		static Delegate cb_getYearLength_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetYearLength_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getYearLength_Lsun_util_calendar_CalendarDate_ == null)
				cb_getYearLength_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetYearLength_Lsun_util_calendar_CalendarDate_);
			return cb_getYearLength_Lsun_util_calendar_CalendarDate_;
		}

		static int n_GetYearLength_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetYearLength (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getYearLength' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getYearLength", "(Lsun/util/calendar/CalendarDate;)I", "GetGetYearLength_Lsun_util_calendar_CalendarDate_Handler")]
		public abstract int GetYearLength (global::Sun.Util.Calendar.CalendarDate p0);

		static Delegate cb_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetYearLengthInMonths_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_ == null)
				cb_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetYearLengthInMonths_Lsun_util_calendar_CalendarDate_);
			return cb_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_;
		}

		static int n_GetYearLengthInMonths_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetYearLengthInMonths (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getYearLengthInMonths' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getYearLengthInMonths", "(Lsun/util/calendar/CalendarDate;)I", "GetGetYearLengthInMonths_Lsun_util_calendar_CalendarDate_Handler")]
		public abstract int GetYearLengthInMonths (global::Sun.Util.Calendar.CalendarDate p0);

		static Delegate cb_newCalendarDate;
#pragma warning disable 0169
		static Delegate GetNewCalendarDateHandler ()
		{
			if (cb_newCalendarDate == null)
				cb_newCalendarDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewCalendarDate);
			return cb_newCalendarDate;
		}

		static IntPtr n_NewCalendarDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewCalendarDate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='newCalendarDate' and count(parameter)=0]"
		[Register ("newCalendarDate", "()Lsun/util/calendar/CalendarDate;", "GetNewCalendarDateHandler")]
		public abstract global::Sun.Util.Calendar.CalendarDate NewCalendarDate ();

		static Delegate cb_newCalendarDate_Ljava_util_TimeZone_;
#pragma warning disable 0169
		static Delegate GetNewCalendarDate_Ljava_util_TimeZone_Handler ()
		{
			if (cb_newCalendarDate_Ljava_util_TimeZone_ == null)
				cb_newCalendarDate_Ljava_util_TimeZone_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewCalendarDate_Ljava_util_TimeZone_);
			return cb_newCalendarDate_Ljava_util_TimeZone_;
		}

		static IntPtr n_NewCalendarDate_Ljava_util_TimeZone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.TimeZone p0 = global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewCalendarDate (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='newCalendarDate' and count(parameter)=1 and parameter[1][@type='java.util.TimeZone']]"
		[Register ("newCalendarDate", "(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "GetNewCalendarDate_Ljava_util_TimeZone_Handler")]
		public abstract global::Sun.Util.Calendar.CalendarDate NewCalendarDate (global::Java.Util.TimeZone p0);

		static Delegate cb_normalize_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetNormalize_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_normalize_Lsun_util_calendar_CalendarDate_ == null)
				cb_normalize_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Normalize_Lsun_util_calendar_CalendarDate_);
			return cb_normalize_Lsun_util_calendar_CalendarDate_;
		}

		static bool n_Normalize_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Normalize (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("normalize", "(Lsun/util/calendar/CalendarDate;)Z", "GetNormalize_Lsun_util_calendar_CalendarDate_Handler")]
		public abstract bool Normalize (global::Sun.Util.Calendar.CalendarDate p0);

		static Delegate cb_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_Handler ()
		{
			if (cb_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_ == null)
				cb_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_);
			return cb_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_;
		}

		static void n_SetEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetEra (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='setEra' and count(parameter)=2 and parameter[1][@type='sun.util.calendar.CalendarDate'] and parameter[2][@type='java.lang.String']]"
		[Register ("setEra", "(Lsun/util/calendar/CalendarDate;Ljava/lang/String;)V", "GetSetEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_Handler")]
		public abstract void SetEra (global::Sun.Util.Calendar.CalendarDate p0, string p1);

		static Delegate cb_setTimeOfDay_Lsun_util_calendar_CalendarDate_I;
#pragma warning disable 0169
		static Delegate GetSetTimeOfDay_Lsun_util_calendar_CalendarDate_IHandler ()
		{
			if (cb_setTimeOfDay_Lsun_util_calendar_CalendarDate_I == null)
				cb_setTimeOfDay_Lsun_util_calendar_CalendarDate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SetTimeOfDay_Lsun_util_calendar_CalendarDate_I);
			return cb_setTimeOfDay_Lsun_util_calendar_CalendarDate_I;
		}

		static IntPtr n_SetTimeOfDay_Lsun_util_calendar_CalendarDate_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTimeOfDay (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='setTimeOfDay' and count(parameter)=2 and parameter[1][@type='sun.util.calendar.CalendarDate'] and parameter[2][@type='int']]"
		[Register ("setTimeOfDay", "(Lsun/util/calendar/CalendarDate;I)Lsun/util/calendar/CalendarDate;", "GetSetTimeOfDay_Lsun_util_calendar_CalendarDate_IHandler")]
		public abstract global::Sun.Util.Calendar.CalendarDate SetTimeOfDay (global::Sun.Util.Calendar.CalendarDate p0, int p1);

		static Delegate cb_validate_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetValidate_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_validate_Lsun_util_calendar_CalendarDate_ == null)
				cb_validate_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Validate_Lsun_util_calendar_CalendarDate_);
			return cb_validate_Lsun_util_calendar_CalendarDate_;
		}

		static bool n_Validate_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Util.Calendar.CalendarSystem __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Validate (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='validate' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("validate", "(Lsun/util/calendar/CalendarDate;)Z", "GetValidate_Lsun_util_calendar_CalendarDate_Handler")]
		public abstract bool Validate (global::Sun.Util.Calendar.CalendarDate p0);

	}

	[global::Android.Runtime.Register ("sun/util/calendar/CalendarSystem", DoNotGenerateAcw=true)]
	internal partial class CalendarSystemInvoker : CalendarSystem {

		public CalendarSystemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalendarSystemInvoker); }
		}

		static IntPtr id_getCalendarDate;
		public override unsafe global::Sun.Util.Calendar.CalendarDate CalendarDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getCalendarDate' and count(parameter)=0]"
			[Register ("getCalendarDate", "()Lsun/util/calendar/CalendarDate;", "GetGetCalendarDateHandler")]
			get {
				if (id_getCalendarDate == IntPtr.Zero)
					id_getCalendarDate = JNIEnv.GetMethodID (class_ref, "getCalendarDate", "()Lsun/util/calendar/CalendarDate;");
				try {
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarDate), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getName;
		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getName' and count(parameter)=0]"
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

		static IntPtr id_getWeekLength;
		public override unsafe int WeekLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getWeekLength' and count(parameter)=0]"
			[Register ("getWeekLength", "()I", "GetGetWeekLengthHandler")]
			get {
				if (id_getWeekLength == IntPtr.Zero)
					id_getWeekLength = JNIEnv.GetMethodID (class_ref, "getWeekLength", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWeekLength);
				} finally {
				}
			}
		}

		static IntPtr id_getCalendarDate_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getCalendarDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getCalendarDate", "(J)Lsun/util/calendar/CalendarDate;", "GetGetCalendarDate_JHandler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate GetCalendarDate (long p0)
		{
			if (id_getCalendarDate_J == IntPtr.Zero)
				id_getCalendarDate_J = JNIEnv.GetMethodID (class_ref, "getCalendarDate", "(J)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarDate_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getCalendarDate_JLjava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getCalendarDate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.TimeZone']]"
		[Register ("getCalendarDate", "(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "GetGetCalendarDate_JLjava_util_TimeZone_Handler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate GetCalendarDate (long p0, global::Java.Util.TimeZone p1)
		{
			if (id_getCalendarDate_JLjava_util_TimeZone_ == IntPtr.Zero)
				id_getCalendarDate_JLjava_util_TimeZone_ = JNIEnv.GetMethodID (class_ref, "getCalendarDate", "(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Sun.Util.Calendar.CalendarDate __ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarDate_JLjava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getCalendarDate_JLsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getCalendarDate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getCalendarDate", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "GetGetCalendarDate_JLsun_util_calendar_CalendarDate_Handler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate GetCalendarDate (long p0, global::Sun.Util.Calendar.CalendarDate p1)
		{
			if (id_getCalendarDate_JLsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getCalendarDate_JLsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getCalendarDate", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Sun.Util.Calendar.CalendarDate __ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarDate_JLsun_util_calendar_CalendarDate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getEra_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getEra' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEra", "(Ljava/lang/String;)Lsun/util/calendar/Era;", "GetGetEra_Ljava_lang_String_Handler")]
		public override unsafe global::Sun.Util.Calendar.Era GetEra (string p0)
		{
			if (id_getEra_Ljava_lang_String_ == IntPtr.Zero)
				id_getEra_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getEra", "(Ljava/lang/String;)Lsun/util/calendar/Era;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Sun.Util.Calendar.Era __ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.Era> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEra_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getEras;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getEras' and count(parameter)=0]"
		[Register ("getEras", "()[Lsun/util/calendar/Era;", "GetGetErasHandler")]
		public override unsafe global::Sun.Util.Calendar.Era[] GetEras ()
		{
			if (id_getEras == IntPtr.Zero)
				id_getEras = JNIEnv.GetMethodID (class_ref, "getEras", "()[Lsun/util/calendar/Era;");
			try {
				return (global::Sun.Util.Calendar.Era[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEras), JniHandleOwnership.TransferLocalRef, typeof (global::Sun.Util.Calendar.Era));
			} finally {
			}
		}

		static IntPtr id_getMonthLength_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getMonthLength' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getMonthLength", "(Lsun/util/calendar/CalendarDate;)I", "GetGetMonthLength_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe int GetMonthLength (global::Sun.Util.Calendar.CalendarDate p0)
		{
			if (id_getMonthLength_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getMonthLength_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getMonthLength", "(Lsun/util/calendar/CalendarDate;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMonthLength_Lsun_util_calendar_CalendarDate_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getNthDayOfWeek' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getNthDayOfWeek", "(IILsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "GetGetNthDayOfWeek_IILsun_util_calendar_CalendarDate_Handler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate GetNthDayOfWeek (int p0, int p1, global::Sun.Util.Calendar.CalendarDate p2)
		{
			if (id_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getNthDayOfWeek", "(IILsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Sun.Util.Calendar.CalendarDate __ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTime_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getTime' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getTime", "(Lsun/util/calendar/CalendarDate;)J", "GetGetTime_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe long GetTime (global::Sun.Util.Calendar.CalendarDate p0)
		{
			if (id_getTime_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getTime_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getTime", "(Lsun/util/calendar/CalendarDate;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTime_Lsun_util_calendar_CalendarDate_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getYearLength_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getYearLength' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getYearLength", "(Lsun/util/calendar/CalendarDate;)I", "GetGetYearLength_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe int GetYearLength (global::Sun.Util.Calendar.CalendarDate p0)
		{
			if (id_getYearLength_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getYearLength_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getYearLength", "(Lsun/util/calendar/CalendarDate;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYearLength_Lsun_util_calendar_CalendarDate_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='getYearLengthInMonths' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getYearLengthInMonths", "(Lsun/util/calendar/CalendarDate;)I", "GetGetYearLengthInMonths_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe int GetYearLengthInMonths (global::Sun.Util.Calendar.CalendarDate p0)
		{
			if (id_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getYearLengthInMonths", "(Lsun/util/calendar/CalendarDate;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newCalendarDate;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='newCalendarDate' and count(parameter)=0]"
		[Register ("newCalendarDate", "()Lsun/util/calendar/CalendarDate;", "GetNewCalendarDateHandler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate NewCalendarDate ()
		{
			if (id_newCalendarDate == IntPtr.Zero)
				id_newCalendarDate = JNIEnv.GetMethodID (class_ref, "newCalendarDate", "()Lsun/util/calendar/CalendarDate;");
			try {
				return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newCalendarDate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newCalendarDate_Ljava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='newCalendarDate' and count(parameter)=1 and parameter[1][@type='java.util.TimeZone']]"
		[Register ("newCalendarDate", "(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "GetNewCalendarDate_Ljava_util_TimeZone_Handler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate NewCalendarDate (global::Java.Util.TimeZone p0)
		{
			if (id_newCalendarDate_Ljava_util_TimeZone_ == IntPtr.Zero)
				id_newCalendarDate_Ljava_util_TimeZone_ = JNIEnv.GetMethodID (class_ref, "newCalendarDate", "(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Sun.Util.Calendar.CalendarDate __ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newCalendarDate_Ljava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_normalize_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("normalize", "(Lsun/util/calendar/CalendarDate;)Z", "GetNormalize_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe bool Normalize (global::Sun.Util.Calendar.CalendarDate p0)
		{
			if (id_normalize_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_normalize_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "normalize", "(Lsun/util/calendar/CalendarDate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_normalize_Lsun_util_calendar_CalendarDate_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='setEra' and count(parameter)=2 and parameter[1][@type='sun.util.calendar.CalendarDate'] and parameter[2][@type='java.lang.String']]"
		[Register ("setEra", "(Lsun/util/calendar/CalendarDate;Ljava/lang/String;)V", "GetSetEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_Handler")]
		public override unsafe void SetEra (global::Sun.Util.Calendar.CalendarDate p0, string p1)
		{
			if (id_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_ == IntPtr.Zero)
				id_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEra", "(Lsun/util/calendar/CalendarDate;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setTimeOfDay_Lsun_util_calendar_CalendarDate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='setTimeOfDay' and count(parameter)=2 and parameter[1][@type='sun.util.calendar.CalendarDate'] and parameter[2][@type='int']]"
		[Register ("setTimeOfDay", "(Lsun/util/calendar/CalendarDate;I)Lsun/util/calendar/CalendarDate;", "GetSetTimeOfDay_Lsun_util_calendar_CalendarDate_IHandler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate SetTimeOfDay (global::Sun.Util.Calendar.CalendarDate p0, int p1)
		{
			if (id_setTimeOfDay_Lsun_util_calendar_CalendarDate_I == IntPtr.Zero)
				id_setTimeOfDay_Lsun_util_calendar_CalendarDate_I = JNIEnv.GetMethodID (class_ref, "setTimeOfDay", "(Lsun/util/calendar/CalendarDate;I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Sun.Util.Calendar.CalendarDate __ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTimeOfDay_Lsun_util_calendar_CalendarDate_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_validate_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarSystem']/method[@name='validate' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("validate", "(Lsun/util/calendar/CalendarDate;)Z", "GetValidate_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe bool Validate (global::Sun.Util.Calendar.CalendarDate p0)
		{
			if (id_validate_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_validate_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "validate", "(Lsun/util/calendar/CalendarDate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_validate_Lsun_util_calendar_CalendarDate_, __args);
				return __ret;
			} finally {
			}
		}

	}

}
