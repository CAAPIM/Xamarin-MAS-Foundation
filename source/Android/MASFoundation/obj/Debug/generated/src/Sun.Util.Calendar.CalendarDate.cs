using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Util.Calendar {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']"
	[global::Android.Runtime.Register ("sun/util/calendar/CalendarDate", DoNotGenerateAcw=true)]
	public abstract partial class CalendarDate : global::Java.Lang.Object, global::Java.Lang.ICloneable {


		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/field[@name='FIELD_UNDEFINED']"
		[Register ("FIELD_UNDEFINED")]
		public const int FieldUndefined = (int) -2147483648;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/field[@name='TIME_UNDEFINED']"
		[Register ("TIME_UNDEFINED")]
		public const long TimeUndefined = (long) -9223372036854775808;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/util/calendar/CalendarDate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalendarDate); }
		}

		protected CalendarDate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/constructor[@name='CalendarDate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe CalendarDate ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CalendarDate)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/constructor[@name='CalendarDate' and count(parameter)=1 and parameter[1][@type='java.util.TimeZone']]"
		[Register (".ctor", "(Ljava/util/TimeZone;)V", "")]
		protected unsafe CalendarDate (global::Java.Util.TimeZone zone)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (zone);
				if (((object) this).GetType () != typeof (CalendarDate)) {
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

		static Delegate cb_getDayOfMonth;
#pragma warning disable 0169
		static Delegate GetGetDayOfMonthHandler ()
		{
			if (cb_getDayOfMonth == null)
				cb_getDayOfMonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDayOfMonth);
			return cb_getDayOfMonth;
		}

		static int n_GetDayOfMonth (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DayOfMonth;
		}
#pragma warning restore 0169

		static IntPtr id_getDayOfMonth;
		public virtual unsafe int DayOfMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getDayOfMonth' and count(parameter)=0]"
			[Register ("getDayOfMonth", "()I", "GetGetDayOfMonthHandler")]
			get {
				if (id_getDayOfMonth == IntPtr.Zero)
					id_getDayOfMonth = JNIEnv.GetMethodID (class_ref, "getDayOfMonth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDayOfMonth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDayOfMonth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDayOfWeek;
#pragma warning disable 0169
		static Delegate GetGetDayOfWeekHandler ()
		{
			if (cb_getDayOfWeek == null)
				cb_getDayOfWeek = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDayOfWeek);
			return cb_getDayOfWeek;
		}

		static int n_GetDayOfWeek (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DayOfWeek;
		}
#pragma warning restore 0169

		static IntPtr id_getDayOfWeek;
		public virtual unsafe int DayOfWeek {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getDayOfWeek' and count(parameter)=0]"
			[Register ("getDayOfWeek", "()I", "GetGetDayOfWeekHandler")]
			get {
				if (id_getDayOfWeek == IntPtr.Zero)
					id_getDayOfWeek = JNIEnv.GetMethodID (class_ref, "getDayOfWeek", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDayOfWeek);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDayOfWeek", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDaylightSaving;
#pragma warning disable 0169
		static Delegate GetGetDaylightSavingHandler ()
		{
			if (cb_getDaylightSaving == null)
				cb_getDaylightSaving = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDaylightSaving);
			return cb_getDaylightSaving;
		}

		static int n_GetDaylightSaving (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DaylightSaving;
		}
#pragma warning restore 0169

		static IntPtr id_getDaylightSaving;
		public virtual unsafe int DaylightSaving {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getDaylightSaving' and count(parameter)=0]"
			[Register ("getDaylightSaving", "()I", "GetGetDaylightSavingHandler")]
			get {
				if (id_getDaylightSaving == IntPtr.Zero)
					id_getDaylightSaving = JNIEnv.GetMethodID (class_ref, "getDaylightSaving", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDaylightSaving);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDaylightSaving", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getEra;
#pragma warning disable 0169
		static Delegate GetGetEraHandler ()
		{
			if (cb_getEra == null)
				cb_getEra = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEra);
			return cb_getEra;
		}

		static IntPtr n_GetEra (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Era);
		}
#pragma warning restore 0169

		static IntPtr id_getEra;
		public virtual unsafe global::Sun.Util.Calendar.Era Era {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getEra' and count(parameter)=0]"
			[Register ("getEra", "()Lsun/util/calendar/Era;", "GetGetEraHandler")]
			get {
				if (id_getEra == IntPtr.Zero)
					id_getEra = JNIEnv.GetMethodID (class_ref, "getEra", "()Lsun/util/calendar/Era;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.Era> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEra), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.Era> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEra", "()Lsun/util/calendar/Era;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHours;
#pragma warning disable 0169
		static Delegate GetGetHoursHandler ()
		{
			if (cb_getHours == null)
				cb_getHours = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHours);
			return cb_getHours;
		}

		static int n_GetHours (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Hours;
		}
#pragma warning restore 0169

		static IntPtr id_getHours;
		public virtual unsafe int Hours {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getHours' and count(parameter)=0]"
			[Register ("getHours", "()I", "GetGetHoursHandler")]
			get {
				if (id_getHours == IntPtr.Zero)
					id_getHours = JNIEnv.GetMethodID (class_ref, "getHours", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHours);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHours", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isDaylightTime;
#pragma warning disable 0169
		static Delegate GetIsDaylightTimeHandler ()
		{
			if (cb_isDaylightTime == null)
				cb_isDaylightTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDaylightTime);
			return cb_isDaylightTime;
		}

		static bool n_IsDaylightTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDaylightTime;
		}
#pragma warning restore 0169

		static IntPtr id_isDaylightTime;
		public virtual unsafe bool IsDaylightTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='isDaylightTime' and count(parameter)=0]"
			[Register ("isDaylightTime", "()Z", "GetIsDaylightTimeHandler")]
			get {
				if (id_isDaylightTime == IntPtr.Zero)
					id_isDaylightTime = JNIEnv.GetMethodID (class_ref, "isDaylightTime", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDaylightTime);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDaylightTime", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLeapYear;
#pragma warning disable 0169
		static Delegate GetIsLeapYearHandler ()
		{
			if (cb_isLeapYear == null)
				cb_isLeapYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLeapYear);
			return cb_isLeapYear;
		}

		static bool n_IsLeapYear (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLeapYear;
		}
#pragma warning restore 0169

		static IntPtr id_isLeapYear;
		public virtual unsafe bool IsLeapYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='isLeapYear' and count(parameter)=0]"
			[Register ("isLeapYear", "()Z", "GetIsLeapYearHandler")]
			get {
				if (id_isLeapYear == IntPtr.Zero)
					id_isLeapYear = JNIEnv.GetMethodID (class_ref, "isLeapYear", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLeapYear);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLeapYear", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isNormalized;
#pragma warning disable 0169
		static Delegate GetIsNormalizedHandler ()
		{
			if (cb_isNormalized == null)
				cb_isNormalized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNormalized);
			return cb_isNormalized;
		}

		static bool n_IsNormalized (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNormalized;
		}
#pragma warning restore 0169

		static IntPtr id_isNormalized;
		public virtual unsafe bool IsNormalized {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='isNormalized' and count(parameter)=0]"
			[Register ("isNormalized", "()Z", "GetIsNormalizedHandler")]
			get {
				if (id_isNormalized == IntPtr.Zero)
					id_isNormalized = JNIEnv.GetMethodID (class_ref, "isNormalized", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNormalized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNormalized", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMillis;
#pragma warning disable 0169
		static Delegate GetGetMillisHandler ()
		{
			if (cb_getMillis == null)
				cb_getMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMillis);
			return cb_getMillis;
		}

		static int n_GetMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Millis;
		}
#pragma warning restore 0169

		static IntPtr id_getMillis;
		public virtual unsafe int Millis {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getMillis' and count(parameter)=0]"
			[Register ("getMillis", "()I", "GetGetMillisHandler")]
			get {
				if (id_getMillis == IntPtr.Zero)
					id_getMillis = JNIEnv.GetMethodID (class_ref, "getMillis", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMillis);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMillis", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMinutes;
#pragma warning disable 0169
		static Delegate GetGetMinutesHandler ()
		{
			if (cb_getMinutes == null)
				cb_getMinutes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinutes);
			return cb_getMinutes;
		}

		static int n_GetMinutes (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Minutes;
		}
#pragma warning restore 0169

		static IntPtr id_getMinutes;
		public virtual unsafe int Minutes {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getMinutes' and count(parameter)=0]"
			[Register ("getMinutes", "()I", "GetGetMinutesHandler")]
			get {
				if (id_getMinutes == IntPtr.Zero)
					id_getMinutes = JNIEnv.GetMethodID (class_ref, "getMinutes", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMinutes);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinutes", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMonth;
#pragma warning disable 0169
		static Delegate GetGetMonthHandler ()
		{
			if (cb_getMonth == null)
				cb_getMonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMonth);
			return cb_getMonth;
		}

		static int n_GetMonth (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Month;
		}
#pragma warning restore 0169

		static IntPtr id_getMonth;
		public virtual unsafe int Month {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getMonth' and count(parameter)=0]"
			[Register ("getMonth", "()I", "GetGetMonthHandler")]
			get {
				if (id_getMonth == IntPtr.Zero)
					id_getMonth = JNIEnv.GetMethodID (class_ref, "getMonth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMonth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMonth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSeconds;
#pragma warning disable 0169
		static Delegate GetGetSecondsHandler ()
		{
			if (cb_getSeconds == null)
				cb_getSeconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSeconds);
			return cb_getSeconds;
		}

		static int n_GetSeconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Seconds;
		}
#pragma warning restore 0169

		static IntPtr id_getSeconds;
		public virtual unsafe int Seconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getSeconds' and count(parameter)=0]"
			[Register ("getSeconds", "()I", "GetGetSecondsHandler")]
			get {
				if (id_getSeconds == IntPtr.Zero)
					id_getSeconds = JNIEnv.GetMethodID (class_ref, "getSeconds", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSeconds);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeconds", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isStandardTime;
#pragma warning disable 0169
		static Delegate GetIsStandardTimeHandler ()
		{
			if (cb_isStandardTime == null)
				cb_isStandardTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStandardTime);
			return cb_isStandardTime;
		}

		static bool n_IsStandardTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StandardTime;
		}
#pragma warning restore 0169

		static Delegate cb_setStandardTime_Z;
#pragma warning disable 0169
		static Delegate GetSetStandardTime_ZHandler ()
		{
			if (cb_setStandardTime_Z == null)
				cb_setStandardTime_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetStandardTime_Z);
			return cb_setStandardTime_Z;
		}

		static void n_SetStandardTime_Z (IntPtr jnienv, IntPtr native__this, bool standardTime)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StandardTime = standardTime;
		}
#pragma warning restore 0169

		static IntPtr id_isStandardTime;
		static IntPtr id_setStandardTime_Z;
		public virtual unsafe bool StandardTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='isStandardTime' and count(parameter)=0]"
			[Register ("isStandardTime", "()Z", "GetIsStandardTimeHandler")]
			get {
				if (id_isStandardTime == IntPtr.Zero)
					id_isStandardTime = JNIEnv.GetMethodID (class_ref, "isStandardTime", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStandardTime);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStandardTime", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setStandardTime' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStandardTime", "(Z)V", "GetSetStandardTime_ZHandler")]
			set {
				if (id_setStandardTime_Z == IntPtr.Zero)
					id_setStandardTime_Z = JNIEnv.GetMethodID (class_ref, "setStandardTime", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStandardTime_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStandardTime", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeOfDay;
#pragma warning disable 0169
		static Delegate GetGetTimeOfDayHandler ()
		{
			if (cb_getTimeOfDay == null)
				cb_getTimeOfDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeOfDay);
			return cb_getTimeOfDay;
		}

		static long n_GetTimeOfDay (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeOfDay;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeOfDay;
		public virtual unsafe long TimeOfDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getTimeOfDay' and count(parameter)=0]"
			[Register ("getTimeOfDay", "()J", "GetGetTimeOfDayHandler")]
			get {
				if (id_getTimeOfDay == IntPtr.Zero)
					id_getTimeOfDay = JNIEnv.GetMethodID (class_ref, "getTimeOfDay", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeOfDay);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeOfDay", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getYear;
#pragma warning disable 0169
		static Delegate GetGetYearHandler ()
		{
			if (cb_getYear == null)
				cb_getYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYear);
			return cb_getYear;
		}

		static int n_GetYear (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Year;
		}
#pragma warning restore 0169

		static IntPtr id_getYear;
		public virtual unsafe int Year {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getYear' and count(parameter)=0]"
			[Register ("getYear", "()I", "GetGetYearHandler")]
			get {
				if (id_getYear == IntPtr.Zero)
					id_getYear = JNIEnv.GetMethodID (class_ref, "getYear", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYear);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYear", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getZone;
#pragma warning disable 0169
		static Delegate GetGetZoneHandler ()
		{
			if (cb_getZone == null)
				cb_getZone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZone);
			return cb_getZone;
		}

		static IntPtr n_GetZone (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Zone);
		}
#pragma warning restore 0169

		static IntPtr id_getZone;
		public virtual unsafe global::Java.Util.TimeZone Zone {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getZone' and count(parameter)=0]"
			[Register ("getZone", "()Ljava/util/TimeZone;", "GetGetZoneHandler")]
			get {
				if (id_getZone == IntPtr.Zero)
					id_getZone = JNIEnv.GetMethodID (class_ref, "getZone", "()Ljava/util/TimeZone;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getZone), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZone", "()Ljava/util/TimeZone;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getZoneOffset;
#pragma warning disable 0169
		static Delegate GetGetZoneOffsetHandler ()
		{
			if (cb_getZoneOffset == null)
				cb_getZoneOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZoneOffset);
			return cb_getZoneOffset;
		}

		static int n_GetZoneOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoneOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getZoneOffset;
		public virtual unsafe int ZoneOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='getZoneOffset' and count(parameter)=0]"
			[Register ("getZoneOffset", "()I", "GetGetZoneOffsetHandler")]
			get {
				if (id_getZoneOffset == IntPtr.Zero)
					id_getZoneOffset = JNIEnv.GetMethodID (class_ref, "getZoneOffset", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getZoneOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoneOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_addDate_III;
#pragma warning disable 0169
		static Delegate GetAddDate_IIIHandler ()
		{
			if (cb_addDate_III == null)
				cb_addDate_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_AddDate_III);
			return cb_addDate_III;
		}

		static IntPtr n_AddDate_III (IntPtr jnienv, IntPtr native__this, int year, int month, int dayOfMonth)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddDate (year, month, dayOfMonth));
		}
#pragma warning restore 0169

		static IntPtr id_addDate_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='addDate' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("addDate", "(III)Lsun/util/calendar/CalendarDate;", "GetAddDate_IIIHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate AddDate (int year, int month, int dayOfMonth)
		{
			if (id_addDate_III == IntPtr.Zero)
				id_addDate_III = JNIEnv.GetMethodID (class_ref, "addDate", "(III)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (year);
				__args [1] = new JValue (month);
				__args [2] = new JValue (dayOfMonth);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addDate_III, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDate", "(III)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addDayOfMonth_I;
#pragma warning disable 0169
		static Delegate GetAddDayOfMonth_IHandler ()
		{
			if (cb_addDayOfMonth_I == null)
				cb_addDayOfMonth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AddDayOfMonth_I);
			return cb_addDayOfMonth_I;
		}

		static IntPtr n_AddDayOfMonth_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddDayOfMonth (n));
		}
#pragma warning restore 0169

		static IntPtr id_addDayOfMonth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='addDayOfMonth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addDayOfMonth", "(I)Lsun/util/calendar/CalendarDate;", "GetAddDayOfMonth_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate AddDayOfMonth (int n)
		{
			if (id_addDayOfMonth_I == IntPtr.Zero)
				id_addDayOfMonth_I = JNIEnv.GetMethodID (class_ref, "addDayOfMonth", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (n);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addDayOfMonth_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDayOfMonth", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addHours_I;
#pragma warning disable 0169
		static Delegate GetAddHours_IHandler ()
		{
			if (cb_addHours_I == null)
				cb_addHours_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AddHours_I);
			return cb_addHours_I;
		}

		static IntPtr n_AddHours_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddHours (n));
		}
#pragma warning restore 0169

		static IntPtr id_addHours_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='addHours' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addHours", "(I)Lsun/util/calendar/CalendarDate;", "GetAddHours_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate AddHours (int n)
		{
			if (id_addHours_I == IntPtr.Zero)
				id_addHours_I = JNIEnv.GetMethodID (class_ref, "addHours", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (n);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addHours_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHours", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addMillis_I;
#pragma warning disable 0169
		static Delegate GetAddMillis_IHandler ()
		{
			if (cb_addMillis_I == null)
				cb_addMillis_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AddMillis_I);
			return cb_addMillis_I;
		}

		static IntPtr n_AddMillis_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddMillis (n));
		}
#pragma warning restore 0169

		static IntPtr id_addMillis_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='addMillis' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addMillis", "(I)Lsun/util/calendar/CalendarDate;", "GetAddMillis_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate AddMillis (int n)
		{
			if (id_addMillis_I == IntPtr.Zero)
				id_addMillis_I = JNIEnv.GetMethodID (class_ref, "addMillis", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (n);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMillis_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMillis", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addMinutes_I;
#pragma warning disable 0169
		static Delegate GetAddMinutes_IHandler ()
		{
			if (cb_addMinutes_I == null)
				cb_addMinutes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AddMinutes_I);
			return cb_addMinutes_I;
		}

		static IntPtr n_AddMinutes_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddMinutes (n));
		}
