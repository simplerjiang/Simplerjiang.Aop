using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayItemDescription : AopObject
	{
		[XmlArray("details")]
		[XmlArrayItem("string")]
		public List<string> Details
		{
			get;
			set;
		}

		[XmlArray("images")]
		[XmlArrayItem("string")]
		public List<string> Images
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
