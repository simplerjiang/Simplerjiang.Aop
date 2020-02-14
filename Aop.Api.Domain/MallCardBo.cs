using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MallCardBo : AopObject
	{
		[XmlArray("benefit_desc")]
		[XmlArrayItem("string")]
		public List<string> BenefitDesc
		{
			get;
			set;
		}

		[XmlElement("card_logo_url")]
		public string CardLogoUrl
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("level_show_name")]
		public string LevelShowName
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

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
