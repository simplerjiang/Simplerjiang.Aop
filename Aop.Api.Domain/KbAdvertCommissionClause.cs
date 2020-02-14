using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertCommissionClause : AopObject
	{
		[XmlElement("clause_type")]
		public string ClauseType
		{
			get;
			set;
		}

		[XmlElement("percentage_clause")]
		public KbAdvertPercentageCommissionClause PercentageClause
		{
			get;
			set;
		}

		[XmlElement("preserve_clause")]
		public KbAdvertPreserveCommissionClause PreserveClause
		{
			get;
			set;
		}

		[XmlElement("quota_clause")]
		public KbAdvertQuotaCommissionClause QuotaClause
		{
			get;
			set;
		}
	}
}
