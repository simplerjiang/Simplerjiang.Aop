using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TableInfoResult : AopObject
	{
		[XmlArray("table_info_list")]
		[XmlArrayItem("table_list_result")]
		public List<TableListResult> TableInfoList
		{
			get;
			set;
		}
	}
}