#pragma warning restore 0169

		static IntPtr id_addMinutes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='addMinutes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addMinutes", "(I)Lsun/util/calendar/CalendarDate;", "GetAddMinutes_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate AddMinutes (int n)
		{
			if (id_addMinutes_I == IntPtr.Zero)
				id_addMinutes_I = JNIEnv.GetMethodID (class_ref, "addMinutes", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (n);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMinutes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMinutes", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addMonth_I;
#pragma warning disable 0169
		static Delegate GetAddMonth_IHandler ()
		{
			if (cb_addMonth_I == null)
				cb_addMonth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AddMonth_I);
			return cb_addMonth_I;
		}

		static IntPtr n_AddMonth_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddMonth (n));
		}
#pragma warning restore 0169

		static IntPtr id_addMonth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='addMonth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addMonth", "(I)Lsun/util/calendar/CalendarDate;", "GetAddMonth_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate AddMonth (int n)
		{
			if (id_addMonth_I == IntPtr.Zero)
				id_addMonth_I = JNIEnv.GetMethodID (class_ref, "addMonth", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (n);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMonth_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMonth", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addSeconds_I;
#pragma warning disable 0169
		static Delegate GetAddSeconds_IHandler ()
		{
			if (cb_addSeconds_I == null)
				cb_addSeconds_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AddSeconds_I);
			return cb_addSeconds_I;
		}

		static IntPtr n_AddSeconds_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddSeconds (n));
		}
