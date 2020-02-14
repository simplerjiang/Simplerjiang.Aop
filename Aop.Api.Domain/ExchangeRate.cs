using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExchangeRate : AopObject
	{
		[XmlElement("base_currency")]
		public string BaseCurrency
		{
			get;
			set;
		}

		[XmlElement("exchange_currency")]
		public string ExchangeCurrency
		{
			get;
			set;
		}

		[XmlElement("rate")]
		public long Rate
		{
			get;
			set;
		}
	}
}
