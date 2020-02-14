using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsMarketingCampaignPrizeSendModel : AopObject
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

		[XmlElement("campaign_id")]
		public string CampaignId
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

		[XmlElement("out_biz_no")]
		public string OutBizNo
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
