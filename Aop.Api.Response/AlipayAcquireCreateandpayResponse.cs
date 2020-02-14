using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAcquireCreateandpayResponse : AopResponse
	{
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

		[XmlElement("extend_info")]
		public string ExtendInfo
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

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
