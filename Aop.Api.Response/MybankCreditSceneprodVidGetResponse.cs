using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSceneprodVidGetResponse : AopResponse
	{
		[XmlElement("retry")]
		public string Retry
		{
			get;
			set;
		}

		[XmlElement("trace_id")]
		public string TraceId
		{
			get;
			set;
		}

		[XmlElement("verify_id")]
		public string VerifyId
		{
			get;
			set;
		}
	}
}
