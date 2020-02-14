using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PeriodInfo : AopObject
	{
		[XmlElement("dimension")]
		public string Dimension
		{
			get;
			set;
		}

		[XmlElement("value")]
		public long Value
		{
			get;
			set;
		}
	}
}
