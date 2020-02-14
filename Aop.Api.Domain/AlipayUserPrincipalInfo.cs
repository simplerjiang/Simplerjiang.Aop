using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserPrincipalInfo : AopObject
	{
		[XmlElement("email")]
		public string Email
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
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
