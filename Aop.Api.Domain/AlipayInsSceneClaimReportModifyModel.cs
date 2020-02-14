using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneClaimReportModifyModel : AopObject
	{
		[XmlElement("accident_address")]
		public string AccidentAddress
		{
			get;
			set;
		}

		[XmlElement("accident_desc")]
		public string AccidentDesc
		{
			get;
			set;
		}

		[XmlElement("accident_time")]
		public string AccidentTime
		{
			get;
			set;
		}

		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("claim_report_no")]
		public string ClaimReportNo
		{
			get;
			set;
		}
	}
}
