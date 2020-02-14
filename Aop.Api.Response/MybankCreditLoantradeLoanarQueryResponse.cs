using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoantradeLoanarQueryResponse : AopResponse
	{
		[XmlElement("arg_status")]
		public string ArgStatus
		{
			get;
			set;
		}

		[XmlArray("instal_int_rate")]
		[XmlArrayItem("installment_meta_info")]
		public List<InstallmentMetaInfo> InstalIntRate
		{
			get;
			set;
		}

		[XmlArray("installment_repay_plans")]
		[XmlArrayItem("installment_repay_plan")]
		public List<InstallmentRepayPlan> InstallmentRepayPlans
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

		[XmlElement("nom_int")]
		public string NomInt
		{
			get;
			set;
		}

		[XmlElement("nom_prin")]
		public string NomPrin
		{
			get;
			set;
		}

		[XmlElement("ovd_int")]
		public string OvdInt
		{
			get;
			set;
		}

		[XmlElement("ovd_int_pen_int")]
		public string OvdIntPenInt
		{
			get;
			set;
		}

		[XmlElement("ovd_prin")]
		public string OvdPrin
		{
			get;
			set;
		}

		[XmlElement("ovd_prin_pen_int")]
		public string OvdPrinPenInt
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
	}
}
