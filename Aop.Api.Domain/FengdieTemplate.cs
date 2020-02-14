using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieTemplate : AopObject
	{
		[XmlElement("id")]
		public long Id
		{
			get;
			set;
		}

		[XmlArray("maintainer")]
		[XmlArrayItem("string")]
		public List<string> Maintainer
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("snapshot")]
		public string Snapshot
		{
			get;
			set;
		}

		[XmlElement("summary")]
		public string Summary
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
