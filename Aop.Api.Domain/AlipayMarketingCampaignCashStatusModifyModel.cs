using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignCashStatusModifyModel : AopObject
	{
		[XmlElement("camp_status")]
		public string CampStatus
		{
			get;
			set;
		}

		[XmlElement("crowd_no")]
		public string CrowdNo
		{
			get;
			set;
		}
	}
}
