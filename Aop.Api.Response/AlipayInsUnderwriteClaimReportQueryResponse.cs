using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsUnderwriteClaimReportQueryResponse : AopResponse
	{
		[XmlArray("reports")]
		[XmlArrayItem("ins_claim_report")]
		public List<InsClaimReport> Reports
		{
			get;
			set;
		}
	}
}
