using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserCertifyActionApplyResponse : AopResponse
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}
	}
}
