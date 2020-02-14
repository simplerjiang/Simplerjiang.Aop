using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceTitleBatchqueryResponse : AopResponse
	{
		[XmlArray("invoice_element_list")]
		[XmlArrayItem("invoice_element_model")]
		public List<InvoiceElementModel> InvoiceElementList
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public long TotalCount
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
