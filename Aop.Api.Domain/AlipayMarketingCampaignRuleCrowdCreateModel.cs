using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignRuleCrowdCreateModel : AopObject
	{
		[XmlElement("mdatacrowdsource")]
		public string Mdatacrowdsource
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

		[XmlElement("ruledesc")]
		public string Ruledesc
		{
			get;
			set;
		}
	}
}
