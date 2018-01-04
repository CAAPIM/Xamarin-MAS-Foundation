using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Sun.Security.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']"
	[global::Android.Runtime.Register ("sun/security/util/DerInputStream", DoNotGenerateAcw=true)]
	public partial class DerInputStream : global::Java.Lang.Object {


		static IntPtr tag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/field[@name='tag']"
		[Register ("tag")]
		public sbyte Tag {
			get {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "B");
				return JNIEnv.GetByteField (((global::Java.Lang.Object) this).Handle, tag_jfieldId);
			}
			set {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "B");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tag_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("sun/security/util/DerInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DerInputStream); }
		}

		protected DerInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/constructor[@name='DerInputStream' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe DerInputStream (byte[] data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				if (((object) this).GetType () != typeof (DerInputStream)) {
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
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_ctor_arrayBII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/constructor[@name='DerInputStream' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "([BII)V", "")]
		public unsafe DerInputStream (byte[] data, int offset, int len)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_data);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (len);
				if (((object) this).GetType () != typeof (DerInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([BII)V", __args);
					return;
				}

				if (id_ctor_arrayBII == IntPtr.Zero)
					id_ctor_arrayBII = JNIEnv.GetMethodID (class_ref, "<init>", "([BII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBII, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_getBMPString;
#pragma warning disable 0169
		static Delegate GetGetBMPStringHandler ()
		{
			if (cb_getBMPString == null)
				cb_getBMPString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBMPString);
			return cb_getBMPString;
		}

		static IntPtr n_GetBMPString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BMPString);
		}
#pragma warning restore 0169

		static IntPtr id_getBMPString;
		public virtual unsafe string BMPString {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getBMPString' and count(parameter)=0]"
			[Register ("getBMPString", "()Ljava/lang/String;", "GetGetBMPStringHandler")]
			get {
				if (id_getBMPString == IntPtr.Zero)
					id_getBMPString = JNIEnv.GetMethodID (class_ref, "getBMPString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBMPString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBMPString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBigInteger;
#pragma warning disable 0169
		static Delegate GetGetBigIntegerHandler ()
		{
			if (cb_getBigInteger == null)
				cb_getBigInteger = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBigInteger);
			return cb_getBigInteger;
		}

		static IntPtr n_GetBigInteger (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BigInteger);
		}
#pragma warning restore 0169

		static IntPtr id_getBigInteger;
		public virtual unsafe global::Java.Math.BigInteger BigInteger {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getBigInteger' and count(parameter)=0]"
			[Register ("getBigInteger", "()Ljava/math/BigInteger;", "GetGetBigIntegerHandler")]
			get {
				if (id_getBigInteger == IntPtr.Zero)
					id_getBigInteger = JNIEnv.GetMethodID (class_ref, "getBigInteger", "()Ljava/math/BigInteger;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBigInteger), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBigInteger", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEnumerated;
#pragma warning disable 0169
		static Delegate GetGetEnumeratedHandler ()
		{
			if (cb_getEnumerated == null)
				cb_getEnumerated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEnumerated);
			return cb_getEnumerated;
		}

		static int n_GetEnumerated (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enumerated;
		}
#pragma warning restore 0169

		static IntPtr id_getEnumerated;
		public virtual unsafe int Enumerated {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getEnumerated' and count(parameter)=0]"
			[Register ("getEnumerated", "()I", "GetGetEnumeratedHandler")]
			get {
				if (id_getEnumerated == IntPtr.Zero)
					id_getEnumerated = JNIEnv.GetMethodID (class_ref, "getEnumerated", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEnumerated);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnumerated", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getGeneralString;
#pragma warning disable 0169
		static Delegate GetGetGeneralStringHandler ()
		{
			if (cb_getGeneralString == null)
				cb_getGeneralString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeneralString);
			return cb_getGeneralString;
		}

		static IntPtr n_GetGeneralString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GeneralString);
		}
#pragma warning restore 0169

		static IntPtr id_getGeneralString;
		public virtual unsafe string GeneralString {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getGeneralString' and count(parameter)=0]"
			[Register ("getGeneralString", "()Ljava/lang/String;", "GetGetGeneralStringHandler")]
			get {
				if (id_getGeneralString == IntPtr.Zero)
					id_getGeneralString = JNIEnv.GetMethodID (class_ref, "getGeneralString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGeneralString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeneralString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGeneralizedTime;
#pragma warning disable 0169
		static Delegate GetGetGeneralizedTimeHandler ()
		{
			if (cb_getGeneralizedTime == null)
				cb_getGeneralizedTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeneralizedTime);
			return cb_getGeneralizedTime;
		}

		static IntPtr n_GetGeneralizedTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GeneralizedTime);
		}
#pragma warning restore 0169

		static IntPtr id_getGeneralizedTime;
		public virtual unsafe global::Java.Util.Date GeneralizedTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getGeneralizedTime' and count(parameter)=0]"
			[Register ("getGeneralizedTime", "()Ljava/util/Date;", "GetGetGeneralizedTimeHandler")]
			get {
				if (id_getGeneralizedTime == IntPtr.Zero)
					id_getGeneralizedTime = JNIEnv.GetMethodID (class_ref, "getGeneralizedTime", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGeneralizedTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeneralizedTime", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIA5String;
#pragma warning disable 0169
		static Delegate GetGetIA5StringHandler ()
		{
			if (cb_getIA5String == null)
				cb_getIA5String = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIA5String);
			return cb_getIA5String;
		}

		static IntPtr n_GetIA5String (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IA5String);
		}
#pragma warning restore 0169

		static IntPtr id_getIA5String;
		public virtual unsafe string IA5String {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getIA5String' and count(parameter)=0]"
			[Register ("getIA5String", "()Ljava/lang/String;", "GetGetIA5StringHandler")]
			get {
				if (id_getIA5String == IntPtr.Zero)
					id_getIA5String = JNIEnv.GetMethodID (class_ref, "getIA5String", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIA5String), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIA5String", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInteger;
#pragma warning disable 0169
		static Delegate GetGetIntegerHandler ()
		{
			if (cb_getInteger == null)
				cb_getInteger = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInteger);
			return cb_getInteger;
		}

		static int n_GetInteger (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Integer;
		}
#pragma warning restore 0169

		static IntPtr id_getInteger;
		public virtual unsafe int Integer {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getInteger' and count(parameter)=0]"
			[Register ("getInteger", "()I", "GetGetIntegerHandler")]
			get {
				if (id_getInteger == IntPtr.Zero)
					id_getInteger = JNIEnv.GetMethodID (class_ref, "getInteger", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInteger);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInteger", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getOID;
#pragma warning disable 0169
		static Delegate GetGetOIDHandler ()
		{
			if (cb_getOID == null)
				cb_getOID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOID);
			return cb_getOID;
		}

		static IntPtr n_GetOID (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OID);
		}
#pragma warning restore 0169

		static IntPtr id_getOID;
		public virtual unsafe global::Sun.Security.Util.ObjectIdentifier OID {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getOID' and count(parameter)=0]"
			[Register ("getOID", "()Lsun/security/util/ObjectIdentifier;", "GetGetOIDHandler")]
			get {
				if (id_getOID == IntPtr.Zero)
					id_getOID = JNIEnv.GetMethodID (class_ref, "getOID", "()Lsun/security/util/ObjectIdentifier;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.ObjectIdentifier> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOID", "()Lsun/security/util/ObjectIdentifier;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPositiveBigInteger;
#pragma warning disable 0169
		static Delegate GetGetPositiveBigIntegerHandler ()
		{
			if (cb_getPositiveBigInteger == null)
				cb_getPositiveBigInteger = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPositiveBigInteger);
			return cb_getPositiveBigInteger;
		}

		static IntPtr n_GetPositiveBigInteger (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PositiveBigInteger);
		}
#pragma warning restore 0169

		static IntPtr id_getPositiveBigInteger;
		public virtual unsafe global::Java.Math.BigInteger PositiveBigInteger {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getPositiveBigInteger' and count(parameter)=0]"
			[Register ("getPositiveBigInteger", "()Ljava/math/BigInteger;", "GetGetPositiveBigIntegerHandler")]
			get {
				if (id_getPositiveBigInteger == IntPtr.Zero)
					id_getPositiveBigInteger = JNIEnv.GetMethodID (class_ref, "getPositiveBigInteger", "()Ljava/math/BigInteger;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPositiveBigInteger), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositiveBigInteger", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrintableString;
#pragma warning disable 0169
		static Delegate GetGetPrintableStringHandler ()
		{
			if (cb_getPrintableString == null)
				cb_getPrintableString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrintableString);
			return cb_getPrintableString;
		}

		static IntPtr n_GetPrintableString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PrintableString);
		}
#pragma warning restore 0169

		static IntPtr id_getPrintableString;
		public virtual unsafe string PrintableString {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getPrintableString' and count(parameter)=0]"
			[Register ("getPrintableString", "()Ljava/lang/String;", "GetGetPrintableStringHandler")]
			get {
				if (id_getPrintableString == IntPtr.Zero)
					id_getPrintableString = JNIEnv.GetMethodID (class_ref, "getPrintableString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrintableString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrintableString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getT61String;
#pragma warning disable 0169
		static Delegate GetGetT61StringHandler ()
		{
			if (cb_getT61String == null)
				cb_getT61String = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetT61String);
			return cb_getT61String;
		}

		static IntPtr n_GetT61String (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.T61String);
		}
#pragma warning restore 0169

		static IntPtr id_getT61String;
		public virtual unsafe string T61String {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getT61String' and count(parameter)=0]"
			[Register ("getT61String", "()Ljava/lang/String;", "GetGetT61StringHandler")]
			get {
				if (id_getT61String == IntPtr.Zero)
					id_getT61String = JNIEnv.GetMethodID (class_ref, "getT61String", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getT61String), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getT61String", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUTCTime;
#pragma warning disable 0169
		static Delegate GetGetUTCTimeHandler ()
		{
			if (cb_getUTCTime == null)
				cb_getUTCTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUTCTime);
			return cb_getUTCTime;
		}

		static IntPtr n_GetUTCTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UTCTime);
		}
#pragma warning restore 0169

		static IntPtr id_getUTCTime;
		public virtual unsafe global::Java.Util.Date UTCTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getUTCTime' and count(parameter)=0]"
			[Register ("getUTCTime", "()Ljava/util/Date;", "GetGetUTCTimeHandler")]
			get {
				if (id_getUTCTime == IntPtr.Zero)
					id_getUTCTime = JNIEnv.GetMethodID (class_ref, "getUTCTime", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUTCTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUTCTime", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUTF8String;
#pragma warning disable 0169
		static Delegate GetGetUTF8StringHandler ()
		{
			if (cb_getUTF8String == null)
				cb_getUTF8String = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUTF8String);
			return cb_getUTF8String;
		}

		static IntPtr n_GetUTF8String (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UTF8String);
		}
#pragma warning restore 0169

		static IntPtr id_getUTF8String;
		public virtual unsafe string UTF8String {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getUTF8String' and count(parameter)=0]"
			[Register ("getUTF8String", "()Ljava/lang/String;", "GetGetUTF8StringHandler")]
			get {
				if (id_getUTF8String == IntPtr.Zero)
					id_getUTF8String = JNIEnv.GetMethodID (class_ref, "getUTF8String", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUTF8String), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUTF8String", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnalignedBitString;
#pragma warning disable 0169
		static Delegate GetGetUnalignedBitStringHandler ()
		{
			if (cb_getUnalignedBitString == null)
				cb_getUnalignedBitString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnalignedBitString);
			return cb_getUnalignedBitString;
		}

		static IntPtr n_GetUnalignedBitString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnalignedBitString);
		}
#pragma warning restore 0169

		static IntPtr id_getUnalignedBitString;
		public virtual unsafe global::Sun.Security.Util.BitArray UnalignedBitString {
			// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getUnalignedBitString' and count(parameter)=0]"
			[Register ("getUnalignedBitString", "()Lsun/security/util/BitArray;", "GetGetUnalignedBitStringHandler")]
			get {
				if (id_getUnalignedBitString == IntPtr.Zero)
					id_getUnalignedBitString = JNIEnv.GetMethodID (class_ref, "getUnalignedBitString", "()Lsun/security/util/BitArray;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUnalignedBitString), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.BitArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnalignedBitString", "()Lsun/security/util/BitArray;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_available;
#pragma warning disable 0169
		static Delegate GetAvailableHandler ()
		{
			if (cb_available == null)
				cb_available = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Available);
			return cb_available;
		}

		static int n_Available (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Available ();
		}
#pragma warning restore 0169

		static IntPtr id_available;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='available' and count(parameter)=0]"
		[Register ("available", "()I", "GetAvailableHandler")]
		public virtual unsafe int Available ()
		{
			if (id_available == IntPtr.Zero)
				id_available = JNIEnv.GetMethodID (class_ref, "available", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_available);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "available", "()I"));
			} finally {
			}
		}

		static Delegate cb_getBitString;
#pragma warning disable 0169
		static Delegate GetGetBitStringHandler ()
		{
			if (cb_getBitString == null)
				cb_getBitString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitString);
			return cb_getBitString;
		}

		static IntPtr n_GetBitString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBitString ());
		}
