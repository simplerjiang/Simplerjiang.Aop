using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCardActivateurlApplyModel : AopObject
	{
		[XmlElement("callback")]
		public string Callback
		{
			get;
			set;
		}

		[XmlElement("follow_app_id")]
		public string FollowAppId
		{
			get;
			set;
		}

		[XmlElement("out_string")]
		public string OutString
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
