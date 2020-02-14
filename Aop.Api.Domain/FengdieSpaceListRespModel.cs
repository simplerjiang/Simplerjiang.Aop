using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieSpaceListRespModel : AopObject
	{
		[XmlArray("list")]
		[XmlArrayItem("fengdie_space_detail_model")]
		public List<FengdieSpaceDetailModel> List
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
