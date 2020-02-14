using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertCommissionClauseResponse : AopObject
	{
		[XmlElement("percentage_clause")]
		public KbAdvertCommissionClausePercentageResponse PercentageClause
		{
			get;
			set;
		}

		[XmlElement("quota_clause")]
		public KbAdvertCommissionClauseQuotaResponse QuotaClause
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
