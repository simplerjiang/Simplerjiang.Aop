using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingVoucherConfirmResponse : AopResponse
	{
		[XmlElement("need_redirect")]
		public bool NeedRedirect
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

		[XmlElement("redirect_uri")]
		public string RedirectUri
		{
			get;
			set;
		}

		[XmlElement("send_code")]
		public string SendCode
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}

		[XmlElement("theme")]
		public string Theme
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
