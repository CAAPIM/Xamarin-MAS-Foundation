using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Util.Calendar {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']"
	[global::Android.Runtime.Register ("sun/util/calendar/BaseCalendar", DoNotGenerateAcw=true)]
	public abstract partial class BaseCalendar : global::Sun.Util.Calendar.AbstractCalendar {


		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='APRIL']"
		[Register ("APRIL")]
		public const int April = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='AUGUST']"
		[Register ("AUGUST")]
		public const int August = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='DECEMBER']"
		[Register ("DECEMBER")]
		public const int December = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='FEBRUARY']"
		[Register ("FEBRUARY")]
		public const int February = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='FRIDAY']"
		[Register ("FRIDAY")]
		public const int Friday = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='JANUARY']"
		[Register ("JANUARY")]
		public const int January = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='JULY']"
		[Register ("JULY")]
		public const int July = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='JUNE']"
		[Register ("JUNE")]
		public const int June = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='MARCH']"
		[Register ("MARCH")]
		public const int March = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='MAY']"
		[Register ("MAY")]
		public const int May = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='MONDAY']"
		[Register ("MONDAY")]
		public const int Monday = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='NOVEMBER']"
		[Register ("NOVEMBER")]
		public const int November = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='OCTOBER']"
		[Register ("OCTOBER")]
		public const int October = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='SATURDAY']"
		[Register ("SATURDAY")]
		public const int Saturday = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='SEPTEMBER']"
		[Register ("SEPTEMBER")]
		public const int September = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='SUNDAY']"
		[Register ("SUNDAY")]
		public const int Sunday = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='THURSDAY']"
		[Register ("THURSDAY")]
		public const int Thursday = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='TUESDAY']"
		[Register ("TUESDAY")]
		public const int Tuesday = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/field[@name='WEDNESDAY']"
		[Register ("WEDNESDAY")]
		public const int Wednesday = (int) 4;
		// Metadata.xml XPath class reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']"
		[global::Android.Runtime.Register ("sun/util/calendar/BaseCalendar$Date", DoNotGenerateAcw=true)]
		public abstract partial class Date : global::Sun.Util.Calendar.CalendarDate {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("sun/util/calendar/BaseCalendar$Date", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Date); }
			}

			protected Date (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/constructor[@name='BaseCalendar.Date' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe Date ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Date)) {
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

			static IntPtr id_ctor_Ljava_util_TimeZone_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/constructor[@name='BaseCalendar.Date' and count(parameter)=1 and parameter[1][@type='java.util.TimeZone']]"
			[Register (".ctor", "(Ljava/util/TimeZone;)V", "")]
			protected unsafe Date (global::Java.Util.TimeZone zone)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (zone);
					if (((object) this).GetType () != typeof (Date)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/TimeZone;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/TimeZone;)V", __args);
						return;
					}

					if (id_ctor_Ljava_util_TimeZone_ == IntPtr.Zero)
						id_ctor_Ljava_util_TimeZone_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/TimeZone;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_TimeZone_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_TimeZone_, __args);
				} finally {
				}
			}

			static Delegate cb_getCachedJan1;
#pragma warning disable 0169
			static Delegate GetGetCachedJan1Handler ()
			{
				if (cb_getCachedJan1 == null)
					cb_getCachedJan1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCachedJan1);
				return cb_getCachedJan1;
			}

			static long n_GetCachedJan1 (IntPtr jnienv, IntPtr native__this)
			{
				global::Sun.Util.Calendar.BaseCalendar.Date __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar.Date> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CachedJan1;
			}
