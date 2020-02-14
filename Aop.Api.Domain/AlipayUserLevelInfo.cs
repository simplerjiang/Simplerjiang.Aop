using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserLevelInfo : AopObject
	{
		[XmlElement("login_id")]
		public string LoginId
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

		[XmlElement("user_level")]
		public string UserLevel
		{
			get;
			set;
		}
	}
}
