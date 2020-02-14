using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppBillSearchResponse : AopResponse
	{
		[XmlElement("cachekey")]
		public string Cachekey
		{
			get;
			set;
		}

		[XmlArray("inst_bill_info_list")]
		[XmlArrayItem("query_inst_bill_info")]
		public List<QueryInstBillInfo> InstBillInfoList
		{
			get;
			set;
		}
	}
}
