using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenServicemarketOrderRejectModel : AopObject
	{
		[XmlElement("commodity_order_id")]
		public string CommodityOrderId
		{
			get;
			set;
		}

		[XmlElement("reject_reason")]
		public string RejectReason
		{
			get;
			set;
		}
	}
}
