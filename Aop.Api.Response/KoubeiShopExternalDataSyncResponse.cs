using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiShopExternalDataSyncResponse : AopResponse
	{
		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("order_status")]
		public string OrderStatus
		{
			get;
			set;
		}
	}
}
