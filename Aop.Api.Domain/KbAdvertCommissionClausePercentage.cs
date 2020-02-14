using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertCommissionClausePercentage : AopObject
	{
		[XmlElement("commission_rate_end")]
		public string CommissionRateEnd
		{
			get;
			set;
		}

		[XmlElement("commission_rate_start")]
		public string CommissionRateStart
		{
			get;
			set;
		}

		[XmlElement("max_limit_end")]
		public string MaxLimitEnd
		{
			get;
			set;
		}

		[XmlElement("max_limit_start")]
		public string MaxLimitStart
		{
			get;
			set;
		}
	}
}
