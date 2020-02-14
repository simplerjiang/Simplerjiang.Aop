using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignCashCreateResponse : AopResponse
	{
		[XmlElement("crowd_no")]
		public string CrowdNo
		{
			get;
			set;
		}

		[XmlElement("origin_crowd_no")]
		public string OriginCrowdNo
		{
			get;
			set;
		}

		[XmlElement("pay_url")]
		public string PayUrl
		{
			get;
			set;
		}
	}
}
