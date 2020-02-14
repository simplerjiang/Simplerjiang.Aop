using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppProdmodeUnionbankQueryModel : AopObject
	{
		[XmlElement("bank_code")]
		public string BankCode
		{
			get;
			set;
		}
	}
}
