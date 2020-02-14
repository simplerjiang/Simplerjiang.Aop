using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ContactPersonInfo : AopObject
	{
		[XmlElement("contact_email")]
		public string ContactEmail
		{
			get;
			set;
		}

		[XmlElement("contact_mobile")]
		public string ContactMobile
		{
			get;
			set;
		}

		[XmlElement("contact_name")]
		public string ContactName
		{
			get;
			set;
		}

		[XmlElement("contact_type")]
		public string ContactType
		{
			get;
			set;
		}
	}
}
