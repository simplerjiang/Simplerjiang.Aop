using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailKbcodeQueryResponse : AopResponse
	{
		[XmlArray("code_info_list")]
		[XmlArrayItem("retail_kbcode_query_vo")]
		public List<RetailKbcodeQueryVo> CodeInfoList
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public long TotalCount
		{
			get;
			set;
		}
	}
}
