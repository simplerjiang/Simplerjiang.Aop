using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsAutoUserCampaignQueryModel : AopObject
	{
		[XmlElement("auto_campaign_type")]
		public string AutoCampaignType
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
