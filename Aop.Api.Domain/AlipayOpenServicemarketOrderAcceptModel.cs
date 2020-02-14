using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenServicemarketOrderAcceptModel : AopObject
	{
		[XmlElement("commodity_order_id")]
		public string CommodityOrderId
		{
			get;
			set;
		}
	}
}
