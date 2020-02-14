using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ApproveCreditResult : AopObject
	{
		[XmlArray("charge_info_list")]
		[XmlArrayItem("loan_charge_info")]
		public List<LoanChargeInfo> ChargeInfoList
		{
			get;
			set;
		}

		[XmlElement("credit_amt")]
		public string CreditAmt
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

		[XmlElement("credit_term")]
		public string CreditTerm
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
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

		[XmlElement("loan_term")]
		public string LoanTerm
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

		[XmlElement("start_date")]
		public string StartDate
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
