using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieSpaceMemberCreateModel : AopObject
	{
		[XmlElement("nick")]
		public string Nick
		{
			get;
			set;
		}

		[XmlElement("origin_user_id")]
		public string OriginUserId
		{
			get;
			set;
		}
	}
}
