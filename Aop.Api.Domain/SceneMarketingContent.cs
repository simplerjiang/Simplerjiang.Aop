using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SceneMarketingContent : AopObject
	{
		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlElement("icon")]
		public string Icon
		{
			get;
			set;
		}

		[XmlElement("image")]
		public string Image
		{
			get;
			set;
		}

		[XmlElement("meaning")]
		public string Meaning
		{
			get;
			set;
		}

		[XmlElement("meaning_desc")]
		public string MeaningDesc
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

		[XmlArray("tips")]
		[XmlArrayItem("string")]
		public List<string> Tips
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

		[XmlElement("type")]
		public string Type
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
