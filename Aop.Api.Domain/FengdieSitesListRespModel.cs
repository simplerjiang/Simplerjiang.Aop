using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieSitesListRespModel : AopObject
	{
		[XmlArray("list")]
		[XmlArrayItem("fengdie_sites_list_model")]
		public List<FengdieSitesListModel> List
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
