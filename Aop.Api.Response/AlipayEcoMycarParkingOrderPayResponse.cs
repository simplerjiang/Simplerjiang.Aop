using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarParkingOrderPayResponse : AopResponse
	{
		[XmlElement("fund_bill_list")]
		public string FundBillList
		{
			get;
			set;
		}

		[XmlElement("gmt_payment")]
		public string GmtPayment
		{
			get;
			set;
		}

		[XmlElement("out_trade_no")]
		public string OutTradeNo
		{
			get;
			set;
		}

		[XmlElement("total_fee")]
		public string TotalFee
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
