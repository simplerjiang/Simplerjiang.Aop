using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsUnderwriteClaimReportQueryModel : AopObject
	{
		[XmlElement("claim_report_no")]
		public string ClaimReportNo
		{
			get;
			set;
		}
	}
}
