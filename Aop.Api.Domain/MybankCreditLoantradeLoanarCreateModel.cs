using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoantradeLoanarCreateModel : AopObject
	{
		[XmlElement("account_ext_no")]
		public string AccountExtNo
		{
			get;
			set;
		}

		[XmlElement("account_fin_code")]
		public string AccountFinCode
		{
			get;
			set;
		}

		[XmlElement("account_fin_name")]
		public string AccountFinName
		{
			get;
			set;
		}

		[XmlElement("account_fin_type")]
		public string AccountFinType
		{
			get;
			set;
		}

		[XmlElement("account_name")]
		public string AccountName
		{
			get;
			set;
		}

		[XmlElement("account_no")]
		public string AccountNo
		{
			get;
			set;
		}

		[XmlElement("account_type")]
		public string AccountType
		{
			get;
			set;
		}

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

		[XmlElement("bsn_no")]
		public string BsnNo
		{
			get;
			set;
		}

		[XmlElement("bsn_type")]
		public string BsnType
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

		[XmlElement("grant_channel")]
		public string GrantChannel
		{
			get;
			set;
		}

		[XmlElement("industry")]
		public string Industry
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

		[XmlElement("need_check_account_same_name")]
		public bool NeedCheckAccountSameName
		{
			get;
			set;
		}

		[XmlElement("need_sign_contract")]
		public bool NeedSignContract
		{
			get;
			set;
		}

		[XmlElement("pd_code")]
		public string PdCode
		{
			get;
			set;
		}

		[XmlElement("pd_version")]
		public string PdVersion
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

		[XmlElement("repay_account")]
		public MyBkAccountVO RepayAccount
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

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("sign")]
		public string Sign
		{
			get;
			set;
		}

		[XmlElement("trans_memo")]
		public string TransMemo
		{
			get;
			set;
		}
	}
}