#pragma warning restore 0169

		static IntPtr id_addSeconds_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='addSeconds' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addSeconds", "(I)Lsun/util/calendar/CalendarDate;", "GetAddSeconds_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate AddSeconds (int n)
		{
			if (id_addSeconds_I == IntPtr.Zero)
				id_addSeconds_I = JNIEnv.GetMethodID (class_ref, "addSeconds", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (n);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addSeconds_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSeconds", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addTimeOfDay_IIII;
#pragma warning disable 0169
		static Delegate GetAddTimeOfDay_IIIIHandler ()
		{
			if (cb_addTimeOfDay_IIII == null)
				cb_addTimeOfDay_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_AddTimeOfDay_IIII);
			return cb_addTimeOfDay_IIII;
		}

		static IntPtr n_AddTimeOfDay_IIII (IntPtr jnienv, IntPtr native__this, int hours, int minutes, int seconds, int millis)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddTimeOfDay (hours, minutes, seconds, millis));
		}
#pragma warning restore 0169

		static IntPtr id_addTimeOfDay_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='addTimeOfDay' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("addTimeOfDay", "(IIII)Lsun/util/calendar/CalendarDate;", "GetAddTimeOfDay_IIIIHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate AddTimeOfDay (int hours, int minutes, int seconds, int millis)
		{
			if (id_addTimeOfDay_IIII == IntPtr.Zero)
				id_addTimeOfDay_IIII = JNIEnv.GetMethodID (class_ref, "addTimeOfDay", "(IIII)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (hours);
				__args [1] = new JValue (minutes);
				__args [2] = new JValue (seconds);
				__args [3] = new JValue (millis);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addTimeOfDay_IIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTimeOfDay", "(IIII)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addYear_I;
#pragma warning disable 0169
		static Delegate GetAddYear_IHandler ()
		{
			if (cb_addYear_I == null)
				cb_addYear_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AddYear_I);
			return cb_addYear_I;
		}

		static IntPtr n_AddYear_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddYear (n));
		}
