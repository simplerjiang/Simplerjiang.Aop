using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SceneMarketingHeader : AopObject
	{
		[XmlElement("icon")]
		public string Icon
		{
			get;
			set;
		}

		[XmlElement("sub_title")]
		public string SubTitle
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

		[XmlArray("tags")]
		[XmlArrayItem("string")]
		public List<string> Tags
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
