using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCustomerEpCertificationCertifyResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("failed_reason")]
		public string FailedReason
		{
			get;
			set;
		}

		[XmlElement("passed")]
		public string Passed
		{
			get;
			set;
		}
	}
}
