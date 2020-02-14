using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceLogisticsUserOrderQueryResponse : AopResponse
	{
		[XmlElement("order_info")]
		public string OrderInfo
		{
			get;
			set;
		}
	}
}