#pragma warning restore 0169

		static IntPtr id_addYear_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='addYear' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addYear", "(I)Lsun/util/calendar/CalendarDate;", "GetAddYear_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate AddYear (int n)
		{
			if (id_addYear_I == IntPtr.Zero)
				id_addYear_I = JNIEnv.GetMethodID (class_ref, "addYear", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (n);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addYear_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addYear", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='clone' and count(parameter)=0]"
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

		static Delegate cb_isSameDate_Lsun_util_calendar_CalendarDate_;
#pragma warning disable 0169
		static Delegate GetIsSameDate_Lsun_util_calendar_CalendarDate_Handler ()
		{
			if (cb_isSameDate_Lsun_util_calendar_CalendarDate_ == null)
				cb_isSameDate_Lsun_util_calendar_CalendarDate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSameDate_Lsun_util_calendar_CalendarDate_);
			return cb_isSameDate_Lsun_util_calendar_CalendarDate_;
		}

		static bool n_IsSameDate_Lsun_util_calendar_CalendarDate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.CalendarDate date = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (native_date, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSameDate (date);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSameDate_Lsun_util_calendar_CalendarDate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='isSameDate' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.CalendarDate']]"
		[Register ("isSameDate", "(Lsun/util/calendar/CalendarDate;)Z", "GetIsSameDate_Lsun_util_calendar_CalendarDate_Handler")]
		public virtual unsafe bool IsSameDate (global::Sun.Util.Calendar.CalendarDate date)
		{
			if (id_isSameDate_Lsun_util_calendar_CalendarDate_ == IntPtr.Zero)
				id_isSameDate_Lsun_util_calendar_CalendarDate_ = JNIEnv.GetMethodID (class_ref, "isSameDate", "(Lsun/util/calendar/CalendarDate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSameDate_Lsun_util_calendar_CalendarDate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSameDate", "(Lsun/util/calendar/CalendarDate;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDate_III;
#pragma warning disable 0169
		static Delegate GetSetDate_IIIHandler ()
		{
			if (cb_setDate_III == null)
				cb_setDate_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_SetDate_III);
			return cb_setDate_III;
		}

		static IntPtr n_SetDate_III (IntPtr jnienv, IntPtr native__this, int year, int month, int dayOfMonth)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDate (year, month, dayOfMonth));
		}
#pragma warning restore 0169

		static IntPtr id_setDate_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setDate' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setDate", "(III)Lsun/util/calendar/CalendarDate;", "GetSetDate_IIIHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetDate (int year, int month, int dayOfMonth)
		{
			if (id_setDate_III == IntPtr.Zero)
				id_setDate_III = JNIEnv.GetMethodID (class_ref, "setDate", "(III)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (year);
				__args [1] = new JValue (month);
				__args [2] = new JValue (dayOfMonth);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDate_III, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDate", "(III)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDayOfMonth_I;
#pragma warning disable 0169
		static Delegate GetSetDayOfMonth_IHandler ()
		{
			if (cb_setDayOfMonth_I == null)
				cb_setDayOfMonth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetDayOfMonth_I);
			return cb_setDayOfMonth_I;
		}

		static IntPtr n_SetDayOfMonth_I (IntPtr jnienv, IntPtr native__this, int date)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDayOfMonth (date));
		}
