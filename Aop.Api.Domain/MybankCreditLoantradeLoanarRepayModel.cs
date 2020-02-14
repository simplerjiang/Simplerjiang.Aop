using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoantradeLoanarRepayModel : AopObject
	{
		[XmlElement("cust_iprole_id")]
		public string CustIproleId
		{
			get;
			set;
		}

		[XmlElement("date")]
		public string Date
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

		[XmlElement("prin_amt")]
		public string PrinAmt
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
