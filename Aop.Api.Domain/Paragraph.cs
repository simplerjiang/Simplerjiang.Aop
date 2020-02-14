using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Paragraph : AopObject
	{
		[XmlArray("pictures")]
		[XmlArrayItem("picture")]
		public List<Picture> Pictures
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
