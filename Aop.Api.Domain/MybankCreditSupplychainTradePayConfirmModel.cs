using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditSupplychainTradePayConfirmModel : AopObject
	{
		[XmlElement("buyer")]
		public Member Buyer
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

		[XmlElement("prepay_order_no")]
		public string PrepayOrderNo
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
