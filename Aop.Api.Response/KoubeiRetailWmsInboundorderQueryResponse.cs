using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsInboundorderQueryResponse : AopResponse
	{
		[XmlArray("inbound_order_line_list")]
		[XmlArrayItem("inbound_order_line")]
		public List<InboundOrderLine> InboundOrderLineList
		{
			get;
			set;
		}

		[XmlElement("inbound_order_vo")]
		public InboundOrderVO InboundOrderVo
		{
			get;
			set;
		}
	}
}
