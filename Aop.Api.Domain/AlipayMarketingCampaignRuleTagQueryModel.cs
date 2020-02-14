using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignRuleTagQueryModel : AopObject
	{
		[XmlElement("mpid")]
		public string Mpid
		{
			get;
			set;
		}
	}
}
