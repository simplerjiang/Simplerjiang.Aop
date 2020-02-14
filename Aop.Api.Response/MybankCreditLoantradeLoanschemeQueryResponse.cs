using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoantradeLoanschemeQueryResponse : AopResponse
	{
		[XmlArray("account_vo")]
		[XmlArrayItem("my_bk_account_v_o")]
		public List<MyBkAccountVO> AccountVo
		{
			get;
			set;
		}

		[XmlElement("alert_amt")]
		public string AlertAmt
		{
			get;
			set;
		}

		[XmlArray("charge_info_list")]
		[XmlArrayItem("loan_charge_info")]
		public List<LoanChargeInfo> ChargeInfoList
		{
			get;
			set;
		}

		[XmlElement("credit_expire_date")]
		public string CreditExpireDate
		{
			get;
			set;
		}

		[XmlElement("credit_lmt_amt")]
		public string CreditLmtAmt
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

		[XmlElement("credit_source")]
		public string CreditSource
		{
			get;
			set;
		}

		[XmlElement("credit_start_date")]
		public string CreditStartDate
		{
			get;
			set;
		}

		[XmlElement("int_rate")]
		public string IntRate
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

		[XmlElement("loanable_amt")]
		public string LoanableAmt
		{
			get;
			set;
		}

		[XmlElement("repay_mode_list")]
		public InstallmentValue RepayModeList
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

		[XmlElement("water_amt")]
		public string WaterAmt
		{
			get;
			set;
		}
	}
}
