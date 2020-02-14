using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PointsExchangeInfo : AopObject
	{
		[XmlArray("ids")]
		[XmlArrayItem("string")]
		public List<string> Ids
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
