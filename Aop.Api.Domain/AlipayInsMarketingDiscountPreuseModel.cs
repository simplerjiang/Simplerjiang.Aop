using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsMarketingDiscountPreuseModel : AopObject
	{
		[XmlElement("account_id")]
		public string AccountId
		{
			get;
			set;
		}

		[XmlElement("account_type")]
		public long AccountType
		{
			get;
			set;
		}

		[XmlElement("business_type")]
		public long BusinessType
		{
			get;
			set;
		}

		[XmlArray("factors")]
		[XmlArrayItem("ins_mkt_factor_d_t_o")]
		public List<InsMktFactorDTO> Factors
		{
			get;
			set;
		}

		[XmlArray("market_types")]
		[XmlArrayItem("number")]
		public List<long> MarketTypes
		{
			get;
			set;
		}

		[XmlArray("mkt_coupon_campaigns")]
		[XmlArrayItem("ins_mkt_coupon_cmpgn_base_d_t_o")]
		public List<InsMktCouponCmpgnBaseDTO> MktCouponCampaigns
		{
			get;
			set;
		}

		[XmlArray("mkt_coupons")]
		[XmlArrayItem("ins_mkt_coupon_base_d_t_o")]
		public List<InsMktCouponBaseDTO> MktCoupons
		{
			get;
			set;
		}

		[XmlArray("mkt_objects")]
		[XmlArrayItem("ins_mkt_object_d_t_o")]
		public List<InsMktObjectDTO> MktObjects
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}
