using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringOrderInfoCreateResponse : AopResponse
	{
		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("retry")]
		public bool Retry
		{
			get;
			set;
		}
	}
}
