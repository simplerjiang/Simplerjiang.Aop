using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditAntifraudScoreGetResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("decision_result")]
		public string DecisionResult
		{
			get;
			set;
		}

		[XmlElement("score")]
		public long Score
		{
			get;
			set;
		}

		[XmlElement("solution_id")]
		public string SolutionId
		{
			get;
			set;
		}
	}
}
