using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCustomerEpCertificationQueryResponse : AopResponse
	{
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
