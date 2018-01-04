using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Util.Calendar {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']"
	[global::Android.Runtime.Register ("sun/util/calendar/AbstractCalendar", DoNotGenerateAcw=true)]
	public abstract partial class AbstractCalendar : global::Sun.Util.Calendar.CalendarSystem {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/util/calendar/AbstractCalendar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractCalendar); }
		}

		protected AbstractCalendar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/constructor[@name='AbstractCalendar' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe AbstractCalendar ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AbstractCalendar)) {
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
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CalendarDate);
		}
#pragma warning restore 0169

		static IntPtr id_getCalendarDate;
		public override unsafe global::Sun.Util.Calendar.CalendarDate CalendarDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getCalendarDate' and count(parameter)=0]"
			[Register ("getCalendarDate", "()Lsun/util/calendar/CalendarDate;", "GetGetCalendarDateHandler")]
			get {
				if (id_getCalendarDate == IntPtr.Zero)
					id_getCalendarDate = JNIEnv.GetMethodID (class_ref, "getCalendarDate", "()Lsun/util/calendar/CalendarDate;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalendarDate", "()Lsun/util/calendar/CalendarDate;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WeekLength;
		}
#pragma warning restore 0169

		static IntPtr id_getWeekLength;
		public override unsafe int WeekLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getWeekLength' and count(parameter)=0]"
			[Register ("getWeekLength", "()I", "GetGetWeekLengthHandler")]
			get {
				if (id_getWeekLength == IntPtr.Zero)
					id_getWeekLength = JNIEnv.GetMethodID (class_ref, "getWeekLength", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWeekLength);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWeekLength", "()I"));
				} finally {
				}
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

		static IntPtr n_GetCalendarDate_J (IntPtr jnienv, IntPtr native__this, long millis)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCalendarDate (millis));
		}
