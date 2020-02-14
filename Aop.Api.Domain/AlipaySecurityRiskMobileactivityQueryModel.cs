using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskMobileactivityQueryModel : AopObject
	{
		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("scene_id")]
		public string SceneId
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