#pragma warning restore 0169

		static IntPtr id_getBitString;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getBitString' and count(parameter)=0]"
		[Register ("getBitString", "()[B", "GetGetBitStringHandler")]
		public virtual unsafe byte[] GetBitString ()
		{
			if (id_getBitString == IntPtr.Zero)
				id_getBitString = JNIEnv.GetMethodID (class_ref, "getBitString", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBitString), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitString", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getBytes_arrayB;
#pragma warning disable 0169
		static Delegate GetGetBytes_arrayBHandler ()
		{
			if (cb_getBytes_arrayB == null)
				cb_getBytes_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetBytes_arrayB);
			return cb_getBytes_arrayB;
		}

		static void n_GetBytes_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] val = (byte[]) JNIEnv.GetArray (native_val, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.GetBytes (val);
			if (val != null)
				JNIEnv.CopyArray (val, native_val);
		}
#pragma warning restore 0169

		static IntPtr id_getBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getBytes", "([B)V", "GetGetBytes_arrayBHandler")]
		public virtual unsafe void GetBytes (byte[] val)
		{
			if (id_getBytes_arrayB == IntPtr.Zero)
				id_getBytes_arrayB = JNIEnv.GetMethodID (class_ref, "getBytes", "([B)V");
			IntPtr native_val = JNIEnv.NewArray (val);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_val);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBytes_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBytes", "([B)V"), __args);
			} finally {
				if (val != null) {
					JNIEnv.CopyArray (native_val, val);
					JNIEnv.DeleteLocalRef (native_val);
				}
			}
		}

		static Delegate cb_getNull;
