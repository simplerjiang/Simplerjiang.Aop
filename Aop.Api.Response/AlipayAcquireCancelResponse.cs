using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAcquireCancelResponse : AopResponse
	{
		[XmlElement("detail_error_code")]
		public string DetailErrorCode
		{
			get;
			set;
		}

		[XmlElement("detail_error_des")]
		public string DetailErrorDes
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

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("retry_flag")]
		public string RetryFlag
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
