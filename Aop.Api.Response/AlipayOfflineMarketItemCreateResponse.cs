using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketItemCreateResponse : AopResponse
	{
		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}
