using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiSalesKbassetStuffProduceorderBatchqueryResponse : AopResponse
	{
		[XmlElement("has_next_page")]
		public bool HasNextPage
		{
			get;
			set;
		}

		[XmlArray("list")]
		[XmlArrayItem("access_produce_order")]
		public List<AccessProduceOrder> List
		{
			get;
			set;
		}
	}
}
