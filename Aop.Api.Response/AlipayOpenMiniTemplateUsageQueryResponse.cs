using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniTemplateUsageQueryResponse : AopResponse
	{
		[XmlArray("app_ids")]
		[XmlArrayItem("string")]
		public List<string> AppIds
		{
			get;
			set;
		}

		[XmlArray("template_usage_info_list")]
		[XmlArrayItem("template_usage_info")]
		public List<TemplateUsageInfo> TemplateUsageInfoList
		{
			get;
			set;
		}
	}
}
