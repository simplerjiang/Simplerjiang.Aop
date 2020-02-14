using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TemplateRightsContentDTO : AopObject
	{
		[XmlElement("detail")]
		public string Detail
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
