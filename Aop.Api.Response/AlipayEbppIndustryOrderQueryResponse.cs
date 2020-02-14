using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppIndustryOrderQueryResponse : AopResponse
	{
		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_pay")]
		public string GmtPay
		{
			get;
			set;
		}

		[XmlElement("gmt_refund")]
		public string GmtRefund
		{
			get;
			set;
		}

		[XmlElement("gmt_success")]
		public string GmtSuccess
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
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
	}
}
