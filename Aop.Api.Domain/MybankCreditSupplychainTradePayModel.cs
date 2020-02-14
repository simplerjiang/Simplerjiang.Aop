using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSupplychainTradePayModel : AopObject
	{
		[XmlElement("buyer")]
		public Member Buyer
		{
			get;
			set;
		}

		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("ext_data")]
		public string ExtData
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("pay_amount")]
		public string PayAmount
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("sale_pd_code")]
		public string SalePdCode
		{
			get;
			set;
		}

		[XmlElement("trade_type")]
		public string TradeType
		{
			get;
			set;
		}
	}
}
