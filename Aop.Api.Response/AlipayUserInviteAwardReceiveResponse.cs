using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserInviteAwardReceiveResponse : AopResponse
	{
		[XmlElement("alipay_account_no")]
		public string AlipayAccountNo
		{
			get;
			set;
		}

		[XmlElement("biz_result_code")]
		public string BizResultCode
		{
			get;
			set;
		}

		[XmlElement("biz_result_desc")]
		public string BizResultDesc
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("user_attr")]
		public string UserAttr
		{
			get;
			set;
		}
	}
}
