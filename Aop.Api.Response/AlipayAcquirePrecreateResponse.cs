using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAcquirePrecreateResponse : AopResponse
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

		[XmlElement("error")]
		public string Error
		{
			get;
			set;
		}

		[XmlElement("is_success")]
		public string IsSuccess
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

		[XmlElement("pic_url")]
		public string PicUrl
		{
			get;
			set;
		}

		[XmlElement("qr_code")]
		public string QrCode
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

		[XmlElement("voucher_type")]
		public string VoucherType
		{
			get;
			set;
		}
	}
}
