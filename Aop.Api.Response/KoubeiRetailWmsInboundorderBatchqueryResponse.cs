using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsInboundorderBatchqueryResponse : AopResponse
	{
		[XmlArray("inbound_order_vo_list")]
		[XmlArrayItem("inbound_order_v_o")]
		public List<InboundOrderVO> InboundOrderVoList
		{
			get;
			set;
		}
	}
}
