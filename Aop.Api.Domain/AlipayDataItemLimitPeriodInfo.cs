using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataItemLimitPeriodInfo : AopObject
	{
		[XmlElement("rule")]
		public string Rule
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

		[XmlArray("value")]
		[XmlArrayItem("number")]
		public List<long> Value
		{
			get;
			set;
		}
	}
}
