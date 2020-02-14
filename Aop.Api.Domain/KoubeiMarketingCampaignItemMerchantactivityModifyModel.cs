using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignItemMerchantactivityModifyModel : AopObject
	{
		[XmlElement("activity_id")]
		public string ActivityId
		{
			get;
			set;
		}

		[XmlElement("external_callback_url")]
		public string ExternalCallbackUrl
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlArray("item_ids")]
		[XmlArrayItem("string")]
		public List<string> ItemIds
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("voucher_info")]
		public MerchantActivityModifyVoucherInfo VoucherInfo
		{
			get;
			set;
		}
	}
}
