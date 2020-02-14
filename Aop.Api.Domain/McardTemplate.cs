using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class McardTemplate : AopObject
	{
		[XmlElement("card_type")]
		public string CardType
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
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

		[XmlElement("template_style_info")]
		public TemplateStyleInfoDTO TemplateStyleInfo
		{
			get;
			set;
		}
	}
}
