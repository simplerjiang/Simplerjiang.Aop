using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeBatchSettleModel : AopObject
	{
		[XmlElement("biz_product")]
		public string BizProduct
		{
			get;
			set;
		}

		[XmlElement("extend_params")]
		public string ExtendParams
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}

		[XmlArray("settle_clauses")]
		[XmlArrayItem("settle_clause")]
		public List<SettleClause> SettleClauses
		{
			get;
			set;
		}
	}
}
