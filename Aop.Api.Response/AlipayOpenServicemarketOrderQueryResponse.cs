using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenServicemarketOrderQueryResponse : AopResponse
	{
		[XmlElement("commodity_id")]
		public string CommodityId
		{
			get;
			set;
		}

		[XmlElement("current_page")]
		public long CurrentPage
		{
			get;
			set;
		}

		[XmlArray("order_items")]
		[XmlArrayItem("order_item")]
		public List<OrderItem> OrderItems
		{
			get;
			set;
		}

		[XmlElement("specifications")]
		public string Specifications
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("total_size")]
		public long TotalSize
		{
			get;
			set;
		}
	}
}
