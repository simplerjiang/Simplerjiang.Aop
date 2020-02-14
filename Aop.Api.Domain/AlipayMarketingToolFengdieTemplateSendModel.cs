using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingToolFengdieTemplateSendModel : AopObject
	{
		[XmlElement("operator")]
		public string Operator
		{
			get;
			set;
		}

		[XmlArray("space_ids")]
		[XmlArrayItem("string")]
		public List<string> SpaceIds
		{
			get;
			set;
		}

		[XmlElement("template_name")]
		public string TemplateName
		{
			get;
			set;
		}
	}
}
