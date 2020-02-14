using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppProdmodeProvcityQueryResponse : AopResponse
	{
		[XmlArray("data_list")]
		[XmlArrayItem("query_prov_city_info")]
		public List<QueryProvCityInfo> DataList
		{
			get;
			set;
		}
	}
}
