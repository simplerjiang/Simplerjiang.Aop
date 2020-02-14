using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Sale : AopObject
	{
		[XmlElement("describe")]
		public string Describe
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
