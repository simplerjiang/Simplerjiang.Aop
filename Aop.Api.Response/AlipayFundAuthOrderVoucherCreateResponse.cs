using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundAuthOrderVoucherCreateResponse : AopResponse
	{
		[XmlElement("code_type")]
		public string CodeType
		{
			get;
			set;
		}

		[XmlElement("code_url")]
		public string CodeUrl
		{
			get;
			set;
		}

		[XmlElement("code_value")]
		public string CodeValue
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

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}
	}
}
