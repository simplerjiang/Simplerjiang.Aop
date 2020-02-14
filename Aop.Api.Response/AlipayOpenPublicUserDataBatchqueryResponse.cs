using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicUserDataBatchqueryResponse : AopResponse
	{
		[XmlArray("data_list")]
		[XmlArrayItem("user_analysis_data")]
		public List<UserAnalysisData> DataList
		{
			get;
			set;
		}
	}
}
