using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoantradeLoanarrangementQueryResponse : AopResponse
	{
		[XmlElement("ar_status")]
		public string ArStatus
		{
			get;
			set;
		}

		[XmlElement("encash_amt")]
		public string EncashAmt
		{
			get;
			set;
		}

		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlArray("installment_repay_plans")]
		[XmlArrayItem("inst_repay_plan")]
		public List<InstRepayPlan> InstallmentRepayPlans
		{
			get;
			set;
		}

		[XmlElement("interest")]
		public string Interest
		{
			get;
			set;
		}

		[XmlArray("interest_rates")]
		[XmlArrayItem("installment_meta_info")]
		public List<InstallmentMetaInfo> InterestRates
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

		[XmlElement("loan_term")]
		public string LoanTerm
		{
			get;
			set;
		}

		[XmlElement("ovd_days")]
		public string OvdDays
		{
			get;
			set;
		}

		[XmlElement("overdue_interest_penalty")]
		public string OverdueInterestPenalty
		{
			get;
			set;
		}

		[XmlElement("overdue_principal_penalty")]
		public string OverduePrincipalPenalty
		{
			get;
			set;
		}

		[XmlElement("principal")]
		public string Principal
		{
			get;
			set;
		}

		[XmlArray("repay_modes")]
		[XmlArrayItem("installment_meta_info")]
		public List<InstallmentMetaInfo> RepayModes
		{
			get;
			set;
		}

		[XmlArray("start_date")]
		[XmlArrayItem("string")]
		public List<string> StartDate
		{
			get;
			set;
		}
	}
}
