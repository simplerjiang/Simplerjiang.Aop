using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeOrderPayModel : AopObject
	{
		[XmlElement("buyer_id")]
		public string BuyerId
		{
			get;
			set;
		}

		[XmlArray("buyer_pay_detail")]
		[XmlArrayItem("buyer_pay_detail")]
		public List<BuyerPayDetail> BuyerPayDetail
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
