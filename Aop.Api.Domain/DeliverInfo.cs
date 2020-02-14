using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DeliverInfo : AopObject
	{
		[XmlElement("recipients_address")]
		public string RecipientsAddress
		{
			get;
			set;
		}

		[XmlElement("recipients_address_code")]
		public string RecipientsAddressCode
		{
			get;
			set;
		}

		[XmlElement("recipients_name")]
		public string RecipientsName
		{
			get;
			set;
		}

		[XmlElement("recipients_phone")]
		public string RecipientsPhone
		{
			get;
			set;
		}
	}
}
