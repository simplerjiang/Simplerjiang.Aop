using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceTaxnoBatchqueryModel : AopObject
	{
		[XmlElement("end_invoice_date")]
		public string EndInvoiceDate
		{
			get;
			set;
		}

		[XmlArray("invoice_kind_list")]
		[XmlArrayItem("string")]
		public List<string> InvoiceKindList
		{
			get;
			set;
		}

		[XmlElement("limit_size")]
		public long LimitSize
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

		[XmlElement("start_invoice_date")]
		public string StartInvoiceDate
		{
			get;
			set;
		}

		[XmlElement("tax_no")]
		public string TaxNo
		{
			get;
			set;
		}
	}
}
