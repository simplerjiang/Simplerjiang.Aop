using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoantradeRepayCustApplyResponse : AopResponse
	{
		[XmlElement("ev_seq_no")]
		public string EvSeqNo
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
