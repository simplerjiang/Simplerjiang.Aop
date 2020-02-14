using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoServiceCouponVerifyResponse : AopResponse
	{
		[XmlElement("biz_success")]
		public bool BizSuccess
		{
			get;
			set;
		}
	}
}
