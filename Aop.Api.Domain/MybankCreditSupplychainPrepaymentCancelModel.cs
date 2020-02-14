using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSupplychainPrepaymentCancelModel : AopObject
	{
		[XmlElement("buyer")]
		public Member Buyer
		{
			get;
			set;
		}

		[XmlElement("prepay_apply_no")]
		public string PrepayApplyNo
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
