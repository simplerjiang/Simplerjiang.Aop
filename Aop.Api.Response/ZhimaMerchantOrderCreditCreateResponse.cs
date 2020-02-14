using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantOrderCreditCreateResponse : AopResponse
	{
		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("order_create_time")]
		public string OrderCreateTime
		{
			get;
			set;
		}

		[XmlElement("order_status")]
		public string OrderStatus
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

		[XmlElement("page_type")]
		public string PageType
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
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