#pragma warning disable 0169
		static Delegate GetGetNullHandler ()
		{
			if (cb_getNull == null)
				cb_getNull = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetNull);
			return cb_getNull;
		}

		static void n_GetNull (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetNull ();
		}
#pragma warning restore 0169

		static IntPtr id_getNull;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getNull' and count(parameter)=0]"
		[Register ("getNull", "()V", "GetGetNullHandler")]
		public virtual unsafe void GetNull ()
		{
			if (id_getNull == IntPtr.Zero)
				id_getNull = JNIEnv.GetMethodID (class_ref, "getNull", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getNull);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNull", "()V"));
			} finally {
			}
		}

		static Delegate cb_getOctetString;
#pragma warning disable 0169
		static Delegate GetGetOctetStringHandler ()
		{
			if (cb_getOctetString == null)
				cb_getOctetString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOctetString);
			return cb_getOctetString;
		}

		static IntPtr n_GetOctetString (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOctetString ());
		}
#pragma warning restore 0169

		static IntPtr id_getOctetString;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='getOctetString' and count(parameter)=0]"
		[Register ("getOctetString", "()[B", "GetGetOctetStringHandler")]
		public virtual unsafe byte[] GetOctetString ()
		{
			if (id_getOctetString == IntPtr.Zero)
				id_getOctetString = JNIEnv.GetMethodID (class_ref, "getOctetString", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOctetString), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOctetString", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_mark_I;
#pragma warning disable 0169
		static Delegate GetMark_IHandler ()
		{
			if (cb_mark_I == null)
				cb_mark_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Mark_I);
			return cb_mark_I;
		}

		static void n_Mark_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mark (value);
		}
