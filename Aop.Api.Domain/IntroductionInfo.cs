using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IntroductionInfo : AopObject
	{
		[XmlArray("image_urls")]
		[XmlArrayItem("string")]
		public List<string> ImageUrls
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