#pragma warning restore 0169

		static IntPtr id_setDayOfMonth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setDayOfMonth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDayOfMonth", "(I)Lsun/util/calendar/CalendarDate;", "GetSetDayOfMonth_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetDayOfMonth (int date)
		{
			if (id_setDayOfMonth_I == IntPtr.Zero)
				id_setDayOfMonth_I = JNIEnv.GetMethodID (class_ref, "setDayOfMonth", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDayOfMonth_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDayOfMonth", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDayOfWeek_I;
#pragma warning disable 0169
		static Delegate GetSetDayOfWeek_IHandler ()
		{
			if (cb_setDayOfWeek_I == null)
				cb_setDayOfWeek_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDayOfWeek_I);
			return cb_setDayOfWeek_I;
		}

		static void n_SetDayOfWeek_I (IntPtr jnienv, IntPtr native__this, int dayOfWeek)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDayOfWeek (dayOfWeek);
		}
#pragma warning restore 0169

		static IntPtr id_setDayOfWeek_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setDayOfWeek' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDayOfWeek", "(I)V", "GetSetDayOfWeek_IHandler")]
		protected virtual unsafe void SetDayOfWeek (int dayOfWeek)
		{
			if (id_setDayOfWeek_I == IntPtr.Zero)
				id_setDayOfWeek_I = JNIEnv.GetMethodID (class_ref, "setDayOfWeek", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dayOfWeek);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDayOfWeek_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDayOfWeek", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDaylightSaving_I;
#pragma warning disable 0169
		static Delegate GetSetDaylightSaving_IHandler ()
		{
			if (cb_setDaylightSaving_I == null)
				cb_setDaylightSaving_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDaylightSaving_I);
			return cb_setDaylightSaving_I;
		}

		static void n_SetDaylightSaving_I (IntPtr jnienv, IntPtr native__this, int daylightSaving)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDaylightSaving (daylightSaving);
		}