#pragma warning restore 0169

		static IntPtr id_getCalendarDate_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getCalendarDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getCalendarDate", "(J)Lsun/util/calendar/CalendarDate;", "GetGetCalendarDate_JHandler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate GetCalendarDate (long millis)
		{
			if (id_getCalendarDate_J == IntPtr.Zero)
				id_getCalendarDate_J = JNIEnv.GetMethodID (class_ref, "getCalendarDate", "(J)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (millis);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarDate_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalendarDate", "(J)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCalendarDate_JLjava_util_TimeZone_;
#pragma warning disable 0169
		static Delegate GetGetCalendarDate_JLjava_util_TimeZone_Handler ()
		{
			if (cb_getCalendarDate_JLjava_util_TimeZone_ == null)
				cb_getCalendarDate_JLjava_util_TimeZone_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_GetCalendarDate_JLjava_util_TimeZone_);
			return cb_getCalendarDate_JLjava_util_TimeZone_;
		}

		static IntPtr n_GetCalendarDate_JLjava_util_TimeZone_ (IntPtr jnienv, IntPtr native__this, long millis, IntPtr native_zone)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.TimeZone zone = global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (native_zone, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCalendarDate (millis, zone));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCalendarDate_JLjava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getCalendarDate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.TimeZone']]"
		[Register ("getCalendarDate", "(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "GetGetCalendarDate_JLjava_util_TimeZone_Handler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate GetCalendarDate (long millis, global::Java.Util.TimeZone zone)
		{
			if (id_getCalendarDate_JLjava_util_TimeZone_ == IntPtr.Zero)
				id_getCalendarDate_JLjava_util_TimeZone_ = JNIEnv.GetMethodID (class_ref, "getCalendarDate", "(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (millis);
				__args [1] = new JValue (zone);

				global::Sun.Util.Calendar.CalendarDate __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarDate_JLjava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalendarDate", "(JLjava/util/TimeZone;)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getCalendarDate_JLsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetCalendarDate_JLsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getCalendarDate_JLsun_util_calendar_CalendarDate_ == null)
				cb_getCalendarDate_JLsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_GetCalendarDate_JLsun_util_calendar_CalendarDate_);
			return cb_getCalendarDate_JLsun_util_calendar_CalendarDate_;
		}

		static IntPtr n_GetCalendarDate_JLsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, long millis, IntPtr native_date)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCalendarDate (millis, date));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCalendarDate_JLsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getCalendarDate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getCalendarDate", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "GetGetCalendarDate_JLsun_util_calendar_CalendarDate_Handler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate GetCalendarDate (long millis, global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getCalendarDate_JLsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getCalendarDate_JLsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getCalendarDate", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (millis);
				__args [1] = new JValue (date);

				global::Sun.Util.Calendar.CalendarDate __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarDate_JLsun_util_calendar_CalendarDate_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalendarDate", "(JLsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J;
#pragma warning disable 0169
		static Delegate GetGetCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_JHandler ()
		{
			if (cb_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J == null)
				cb_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_GetCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J);
			return cb_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J;
		}

		static void n_GetCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetCalendarDateFromFixedDate (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getCalendarDateFromFixedDate' and count(parameter)=2 and parameter[1][@type='sun.util.calendar.CalendarDate'] and parameter[2][@type='long']]"
		[Register ("getCalendarDateFromFixedDate", "(Lsun/util/calendar/CalendarDate;J)V", "GetGetCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_JHandler")]
		protected abstract void GetCalendarDateFromFixedDate (global::Sun.Util.Calendar.CalendarDate p0, long p1);

		static IntPtr id_getDayOfWeekDateOnOrBefore_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getDayOfWeekDateOnOrBefore' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("getDayOfWeekDateOnOrBefore", "(JI)J", "")]
		public static unsafe long GetDayOfWeekDateOnOrBefore (long fixedDate, int dayOfWeek)
		{
			if (id_getDayOfWeekDateOnOrBefore_JI == IntPtr.Zero)
				id_getDayOfWeekDateOnOrBefore_JI = JNIEnv.GetStaticMethodID (class_ref, "getDayOfWeekDateOnOrBefore", "(JI)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (fixedDate);
				__args [1] = new JValue (dayOfWeek);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_getDayOfWeekDateOnOrBefore_JI, __args);
			} finally {
			}
		}

		static Delegate cb_getEra_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEra_Ljava_lang_String_Handler ()
		{
			if (cb_getEra_Ljava_lang_String_ == null)
				cb_getEra_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEra_Ljava_lang_String_);
			return cb_getEra_Ljava_lang_String_;
		}

		static IntPtr n_GetEra_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eraName)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eraName = JNIEnv.GetString (native_eraName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEra (eraName));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getEra_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getEra' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEra", "(Ljava/lang/String;)Lsun/util/calendar/Era;", "GetGetEra_Ljava_lang_String_Handler")]
		public override unsafe global::Sun.Util.Calendar.Era GetEra (string eraName)
		{
			if (id_getEra_Ljava_lang_String_ == IntPtr.Zero)
				id_getEra_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getEra", "(Ljava/lang/String;)Lsun/util/calendar/Era;");
			IntPtr native_eraName = JNIEnv.NewString (eraName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_eraName);

				global::Sun.Util.Calendar.Era __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.Era> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEra_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.Era> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEra", "(Ljava/lang/String;)Lsun/util/calendar/Era;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_eraName);
			}
		}

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
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEras ());
		}