#pragma warning restore 0169

			static IntPtr id_getCachedJan1;
			protected virtual unsafe long CachedJan1 {
				// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/method[@name='getCachedJan1' and count(parameter)=0]"
				[Register ("getCachedJan1", "()J", "GetGetCachedJan1Handler")]
				get {
					if (id_getCachedJan1 == IntPtr.Zero)
						id_getCachedJan1 = JNIEnv.GetMethodID (class_ref, "getCachedJan1", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCachedJan1);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedJan1", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_getCachedYear;
#pragma warning disable 0169
			static Delegate GetGetCachedYearHandler ()
			{
				if (cb_getCachedYear == null)
					cb_getCachedYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCachedYear);
				return cb_getCachedYear;
			}

			static int n_GetCachedYear (IntPtr jnienv, IntPtr native__this)
			{
				global::Sun.Util.Calendar.BaseCalendar.Date __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar.Date> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CachedYear;
			}
#pragma warning restore 0169

			static IntPtr id_getCachedYear;
			protected virtual unsafe int CachedYear {
				// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/method[@name='getCachedYear' and count(parameter)=0]"
				[Register ("getCachedYear", "()I", "GetGetCachedYearHandler")]
				get {
					if (id_getCachedYear == IntPtr.Zero)
						id_getCachedYear = JNIEnv.GetMethodID (class_ref, "getCachedYear", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCachedYear);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedYear", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getNormalizedYear;
#pragma warning disable 0169
			static Delegate GetGetNormalizedYearHandler ()
			{
				if (cb_getNormalizedYear == null)
					cb_getNormalizedYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNormalizedYear);
				return cb_getNormalizedYear;
			}

			static int n_GetNormalizedYear (IntPtr jnienv, IntPtr native__this)
			{
				global::Sun.Util.Calendar.BaseCalendar.Date __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar.Date> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NormalizedYear;
			}
#pragma warning restore 0169

			static Delegate cb_setNormalizedYear_I;
#pragma warning disable 0169
			static Delegate GetSetNormalizedYear_IHandler ()
			{
				if (cb_setNormalizedYear_I == null)
					cb_setNormalizedYear_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNormalizedYear_I);
				return cb_setNormalizedYear_I;
			}

			static void n_SetNormalizedYear_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Sun.Util.Calendar.BaseCalendar.Date __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar.Date> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.NormalizedYear = p0;
			}
#pragma warning restore 0169

			public abstract int NormalizedYear {
				// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/method[@name='getNormalizedYear' and count(parameter)=0]"
				[Register ("getNormalizedYear", "()I", "GetGetNormalizedYearHandler")] get;
				// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/method[@name='setNormalizedYear' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setNormalizedYear", "(I)V", "GetSetNormalizedYear_IHandler")] set;
			}

			static IntPtr id_hit_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/method[@name='hit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("hit", "(I)Z", "")]
			protected unsafe bool Hit (int year)
			{
				if (id_hit_I == IntPtr.Zero)
					id_hit_I = JNIEnv.GetMethodID (class_ref, "hit", "(I)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (year);
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hit_I, __args);
				} finally {
				}
			}

			static IntPtr id_hit_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/method[@name='hit' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("hit", "(J)Z", "")]
			protected unsafe bool Hit (long fixedDate)
			{
				if (id_hit_J == IntPtr.Zero)
					id_hit_J = JNIEnv.GetMethodID (class_ref, "hit", "(J)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (fixedDate);
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hit_J, __args);
				} finally {
				}
			}

			static Delegate cb_setCache_IJI;
#pragma warning disable 0169
			static Delegate GetSetCache_IJIHandler ()
			{
				if (cb_setCache_IJI == null)
					cb_setCache_IJI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long, int>) n_SetCache_IJI);
				return cb_setCache_IJI;
			}

			static void n_SetCache_IJI (IntPtr jnienv, IntPtr native__this, int year, long jan1, int len)
			{
				global::Sun.Util.Calendar.BaseCalendar.Date __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar.Date> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetCache (year, jan1, len);
			}
