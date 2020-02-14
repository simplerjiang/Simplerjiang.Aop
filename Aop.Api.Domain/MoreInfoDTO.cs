using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MoreInfoDTO : AopObject
	{
		[XmlArray("descs")]
		[XmlArrayItem("string")]
		public List<string> Descs
		{
			get;
			set;
		}

		[XmlElement("params")]
		public string Params
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

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
