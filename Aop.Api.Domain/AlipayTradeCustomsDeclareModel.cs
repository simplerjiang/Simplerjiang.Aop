using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeCustomsDeclareModel : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("buyer_info")]
		public CustomsDeclareBuyerInfo BuyerInfo
		{
			get;
			set;
		}

		[XmlElement("customs_place")]
		public string CustomsPlace
		{
			get;
			set;
		}

		[XmlElement("is_split")]
		public string IsSplit
		{
			get;
			set;
		}

		[XmlElement("merchant_customs_code")]
		public string MerchantCustomsCode
		{
			get;
			set;
		}

		[XmlElement("merchant_customs_name")]
		public string MerchantCustomsName
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}

		[XmlElement("sub_out_biz_no")]
		public string SubOutBizNo
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
