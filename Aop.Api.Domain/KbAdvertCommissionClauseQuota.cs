using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertCommissionClauseQuota : AopObject
	{
		[XmlElement("quota_amount_end")]
		public string QuotaAmountEnd
		{
			get;
			set;
		}

		[XmlElement("quota_amount_start")]
		public string QuotaAmountStart
		{
			get;
			set;
		}
	}
}
