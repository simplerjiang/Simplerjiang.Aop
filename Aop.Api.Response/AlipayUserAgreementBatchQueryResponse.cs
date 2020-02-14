using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAgreementBatchQueryResponse : AopResponse
	{
		[XmlArray("usage_agreement_info_list")]
		[XmlArrayItem("open_api_sign_query_response")]
		public List<OpenApiSignQueryResponse> UsageAgreementInfoList
		{
			get;
			set;
		}
	}
}
