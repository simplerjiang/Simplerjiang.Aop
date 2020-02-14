using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoantradeRepayCustApplyModel : AopObject
	{
		[XmlElement("apply_repay_fee")]
		public string ApplyRepayFee
		{
			get;
			set;
		}

		[XmlElement("apply_repay_int")]
		public string ApplyRepayInt
		{
			get;
			set;
		}

		[XmlElement("apply_repay_pre_fee")]
		public string ApplyRepayPreFee
		{
			get;
			set;
		}

		[XmlElement("apply_repay_prin")]
		public string ApplyRepayPrin
		{
			get;
			set;
		}

		[XmlElement("discount_amt")]
		public string DiscountAmt
		{
			get;
			set;
		}

		[XmlElement("ext_data")]
		public string ExtData
		{
			get;
			set;
		}

		[XmlElement("ip_id")]
		public string IpId
		{
			get;
			set;
		}

		[XmlElement("ip_role_id")]
		public string IpRoleId
		{
			get;
			set;
		}

		[XmlElement("loan_ar_no")]
		public string LoanArNo
		{
			get;
			set;
		}

		[XmlArray("prom_tools")]
		[XmlArrayItem("string")]
		public List<string> PromTools
		{
			get;
			set;
		}

		[XmlElement("repay_account")]
		public MyBkAccountVO RepayAccount
		{
			get;
			set;
		}

		[XmlElement("repay_type")]
		public string RepayType
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}
