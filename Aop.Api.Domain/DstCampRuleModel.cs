using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DstCampRuleModel : AopObject
	{
		[XmlElement("alipay_cashier")]
		public string AlipayCashier
		{
			get;
			set;
		}

		[XmlElement("discount_type")]
		public string DiscountType
		{
			get;
			set;
		}

		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}

		[XmlElement("prize_count_per_account")]
		public string PrizeCountPerAccount
		{
			get;
			set;
		}

		[XmlElement("product_type")]
		public string ProductType
		{
			get;
			set;
		}

		[XmlElement("rule_uuid")]
		public string RuleUuid
		{
			get;
			set;
		}

		[XmlElement("voucher_id")]
		public string VoucherId
		{
			get;
			set;
		}
	}
}
