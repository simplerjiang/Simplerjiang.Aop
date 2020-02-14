using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TemplateActionMiniAppUrlDTO : AopObject
	{
		[XmlElement("display_on_list")]
		public string DisplayOnList
		{
			get;
			set;
		}

		[XmlElement("mini_app_id")]
		public string MiniAppId
		{
			get;
			set;
		}

		[XmlElement("mini_page_param")]
		public string MiniPageParam
		{
			get;
			set;
		}

		[XmlElement("mini_query_param")]
		public string MiniQueryParam
		{
			get;
			set;
		}
	}
}
