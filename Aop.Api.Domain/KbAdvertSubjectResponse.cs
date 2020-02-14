using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertSubjectResponse : AopObject
	{
		[XmlElement("commission_clause")]
		public KbAdvertCommissionClauseResponse CommissionClause
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
		public KbAdvertSubjectVoucherResponse Voucher
		{
			get;
			set;
		}
	}
}
