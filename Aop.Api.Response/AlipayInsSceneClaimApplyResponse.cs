using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneClaimApplyResponse : AopResponse
	{
		[XmlElement("claim_report_no")]
		public string ClaimReportNo
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
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
	}
}
