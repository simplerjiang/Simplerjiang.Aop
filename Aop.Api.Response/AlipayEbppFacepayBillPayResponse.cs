using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppFacepayBillPayResponse : AopResponse
	{
		[XmlElement("bill_no")]
		public string BillNo
		{
			get;
			set;
		}

		[XmlElement("biz_status")]
		public string BizStatus
		{
			get;
			set;
		}

		[XmlElement("charge_inst")]
		public string ChargeInst
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("inst_no")]
		public string InstNo
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

		[XmlElement("trade_date")]
		public string TradeDate
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
