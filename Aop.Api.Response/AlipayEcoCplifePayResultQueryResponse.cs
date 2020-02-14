using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifePayResultQueryResponse : AopResponse
	{
		[XmlElement("assoc_bill_details")]
		public TradeAssocBillDetails AssocBillDetails
		{
			get;
			set;
		}

		[XmlElement("biz_entity_id")]
		public string BizEntityId
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("buyer_logon_id")]
		public string BuyerLogonId
		{
			get;
			set;
		}

		[XmlElement("buyer_user_id")]
		public string BuyerUserId
		{
			get;
			set;
		}

		[XmlElement("fund_bill_list")]
		public FundBillListEco FundBillList
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

		[XmlElement("seller_id")]
		public string SellerId
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

		[XmlElement("trade_status")]
		public string TradeStatus
		{
			get;
			set;
		}
	}
}
