using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceDetailOutputQueryModel : AopObject
	{
		[XmlElement("invoice_code")]
		public string InvoiceCode
		{
			get;
			set;
		}

		[XmlElement("invoice_no")]
		public string InvoiceNo
		{
			get;
			set;
		}

		[XmlElement("scene")]
		public string Scene
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
