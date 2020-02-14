using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSceneprodDataBatchqueryModel : AopObject
	{
		[XmlArray("app_seqno_list")]
		[XmlArrayItem("scene_prod_data_query_param")]
		public List<SceneProdDataQueryParam> AppSeqnoList
		{
			get;
			set;
		}
	}
}
