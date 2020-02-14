using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoantradeRepayBudgetQueryModel : AopObject
	{
		[XmlElement("apply_repay_prin")]
		public string ApplyRepayPrin
		{
			get;
			set;
		}

		[XmlElement("budget_type")]
		public string BudgetType
		{
			get;
			set;
		}

		[XmlElement("can_repay_flag")]
		public bool CanRepayFlag
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
	}
}
