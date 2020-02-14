using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiShopMallPageModifyResponse : AopResponse
	{
		[XmlElement("order_flow_id")]
		public string OrderFlowId
		{
			get;
			set;
		}
	}
}
