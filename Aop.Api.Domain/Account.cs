using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Account : AopObject
	{
		[XmlElement("account_ext")]
		public string AccountExt
		{
			get;
			set;
		}

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
	}
}
