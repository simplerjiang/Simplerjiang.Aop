using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoantradeLoanarrangementQueryModel : AopObject
	{
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
