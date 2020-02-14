using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsClaim : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("claim_fee")]
		public long ClaimFee
		{
			get;
			set;
		}

		[XmlElement("claim_no")]
		public string ClaimNo
		{
			get;
			set;
		}

		[XmlElement("claim_pay_time")]
		public string ClaimPayTime
		{
			get;
			set;
		}

		[XmlArray("claim_progress")]
		[XmlArrayItem("claim_progress")]
		public List<ClaimProgress> ClaimProgress
		{
			get;
			set;
		}

		[XmlElement("claim_status")]
		public string ClaimStatus
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

		[XmlElement("reject_reason")]
		public string RejectReason
		{
			get;
			set;
		}
	}
}
