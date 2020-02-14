using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertCommissionClausePercentageResponse : AopObject
	{
		[XmlElement("commission_rate")]
		public string CommissionRate
		{
			get;
			set;
		}

		[XmlElement("max_limit")]
		public string MaxLimit
		{
			get;
			set;
		}
	}
}
