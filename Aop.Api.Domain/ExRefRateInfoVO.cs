using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExRefRateInfoVO : AopObject
	{
		[XmlElement("currency_pair")]
		public string CurrencyPair
		{
			get;
			set;
		}

		[XmlElement("datum_currency")]
		public string DatumCurrency
		{
			get;
			set;
		}

		[XmlElement("price_type")]
		public string PriceType
		{
			get;
			set;
		}

		[XmlElement("pub_date")]
		public string PubDate
		{
			get;
			set;
		}

		[XmlElement("pub_time")]
		public string PubTime
		{
			get;
			set;
		}

		[XmlElement("rate")]
		public string Rate
		{
			get;
			set;
		}

		[XmlElement("target_currency")]
		public string TargetCurrency
		{
			get;
			set;
		}
	}
}
