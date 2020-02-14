using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ScheduleInfo : AopObject
	{
		[XmlElement("bitmap")]
		public string Bitmap
		{
			get;
			set;
		}

		[XmlElement("date")]
		public string Date
		{
			get;
			set;
		}
	}
}
