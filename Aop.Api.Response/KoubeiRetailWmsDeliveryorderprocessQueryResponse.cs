using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsDeliveryorderprocessQueryResponse : AopResponse
	{
		[XmlArray("delivery_order_process_vo_list")]
		[XmlArrayItem("delivery_order_process_v_o")]
		public List<DeliveryOrderProcessVO> DeliveryOrderProcessVoList
		{
			get;
			set;
		}
	}
}
