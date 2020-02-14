using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransOrderQueryResponse : AopResponse
	{
		[XmlElement("arrival_time_end")]
		public string ArrivalTimeEnd
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("fail_reason")]
		public string FailReason
		{
			get;
			set;
		}

		[XmlElement("order_fee")]
		public string OrderFee
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("pay_date")]
		public string PayDate
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
