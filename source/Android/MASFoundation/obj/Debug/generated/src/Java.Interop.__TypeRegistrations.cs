using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/ca/mas/foundation",
						"com/ca/mas/identity",
					},
					new Converter<string, Type>[]{
						lookup_com_ca_mas_foundation_package,
						lookup_com_ca_mas_identity_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_ca_mas_foundation_mappings;
		static Type lookup_com_ca_mas_foundation_package (string klass)
		{
			if (package_com_ca_mas_foundation_mappings == null) {
				package_com_ca_mas_foundation_mappings = new string[]{
					"com/ca/mas/foundation/MASSecurityConfiguration$Builder:Com.CA.Mas.Foundation.MASSecurityConfigurationBuilder",
				};
			}

			return Lookup (package_com_ca_mas_foundation_mappings, klass);
		}

		static string[] package_com_ca_mas_identity_mappings;
		static Type lookup_com_ca_mas_identity_package (string klass)
		{
			if (package_com_ca_mas_identity_mappings == null) {
				package_com_ca_mas_identity_mappings = new string[]{
					"com/ca/mas/identity/ScimIdentifiable$ResourceType:Com.CA.Mas.Identity.ScimIdentifiableResourceType",
				};
			}

			return Lookup (package_com_ca_mas_identity_mappings, klass);
		}
	}
}
