using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsOutboundorderBatchqueryResponse : AopResponse
	{
		[XmlArray("outbound_order_vo_list")]
		[XmlArrayItem("outbound_order_v_o")]
		public List<OutboundOrderVO> OutboundOrderVoList
		{
			get;
			set;
		}
	}
}
