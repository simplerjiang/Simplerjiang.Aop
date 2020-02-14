using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignActivityOfflineCreateModel : AopObject
	{
		[XmlElement("budget")]
		public OpenPromoBudget Budget
		{
			get;
			set;
		}

		[XmlElement("camp")]
		public OpenPromoCamp Camp
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

		[XmlElement("prize")]
		public OpenPromoPrize Prize
		{
			get;
			set;
		}
	}
}
