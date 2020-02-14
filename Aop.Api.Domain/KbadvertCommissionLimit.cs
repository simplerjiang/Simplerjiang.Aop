using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbadvertCommissionLimit : AopObject
	{
		[XmlElement("commission_user_type")]
		public string CommissionUserType
		{
			get;
			set;
		}

		[XmlElement("level")]
		public long Level
		{
			get;
			set;
		}

		[XmlElement("max_max_amount")]
		public string MaxMaxAmount
		{
			get;
			set;
		}

		[XmlElement("max_quota_amount")]
		public string MaxQuotaAmount
		{
			get;
			set;
		}

		[XmlElement("min_commission_percentage")]
		public string MinCommissionPercentage
		{
			get;
			set;
		}

		[XmlElement("min_quota_amount")]
		public string MinQuotaAmount
		{
			get;
			set;
		}
	}
}
