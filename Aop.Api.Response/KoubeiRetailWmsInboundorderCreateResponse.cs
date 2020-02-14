using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsInboundorderCreateResponse : AopResponse
	{
		[XmlElement("inbound_order_id")]
		public string InboundOrderId
		{
			get;
			set;
		}
	}
}
