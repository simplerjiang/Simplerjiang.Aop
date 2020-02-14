using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAccountExrateRatequeryModel : AopObject
	{
		[XmlElement("currency_pair")]
		public string CurrencyPair
		{
			get;
			set;
		}
	}
}
