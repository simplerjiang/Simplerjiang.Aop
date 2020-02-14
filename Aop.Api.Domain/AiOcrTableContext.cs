using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AiOcrTableContext : AopObject
	{
		[XmlElement("ex")]
		public long Ex
		{
			get;
			set;
		}

		[XmlElement("ey")]
		public long Ey
		{
			get;
			set;
		}

		[XmlElement("height")]
		public long Height
		{
			get;
			set;
		}

		[XmlElement("sx")]
		public long Sx
		{
			get;
			set;
		}

		[XmlElement("sy")]
		public long Sy
		{
			get;
			set;
		}

		[XmlArray("text")]
		[XmlArrayItem("string")]
		public List<string> Text
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

		[XmlElement("width")]
		public long Width
		{
			get;
			set;
		}
	}
}
