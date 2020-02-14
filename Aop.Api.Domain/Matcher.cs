using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Matcher : AopObject
	{
		[XmlElement("identity_card")]
		public string IdentityCard
		{
			get;
			set;
		}

		[XmlElement("mobile_no")]
		public string MobileNo
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
