using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayPcreditLoanRepayplanQueryModel : AopObject
	{
		[XmlElement("loan_apply_no")]
		public string LoanApplyNo
		{
			get;
			set;
		}
	}
}
