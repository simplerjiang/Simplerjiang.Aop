using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PaymentAccountInfo : AopObject
	{
		[XmlElement("account_name")]
		public string AccountName
		{
			get;
			set;
		}

		[XmlElement("account_no")]
		public string AccountNo
		{
			get;
			set;
		}

		[XmlElement("account_type")]
		public string AccountType
		{
			get;
			set;
		}

		[XmlElement("amount")]
		public long Amount
		{
			get;
			set;
		}

		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}
	}
}