#pragma warning restore 0169

			static IntPtr id_setCache_IJI;
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/method[@name='setCache' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
			[Register ("setCache", "(IJI)V", "GetSetCache_IJIHandler")]
			protected virtual unsafe void SetCache (int year, long jan1, int len)
			{
				if (id_setCache_IJI == IntPtr.Zero)
					id_setCache_IJI = JNIEnv.GetMethodID (class_ref, "setCache", "(IJI)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (year);
					__args [1] = new JValue (jan1);
					__args [2] = new JValue (len);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCache_IJI, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCache", "(IJI)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setNormalizedDate_III;
#pragma warning disable 0169
			static Delegate GetSetNormalizedDate_IIIHandler ()
			{
				if (cb_setNormalizedDate_III == null)
					cb_setNormalizedDate_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_SetNormalizedDate_III);
				return cb_setNormalizedDate_III;
			}

			static IntPtr n_SetNormalizedDate_III (IntPtr jnienv, IntPtr native__this, int normalizedYear, int month, int dayOfMonth)
			{
				global::Sun.Util.Calendar.BaseCalendar.Date __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar.Date> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetNormalizedDate (normalizedYear, month, dayOfMonth));
			}
#pragma warning restore 0169

			static IntPtr id_setNormalizedDate_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/method[@name='setNormalizedDate' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("setNormalizedDate", "(III)Lsun/util/calendar/BaseCalendar$Date;", "GetSetNormalizedDate_IIIHandler")]
			public virtual unsafe global::Sun.Util.Calendar.BaseCalendar.Date SetNormalizedDate (int normalizedYear, int month, int dayOfMonth)
			{
				if (id_setNormalizedDate_III == IntPtr.Zero)
					id_setNormalizedDate_III = JNIEnv.GetMethodID (class_ref, "setNormalizedDate", "(III)Lsun/util/calendar/BaseCalendar$Date;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (normalizedYear);
					__args [1] = new JValue (month);
					__args [2] = new JValue (dayOfMonth);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNormalizedDate_III, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNormalizedDate", "(III)Lsun/util/calendar/BaseCalendar$Date;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("sun/util/calendar/BaseCalendar$Date", DoNotGenerateAcw=true)]
		internal partial class DateInvoker : Date {

			public DateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (DateInvoker); }
			}

			static IntPtr id_getNormalizedYear;
			static IntPtr id_setNormalizedYear_I;
			public override unsafe int NormalizedYear {
				// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/method[@name='getNormalizedYear' and count(parameter)=0]"
				[Register ("getNormalizedYear", "()I", "GetGetNormalizedYearHandler")]
				get {
					if (id_getNormalizedYear == IntPtr.Zero)
						id_getNormalizedYear = JNIEnv.GetMethodID (class_ref, "getNormalizedYear", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNormalizedYear);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar.Date']/method[@name='setNormalizedYear' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setNormalizedYear", "(I)V", "GetSetNormalizedYear_IHandler")]
				set {
					if (id_setNormalizedYear_I == IntPtr.Zero)
						id_setNormalizedYear_I = JNIEnv.GetMethodID (class_ref, "setNormalizedYear", "(I)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNormalizedYear_I, __args);
					} finally {
					}
				}
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/util/calendar/BaseCalendar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseCalendar); }
		}

		protected BaseCalendar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/constructor[@name='BaseCalendar' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseCalendar ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseCalendar)) {
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

		static Delegate cb_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J;
#pragma warning disable 0169
		static Delegate GetGetCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_JHandler ()
		{
			if (cb_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J == null)
				cb_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_GetCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J);
			return cb_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J;
		}

		static void n_GetCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J (IntPtr jnienv, IntPtr native__this, IntPtr native_date, long fixedDate)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.GetCalendarDateFromFixedDate (date, fixedDate);
		}
