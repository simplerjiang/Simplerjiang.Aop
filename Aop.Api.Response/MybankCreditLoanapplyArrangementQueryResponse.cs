using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoanapplyArrangementQueryResponse : AopResponse
	{
		[XmlArray("arrangement_query_result")]
		[XmlArrayItem("arrangement_open_query_result_v_o")]
		public List<ArrangementOpenQueryResultVO> ArrangementQueryResult
		{
			get;
			set;
		}
	}
}
