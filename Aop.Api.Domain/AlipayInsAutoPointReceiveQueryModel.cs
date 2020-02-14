using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsAutoPointReceiveQueryModel : AopObject
	{
		[XmlElement("auto_campaign_type")]
		public string AutoCampaignType
		{
			get;
			set;
		}

		[XmlElement("scene_type")]
		public string SceneType
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
