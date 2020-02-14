using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceFileQueryModel : AopObject
	{
		[XmlElement("invoice_id")]
		public string InvoiceId
		{
			get;
			set;
		}
	}
}
