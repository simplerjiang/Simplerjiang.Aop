using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataMallCheckGetResponse : AopResponse
	{
		[XmlArray("data_results")]
		[XmlArrayItem("data_sec_check_result")]
		public List<DataSecCheckResult> DataResults
		{
			get;
			set;
		}
	}
}
