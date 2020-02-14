using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskCustomerriskrankGetResponse : AopResponse
	{
		[XmlElement("has_risk")]
		public bool HasRisk
		{
			get;
			set;
		}

		[XmlArray("info_code")]
		[XmlArrayItem("risk_rank_info_code")]
		public List<RiskRankInfoCode> InfoCode
		{
			get;
			set;
		}

		[XmlElement("risk_rank")]
		public long RiskRank
		{
			get;
			set;
		}

		[XmlElement("risk_score")]
		public long RiskScore
		{
			get;
			set;
		}
	}
}
