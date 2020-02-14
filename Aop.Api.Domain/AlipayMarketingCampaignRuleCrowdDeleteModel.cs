using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignRuleCrowdDeleteModel : AopObject
	{
		[XmlElement("mpid")]
		public string Mpid
		{
			get;
			set;
		}

		[XmlElement("ruleid")]
		public string Ruleid
		{
			get;
			set;
		}
	}
}