#pragma warning restore 0169

		static IntPtr id_mark_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='mark' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("mark", "(I)V", "GetMark_IHandler")]
		public virtual unsafe void Mark (int value)
		{
			if (id_mark_I == IntPtr.Zero)
				id_mark_I = JNIEnv.GetMethodID (class_ref, "mark", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mark_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mark", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_peekByte;
#pragma warning disable 0169
		static Delegate GetPeekByteHandler ()
		{
			if (cb_peekByte == null)
				cb_peekByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_PeekByte);
			return cb_peekByte;
		}

		static int n_PeekByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeekByte ();
		}
#pragma warning restore 0169

		static IntPtr id_peekByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='peekByte' and count(parameter)=0]"
		[Register ("peekByte", "()I", "GetPeekByteHandler")]
		public virtual unsafe int PeekByte ()
		{
			if (id_peekByte == IntPtr.Zero)
				id_peekByte = JNIEnv.GetMethodID (class_ref, "peekByte", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_peekByte);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peekByte", "()I"));
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_subStream_IZ;
#pragma warning disable 0169
		static Delegate GetSubStream_IZHandler ()
		{
			if (cb_subStream_IZ == null)
				cb_subStream_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr>) n_SubStream_IZ);
			return cb_subStream_IZ;
		}

		static IntPtr n_SubStream_IZ (IntPtr jnienv, IntPtr native__this, int len, bool do_skip)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubStream (len, do_skip));
		}
