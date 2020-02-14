using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoantradeLoanschemeFullQueryModel : AopObject
	{
		[XmlElement("alipay_id")]
		public string AlipayId
		{
			get;
			set;
		}

		[XmlElement("apply_amt")]
		public string ApplyAmt
		{
			get;
			set;
		}

		[XmlElement("apply_date")]
		public string ApplyDate
		{
			get;
			set;
		}

		[XmlElement("credit_no")]
		public string CreditNo
		{
			get;
			set;
		}

		[XmlElement("cust_group")]
		public string CustGroup
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

		[XmlElement("loan_policy_code")]
		public string LoanPolicyCode
		{
			get;
			set;
		}

		[XmlElement("loan_term")]
		public long LoanTerm
		{
			get;
			set;
		}

		[XmlElement("loan_term_unit")]
		public string LoanTermUnit
		{
			get;
			set;
		}

		[XmlArray("promo_tools")]
		[XmlArrayItem("string")]
		public List<string> PromoTools
		{
			get;
			set;
		}

		[XmlElement("repay_mode")]
		public string RepayMode
		{
			get;
			set;
		}

		[XmlElement("sale_pd_code")]
		public string SalePdCode
		{
			get;
			set;
		}

		[XmlElement("trans_in_account")]
		public MyBkAccountVO TransInAccount
		{
			get;
			set;
		}
	}
}
