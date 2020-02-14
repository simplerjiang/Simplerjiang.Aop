using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingMallTradeSubscribeResponse : AopResponse
	{
		[XmlElement("order_flow_id")]
		public string OrderFlowId
		{
			get;
			set;
		}
	}
}
