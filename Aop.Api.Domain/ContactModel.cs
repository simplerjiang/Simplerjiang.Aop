using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ContactModel : AopObject
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
	}
}
