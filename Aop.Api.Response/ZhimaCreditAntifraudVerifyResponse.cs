using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditAntifraudVerifyResponse : AopResponse
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

		[XmlElement("solution_id")]
		public string SolutionId
		{
			get;
			set;
		}

		[XmlArray("verify_code")]
		[XmlArrayItem("string")]
		public List<string> VerifyCode
		{
			get;
			set;
		}
	}
}
