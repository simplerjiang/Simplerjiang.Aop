using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceInfoApplyidQueryResponse : AopResponse
	{
		[XmlArray("invoice_info")]
		[XmlArrayItem("invoice_query_open_model")]
		public List<InvoiceQueryOpenModel> InvoiceInfo
		{
			get;
			set;
		}
	}
}
