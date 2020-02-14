using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAccountExrateRatequeryResponse : AopResponse
	{
		[XmlArray("rate_query_response_list")]
		[XmlArrayItem("ex_ref_rate_info_v_o")]
		public List<ExRefRateInfoVO> RateQueryResponseList
		{
			get;
			set;
		}
	}
}
