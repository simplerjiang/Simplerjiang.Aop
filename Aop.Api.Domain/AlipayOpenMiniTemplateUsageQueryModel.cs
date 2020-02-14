using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniTemplateUsageQueryModel : AopObject
	{
		[XmlElement("page_num")]
		public long PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
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

		[XmlElement("template_version")]
		public string TemplateVersion
		{
			get;
			set;
		}
	}
}
