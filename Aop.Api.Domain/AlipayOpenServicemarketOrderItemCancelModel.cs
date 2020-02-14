using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenServicemarketOrderItemCancelModel : AopObject
	{
		[XmlElement("cancel_reason")]
		public string CancelReason
		{
			get;
			set;
		}

		[XmlElement("commodity_order_id")]
		public string CommodityOrderId
		{
			get;
			set;
		}

		[XmlElement("mini_app_id")]
		public string MiniAppId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}
	}
}
