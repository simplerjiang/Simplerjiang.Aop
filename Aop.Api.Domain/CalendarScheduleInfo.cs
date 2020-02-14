using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CalendarScheduleInfo : AopObject
	{
		[XmlElement("duration")]
		public long Duration
		{
			get;
			set;
		}

		[XmlArray("schedule")]
		[XmlArrayItem("schedule_info")]
		public List<ScheduleInfo> Schedule
		{
			get;
			set;
		}

		[XmlElement("unit")]
		public string Unit
		{
			get;
			set;
		}
	}
}
