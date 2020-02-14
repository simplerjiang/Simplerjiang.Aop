using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceTitleListGetResponse : AopResponse
	{
		[XmlArray("title_list")]
		[XmlArrayItem("invoice_title_model")]
		public List<InvoiceTitleModel> TitleList
		{
			get;
			set;
		}
	}
}
