using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCustomerEpCertificationInitializeResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}
	}
}
