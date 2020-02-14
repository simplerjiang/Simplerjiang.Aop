using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsClaimReport : AopObject
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

		[XmlArray("attachments")]
		[XmlArrayItem("ins_claim_attachment")]
		public List<InsClaimAttachment> Attachments
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

		[XmlArray("claims")]
		[XmlArrayItem("ins_claim")]
		public List<InsClaim> Claims
		{
			get;
			set;
		}

		[XmlArray("progress")]
		[XmlArrayItem("ins_claim_report_progress")]
		public List<InsClaimReportProgress> Progress
		{
			get;
			set;
		}

		[XmlElement("report_reject_reason")]
		public string ReportRejectReason
		{
			get;
			set;
		}

		[XmlElement("reporter")]
		public InsPerson Reporter
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
