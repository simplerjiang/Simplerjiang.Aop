using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSceneprodBillSyncResponse : AopResponse
	{
		[XmlElement("trace_id")]
		public string TraceId
		{
			get;
			set;
		}
	}
}
