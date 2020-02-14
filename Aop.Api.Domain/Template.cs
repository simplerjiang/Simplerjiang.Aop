using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Template : AopObject
	{
		[XmlElement("context")]
		public Context Context
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
