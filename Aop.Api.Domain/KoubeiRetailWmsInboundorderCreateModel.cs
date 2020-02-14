using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsInboundorderCreateModel : AopObject
	{
		[XmlElement("inbound_order")]
		public InboundOrder InboundOrder
		{
			get;
			set;
		}

		[XmlElement("operate_context")]
		public OperateContext OperateContext
		{
			get;
			set;
		}

		[XmlArray("order_lines")]
		[XmlArrayItem("inbound_order_line")]
		public List<InboundOrderLine> OrderLines
		{
			get;
			set;
		}
	}
}
