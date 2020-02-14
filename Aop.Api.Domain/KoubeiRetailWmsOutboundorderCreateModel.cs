using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsOutboundorderCreateModel : AopObject
	{
		[XmlElement("operate_context")]
		public OperateContext OperateContext
		{
			get;
			set;
		}

		[XmlArray("order_lines")]
		[XmlArrayItem("outbound_order_line")]
		public List<OutboundOrderLine> OrderLines
		{
			get;
			set;
		}

		[XmlElement("outbound_order")]
		public OutboundOrder OutboundOrder
		{
			get;
			set;
		}
	}
}
