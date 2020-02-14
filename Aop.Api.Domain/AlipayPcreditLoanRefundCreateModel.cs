using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayPcreditLoanRefundCreateModel : AopObject
	{
		[XmlElement("loan_apply_no")]
		public string LoanApplyNo
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

		[XmlElement("repay_amt")]
		public string RepayAmt
		{
			get;
			set;
		}

		[XmlElement("req_id")]
		public string ReqId
		{
			get;
			set;
		}
	}
}
