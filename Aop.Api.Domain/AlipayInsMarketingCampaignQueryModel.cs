using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsMarketingCampaignQueryModel : AopObject
	{
		[XmlElement("campaign_id")]
		public string CampaignId
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
