using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSupplychainPrepaymentApplyModel : AopObject
	{
		[XmlElement("buyer")]
		public Member Buyer
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

		[XmlElement("loan_pay_amount")]
		public string LoanPayAmount
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
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

		[XmlElement("self_pay_amount")]
		public string SelfPayAmount
		{
			get;
			set;
		}
	}
}
