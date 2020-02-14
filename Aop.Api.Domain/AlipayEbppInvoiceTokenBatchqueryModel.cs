using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceTokenBatchqueryModel : AopObject
	{
		[XmlElement("invoice_token")]
		public string InvoiceToken
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
	}
}
