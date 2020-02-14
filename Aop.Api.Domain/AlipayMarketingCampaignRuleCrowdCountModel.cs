using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignRuleCrowdCountModel : AopObject
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

		[XmlElement("scenetagjson")]
		public string Scenetagjson
		{
			get;
			set;
		}
	}
}
