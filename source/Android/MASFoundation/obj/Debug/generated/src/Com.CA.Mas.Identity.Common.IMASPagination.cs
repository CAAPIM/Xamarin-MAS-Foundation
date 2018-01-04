using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.CA.Mas.Identity.Common {

	[Register ("com/ca/mas/identity/common/MASPagination", DoNotGenerateAcw=true)]
	public abstract class MASPagination : Java.Lang.Object {

		internal MASPagination ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/interface[@name='MASPagination']/field[@name='PAGE_INC_BY']"
		[Register ("PAGE_INC_BY")]
		public const string PageIncBy = (string) "&count=%s";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/interface[@name='MASPagination']/field[@name='PAGE_NO_PAGINATION']"
		[Register ("PAGE_NO_PAGINATION")]
		public const int PageNoPagination = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/interface[@name='MASPagination']/field[@name='PAGE_START']"
		[Register ("PAGE_START")]
		public const string PageStart = (string) "startIndex=%s";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/interface[@name='MASPagination']/field[@name='PAGE_START_EXP']"
		[Register ("PAGE_START_EXP")]
		public const string PageStartExp = (string) "startIndex=";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ca.mas.identity.common']/interface[@name='MASPagination']/field[@name='PAGE_START_INDEX']"
		[Register ("PAGE_START_INDEX")]
		public const int PageStartIndex = (int) 1;
	}

	[Register ("com/ca/mas/identity/common/MASPagination", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MASPagination' type. This type will be removed in a future release.")]
	public abstract class MASPaginationConsts : MASPagination {

		private MASPaginationConsts ()
		{
		}
	}

}
