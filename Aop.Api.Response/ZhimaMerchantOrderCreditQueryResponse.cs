using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantOrderCreditQueryResponse : AopResponse
	{
		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("cost")]
		public string Cost
		{
			get;
			set;
		}

		[XmlElement("credit_amount")]
		public string CreditAmount
		{
			get;
			set;
		}

		[XmlElement("deposit")]
		public string Deposit
		{
			get;
			set;
		}

		[XmlElement("finish_time")]
		public string FinishTime
		{
			get;
			set;
		}

		[XmlElement("fund_type")]
		public string FundType
		{
			get;
			set;
		}

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlElement("order_time")]
		public string OrderTime
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("zm_order_no")]
		public string ZmOrderNo
		{
			get;
			set;
		}
	}
}
