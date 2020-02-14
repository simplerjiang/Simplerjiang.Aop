using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertQuotaCommissionClause : AopObject
	{
		[XmlElement("quota_amount")]
		public string QuotaAmount
		{
			get;
			set;
		}
	}
}
