using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertDataPromotedetailBatchqueryModel : AopObject
	{
		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("page_index")]
		public long PageIndex
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("start_date")]
		public string StartDate
		{
			get;
			set;
		}

		[XmlElement("voucher_name")]
		public string VoucherName
		{
			get;
			set;
		}
	}
}
