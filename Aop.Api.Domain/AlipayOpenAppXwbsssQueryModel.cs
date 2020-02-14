using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppXwbsssQueryModel : AopObject
	{
		[XmlElement("a")]
		public string A
		{
			get;
			set;
		}

		[XmlElement("b")]
		public string B
		{
			get;
			set;
		}

		[XmlArray("c")]
		[XmlArrayItem("number")]
		public List<long> C
		{
			get;
			set;
		}

		[XmlElement("effect_date")]
		public string EffectDate
		{
			get;
			set;
		}
	}
}
