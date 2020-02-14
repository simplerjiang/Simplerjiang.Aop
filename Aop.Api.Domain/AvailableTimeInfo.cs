using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AvailableTimeInfo : AopObject
	{
		[XmlArray("available_days")]
		[XmlArrayItem("number")]
		public List<long> AvailableDays
		{
			get;
			set;
		}

		[XmlElement("from_time")]
		public string FromTime
		{
			get;
			set;
		}

		[XmlElement("limit_period_unit")]
		public string LimitPeriodUnit
		{
			get;
			set;
		}

		[XmlElement("to_time")]
		public string ToTime
		{
			get;
			set;
		}
	}
}
