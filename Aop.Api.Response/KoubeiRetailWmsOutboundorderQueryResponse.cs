using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsOutboundorderQueryResponse : AopResponse
	{
		[XmlArray("outbound_order_line_list")]
		[XmlArrayItem("outbound_order_line")]
		public List<OutboundOrderLine> OutboundOrderLineList
		{
			get;
			set;
		}

		[XmlElement("outbound_order_vo")]
		public OutboundOrderVO OutboundOrderVo
		{
			get;
			set;
		}
	}
}
