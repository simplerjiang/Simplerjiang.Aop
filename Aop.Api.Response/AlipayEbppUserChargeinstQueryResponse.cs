using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppUserChargeinstQueryResponse : AopResponse
	{
		[XmlArray("data_list")]
		[XmlArrayItem("query_user_charge_inst_and_area_info")]
		public List<QueryUserChargeInstAndAreaInfo> DataList
		{
			get;
			set;
		}
	}
}
