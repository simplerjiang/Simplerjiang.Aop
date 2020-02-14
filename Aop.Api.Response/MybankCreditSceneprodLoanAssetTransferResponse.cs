using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSceneprodLoanAssetTransferResponse : AopResponse
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
	}
}
