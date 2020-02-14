using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoantradeLoanarQueryModel : AopObject
	{
		[XmlElement("iproleid")]
		public string Iproleid
		{
			get;
			set;
		}

		[XmlElement("loanarno")]
		public string Loanarno
		{
			get;
			set;
		}
	}
}
