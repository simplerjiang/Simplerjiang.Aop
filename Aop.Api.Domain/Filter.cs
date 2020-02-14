using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Filter : AopObject
	{
		[XmlElement("context")]
		public LabelContext Context
		{
			get;
			set;
		}

		[XmlElement("template")]
		public string Template
		{
			get;
			set;
		}
	}
}
