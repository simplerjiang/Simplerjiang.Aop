using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EduAgeDemand : AopObject
	{
		[XmlElement("age_end")]
		public string AgeEnd
		{
			get;
			set;
		}

		[XmlElement("age_start")]
		public string AgeStart
		{
			get;
			set;
		}
	}
}