#pragma warning restore 0169

		static IntPtr id_getEras;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getEras' and count(parameter)=0]"
		[Register ("getEras", "()[Lsun/util/calendar/Era;", "GetGetErasHandler")]
		public override unsafe global::Sun.Util.Calendar.Era[] GetEras ()
		{
			if (id_getEras == IntPtr.Zero)
				id_getEras = JNIEnv.GetMethodID (class_ref, "getEras", "()[Lsun/util/calendar/Era;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Sun.Util.Calendar.Era[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEras), JniHandleOwnership.TransferLocalRef, typeof (global::Sun.Util.Calendar.Era));
				else
					return (global::Sun.Util.Calendar.Era[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEras", "()[Lsun/util/calendar/Era;")), JniHandleOwnership.TransferLocalRef, typeof (global::Sun.Util.Calendar.Era));
			} finally {
			}
		}

		static Delegate cb_getFixedDate_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetFixedDate_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getFixedDate_Lsun_util_calendar_CalendarDate_ == null)
				cb_getFixedDate_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetFixedDate_Lsun_util_calendar_CalendarDate_);
			return cb_getFixedDate_Lsun_util_calendar_CalendarDate_;
		}

		static long n_GetFixedDate_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetFixedDate (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getFixedDate' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getFixedDate", "(Lsun/util/calendar/CalendarDate;)J", "GetGetFixedDate_Lsun_util_calendar_CalendarDate_Handler")]
		protected abstract long GetFixedDate (global::Sun.Util.Calendar.CalendarDate p0);

		static Delegate cb_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetNthDayOfWeek_IILsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_ == null)
				cb_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetNthDayOfWeek_IILsun_util_calendar_CalendarDate_);
			return cb_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_;
		}

		static IntPtr n_GetNthDayOfWeek_IILsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, int nth, int dayOfWeek, IntPtr native_date)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNthDayOfWeek (nth, dayOfWeek, date));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getNthDayOfWeek' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getNthDayOfWeek", "(IILsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;", "GetGetNthDayOfWeek_IILsun_util_calendar_CalendarDate_Handler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate GetNthDayOfWeek (int nth, int dayOfWeek, global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getNthDayOfWeek", "(IILsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (nth);
				__args [1] = new JValue (dayOfWeek);
				__args [2] = new JValue (date);

				global::Sun.Util.Calendar.CalendarDate __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNthDayOfWeek_IILsun_util_calendar_CalendarDate_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNthDayOfWeek", "(IILsun/util/calendar/CalendarDate;)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getTime_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetTime_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getTime_Lsun_util_calendar_CalendarDate_ == null)
				cb_getTime_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetTime_Lsun_util_calendar_CalendarDate_);
			return cb_getTime_Lsun_util_calendar_CalendarDate_;
		}

		static long n_GetTime_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetTime (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTime_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getTime' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getTime", "(Lsun/util/calendar/CalendarDate;)J", "GetGetTime_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe long GetTime (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getTime_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getTime_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getTime", "(Lsun/util/calendar/CalendarDate;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTime_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTime", "(Lsun/util/calendar/CalendarDate;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getTimeOfDay_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetTimeOfDay_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getTimeOfDay_Lsun_util_calendar_CalendarDate_ == null)
				cb_getTimeOfDay_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetTimeOfDay_Lsun_util_calendar_CalendarDate_);
			return cb_getTimeOfDay_Lsun_util_calendar_CalendarDate_;
		}

		static long n_GetTimeOfDay_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetTimeOfDay (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeOfDay_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getTimeOfDay' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getTimeOfDay", "(Lsun/util/calendar/CalendarDate;)J", "GetGetTimeOfDay_Lsun_util_calendar_CalendarDate_Handler")]
		protected virtual unsafe long GetTimeOfDay (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getTimeOfDay_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getTimeOfDay_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getTimeOfDay", "(Lsun/util/calendar/CalendarDate;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeOfDay_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeOfDay", "(Lsun/util/calendar/CalendarDate;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getTimeOfDayValue_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetTimeOfDayValue_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getTimeOfDayValue_Lsun_util_calendar_CalendarDate_ == null)
				cb_getTimeOfDayValue_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetTimeOfDayValue_Lsun_util_calendar_CalendarDate_);
			return cb_getTimeOfDayValue_Lsun_util_calendar_CalendarDate_;
		}

		static long n_GetTimeOfDayValue_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetTimeOfDayValue (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeOfDayValue_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getTimeOfDayValue' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getTimeOfDayValue", "(Lsun/util/calendar/CalendarDate;)J", "GetGetTimeOfDayValue_Lsun_util_calendar_CalendarDate_Handler")]
		public virtual unsafe long GetTimeOfDayValue (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getTimeOfDayValue_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getTimeOfDayValue_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getTimeOfDayValue", "(Lsun/util/calendar/CalendarDate;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeOfDayValue_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeOfDayValue", "(Lsun/util/calendar/CalendarDate;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isLeapYear_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetIsLeapYear_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_isLeapYear_Lsun_util_calendar_CalendarDate_ == null)
				cb_isLeapYear_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsLeapYear_Lsun_util_calendar_CalendarDate_);
			return cb_isLeapYear_Lsun_util_calendar_CalendarDate_;
		}

		static bool n_IsLeapYear_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate p0 = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsLeapYear (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='isLeapYear' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("isLeapYear", "(Lsun/util/calendar/CalendarDate;)Z", "GetIsLeapYear_Lsun_util_calendar_CalendarDate_Handler")]
		protected abstract bool IsLeapYear (global::Sun.Util.Calendar.CalendarDate p0);

		static Delegate cb_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_Handler ()
		{
			if (cb_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_ == null)
				cb_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_);
			return cb_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_;
		}

		static void n_SetEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date, IntPtr native_eraName)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			string eraName = JNIEnv.GetString (native_eraName, JniHandleOwnership.DoNotTransfer);
			__this.SetEra (date, eraName);
		}