#pragma warning restore 0169

		static IntPtr id_subStream_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='subStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("subStream", "(IZ)Lsun/security/util/DerInputStream;", "GetSubStream_IZHandler")]
		public virtual unsafe global::Sun.Security.Util.DerInputStream SubStream (int len, bool do_skip)
		{
			if (id_subStream_IZ == IntPtr.Zero)
				id_subStream_IZ = JNIEnv.GetMethodID (class_ref, "subStream", "(IZ)Lsun/security/util/DerInputStream;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (len);
				__args [1] = new JValue (do_skip);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subStream_IZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subStream", "(IZ)Lsun/security/util/DerInputStream;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toByteArray;
#pragma warning disable 0169
		static Delegate GetToByteArrayHandler ()
		{
			if (cb_toByteArray == null)
				cb_toByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByteArray);
			return cb_toByteArray;
		}

		static IntPtr n_ToByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Sun.Security.Util.DerInputStream __this = global::Java.Lang.Object.GetObject<global::Sun.Security.Util.DerInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='sun.security.util']/class[@name='DerInputStream']/method[@name='toByteArray' and count(parameter)=0]"
		[Register ("toByteArray", "()[B", "GetToByteArrayHandler")]
		public virtual unsafe byte[] ToByteArray ()
		{
			if (id_toByteArray == IntPtr.Zero)
				id_toByteArray = JNIEnv.GetMethodID (class_ref, "toByteArray", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toByteArray", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
