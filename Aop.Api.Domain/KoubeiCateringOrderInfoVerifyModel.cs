using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringOrderInfoVerifyModel : AopObject
	{
		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("verify_order_id")]
		public string VerifyOrderId
		{
			get;
			set;
		}
	}
}
