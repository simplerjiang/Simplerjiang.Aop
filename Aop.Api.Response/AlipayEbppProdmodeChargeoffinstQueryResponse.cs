using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppProdmodeChargeoffinstQueryResponse : AopResponse
	{
		[XmlArray("data_list")]
		[XmlArrayItem("biz_list_data_info")]
		public List<BizListDataInfo> DataList
		{
			get;
			set;
		}
	}
}
