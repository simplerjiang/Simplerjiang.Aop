using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailWmsOutboundorderCreateResponse : AopResponse
	{
		[XmlElement("outbound_order_id")]
		public string OutboundOrderId
		{
			get;
			set;
		}
	}
}
