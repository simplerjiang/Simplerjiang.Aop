using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieTemplateListRespModel : AopObject
	{
		[XmlArray("list")]
		[XmlArrayItem("fengdie_template_detail_model")]
		public List<FengdieTemplateDetailModel> List
		{
			get;
			set;
		}

		[XmlElement("paginator")]
		public FengdieListPaginator Paginator
		{
			get;
			set;
		}
	}
}
