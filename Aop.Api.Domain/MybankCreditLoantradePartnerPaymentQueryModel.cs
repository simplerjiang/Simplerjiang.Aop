using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoantradePartnerPaymentQueryModel : AopObject
	{
		[XmlElement("in_apply_no")]
		public string InApplyNo
		{
			get;
			set;
		}
	}
}
