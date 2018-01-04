using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Util.Calendar {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']"
	[global::Android.Runtime.Register ("sun/util/calendar/ZoneInfoFile", DoNotGenerateAcw=true)]
	public partial class ZoneInfoFile : global::Java.Lang.Object {


		static IntPtr JAVAZI_LABEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='JAVAZI_LABEL']"
		[Register ("JAVAZI_LABEL")]
		public static IList<byte> JavaziLabel {
			get {
				if (JAVAZI_LABEL_jfieldId == IntPtr.Zero)
					JAVAZI_LABEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVAZI_LABEL", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, JAVAZI_LABEL_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='JAVAZI_VERSION']"
		[Register ("JAVAZI_VERSION")]
		public const sbyte JavaziVersion = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='JAVAZM_FILE_NAME']"
		[Register ("JAVAZM_FILE_NAME")]
		public const string JavazmFileName = (string) "ZoneInfoMappings";

		static IntPtr JAVAZM_LABEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='JAVAZM_LABEL']"
		[Register ("JAVAZM_LABEL")]
		public static IList<byte> JavazmLabel {
			get {
				if (JAVAZM_LABEL_jfieldId == IntPtr.Zero)
					JAVAZM_LABEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JAVAZM_LABEL", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, JAVAZM_LABEL_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='JAVAZM_VERSION']"
		[Register ("JAVAZM_VERSION")]
		public const sbyte JavazmVersion = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_CRC32']"
		[Register ("TAG_CRC32")]
		public const sbyte TagCrc32 = (sbyte) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_ExcludedZones']"
		[Register ("TAG_ExcludedZones")]
		public const sbyte TAGExcludedZones = (sbyte) 69;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_GMTOffsetWillChange']"
		[Register ("TAG_GMTOffsetWillChange")]
		public const sbyte TAGGMTOffsetWillChange = (sbyte) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_LastDSTSaving']"
		[Register ("TAG_LastDSTSaving")]
		public const sbyte TAGLastDSTSaving = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_Offset']"
		[Register ("TAG_Offset")]
		public const sbyte TAGOffset = (sbyte) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_RawOffset']"
		[Register ("TAG_RawOffset")]
		public const sbyte TAGRawOffset = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_RawOffsetIndices']"
		[Register ("TAG_RawOffsetIndices")]
		public const sbyte TAGRawOffsetIndices = (sbyte) 66;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_RawOffsets']"
		[Register ("TAG_RawOffsets")]
		public const sbyte TAGRawOffsets = (sbyte) 65;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_SimpleTimeZone']"
		[Register ("TAG_SimpleTimeZone")]
		public const sbyte TAGSimpleTimeZone = (sbyte) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_TZDataVersion']"
		[Register ("TAG_TZDataVersion")]
		public const sbyte TAGTZDataVersion = (sbyte) 68;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_Transition']"
		[Register ("TAG_Transition")]
		public const sbyte TAGTransition = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_ZoneAliases']"
		[Register ("TAG_ZoneAliases")]
		public const sbyte TAGZoneAliases = (sbyte) 67;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/field[@name='TAG_ZoneIDs']"
		[Register ("TAG_ZoneIDs")]
		public const sbyte TAGZoneIDs = (sbyte) 64;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/util/calendar/ZoneInfoFile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZoneInfoFile); }
		}

		protected ZoneInfoFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/constructor[@name='ZoneInfoFile' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ZoneInfoFile ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ZoneInfoFile)) {
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

		static IntPtr id_getFileName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/method[@name='getFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFileName (string ID)
		{
			if (id_getFileName_Ljava_lang_String_ == IntPtr.Zero)
				id_getFileName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFileName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_ID = JNIEnv.NewString (ID);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_ID);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_ID);
			}
		}

		static IntPtr id_toCustomID_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.util.calendar']/class[@name='ZoneInfoFile']/method[@name='toCustomID' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toCustomID", "(I)Ljava/lang/String;", "")]
		public static unsafe string ToCustomID (int gmtOffset)
		{
			if (id_toCustomID_I == IntPtr.Zero)
				id_toCustomID_I = JNIEnv.GetStaticMethodID (class_ref, "toCustomID", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (gmtOffset);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toCustomID_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
