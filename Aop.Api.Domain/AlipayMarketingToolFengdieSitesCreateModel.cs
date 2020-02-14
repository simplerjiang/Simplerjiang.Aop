using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingToolFengdieSitesCreateModel : AopObject
	{
		[XmlElement("activity")]
		public FengdieSitesCreateModel Activity
		{
			get;
			set;
		}

		[XmlElement("operator")]
		public string Operator
		{
			get;
			set;
		}

		[XmlElement("space_id")]
		public string SpaceId
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