#pragma warning restore 0169

		static IntPtr id_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='getCalendarDateFromFixedDate' and count(parameter)=2 and parameter[1][@type='sun.util.calendar.CalendarDate'] and parameter[2][@type='long']]"
		[Register ("getCalendarDateFromFixedDate", "(Lsun/util/calendar/CalendarDate;J)V", "GetGetCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_JHandler")]
		protected override unsafe void GetCalendarDateFromFixedDate (global::Sun.Util.Calendar.CalendarDate date, long fixedDate)
		{
			if (id_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J == IntPtr.Zero)
				id_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J = JNIEnv.GetMethodID (class_ref, "getCalendarDateFromFixedDate", "(Lsun/util/calendar/CalendarDate;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (date);
				__args [1] = new JValue (fixedDate);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarDateFromFixedDate_Lsun_util_calendar_CalendarDate_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalendarDateFromFixedDate", "(Lsun/util/calendar/CalendarDate;J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getDayOfWeek_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetDayOfWeek_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getDayOfWeek_Lsun_util_calendar_CalendarDate_ == null)
				cb_getDayOfWeek_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetDayOfWeek_Lsun_util_calendar_CalendarDate_);
			return cb_getDayOfWeek_Lsun_util_calendar_CalendarDate_;
		}

		static int n_GetDayOfWeek_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetDayOfWeek (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDayOfWeek_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='getDayOfWeek' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getDayOfWeek", "(Lsun/util/calendar/CalendarDate;)I", "GetGetDayOfWeek_Lsun_util_calendar_CalendarDate_Handler")]
		public virtual unsafe int GetDayOfWeek (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getDayOfWeek_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getDayOfWeek_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getDayOfWeek", "(Lsun/util/calendar/CalendarDate;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDayOfWeek_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDayOfWeek", "(Lsun/util/calendar/CalendarDate;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDayOfWeekFromFixedDate_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='getDayOfWeekFromFixedDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getDayOfWeekFromFixedDate", "(J)I", "")]
		public static unsafe int GetDayOfWeekFromFixedDate (long fixedDate)
		{
			if (id_getDayOfWeekFromFixedDate_J == IntPtr.Zero)
				id_getDayOfWeekFromFixedDate_J = JNIEnv.GetStaticMethodID (class_ref, "getDayOfWeekFromFixedDate", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (fixedDate);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getDayOfWeekFromFixedDate_J, __args);
			} finally {
			}
		}

		static Delegate cb_getDayOfYear_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetDayOfYear_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getDayOfYear_Lsun_util_calendar_CalendarDate_ == null)
				cb_getDayOfYear_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetDayOfYear_Lsun_util_calendar_CalendarDate_);
			return cb_getDayOfYear_Lsun_util_calendar_CalendarDate_;
		}

		static long n_GetDayOfYear_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetDayOfYear (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDayOfYear_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='getDayOfYear' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getDayOfYear", "(Lsun/util/calendar/CalendarDate;)J", "GetGetDayOfYear_Lsun_util_calendar_CalendarDate_Handler")]
		public virtual unsafe long GetDayOfYear (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getDayOfYear_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getDayOfYear_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getDayOfYear", "(Lsun/util/calendar/CalendarDate;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDayOfYear_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDayOfYear", "(Lsun/util/calendar/CalendarDate;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getFixedDate_IIILsun_util_calendar_BaseCalendar_Date_;
#pragma warning disable 0169
		static Delegate GetGetFixedDate_IIILsun_util_calendar_BaseCalendar_Date_Handler ()
		{
			if (cb_getFixedDate_IIILsun_util_calendar_BaseCalendar_Date_ == null)
				cb_getFixedDate_IIILsun_util_calendar_BaseCalendar_Date_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, long>) n_GetFixedDate_IIILsun_util_calendar_BaseCalendar_Date_);
			return cb_getFixedDate_IIILsun_util_calendar_BaseCalendar_Date_;
		}

		static long n_GetFixedDate_IIILsun_util_calendar_BaseCalendar_Date_ (IntPtr jnienv, IntPtr native__this, int year, int month, int dayOfMonth, IntPtr native_cache)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.BaseCalendar.Date cache = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar.Date> (native_cache, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetFixedDate (year, month, dayOfMonth, cache);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFixedDate_IIILsun_util_calendar_BaseCalendar_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='getFixedDate' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='sun.util.calendar.BaseCalendar.Date']]"
		[Register ("getFixedDate", "(IIILsun/util/calendar/BaseCalendar$Date;)J", "GetGetFixedDate_IIILsun_util_calendar_BaseCalendar_Date_Handler")]
		protected virtual unsafe long GetFixedDate (int year, int month, int dayOfMonth, global::Sun.Util.Calendar.BaseCalendar.Date cache)
		{
			if (id_getFixedDate_IIILsun_util_calendar_BaseCalendar_Date_ == IntPtr.Zero)
				id_getFixedDate_IIILsun_util_calendar_BaseCalendar_Date_ = JNIEnv.GetMethodID (class_ref, "getFixedDate", "(IIILsun/util/calendar/BaseCalendar$Date;)J");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (year);
				__args [1] = new JValue (month);
				__args [2] = new JValue (dayOfMonth);
				__args [3] = new JValue (cache);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getFixedDate_IIILsun_util_calendar_BaseCalendar_Date_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFixedDate", "(IIILsun/util/calendar/BaseCalendar$Date;)J"), __args);
				return __ret;
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

		static long n_GetFixedDate_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetFixedDate (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFixedDate_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='getFixedDate' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getFixedDate", "(Lsun/util/calendar/CalendarDate;)J", "GetGetFixedDate_Lsun_util_calendar_CalendarDate_Handler")]
		protected override unsafe long GetFixedDate (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getFixedDate_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getFixedDate_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getFixedDate", "(Lsun/util/calendar/CalendarDate;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getFixedDate_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFixedDate", "(Lsun/util/calendar/CalendarDate;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMonthLength_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetMonthLength_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getMonthLength_Lsun_util_calendar_CalendarDate_ == null)
				cb_getMonthLength_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetMonthLength_Lsun_util_calendar_CalendarDate_);
			return cb_getMonthLength_Lsun_util_calendar_CalendarDate_;
		}

		static int n_GetMonthLength_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetMonthLength (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMonthLength_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='getMonthLength' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getMonthLength", "(Lsun/util/calendar/CalendarDate;)I", "GetGetMonthLength_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe int GetMonthLength (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getMonthLength_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getMonthLength_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getMonthLength", "(Lsun/util/calendar/CalendarDate;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMonthLength_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMonthLength", "(Lsun/util/calendar/CalendarDate;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getYearFromFixedDate_J;
#pragma warning disable 0169
		static Delegate GetGetYearFromFixedDate_JHandler ()
		{
			if (cb_getYearFromFixedDate_J == null)
				cb_getYearFromFixedDate_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_GetYearFromFixedDate_J);
			return cb_getYearFromFixedDate_J;
		}

		static int n_GetYearFromFixedDate_J (IntPtr jnienv, IntPtr native__this, long fixedDate)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetYearFromFixedDate (fixedDate);
		}
#pragma warning restore 0169

		static IntPtr id_getYearFromFixedDate_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='getYearFromFixedDate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getYearFromFixedDate", "(J)I", "GetGetYearFromFixedDate_JHandler")]
		public virtual unsafe int GetYearFromFixedDate (long fixedDate)
		{
			if (id_getYearFromFixedDate_J == IntPtr.Zero)
				id_getYearFromFixedDate_J = JNIEnv.GetMethodID (class_ref, "getYearFromFixedDate", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (fixedDate);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYearFromFixedDate_J, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYearFromFixedDate", "(J)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getYearLength_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetYearLength_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getYearLength_Lsun_util_calendar_CalendarDate_ == null)
				cb_getYearLength_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetYearLength_Lsun_util_calendar_CalendarDate_);
			return cb_getYearLength_Lsun_util_calendar_CalendarDate_;
		}

		static int n_GetYearLength_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetYearLength (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getYearLength_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='getYearLength' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getYearLength", "(Lsun/util/calendar/CalendarDate;)I", "GetGetYearLength_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe int GetYearLength (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getYearLength_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getYearLength_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getYearLength", "(Lsun/util/calendar/CalendarDate;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYearLength_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYearLength", "(Lsun/util/calendar/CalendarDate;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetGetYearLengthInMonths_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_ == null)
				cb_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetYearLengthInMonths_Lsun_util_calendar_CalendarDate_);
			return cb_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_;
		}

		static int n_GetYearLengthInMonths_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetYearLengthInMonths (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='getYearLengthInMonths' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("getYearLengthInMonths", "(Lsun/util/calendar/CalendarDate;)I", "GetGetYearLengthInMonths_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe int GetYearLengthInMonths (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "getYearLengthInMonths", "(Lsun/util/calendar/CalendarDate;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYearLengthInMonths_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYearLengthInMonths", "(Lsun/util/calendar/CalendarDate;)I"), __args);
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

		static bool n_IsLeapYear_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsLeapYear (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isLeapYear_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='isLeapYear' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("isLeapYear", "(Lsun/util/calendar/CalendarDate;)Z", "GetIsLeapYear_Lsun_util_calendar_CalendarDate_Handler")]
		protected override unsafe bool IsLeapYear (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_isLeapYear_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_isLeapYear_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "isLeapYear", "(Lsun/util/calendar/CalendarDate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLeapYear_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLeapYear", "(Lsun/util/calendar/CalendarDate;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_normalize_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetNormalize_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_normalize_Lsun_util_calendar_CalendarDate_ == null)
				cb_normalize_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Normalize_Lsun_util_calendar_CalendarDate_);
			return cb_normalize_Lsun_util_calendar_CalendarDate_;
		}

		static bool n_Normalize_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Normalize (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_normalize_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='normalize' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("normalize", "(Lsun/util/calendar/CalendarDate;)Z", "GetNormalize_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe bool Normalize (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_normalize_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_normalize_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "normalize", "(Lsun/util/calendar/CalendarDate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_normalize_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalize", "(Lsun/util/calendar/CalendarDate;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_validate_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetValidate_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_validate_Lsun_util_calendar_CalendarDate_ == null)
				cb_validate_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Validate_Lsun_util_calendar_CalendarDate_);
			return cb_validate_Lsun_util_calendar_CalendarDate_;
		}

		static bool n_Validate_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.BaseCalendar __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.BaseCalendar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Validate (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_validate_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='BaseCalendar']/method[@name='validate' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("validate", "(Lsun/util/calendar/CalendarDate;)Z", "GetValidate_Lsun_util_calendar_CalendarDate_Handler")]
		public override unsafe bool Validate (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_validate_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_validate_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "validate", "(Lsun/util/calendar/CalendarDate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_validate_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "validate", "(Lsun/util/calendar/CalendarDate;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("sun/util/calendar/BaseCalendar", DoNotGenerateAcw=true)]
	internal partial class BaseCalendarInvoker : BaseCalendar {

		public BaseCalendarInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseCalendarInvoker); }
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

	}

}
