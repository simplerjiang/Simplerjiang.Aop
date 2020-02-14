using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDaoweiSpScheduleModifyModel : AopObject
	{
		[XmlElement("calendar_schedule")]
		public CalendarScheduleInfo CalendarSchedule
		{
			get;
			set;
		}

		[XmlElement("out_sp_id")]
		public string OutSpId
		{
			get;
			set;
		}
	}
}
