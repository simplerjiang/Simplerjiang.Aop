using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignCashDetailQueryModel : AopObject
	{
		[XmlElement("crowd_no")]
		public string CrowdNo
		{
			get;
			set;
		}
	}
}