#pragma warning restore 0169

		static IntPtr id_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='setEra' and count(parameter)=2 and parameter[1][@type='sun.util.calendar.CalendarDate'] and parameter[2][@type='java.lang.String']]"
		[Register ("setEra", "(Lsun/util/calendar/CalendarDate;Ljava/lang/String;)V", "GetSetEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_Handler")]
		public override unsafe void SetEra (global::Sun.Util.Calendar.CalendarDate date, string eraName)
		{
			if (id_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_ == IntPtr.Zero)
				id_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEra", "(Lsun/util/calendar/CalendarDate;Ljava/lang/String;)V");
			IntPtr native_eraName = JNIEnv.NewString (eraName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (native_eraName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEra_Lsun_util_calendar_CalendarDate_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEra", "(Lsun/util/calendar/CalendarDate;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eraName);
			}
		}

		static Delegate cb_setEras_arrayLsun_util_calendar_Era_;
#pragma warning disable 0169
		static Delegate GetSetEras_arrayLsun_util_calendar_Era_Handler ()
		{
			if (cb_setEras_arrayLsun_util_calendar_Era_ == null)
				cb_setEras_arrayLsun_util_calendar_Era_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEras_arrayLsun_util_calendar_Era_);
			return cb_setEras_arrayLsun_util_calendar_Era_;
		}

		static void n_SetEras_arrayLsun_util_calendar_Era_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eras)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.Era[] eras = (global::Sun.Util.Calendar.Era[]) JNIEnv.GetArray (native_eras, JniHandleOwnership.DoNotTransfer, typeof (global::Sun.Util.Calendar.Era));
			__this.SetEras (eras);
			if (eras != null)
				JNIEnv.CopyArray (eras, native_eras);
		}
#pragma warning restore 0169

		static IntPtr id_setEras_arrayLsun_util_calendar_Era_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='setEras' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.Era[]']]"
		[Register ("setEras", "([Lsun/util/calendar/Era;)V", "GetSetEras_arrayLsun_util_calendar_Era_Handler")]
		protected virtual unsafe void SetEras (global::Sun.Util.Calendar.Era[] eras)
		{
			if (id_setEras_arrayLsun_util_calendar_Era_ == IntPtr.Zero)
				id_setEras_arrayLsun_util_calendar_Era_ = JNIEnv.GetMethodID (class_ref, "setEras", "([Lsun/util/calendar/Era;)V");
			IntPtr native_eras = JNIEnv.NewArray (eras);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_eras);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEras_arrayLsun_util_calendar_Era_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEras", "([Lsun/util/calendar/Era;)V"), __args);
			} finally {
				if (eras != null) {
					JNIEnv.CopyArray (native_eras, eras);
					JNIEnv.DeleteLocalRef (native_eras);
				}
			}
		}

		static Delegate cb_setTimeOfDay_Lsun_util_calendar_CalendarDate_I;
