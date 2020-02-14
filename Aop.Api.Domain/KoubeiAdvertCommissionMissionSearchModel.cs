using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionMissionSearchModel : AopObject
	{
		[XmlElement("commission_clause_type")]
		public string CommissionClauseType
		{
			get;
			set;
		}

		[XmlElement("page_index")]
		public string PageIndex
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlElement("percentage_clause")]
		public KbAdvertCommissionClausePercentage PercentageClause
		{
			get;
			set;
		}

		[XmlElement("quota_clause")]
		public KbAdvertCommissionClauseQuota QuotaClause
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

		[XmlElement("voucher")]
		public KbAdvertSubjectVoucher Voucher
		{
			get;
			set;
		}
	}
}