#pragma warning restore 0169

		static IntPtr id_setDaylightSaving_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setDaylightSaving' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDaylightSaving", "(I)V", "GetSetDaylightSaving_IHandler")]
		protected virtual unsafe void SetDaylightSaving (int daylightSaving)
		{
			if (id_setDaylightSaving_I == IntPtr.Zero)
				id_setDaylightSaving_I = JNIEnv.GetMethodID (class_ref, "setDaylightSaving", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (daylightSaving);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDaylightSaving_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDaylightSaving", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setEra_Lsun_util_calendar_Era_;
#pragma warning disable 0169
		static Delegate GetSetEra_Lsun_util_calendar_Era_Handler ()
		{
			if (cb_setEra_Lsun_util_calendar_Era_ == null)
				cb_setEra_Lsun_util_calendar_Era_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEra_Lsun_util_calendar_Era_);
			return cb_setEra_Lsun_util_calendar_Era_;
		}

		static IntPtr n_SetEra_Lsun_util_calendar_Era_ (IntPtr jnienv, IntPtr native__this, IntPtr native_era)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Sun.Util.Calendar.Era era = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.Era> (native_era, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEra (era));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setEra_Lsun_util_calendar_Era_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setEra' and count(parameter)=1 and parameter[1][@type='sun.util.calendar.Era']]"
		[Register ("setEra", "(Lsun/util/calendar/Era;)Lsun/util/calendar/CalendarDate;", "GetSetEra_Lsun_util_calendar_Era_Handler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetEra (global::Sun.Util.Calendar.Era era)
		{
			if (id_setEra_Lsun_util_calendar_Era_ == IntPtr.Zero)
				id_setEra_Lsun_util_calendar_Era_ = JNIEnv.GetMethodID (class_ref, "setEra", "(Lsun/util/calendar/Era;)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (era);

				global::Sun.Util.Calendar.CalendarDate __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEra_Lsun_util_calendar_Era_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEra", "(Lsun/util/calendar/Era;)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setHours_I;
#pragma warning disable 0169
		static Delegate GetSetHours_IHandler ()
		{
			if (cb_setHours_I == null)
				cb_setHours_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetHours_I);
			return cb_setHours_I;
		}

		static IntPtr n_SetHours_I (IntPtr jnienv, IntPtr native__this, int hours)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHours (hours));
		}
#pragma warning restore 0169

		static IntPtr id_setHours_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setHours' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHours", "(I)Lsun/util/calendar/CalendarDate;", "GetSetHours_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetHours (int hours)
		{
			if (id_setHours_I == IntPtr.Zero)
				id_setHours_I = JNIEnv.GetMethodID (class_ref, "setHours", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (hours);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHours_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHours", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLocale_Ljava_util_Locale_;
#pragma warning disable 0169
		static Delegate GetSetLocale_Ljava_util_Locale_Handler ()
		{
			if (cb_setLocale_Ljava_util_Locale_ == null)
				cb_setLocale_Ljava_util_Locale_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocale_Ljava_util_Locale_);
			return cb_setLocale_Ljava_util_Locale_;
		}

		static void n_SetLocale_Ljava_util_Locale_ (IntPtr jnienv, IntPtr native__this, IntPtr native_loc)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Locale loc = global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (native_loc, JniHandleOwnership.DoNotTransfer);
			__this.SetLocale (loc);
		}
#pragma warning restore 0169

		static IntPtr id_setLocale_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setLocale' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("setLocale", "(Ljava/util/Locale;)V", "GetSetLocale_Ljava_util_Locale_Handler")]
		protected virtual unsafe void SetLocale (global::Java.Util.Locale loc)
		{
			if (id_setLocale_Ljava_util_Locale_ == IntPtr.Zero)
				id_setLocale_Ljava_util_Locale_ = JNIEnv.GetMethodID (class_ref, "setLocale", "(Ljava/util/Locale;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (loc);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocale_Ljava_util_Locale_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocale", "(Ljava/util/Locale;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMillis_I;
#pragma warning disable 0169
		static Delegate GetSetMillis_IHandler ()
		{
			if (cb_setMillis_I == null)
				cb_setMillis_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMillis_I);
			return cb_setMillis_I;
		}

		static IntPtr n_SetMillis_I (IntPtr jnienv, IntPtr native__this, int millis)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMillis (millis));
		}
#pragma warning restore 0169

		static IntPtr id_setMillis_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setMillis' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMillis", "(I)Lsun/util/calendar/CalendarDate;", "GetSetMillis_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetMillis (int millis)
		{
			if (id_setMillis_I == IntPtr.Zero)
				id_setMillis_I = JNIEnv.GetMethodID (class_ref, "setMillis", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (millis);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMillis_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMillis", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMinutes_I;
#pragma warning disable 0169
		static Delegate GetSetMinutes_IHandler ()
		{
			if (cb_setMinutes_I == null)
				cb_setMinutes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMinutes_I);
			return cb_setMinutes_I;
		}

		static IntPtr n_SetMinutes_I (IntPtr jnienv, IntPtr native__this, int minutes)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMinutes (minutes));
		}
