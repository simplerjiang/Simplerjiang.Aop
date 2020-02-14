using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditRiskEvaluateQueryResponse : AopResponse
	{
		[XmlElement("accessible")]
		public bool Accessible
		{
			get;
			set;
		}

		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("limit_level")]
		public string LimitLevel
		{
			get;
			set;
		}

		[XmlElement("risk_code")]
		public string RiskCode
		{
			get;
			set;
		}

		[XmlElement("score_level")]
		public string ScoreLevel
		{
			get;
			set;
		}
	}
}
