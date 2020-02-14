using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserUnicomOrderInfoSyncResponse : AopResponse
	{
		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("order_sync_result")]
		public string OrderSyncResult
		{
			get;
			set;
		}
	}
}
