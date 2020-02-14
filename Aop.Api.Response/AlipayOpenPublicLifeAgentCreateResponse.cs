using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLifeAgentCreateResponse : AopResponse
	{
		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}
	}
}
