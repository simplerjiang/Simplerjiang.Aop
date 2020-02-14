using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MemberShip : AopObject
	{
		[XmlElement("bank_card_no")]
		public string BankCardNo
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("email")]
		public string Email
		{
			get;
			set;
		}

		[XmlElement("mac")]
		public string Mac
		{
			get;
			set;
		}

		[XmlElement("mobile_phone_no")]
		public string MobilePhoneNo
		{
			get;
			set;
		}
	}
}
