using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsDataAutoFraudSyncModel : AopObject
	{
		[XmlElement("avoid_loss_amount")]
		public string AvoidLossAmount
		{
			get;
			set;
		}

		[XmlElement("avoid_loss_type")]
		public string AvoidLossType
		{
			get;
			set;
		}

		[XmlElement("case_end_amount")]
		public string CaseEndAmount
		{
			get;
			set;
		}

		[XmlElement("fraud_query_request_no")]
		public string FraudQueryRequestNo
		{
			get;
			set;
		}

		[XmlElement("fraud_result")]
		public string FraudResult
		{
			get;
			set;
		}

		[XmlElement("report_no")]
		public string ReportNo
		{
			get;
			set;
		}

		[XmlElement("request_no")]
		public string RequestNo
		{
			get;
			set;
		}

		[XmlElement("syn_type")]
		public string SynType
		{
			get;
			set;
		}
	}
}
