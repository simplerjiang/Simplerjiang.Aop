using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpenPromoPrizeDimension : AopObject
	{
		[XmlElement("dimension")]
		public string Dimension
		{
			get;
			set;
		}

		[XmlArray("values")]
		[XmlArrayItem("number")]
		public List<long> Values
		{
			get;
			set;
		}
	}
}
