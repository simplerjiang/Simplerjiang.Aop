using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataFindataOperatorImgQueryResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("captcha")]
		public CaptchaInfo Captcha
		{
			get;
			set;
		}

		[XmlElement("org_biz_no")]
		public string OrgBizNo
		{
			get;
			set;
		}
	}
}
