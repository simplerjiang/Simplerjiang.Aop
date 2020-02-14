using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignRuleRulelistQueryModel : AopObject
	{
		[XmlElement("mpid")]
		public string Mpid
		{
			get;
			set;
		}

		[XmlElement("pageno")]
		public string Pageno
		{
			get;
			set;
		}

		[XmlElement("pagesize")]
		public string Pagesize
		{
			get;
			set;
		}
	}
}
