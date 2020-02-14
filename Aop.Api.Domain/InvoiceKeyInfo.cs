using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceKeyInfo : AopObject
	{
		[XmlElement("invoice_merchant_name")]
		public string InvoiceMerchantName
		{
			get;
			set;
		}

		[XmlElement("is_support_invoice")]
		public bool IsSupportInvoice
		{
			get;
			set;
		}

		[XmlElement("tax_num")]
		public string TaxNum
		{
			get;
			set;
		}
	}
}
