using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignDrawcampUpdateModel : AopObject
	{
		[XmlElement("account_count")]
		public string AccountCount
		{
			get;
			set;
		}

		[XmlElement("appid_count")]
		public string AppidCount
		{
			get;
			set;
		}

		[XmlElement("award_rate")]
		public string AwardRate
		{
			get;
			set;
		}

		[XmlElement("camp_end_time")]
		public string CampEndTime
		{
			get;
			set;
		}

		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}

		[XmlElement("camp_name")]
		public string CampName
		{
			get;
			set;
		}

		[XmlElement("camp_start_time")]
		public string CampStartTime
		{
			get;
			set;
		}

		[XmlElement("cert_rule_id")]
		public string CertRuleId
		{
			get;
			set;
		}

		[XmlElement("certification_count")]
		public string CertificationCount
		{
			get;
			set;
		}

		[XmlElement("crowd_rule_id")]
		public string CrowdRuleId
		{
			get;
			set;
		}

		[XmlElement("mobile_count")]
		public string MobileCount
		{
			get;
			set;
		}

		[XmlElement("mpid")]
		public string Mpid
		{
			get;
			set;
		}

		[XmlArray("prize_list")]
		[XmlArrayItem("mp_prize_info_model")]
		public List<MpPrizeInfoModel> PrizeList
		{
			get;
			set;
		}

		[XmlElement("promo_rule_id")]
		public string PromoRuleId
		{
			get;
			set;
		}

		[XmlElement("user_rule_id")]
		public string UserRuleId
		{
			get;
			set;
		}
	}
}
