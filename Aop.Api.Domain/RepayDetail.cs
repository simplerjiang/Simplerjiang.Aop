using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RepayDetail : AopObject
	{
		[XmlElement("capital_amount")]
		public string CapitalAmount
		{
			get;
			set;
		}

		[XmlElement("contract_no")]
		public string ContractNo
		{
			get;
			set;
		}

		[XmlElement("interest_amount")]
		public string InterestAmount
		{
			get;
			set;
		}

		[XmlElement("loan_year")]
		public string LoanYear
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}
	}
}
