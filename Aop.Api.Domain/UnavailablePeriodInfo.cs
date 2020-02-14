using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class UnavailablePeriodInfo : AopObject
	{
		[XmlElement("end_day")]
		public string EndDay
		{
			get;
			set;
		}

		[XmlElement("start_day")]
		public string StartDay
		{
			get;
			set;
		}
	}
}
