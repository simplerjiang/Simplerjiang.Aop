using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCreditAutofinanceDataBatchqueryModel : AopObject
	{
		[XmlArray("app_seqno_list")]
		[XmlArrayItem("scene_data_query_param")]
		public List<SceneDataQueryParam> AppSeqnoList
		{
			get;
			set;
		}
	}
}
