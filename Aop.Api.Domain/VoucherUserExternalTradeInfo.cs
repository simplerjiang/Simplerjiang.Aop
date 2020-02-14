using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VoucherUserExternalTradeInfo : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("consume_date")]
		public string ConsumeDate
		{
			get;
			set;
		}

		[XmlElement("consume_shop_id")]
		public string ConsumeShopId
		{
			get;
			set;
		}

		[XmlElement("external_trade_no")]
		public string ExternalTradeNo
		{
			get;
			set;
		}
	}
}
