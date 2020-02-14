using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicMenuDataBatchqueryResponse : AopResponse
	{
		[XmlArray("data_list")]
		[XmlArrayItem("menu_analysis_data")]
		public List<MenuAnalysisData> DataList
		{
			get;
			set;
		}
	}
}
