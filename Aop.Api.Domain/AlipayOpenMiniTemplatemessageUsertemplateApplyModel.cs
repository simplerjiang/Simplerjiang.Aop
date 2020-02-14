using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniTemplatemessageUsertemplateApplyModel : AopObject
	{
		[XmlElement("keyword_list")]
		public string KeywordList
		{
			get;
			set;
		}

		[XmlElement("template_library_id")]
		public string TemplateLibraryId
		{
			get;
			set;
		}
	}
}
