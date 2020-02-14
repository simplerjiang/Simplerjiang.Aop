using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenServicemarketOrderQueryModel : AopObject
	{
		[XmlElement("commodity_order_id")]
		public string CommodityOrderId
		{
			get;
			set;
		}

		[XmlElement("start_page")]
		public string StartPage
		{
			get;
			set;
		}
	}
}
