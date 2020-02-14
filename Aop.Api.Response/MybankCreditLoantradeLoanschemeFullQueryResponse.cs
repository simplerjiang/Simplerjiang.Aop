using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoantradeLoanschemeFullQueryResponse : AopResponse
	{
		[XmlArray("contract_list")]
		[XmlArrayItem("contract")]
		public List<Contract> ContractList
		{
			get;
			set;
		}

		[XmlElement("data_sign")]
		public string DataSign
		{
			get;
			set;
		}

		[XmlElement("loan_scheme")]
		public LoanScheme LoanScheme
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

		[XmlElement("trans_in_account")]
		public MyBkAccountVO TransInAccount
		{
			get;
			set;
		}
	}
}
