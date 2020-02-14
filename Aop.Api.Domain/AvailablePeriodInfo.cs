using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AvailablePeriodInfo : AopObject
	{
		[XmlElement("available_week_days")]
		public string AvailableWeekDays
		{
			get;
			set;
		}

		[XmlElement("time_end")]
		public string TimeEnd
		{
			get;
			set;
		}

		[XmlElement("time_start")]
		public string TimeStart
		{
			get;
			set;
		}
	}
}
