using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSupplychainTradeCreateModel : AopObject
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

		[XmlElement("expire_date")]
		public string ExpireDate
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

		[XmlElement("out_order_title")]
		public string OutOrderTitle
		{
			get;
			set;
		}

		[XmlElement("pay_account")]
		public Account PayAccount
		{
			get;
			set;
		}

		[XmlElement("rcv_account")]
		public Account RcvAccount
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

		[XmlElement("seller")]
		public Member Seller
		{
			get;
			set;
		}

		[XmlElement("trade_amount")]
		public string TradeAmount
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
