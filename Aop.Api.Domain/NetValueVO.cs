using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class NetValueVO : AopObject
	{
		[XmlElement("net_value")]
		public string NetValue
		{
			get;
			set;
		}

		[XmlElement("net_value_date")]
		public string NetValueDate
		{
			get;
			set;
		}

		[XmlElement("profit_seven_days")]
		public string ProfitSevenDays
		{
			get;
			set;
		}

		[XmlElement("profit_ten_thousand")]
		public string ProfitTenThousand
		{
			get;
			set;
		}
	}
}
