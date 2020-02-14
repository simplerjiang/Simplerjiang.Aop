using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAgentCreateModel : AopObject
	{
		[XmlElement("account")]
		public string Account
		{
			get;
			set;
		}

		[XmlElement("contact_info")]
		public ContactModel ContactInfo
		{
			get;
			set;
		}

		[XmlElement("order_ticket")]
		public string OrderTicket
		{
			get;
			set;
		}
	}
}
