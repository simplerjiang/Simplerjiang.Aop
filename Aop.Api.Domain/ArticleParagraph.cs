using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ArticleParagraph : AopObject
	{
		[XmlArray("pictures")]
		[XmlArrayItem("article_picture")]
		public List<ArticlePicture> Pictures
		{
			get;
			set;
		}

		[XmlElement("text")]
		public string Text
		{
			get;
			set;
		}
	}
}
