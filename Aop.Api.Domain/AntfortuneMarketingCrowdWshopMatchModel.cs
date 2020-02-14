using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntfortuneMarketingCrowdWshopMatchModel : AopObject
	{
		[XmlElement("crowd_id")]
		public string CrowdId
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
