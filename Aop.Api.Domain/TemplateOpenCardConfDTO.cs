using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TemplateOpenCardConfDTO : AopObject
	{
		[XmlArray("card_rights")]
		[XmlArrayItem("template_rights_content_d_t_o")]
		public List<TemplateRightsContentDTO> CardRights
		{
			get;
			set;
		}

		[XmlElement("conf")]
		public string Conf
		{
			get;
			set;
		}

		[XmlElement("open_card_source_type")]
		public string OpenCardSourceType
		{
			get;
			set;
		}

		[XmlElement("open_card_url")]
		public string OpenCardUrl
		{
			get;
			set;
		}

		[XmlElement("source_app_id")]
		public string SourceAppId
		{
			get;
			set;
		}
	}
}
