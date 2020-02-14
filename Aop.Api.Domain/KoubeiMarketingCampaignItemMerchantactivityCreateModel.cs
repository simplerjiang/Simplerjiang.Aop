using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignItemMerchantactivityCreateModel : AopObject
	{
		[XmlElement("count_limit")]
		public long CountLimit
		{
			get;
			set;
		}

		[XmlElement("count_limit_per_day")]
		public long CountLimitPerDay
		{
			get;
			set;
		}

		[XmlElement("count_limit_per_user")]
		public long CountLimitPerUser
		{
			get;
			set;
		}

		[XmlElement("count_limit_per_user_per_day")]
		public long CountLimitPerUserPerDay
		{
			get;
			set;
		}

		[XmlElement("crowd")]
		public string Crowd
		{
			get;
			set;
		}

		[XmlElement("deduct_amount")]
		public string DeductAmount
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

		[XmlElement("external_unique_id")]
		public string ExternalUniqueId
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

		[XmlElement("gmt_start")]
		public string GmtStart
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

		[XmlElement("min_cost")]
		public string MinCost
		{
			get;
			set;
		}

		[XmlElement("obtain_manually")]
		public bool ObtainManually
		{
			get;
			set;
		}

		[XmlElement("voucher_info")]
		public MerchantActivityVoucherInfo VoucherInfo
		{
			get;
			set;
		}
	}
}
