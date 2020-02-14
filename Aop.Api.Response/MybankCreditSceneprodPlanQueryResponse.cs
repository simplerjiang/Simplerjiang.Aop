using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSceneprodPlanQueryResponse : AopResponse
	{
		[XmlElement("loan_plan")]
		public string LoanPlan
		{
			get;
			set;
		}

		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}

		[XmlElement("retry")]
		public string Retry
		{
			get;
			set;
		}

		[XmlElement("sign_time")]
		public string SignTime
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
