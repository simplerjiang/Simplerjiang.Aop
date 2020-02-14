using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceInfo : AopObject
	{
		[XmlElement("details")]
		public string Details
		{
			get;
			set;
		}

		[XmlElement("key_info")]
		public InvoiceKeyInfo KeyInfo
		{
			get;
			set;
		}
	}
}
