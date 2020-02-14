using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentClauseTerm : AopObject
	{
		[XmlArray("descriptions")]
		[XmlArrayItem("string")]
		public List<string> Descriptions
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
