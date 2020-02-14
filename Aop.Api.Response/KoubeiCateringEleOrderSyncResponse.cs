using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringEleOrderSyncResponse : AopResponse
	{
		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}
	}
}