#pragma warning restore 0169

		static IntPtr id_setMinutes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setMinutes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMinutes", "(I)Lsun/util/calendar/CalendarDate;", "GetSetMinutes_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetMinutes (int minutes)
		{
			if (id_setMinutes_I == IntPtr.Zero)
				id_setMinutes_I = JNIEnv.GetMethodID (class_ref, "setMinutes", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (minutes);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMinutes_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinutes", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMonth_I;
#pragma warning disable 0169
		static Delegate GetSetMonth_IHandler ()
		{
			if (cb_setMonth_I == null)
				cb_setMonth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMonth_I);
			return cb_setMonth_I;
		}

		static IntPtr n_SetMonth_I (IntPtr jnienv, IntPtr native__this, int month)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMonth (month));
		}
#pragma warning restore 0169

		static IntPtr id_setMonth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setMonth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMonth", "(I)Lsun/util/calendar/CalendarDate;", "GetSetMonth_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetMonth (int month)
		{
			if (id_setMonth_I == IntPtr.Zero)
				id_setMonth_I = JNIEnv.GetMethodID (class_ref, "setMonth", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (month);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMonth_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMonth", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNormalized_Z;
#pragma warning disable 0169
		static Delegate GetSetNormalized_ZHandler ()
		{
			if (cb_setNormalized_Z == null)
				cb_setNormalized_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNormalized_Z);
			return cb_setNormalized_Z;
		}

		static void n_SetNormalized_Z (IntPtr jnienv, IntPtr native__this, bool normalized)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNormalized (normalized);
		}
#pragma warning restore 0169

		static IntPtr id_setNormalized_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setNormalized' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNormalized", "(Z)V", "GetSetNormalized_ZHandler")]
		protected virtual unsafe void SetNormalized (bool normalized)
		{
			if (id_setNormalized_Z == IntPtr.Zero)
				id_setNormalized_Z = JNIEnv.GetMethodID (class_ref, "setNormalized", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (normalized);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNormalized_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNormalized", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSeconds_I;
#pragma warning disable 0169
		static Delegate GetSetSeconds_IHandler ()
		{
			if (cb_setSeconds_I == null)
				cb_setSeconds_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSeconds_I);
			return cb_setSeconds_I;
		}

		static IntPtr n_SetSeconds_I (IntPtr jnienv, IntPtr native__this, int seconds)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSeconds (seconds));
		}
#pragma warning restore 0169

		static IntPtr id_setSeconds_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setSeconds' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSeconds", "(I)Lsun/util/calendar/CalendarDate;", "GetSetSeconds_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetSeconds (int seconds)
		{
			if (id_setSeconds_I == IntPtr.Zero)
				id_setSeconds_I = JNIEnv.GetMethodID (class_ref, "setSeconds", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (seconds);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSeconds_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSeconds", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTimeOfDay_IIII;
#pragma warning disable 0169
		static Delegate GetSetTimeOfDay_IIIIHandler ()
		{
			if (cb_setTimeOfDay_IIII == null)
				cb_setTimeOfDay_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_SetTimeOfDay_IIII);
			return cb_setTimeOfDay_IIII;
		}

		static IntPtr n_SetTimeOfDay_IIII (IntPtr jnienv, IntPtr native__this, int hours, int minutes, int seconds, int millis)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTimeOfDay (hours, minutes, seconds, millis));
		}