#pragma warning disable 0169
		static Delegate GetSetTimeOfDay_Lsun_util_calendar_CalendarDate_IHandler ()
		{
			if (cb_setTimeOfDay_Lsun_util_calendar_CalendarDate_I == null)
				cb_setTimeOfDay_Lsun_util_calendar_CalendarDate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SetTimeOfDay_Lsun_util_calendar_CalendarDate_I);
			return cb_setTimeOfDay_Lsun_util_calendar_CalendarDate_I;
		}

		static IntPtr n_SetTimeOfDay_Lsun_util_calendar_CalendarDate_I (IntPtr jnienv, IntPtr native__this, IntPtr native_cdate, int fraction)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate cdate = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_cdate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTimeOfDay (cdate, fraction));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTimeOfDay_Lsun_util_calendar_CalendarDate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='setTimeOfDay' and count(parameter)=2 and parameter[1][@type='sun.util.calendar.CalendarDate'] and parameter[2][@type='int']]"
		[Register ("setTimeOfDay", "(Lsun/util/calendar/CalendarDate;I)Lsun/util/calendar/CalendarDate;", "GetSetTimeOfDay_Lsun_util_calendar_CalendarDate_IHandler")]
		public override unsafe global::Sun.Util.Calendar.CalendarDate SetTimeOfDay (global::Sun.Util.Calendar.CalendarDate cdate, int fraction)
		{
			if (id_setTimeOfDay_Lsun_util_calendar_CalendarDate_I == IntPtr.Zero)
				id_setTimeOfDay_Lsun_util_calendar_CalendarDate_I = JNIEnv.GetMethodID (class_ref, "setTimeOfDay", "(Lsun/util/calendar/CalendarDate;I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cdate);
				__args [1] = new JValue (fraction);

				global::Sun.Util.Calendar.CalendarDate __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTimeOfDay_Lsun_util_calendar_CalendarDate_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeOfDay", "(Lsun/util/calendar/CalendarDate;I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_validateTime_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetValidateTime_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_validateTime_Lsun_util_calendar_CalendarDate_ == null)
				cb_validateTime_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ValidateTime_Lsun_util_calendar_CalendarDate_);
			return cb_validateTime_Lsun_util_calendar_CalendarDate_;
		}

		static bool n_ValidateTime_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.AbstractCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.AbstractCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ValidateTime (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_validateTime_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='validateTime' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("validateTime", "(Lsun/util/calendar/CalendarDate;)Z", "GetValidateTime_Lsun_util_calendar_CalendarDate_Handler")]
		public virtual unsafe bool ValidateTime (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_validateTime_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_validateTime_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "validateTime", "(Lsun/util/calendar/CalendarDate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_validateTime_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validateTime", "(Lsun/util/calendar/CalendarDate;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("sun/util/calendar/AbstractCalendar", DoNotGenerateAcw=true)]
	internal partial class AbstractCalendarInvoker : AbstractCalendar {

		public AbstractCalendarInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractCalendarInvoker); }
		}

		static IntPtr id_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getCalendarDateFromFixedDate' and count(parameter)=2 and parameter[1][@type='sun.util.calendar.CalendarDate'] and parameter[2][@type='long']]"
		[Register ("getCalendarDateFromFixedDate", "(Lsun/util/calendar/CalendarDate;J)V", "GetGetCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_JHandler")]
		protected override unsafe void GetCalendarDateFromFixedDate (global::Sun.Util.Calendar.CalendarDate p0, long p1)
		{
			if (id_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J == IntPtr.Zero)
				id_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J = JNIEnv.GetMethodID (class_ref, "getCalendarDateFromFixedDate", "(Lsun/util/calendar/CalendarDate;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J, __args);
			} finally {
			}
		}

		static IntPtr id_getFixedDate_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='getFixedDate' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getFixedDate", "(Lsun/util/calendar/CalendarDate;)J", "GetGetFixedDate_Lsun_util_calendar_CalendarDate_Handler")]
		protected override unsafe long GetFixedDate (global::Sun.Util.Calendar.CalendarDate p0)
		{
			if (id_getFixedDate_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getFixedDate_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getFixedDate", "(Lsun/util/calendar/CalendarDate;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getFixedDate_Lsun_util_calendar_CalendarDate_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isLeapYear_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='AbstractCalendar']/method[@name='isLeapYear' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("isLeapYear", "(Lsun/util/calendar/CalendarDate;)Z", "GetIsLeapYear_Lsun_util_calendar_CalendarDate_Handler")]
		protected override unsafe bool IsLeapYear (global::Sun.Util.Calendar.CalendarDate p0)
		{
			if (id_isLeapYear_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_isLeapYear_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "isLeapYear", "(Lsun/util/calendar/CalendarDate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLeapYear_Lsun_util_calendar_CalendarDate_, __args);
				return __ret;
			} finally {
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
