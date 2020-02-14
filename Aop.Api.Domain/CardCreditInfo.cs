using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CardCreditInfo : AopObject
	{
		[XmlElement("allowoverpay")]
		public string Allowoverpay
		{
			get;
			set;
		}

		[XmlElement("creditquota")]
		public string Creditquota
		{
			get;
			set;
		}
	}
}