#pragma warning restore 0169

		static IntPtr id_setTimeOfDay_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setTimeOfDay' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setTimeOfDay", "(IIII)Lsun/util/calendar/CalendarDate;", "GetSetTimeOfDay_IIIIHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetTimeOfDay (int hours, int minutes, int seconds, int millis)
		{
			if (id_setTimeOfDay_IIII == IntPtr.Zero)
				id_setTimeOfDay_IIII = JNIEnv.GetMethodID (class_ref, "setTimeOfDay", "(IIII)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (hours);
				__args [1] = new JValue (minutes);
				__args [2] = new JValue (seconds);
				__args [3] = new JValue (millis);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTimeOfDay_IIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeOfDay", "(IIII)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTimeOfDay_J;
#pragma warning disable 0169
		static Delegate GetSetTimeOfDay_JHandler ()
		{
			if (cb_setTimeOfDay_J == null)
				cb_setTimeOfDay_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimeOfDay_J);
			return cb_setTimeOfDay_J;
		}

		static void n_SetTimeOfDay_J (IntPtr jnienv, IntPtr native__this, long fraction)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeOfDay (fraction);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeOfDay_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setTimeOfDay' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTimeOfDay", "(J)V", "GetSetTimeOfDay_JHandler")]
		protected virtual unsafe void SetTimeOfDay (long fraction)
		{
			if (id_setTimeOfDay_J == IntPtr.Zero)
				id_setTimeOfDay_J = JNIEnv.GetMethodID (class_ref, "setTimeOfDay", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (fraction);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeOfDay_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeOfDay", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setYear_I;
#pragma warning disable 0169
		static Delegate GetSetYear_IHandler ()
		{
			if (cb_setYear_I == null)
				cb_setYear_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetYear_I);
			return cb_setYear_I;
		}

		static IntPtr n_SetYear_I (IntPtr jnienv, IntPtr native__this, int year)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetYear (year));
		}
#pragma warning restore 0169

		static IntPtr id_setYear_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setYear' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setYear", "(I)Lsun/util/calendar/CalendarDate;", "GetSetYear_IHandler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetYear (int year)
		{
			if (id_setYear_I == IntPtr.Zero)
				id_setYear_I = JNIEnv.GetMethodID (class_ref, "setYear", "(I)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (year);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setYear_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYear", "(I)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setZone_Ljava_util_TimeZone_;
#pragma warning disable 0169
		static Delegate GetSetZone_Ljava_util_TimeZone_Handler ()
		{
			if (cb_setZone_Ljava_util_TimeZone_ == null)
				cb_setZone_Ljava_util_TimeZone_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetZone_Ljava_util_TimeZone_);
			return cb_setZone_Ljava_util_TimeZone_;
		}

		static IntPtr n_SetZone_Ljava_util_TimeZone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_zoneinfo)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.TimeZone zoneinfo = global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (native_zoneinfo, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetZone (zoneinfo));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setZone_Ljava_util_TimeZone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setZone' and count(parameter)=1 and parameter[1][@type='java.util.TimeZone']]"
		[Register ("setZone", "(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;", "GetSetZone_Ljava_util_TimeZone_Handler")]
		public virtual unsafe global::Sun.Util.Calendar.CalendarDate SetZone (global::Java.Util.TimeZone zoneinfo)
		{
			if (id_setZone_Ljava_util_TimeZone_ == IntPtr.Zero)
				id_setZone_Ljava_util_TimeZone_ = JNIEnv.GetMethodID (class_ref, "setZone", "(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (zoneinfo);

				global::Sun.Util.Calendar.CalendarDate __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setZone_Ljava_util_TimeZone_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZone", "(Ljava/util/TimeZone;)Lsun/util/calendar/CalendarDate;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setZoneOffset_I;
#pragma warning disable 0169
		static Delegate GetSetZoneOffset_IHandler ()
		{
			if (cb_setZoneOffset_I == null)
				cb_setZoneOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZoneOffset_I);
			return cb_setZoneOffset_I;
		}

		static void n_SetZoneOffset_I (IntPtr jnienv, IntPtr native__this, int offset)
		{
			global::Sun.Util.Calendar.CalendarDate __this = global::Java.Lang.Object.GetObject<global::Sun.Util.Calendar.CalendarDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoneOffset (offset);
		}
#pragma warning restore 0169

		static IntPtr id_setZoneOffset_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='CalendarDate']/method[@name='setZoneOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setZoneOffset", "(I)V", "GetSetZoneOffset_IHandler")]
		protected virtual unsafe void SetZoneOffset (int offset)
		{
			if (id_setZoneOffset_I == IntPtr.Zero)
				id_setZoneOffset_I = JNIEnv.GetMethodID (class_ref, "setZoneOffset", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (offset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoneOffset_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoneOffset", "(I)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("sun/util/calendar/CalendarDate", DoNotGenerateAcw=true)]
	internal partial class CalendarDateInvoker : CalendarDate {

		public CalendarDateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalendarDateInvoker); }
		}

	}

}
