using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ValidDateInfo : AopObject
	{
		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("relative_time")]
		public PeriodInfo RelativeTime
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}

		[XmlElement("time_mode")]
		public string TimeMode
		{
			get;
			set;
		}
	}
}
